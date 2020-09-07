namespace BinParser

open System
open System.Text

[<AutoOpen>]
module ParseTypes =
  type ParserLabel = string
  type ParserError = string
  type Position = int

  // ? Consider making userState option
  type InputState<'UserState> =
    { data: byte []
      position: int
      userState: 'UserState }

  type Result<'Return, 'UserState> =
    | Success of 'Return * InputState<'UserState>
    | Failure of ParserLabel * ParserError * Position


  type Parser<'Return, 'UserState> =
    { parseFn: (InputState<'UserState> -> Result<'Return, 'UserState>)
      label: ParserLabel }

[<AutoOpen>]
module Parser2 =
  let run parser input = parser.parseFn input

  let getLabel parser = parser.label

  let setLabel parser newLabel =
    { parseFn =
        fun inputState ->
          let result = parser.parseFn inputState
          match result with
          | Success (value, newState) -> Success(value, newState)
          | Failure (_, error, position) -> Failure(newLabel, error, position)
      label = newLabel }

  let (<?>) = setLabel

  let getUserState =
    { parseFn = fun inputState -> Success(inputState.userState, inputState)
      label = "getUserState" }

  let setUserState newUserState =
    { parseFn =
        fun inputState ->
          Success
            ((),
             { inputState with
                 userState = newUserState })
      label = "setUserState" }

  let matchUserState predicate label =
    { parseFn =
        fun inputState ->
          let result = run getUserState inputState
          match result with
          | Failure (_) -> raise (Exception("Unable to get userState"))
          | Success (userState, _) ->
              if predicate userState
              then Success(true, inputState)
              else Failure(label, "UserState didn't match", inputState.position)
      label = "matchUserState" }

  let bindP parserGenerator parser =
    { parseFn =
        fun inputState ->
          let result = run parser inputState
          match result with
          | Failure (label, error, pos) -> Failure(label, error, pos)
          | Success (value, newState) ->
              let parser2 = parserGenerator value
              run parser2 newState
      label = "unknown" }

  let (>>=) parser parserGenerator = bindP parserGenerator parser

  let returnP x =
    let label = sprintf "%A" x
    { parseFn = fun inputState -> Success(x, inputState)
      label = label }

  let andThen parser1 parser2 =
    let label =
      sprintf "%s andThen %s" (getLabel parser1) (getLabel parser2)

    parser1
    >>= fun result1 ->
          parser2
          >>= fun result2 -> returnP (result1, result2) <?> label

  let (.>>.) = andThen

  let orElse parser1 parser2 =
    { parseFn =
        fun inputState ->
          let result = run parser1 inputState
          match result with
          | Success (_) -> result
          | Failure (_) -> run parser2 inputState
      label = "orElse" }

  let (<|>) = orElse

  let choice parsers = List.reduce (<|>) parsers

  let mapP f = bindP (f >> returnP)
  let (|>>) x f = mapP f x

  let (.>>) p1 p2 =
    p1
    .>>. p2
    |>> fun (a, _) -> a

  let (>>.) p1 p2 =
    p1
    .>>. p2
    |>> fun (_, b) -> b

  let applyP fP xP =
    (fP .>>. xP)
    |>> fun (f,x) -> f x

  let (<*>) = applyP

  let lift2 f xP yP =
    returnP f <*> xP <*> yP

  let manyN num parser =
    { parseFn =
        fun inputState ->
          let rec runner count currentState resultList =
            if count = num then
              Success(resultList |> List.rev, currentState)
            else
              let result = run parser currentState
              match result with
              | Failure (_, _, pos) ->
                  Failure("manyN", (sprintf "Tried to read %i items but found only %i" num count), pos)
              | Success (value, newState) -> runner (count + 1) newState (value :: resultList)

          runner 0 inputState []
      label = "manyN" }

  let canConsume state count =
    let endPos = count + state.position
    if endPos > state.data.Length then None else Some(endPos)

  // ? Idea: make this into a parser instead and don't use the matcher when we don't have to?
  // ? But how? The prediacate matcher'll need to be chained to this one (>>), is it worth it?
  // ? Do it with returnP? Could be the solution
  // ? Also fix so we return the correct position here instead of the start of the consume
  let consume count state =
    let possible = canConsume state count
    match possible with
    | None -> None
    | Some (endPos) ->
        let result =
          state.data.[state.position..(endPos - 1)]

        let newState = { state with position = endPos }
        Some(result, newState)

  let matcherConsumer predicate count label =
    { parseFn =
        fun inputState ->
          match consume count inputState with
          | None -> Failure(label, "Ran out of data", inputState.data.Length)
          | Some (data, newState) ->
              let (isMatch, error) = predicate data
              if isMatch then
                Success(data, newState)
              else
                match error with
                | Some (msg) -> Failure(label, msg, inputState.position)
                | None -> Failure(label, "Unexpected data", inputState.position)

      label = label }

[<AutoOpen>]
module Utils =
  let toInt16 bytes = BitConverter.ToInt16(bytes, 0)
  let toUInt16 bytes = BitConverter.ToUInt16(bytes, 0)
  let toInt32 bytes = BitConverter.ToInt32(bytes, 0)
  let toCharArray bytes = bytes |> Array.map char
  let toBytes (str: string) = Encoding.UTF8.GetBytes(str)
  let getFirstByte (bytes: byte []) = bytes.[0]

[<AutoOpen>]
module BinParsers =
  type BinParser<'UserState>() =
    member x.binMatch label num: Parser<_, 'UserState> =
      matcherConsumer (fun _ -> (true, None)) num label

    member x.byteN = x.binMatch "byteN"

    member x.byte1 =
      x.byteN 1
      |>> getFirstByte

    member x.int16 = x.byteN 2 |>> toInt16
    member x.uint16 = x.byteN 2 |>> toUInt16
    member x.int32 = x.byteN 4 |>> toInt32
    member x.charArray n = x.byteN n |>> toCharArray

    member x.matchStringBytes value =
      let label = sprintf "matching string %s" value
      let stringBytes = toBytes value
      matcherConsumer (fun bytes ->
        let isMatch = bytes = stringBytes
        if isMatch then
          (isMatch, None)
        else
          let resultString = toCharArray bytes |> String

          let error =
            sprintf "Expected %A (%A), got %A (%A)" value stringBytes resultString bytes

          (isMatch, Some error)) stringBytes.Length label
