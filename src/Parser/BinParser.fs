namespace BinParser

module Parse =
  type InputState<'UserState> =
    { data: byte []
      position: int
      userState: 'UserState }
