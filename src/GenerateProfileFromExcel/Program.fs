module GenerateProfileFromExcel
// Learn more about F# at http://fsharp.org
open FSharp.Interop.Excel
//open FSharp.Interop.Excel.ExcelProvider
open System
open System.IO
//open ExcelDataReader

type ExcelProfile = ExcelFile<"Profile.xlsx", "Types">
exception NoTypeException of string

let getPassableString (theString: string) =
    if theString.[0] < '0' || theString.[0] > '9'
    then theString
    else "_" + theString

let snakeToPascal (input: string) =
    input.Split('_')
    |> Array.map (fun s -> String.Join("", [| (s.[0..0]).ToUpper(); s.[1..] |]))
    |> Array.reduce (+)
    |> getPassableString

type TypeRepresentation = { long: string; short: string }

let typeStrings =
    Map.empty.Add("enum", { long = "enum"; short = "uy" }).Add("uint16", { long = "uint16"; short = "us" })
       .Add("uint8", { short = "uy"; long = "byte" }).Add("uint8z", { short = "uy"; long = "byte" })
       .Add("uint32", { short = "u"; long = "int" }).Add("uint32z", { short = "u"; long = "int" })

type Variable = { name: string; value: string }

type Module =
    { name: string
      typeName: string
      values: Variable list }

type Constant = { name: string; typeName: string }

type Thingy =
    | Constant of Constant
    | Module of Module


let addValueToConstant state value =
    Thingy.Module
        { name = state.name
          typeName = state.typeName
          values = [ value ] }
    |> Some

let addValueToModule state value =
    let newValues = List.concat [ state.values; [ value ] ] //value :: state.Values
    Thingy.Module { state with values = newValues }
    |> Some

let convertToLine thing =
    match thing with
    | Constant state ->
        let constDef =
            sprintf "\n  type %s = %s of %s" state.name state.name typeStrings.[state.typeName].long

        [ constDef ]
    | Module { name = modName; typeName = typeName; values = values } ->
        let modDef = sprintf "\n  module %s =" modName
        let ttu = typeStrings.[typeName].short

        let valDefs =
            values
            |> List.collect (fun { name = valName; value = value } ->
                let literal = sprintf "    [<Literal>]"

                let def =
                    sprintf "    let %s = %s%s" valName value ttu

                [ literal; def ])

        List.concat [ [ modDef ]; valDefs ]

let convertToLines things = things |> List.collect convertToLine

// [<Literal>]\n  let %s = %s%s" name exprValue ttu
let rec getThings (rows: ExcelProfile.Row list) things lastThing =
    match rows with
    | [] -> things
    | row :: rest ->
        match row.GetValue 0 with
        | null ->
            match row.GetValue 2 with
            | null ->
                match lastThing with
                | None -> getThings rest things None
                | Some oldThing -> getThings rest (List.concat [ things; [ oldThing ] ]) None
            | value ->
                match lastThing with
                | None -> raise (NoTypeException("value line but no previous constant, bailing"))
                | Some thingy ->
                    let varName = value |> string |> snakeToPascal
                    let varValue = row.GetValue 3 |> string
                    let value = { name = varName; value = varValue }

                    let newThing =
                        match thingy with
                        | Constant state -> addValueToConstant state value
                        | Module state -> addValueToModule state value

                    getThings rest things newThing

        | value ->
            let typeName = row.GetValue 1 |> string
            let name = value |> string |> snakeToPascal

            let thing =
                Thingy.Constant { name = name; typeName = typeName }
                |> Some

            match lastThing with
            | None -> getThings rest things thing
            | Some oldThing -> getThings rest (List.concat [ things; [ oldThing ] ]) thing

[<EntryPoint>]
let main argv =
    let file = ExcelProfile()
    let rows = file.Data |> Seq.toList //Seq.toArray


    printfn "Reading..."
    let things = getThings rows [] None
    printfn "Generating lines..."

    let lines =
        List.concat [ [ "namespace Fit"
                        ""
                        "module ProfileTypes =" ]
                      (things |> convertToLines) ]
    // lines |> List.iter Console.WriteLine
    printfn "Writing..."
    File.WriteAllLines("ProfileTypes.fs", lines)
    printfn "Done!"
    0 // return an integer exit code
