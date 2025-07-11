#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events')

## UnitEvent Enum

Defines all built\-in UnitEvents supported by [PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp\.Events\.PlayerUnitEvents')\.

All of these events fire based on a unit handle filter.

Custom events can also be specified via [AddCustomEvent\(string, Func&lt;int&gt;, playerunitevent\)](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).md 'WCSharp\.Events\.PlayerUnitEvents\.AddCustomEvent\(string, System\.Func\<int\>, WCSharp\.Api\.playerunitevent\)').

```csharp
public enum UnitEvent
```
### Fields

<a name='WCSharp.Events.UnitEvent.Attacks'></a>

`Attacks` 701

Based on EVENT\_PLAYER\_UNIT\_ATTACKED

<a name='WCSharp.Events.UnitEvent.BuysUnit'></a>

`BuysUnit` 702

Based on EVENT\_PLAYER\_UNIT\_SELL

<a name='WCSharp.Events.UnitEvent.CancelsBeingConstructed'></a>

`CancelsBeingConstructed` 703

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_CANCEL

<a name='WCSharp.Events.UnitEvent.CancelsConstruction'></a>

`CancelsConstruction` 704

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_CANCEL

<a name='WCSharp.Events.UnitEvent.CancelsResearch'></a>

`CancelsResearch` 705

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_CANCEL

<a name='WCSharp.Events.UnitEvent.CancelsTraining'></a>

`CancelsTraining` 706

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_CANCEL

<a name='WCSharp.Events.UnitEvent.CancelsUpgrade'></a>

`CancelsUpgrade` 707

Based on EVENT\_PLAYER\_UNIT\_UPGRADE\_CANCEL

<a name='WCSharp.Events.UnitEvent.ChangesOwner'></a>

`ChangesOwner` 708

Based on EVENT\_PLAYER\_UNIT\_CHANGE\_OWNER

<a name='WCSharp.Events.UnitEvent.Damaging'></a>

`Damaging` 709

Based on EVENT\_PLAYER\_UNIT\_DAMAGING

Filters on the unit dealing damage.

Runs before damage reductions.

<a name='WCSharp.Events.UnitEvent.Decays'></a>

`Decays` 710

Based on EVENT\_PLAYER\_UNIT\_DECAY

<a name='WCSharp.Events.UnitEvent.Dies'></a>

`Dies` 711

Based on EVENT\_PLAYER\_UNIT\_DEATH

<a name='WCSharp.Events.UnitEvent.DropsItem'></a>

`DropsItem` 712

Based on EVENT\_PLAYER\_UNIT\_DROP\_ITEM

<a name='WCSharp.Events.UnitEvent.FinishesBeingConstructed'></a>

`FinishesBeingConstructed` 713

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_FINISH

<a name='WCSharp.Events.UnitEvent.FinishesConstruction'></a>

`FinishesConstruction` 714

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_FINISH

<a name='WCSharp.Events.UnitEvent.FinishesResearch'></a>

`FinishesResearch` 715

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_FINISH

<a name='WCSharp.Events.UnitEvent.FinishesTraining'></a>

`FinishesTraining` 716

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_FINISH

<a name='WCSharp.Events.UnitEvent.FinishesUpgrade'></a>

`FinishesUpgrade` 717

Based on EVENT\_PLAYER\_UNIT\_UPGRADE\_FINISH

<a name='WCSharp.Events.UnitEvent.IsAttacked'></a>

`IsAttacked` 718

Based on EVENT\_PLAYER\_UNIT\_ATTACKED

<a name='WCSharp.Events.UnitEvent.IsDamaged'></a>

`IsDamaged` 719

Based on EVENT\_PLAYER\_UNIT\_DAMAGED

Filters on the unit taking damage.

Runs after damage reductions.

<a name='WCSharp.Events.UnitEvent.IsDeselected'></a>

`IsDeselected` 720

Based on EVENT\_PLAYER\_UNIT\_DESELECTED

<a name='WCSharp.Events.UnitEvent.IsDetected'></a>

`IsDetected` 721

Based on EVENT\_PLAYER\_UNIT\_DETECTED

<a name='WCSharp.Events.UnitEvent.IsHidden'></a>

`IsHidden` 722

Based on EVENT\_PLAYER\_UNIT\_HIDDEN

<a name='WCSharp.Events.UnitEvent.IsLoaded'></a>

`IsLoaded` 723

Based on EVENT\_PLAYER\_UNIT\_LOADED

<a name='WCSharp.Events.UnitEvent.IsRescued'></a>

`IsRescued` 724

Based on EVENT\_PLAYER\_UNIT\_RESCUED

<a name='WCSharp.Events.UnitEvent.IsSelected'></a>

`IsSelected` 725

Based on EVENT\_PLAYER\_UNIT\_SELECTED

<a name='WCSharp.Events.UnitEvent.IsSold'></a>

`IsSold` 726

Based on EVENT\_PLAYER\_UNIT\_SELL

<a name='WCSharp.Events.UnitEvent.Kills'></a>

