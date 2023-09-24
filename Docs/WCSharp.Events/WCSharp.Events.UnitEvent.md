#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events')

## UnitEvent Enum

Defines all built-in UnitEvents supported by [PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp.Events.PlayerUnitEvents').  
  
All of these events fire based on a unit handle filter.  
  
Custom events can also be specified via [AddCustomEvent(string, Func&lt;int&gt;, playerunitevent)](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,War3Api.Common.playerunitevent).md 'WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string, System.Func<int>, War3Api.Common.playerunitevent)').

```csharp
public enum UnitEvent
```
### Fields

<a name='WCSharp.Events.UnitEvent.Attacks'></a>

`Attacks` 701

Based on EVENT_PLAYER_UNIT_ATTACKED

<a name='WCSharp.Events.UnitEvent.BuysUnit'></a>

`BuysUnit` 702

Based on EVENT_PLAYER_UNIT_SELL

<a name='WCSharp.Events.UnitEvent.CancelsBeingConstructed'></a>

`CancelsBeingConstructed` 703

Based on EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL

<a name='WCSharp.Events.UnitEvent.CancelsConstruction'></a>

`CancelsConstruction` 704

Based on EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL

<a name='WCSharp.Events.UnitEvent.CancelsResearch'></a>

`CancelsResearch` 705

Based on EVENT_PLAYER_UNIT_RESEARCH_CANCEL

<a name='WCSharp.Events.UnitEvent.CancelsTraining'></a>

`CancelsTraining` 706

Based on EVENT_PLAYER_UNIT_TRAIN_CANCEL

<a name='WCSharp.Events.UnitEvent.CancelsUpgrade'></a>

`CancelsUpgrade` 707

Based on EVENT_PLAYER_UNIT_UPGRADE_CANCEL

<a name='WCSharp.Events.UnitEvent.ChangesOwner'></a>

`ChangesOwner` 708

Based on EVENT_PLAYER_UNIT_CHANGE_OWNER

<a name='WCSharp.Events.UnitEvent.Damaging'></a>

`Damaging` 709

Based on EVENT_PLAYER_UNIT_DAMAGING

<a name='WCSharp.Events.UnitEvent.Decays'></a>

`Decays` 710

Based on EVENT_PLAYER_UNIT_DECAY

<a name='WCSharp.Events.UnitEvent.Dies'></a>

`Dies` 711

Based on EVENT_PLAYER_UNIT_DEATH

<a name='WCSharp.Events.UnitEvent.DropsItem'></a>

`DropsItem` 712

Based on EVENT_PLAYER_UNIT_DROP_ITEM

<a name='WCSharp.Events.UnitEvent.FinishesBeingConstructed'></a>

`FinishesBeingConstructed` 713

Based on EVENT_PLAYER_UNIT_CONSTRUCT_FINISH

<a name='WCSharp.Events.UnitEvent.FinishesConstruction'></a>

`FinishesConstruction` 714

Based on EVENT_PLAYER_UNIT_CONSTRUCT_FINISH

<a name='WCSharp.Events.UnitEvent.FinishesResearch'></a>

`FinishesResearch` 715

Based on EVENT_PLAYER_UNIT_RESEARCH_FINISH

<a name='WCSharp.Events.UnitEvent.FinishesTraining'></a>

`FinishesTraining` 716

Based on EVENT_PLAYER_UNIT_TRAIN_FINISH

<a name='WCSharp.Events.UnitEvent.FinishesUpgrade'></a>

`FinishesUpgrade` 717

Based on EVENT_PLAYER_UNIT_UPGRADE_FINISH

<a name='WCSharp.Events.UnitEvent.IsAttacked'></a>

`IsAttacked` 718

Based on EVENT_PLAYER_UNIT_ATTACKED

<a name='WCSharp.Events.UnitEvent.IsDamaged'></a>

`IsDamaged` 719

Based on EVENT_PLAYER_UNIT_DAMAGED

<a name='WCSharp.Events.UnitEvent.IsDeselected'></a>

`IsDeselected` 720

Based on EVENT_PLAYER_UNIT_DESELECTED

<a name='WCSharp.Events.UnitEvent.IsDetected'></a>

`IsDetected` 721

Based on EVENT_PLAYER_UNIT_DETECTED

<a name='WCSharp.Events.UnitEvent.IsHidden'></a>

`IsHidden` 722

Based on EVENT_PLAYER_UNIT_HIDDEN

<a name='WCSharp.Events.UnitEvent.IsLoaded'></a>

`IsLoaded` 723

Based on EVENT_PLAYER_UNIT_LOADED

<a name='WCSharp.Events.UnitEvent.IsRescued'></a>

`IsRescued` 724

Based on EVENT_PLAYER_UNIT_RESCUED

<a name='WCSharp.Events.UnitEvent.IsSelected'></a>

`IsSelected` 725

Based on EVENT_PLAYER_UNIT_SELECTED

<a name='WCSharp.Events.UnitEvent.IsSold'></a>

