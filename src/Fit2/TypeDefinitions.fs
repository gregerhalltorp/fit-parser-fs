namespace Fit2

module TypeDefinitions =
  type FieldDefinition =
    { num: byte
      size: byte
      fieldType: byte }

  type SubFieldMap =
    { refFieldNum: byte
      refFieldValue: obj }

  type SubField =
    { name: string
      fieldType: FitBaseType
      scale: double
      offset: double
      units: string
      maps: SubFieldMap list }

  type Field =
    { name: string
      num: byte
      fieldType: FitBaseType
      scale: double
      offset: double
      units: string
      isAccumulated: bool
      profileType: ProfileType
      values: obj list
      subFields: SubField list }

  let baseField =
    { name = ""
      num = 0uy
      fieldType = FitBaseType.Enum
      scale = 1.0
      offset = 0.0
      units = ""
      isAccumulated = false
      profileType = File
      values = []
      subFields = [] }

  let unknownField =
    { name = "unknown"
      num = 255uy
      fieldType = FitBaseType.Enum
      scale = 1.0
      offset = 0.0
      units = ""
      isAccumulated = false
      profileType = Enum
      values = []
      subFields = [] }


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
