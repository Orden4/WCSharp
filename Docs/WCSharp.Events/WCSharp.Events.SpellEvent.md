#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events')

## SpellEvent Enum

Defines all built\-in SpellEvents supported by [PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp\.Events\.PlayerUnitEvents')\.

All of these events fire based on a ability id filter.

Custom events can also be specified via [AddCustomEvent\(string, Func&lt;int&gt;, playerunitevent\)](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).md 'WCSharp\.Events\.PlayerUnitEvents\.AddCustomEvent\(string, System\.Func\<int\>, WCSharp\.Api\.playerunitevent\)').

```csharp
public enum SpellEvent
```
### Fields

<a name='WCSharp.Events.SpellEvent.Cast'></a>

`Cast` 601

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CAST

<a name='WCSharp.Events.SpellEvent.Channel'></a>

`Channel` 602

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CHANNEL

<a name='WCSharp.Events.SpellEvent.Effect'></a>

`Effect` 603

Based on EVENT\_PLAYER\_UNIT\_SPELL\_EFFECT

<a name='WCSharp.Events.SpellEvent.EndCast'></a>

`EndCast` 604

Based on EVENT\_PLAYER\_UNIT\_SPELL\_ENDCAST

<a name='WCSharp.Events.SpellEvent.Finish'></a>

`Finish` 605

Based on EVENT\_PLAYER\_UNIT\_SPELL\_FINISH

<a name='WCSharp.Events.SpellEvent.Learned'></a>

`Learned` 606

Based on EVENT\_PLAYER\_HERO\_SKILL