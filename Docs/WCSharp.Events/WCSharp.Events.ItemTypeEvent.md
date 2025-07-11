#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events')

## ItemTypeEvent Enum

Defines all built\-in ItemTypeEvents supported by [PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp\.Events\.PlayerUnitEvents')\.

All of these events fire based on an item type id filter.

Custom events can also be specified via [AddCustomEvent\(string, Func&lt;int&gt;, playerunitevent\)](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).md 'WCSharp\.Events\.PlayerUnitEvents\.AddCustomEvent\(string, System\.Func\<int\>, WCSharp\.Api\.playerunitevent\)').

```csharp
public enum ItemTypeEvent
```
### Fields

<a name='WCSharp.Events.ItemTypeEvent.IsAbsorbed'></a>

`IsAbsorbed` 301

Based on EVENT\_PLAYER\_UNIT\_PICKUP\_ITEM

<a name='WCSharp.Events.ItemTypeEvent.IsDropped'></a>

`IsDropped` 302

Based on EVENT\_PLAYER\_UNIT\_DROP\_ITEM

<a name='WCSharp.Events.ItemTypeEvent.IsPawned'></a>

`IsPawned` 303

Based on EVENT\_PLAYER\_UNIT\_PAWN\_ITEM

<a name='WCSharp.Events.ItemTypeEvent.IsPickedUp'></a>

`IsPickedUp` 304

Based on EVENT\_PLAYER\_UNIT\_PICKUP\_ITEM

<a name='WCSharp.Events.ItemTypeEvent.IsSold'></a>

`IsSold` 305

Based on EVENT\_PLAYER\_UNIT\_SELL\_ITEM

<a name='WCSharp.Events.ItemTypeEvent.IsStacked'></a>

`IsStacked` 306

Based on EVENT\_PLAYER\_UNIT\_STACK\_ITEM

<a name='WCSharp.Events.ItemTypeEvent.IsUsed'></a>

`IsUsed` 307

Based on EVENT\_PLAYER\_UNIT\_USE\_ITEM