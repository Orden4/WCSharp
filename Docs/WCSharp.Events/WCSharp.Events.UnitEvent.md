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

`Attacks` 901

Based on EVENT\_PLAYER\_UNIT\_ATTACKED

<a name='WCSharp.Events.UnitEvent.BuysUnit'></a>

`BuysUnit` 902

Based on EVENT\_PLAYER\_UNIT\_SELL

<a name='WCSharp.Events.UnitEvent.CancelsBeingConstructed'></a>

`CancelsBeingConstructed` 903

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_CANCEL

<a name='WCSharp.Events.UnitEvent.CancelsConstruction'></a>

`CancelsConstruction` 904

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_CANCEL

<a name='WCSharp.Events.UnitEvent.CancelsResearch'></a>

`CancelsResearch` 905

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_CANCEL

<a name='WCSharp.Events.UnitEvent.CancelsTraining'></a>

`CancelsTraining` 906

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_CANCEL

<a name='WCSharp.Events.UnitEvent.CancelsUpgrade'></a>

`CancelsUpgrade` 907

Based on EVENT\_PLAYER\_UNIT\_UPGRADE\_CANCEL

<a name='WCSharp.Events.UnitEvent.ChangesOwner'></a>

`ChangesOwner` 908

Based on EVENT\_PLAYER\_UNIT\_CHANGE\_OWNER

<a name='WCSharp.Events.UnitEvent.Damaging'></a>

`Damaging` 909

Based on EVENT\_PLAYER\_UNIT\_DAMAGING

Filters on the unit dealing damage.

Runs before damage reductions.

<a name='WCSharp.Events.UnitEvent.Decays'></a>

`Decays` 910

Based on EVENT\_PLAYER\_UNIT\_DECAY

<a name='WCSharp.Events.UnitEvent.Dies'></a>

`Dies` 911

Based on EVENT\_PLAYER\_UNIT\_DEATH

<a name='WCSharp.Events.UnitEvent.DropsItem'></a>

`DropsItem` 912

Based on EVENT\_PLAYER\_UNIT\_DROP\_ITEM

<a name='WCSharp.Events.UnitEvent.FinishesBeingConstructed'></a>

`FinishesBeingConstructed` 913

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_FINISH

<a name='WCSharp.Events.UnitEvent.FinishesConstruction'></a>

`FinishesConstruction` 914

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_FINISH

<a name='WCSharp.Events.UnitEvent.FinishesResearch'></a>

`FinishesResearch` 915

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_FINISH

<a name='WCSharp.Events.UnitEvent.FinishesTraining'></a>

`FinishesTraining` 916

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_FINISH

<a name='WCSharp.Events.UnitEvent.FinishesUpgrade'></a>

`FinishesUpgrade` 917

Based on EVENT\_PLAYER\_UNIT\_UPGRADE\_FINISH

<a name='WCSharp.Events.UnitEvent.IsAttacked'></a>

`IsAttacked` 918

Based on EVENT\_PLAYER\_UNIT\_ATTACKED

<a name='WCSharp.Events.UnitEvent.IsDamaged'></a>

`IsDamaged` 919

Based on EVENT\_PLAYER\_UNIT\_DAMAGED

Filters on the unit taking damage.

Runs after damage reductions.

<a name='WCSharp.Events.UnitEvent.IsDeselected'></a>

`IsDeselected` 920

Based on EVENT\_PLAYER\_UNIT\_DESELECTED

<a name='WCSharp.Events.UnitEvent.IsDetected'></a>

`IsDetected` 921

Based on EVENT\_PLAYER\_UNIT\_DETECTED

<a name='WCSharp.Events.UnitEvent.IsHidden'></a>

`IsHidden` 922

Based on EVENT\_PLAYER\_UNIT\_HIDDEN

<a name='WCSharp.Events.UnitEvent.IsLoaded'></a>

`IsLoaded` 923

Based on EVENT\_PLAYER\_UNIT\_LOADED

<a name='WCSharp.Events.UnitEvent.IsRescued'></a>

`IsRescued` 924

Based on EVENT\_PLAYER\_UNIT\_RESCUED

<a name='WCSharp.Events.UnitEvent.IsSelected'></a>

`IsSelected` 925

Based on EVENT\_PLAYER\_UNIT\_SELECTED

<a name='WCSharp.Events.UnitEvent.IsSold'></a>

`IsSold` 926

Based on EVENT\_PLAYER\_UNIT\_SELL

<a name='WCSharp.Events.UnitEvent.Kills'></a>

`Kills` 927

Based on EVENT\_PLAYER\_UNIT\_DEATH

<a name='WCSharp.Events.UnitEvent.Loads'></a>

`Loads` 928

Based on EVENT\_PLAYER\_UNIT\_LOADED

<a name='WCSharp.Events.UnitEvent.PawnsItem'></a>

`PawnsItem` 929

Based on EVENT\_PLAYER\_UNIT\_PAWN\_ITEM

