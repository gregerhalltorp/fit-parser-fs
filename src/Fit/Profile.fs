namespace Fit

open DomainTypes
open DomainTypes.Field
open System

module Profile =
    let SubfieldIndexActiveSubfield = 0xFFFEus
    let BaseTypeNumMask = 0x1Fuy
    let StringType = 0x07uy

    type ProductSubField =
        | FaveroProduct = 0us
        | GarminProduct = 1us
        | SubFields = 2us
        | Active = 65534us
        | MainField = 65535us

    type FieldDefNum =
        | Type = 0uy
        | Manufacturer = 1uy
        | Product = 2uy
        | SerialNumber = 3uy
        | TimeCreated = 4uy
        | Number = 5uy
        | ProductName = 8uy
        | Invalid = 255uy

    let baseProfileMessageBase =
        { LocalNum = LocalNum 0uy
          SystemTimeOffset = SystemTimeOffset 0u
          Name = Name ""
          Num = MesgNum.FileId
          Fields = [] }

    let getFileIdMessage () =
        { baseProfileMessageBase with
              Name = Name "FileId"
              Num = MesgNum.FileId
              Fields =
                  [ { baseField with
                          Name = Name "Type"
                          ProfileType = File }
                    { baseField with
                          Name = Name "Manufacturer"
                          Num = Num 1uy
                          Type = Field.Type 132uy
                          ProfileType = Manufacturer }
                    { baseField with
                          Name = Name "Product"
                          Num = Num 2uy
                          Type = Field.Type 132uy
                          ProfileType = Uint16
                          SubFields =
                              [ { Name = Name "FaveroProduct"
                                  Type = Field.Type 132uy
                                  Scale = Scale 1.0
                                  Offset = Offset 0.0
                                  Units = Units ""
                                  Maps =
                                      [ { RefFieldNum = RefFieldNum 1uy
                                          RefFieldValue = RefFieldValue 263 } ] }
                                { Name = Name "GarminProduct"
                                  Type = Field.Type 132uy
                                  Scale = Scale 1.0
                                  Offset = Offset 0.0
                                  Units = Units ""
                                  Maps =
                                      [ { RefFieldNum = RefFieldNum 1uy
                                          RefFieldValue = RefFieldValue 1 }
                                        { RefFieldNum = RefFieldNum 1uy
                                          RefFieldValue = RefFieldValue 15 }
                                        { RefFieldNum = RefFieldNum 1uy
                                          RefFieldValue = RefFieldValue 13 } ] } ] }
                    { baseField with
                          Name = Name "SerialNumber"
                          Num = Num 3uy
                          Type = Field.Type 140uy
                          ProfileType = Uint32z }
                    { baseField with
                          Name = Name "TimeCreated"
                          Num = Num 4uy
                          Type = Field.Type 134uy
                          ProfileType = ProfileType.DateTime }
                    { baseField with
                          Name = Name "Number"
                          Num = Num 5uy
                          Type = Field.Type 132uy
                          ProfileType = Uint16 }
                    { baseField with
                          Name = Name "ProductName"
                          Num = Num 8uy
                          Type = Field.Type 7uy
                          ProfileType = ProfileType.String } ] }

    let removeEmptyFieldsFromMessage (message: ProfileMessage) =
        { message with
              Fields =
                  message.Fields
                  |> List.filter (fun field -> getNumValues field > 0) }

    let tryGetField fieldNum message =
        message.Fields
        |> List.tryFind (fun f -> f.Num = fieldNum)

    let getField fieldNum message =
        message.Fields
        |> List.find (fun f -> f.Num = fieldNum)

    let getValue baseTypeNum size (data: byte array) =
        match baseTypeNum with
        | FieldTypes.Enum
        | FieldTypes.Byte
        | FieldTypes.UInt8
        | FieldTypes.UInt8z ->
            (FieldValue data.[0], 1)
        | FieldTypes.SInt8 ->
            (FieldValue(sbyte data.[0]), 1)
        | FieldTypes.SInt16 ->
            (FieldValue(BitConverter.ToInt16(data, 0)), 2) // Need to implement handling of little-endian cases
        | FieldTypes.UInt16
        | FieldTypes.UInt16z ->
            (FieldValue(BitConverter.ToUInt16(data, 0)), 2)
        | FieldTypes.SInt32 ->
            (FieldValue(BitConverter.ToInt32(data, 0)), 4)
        | FieldTypes.UInt32
        | FieldTypes.UInt32z ->
            (FieldValue(BitConverter.ToUInt32(data, 0)), 4)
        | FieldTypes.SInt64 ->
            (FieldValue(BitConverter.ToInt64(data, 0)), 8)
        | FieldTypes.UInt64
        | FieldTypes.UInt64z ->
            (FieldValue(BitConverter.ToUInt64(data, 0)), 8)
        | FieldTypes.Float32 ->
            (FieldValue(BitConverter.ToSingle(data, 0)), 4)
        | FieldTypes.Float64 ->
            (FieldValue(BitConverter.ToDouble(data, 0)), 8)
        | _ -> (FieldValue data.[0..size - 1], size)

    let rec tryReadValue numFieldsToRead
                         alwaysKeepValues
                         (values: FieldValue list)
                         (data: byte array)
                         size
                         (Type fieldType)
                         =
        match numFieldsToRead with
        | 0 -> values
        | _ ->
            let baseTypeNum = fieldType &&& BaseTypeNumMask
            let (fieldValue, fieldSize) = getValue baseTypeNum size data

            let invalidValue =
                BaseType.[int baseTypeNum].InvalidValue = InvalidValue fieldValue

            let shouldKeepValue = not invalidValue || alwaysKeepValues
            match shouldKeepValue with
            | true ->
                tryReadValue
                    (numFieldsToRead - 1)
                    alwaysKeepValues
                    (values @ [ fieldValue ])
                    data.[fieldSize..]
                    size
                    (Field.Type fieldType)
            | false -> tryReadValue (numFieldsToRead - 1) alwaysKeepValues values data.[1..] size (Field.Type fieldType)


    let readFieldValue size (data: byte array) (field: Field) =
        let (Type fieldType) = field.Type
        let baseType = fieldType &&& BaseTypeNumMask
        if baseType = StringType then
            printfn "this was a string, it needs to be implemented"
            field
        else
            let (Size baseTypeSize) = BaseType.[int baseType].Size
            let numElements = int (size / baseTypeSize)
            let alwaysKeepValues = numElements > 1
            printfn "number of elements: %i" numElements
            { field with
                  Values = (tryReadValue numElements alwaysKeepValues [] data (int size) field.Type) }

    let parseMessage (data: byte array) (definition: MessageDefinition) =
        match definition.GlobalMsgNum with
        | MesgNum.FileId ->
            printfn "\tfileId thingy"

            let message =
                getFileIdMessage ()
                |> removeEmptyFieldsFromMessage

            let newFields =
                definition.Fields
                |> List.map (fun fieldDefinition ->
                    match message |> tryGetField (Num fieldDefinition.Num) with
                    | Some field -> field
                    | None ->
                        match message.Num with
                        | MesgNum.FileId ->
                            match getFileIdMessage ()
                                  |> tryGetField (Num fieldDefinition.Num) with
                            | Some field -> field
                            | None ->
                                { unknownField with
                                      Num = Num fieldDefinition.Num
                                      Type = Field.Type fieldDefinition.Type }
                        | _ -> baseField
                    |> fun field ->
                        match field.Type = Field.Type fieldDefinition.Type with
                        | true -> field
                        | false ->
                            printfn "There was a type mismatch" // TODO: Implement this
                            field
                    |> readFieldValue fieldDefinition.Size data)

            { message with
                  LocalNum = LocalNum definition.LocalMsgNum
                  Fields = newFields }
        | MesgNum.FileCreator ->
            printfn "\tfilecreator thingy"
            baseProfileMessageBase
        | _ -> 
            printfn "\tnot fileId -> returning baseProfileMessage"
            baseProfileMessageBase
