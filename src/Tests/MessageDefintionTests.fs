module MessageDefinitionTests

open NUnit.Framework
open FsUnit
open FitParse
open BinParser
open Fit2
open Fit2.Messages

[<SetUp>]
let Setup () = ()

let parseDefinition input = run messageDefinitionP input

let getInput data =
  { data = List.toArray data
    position = 0
    userState =
      { headerSize = 0uy
        isBigEndian = false
        numFields = 0
        definitions = Map.empty
        currentDefinition = None } }

let header = 64uy
let reserved = 0uy
let architectureLE = 0uy
let architectureBE = 1uy
let fileIdMesgNum = [ 0uy; 0uy ]
let numMsg = 7uy
let field1 = [ 3uy; 4uy; 140uy ]
let field2 = [ 4uy; 4uy; 134uy ]
let field3 = [ 7uy; 4uy; 134uy ]
let field4 = [ 1uy; 2uy; 132uy ]
let field5 = [ 2uy; 2uy; 132uy ]
let field6 = [ 5uy; 2uy; 132uy ]
let field7 = [ 0uy; 1uy; 0uy ]

let fields =
  field1
  @ field2
  @ field3
  @ field4
  @ field5
  @ field6
  @ field7

let fieldDef1 =
  { num = 3uy
    size = 4uy
    fieldType = 140uy }

let fieldDef2 =
  { num = 4uy
    size = 4uy
    fieldType = 134uy }

let fieldDef3 =
  { num = 7uy
    size = 4uy
    fieldType = 134uy }

let fieldDef4 =
  { num = 1uy
    size = 2uy
    fieldType = 132uy }

let fieldDef5 =
  { num = 2uy
    size = 2uy
    fieldType = 132uy }

let fieldDef6 =
  { num = 5uy
    size = 2uy
    fieldType = 132uy }

let fieldDef7 =
  { num = 0uy
    size = 1uy
    fieldType = 0uy }

let fieldDefs =
  [ fieldDef1
    fieldDef2
    fieldDef3
    fieldDef4
    fieldDef5
    fieldDef6
    fieldDef7 ]

[<Test>]
let ``messageDefinitionP fails if data is empty`` () =
  let input = getInput []

  let result = parseDefinition input

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Ran out of data", 0)

  result |> should equal expected

[<Test>]
let ``messageDefinitionP fails if not a definition message`` () =
  let input = getInput [ 0uy ]

  let result = parseDefinition input

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Expected a definition message", 0)

  result |> should equal expected

[<Test>]
let ``messageDefinitionP fails if no reserved field`` () =
  let input = getInput [ header ]

  let result = parseDefinition input

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Ran out of data", 1)

  result |> should equal expected

[<Test>]
let ``messageDefinitionP fails if no architecture field`` () =
  let input = getInput [ header; reserved ]

  let result = parseDefinition input

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Ran out of data", 2)

  result |> should equal expected

[<Test>]
let ``messageDefinitionP fails if no global message number field`` () =
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

  let expected1: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Ran out of data", 3)

  let expected2: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Ran out of data", 4)

  result1 |> should equal expected1
  result2 |> should equal expected2

[<Test>]
let ``messageDefinitionP fails if no number of messages field`` () =
  let inputList =
    [ header; reserved; architectureLE ]
    @ fileIdMesgNum

  let result = parseDefinition (getInput inputList)

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Ran out of data", 5)

  result |> should equal expected

[<Test>]
let ``messageDefinitionP fails if first field incomplete`` () =
  let inputList =
    [ header; reserved; architectureLE ]
    @ fileIdMesgNum
    @ [ numMsg ]
    @ [ 3uy; 4uy ]

  let result = parseDefinition (getInput inputList)

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Tried to read 7 items but found only 0", 8)

  result |> should equal expected

[<Test>]
let ``messageDefinitionP fails if not enough fields`` () =
  let inputList =
    [ header; reserved; architectureLE ]
    @ fileIdMesgNum
    @ [ numMsg ]
    @ field1
    @ field2
    @ field3
    @ field4
    @ field5
    @ field6

  let result = parseDefinition (getInput inputList)

  let expected: Result<MessageDefinition, FitState> =
    Failure("messagedefinition", "Tried to read 7 items but found only 6", 24)

  result |> should equal expected

[<Test>]
let ``messageDefinitionP succeeds with defintion header`` () =
  let inputList =
    [ header; reserved; architectureLE ]
    @ fileIdMesgNum
    @ [ numMsg ]
    @ fields

  let input = getInput inputList

  let result = parseDefinition input

  let definition =
    { localMessageNumber = 0uy
      architecture = architectureLE
      globalMessageNumber = Types.getMesgNum 0us
      numberOfFields = 7uy
      fieldDefinitions = fieldDefs }

  let state =
    { data = inputList |> List.toArray
      position = 27
      userState =
        { headerSize = 0uy
          isBigEndian = false
          numFields = 7
          definitions = Map(seq { (0uy, definition) })
          currentDefinition = None } }

  let expected: Result<MessageDefinition, FitState> = Success(definition, state)

  result |> should equal expected

[<Test>]
let ``messageDefinitionP succeeds with defintion header and big endian architecture`` () =
  let inputList =
    [ header; reserved; architectureBE ]
    @ fileIdMesgNum
    @ [ numMsg ]
    @ fields

  let input = getInput inputList

  let result = parseDefinition input

  let definition =
    { localMessageNumber = 0uy
      architecture = architectureBE
      globalMessageNumber = Types.getMesgNum 0us
      numberOfFields = numMsg
      fieldDefinitions = fieldDefs }

  let state =
    { data = inputList |> List.toArray
      position = 27
      userState =
        { headerSize = 0uy
          isBigEndian = true
          numFields = 7
          definitions = Map.empty.Add(0uy, definition)
          currentDefinition = None } }

  let expected: Result<MessageDefinition, FitState> = Success(definition, state)

  result |> should equal expected

[<Test>]
let ``fileId parser fails with incorrect global message number`` () =
  let part1 = [ header; reserved; architectureLE ]
  let part2 = [ 0uy; 4uy; numMsg ]
  let inputList = part1 @ part2 @ fields

  let input = getInput inputList

  let result = run fileIdDefP input

  let expected: Result<MessageDefinition, FitState> =
    Failure("fileId message definition", "Expected fileId definition", 27)

  result |> should equal expected


[<Test>]
let ``fileId succeeds with correct global message number`` () =
  let inputList =
    [ header; reserved; architectureLE ]
    @ fileIdMesgNum
    @ [ numMsg ]
    @ fields

  let input = getInput inputList

  let result = run fileIdDefP input

  let definition =
    { localMessageNumber = 0uy
      architecture = architectureLE
      globalMessageNumber = Types.getMesgNum 0us
      numberOfFields = numMsg
      fieldDefinitions = fieldDefs }

  let state =
    { data = inputList |> List.toArray
      position = 27
      userState =
        { headerSize = 0uy
          isBigEndian = false
          numFields = 7
          definitions = Map.empty.Add(0uy, definition)
          currentDefinition = None } }

  let expected: Result<MessageDefinition, FitState> = Success(definition, state)

  result |> should equal expected