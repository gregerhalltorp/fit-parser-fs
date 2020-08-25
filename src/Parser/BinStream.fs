namespace Parser

open System.IO

module BinProviders =
  type ArrayState = { data: byte []; position: int }

  let inline initBytes size = Array.create size <| byte (0)

  let private readFromStream count (stream: Stream) =
    let b = initBytes count

    stream.Read(b, 0, count) |> ignore

    b

  type BinStream<'UserState>(state: Stream, userState: 'UserState) =
    let mutable userState = userState

    member x.clone() =
      new BinStream<'UserState>(state, userState) :> IConsumableP<Stream, byte [], 'UserState>

    interface IConsumableP<Stream, byte [], 'UserState> with

      member x.state = state

      member x.consume(count) =
        let b = readFromStream count state

        Some(b, x.clone ())

      member x.getUserState() = userState

      member x.setUserState s = userState <- s

      member x.position () = state.Position

  type BinArray<'UserState>(state: ArrayState, userState: 'UserState) =
    let mutable userState = userState

    member x.getNew newState =
      new BinArray<'UserState>(newState, userState) :> IConsumableP<ArrayState, byte [], 'UserState>

    interface IConsumableP<ArrayState, byte [], 'UserState> with
      member x.state = state

      member x.consume(count) =
        let endPos = count + int state.position
        if endPos > state.data.Length then
          None
        else
          let bytes =
            state.data.[state.position..(endPos - 1)]

          let newState = { state with position = endPos }
          Some((bytes), x.getNew newState)

      member x.getUserState() = userState

      member x.setUserState s = userState <- s

      member x.position () = int64 state.position