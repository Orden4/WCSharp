### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp.Events.PlayerUnitEvents')

## PlayerUnitEvents.Register(PlayerEvent, Action) Method

Registers [action](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action).action 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent, System.Action).action') to fire when [event](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action).event 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent, System.Action).event') is triggered for any player.

```csharp
public static void Register(WCSharp.Events.PlayerEvent @event, System.Action action);
```
#### Parameters

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action).event'></a>

`event` [PlayerEvent](WCSharp.Events.PlayerEvent.md 'WCSharp.Events.PlayerEvent')

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.PlayerEvent,System.Action).action'></a>

`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')