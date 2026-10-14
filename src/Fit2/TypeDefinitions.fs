namespace Fit2

open Fit2.Profile

module TypeDefinitions =
  type FieldDefinition =
    { num: byte
      size: byte
      fieldType: byte }

  type SubFieldMap =
    { refFieldNum: byte
      refFieldValue: int64 }

  /// Part of a field's raw value that should be unpacked into another field
  type Component =
    { fieldNum: byte
      scale: double
      offset: double
      units: string
      bits: int
      isAccumulated: bool }

  type SubField =
    { name: string
      fieldType: FitBaseType
      profileType: ProfileType
      scale: double
      offset: double
      units: string
      components: Component list
      maps: SubFieldMap list }

  type Field =
    { name: string
      num: byte
      fieldType: FitBaseType
      scale: double
      offset: double
      units: string
      isAccumulated: bool
      isArray: bool
      profileType: ProfileType
      values: obj list
      components: Component list
      subFields: SubField list }

  let baseComponent =
    { fieldNum = 0uy
      scale = 1.0
      offset = 0.0
      units = ""
      bits = 0
      isAccumulated = false }

  let baseSubField =
    { name = ""
      fieldType = FitBaseType.Enum
      profileType = ProfileType.Enum
      scale = 1.0
      offset = 0.0
      units = ""
      components = []
      maps = [] }

  let baseField =
    { name = ""
      num = 0uy
      fieldType = FitBaseType.Enum
      scale = 1.0
      offset = 0.0
      units = ""
      isAccumulated = false
      isArray = false
      profileType = ProfileType.File
      values = []
      components = []
      subFields = [] }

  let unknownField =
    { baseField with
        name = "unknown"
        num = 255uy
        profileType = ProfileType.Enum }


  type MessageDefinition =
    { localMessageNumber: byte
      architecture: byte
      globalMessageNumber: MesgNum
      numberOfFields: byte
      fieldDefinitions: FieldDefinition list }

  type DataMessage =
    { localMessageNumber: byte
      systemTimeOffset: uint
      name: string
      number: MesgNum
      fields: Field list }

  type Message =
    | DataMessage of DataMessage
    | MessageDefinition of MessageDefinition

  type Header =
    { size: byte
      protocolVersion: byte
      profileVersion: int16
      dataSize: int
      dataType: char []
      crc: int16 }

  type File =
    { header: Header
      definitions: MessageDefinition list }

  type FitState =
    { headerSize: byte
      isBigEndian: bool
      numFields: int
      definitions: Map<byte, MessageDefinition>
      currentDefinition: MessageDefinition option }

  let dataMessageBase =
    { localMessageNumber = 0uy
      systemTimeOffset = 0u
      name = ""
      number = MesgNum.FileId
      fields = [] }
