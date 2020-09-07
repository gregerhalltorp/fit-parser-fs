namespace FitParse

open BinParser

[<AutoOpen>]
module DataMessageParser =
  // let fitFileParser = new BinParser<_>()

  let localMessageNumberP =
    matcherConsumer (fun bytes ->
      let maskedHeader = bytes.[0] &&& Constants.DefinitionMask
      (maskedHeader = Constants.DataMask, Some("Expected a data message"))) 1 "data message matcher"
    |>> fun bytes -> bytes.[0] &&& Constants.LocalMesgNumMask
    >>= (fun localMessageNumber ->
    matchUserState (fun (ous: FitState) -> ous.definitions.ContainsKey(localMessageNumber)) "definitionlist checker"
    |>> fun _ -> localMessageNumber)
    .>>. getUserState
    >>= (fun (lmn, ous) ->
    setUserState
      { ous with
          currentDefinition = Some(ous.definitions.[lmn]) }
    |>> fun () -> lmn)

  // set the current definition in the userstate
  let dataMessageP = localMessageNumberP <?> "datamessage"
