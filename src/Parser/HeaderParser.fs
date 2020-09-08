namespace FitParse

open BinParser
open Fit2.TypeDefinitions

[<AutoOpen>]
module HeaderParser =
  let fitFileParser = new BinParser<_>()

  let headerSizeP =
    fitFileParser.byte1
    .>>. getUserState
    >>= fun (size, ous) ->
          setUserState { ous with headerSize = size }
          >>= fun () -> returnP size

  let protocolVersionP: Parser<_, FitState> =
    matcherConsumer (fun bytes ->
      let protocolVersion = bytes.[0]

      let maskedProtocolVersion =
        protocolVersion
        &&& Constants.protocolVersionMajorMask

      (maskedProtocolVersion
       <= Constants.protocolVersionCheck,
       Some "Protocol version not supported")) 1 "protocolVersionChecker"
    |>> getFirstByte

  let crcP =
    let p1 =
      matchUserState (fun us -> us.headerSize = 12uy) "match header size"
      >>. returnP 0s

    let p2 =
      matchUserState (fun us -> us.headerSize = 14uy) "match header size"
      >>. fitFileParser.int16

    p1 <|> p2

  let headerP =
    headerSizeP
    .>>. protocolVersionP
    .>>. fitFileParser.int16
    .>>. fitFileParser.int32
    .>>. (fitFileParser.matchStringBytes ".FIT"
          |>> toCharArray)
    .>>. crcP
    >>= (fun (((((size, protocolVersion), profileVersion), dataSize), dataType), crc) ->
    returnP
      { size = size
        protocolVersion = protocolVersion
        profileVersion = profileVersion
        dataSize = dataSize
        dataType = dataType
        crc = crc })
    <?> "header"
