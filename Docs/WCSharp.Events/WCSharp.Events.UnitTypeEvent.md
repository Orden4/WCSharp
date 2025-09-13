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

`Attacks` 1001

Based on EVENT\_PLAYER\_UNIT\_ATTACKED

<a name='WCSharp.Events.UnitTypeEvent.BuysUnit'></a>

`BuysUnit` 1002

Based on EVENT\_PLAYER\_UNIT\_SELL

<a name='WCSharp.Events.UnitTypeEvent.CancelsBeingConstructed'></a>

`CancelsBeingConstructed` 1003

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_CANCEL

<a name='WCSharp.Events.UnitTypeEvent.CancelsBeingTrained'></a>

`CancelsBeingTrained` 1004

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_CANCEL

<a name='WCSharp.Events.UnitTypeEvent.CancelsConstruction'></a>

`CancelsConstruction` 1005

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_CANCEL

<a name='WCSharp.Events.UnitTypeEvent.CancelsResearch'></a>

`CancelsResearch` 1006

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_CANCEL

<a name='WCSharp.Events.UnitTypeEvent.CancelsTraining'></a>

`CancelsTraining` 1007

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_CANCEL

<a name='WCSharp.Events.UnitTypeEvent.CancelsUpgrade'></a>

`CancelsUpgrade` 1008

Based on EVENT\_PLAYER\_UNIT\_UPGRADE\_CANCEL

<a name='WCSharp.Events.UnitTypeEvent.ChangesOwner'></a>

`ChangesOwner` 1009

Based on EVENT\_PLAYER\_UNIT\_CHANGE\_OWNER

<a name='WCSharp.Events.UnitTypeEvent.Damaging'></a>

`Damaging` 1010

Based on EVENT\_PLAYER\_UNIT\_DAMAGING

Filters on the unit dealing damage.

Runs before damage reductions.

<a name='WCSharp.Events.UnitTypeEvent.DamagingTaken'></a>

`DamagingTaken` 1011

Based on EVENT\_PLAYER\_UNIT\_DAMAGING

Filters on the unit taking damage.

Runs before damage reductions.

<a name='WCSharp.Events.UnitTypeEvent.Decays'></a>

`Decays` 1012

Based on EVENT\_PLAYER\_UNIT\_DECAY

<a name='WCSharp.Events.UnitTypeEvent.Dies'></a>

`Dies` 1013

Based on EVENT\_PLAYER\_UNIT\_DEATH

<a name='WCSharp.Events.UnitTypeEvent.DropsItem'></a>

`DropsItem` 1014

Based on EVENT\_PLAYER\_UNIT\_DROP\_ITEM

<a name='WCSharp.Events.UnitTypeEvent.FinishesBeingConstructed'></a>

`FinishesBeingConstructed` 1015

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.FinishesBeingTrained'></a>

`FinishesBeingTrained` 1016

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.FinishesConstruction'></a>

`FinishesConstruction` 1017

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.FinishesResearch'></a>

`FinishesResearch` 1018

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.FinishesTraining'></a>

`FinishesTraining` 1019

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.FinishesUpgrade'></a>

`FinishesUpgrade` 1020

Based on EVENT\_PLAYER\_UNIT\_UPGRADE\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.IsAttacked'></a>

`IsAttacked` 1021

Based on EVENT\_PLAYER\_UNIT\_ATTACKED

<a name='WCSharp.Events.UnitTypeEvent.IsCreated'></a>

`IsCreated` 1022

Identical to `Register(RegionUnitTypeEvent.Enters, action, Rectangle.WorldBounds.Region)`

<a name='WCSharp.Events.UnitTypeEvent.IsDamaged'></a>

`IsDamaged` 1023

Based on EVENT\_PLAYER\_UNIT\_DAMAGED

Filters on the unit taking damage.

Runs after damage reductions.

<a name='WCSharp.Events.UnitTypeEvent.IsDamagedDealt'></a>

`IsDamagedDealt` 1024

Based on EVENT\_PLAYER\_UNIT\_DAMAGED

Filters on the unit dealing damage.

Runs after damage reductions.

<a name='WCSharp.Events.UnitTypeEvent.IsDeselected'></a>

`IsDeselected` 1025

Based on EVENT\_PLAYER\_UNIT\_DESELECTED

<a name='WCSharp.Events.UnitTypeEvent.IsDetected'></a>

`IsDetected` 1026

Based on EVENT\_PLAYER\_UNIT\_DETECTED

<a name='WCSharp.Events.UnitTypeEvent.IsHidden'></a>

`IsHidden` 1027

Based on EVENT\_PLAYER\_UNIT\_HIDDEN

<a name='WCSharp.Events.UnitTypeEvent.IsLoaded'></a>

`IsLoaded` 1028

Based on EVENT\_PLAYER\_UNIT\_LOADED

<a name='WCSharp.Events.UnitTypeEvent.IsRemoved'></a>

`IsRemoved` 1029

Identical to `Register(RegionUnitTypeEvent.Leaves, action, Rectangle.WorldBounds.Region)`

<a name='WCSharp.Events.UnitTypeEvent.IsRescued'></a>

`IsRescued` 1030

Based on EVENT\_PLAYER\_UNIT\_RESCUED

<a name='WCSharp.Events.UnitTypeEvent.IsSelected'></a>

`IsSelected` 1031

Based on EVENT\_PLAYER\_UNIT\_SELECTED

