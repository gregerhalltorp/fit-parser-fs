namespace Fit

open Constants

module Crc =
    let rec validateCrc (crc: uint16) (dataBlock: byte []) =
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
