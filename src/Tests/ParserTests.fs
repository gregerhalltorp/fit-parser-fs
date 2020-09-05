module ParserTests

open NUnit.Framework
open FsUnit
open Parse.ParseTypes

[<SetUp>]
let Setup () = ()

[<TestFixture>]
type ``manyN tests``() =
  [<Test>]
  member this.``Handles 0``() =
    let state =
      { data = [| 1uy; 2uy; 3uy; 4uy; 5uy |]
        position = 0
        userState =
          { headerSize = 0uy
            isBigEndian = false
            numFields = 0 } }

    let dodo = manyN 0 byte1

    let result = run dodo state

    let expected: Result<byte list, FitState> = Success([], state)

    result |> should equal expected

  [<Test>]
  member this.``Handles 1``() =
    let state =
      { data = [| 1uy; 2uy; 3uy; 4uy; 5uy |]
        position = 0
        userState =
          { headerSize = 0uy
            isBigEndian = false
            numFields = 0 } }

    let dodo = manyN 1 byte1

    let result = run dodo state

    let expected: Result<byte list, FitState> =
      Success([ 1uy ], { state with position = 1 })

    result |> should equal expected

  [<Test>]
  member this.``Handles 5``() =
    let state =
      { data = [| 1uy; 2uy; 3uy; 4uy; 5uy |]
        position = 0
        userState =
          { headerSize = 0uy
            isBigEndian = false
            numFields = 0 } }

    let dodo = manyN 5 byte1

    let result = run dodo state

    let expected: Result<byte list, FitState> =
      Success([ 1uy; 2uy; 3uy; 4uy; 5uy ], { state with position = 5 })

    result |> should equal expected

  [<Test>]
  member this.``Fails for 6``() =
    let state =
      { data = [| 1uy; 2uy; 3uy; 4uy; 5uy |]
        position = 0
        userState =
          { headerSize = 0uy
            isBigEndian = false
            numFields = 0 } }

    let dodo = manyN 6 byte1

    let result = run dodo state

    let expected: Result<byte list, FitState> =
      Failure("manyN", "Tried to read 6 items but found only 5", 5)

    result |> should equal expected
