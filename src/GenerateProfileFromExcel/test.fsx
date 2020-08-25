// let replaceInitialNumber (input: string) =
open System
type File =
    | Device = 1uy
    | Settings = 2uy
    | Sport = 3uy
    | Activity = 4uy
    | Workout = 5uy
    | Course = 6uy
let fileGetter = Microsoft.FSharp.Core.LanguagePrimitives.EnumOfValue<byte, File>

let device = fileGetter 1uy

match device with
| File.Device -> printfn "yes"
| _ -> printfn "no"