`Kills` 727

Based on EVENT\_PLAYER\_UNIT\_DEATH

<a name='WCSharp.Events.UnitEvent.Loads'></a>

`Loads` 728

Based on EVENT\_PLAYER\_UNIT\_LOADED

<a name='WCSharp.Events.UnitEvent.PawnsItem'></a>

`PawnsItem` 729

Based on EVENT\_PLAYER\_UNIT\_PAWN\_ITEM

<a name='WCSharp.Events.UnitEvent.PicksUpItem'></a>

`PicksUpItem` 730

Based on EVENT\_PLAYER\_UNIT\_PICKUP\_ITEM

<a name='WCSharp.Events.UnitEvent.ReceivesOrder'></a>

`ReceivesOrder` 731

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_ORDER

<a name='WCSharp.Events.UnitEvent.ReceivesPointOrder'></a>

`ReceivesPointOrder` 732

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_POINT\_ORDER

<a name='WCSharp.Events.UnitEvent.ReceivesTargetOrder'></a>

`ReceivesTargetOrder` 733

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_TARGET\_ORDER

<a name='WCSharp.Events.UnitEvent.ReceivesUnitTypeOrder'></a>

`ReceivesUnitTypeOrder` 734

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_UNIT\_ORDER

<a name='WCSharp.Events.UnitEvent.Rescues'></a>

`Rescues` 735

Based on EVENT\_PLAYER\_UNIT\_RESCUED

<a name='WCSharp.Events.UnitEvent.SellsItem'></a>

`SellsItem` 736

Based on EVENT\_PLAYER\_UNIT\_SELL\_ITEM

<a name='WCSharp.Events.UnitEvent.SellsUnit'></a>

`SellsUnit` 737

Based on EVENT\_PLAYER\_UNIT\_SELL

<a name='WCSharp.Events.UnitEvent.SpellCast'></a>

`SpellCast` 738

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CAST

<a name='WCSharp.Events.UnitEvent.SpellCastOn'></a>

`SpellCastOn` 739

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CAST

<a name='WCSharp.Events.UnitEvent.SpellChannel'></a>

`SpellChannel` 740

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CHANNEL

<a name='WCSharp.Events.UnitEvent.SpellChannelOn'></a>

`SpellChannelOn` 741

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CHANNEL

<a name='WCSharp.Events.UnitEvent.SpellEffect'></a>

`SpellEffect` 742

Based on EVENT\_PLAYER\_UNIT\_SPELL\_EFFECT

<a name='WCSharp.Events.UnitEvent.SpellEffectOn'></a>

`SpellEffectOn` 743

Based on EVENT\_PLAYER\_UNIT\_SPELL\_EFFECT

<a name='WCSharp.Events.UnitEvent.SpellEndCast'></a>

`SpellEndCast` 744

Based on EVENT\_PLAYER\_UNIT\_SPELL\_ENDCAST

<a name='WCSharp.Events.UnitEvent.SpellEndCastOn'></a>

`SpellEndCastOn` 745

Based on EVENT\_PLAYER\_UNIT\_SPELL\_ENDCAST

<a name='WCSharp.Events.UnitEvent.SpellFinish'></a>

`SpellFinish` 746

Based on EVENT\_PLAYER\_UNIT\_SPELL\_FINISH

<a name='WCSharp.Events.UnitEvent.SpellFinishOn'></a>

`SpellFinishOn` 747

Based on EVENT\_PLAYER\_UNIT\_SPELL\_FINISH

<a name='WCSharp.Events.UnitEvent.StacksItem'></a>

`StacksItem` 748

Based on EVENT\_PLAYER\_UNIT\_STACK\_ITEM

<a name='WCSharp.Events.UnitEvent.StartsConstruction'></a>

`StartsConstruction` 749

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_START

<a name='WCSharp.Events.UnitEvent.StartsResearch'></a>

`StartsResearch` 750

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_START

<a name='WCSharp.Events.UnitEvent.StartsTraining'></a>

`StartsTraining` 751

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_START

<a name='WCSharp.Events.UnitEvent.StartsUpgrade'></a>

`StartsUpgrade` 752

Based on EVENT\_PLAYER\_UNIT\_UPGRADE\_START

<a name='WCSharp.Events.UnitEvent.Summons'></a>

`Summons` 753

Based on EVENT\_PLAYER\_UNIT\_SUMMON

<a name='WCSharp.Events.UnitEvent.UsesItem'></a>

`UsesItem` 754

Based on EVENT\_PLAYER\_UNIT\_USE\_ITEM

<a name='WCSharp.Events.UnitEvent.DamagingTaken'></a>

`DamagingTaken` 755

Based on EVENT\_PLAYER\_UNIT\_DAMAGING

Filters on the unit taking damage.

Runs before damage reductions.

<a name='WCSharp.Events.UnitEvent.IsDamagedDealt'></a>

`IsDamagedDealt` 756

Based on EVENT\_PLAYER\_UNIT\_DAMAGED

Filters on the unit dealing damage.

Runs after damage reductions.