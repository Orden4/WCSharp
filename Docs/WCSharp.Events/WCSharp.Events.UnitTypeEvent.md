#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events')

## UnitTypeEvent Enum

Defines all built\-in UnitTypeEvents supported by [PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp\.Events\.PlayerUnitEvents')\.

All of these events fire based on an unit type id filter.

Custom events can also be specified via [AddCustomEvent\(string, Func&lt;int&gt;, playerunitevent\)](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).md 'WCSharp\.Events\.PlayerUnitEvents\.AddCustomEvent\(string, System\.Func\<int\>, WCSharp\.Api\.playerunitevent\)').

```csharp
public enum UnitTypeEvent
```
### Fields

<a name='WCSharp.Events.UnitTypeEvent.Attacks'></a>

`Attacks` 801

Based on EVENT\_PLAYER\_UNIT\_ATTACKED

<a name='WCSharp.Events.UnitTypeEvent.BuysUnit'></a>

`BuysUnit` 802

Based on EVENT\_PLAYER\_UNIT\_SELL

<a name='WCSharp.Events.UnitTypeEvent.CancelsBeingConstructed'></a>

`CancelsBeingConstructed` 803

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_CANCEL

<a name='WCSharp.Events.UnitTypeEvent.CancelsBeingTrained'></a>

`CancelsBeingTrained` 804

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_CANCEL

<a name='WCSharp.Events.UnitTypeEvent.CancelsConstruction'></a>

`CancelsConstruction` 805

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_CANCEL

<a name='WCSharp.Events.UnitTypeEvent.CancelsResearch'></a>

`CancelsResearch` 806

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_CANCEL

<a name='WCSharp.Events.UnitTypeEvent.CancelsTraining'></a>

`CancelsTraining` 807

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_CANCEL

<a name='WCSharp.Events.UnitTypeEvent.CancelsUpgrade'></a>

`CancelsUpgrade` 808

Based on EVENT\_PLAYER\_UNIT\_UPGRADE\_CANCEL

<a name='WCSharp.Events.UnitTypeEvent.ChangesOwner'></a>

`ChangesOwner` 809

Based on EVENT\_PLAYER\_UNIT\_CHANGE\_OWNER

<a name='WCSharp.Events.UnitTypeEvent.Damaging'></a>

`Damaging` 810

Based on EVENT\_PLAYER\_UNIT\_DAMAGING

Filters on the unit dealing damage.

Runs before damage reductions.

<a name='WCSharp.Events.UnitTypeEvent.DamagingTaken'></a>

`DamagingTaken` 811

Based on EVENT\_PLAYER\_UNIT\_DAMAGING

Filters on the unit taking damage.

Runs before damage reductions.

<a name='WCSharp.Events.UnitTypeEvent.Decays'></a>

`Decays` 812

Based on EVENT\_PLAYER\_UNIT\_DECAY

<a name='WCSharp.Events.UnitTypeEvent.Dies'></a>

`Dies` 813

Based on EVENT\_PLAYER\_UNIT\_DEATH

<a name='WCSharp.Events.UnitTypeEvent.DropsItem'></a>

`DropsItem` 814

Based on EVENT\_PLAYER\_UNIT\_DROP\_ITEM

<a name='WCSharp.Events.UnitTypeEvent.FinishesBeingConstructed'></a>

`FinishesBeingConstructed` 815

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.FinishesBeingTrained'></a>

`FinishesBeingTrained` 816

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.FinishesConstruction'></a>

`FinishesConstruction` 817

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.FinishesResearch'></a>

`FinishesResearch` 818

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.FinishesTraining'></a>

`FinishesTraining` 819

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.FinishesUpgrade'></a>

`FinishesUpgrade` 820

Based on EVENT\_PLAYER\_UNIT\_UPGRADE\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.IsAttacked'></a>

`IsAttacked` 821

Based on EVENT\_PLAYER\_UNIT\_ATTACKED

<a name='WCSharp.Events.UnitTypeEvent.IsCreated'></a>

`IsCreated` 822

Based on TriggerRegisterEnterRegion using GetWorldBounds

<a name='WCSharp.Events.UnitTypeEvent.IsDamaged'></a>

`IsDamaged` 823

Based on EVENT\_PLAYER\_UNIT\_DAMAGED

Filters on the unit taking damage.

Runs after damage reductions.

<a name='WCSharp.Events.UnitTypeEvent.IsDamagedDealt'></a>

`IsDamagedDealt` 824

Based on EVENT\_PLAYER\_UNIT\_DAMAGED

Filters on the unit dealing damage.

Runs after damage reductions.

<a name='WCSharp.Events.UnitTypeEvent.IsDeselected'></a>

`IsDeselected` 825

Based on EVENT\_PLAYER\_UNIT\_DESELECTED

<a name='WCSharp.Events.UnitTypeEvent.IsDetected'></a>

`IsDetected` 826

Based on EVENT\_PLAYER\_UNIT\_DETECTED

<a name='WCSharp.Events.UnitTypeEvent.IsHidden'></a>

`IsHidden` 827

Based on EVENT\_PLAYER\_UNIT\_HIDDEN

<a name='WCSharp.Events.UnitTypeEvent.IsLoaded'></a>

`IsLoaded` 828

Based on EVENT\_PLAYER\_UNIT\_LOADED

<a name='WCSharp.Events.UnitTypeEvent.IsRescued'></a>

`IsRescued` 829

Based on EVENT\_PLAYER\_UNIT\_RESCUED

