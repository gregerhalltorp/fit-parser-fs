namespace Fit

open System

module Header =
    type HeaderSize =
        | WithCRC = 14uy
        | WithoutCRC = 12uy
    let HeaderSizeConverter = LanguagePrimitives.EnumOfValue<byte, HeaderSize>

    type ProtocolVersion = byte
    type ProfileVersion = int16
    type DataSize = int32
    type DataType = char []
    type CRC = int16

    type Header =
        { Size: HeaderSize
          ProtocolVersion: ProtocolVersion
          ProfileVersion: ProfileVersion
          DataSize: DataSize
          DataType: DataType
          CRC: CRC }

    let ValidDataType = ".FIT"

    let parseHeader (headerData: byte []) =
        let size = HeaderSizeConverter headerData.[0]

        let protocolVersion = headerData.[1]
        let profileVersion = BitConverter.ToInt16(headerData, 2)
        let dataSize = BitConverter.ToInt32(headerData, 4)
        let dataType = headerData.[8..11] |> Array.map char

        let crc =
            match size with
            | HeaderSize.WithCRC -> BitConverter.ToInt16(headerData, 12)
            | HeaderSize.WithoutCRC -> 0s
            | _ -> raise(Exception("Unrecognized header size")) 

        { Size = size
          ProtocolVersion = protocolVersion
          ProfileVersion = profileVersion
          DataSize = dataSize
          DataType = dataType
          CRC = crc }

    let isValid header =
        (header.DataType |> String) = ValidDataType
