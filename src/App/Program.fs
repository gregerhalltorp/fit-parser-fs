module App

open Fit
open FileReader

[<EntryPoint>]
let main argv =
    let fileName = argv.[0]

    let data = getFileData fileName

    // let valid = Crc.validateCrc (uint16 0) data
    // printfn "Valid file: %b" valid

    let header = Header.parseHeader data.[..13]
    let startBytePos =
        match header.Size with
        | Header.WithCRC -> 14
        | Header.WithoutCRC -> 12
    let messages = Message.readMessages data.[startBytePos..] []

    0 // return an integer exit code
