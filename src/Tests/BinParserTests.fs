module BinParserTests

open NUnit.Framework
open FsUnit
open BinParser

// * Chose to use byte1 parser for simplicity

[<SetUp>]
let Setup () = ()

type ShabbaRex = { shabba: string }
let bp = new BinParser<_>()

let state =
  { data = [| 1uy; 2uy; 3uy; 4uy; 5uy |]
    position = 0
    userState = { shabba = "rex" } }


[<Test>]
let ``manyN handles 0`` () =
  let repeatParser = manyN 0 bp.byte1
  let result = run repeatParser state
  let expected: Result<byte list, _> = Success([], state)
  result |> should equal expected

[<Test>]
let ``manyN handles 1`` () =
  let repeatParser = manyN 1 bp.byte1
  let result = run repeatParser state

  let expected: Result<byte list, _> =
    Success([ 1uy ], { state with position = 1 })

  result |> should equal expected

[<Test>]
let ``manyN handles 5`` () =
  let repeatParser = manyN 5 bp.byte1
  let result = run repeatParser state

  let expected: Result<byte list, _> =
    Success([ 1uy; 2uy; 3uy; 4uy; 5uy ], { state with position = 5 })

  result |> should equal expected

[<Test>]
let ``manyN fails for when request exceeds capacity`` () =
  let repeatParser = manyN 6 bp.byte1
  let result = run repeatParser state

  let expected: Result<byte list, ShabbaRex> =
    Failure("manyN", "Tried to read 6 items but found only 5", 5)

  result |> should equal expected