<a name='WCSharp.Events.UnitTypeEvent.IsSold'></a>

`IsSold` 1032

Based on EVENT\_PLAYER\_UNIT\_SELL

<a name='WCSharp.Events.UnitTypeEvent.IsSummoned'></a>

`IsSummoned` 1033

Based on EVENT\_PLAYER\_UNIT\_SUMMON

<a name='WCSharp.Events.UnitTypeEvent.Kills'></a>

`Kills` 1034

Based on EVENT\_PLAYER\_UNIT\_DEATH

<a name='WCSharp.Events.UnitTypeEvent.Loads'></a>

`Loads` 1035

Based on EVENT\_PLAYER\_UNIT\_LOADED

<a name='WCSharp.Events.UnitTypeEvent.PawnsItem'></a>

`PawnsItem` 1036

Based on EVENT\_PLAYER\_UNIT\_PAWN\_ITEM

<a name='WCSharp.Events.UnitTypeEvent.PicksUpItem'></a>

`PicksUpItem` 1037

Based on EVENT\_PLAYER\_UNIT\_PICKUP\_ITEM

<a name='WCSharp.Events.UnitTypeEvent.ReceivesOrder'></a>

`ReceivesOrder` 1038

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_ORDER

<a name='WCSharp.Events.UnitTypeEvent.ReceivesPointOrder'></a>

`ReceivesPointOrder` 1039

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_POINT\_ORDER

<a name='WCSharp.Events.UnitTypeEvent.ReceivesTargetOrder'></a>

`ReceivesTargetOrder` 1040

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_TARGET\_ORDER

<a name='WCSharp.Events.UnitTypeEvent.ReceivesUnitTypeOrder'></a>

`ReceivesUnitTypeOrder` 1041

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_UNIT\_ORDER

<a name='WCSharp.Events.UnitTypeEvent.Rescues'></a>

`Rescues` 1042

Based on EVENT\_PLAYER\_UNIT\_RESCUED

<a name='WCSharp.Events.UnitTypeEvent.SellsItem'></a>

`SellsItem` 1043

Based on EVENT\_PLAYER\_UNIT\_SELL\_ITEM

<a name='WCSharp.Events.UnitTypeEvent.SellsUnit'></a>

`SellsUnit` 1044

Based on EVENT\_PLAYER\_UNIT\_SELL

<a name='WCSharp.Events.UnitTypeEvent.SpellCast'></a>

`SpellCast` 1045

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CAST

<a name='WCSharp.Events.UnitTypeEvent.SpellCastOn'></a>

`SpellCastOn` 1046

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CAST

<a name='WCSharp.Events.UnitTypeEvent.SpellChannel'></a>

`SpellChannel` 1047

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CHANNEL

<a name='WCSharp.Events.UnitTypeEvent.SpellChannelOn'></a>

`SpellChannelOn` 1048

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CHANNEL

<a name='WCSharp.Events.UnitTypeEvent.SpellEffect'></a>

`SpellEffect` 1049

Based on EVENT\_PLAYER\_UNIT\_SPELL\_EFFECT

<a name='WCSharp.Events.UnitTypeEvent.SpellEffectOn'></a>

`SpellEffectOn` 1050

Based on EVENT\_PLAYER\_UNIT\_SPELL\_EFFECT

<a name='WCSharp.Events.UnitTypeEvent.SpellEndCast'></a>

`SpellEndCast` 1051

Based on EVENT\_PLAYER\_UNIT\_SPELL\_ENDCAST

<a name='WCSharp.Events.UnitTypeEvent.SpellEndCastOn'></a>

`SpellEndCastOn` 1052

Based on EVENT\_PLAYER\_UNIT\_SPELL\_ENDCAST

<a name='WCSharp.Events.UnitTypeEvent.SpellFinish'></a>

`SpellFinish` 1053

Based on EVENT\_PLAYER\_UNIT\_SPELL\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.SpellFinishOn'></a>

`SpellFinishOn` 1054

Based on EVENT\_PLAYER\_UNIT\_SPELL\_FINISH

<a name='WCSharp.Events.UnitTypeEvent.StacksItem'></a>

`StacksItem` 1055

Based on EVENT\_PLAYER\_UNIT\_STACK\_ITEM

<a name='WCSharp.Events.UnitTypeEvent.StartsBeingConstructed'></a>

`StartsBeingConstructed` 1056

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_START

<a name='WCSharp.Events.UnitTypeEvent.StartsBeingTrained'></a>

`StartsBeingTrained` 1057

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_START

<a name='WCSharp.Events.UnitTypeEvent.StartsConstruction'></a>

`StartsConstruction` 1058

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_START

<a name='WCSharp.Events.UnitTypeEvent.StartsResearch'></a>

`StartsResearch` 1059

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_START

<a name='WCSharp.Events.UnitTypeEvent.StartsTraining'></a>

`StartsTraining` 1060

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_START

<a name='WCSharp.Events.UnitTypeEvent.StartsUpgrade'></a>

`StartsUpgrade` 1061

Based on EVENT\_PLAYER\_UNIT\_UPGRADE\_START

<a name='WCSharp.Events.UnitTypeEvent.Summons'></a>

`Summons` 1062

Based on EVENT\_PLAYER\_UNIT\_SUMMON

<a name='WCSharp.Events.UnitTypeEvent.UsesItem'></a>

`UsesItem` 1063

Based on EVENT\_PLAYER\_UNIT\_USE\_ITEM