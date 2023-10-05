#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp.Events.PlayerUnitEvents')

## PlayerUnitEvents.Register(SpellEvent, Action, int) Method

Registers [action](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.SpellEvent,System.Action,int).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.SpellEvent,System.Action,int).action 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.SpellEvent, System.Action, int).action') to fire when [event](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.SpellEvent,System.Action,int).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.SpellEvent,System.Action,int).event 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.SpellEvent, System.Action, int).event') is triggered for any spell of [abilityId](WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.SpellEvent,System.Action,int).md#WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.SpellEvent,System.Action,int).abilityId 'WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.SpellEvent, System.Action, int).abilityId').

```csharp
public static void Register(WCSharp.Events.SpellEvent @event, System.Action action, int abilityId);
```
#### Parameters

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.SpellEvent,System.Action,int).event'></a>

`event` [SpellEvent](WCSharp.Events.SpellEvent.md 'WCSharp.Events.SpellEvent')

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.SpellEvent,System.Action,int).action'></a>

`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

<a name='WCSharp.Events.PlayerUnitEvents.Register(WCSharp.Events.SpellEvent,System.Action,int).abilityId'></a>

`abilityId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')