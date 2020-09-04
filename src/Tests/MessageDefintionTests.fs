module MessageDefinitionTests

open NUnit.Framework
open FsUnit
open Parse.ParseTypes

[<SetUp>]
let Setup () = ()

let parseDefinition input = run messageDefinitionP input
let header = 64uy
let reserved = 0uy
let architectureLE = 0uy
let architectureBE = 1uy
let fileIdMesgNum = [ 0uy; 0uy ]

let getInput data =
  { data = List.toArray data
    position = 0
    userState =
      { headerSize = 0uy
        isBigEndian = false } }

[<Test>]
let ``Fails if data is empty`` () =
  let input = getInput []

  let result = parseDefinition input

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Ran out of data", 0)

  result |> should equal expected

[<Test>]
let ``Fails if not a definition message`` () =
  let input = getInput [ 0uy ]

  let result = parseDefinition input

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Expected a definition message", 0)

  result |> should equal expected

[<Test>]
let ``Fails if no reserved field`` () =
  let input = getInput [ header ]

  let result = parseDefinition input

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Ran out of data", 1)

  result |> should equal expected

[<Test>]
let ``Fails if no architecture field`` () =
  let input = getInput [ header; reserved ]

  let result = parseDefinition input

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Ran out of data", 2)

  result |> should equal expected

[<Test>]
let ``Fails if no global message number field`` () =
  let input1 = getInput [ header; reserved; architectureLE ]
  let input2 = getInput [ header; reserved; architectureLE; 0uy ]

  let result1 = parseDefinition input1
  let result2 = parseDefinition input2

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Ran out of data", 3)

  result1 |> should equal expected
  result2 |> should equal expected


[<Test>]
let ``Passes with defintion header`` () =
  let inputList =
    [ header; reserved; architectureLE ]
    @ fileIdMesgNum

  let input = getInput inputList

  let result = parseDefinition input

  let state =
    { data = [| 64uy; 0uy; 0uy; 0uy; 0uy |]
      position = 5
      userState =
        { headerSize = 0uy
          isBigEndian = false } }

  let definition =
    { localMessageNumber = 0uy
      architecture = architectureLE
      globalMessageNumber = 0us}

  let expected: Result<MessageDefinition, FitState> = Success(definition, state)

  result |> should equal expected

[<Test>]
let ``Passes with defintion header and big endian architecture`` () =
  let inputList =
    [ header; reserved; architectureBE ]
    @ fileIdMesgNum

  let input = getInput inputList

  let result = parseDefinition input

  let state =
    { data = [| 64uy; 0uy; 1uy; 0uy; 0uy |]
      position = 5
      userState = { headerSize = 0uy; isBigEndian = true } }

  let definition =
    { localMessageNumber = 0uy
      architecture = architectureBE
      globalMessageNumber = 0us}

  let expected: Result<MessageDefinition, FitState> = Success(definition, state)

  result |> should equal expected
