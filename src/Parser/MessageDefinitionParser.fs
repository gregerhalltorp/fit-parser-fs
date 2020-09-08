namespace FitParse

open BinParser
open Fit2
open Fit2.TypeDefinitions
open Fit2.Types

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

  let fieldDefinitionP =
    fitFileParser.byte1
    .>>. fitFileParser.byte1
    .>>. fitFileParser.byte1
    >>= (fun ((fieldNum, fieldSize), fieldType) ->
    returnP
      { num = fieldNum
        size = fieldSize
        fieldType = fieldType })

  let fieldDefinitionsP =
    getUserState
    >>= fun { numFields = numFields } -> manyN numFields fieldDefinitionP

  let messageDefinitionP =
    matcherConsumer (fun bytes ->
      let maskedHeader = bytes.[0] &&& Constants.DefinitionMask
      (maskedHeader = Constants.DefinitionMask, Some("Expected a definition message"))) 1 "definition header"
    >>= fun bytes -> returnP (bytes.[0] &&& Constants.LocalMesgNumMask)
    .>> fitFileParser.byte1
    .>>. architectureP
    .>>. fitFileParser.uint16
    .>>. numFieldsP
    .>>. fieldDefinitionsP
    .>>. getUserState
    >>= (fun (((((localMessageNumber, architecture), globalMessageNumber), numberOfFields), fieldDefinitions), ous) ->
    let definition =
      { localMessageNumber = localMessageNumber
        architecture = architecture
        globalMessageNumber = getMesgNum globalMessageNumber
        numberOfFields = numberOfFields
        fieldDefinitions = fieldDefinitions }

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
          if v.globalMessageNumber = MesgNum.FileId
          then Success(v, s)
          else Failure("fileId message definition", "Expected fileId definition", s.position)

    { parseFn = innerFn; label = "fileId message definition" }
