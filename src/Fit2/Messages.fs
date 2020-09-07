namespace Fit2

module Messages =
  type FieldDefinition =
    { num: byte
      size: byte
      fieldType: byte }

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
      fields: byte list }

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
