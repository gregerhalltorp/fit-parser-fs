#r "/bin/ExcelProvider.Runtime.dll"
open FSharp.Interop.Excel

type ExcelProfile = ExcelFile<"Profile.xlsx", "Types">

let file = new ExcelProfile()
let rows = file.Data |> Seq.toArray

printfn "hej %A" rows

// let rec printRows (rows: ExcelProfile.Row array) =
//     match rows.Length with
//     | 0 -> printfn "DONE!"
//     | _ ->
//         printfn "%A" (rows.[0].GetValue 0)
//         printRows rows.[1..]

// printRows rows
