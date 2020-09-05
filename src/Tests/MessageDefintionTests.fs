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
let numMsg = 7uy

let getInput data =
  { data = List.toArray data
    position = 0
    userState =
      { headerSize = 0uy
        isBigEndian = false
        numFields = 0 } }

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
  let input1 =
    getInput [ header
               reserved
               architectureLE ]

  let input2 =
    getInput [ header
               reserved
               architectureLE
               0uy ]

  let result1 = parseDefinition input1
  let result2 = parseDefinition input2

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Ran out of data", 3)

  result1 |> should equal expected
  result2 |> should equal expected

[<Test>]
let ``Fails if no number of messages field`` () =
  let inputList =
    [ header; reserved; architectureLE ]
    @ fileIdMesgNum

  let result = parseDefinition (getInput inputList)

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Ran out of data", 5)

  result |> should equal expected

[<Test>]
let ``Passes with defintion header`` () =
  let inputList =
    [ header; reserved; architectureLE ]
    @ fileIdMesgNum
    @ [ numMsg ]

  let input = getInput inputList

  let result = parseDefinition input

  let state =
    { data = inputList |> List.toArray
      position = 6
      userState =
        { headerSize = 0uy
          isBigEndian = false
          numFields = 7 } }

  let definition =
    { localMessageNumber = 0uy
      architecture = architectureLE
      globalMessageNumber = 0us
      numberOfFields = 7uy }

  let expected: Result<MessageDefinition, FitState> = Success(definition, state)

  result |> should equal expected

[<Test>]
let ``Passes with defintion header and big endian architecture`` () =
  let inputList =
    [ header; reserved; architectureBE ]
    @ fileIdMesgNum
    @ [ numMsg ]

  let input = getInput inputList

  let result = parseDefinition input

  let state =
    { data = inputList |> List.toArray
      position = 6
      userState =
        { headerSize = 0uy
          isBigEndian = true
          numFields = 7 } }

  let definition =
    { localMessageNumber = 0uy
      architecture = architectureBE
      globalMessageNumber = 0us
      numberOfFields = numMsg }

  let expected: Result<MessageDefinition, FitState> = Success(definition, state)

  result |> should equal expected

[<Test>]
let ``FileId parser fails with incorrect global message number`` () =
  let part1 = [ header; reserved; architectureLE ]
  let part2 = [ 0uy; 4uy; numMsg ]
  let inputList = part1 @ part2

  let input = getInput inputList

  let result = run fileIdDefP input

  let expected: Result<MessageDefinition, FitState> =
    Failure("fileId message definition", "Expected fileId definition", 6)

  result |> should equal expected


[<Test>]
let ``FileId parser passes with correct global message number`` () =
  let inputList =
    [ header; reserved; architectureLE ]
    @ fileIdMesgNum
    @ [ numMsg ]

  let input = getInput inputList

  let result = run fileIdDefP input

  let state =
    { data = inputList |> List.toArray
      position = 6
      userState =
        { headerSize = 0uy
          isBigEndian = false
          numFields = 7 } }

  let definition =
    { localMessageNumber = 0uy
      architecture = architectureLE
      globalMessageNumber = 0us
      numberOfFields = numMsg }

  let expected: Result<MessageDefinition, FitState> = Success(definition, state)

  result |> should equal expected

// fileIdDefP
