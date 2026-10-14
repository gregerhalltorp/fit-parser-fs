module GenerateProfileFromExcel

open System
open System.Globalization
open System.IO
open FSharp.Interop.Excel

// Reads the Types and Messages sheets of the FIT SDK's Profile.xlsx and generates
// Fit2/Profile/Types.fs (enums) and Fit2/Profile/Messages.fs (message profiles)

type TypesSheet = ExcelFile<"Profile.xlsx", "Types">
type MessagesSheet = ExcelFile<"Profile.xlsx", "Messages">

let invariant = CultureInfo.InvariantCulture

// ---------- Reading ----------

let toCells (getValue: int -> obj) count =
    Array.init count (fun i ->
        match getValue i with
        | null -> ""
        | value -> Convert.ToString(value, invariant).Trim())

/// Splits a cell holding a comma separated list, keeping empty entries so positions still line up
let splitList (cell: string) =
    if cell = "" then [] else cell.Split(',') |> Array.map (fun s -> s.Trim()) |> List.ofArray

let tryNth index list =
    List.tryItem index list |> Option.filter (fun s -> s <> "")

let parseFloat (s: string) = Double.Parse(s, invariant)

let parseNumber (s: string) =
    if s.StartsWith("0x") then Convert.ToInt64(s.Substring 2, 16) else Int64.Parse(s, invariant)

// ---------- Types sheet ----------

type TypeDef =
    { name: string
      baseType: string
      values: (string * string) list }

// Columns: Type Name | Base Type | Value Name | Value | Comment
let readTypes (rows: string [] list) =
    let finish current types =
        match current with
        | Some t -> { t with values = List.rev t.values } :: types
        | None -> types

    let folder (types, current) (row: string []) =
        match row.[0], row.[2] with
        | "", "" -> (types, current)
        | "", valueName ->
            match current with
            | Some t -> (types, Some { t with values = (valueName, row.[3]) :: t.values })
            | None -> failwithf "Value %s appears before any type" valueName
        | typeName, _ -> (finish current types, Some { name = typeName; baseType = row.[1]; values = [] })

    let (types, current) = List.fold folder ([], None) rows
    finish current types |> List.rev

// ---------- Messages sheet ----------

type FieldRow =
    { num: string
      name: string
      fieldType: string
      array: string
      components: string
      scale: string
      offset: string
      units: string
      bits: string
      accumulate: string
      refFieldNames: string
      refFieldValues: string }

type FieldDef = { row: FieldRow; subFields: FieldRow list }

type MessageDef = { name: string; fields: FieldDef list }

// Columns: Message Name | Field Def # | Field Name | Field Type | Array | Components | Scale | Offset
//          | Units | Bits | Accumulate | Ref Field Name | Ref Field Value | ...
let toFieldRow (row: string []) =
    { num = row.[1]
      name = row.[2]
      fieldType = row.[3]
      array = row.[4]
      components = row.[5]
      scale = row.[6]
      offset = row.[7]
      units = row.[8]
      bits = row.[9]
      accumulate = row.[10]
      refFieldNames = row.[11]
      refFieldValues = row.[12] }

let readMessages (rows: string [] list) =
    // Everything is collected in reverse and put back in order once a message is complete
    let finish current messages =
        match current with
        | Some (m: MessageDef) ->
            let fields =
                m.fields |> List.rev |> List.map (fun f -> { f with subFields = List.rev f.subFields })

            { m with fields = fields } :: messages
        | None -> messages

    let folder (messages, current) (row: string []) =
        match row.[0], row.[1], row.[2], current with
        | messageName, _, _, _ when messageName <> "" -> (finish current messages, Some { name = messageName; fields = [] })
        | _, num, _, Some m when num <> "" ->
            (messages, Some { m with fields = { row = toFieldRow row; subFields = [] } :: m.fields })
        | _, _, subName, Some ({ fields = field :: rest } as m) when subName <> "" ->
            let field = { field with subFields = toFieldRow row :: field.subFields }
            (messages, Some { m with fields = field :: rest })
        | _, _, name, _ when name <> "" -> failwithf "Field %s is not part of a message" name
        // Blank rows and section headings ("COMMON MESSAGES" etc.)
        | _ -> (messages, current)

    let (messages, current) = List.fold folder ([], None) rows
    finish current messages |> List.rev

