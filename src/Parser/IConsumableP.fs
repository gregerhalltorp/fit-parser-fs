namespace Parser

type IConsumableP<'StateType, 'ConsumeType, 'UserState> =
  abstract state: 'StateType
  abstract consume: int -> ('ConsumeType * IConsumableP<'StateType, 'ConsumeType, 'UserState>) option
  abstract getUserState: unit -> 'UserState
  abstract setUserState: 'UserState -> unit
  abstract position: unit -> int64