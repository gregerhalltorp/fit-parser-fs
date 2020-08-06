namespace Fit

module Message =
    open Profile
    open DomainTypes
    open System

    let CompressedHeaderMask = 0x80uy
    let MesgDefinitionMask = 0x40uy
    let MesgHeaderMask = 0x00uy
    let DevDataMask = 0x20uy
    let LocalMesgNumMask = 0x0Fuy

    let (|``Compressed timestamp message``|``Message definition``|``Data message``|Other|) firstByte =
        if (firstByte &&& CompressedHeaderMask) = CompressedHeaderMask
        then ``Compressed timestamp message``
        elif (firstByte &&& MesgDefinitionMask) = MesgDefinitionMask
        then ``Message definition``
        elif (firstByte &&& MesgDefinitionMask) = MesgHeaderMask
        then ``Data message``
        else Other

    let readMessageDefinition (data: byte array) =
        let localMessageNumber = data.[0] &&& LocalMesgNumMask
        let architecture = data.[2]
        let globalMessageNumber = BitConverter.ToUInt16(data, 3)
        let numFields = data.[5]
        let endByte = (int numFields) * 3 + 5

        let rec getFields (data: byte array) (fields: List<FieldDefinition>) =
            match data.Length with
            | 0 -> fields
            | _ ->
                getFields data.[3..] fields
                @ [ { Num = data.[0]
                      Size = data.[1]
                      Type = data.[2] } ]

        let fields = getFields data.[6..endByte] []

        if (data.[0] &&& DevDataMask) = DevDataMask then printfn "has dev data" else ()

        (MessageDefinition
            { LocalMsgNum = localMessageNumber
              Architecture = architecture
              GlobalMsgNum = LanguagePrimitives.EnumOfValue globalMessageNumber
              NumFields = numFields
              Fields = fields },
         endByte + 1)

    let readDataMessage (data: byte array) (messages: Message list) =
        let localMessageNumber = data.[0] &&& LocalMesgNumMask

        let def =
            messages
            |> List.choose (function
                | MessageDefinition (d) -> Some(d)
                | _ -> None)
            |> List.find (fun m -> m.LocalMsgNum = localMessageNumber)

        let message = DataMessage (parseMessage data.[1..] def)
        printfn "The message was: %A" message

        ()

    let rec readMessages (data: byte array) (messages: List<Message>) =
        match data.Length with
        | 0 -> messages
        | _ ->
            match data.[0] with
            | ``Compressed timestamp message`` ->
                printfn "compressed timestamp"
                readMessages [||] messages

            | ``Message definition`` ->
                let (messageDefinition, nextByte) = readMessageDefinition data
                printfn "message definition%A" messageDefinition
                readMessages
                    data.[nextByte..]
                    (List.concat [ messages
                                   [ messageDefinition ] ])

            | ``Data message`` ->
                printfn "data message"
                readDataMessage data messages
                readMessages [||] messages

            | Other ->
                printfn "something else"
                readMessages [||] messages
