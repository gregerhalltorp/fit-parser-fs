open System

type ParserLabel = string
type ParserError = string

type Position = { line: int; column: int }
let initialPos = { line = 0; column = 0 }
let incrCol pos = { pos with column = pos.column + 1 }

let incrLine pos =
    { pos with
          line = pos.line + 1
          column = 0 }

type InputState =
    { lines: string []
      position: Position }

let fromStr str =
    if String.IsNullOrEmpty(str) then
        { lines = [||]; position = initialPos }
    else
        let separators = [| "\r\n"; "\n" |]

        let lines =
            str.Split(separators, StringSplitOptions.None)

        { lines = lines; position = initialPos }

let currentLine inputState =
    let linePos = inputState.position.line
    if linePos < inputState.lines.Length then inputState.lines.[linePos] else "end of file"

let nextChar input =
    let linePos = input.position.line
    let colPos = input.position.column
    if linePos >= input.lines.Length then
        (input, None)
    else
        let currentLine = currentLine input
        if colPos < currentLine.Length then
            let char = currentLine.[colPos]
            let newPos = incrCol input.position
            let newState = { input with position = newPos }
            (newState, Some char)
        else
            let char = '\n'
            let newPos = incrLine input.position
            let newState = { input with position = newPos }
            (newState, Some char)

let rec readAllChars input =
    [ let remainingInput, charOpt = nextChar input
      match charOpt with
      | None -> ()
      | Some ch ->
          yield ch
          yield! readAllChars remainingInput ]

type ParserPosition =
    { currentLine: string
      line: int
      column: int }

let parserPositionFromInputState inputState =
    { currentLine = currentLine inputState
      line = inputState.position.line
      column = inputState.position.column }

type Result<'a> =
    | Success of 'a
    | Failure of ParserLabel * ParserError * ParserPosition

type Input = InputState

type Parser<'a> =
    { parseFn: (Input -> Result<'a * Input>)
      label: ParserLabel }

let getLabel parser = parser.label

let setLabel parser newLabel =
    let newInnerFn input =
        let result = parser.parseFn input
        match result with
        | Success s -> Success s
        | Failure (_, err, pos) -> Failure(newLabel, err, pos)

    { parseFn = newInnerFn
      label = newLabel }

let (<?>) = setLabel

let printResult result =
    match result with
    | Success (value, input) -> printfn "%A" value
    | Failure (label, error, parserPos) ->
        let errorLine = parserPos.currentLine
        let colPos = parserPos.column
        let linePos = parserPos.line
        let failureCaret = sprintf "%*s^%s" colPos "" error
        printfn "Line: %i Col: %i Error parsing %s\n%s\n%s" linePos colPos label errorLine failureCaret

let runOnInput parser input =
    parser.parseFn input

let run parser inputStr =
    runOnInput parser (fromStr inputStr)

let bindP f p =
    let label = "unknown"

    let innerFn input =
        let result1 = runOnInput p input
        match result1 with
        | Failure (label, err, pos) -> Failure(label, err, pos)
        | Success (value1, rest) ->
            let p2 = f value1
            runOnInput p2 rest

    { parseFn = innerFn; label = label }

let (>>=) p f = bindP f p

let returnP x =
    let label = sprintf "%A" x
    let innerFn input = Success(x, input)
    { parseFn = innerFn; label = label }

let mapP f = bindP (f >> returnP)

let (<!>) = mapP
let (|>>) x f = mapP f x

let applyP fP xP =
    fP >>= (fun f -> xP >>= (fun x -> returnP (f x)))

let (<*>) = applyP

let lift2 f xP yP = returnP f <*> xP <*> yP

let andThen p1 p2 =
    let label =
        sprintf "%s andThen %s" (getLabel p1) (getLabel p2)

    p1
    >>= (fun p1Result ->
        p2
        >>= (fun p2Result -> returnP (p1Result, p2Result)))
    <?> label

let (.>>.) = andThen

let orElse p1 p2 =
    let label =
        sprintf "%s orElse %s" (getLabel p1) (getLabel p2)

    let innerFn input =
        let result1 = runOnInput p1 input

        match result1 with
        | Success _ -> result1
        | Failure _ -> runOnInput p2 input

    { parseFn = innerFn; label = label }

let (<|>) = orElse

let satisfy predicate label =
    let innerFn input =
        let (remainingInput, charOpt) = nextChar input
        match charOpt with
        | None ->
            let err = "No more input"
            let pos = parserPositionFromInputState input
            Failure (label, err, pos)
        | Some first ->
            if predicate first then
                Success(first, remainingInput)
            else
                let err = sprintf "Unexpected '%c'" first
                let pos = parserPositionFromInputState input
                Failure(label, err, pos)

    { parseFn = innerFn; label = label }

let pchar charToMatch =
    let label = sprintf "%c" charToMatch
    let predicate ch = (ch = charToMatch)
    satisfy predicate label

let choice listOfParsers = List.reduce (<|>) listOfParsers

let anyOf listOfChars =
    let label = sprintf "any of %A" listOfChars
    listOfChars |> List.map pchar |> choice <?> label

let rec sequence parserList =
    let cons head tail = head :: tail
    let consP = lift2 cons

    match parserList with
    | [] -> returnP []
    | head :: tail -> consP head (sequence tail)


let charListToStr charList = String(List.toArray charList)

let pstring str =
    str
    |> List.ofSeq
    |> List.map pchar
    |> sequence
    |> mapP charListToStr

let rec parseZeroOrMore parser input =
    let firstResult = runOnInput parser input
    match firstResult with
    | Failure _ -> ([], input)
    | Success (firstValue, inputAfterFirstPass) ->
        let (otherValues, remainingInput) =
            parseZeroOrMore parser inputAfterFirstPass

        let values = firstValue :: otherValues
        (values, remainingInput)

let many parser =
    let label = sprintf "many %s" (getLabel parser)
    let rec innerFn input = Success(parseZeroOrMore parser input)

    { parseFn = innerFn; label = label }

let many1 p =
    let label = sprintf "many1 %s" (getLabel p)

    let rec innerFn input =
        let firstResult = runOnInput p input
        match firstResult with
        | Failure (label, err, pos) -> Failure(label, err, pos)
        | Success (firstValue, rest) ->
            let (otherValues, remaining) = parseZeroOrMore p rest
            let values = firstValue :: otherValues
            Success(values, remaining)

    { parseFn = innerFn; label = label }

let opt p =
    let some = p |>> Some
    let none = returnP None
    some <|> none

let pint =
    let resultToInt (sign, digitList) =
        let i = String(List.toArray digitList) |> int
        match sign with
        | Some _ -> -i
        | None -> i

    let digit = anyOf [ '0' .. '9' ]

    let digits = many1 digit

    opt (pchar '-') .>>. digits |>> resultToInt

let (.>>) p1 p2 = p1 .>>. p2 |> mapP (fun (a, _) -> a)

let (>>.) p1 p2 = p1 .>>. p2 |> mapP (fun (_, b) -> b)

let between p1 p2 p3 = p1 >>. p2 .>> p3
