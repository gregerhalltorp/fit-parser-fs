namespace Fit2

open System

module Types =
  let getMesgNum (value: uint16): MesgNum = LanguagePrimitives.EnumOfValue value
  let getBaseType (value: byte): FitBaseType = LanguagePrimitives.EnumOfValue value

  type FitType =
    { endianAbility: bool
      baseTypeField: byte
      typeName: string
      invalidValue: obj
      size: byte
      isSigned: bool
      isInteger: bool }

  let BaseType =
    [| { endianAbility = false
         baseTypeField = 0x00uy
         typeName = "enum"
         invalidValue = 0xFFuy
         size = 1uy
         isSigned = false
         isInteger = false }
       { endianAbility = false
         baseTypeField = 0x01uy
         typeName = "sint8"
         invalidValue = 0x7Fy
         size = 1uy
         isSigned = true
         isInteger = true }
       { endianAbility = false
         baseTypeField = 0x02uy
         typeName = "uint8"
         invalidValue = 0xFFuy
         size = 1uy
         isSigned = false
         isInteger = true }
       { endianAbility = true
         baseTypeField = 0x83uy
         typeName = "sint16"
         invalidValue = 0x7FFFs
         size = 2uy
         isSigned = true
         isInteger = true }
       { endianAbility = true
         baseTypeField = 0x84uy
         typeName = "uint16"
         invalidValue = 0xFFFFus
         size = 2uy
         isSigned = false
         isInteger = true }
       { endianAbility = true
         baseTypeField = 0x85uy
         typeName = "sint32"
         invalidValue = 0x7FFFFFFF
         size = 4uy
         isSigned = true
         isInteger = true }
       { endianAbility = true
         baseTypeField = 0x86uy
         typeName = "uint32"
         invalidValue = 0xFFFFFFFFu
         size = 4uy
         isSigned = false
         isInteger = true }
       { endianAbility = false
         baseTypeField = 0x07uy
         typeName = "string"
         invalidValue = 0x00uy
         size = 1uy
         isSigned = false
         isInteger = false }
       { endianAbility = true
         baseTypeField = 0x88uy
         typeName = "float32"
         invalidValue = BitConverter.ToSingle([| 0xFFuy; 0xFFuy; 0xFFuy; 0xFFuy |], 0)
         size = 4uy
         isSigned = true
         isInteger = false }
       { endianAbility = true
         baseTypeField = 0x89uy
         typeName = "float64"
         invalidValue =
           BitConverter.ToSingle
             ([| 0xFFuy
                 0xFFuy
                 0xFFuy
                 0xFFuy
                 0xFFuy
                 0xFFuy
                 0xFFuy
                 0xFFuy |],
              0)
         size = 8uy
         isSigned = true
         isInteger = false }
       { endianAbility = false
         baseTypeField = 0x0Auy
         typeName = "uint8z"
         invalidValue = 0x00uy
         size = 1uy
         isSigned = false
         isInteger = true }
       { endianAbility = true
         baseTypeField = 0x8Buy
         typeName = "uint16z"
         invalidValue = 0x0000us
         size = 2uy
         isSigned = false
         isInteger = true }
       { endianAbility = true
         baseTypeField = 0x8Cuy
         typeName = "uint32z"
         invalidValue = 0x00000000u
         size = 4uy
         isSigned = false
         isInteger = true }
       { endianAbility = false
         baseTypeField = 0x0Duy
         typeName = "byte"
         invalidValue = 0xFFuy
         size = 1uy
         isSigned = false
         isInteger = false }
       { endianAbility = true
         baseTypeField = 0x8Euy
         typeName = "sint64"
         invalidValue = 9223372036854775807L
         size = 8uy
         isSigned = true
         isInteger = true }
       { endianAbility = true
         baseTypeField = 0x8Fuy
         typeName = "uint64"
         invalidValue = 0xFFFFFFFFFFFFFFFFUL
         size = 8uy
         isSigned = false
         isInteger = true }
       { endianAbility = true
         baseTypeField = 0x90uy
         typeName = "uint64z"
         invalidValue = 0x0000000000000000UL
         size = 8uy
         isSigned = false
         isInteger = true } |]