<a name='WCSharp.Events.UnitTypeEvent.IsSelected'></a>

`IsSelected` 830

Based on EVENT\_PLAYER\_UNIT\_SELECTED

<a name='WCSharp.Events.UnitTypeEvent.IsSold'></a>

`IsSold` 831

Based on EVENT\_PLAYER\_UNIT\_SELL

<a name='WCSharp.Events.UnitTypeEvent.IsSummoned'></a>

`IsSummoned` 832

Based on EVENT\_PLAYER\_UNIT\_SUMMON

<a name='WCSharp.Events.UnitTypeEvent.Kills'></a>

`Kills` 833

Based on EVENT\_PLAYER\_UNIT\_DEATH

<a name='WCSharp.Events.UnitTypeEvent.Loads'></a>

`Loads` 834

Based on EVENT\_PLAYER\_UNIT\_LOADED

<a name='WCSharp.Events.UnitTypeEvent.PawnsItem'></a>

`PawnsItem` 835

Based on EVENT\_PLAYER\_UNIT\_PAWN\_ITEM

<a name='WCSharp.Events.UnitTypeEvent.PicksUpItem'></a>

`PicksUpItem` 836

Based on EVENT\_PLAYER\_UNIT\_PICKUP\_ITEM

<a name='WCSharp.Events.UnitTypeEvent.ReceivesOrder'></a>

`ReceivesOrder` 837

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_ORDER

<a name='WCSharp.Events.UnitTypeEvent.ReceivesPointOrder'></a>

`ReceivesPointOrder` 838

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_POINT\_ORDER

<a name='WCSharp.Events.UnitTypeEvent.ReceivesTargetOrder'></a>

`ReceivesTargetOrder` 839

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_TARGET\_ORDER

<a name='WCSharp.Events.UnitTypeEvent.ReceivesUnitTypeOrder'></a>

`ReceivesUnitTypeOrder` 840

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_UNIT\_ORDER

<a name='WCSharp.Events.UnitTypeEvent.Rescues'></a>

`Rescues` 841

Based on EVENT\_PLAYER\_UNIT\_RESCUED

<a name='WCSharp.Events.UnitTypeEvent.SellsItem'></a>

`SellsItem` 842

Based on EVENT\_PLAYER\_UNIT\_SELL\_ITEM

<a name='WCSharp.Events.UnitTypeEvent.SellsUnit'></a>

`SellsUnit` 843

Based on EVENT\_PLAYER\_UNIT\_SELL

<a name='WCSharp.Events.UnitTypeEvent.SpellCast'></a>

`SpellCast` 844

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CAST

<a name='WCSharp.Events.UnitTypeEvent.SpellCastOn'></a>

`SpellCastOn` 845

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CAST

<a name='WCSharp.Events.UnitTypeEvent.SpellChannel'></a>

`SpellChannel` 846

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CHANNEL

<a name='WCSharp.Events.UnitTypeEvent.SpellChannelOn'></a>

`SpellChannelOn` 847

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CHANNEL

<a name='WCSharp.Events.UnitTypeEvent.SpellEffect'></a>

`SpellEffect` 848

Based on EVENT\_PLAYER\_UNIT\_SPELL\_EFFECT

<a name='WCSharp.Events.UnitTypeEvent.SpellEffectOn'></a>

`SpellEffectOn` 849

Based on EVENT\_PLAYER\_UNIT\_SPELL\_EFFECT

<a name='WCSharp.Events.UnitTypeEvent.SpellEndCast'></a>

`SpellEndCast` 850

Based on EVENT\_PLAYER\_UNIT\_SPELL\_ENDCAST

<a name='WCSharp.Events.UnitTypeEvent.SpellEndCastOn'></a>

`SpellEndCastOn` 851

Based on EVENT\_PLAYER\_UNIT\_SPELL\_ENDCAST

<a name='WCSharp.Events.UnitTypeEvent.SpellFinish'></a>

`SpellFinish` 852

Based on EVENT\_PLAYER\_UNIT\_SPELL\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.SpellFinishOn'></a>

`SpellFinishOn` 853

Based on EVENT\_PLAYER\_UNIT\_SPELL\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.StacksItem'></a>

`StacksItem` 854

Based on EVENT\_PLAYER\_UNIT\_STACK\_ITEM

<a name='WCSharp.Events.UnitTypeEvent.StartsBeingConstructed'></a>

`StartsBeingConstructed` 855

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_START

<a name='WCSharp.Events.UnitTypeEvent.StartsBeingTrained'></a>

`StartsBeingTrained` 856

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_START

<a name='WCSharp.Events.UnitTypeEvent.StartsConstruction'></a>

`StartsConstruction` 857

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_START

<a name='WCSharp.Events.UnitTypeEvent.StartsResearch'></a>

`StartsResearch` 858

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_START

<a name='WCSharp.Events.UnitTypeEvent.StartsTraining'></a>

`StartsTraining` 859

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_START

<a name='WCSharp.Events.UnitTypeEvent.StartsUpgrade'></a>

`StartsUpgrade` 860

Based on EVENT\_PLAYER\_UNIT\_UPGRADE\_START

<a name='WCSharp.Events.UnitTypeEvent.Summons'></a>

`Summons` 861

Based on EVENT\_PLAYER\_UNIT\_SUMMON

<a name='WCSharp.Events.UnitTypeEvent.UsesItem'></a>

`UsesItem` 862

Based on EVENT\_PLAYER\_UNIT\_USE\_ITEM