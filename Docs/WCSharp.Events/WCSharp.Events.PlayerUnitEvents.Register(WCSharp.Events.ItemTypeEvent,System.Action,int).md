#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp.Events.PlayerUnitEvents')

## PlayerUnitEvents.Register(ItemTypeEvent, Action, int) Method

Registers [action](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.ItemTypeEvent,System.Action,int).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.ItemTypeEvent,System.Action,int).action 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.ItemTypeEvent, System.Action, int).action') to fire when [event](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.ItemTypeEvent,System.Action,int).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.ItemTypeEvent,System.Action,int).event 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.ItemTypeEvent, System.Action, int).event') is triggered for any item of [itemTypeId](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.ItemTypeEvent,System.Action,int).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.ItemTypeEvent,System.Action,int).itemTypeId 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.ItemTypeEvent, System.Action, int).itemTypeId').

```csharp
public static void Register(WCSharp.Events.ItemTypeEvent @event, System.Action action, int itemTypeId);
```
#### Parameters

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.ItemTypeEvent,System.Action,int).event'></a>

`event` [ItemTypeEvent](WCSharp.Events.ItemTypeEvent.md 'WCSharp.Events.ItemTypeEvent')

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.ItemTypeEvent,System.Action,int).action'></a>

`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.ItemTypeEvent,System.Action,int).itemTypeId'></a>

`itemTypeId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')