#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events')

## ItemEvent Enum

Defines all built\-in ItemEvents supported by [PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp\.Events\.PlayerUnitEvents')\.

All of these events fire based on an item filter.

Custom events can also be specified via [AddCustomEvent\(string, Func&lt;int&gt;, playerunitevent\)](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).md 'WCSharp\.Events\.PlayerUnitEvents\.AddCustomEvent\(string, System\.Func\<int\>, WCSharp\.Api\.playerunitevent\)').

```csharp
public enum ItemEvent
```
### Fields

<a name='WCSharp.Events.ItemEvent.IsAbsorbed'></a>

`IsAbsorbed` 201

Based on EVENT\_PLAYER\_UNIT\_PICKUP\_ITEM

<a name='WCSharp.Events.ItemEvent.IsDropped'></a>

`IsDropped` 202

Based on EVENT\_PLAYER\_UNIT\_DROP\_ITEM

<a name='WCSharp.Events.ItemEvent.IsPawned'></a>

`IsPawned` 203

Based on EVENT\_PLAYER\_UNIT\_PAWN\_ITEM

<a name='WCSharp.Events.ItemEvent.IsPickedUp'></a>

`IsPickedUp` 204

Based on EVENT\_PLAYER\_UNIT\_PICKUP\_ITEM

<a name='WCSharp.Events.ItemEvent.IsSold'></a>

`IsSold` 205

Based on EVENT\_PLAYER\_UNIT\_SELL\_ITEM

<a name='WCSharp.Events.ItemEvent.IsStacked'></a>

`IsStacked` 206

Based on EVENT\_PLAYER\_UNIT\_STACK\_ITEM

<a name='WCSharp.Events.ItemEvent.IsUsed'></a>

`IsUsed` 207

Based on EVENT\_PLAYER\_UNIT\_USE\_ITEM