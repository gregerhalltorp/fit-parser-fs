module DataMessageTests

open NUnit.Framework
open FsUnit
open Parse.ParseTypes
open MessageDefinitionTests

[<SetUp>]
let Setup () = ()

let parseMessage input = run dataMessageP input

let getInput data =
  { data = List.toArray data
    position = 0
    userState =
      { headerSize = 0uy
        isBigEndian = false
        numFields = 0
        definitions = Map.empty
        currentDefinition = None } }

let header = 0uy

let definition =
  { localMessageNumber = 0uy
    architecture = architectureLE
    globalMessageNumber = 0us
    numberOfFields = 7uy
    fields = fieldDefs }

[<Test>]
let ``Fails if data is empty`` () =
  let input = getInput []
  let result = parseMessage input

  let expected: Result<byte, FitState> =
    Failure("datamessage", "Ran out of data", 0)

  result |> should equal expected

[<Test>]
let ``Fails when header not datamessage`` () =
  let input = getInput [ 64uy ]
  let result = parseMessage input

  let expected: Result<byte, FitState> =
    Failure("datamessage", "Expected a data message", 0)

  result |> should equal expected

[<Test>]
let ``Fails when userState defintions empty`` () =
  let input = getInput [ header ]
  let result = parseMessage input

  let expected: Result<byte, FitState> =
    Failure("datamessage", "UserState didn't match", 1)

  result |> should equal expected

[<Test>]
let ``Fails when userState defintions does not contain local message number`` () =
  let doobie = getInput [ header ]

  let input =
    { doobie with
        userState =
          { doobie.userState with
              definitions = Map(seq { (1uy, definition) }) } }

  let result = parseMessage input
  printfn "%A" (header &&& 0x0Fuy)

  let expected: Result<byte, FitState> =
    Failure("datamessage", "UserState didn't match", 1)

  result |> should equal expected

[<Test>]
let ``Fails when userState defintions empty2`` () =
  let inputList = [ header ]
  let basicInput = getInput inputList

  let input =
    { basicInput with
        userState =
          { basicInput.userState with
              definitions = Map(seq { (0uy, definition) }) } }

  let state =
    { data = inputList |> List.toArray
      position = 1
      userState =
        { headerSize = 0uy
          isBigEndian = false
          numFields = 0
          definitions = Map.empty.Add(0uy, definition) 
          currentDefinition = Some(definition)} }

  let result = parseMessage input
  printfn "%A" (header &&& 0x0Fuy)

  let expected: Result<byte, FitState> = Success(0uy, state)

  result |> should equal expected
