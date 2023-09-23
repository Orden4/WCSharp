### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp.Events.PlayerUnitEvents')

## PlayerUnitEvents.Register(UnitTypeEvent, Action, int) Method

Registers [action](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent,System.Action,int).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent,System.Action,int).action 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent, System.Action, int).action') to fire when [event](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent,System.Action,int).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent,System.Action,int).event 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent, System.Action, int).event') is triggered for any unit.

```csharp
public static void Register(WCSharp.Events.UnitTypeEvent @event, System.Action action, int unitTypeId);
```
#### Parameters

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent,System.Action,int).event'></a>

`event` [UnitTypeEvent](WCSharp.Events.UnitTypeEvent.md 'WCSharp.Events.UnitTypeEvent')

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent,System.Action,int).action'></a>

`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.UnitTypeEvent,System.Action,int).unitTypeId'></a>

`unitTypeId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')