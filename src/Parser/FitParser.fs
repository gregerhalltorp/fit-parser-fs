namespace FitParse

open BinParser

[<AutoOpen>]
module FitParser =
  // let fitFileParser = new BinParser<_>()

  // TODO: write tests for this!
  // TODO: switch more binds to maps, think more about how to handle set/get userstate
  let fileParser =
    headerP
    .>>. fileIdDefP
    >>= (fun (header, fileIdDefinition) ->
    returnP
      { header = header
        definitions = [ fileIdDefinition ] })

// let printResult result =
//   match result with
//   | Success (value, state) -> printfn "%A\n(userState:%A)" value state.userState
//   | Failure (label, error, pos) -> printfn "Error parsing %s at position %i: %s" label pos error

// let prettyParseFitFile input = run headerP input |> printResult

  let parseFitFile input = run fileParser input

// let parseFitFile2 input =
//   match run headerP input with
//   | Success (value, _) -> value
//   | Failure (_) -> failwith "Errors and shit"
