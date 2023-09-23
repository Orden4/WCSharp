### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp.Events.PlayerUnitEvents')

## PlayerUnitEvents.Register(UnitTypeEvent, Action) Method

Registers [action](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent,System.Action).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent,System.Action).action 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent, System.Action).action') to fire when [event](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent,System.Action).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent,System.Action).event 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent, System.Action).event') is triggered for any unit.

```csharp
public static void Register(WCSharp.Events.UnitTypeEvent @event, System.Action action);
```
#### Parameters

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent,System.Action).event'></a>

`event` [UnitTypeEvent](WCSharp.Events.UnitTypeEvent.md 'WCSharp.Events.UnitTypeEvent')

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent,System.Action).action'></a>

`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')