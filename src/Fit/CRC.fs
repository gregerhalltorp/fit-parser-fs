namespace Fit

module Crc =
    let (crcTable: uint16 array) =
        [| uint16 0x0000
           uint16 0xCC01
           uint16 0xD801
           uint16 0x1400
           uint16 0xF001
           uint16 0x3C00
           uint16 0x2800
           uint16 0xE401
           uint16 0xA001
           uint16 0x6C00
           uint16 0x7800
           uint16 0xB401
           uint16 0x5000
           uint16 0x9C01
           uint16 0x8801
           uint16 0x4400 |]

    let uintMaskF = uint16 0xF
    let uintMaskFFF = uint16 0x0FFF
    let byteMaskF = byte 0xF

    let rec validateCrc (crc: uint16) (dataBlock: byte array) =
        match dataBlock.Length with
        | 0 -> crc = uint16 0x000
        | _ ->
            let data = dataBlock.[0]

            let lowTemp = crcTable.[int (crc &&& uintMaskF)]
            let intermediaryLowCrc1 = (crc >>> 4) &&& uintMaskFFF

            let intermediaryLowCrc2 =
                intermediaryLowCrc1
                ^^^ lowTemp
                ^^^ crcTable.[int (data &&& byteMaskF)]

            let highTemp =
                crcTable.[int (intermediaryLowCrc2 &&& uintMaskF)]

            let intermediaryHighCrc1 =
                (intermediaryLowCrc2 >>> 4) &&& uintMaskFFF

            let newCrc =
                intermediaryHighCrc1
                ^^^ highTemp
                ^^^ crcTable.[int ((data >>> 4) &&& byteMaskF)]

            validateCrc newCrc dataBlock.[1..]
