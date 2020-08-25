namespace Fit

module Constants =
    let (crcTable: uint16 []) =
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
