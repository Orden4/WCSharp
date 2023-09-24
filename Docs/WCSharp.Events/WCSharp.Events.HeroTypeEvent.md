#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events')

## HeroTypeEvent Enum

Defines all built-in HeroTypeEvents supported by [PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp.Events.PlayerUnitEvents').  
  
All of these events fire based on a unit type id filter.  
  
Custom events can also be specified via [AddCustomEvent(string, Func&lt;int&gt;, playerunitevent)](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,War3Api.Common.playerunitevent).md 'WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string, System.Func<int>, War3Api.Common.playerunitevent)').

```csharp
public enum HeroTypeEvent
```
### Fields

<a name='WCSharp.Events.HeroTypeEvent.BecomesRevivable'></a>

`BecomesRevivable` 101

Based on EVENT_PLAYER_HERO_REVIVABLE

<a name='WCSharp.Events.HeroTypeEvent.CancelsRevive'></a>

`CancelsRevive` 102

Based on EVENT_PLAYER_HERO_REVIVE_CANCEL

<a name='WCSharp.Events.HeroTypeEvent.FinishesRevive'></a>

`FinishesRevive` 103

Based on EVENT_PLAYER_HERO_REVIVE_FINISH

<a name='WCSharp.Events.HeroTypeEvent.LearnsSpell'></a>

`LearnsSpell` 104

Based on EVENT_PLAYER_HERO_SKILL

<a name='WCSharp.Events.HeroTypeEvent.Levels'></a>

`Levels` 105

Based on EVENT_PLAYER_HERO_LEVEL

<a name='WCSharp.Events.HeroTypeEvent.StartsRevive'></a>

`StartsRevive` 106

Based on EVENT_PLAYER_HERO_REVIVE_START