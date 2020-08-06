module FileReader

open System.IO

let rec readData (stream:FileStream) buffer offset count =
    match count with
    | 0 ->
        printfn "done"
        buffer
    | _ ->
        printfn "running"
        let n = stream.Read(buffer, offset, count)
        readData stream buffer (offset + n) (count - n)

let getFileData fileName =
    use source = File.OpenRead(fileName)
    let bytesToRead = int source.Length
    let (data: byte array) = Array.zeroCreate bytesToRead
    let bytesRead = 0

    readData source data bytesRead bytesToRead
