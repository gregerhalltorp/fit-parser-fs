module App

open Fit
open FileReader
open System
open Parse

[<EntryPoint>]
let main argv =
  let fileName = argv.[0]

  let data = getFileData fileName

  let result =
    ParseTypes.parseFitFile
      { data = data
        position = 0
        userState = { headerSize = 0uy } }

  printfn "%A" result
  // let valid = Crc.validateCrc (uint16 0) data
  // printfn "Valid file: %b" valid

  // let header = Header.parseHeader data.[..13]
//   printfn "header %A" header
  // let startBytePos =
  //     match header.Size with
  //     | Header.HeaderSize.WithCRC -> 14
  //     | Header.HeaderSize.WithoutCRC -> 12
  //     | _ -> raise(Exception("unknown header size"))
  // let messages = Message.readMessages data.[startBytePos..] []

  0 // return an integer exit code