// ---------- Resolving ----------

let baseTypeNames =
    [ "enum"; "sint8"; "uint8"; "sint16"; "uint16"; "sint32"; "uint32"; "string"; "float32"; "float64"
      "uint8z"; "uint16z"; "uint32z"; "byte"; "sint64"; "uint64"; "uint64z"; "bool" ]

/// F# representation of the base types that profile types (enums) are built on
let enumRepresentation baseType =
    match baseType with
    | "enum"
    | "uint8"
    | "uint8z" -> ("byte", "uy")
    | "uint16"
    | "uint16z" -> ("uint16", "us")
    | "uint32"
    | "uint32z" -> ("uint32", "u")
    | other -> failwithf "No enum representation for base type %s" other

let toPascal (snake: string) =
    let pascal =
        snake.Split([| '_'; ' '; '-' |], StringSplitOptions.RemoveEmptyEntries)
        |> Array.map (fun s -> string (Char.ToUpperInvariant s.[0]) + s.Substring 1)
        |> String.concat ""

    if Char.IsDigit pascal.[0] then "_" + pascal else pascal

type Resolver(types: TypeDef list) =
    let typesByName =
        types |> List.map (fun t -> t.name, t) |> Map.ofList

    let mesgNums =
        typesByName.["mesg_num"].values |> Map.ofList

    member _.fitBaseType(fieldType: string) =
        match fieldType with
        | "bool" -> "Enum"
        | t when List.contains t baseTypeNames -> toPascal t
        | t ->
            match typesByName.TryFind t with
            | Some typeDef -> toPascal typeDef.baseType
            | None -> failwithf "Unknown field type %s" t

    member _.mesgNumExists messageName = mesgNums.ContainsKey messageName

    /// The numeric value of a named value of a profile type, or the number itself for base types
    member _.value (fieldType: string) (valueName: string) =
        match typesByName.TryFind fieldType with
        | Some typeDef ->
            match List.tryFind (fun (name, _) -> name = valueName) typeDef.values with
            | Some (_, value) -> parseNumber value
            | None -> failwithf "Type %s has no value %s" fieldType valueName
        | None -> parseNumber valueName

// ---------- Emitting ----------

let formatFloat (x: float) =
    let s = x.ToString("R", invariant)
    if s.Contains(".") || s.Contains("E") then s else s + ".0"

let quote (s: string) =
    "\"" + s.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\""

let indent n lines =
    let pad = String(' ', n)
    lines |> List.map (fun l -> pad + l)

let appendToLast suffix lines =
    match List.rev lines with
    | last :: rest -> List.rev ((last + suffix) :: rest)
    | [] -> [ suffix ]

/// A list literal whose items may span several lines
let listLines (items: string list list) =
    match items with
    | [] -> [ "[]" ]
    | _ ->
        items
        |> List.mapi (fun i item ->
            let prefix = if i = 0 then "[ " else "  "
            (prefix + List.head item) :: indent 2 (List.tail item))
        |> List.concat
        |> appendToLast " ]"

/// A copy-and-update record expression, `{ baseName with ... }`, listing only the given properties
let recordLines baseName (props: (string * string list) list) =
    let propLines =
        props
        |> List.collect (fun (name, value) ->
            match value with
            | [ single ] -> [ sprintf "%s = %s" name single ]
            | lines -> (name + " =") :: indent 2 lines)

    (sprintf "{ %s with" baseName :: indent 4 propLines)
    |> appendToLast " }"

