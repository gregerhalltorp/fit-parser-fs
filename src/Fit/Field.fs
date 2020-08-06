namespace Fit

open DomainTypes

module Field =
    type Name = Name of string
    type Type = Type of byte
    type Scale = Scale of double
    type Offset = Offset of double
    type Units = Units of string
    type IsAccumulated = IsAccumulated of bool
    type Num = Num of byte
    type RefFieldNum = RefFieldNum of byte
    type RefFieldValue = RefFieldValue of int // This will need to be updated at some point
    type FieldValue = FieldValue of obj // This will need to be updated at some point

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
