#### [WCSharp.Events](index.md 'index')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events')

## HeroEvent Enum

Defines all built-in HeroEvents supported by [PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp.Events.PlayerUnitEvents').  
  
All of these events fire based on a unit handle filter.  
  
Custom events can also be specified via [AddCustomEvent(string, Func&lt;int&gt;, playerunitevent)](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,War3Api.Common.playerunitevent).md 'WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string, System.Func<int>, War3Api.Common.playerunitevent)').

```csharp
public enum HeroEvent
```
### Fields

<a name='WCSharp.Events.HeroEvent.BecomesRevivable'></a>

`BecomesRevivable` 1

Based on EVENT_PLAYER_HERO_REVIVABLE

<a name='WCSharp.Events.HeroEvent.CancelsRevive'></a>

`CancelsRevive` 2

Based on EVENT_PLAYER_HERO_REVIVE_CANCEL

<a name='WCSharp.Events.HeroEvent.FinishesRevive'></a>

`FinishesRevive` 3

Based on EVENT_PLAYER_HERO_REVIVE_FINISH

<a name='WCSharp.Events.HeroEvent.LearnsSpell'></a>

`LearnsSpell` 4

Based on EVENT_PLAYER_HERO_SKILL

<a name='WCSharp.Events.HeroEvent.Levels'></a>

`Levels` 5

Based on EVENT_PLAYER_HERO_LEVEL

<a name='WCSharp.Events.HeroEvent.StartsRevive'></a>

`StartsRevive` 6

Based on EVENT_PLAYER_HERO_REVIVE_START