let optionalProp name isDefault value =
    if isDefault then [] else [ (name, value) ]

type MessageEmitter(resolver: Resolver, message: MessageDef) =
    let fieldsByName =
        message.fields |> List.map (fun f -> f.row.name, f.row) |> Map.ofList

    let fieldNum name =
        match fieldsByName.TryFind name with
        | Some row -> row.num
        | None -> failwithf "Message %s has no field %s" message.name name

    let componentLines (row: FieldRow) =
        let names = splitList row.components
        let scales = splitList row.scale
        let offsets = splitList row.offset
        let units = splitList row.units
        let bits = splitList row.bits
        let accumulate = splitList row.accumulate

        names
        |> List.mapi (fun i name ->
            let scale = tryNth i scales |> Option.map parseFloat |> Option.defaultValue 1.0
            let offset = tryNth i offsets |> Option.map parseFloat |> Option.defaultValue 0.0
            let unit = tryNth i units |> Option.defaultValue ""

            recordLines
                "baseComponent"
                ([ ("fieldNum", [ fieldNum name + "uy" ]) ]
                 @ optionalProp "scale" (scale = 1.0) [ formatFloat scale ]
                 @ optionalProp "offset" (offset = 0.0) [ formatFloat offset ]
                 @ optionalProp "units" (unit = "") [ quote unit ]
                 @ optionalProp "bits" (tryNth i bits = None) [ defaultArg (tryNth i bits) "" ]
                 @ optionalProp "isAccumulated" (tryNth i accumulate <> Some "1") [ "true" ]))

    // Scale, offset and units describe the components when there are several of them.
    // With a single component they also apply to the field itself, as in the SDK
    let scalingProps (row: FieldRow) =
        if List.length (splitList row.components) > 1 then
            []
        else
            let scale = tryNth 0 (splitList row.scale) |> Option.map parseFloat |> Option.defaultValue 1.0
            let offset = tryNth 0 (splitList row.offset) |> Option.map parseFloat |> Option.defaultValue 0.0
            let unit = tryNth 0 (splitList row.units) |> Option.defaultValue ""

            optionalProp "scale" (scale = 1.0) [ formatFloat scale ]
            @ optionalProp "offset" (offset = 0.0) [ formatFloat offset ]
            @ optionalProp "units" (unit = "") [ quote unit ]

    let typeProps (row: FieldRow) =
        [ ("fieldType", [ "FitBaseType." + resolver.fitBaseType row.fieldType ])
          ("profileType", [ "ProfileType." + toPascal row.fieldType ]) ]

    let componentsProp row =
        let components = componentLines row
        optionalProp "components" (List.isEmpty components) (listLines components)

    let subFieldLines (sub: FieldRow) =
        let refNames = splitList sub.refFieldNames
        let refValues = splitList sub.refFieldValues

        if List.length refNames <> List.length refValues then
            failwithf "Subfield %s.%s has %i ref fields but %i ref values" message.name sub.name refNames.Length refValues.Length

        let maps =
            List.zip refNames refValues
            |> List.map (fun (refName, refValue) ->
                let value = resolver.value fieldsByName.[refName].fieldType refValue
                [ sprintf "{ refFieldNum = %suy; refFieldValue = %iL }" (fieldNum refName) value ])

        recordLines
            "baseSubField"
            ([ ("name", [ quote (toPascal sub.name) ]) ]
             @ typeProps sub
             @ scalingProps sub
             @ componentsProp sub
             @ [ ("maps", listLines maps) ])

    let fieldLines (field: FieldDef) =
        let row = field.row
        let accumulated = splitList row.components |> List.isEmpty && row.accumulate = "1"

        recordLines
            "baseField"
            ([ ("name", [ quote (toPascal row.name) ])
               ("num", [ row.num + "uy" ]) ]
             @ typeProps row
             @ scalingProps row
             @ optionalProp "isAccumulated" (not accumulated) [ "true" ]
             @ optionalProp "isArray" (row.array = "") [ "true" ]
             @ componentsProp row
             @ optionalProp "subFields" (List.isEmpty field.subFields) (listLines (List.map subFieldLines field.subFields)))

    member _.lines =
        let name = toPascal message.name

        let record =
            recordLines
                "dataMessageBase"
                [ ("name", [ quote name ])
                  ("number", [ "MesgNum." + name ])
                  ("fields", listLines (List.map fieldLines message.fields)) ]

        (sprintf "let %s =" name :: indent 2 record) @ [ "" ]

