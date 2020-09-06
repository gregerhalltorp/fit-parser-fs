namespace Parse

open System
open System.Text
open Fit

module ParseTypes =
  type ParserLabel = string

  type ParserError = string
  type Position = int

  // Make inputstate optional!
  type InputState<'UserState> =
    { data: byte []
      position: Position
      userState: 'UserState }

  type Result<'Return, 'UserState> =
    | Success of 'Return * InputState<'UserState>
    // | Failure of ParserError * Position
    | Failure of ParserLabel * ParserError * int

  type Parser<'Return, 'UserState> =
    { parseFn: (InputState<'UserState> -> Result<'Return, 'UserState>)
      label: ParserLabel }
  // type Parser<'Return> = InputState -> Result<'Return * InputState>
  type FieldDefinition =
    { num: byte
      size: byte
      fieldType: byte }

  type MessageDefinition =
    { localMessageNumber: byte
      architecture: byte
      globalMessageNumber: uint16
      numberOfFields: byte
      fields: FieldDefinition list }

  type FitState =
    { headerSize: byte
      isBigEndian: bool
      numFields: int
      definitions: Map<byte, MessageDefinition>
      currentDefinition: MessageDefinition option }

  let run p i = p.parseFn i

  let getLabel p = p.label

  let setLabel p l =
    let newInnerFn input =
      let result = p.parseFn input
      match result with
      | Success (v, s) -> Success(v, s)
      | Failure (_, err, pos) -> Failure(l, err, pos)

    { parseFn = newInnerFn; label = l }

  let (<?>) = setLabel

  let getUserState =
    { parseFn = fun state -> Success(state.userState, state)
      label = "getUserState" }

  let setUserState userState =
    { parseFn = fun state -> Success((), { state with userState = userState })
      label = "setUserState" }

  let updateUserState nus =
    { parseFn = fun state -> Success((), { state with userState = nus })
      label = "updateUserState" }

  let bindP (f: _ -> Parser<_, _>) (p: Parser<_, _>): Parser<_, _> =
    let label = "unknown"

    let innerFn input =
      let result1 = run p input
      match result1 with
      | Failure (label, error, pos) -> Failure(label, error, pos)
      | Success (value1, newState) ->
          let p2 = f value1
          run p2 newState

    { parseFn = innerFn; label = label }

  let (>>=) p f = bindP f p

  let returnP x =
    let label = sprintf "%A" x
    let innerFn input = Success(x, input)
    { parseFn = innerFn; label = label }

  let andThen p1 p2 =
    let label =
      sprintf "%s andThen %s" (getLabel p1) (getLabel p2)

    p1
    >>= fun p1Result ->
          p2
          >>= fun p2Result -> returnP (p1Result, p2Result)
    <?> label

  let (.>>.) = andThen

  let orElse p1 p2 =
    let innerFn state =
      let r1 = run p1 state
      match r1 with
      | Success (_) -> r1
      | Failure _ -> run p2 state

    { parseFn = innerFn; label = "orElse" }

  let (<|>) = orElse

  let mapP f = bindP (f >> returnP)
  let (|>>) x f = mapP f x

  let (.>>) p1 p2 = p1 .>>. p2 |> mapP (fun (a, _) -> a)
  let (>>.) p1 p2 = p1 .>>. p2 |> mapP (fun (_, b) -> b)

  let manyN num parser =
    let innerFn input =
      let rec funky count currState resultList =
        if count = num then
          Success(resultList |> List.rev, currState)
        else
          let result = run parser currState
          match result with
          | Failure (_, _, pos) -> Failure("manyN", (sprintf "Tried to read %i items but found only %i" num count), pos)
          | Success (v, s) -> funky (count + 1) s (v :: resultList)

      funky 0 input []

    { parseFn = innerFn; label = "manyN" }


  let canConsume state count =
    let endPos = count + state.position
    if endPos > state.data.Length then None else Some(count)

  // Idea: make this into a parser instead and don't use the matcher when we don't have to?
  // But how? The prediacate matcher'll need to be chained to this one (>>), is it worth it?
  // Do it with returnP? Could be the solution
  // Also fix so we return the correct position here instead of the start of the consume
  let consume count state =
    let endPos = count + state.position
    if endPos > state.data.Length then
      None
    else
      let bytes =
        state.data.[state.position..(endPos - 1)]

      let newState = { state with position = endPos }
      Some(bytes, newState)

  let matcherConsumer predicate count label: Parser<_, _> =
    let innerFn (input: InputState<'UserState>) =
      match consume count input with
      | None -> Failure(label, "Ran out of data", input.position)
      | Some (bytes, newState) ->
          let (isMatch, error) = predicate bytes
          if isMatch then
            Success(bytes, newState)
          else
            match error with
            | Some (msg) -> Failure(label, msg, input.position)
            | None -> Failure(label, "Unexpected data", input.position)

    { parseFn = innerFn; label = label }

  let matchUserState predicate label =
    let innerFn state =
      let result = run getUserState state
      match result with
      | Failure (_) -> raise (Exception("spectacular"))
      | Success (us, state) ->
          if predicate us
          then Success(true, state)
          else Failure(label, "UserState didn't match", state.position)

    { parseFn = innerFn; label = label }

  let binMatch label (num: int): Parser<_, 'UserState> =
    matcherConsumer (fun _ -> (true, None)) num label

  let toInt16 v = BitConverter.ToInt16(v, 0)
  let toUInt16 v = BitConverter.ToUInt16(v, 0)
  let toInt32 v = BitConverter.ToInt32(v, 0)
  let toCharArr bytes = bytes |> Array.map char

  let byteN: int -> Parser<_, 'UserState> = binMatch "dodo"

  let byte1 =
    byteN 1
    >>= fun b1 -> returnP b1.[0]

  let int8 = byteN 1 |>> toInt32
  let int16 = byteN 2 |>> toInt16
  let uint16 = byteN 2 |>> toUInt16
  let int32 = byteN 4 |>> toInt32

  let charArr n = byteN n |>> toCharArr

  let toBytes (str: string) = Encoding.UTF8.GetBytes(str)

  let stringMatch (value: string) =
    let label = sprintf "matching string %s" value
    let stringBytes = Encoding.UTF8.GetBytes(value)
    matcherConsumer (fun bytes ->
      let isMatch = bytes = stringBytes
      if isMatch then
        (isMatch, None)
      else
        let resultString = (toCharArr bytes) |> String

        let error =
          sprintf "Expected %A (%A), got %A (%A)" value stringBytes resultString bytes

        (isMatch, Some error)) stringBytes.Length label

  type FitParser<'Return> = Parser<'Return, FitState>

  let protocolVersionP: Parser<_, FitState> =
    let innerFn state =
      let result =
        run
          (matcherConsumer (fun bytes ->
            let protocolVersion = bytes.[0]

            let interm1 =
              protocolVersion
              &&& Constants.protocolVersionMajorMask

            (interm1 <= Constants.protocolVersionCheck, None)) 1 "dong")
          state

      match result with
      | Failure (label, error, pos) ->
          if error = "Ran out of data"
          then Failure(label, error, pos)
          else Failure(label, "Protocol version not supported", pos)
      | Success (v, s) -> Success(v.[0], s)

    { parseFn = innerFn; label = "shabba" }
    <?> "ddoboobooboobobooboboobob"


  let headerSizeP =
    byte1
    .>>. getUserState
    >>= fun (size, ous) ->
          setUserState { ous with headerSize = size }
          >>= fun () -> returnP size

  let crcP =
    let p1 =
      matchUserState (fun us -> us.headerSize = 12uy) "match header size"
      >>. returnP 0s

    let p2 =
      matchUserState (fun us -> us.headerSize = 14uy) "match header size"
      >>. int16

    p1 <|> p2

  type Header =
    { size: byte
      protocolVersion: byte
      profileVersion: int16
      dataSize: int
      dataType: char []
      crc: int16 }

  type File =
    { header: Header
      definitions: MessageDefinition list }

  let headerP: FitParser<_> =
    (headerSizeP
     .>>. protocolVersionP
     .>>. int16
     .>>. int32
     .>>. (stringMatch ".FIT" |>> toCharArr)
     .>>. crcP
     >>= fun (((((size, protocolVersion), profileVersion), dataSize), dataType), crc) ->
       returnP
         { size = size
           protocolVersion = protocolVersion
           profileVersion = profileVersion
           dataSize = dataSize
           dataType = dataType
           crc = crc })
    <?> "header"

  let architectureP =
    byte1
    .>>. getUserState
    >>= fun (architecture, ous) ->
          setUserState
            { ous with
                isBigEndian = (architecture = Constants.BigEndian) }
          >>= fun () -> returnP architecture

  let numFieldsP =
    byte1
    .>>. getUserState
    >>= fun (numFieldsB, ous) ->
          setUserState { ous with numFields = int numFieldsB }
          >>= fun () -> returnP numFieldsB

  let fieldP =
    byte1
    .>>. byte1
    .>>. byte1
    >>= (fun ((fieldNum, fieldSize), fieldType) ->
    returnP
      { num = fieldNum
        size = fieldSize
        fieldType = fieldType })

  let fieldsP =
    let parser =
      getUserState
      >>= fun { numFields = numFields } -> manyN numFields fieldP

    parser

  // Fix this! I want to do: byte1 .>> satisifies
  let messageDefinitionP: FitParser<_> =
    matcherConsumer (fun bytes ->
      let maskedHeader = bytes.[0] &&& Constants.DefinitionMask
      (maskedHeader = Constants.DefinitionMask, Some("Expected a definition message"))) 1 "dong"
    >>= fun bytes -> returnP (bytes.[0] &&& Constants.LocalMesgNumMask)
    .>> byte1
    .>>. architectureP
    .>>. uint16
    .>>. numFieldsP
    .>>. fieldsP
    .>>. getUserState
    >>= (fun (((((localMessageNumber, architecture), globalMessageNumber), numerOfFields), fields), ous) ->
    let definition =
      { localMessageNumber = localMessageNumber
        architecture = architecture
        globalMessageNumber = globalMessageNumber
        numberOfFields = numerOfFields
        fields = fields }

    setUserState
      { ous with
          definitions = ous.definitions.Add(localMessageNumber, definition) }
    >>= fun () -> returnP definition)
    <?> "messagedefinition"

  // set the current definition in the userstate
  let dataMessageP: FitParser<_> =
    matcherConsumer (fun bytes ->
      let maskedHeader = bytes.[0] &&& Constants.DefinitionMask
      (maskedHeader = Constants.DataMask, Some("Expected a data message"))) 1 "dong"
    >>= (fun bytes -> returnP (bytes.[0] &&& Constants.LocalMesgNumMask))
    >>= (fun localMessageNumber -> 
    matchUserState (fun (ous:FitState) -> ous.definitions.ContainsKey(localMessageNumber)) "shabba"
      >>= (fun _ -> returnP localMessageNumber))
    .>>. getUserState
    >>= (fun (lmn, ous) -> 
      setUserState {ous with currentDefinition = Some(ous.definitions.[lmn])}
      >>= fun () -> returnP lmn)
    <?> "datamessage"

  // TODO: Use fileId messageNumber (another file with constants)
  let fileIdDefP =
    let innerFn state =
      let result = run messageDefinitionP state
      match result with
      | Failure (label, error, pos) -> Failure(label, error, pos)
      | Success (v, s) ->
          if v.globalMessageNumber = 0us
          then Success(v, s)
          else Failure("fileId message definition", "Expected fileId definition", s.position)

    { parseFn = innerFn; label = "aslfk" }

  let fileParser: FitParser<_> =
    headerP
    .>>. fileIdDefP
    >>= (fun (header, fileIdDefinition) ->
    returnP
      { header = header
        definitions = [ fileIdDefinition ] })

  let printResult result =
    match result with
    | Success (value, state) -> printfn "%A\n(userState:%A)" value state.userState
    | Failure (label, error, pos) -> printfn "Error parsing %s at position %i: %s" label pos error

  let prettyParseFitFile input = run headerP input |> printResult

  let parseFitFile input = run fileParser input

  let parseFitFile2 input =
    match run headerP input with
    | Success (value, _) -> value
    | Failure (_) -> failwith "Errors and shit"
