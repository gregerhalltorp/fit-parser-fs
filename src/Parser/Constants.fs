namespace Fit

module Constants =
  let protocolVersionMajorShift = 4
  let protocolVersionMajorMask = (0x0Fuy <<< protocolVersionMajorShift)
  let protocolMajorVersion = 2uy

  let protocolVersionCheck =
    protocolMajorVersion <<< protocolVersionMajorShift

  let CompressedHeaderMask = 0x80uy
  let DefinitionMask = 0x40uy
  let DataMask = 0x00uy
  let LocalMesgNumMask = 0x0Fuy
  let LittleEndian = 0uy
  let BigEndian = 1uy

module ErrorMessages =
  let protocolErrorMessage thisMajor sdkMajor sdkMinor =
    sprintf "FIT decode error: Protocol Version %i.X not supported by SDK Protocol Ver%i.%i" thisMajor sdkMajor sdkMinor

  let missingDefinitionErrorMessage localMesgNum position =
    sprintf
      "Decode:DecodeNextMessage - FIT decode error: Missing message definition for local message number %A at stream position %i"
      localMesgNum
      position