let header =
    [ "// This file is generated by GenerateProfileFromExcel from the FIT SDK's Profile.xlsx."
      "// Do not edit it by hand, change the generator and run it again." ]

let typesFile (types: TypeDef list) =
    let typeLines (t: TypeDef) =
        let (fsType, suffix) = enumRepresentation t.baseType

        match t.values with
        // Types without named values are plain numbers
        | [] -> [ sprintf "type %s = %s" (toPascal t.name) fsType; "" ]
        | values ->
            (sprintf "type %s =" (toPascal t.name)
             :: (values |> List.map (fun (name, value) -> sprintf "  | %s = %s%s" (toPascal name) value suffix)))
            @ [ "" ]

    let profileTypeLines =
        [ "/// Every type a field can have: the base types plus the types above"
          "[<RequireQualifiedAccess>]"
          "type ProfileType =" ]
        @ (baseTypeNames @ (types |> List.map (fun t -> t.name))
           |> List.map (fun name -> "  | " + toPascal name))

    header
    @ [ ""; "namespace Fit2.Profile"; "" ]
    @ List.collect typeLines types
    @ profileTypeLines

let messagesFile resolver (messages: MessageDef list) =
    let names =
        messages |> List.map (fun m -> toPascal m.name)

    header
    @ [ ""
        "namespace Fit2.Profile"
        ""
        "open Fit2.TypeDefinitions"
        ""
        "module Messages ="
        "" ]
    @ indent 2 (messages |> List.collect (fun m -> MessageEmitter(resolver, m).lines))
    @ indent 2 ([ "let all =" ] @ indent 2 (listLines (List.map List.singleton names)))
    @ [ ""
        "  let byNumber ="
        "    all |> List.map (fun m -> m.number, m) |> Map.ofList" ]

// Generated lines can be indented without content, keep the output free of trailing whitespace
let writeFile path (lines: string list) =
    File.WriteAllLines(path, lines |> List.map (fun l -> l.TrimEnd()))
    printfn "Wrote %s" (Path.GetFullPath path)

[<EntryPoint>]
let main argv =
    let excelPath = Path.Combine(__SOURCE_DIRECTORY__, "Profile.xlsx")

    let outDir =
        match argv with
        | [| dir |] -> dir
        | _ -> Path.Combine(__SOURCE_DIRECTORY__, "..", "Fit2", "Profile")

    printfn "Reading %s..." excelPath

    let types =
        TypesSheet(excelPath).Data
        |> Seq.map (fun row -> toCells row.GetValue 4)
        |> List.ofSeq
        |> readTypes

    let resolver = Resolver(types)

    let messages =
        MessagesSheet(excelPath).Data
        |> Seq.map (fun row -> toCells row.GetValue 13)
        |> List.ofSeq
        |> readMessages

    // Messages without a message number can't appear in a file, so there's nothing to generate for them
    let (known, unknown) =
        messages |> List.partition (fun m -> resolver.mesgNumExists m.name)

    for m in unknown do
        eprintfn "Warning: skipping message %s, it has no mesg_num value" m.name

    printfn "Read %i types and %i messages" types.Length known.Length

    Directory.CreateDirectory outDir |> ignore
    writeFile (Path.Combine(outDir, "Types.fs")) (typesFile types)
    writeFile (Path.Combine(outDir, "Messages.fs")) (messagesFile resolver known)
    0
