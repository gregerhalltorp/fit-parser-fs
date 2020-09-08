module HeaderTests

open NUnit.Framework
open FsUnit
open FitParse
open BinParser
open Fit2.TypeDefinitions

[<SetUp>]
let Setup () = ()

let parseHeader input = run headerP input

let headerSize14 = 14uy
let headerSize12 = 12uy
let badProtocolVersion = 48uy
let goodProtocolVersion = 16uy
let profileVersion = [ 249uy; 7uy ]
let dataSize = [ 175uy; 200uy; 0uy; 0uy ]
let badDataType = [ 70uy; 71uy; 72uy; 73uy ]
let goodDataType = [ 46uy; 70uy; 73uy; 84uy ]
let crc = [ 147uy; 173uy ]

let getInput data =
  { data = List.toArray data
    position = 0
    userState =
      { headerSize = 0uy
        isBigEndian = false
        numFields = 0
        definitions = Map.empty
        currentDefinition = None } }

[<Test>]
let ``headerP fails if data is empty`` () =
  let input = getInput []

  let result = parseHeader input
  let expected: Result<Header, FitState> = Failure("header", "Ran out of data", 0)

  result |> should equal expected

[<Test>]
let ``headerP fails if length = 1`` () =
  let input = getInput [ headerSize14 ]
  let result = parseHeader input

  let expected: Result<Header, FitState> = Failure("header", "Ran out of data", 1)

  result |> should equal expected

[<Test>]
let ``headerP fails for bad protocolVersion`` () =
  let input =
    getInput [ headerSize14
               badProtocolVersion ]

  let result = parseHeader input

  let expected: Result<Header, FitState> =
    Failure("header", "Protocol version not supported", 1)

  result |> should equal expected

[<Test>]
let ``headerP fails when length = 2, good protocolVersion`` () =
  let input =
    getInput [ headerSize14
               goodProtocolVersion ]

  let result = parseHeader input

  let expected: Result<Header, FitState> = Failure("header", "Ran out of data", 2)

  result |> should equal expected

[<Test>]
let ``headerP fails when length = 3 or 4`` () =
  let goodPart = [ headerSize14; goodProtocolVersion ]
  let input1 = getInput (goodPart @ [ 1uy ])
  let input2 = getInput (goodPart @ profileVersion)
  let result1 = parseHeader input1
  let result2 = parseHeader input2

  let expected1: Result<Header, FitState> = Failure("header", "Ran out of data", 3)
  let expected2: Result<Header, FitState> = Failure("header", "Ran out of data", 4)

  result1 |> should equal expected1
  result2 |> should equal expected2

[<Test>]
let ``headerP fails when length = 5, 6, 7 or 8`` () =
  let goodPart =
    [ headerSize14; goodProtocolVersion ]
    @ profileVersion

  let input1 = getInput (goodPart @ [ 0uy ])
  let input2 = getInput (goodPart @ [ 0uy; 0uy ])
  let input3 = getInput (goodPart @ [ 0uy; 0uy; 0uy ])
  let input4 = getInput (goodPart @ dataSize)

  let result1 = parseHeader input1
  let result2 = parseHeader input2
  let result3 = parseHeader input3
  let result4 = parseHeader input4

  let expected1: Result<Header, FitState> = Failure("header", "Ran out of data", 5)
  let expected2: Result<Header, FitState> = Failure("header", "Ran out of data", 6)
  let expected3: Result<Header, FitState> = Failure("header", "Ran out of data", 7)
  let expected4: Result<Header, FitState> = Failure("header", "Ran out of data", 8)

  result1 |> should equal expected1
  result2 |> should equal expected2
  result3 |> should equal expected3
  result4 |> should equal expected4

[<Test>]
let ``headerP fails when length = 9, 10, 11`` () =
  let goodPart =
    [ headerSize14; goodProtocolVersion ]
    @ profileVersion
    @ dataSize

  let input1 = getInput (goodPart @ [ 46uy ])
  let input2 = getInput (goodPart @ [ 46uy; 70uy ])

  let input3 =
    getInput (goodPart @ [ 46uy; 70uy; 73uy ])

  let result1 = parseHeader input1
  let result2 = parseHeader input2
  let result3 = parseHeader input3

  let expected1: Result<Header, FitState> = Failure("header", "Ran out of data", 9)
  let expected2: Result<Header, FitState> = Failure("header", "Ran out of data", 10)
  let expected3: Result<Header, FitState> = Failure("header", "Ran out of data", 11)

  result1 |> should equal expected1
  result2 |> should equal expected2
  result3 |> should equal expected3

[<Test>]
let ``headerP fails when data type field is not correct`` () =
  let inputList =
    [ headerSize14; goodProtocolVersion ]
    @ profileVersion
    @ dataSize
    @ badDataType

  let input = getInput inputList

  let result = parseHeader input

  let expectedString =
    sprintf "Expected %A (%A), got %A (%A)" ".FIT" (List.toArray goodDataType) "FGHI" (List.toArray badDataType)


  let expected: Result<Header, FitState> = Failure("header", expectedString, 8)

  result |> should equal expected

[<Test>]
let ``headerP fails when headerSize is 14 but header is 12 or 13 bytes`` () =
  let inputList =
    [ headerSize14; goodProtocolVersion ]
    @ profileVersion
    @ dataSize
    @ goodDataType

  let input1 = getInput inputList
  let input2 = getInput (inputList @ [ 0uy ])

  let result1 = parseHeader input1
  let result2 = parseHeader input2

  let expected1: Result<Header, FitState> = Failure("header", "Ran out of data", 12)
  let expected2: Result<Header, FitState> = Failure("header", "Ran out of data", 13)

  result1 |> should equal expected1
  result2 |> should equal expected2

[<Test>]
let ``headerP succeeds if headerSize is 12 and header is 12 bytes`` () =
  let inputList =
    [ headerSize12; goodProtocolVersion ]
    @ profileVersion
    @ dataSize
    @ goodDataType

  let input = getInput inputList

  let result = parseHeader input

  let header =
    { size = 12uy
      protocolVersion = 16uy
      profileVersion = 2041s
      dataSize = 51375
      dataType = [| '.'; 'F'; 'I'; 'T' |]
      crc = 0s }

  let state =
    { data = inputList |> List.toArray
      position = 12
      userState =
        { headerSize = 12uy
          isBigEndian = false
          numFields = 0
          definitions = Map.empty
          currentDefinition = None} }

  let expected: Result<Header, FitState> = Success(header, state)

  result |> should equal expected

[<Test>]
let ``headerP succeeds if headerSize is 14 and header is 14 bytes`` () =
  let inputList =
    [ headerSize14; goodProtocolVersion ]
    @ profileVersion
    @ dataSize
    @ goodDataType
    @ crc

  let input = getInput inputList

  let result = parseHeader input

  let expectedString =
    sprintf "Expected %A (%A), got %A (%A)" ".FIT" (List.toArray goodDataType) "FGHI" (List.toArray badDataType)

  let header =
    { size = 14uy
      protocolVersion = 16uy
      profileVersion = 2041s
      dataSize = 51375
      dataType = [| '.'; 'F'; 'I'; 'T' |]
      crc = -21101s }

  let state =
    { data = inputList |> List.toArray
      position = 14
      userState =
        { headerSize = 14uy
          isBigEndian = false
          numFields = 0
          definitions = Map.empty
          currentDefinition = None } }

  let expected: Result<Header, FitState> = Success(header, state)

  result |> should equal expected
