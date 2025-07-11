#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events')

## HeroEvent Enum

Defines all built\-in HeroEvents supported by [PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp\.Events\.PlayerUnitEvents')\.

All of these events fire based on a unit handle filter.

Custom events can also be specified via [AddCustomEvent\(string, Func&lt;int&gt;, playerunitevent\)](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).md 'WCSharp\.Events\.PlayerUnitEvents\.AddCustomEvent\(string, System\.Func\<int\>, WCSharp\.Api\.playerunitevent\)').

```csharp
public enum HeroEvent
```
### Fields

<a name='WCSharp.Events.HeroEvent.BecomesRevivable'></a>

`BecomesRevivable` 1

Based on EVENT\_PLAYER\_HERO\_REVIVABLE

<a name='WCSharp.Events.HeroEvent.CancelsRevive'></a>

`CancelsRevive` 2

Based on EVENT\_PLAYER\_HERO\_REVIVE\_CANCEL

<a name='WCSharp.Events.HeroEvent.FinishesRevive'></a>

`FinishesRevive` 3

Based on EVENT\_PLAYER\_HERO\_REVIVE\_FINISH

<a name='WCSharp.Events.HeroEvent.LearnsSpell'></a>

`LearnsSpell` 4

Based on EVENT\_PLAYER\_HERO\_SKILL

<a name='WCSharp.Events.HeroEvent.Levels'></a>

`Levels` 5

Based on EVENT\_PLAYER\_HERO\_LEVEL

<a name='WCSharp.Events.HeroEvent.StartsRevive'></a>

`StartsRevive` 6

Based on EVENT\_PLAYER\_HERO\_REVIVE\_START