namespace Parse

open System
open System.Text

module ParseTypes =
    type ParserLabel = string

    type ParserError = string
    type Position = int

    type InputState = { data: byte []; position: Position }

    type Result<'Return> =
        | Success of 'Return
        // | Failure of ParserError * Position
        | Failure of ParserLabel * ParserError * int

    type Parser<'Return> =
        { parseFn: (InputState -> Result<'Return>)
          label: ParserLabel }
    // type Parser<'Return> = InputState -> Result<'Return * InputState>

    let run p i = p.parseFn i

    let getLabel p = p.label

    let setLabel p l =
        let newInnerFn input =
            let result = p.parseFn input
            match result with
            | Success s -> Success s
            | Failure (_, err, pos) -> Failure(l, err, pos)

        { parseFn = newInnerFn; label = l }

    let (<?>) = setLabel

    let bindP (f: _ -> Parser<_>) (p: Parser<_>): Parser<_> =
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

    let mapP f = bindP (f >> returnP)
    let (|>>) x f = mapP f x

    let canConsume state count =
        let endPos = count + state.position
        if endPos > state.data.Length then None else Some(count)

    let consume count state =
        let endPos = count + state.position
        if endPos > state.data.Length then
            None
        else
            let bytes =
                state.data.[state.position..(endPos - 1)]

            let newState = { state with position = endPos }
            Some(bytes, newState)

    let matcher predicate count label: Parser<_> =
        let innerFn input =
            match consume count input with
            | None -> Failure(label, "Ran out of data", input.position)
            | Some (bytes, newState) ->
                if predicate bytes
                then Success(bytes, newState)
                else Failure(label, "Unexpected data", input.position)

        { parseFn = innerFn; label = label }

    let binMatch label (num: int) = matcher (fun _ -> true) num label

    let toInt16 v = BitConverter.ToInt16(v, 0)
    let toInt32 v = BitConverter.ToInt32(v, 0)
    let toCharArr ca = ca |> Array.map char

    let byteN: int -> Parser<_> = binMatch "dodo"

    let byte1 =
        byteN 1
        >>= fun b1 -> returnP b1.[0]

    let int16 = byteN 2 |>> toInt16
    let int32 = byteN 4 |>> toInt32

    let charArr n = byteN n |>> toCharArr

    let toBytes (str: string) = Encoding.UTF8.GetBytes(str)

    let stringMatch (value: string) =
        let label = sprintf "matching string %s" value
        let stringBytes = Encoding.UTF8.GetBytes(value)
        matcher (fun bytes -> bytes = stringBytes) stringBytes.Length label

    type Header =
        { size: byte
          protocolVersion: byte
          profileVersion: int16
          dataSize: int
          dataType: char [] }
    // crc: int16 }

    let headerP =
        (byte1
         .>>. byte1
         .>>. int16
         .>>. int32
         .>>. (stringMatch ".FIT" |>> toCharArr)
         >>= fun ((((size, protocolVersion), profileVersion), dataSize), dataType) ->
             returnP
                 { size = size
                   protocolVersion = protocolVersion
                   profileVersion = profileVersion
                   dataSize = dataSize
                   dataType = dataType })
        <?> "header"

    let printResult result =
        match result with
        | Success (value, _) -> printfn "%A" value
        | Failure (label, error, pos) -> printfn "Error parsing %s at position %i: %s" label pos error

    let parseFitFile input = run headerP input |> printResult

    let parseFitFile2 input =
        match run headerP input with
        | Success (value, _) -> value
        | Failure (_) -> failwith "Errors and shit"
