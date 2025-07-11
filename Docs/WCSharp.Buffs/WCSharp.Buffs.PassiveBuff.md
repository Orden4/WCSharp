#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs')

## PassiveBuff Class

A very basic buff implementation that simply applies and removes itself according to its duration\.

```csharp
public abstract class PassiveBuff : WCSharp.Buffs.Buff
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [Buff](WCSharp.Buffs.Buff.md 'WCSharp\.Buffs\.Buff') &#129106; PassiveBuff

| Constructors | |
| :--- | :--- |
| [PassiveBuff\(unit, unit\)](WCSharp.Buffs.PassiveBuff.PassiveBuff(WCSharp.Api.unit,WCSharp.Api.unit).md 'WCSharp\.Buffs\.PassiveBuff\.PassiveBuff\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)') | Will set Caster, CastingPlayer, Target and TargetPlayer accordingly\. |

| Methods | |
| :--- | :--- |
| [Action\(\)](WCSharp.Buffs.PassiveBuff.Action().md 'WCSharp\.Buffs\.PassiveBuff\.Action\(\)') | Called by the system\. Do not call yourself\. |
| [Apply\(\)](WCSharp.Buffs.PassiveBuff.Apply().md 'WCSharp\.Buffs\.PassiveBuff\.Apply\(\)') | Called by the system\. Do not call yourself\. |
| [Dispose\(\)](WCSharp.Buffs.PassiveBuff.Dispose().md 'WCSharp\.Buffs\.PassiveBuff\.Dispose\(\)') | Automatically called after [Active](WCSharp.Buffs.Buff.Active.md 'WCSharp\.Buffs\.Buff\.Active') is set to false\.   Automatically called by the system. Do not call yourself. |