`IsSold` 726

Based on EVENT_PLAYER_UNIT_SELL

<a name='WCSharp.Events.UnitEvent.Kills'></a>

`Kills` 727

Based on EVENT_PLAYER_UNIT_DEATH

<a name='WCSharp.Events.UnitEvent.Loads'></a>

`Loads` 728

Based on EVENT_PLAYER_UNIT_LOADED

<a name='WCSharp.Events.UnitEvent.PawnsItem'></a>

`PawnsItem` 729

Based on EVENT_PLAYER_UNIT_PAWN_ITEM

<a name='WCSharp.Events.UnitEvent.PicksUpItem'></a>

`PicksUpItem` 730

Based on EVENT_PLAYER_UNIT_PICKUP_ITEM

<a name='WCSharp.Events.UnitEvent.ReceivesOrder'></a>

`ReceivesOrder` 731

Based on EVENT_PLAYER_UNIT_ISSUED_ORDER

<a name='WCSharp.Events.UnitEvent.ReceivesPointOrder'></a>

`ReceivesPointOrder` 732

Based on EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER

<a name='WCSharp.Events.UnitEvent.ReceivesTargetOrder'></a>

`ReceivesTargetOrder` 733

Based on EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER

<a name='WCSharp.Events.UnitEvent.ReceivesUnitTypeOrder'></a>

`ReceivesUnitTypeOrder` 734

Based on EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER

<a name='WCSharp.Events.UnitEvent.Rescues'></a>

`Rescues` 735

Based on EVENT_PLAYER_UNIT_RESCUED

<a name='WCSharp.Events.UnitEvent.SellsItem'></a>

`SellsItem` 736

Based on EVENT_PLAYER_UNIT_SELL_ITEM

<a name='WCSharp.Events.UnitEvent.SellsUnit'></a>

`SellsUnit` 737

Based on EVENT_PLAYER_UNIT_SELL

<a name='WCSharp.Events.UnitEvent.SpellCast'></a>

`SpellCast` 738

Based on EVENT_PLAYER_UNIT_SPELL_CAST

<a name='WCSharp.Events.UnitEvent.SpellCastOn'></a>

`SpellCastOn` 739

Based on EVENT_PLAYER_UNIT_SPELL_CAST

<a name='WCSharp.Events.UnitEvent.SpellChannel'></a>

`SpellChannel` 740

Based on EVENT_PLAYER_UNIT_SPELL_CHANNEL

<a name='WCSharp.Events.UnitEvent.SpellChannelOn'></a>

`SpellChannelOn` 741

Based on EVENT_PLAYER_UNIT_SPELL_CHANNEL

<a name='WCSharp.Events.UnitEvent.SpellEffect'></a>

`SpellEffect` 742

Based on EVENT_PLAYER_UNIT_SPELL_EFFECT

<a name='WCSharp.Events.UnitEvent.SpellEffectOn'></a>

`SpellEffectOn` 743

Based on EVENT_PLAYER_UNIT_SPELL_EFFECT

<a name='WCSharp.Events.UnitEvent.SpellEndCast'></a>

`SpellEndCast` 744

Based on EVENT_PLAYER_UNIT_SPELL_ENDCAST

<a name='WCSharp.Events.UnitEvent.SpellEndCastOn'></a>

`SpellEndCastOn` 745

Based on EVENT_PLAYER_UNIT_SPELL_ENDCAST

<a name='WCSharp.Events.UnitEvent.SpellFinish'></a>

`SpellFinish` 746

Based on EVENT_PLAYER_UNIT_SPELL_FINISH

<a name='WCSharp.Events.UnitEvent.SpellFinishOn'></a>

`SpellFinishOn` 747

Based on EVENT_PLAYER_UNIT_SPELL_FINISH

<a name='WCSharp.Events.UnitEvent.StacksItem'></a>

`StacksItem` 748

Based on EVENT_PLAYER_UNIT_STACK_ITEM

<a name='WCSharp.Events.UnitEvent.StartsConstruction'></a>

`StartsConstruction` 749

Based on EVENT_PLAYER_UNIT_CONSTRUCT_START

<a name='WCSharp.Events.UnitEvent.StartsResearch'></a>

`StartsResearch` 750

Based on EVENT_PLAYER_UNIT_RESEARCH_START

<a name='WCSharp.Events.UnitEvent.StartsTraining'></a>

`StartsTraining` 751

Based on EVENT_PLAYER_UNIT_TRAIN_START

<a name='WCSharp.Events.UnitEvent.StartsUpgrade'></a>

`StartsUpgrade` 752

Based on EVENT_PLAYER_UNIT_UPGRADE_START

<a name='WCSharp.Events.UnitEvent.Summons'></a>

`Summons` 753

Based on EVENT_PLAYER_UNIT_SUMMON

<a name='WCSharp.Events.UnitEvent.UsesItem'></a>

`UsesItem` 754

Based on EVENT_PLAYER_UNIT_USE_ITEM