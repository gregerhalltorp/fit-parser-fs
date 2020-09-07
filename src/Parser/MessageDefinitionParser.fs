namespace FitParse

open BinParser

[<AutoOpen>]
module MessageDefinitionParser =
  let fitFileParser = new BinParser<_>()

  let architectureP =
    fitFileParser.byte1
    .>>. getUserState
    >>= fun (architecture, ous) ->
          setUserState
            { ous with
                isBigEndian = (architecture = Constants.BigEndian) }
          >>= fun () -> returnP architecture

  let numFieldsP =
    fitFileParser.byte1
    .>>. getUserState
    >>= fun (numFieldsB, ous) ->
          setUserState { ous with numFields = int numFieldsB }
          >>= fun () -> returnP numFieldsB

  let fieldP =
    fitFileParser.byte1
    .>>. fitFileParser.byte1
    .>>. fitFileParser.byte1
    >>= (fun ((fieldNum, fieldSize), fieldType) ->
    returnP
      { num = fieldNum
        size = fieldSize
        fieldType = fieldType })

  let fieldsP =
    getUserState
    >>= fun { numFields = numFields } -> manyN numFields fieldP

  let messageDefinitionP =
    matcherConsumer (fun bytes ->
      let maskedHeader = bytes.[0] &&& Constants.DefinitionMask
      (maskedHeader = Constants.DefinitionMask, Some("Expected a definition message"))) 1 "definition header"
    >>= fun bytes -> returnP (bytes.[0] &&& Constants.LocalMesgNumMask)
    .>> fitFileParser.byte1
    .>>. architectureP
    .>>. fitFileParser.uint16
    .>>. numFieldsP
    .>>. fieldsP
    .>>. getUserState
    >>= (fun (((((localMessageNumber, architecture), globalMessageNumber), numberOfFields), fields), ous) ->
    let definition =
      { localMessageNumber = localMessageNumber
        architecture = architecture
        globalMessageNumber = globalMessageNumber
        numberOfFields = numberOfFields
        fields = fields }

    setUserState
      { ous with
          definitions = ous.definitions.Add(localMessageNumber, definition) }
    >>= fun () -> returnP definition)
    <?> "messagedefinition"

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

    { parseFn = innerFn; label = "fileId message definition" }
