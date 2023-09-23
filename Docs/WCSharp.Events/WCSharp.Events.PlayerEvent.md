#### [WCSharp.Events](index.md 'index')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events')

## PlayerEvent Enum

Defines all built-in PlayerEvents supported by [PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp.Events.PlayerUnitEvents').  
  
All of these events fire based on a player id.  
  
Custom events can also be specified via [AddCustomEvent(string, Func&lt;int&gt;, playerunitevent)](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,War3Api.Common.playerunitevent).md 'WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string, System.Func<int>, War3Api.Common.playerunitevent)').

```csharp
public enum PlayerEvent
```
### Fields

<a name='WCSharp.Events.PlayerEvent.DeselectsUnit'></a>

`DeselectsUnit` 401

Based on EVENT_PLAYER_UNIT_DESELECTED

<a name='WCSharp.Events.PlayerEvent.GainsOwnership'></a>

`GainsOwnership` 402

Based on EVENT_PLAYER_UNIT_CHANGE_OWNER

<a name='WCSharp.Events.PlayerEvent.LosesOwnership'></a>

`LosesOwnership` 403

Based on EVENT_PLAYER_UNIT_CHANGE_OWNER

<a name='WCSharp.Events.PlayerEvent.SelectsUnit'></a>

`SelectsUnit` 404

Based on EVENT_PLAYER_UNIT_SELECTED