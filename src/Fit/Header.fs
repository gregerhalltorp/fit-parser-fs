namespace Fit

open System

module Header =
    type HeaderSize =
        | WithCRC
        | WithoutCRC

    type ProtocolVersion = byte
    type ProfileVersion = int16
    type DataSize = int32
    type DataType = char array
    type CRC = int16

    type Header =
        { Size: HeaderSize
          ProtocolVersion: ProtocolVersion
          ProfileVersion: ProfileVersion
          DataSize: DataSize
          DataType: DataType
          CRC: CRC }

    let HeaderWithCRCSize = byte 14
    let ValidDataType = ".FIT"

    let parseHeader (headerData: byte array) =
        let size =
            if headerData.[0] = HeaderWithCRCSize then HeaderSize.WithCRC else HeaderSize.WithoutCRC

        let protocolVersion = headerData.[1]
        let profileVersion = BitConverter.ToInt16(headerData, 2)
        let dataSize = BitConverter.ToInt32(headerData, 4)
        let dataType = headerData.[8..11] |> Array.map char

        let crc =
            match size with
            | HeaderSize.WithCRC -> BitConverter.ToInt16(headerData, 12)
            | _ -> int16 0

        { Size = size
          ProtocolVersion = protocolVersion
          ProfileVersion = profileVersion
          DataSize = dataSize
          DataType = dataType
          CRC = crc }

    let isValid header =
        (header.DataType |> String) = ValidDataType
