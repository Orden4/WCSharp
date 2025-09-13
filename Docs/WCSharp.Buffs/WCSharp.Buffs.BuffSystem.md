#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs')

## BuffSystem Class

Tracks and runs all active [Buff](WCSharp.Buffs.Buff.md 'WCSharp\.Buffs\.Buff') instances\.

```csharp
public static class BuffSystem
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; BuffSystem

| Properties | |
| :--- | :--- |
| [Buffs](WCSharp.Buffs.BuffSystem.Buffs.md 'WCSharp\.Buffs\.BuffSystem\.Buffs') | All active buffs\. |
| [TickInterval](WCSharp.Buffs.BuffSystem.TickInterval.md 'WCSharp\.Buffs\.BuffSystem\.TickInterval') | The interval between each update of the system\.   Use [SetTickInterval\(float\)](WCSharp.Buffs.BuffSystem.SetTickInterval(float).md 'WCSharp\.Buffs\.BuffSystem\.SetTickInterval\(float\)') to adjust. |

| Methods | |
| :--- | :--- |
| [Add\(Buff, StackBehaviour\)](WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).md 'WCSharp\.Buffs\.BuffSystem\.Add\(WCSharp\.Buffs\.Buff, WCSharp\.Buffs\.StackBehaviour\)') | Adds the given [buff](WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).md#WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).buff 'WCSharp\.Buffs\.BuffSystem\.Add\(WCSharp\.Buffs\.Buff, WCSharp\.Buffs\.StackBehaviour\)\.buff') to the system\. If addition is successful, will invoke [OnApply\(\)](WCSharp.Buffs.Buff.OnApply().md 'WCSharp\.Buffs\.Buff\.OnApply\(\)')\. |
| [Dispel\(unit, unit, bool, int\)](WCSharp.Buffs.BuffSystem.Dispel.md#WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int) 'WCSharp\.Buffs\.BuffSystem\.Dispel\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, bool, int\)') | Attempts to dispel buffs from the target\. Buff types are ignored\. |
| [Dispel\(unit, unit, bool, int, string\)](WCSharp.Buffs.BuffSystem.Dispel.md#WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string) 'WCSharp\.Buffs\.BuffSystem\.Dispel\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, bool, int, string\)') | Attempts to dispel buffs from the target with the given dispel type\. |
| [Dispel\(unit, unit, bool, int, string\[\]\)](WCSharp.Buffs.BuffSystem.Dispel.md#WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string[]) 'WCSharp\.Buffs\.BuffSystem\.Dispel\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, bool, int, string\[\]\)') | Attempts to dispel buffs with any of the given dispel types\. |
| [Dispel\(unit, unit, bool, int, List&lt;string&gt;, List&lt;string&gt;\)](WCSharp.Buffs.BuffSystem.Dispel.md#WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_) 'WCSharp\.Buffs\.BuffSystem\.Dispel\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, bool, int, System\.Collections\.Generic\.List\<string\>, System\.Collections\.Generic\.List\<string\>\)') | For more complex buff hierarchies\. Attempts to dispel buffs with any of the given dispel types, unless it has an excluded type\. |
| [GetBuffsOnUnit\(unit\)](WCSharp.Buffs.BuffSystem.GetBuffsOnUnit(WCSharp.Api.unit).md 'WCSharp\.Buffs\.BuffSystem\.GetBuffsOnUnit\(WCSharp\.Api\.unit\)') | Uses a dictionary to quickly find all buffs attached to the given unit\. |
| [RegisterForOwnershipChanges\(\)](WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges().md 'WCSharp\.Buffs\.BuffSystem\.RegisterForOwnershipChanges\(\)') | By default, [CastingPlayer](WCSharp.Buffs.Buff.CastingPlayer.md 'WCSharp\.Buffs\.Buff\.CastingPlayer') and [TargetPlayer](WCSharp.Buffs.Buff.TargetPlayer.md 'WCSharp\.Buffs\.Buff\.TargetPlayer') are not updated when a unit changes owner\.   This adds an event to pass over all auras and update [CastingPlayer](WCSharp.Buffs.Buff.CastingPlayer.md 'WCSharp\.Buffs\.Buff\.CastingPlayer') and [TargetPlayer](WCSharp.Buffs.Buff.TargetPlayer.md 'WCSharp\.Buffs\.Buff\.TargetPlayer') on ownership changes.  This will ignore ownership changes of unit type 'xxxx' ([UNIT\_TYPE\_DUMMY](../WCSharp.Dummies/WCSharp.Dummies.DummySystem.UNIT_TYPE_DUMMY.md 'WCSharp\.Dummies\.DummySystem\.UNIT\_TYPE\_DUMMY')). |
| [SetTickInterval\(float\)](WCSharp.Buffs.BuffSystem.SetTickInterval(float).md 'WCSharp\.Buffs\.BuffSystem\.SetTickInterval\(float\)') | Changes the tick interval to the desired value\.   Note that the actual change occurs after a 0 second delay.  Calls [BeforeTickIntervalChanged\(float, float\)](WCSharp.Buffs.Buff.BeforeTickIntervalChanged(float,float).md 'WCSharp\.Buffs\.Buff\.BeforeTickIntervalChanged\(float, float\)') to adjust existing missiles. |