<a name='WCSharp.Events.UnitEvent.PicksUpItem'></a>

`PicksUpItem` 930

Based on EVENT\_PLAYER\_UNIT\_PICKUP\_ITEM

<a name='WCSharp.Events.UnitEvent.ReceivesOrder'></a>

`ReceivesOrder` 931

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_ORDER

<a name='WCSharp.Events.UnitEvent.ReceivesPointOrder'></a>

`ReceivesPointOrder` 932

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_POINT\_ORDER

<a name='WCSharp.Events.UnitEvent.ReceivesTargetOrder'></a>

`ReceivesTargetOrder` 933

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_TARGET\_ORDER

<a name='WCSharp.Events.UnitEvent.ReceivesUnitTypeOrder'></a>

`ReceivesUnitTypeOrder` 934

Based on EVENT\_PLAYER\_UNIT\_ISSUED\_UNIT\_ORDER

<a name='WCSharp.Events.UnitEvent.Rescues'></a>

`Rescues` 935

Based on EVENT\_PLAYER\_UNIT\_RESCUED

<a name='WCSharp.Events.UnitEvent.SellsItem'></a>

`SellsItem` 936

Based on EVENT\_PLAYER\_UNIT\_SELL\_ITEM

<a name='WCSharp.Events.UnitEvent.SellsUnit'></a>

`SellsUnit` 937

Based on EVENT\_PLAYER\_UNIT\_SELL

<a name='WCSharp.Events.UnitEvent.SpellCast'></a>

`SpellCast` 938

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CAST

<a name='WCSharp.Events.UnitEvent.SpellCastOn'></a>

`SpellCastOn` 939

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CAST

<a name='WCSharp.Events.UnitEvent.SpellChannel'></a>

`SpellChannel` 940

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CHANNEL

<a name='WCSharp.Events.UnitEvent.SpellChannelOn'></a>

`SpellChannelOn` 941

Based on EVENT\_PLAYER\_UNIT\_SPELL\_CHANNEL

<a name='WCSharp.Events.UnitEvent.SpellEffect'></a>

`SpellEffect` 942

Based on EVENT\_PLAYER\_UNIT\_SPELL\_EFFECT

<a name='WCSharp.Events.UnitEvent.SpellEffectOn'></a>

`SpellEffectOn` 943

Based on EVENT\_PLAYER\_UNIT\_SPELL\_EFFECT

<a name='WCSharp.Events.UnitEvent.SpellEndCast'></a>

`SpellEndCast` 944

Based on EVENT\_PLAYER\_UNIT\_SPELL\_ENDCAST

<a name='WCSharp.Events.UnitEvent.SpellEndCastOn'></a>

`SpellEndCastOn` 945

Based on EVENT\_PLAYER\_UNIT\_SPELL\_ENDCAST

<a name='WCSharp.Events.UnitEvent.SpellFinish'></a>

`SpellFinish` 946

Based on EVENT\_PLAYER\_UNIT\_SPELL\_FINISH

<a name='WCSharp.Events.UnitEvent.SpellFinishOn'></a>

`SpellFinishOn` 947

Based on EVENT\_PLAYER\_UNIT\_SPELL\_FINISH

<a name='WCSharp.Events.UnitEvent.StacksItem'></a>

`StacksItem` 948

Based on EVENT\_PLAYER\_UNIT\_STACK\_ITEM

<a name='WCSharp.Events.UnitEvent.StartsConstruction'></a>

`StartsConstruction` 949

Based on EVENT\_PLAYER\_UNIT\_CONSTRUCT\_START

<a name='WCSharp.Events.UnitEvent.StartsResearch'></a>

`StartsResearch` 950

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_START

<a name='WCSharp.Events.UnitEvent.StartsTraining'></a>

`StartsTraining` 951

Based on EVENT\_PLAYER\_UNIT\_TRAIN\_START

<a name='WCSharp.Events.UnitEvent.StartsUpgrade'></a>

`StartsUpgrade` 952

Based on EVENT\_PLAYER\_UNIT\_UPGRADE\_START

<a name='WCSharp.Events.UnitEvent.Summons'></a>

`Summons` 953

Based on EVENT\_PLAYER\_UNIT\_SUMMON

<a name='WCSharp.Events.UnitEvent.UsesItem'></a>

`UsesItem` 954

Based on EVENT\_PLAYER\_UNIT\_USE\_ITEM

<a name='WCSharp.Events.UnitEvent.DamagingTaken'></a>

`DamagingTaken` 955

Based on EVENT\_PLAYER\_UNIT\_DAMAGING

Filters on the unit taking damage.

Runs before damage reductions.

<a name='WCSharp.Events.UnitEvent.IsDamagedDealt'></a>

`IsDamagedDealt` 956

Based on EVENT\_PLAYER\_UNIT\_DAMAGED

Filters on the unit dealing damage.

Runs after damage reductions.