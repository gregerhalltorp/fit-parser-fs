namespace FitParse

[<AutoOpen>]
module FitParserTypes =
  type FieldDefinition =
    { num: byte
      size: byte
      fieldType: byte }

  type MessageDefinition =
    { localMessageNumber: byte
      architecture: byte
      globalMessageNumber: uint16
      numberOfFields: byte
      fieldDefinitions: FieldDefinition list }

  type DataMessage = { localMessageNumber: byte }

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
