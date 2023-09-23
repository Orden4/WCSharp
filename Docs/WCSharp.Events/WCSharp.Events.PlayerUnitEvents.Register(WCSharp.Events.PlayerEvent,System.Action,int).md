#### [WCSharp.Events](index.md 'index')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp.Events.PlayerUnitEvents')

## PlayerUnitEvents.Register(PlayerEvent, Action, int) Method

Registers [action](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action,int).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action,int).action 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent, System.Action, int).action') to fire when [event](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action,int).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action,int).event 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent, System.Action, int).event') is triggered for [playerId](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action,int).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action,int).playerId 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent, System.Action, int).playerId').  
  
Note: [playerId](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action,int).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action,int).playerId 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent, System.Action, int).playerId') start at 0. So player 1 (red) is 0.

```csharp
public static void Register(WCSharp.Events.PlayerEvent @event, System.Action action, int playerId);
```
#### Parameters

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action,int).event'></a>

`event` [PlayerEvent](WCSharp.Events.PlayerEvent.md 'WCSharp.Events.PlayerEvent')

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action,int).action'></a>

`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action,int).playerId'></a>

`playerId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')