namespace Fit

open System

module DomainTypes =
    type ProfileType =
        | DateTime
        | Enum
        | File
        | Manufacturer
        | String
        | Uint16
        | Uint32z

    type Name = Name of string

    module Field =
        type Type = Type of byte
        type Scale = Scale of double
        type Offset = Offset of double
        type Units = Units of string
        type IsAccumulated = IsAccumulated of bool
        type Num = Num of byte
        type RefFieldNum = RefFieldNum of byte
        type RefFieldValue = RefFieldValue of int // This will need to be updated at some point
        type FieldValue = FieldValue of obj

        type SubFieldMap =
            { RefFieldNum: RefFieldNum
              RefFieldValue: RefFieldValue }

        type SubField =
            { Name: Name
              Type: Type
              Scale: Scale
              Offset: Offset
              Units: Units
              Maps: SubFieldMap list }

        type Field =
            { Name: Name
              Num: Num
              Type: Type
              Scale: Scale
              Offset: Offset
              Units: Units
              IsAccumulated: IsAccumulated
              ProfileType: ProfileType
              Values: FieldValue list
              SubFields: SubField list }

        let baseField =
            { Name = Name ""
              Num = Num 0uy
              Type = Type 0uy
              Scale = Scale 1.0
              Offset = Offset 0.0
              Units = Units ""
              IsAccumulated = IsAccumulated false
              ProfileType = File
              Values = []
              SubFields = [] }

        let unknownField =
            { Name = Name "unknown"
              Num = Num 255uy
              Type = Type 0uy
              Scale = Scale 1.0
              Offset = Offset 0.0
              Units = Units ""
              IsAccumulated = IsAccumulated false
              ProfileType = Enum
              Values = []
              SubFields = [] }

        let getNumValues field = field.Values.Length

    let BigEndian = 0x01uy

    type LocalNum = LocalNum of byte
    type SystemTimeOffset = SystemTimeOffset of uint32

    type MesgNum =
        | FileId = 0us
        | FileCreator = 49us


    type FieldDefinition = { Num: byte; Size: byte; Type: byte }

    type MessageDefinition =
        { LocalMsgNum: byte
          Architecture: byte
          GlobalMsgNum: MesgNum
          NumFields: byte
          Fields: FieldDefinition List }
        member this.IsBigEndian = this.Architecture = BigEndian

        member this.GetMessageSize =
            // In the SDK, this also adds 1 for the header.
            this.Fields |> List.sumBy (fun f -> f.Size)

    type ProfileMessage =
        { LocalNum: LocalNum
          SystemTimeOffset: SystemTimeOffset
          Name: Name
          Num: MesgNum
          Fields: Field.Field list }

    type Message =
        | MessageDefinition of MessageDefinition
        | DataMessage of ProfileMessage

    type EndianAbility = EndianAbility of bool
    type BaseTypeField = BaseTypeField of byte
    type TypeName = TypeName of string
    type InvalidValue = InvalidValue of obj
    type Size = Size of byte
    type IsSigned = IsSigned of bool
    type IsInteger = IsInteger of bool

    module FieldTypes =
        [<Literal>]
        let Enum = 0x00uy

        [<Literal>]
        let SInt8 = 0x01uy

        [<Literal>]
        let UInt8 = 0x02uy

        [<Literal>]
        let SInt16 = 0x03uy

        [<Literal>]
        let UInt16 = 0x04uy

        [<Literal>]
        let SInt32 = 0x05uy

        [<Literal>]
        let UInt32 = 0x06uy

        [<Literal>]
        let String = 0x07uy

        [<Literal>]
        let Float32 = 0x08uy

        [<Literal>]
        let Float64 = 0x09uy

        [<Literal>]
        let UInt8z = 0x0Auy

        [<Literal>]
        let UInt16z = 0x0Buy

        [<Literal>]
        let UInt32z = 0x0Cuy

        [<Literal>]
        let Byte = 0x0Duy

        [<Literal>]
        let SInt64 = 0x0Euy

        [<Literal>]
        let UInt64 = 0x0Fuy

        [<Literal>]
        let UInt64z = 0x10uy



    type FitType =
        { EndianAbility: EndianAbility
          BaseTypeField: BaseTypeField
          TypeName: TypeName
          InvalidValue: InvalidValue
          Size: Size
          IsSigned: IsSigned
          IsInteger: IsInteger }

    let BaseType =
        [| { EndianAbility = EndianAbility false
             BaseTypeField = BaseTypeField 0x00uy
             TypeName = TypeName "enum"
             InvalidValue = InvalidValue 0xFFuy
             Size = Size 1uy
             IsSigned = IsSigned false
             IsInteger = IsInteger false }
           { EndianAbility = EndianAbility false
             BaseTypeField = BaseTypeField 0x01uy
             TypeName = TypeName "sint8"
             InvalidValue = InvalidValue 0x7Fy
             Size = Size 1uy
             IsSigned = IsSigned true
             IsInteger = IsInteger true }
           { EndianAbility = EndianAbility false
             BaseTypeField = BaseTypeField 0x02uy
             TypeName = TypeName "uint8"
             InvalidValue = InvalidValue 0xFFuy
             Size = Size 1uy
             IsSigned = IsSigned false
             IsInteger = IsInteger true }
           { EndianAbility = EndianAbility true
             BaseTypeField = BaseTypeField 0x83uy
             TypeName = TypeName "sint16"
             InvalidValue = InvalidValue 0x7FFFs
             Size = Size 2uy
             IsSigned = IsSigned true
             IsInteger = IsInteger true }
           { EndianAbility = EndianAbility true
             BaseTypeField = BaseTypeField 0x84uy
             TypeName = TypeName "uint16"
             InvalidValue = InvalidValue 0xFFFFus
             Size = Size 2uy
             IsSigned = IsSigned false
             IsInteger = IsInteger true }
           { EndianAbility = EndianAbility true
             BaseTypeField = BaseTypeField 0x85uy
             TypeName = TypeName "sint32"
             InvalidValue = InvalidValue 0x7FFFFFFF
             Size = Size 4uy
             IsSigned = IsSigned true
             IsInteger = IsInteger true }
           { EndianAbility = EndianAbility true
             BaseTypeField = BaseTypeField 0x86uy
             TypeName = TypeName "uint32"
             InvalidValue = InvalidValue 0xFFFFFFFFu
             Size = Size 4uy
             IsSigned = IsSigned false
             IsInteger = IsInteger true }
           { EndianAbility = EndianAbility false
             BaseTypeField = BaseTypeField 0x07uy
             TypeName = TypeName "string"
             InvalidValue = InvalidValue 0x00uy
             Size = Size 1uy
             IsSigned = IsSigned false
             IsInteger = IsInteger false }
           { EndianAbility = EndianAbility true
             BaseTypeField = BaseTypeField 0x88uy
             TypeName = TypeName "float32"
             InvalidValue = InvalidValue(BitConverter.ToSingle([| 0xFFuy; 0xFFuy; 0xFFuy; 0xFFuy |], 0))
             Size = Size 4uy
             IsSigned = IsSigned true
             IsInteger = IsInteger false }
           { EndianAbility = EndianAbility true
             BaseTypeField = BaseTypeField 0x89uy
             TypeName = TypeName "float64"
             InvalidValue =
                 InvalidValue
                     (BitConverter.ToSingle
                         ([| 0xFFuy
                             0xFFuy
                             0xFFuy
                             0xFFuy
                             0xFFuy
                             0xFFuy
                             0xFFuy
                             0xFFuy |],
                          0))
             Size = Size 8uy
             IsSigned = IsSigned true
             IsInteger = IsInteger false }
           { EndianAbility = EndianAbility false
             BaseTypeField = BaseTypeField 0x0Auy
             TypeName = TypeName "uint8z"
             InvalidValue = InvalidValue 0x00uy
             Size = Size 1uy
             IsSigned = IsSigned false
             IsInteger = IsInteger true }
           { EndianAbility = EndianAbility true
             BaseTypeField = BaseTypeField 0x8Buy
             TypeName = TypeName "uint16z"
             InvalidValue = InvalidValue 0x0000us
             Size = Size 2uy
             IsSigned = IsSigned false
             IsInteger = IsInteger true }
           { EndianAbility = EndianAbility true
             BaseTypeField = BaseTypeField 0x8Cuy
             TypeName = TypeName "uint32z"
             InvalidValue = InvalidValue 0x00000000u
             Size = Size 4uy
             IsSigned = IsSigned false
             IsInteger = IsInteger true }
           { EndianAbility = EndianAbility false
             BaseTypeField = BaseTypeField 0x0Duy
             TypeName = TypeName "byte"
             InvalidValue = InvalidValue 0xFFuy
             Size = Size 1uy
             IsSigned = IsSigned false
             IsInteger = IsInteger false }
           { EndianAbility = EndianAbility true
             BaseTypeField = BaseTypeField 0x8Euy
             TypeName = TypeName "sint64"
             InvalidValue = InvalidValue 9223372036854775807L
             Size = Size 8uy
             IsSigned = IsSigned true
             IsInteger = IsInteger true }
           { EndianAbility = EndianAbility true
             BaseTypeField = BaseTypeField 0x8Fuy
             TypeName = TypeName "uint64"
             InvalidValue = InvalidValue 0xFFFFFFFFFFFFFFFFUL
             Size = Size 8uy
             IsSigned = IsSigned false
             IsInteger = IsInteger true }
           { EndianAbility = EndianAbility true
             BaseTypeField = BaseTypeField 0x90uy
             TypeName = TypeName "uint64z"
             InvalidValue = InvalidValue 0x0000000000000000UL
             Size = Size 8uy
             IsSigned = IsSigned false
             IsInteger = IsInteger true } |]
