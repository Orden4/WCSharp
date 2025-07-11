#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs')

## AuraBoundBuff Class

This class is identical to [BoundBuff](WCSharp.Buffs.BoundBuff.md 'WCSharp\.Buffs\.BoundBuff'), except that it implements a default [OnStack\(Buff\)](WCSharp.Buffs.AuraBoundBuff.OnStack(WCSharp.Buffs.Buff).md 'WCSharp\.Buffs\.AuraBoundBuff\.OnStack\(WCSharp\.Buffs\.Buff\)') behaviour that better
matches standard aura behaviour\.

The [Stacks](WCSharp.Buffs.Buff.Stacks.md 'WCSharp\.Buffs\.Buff\.Stacks') property will be set to the number of aura bearers applying the aura.

```csharp
public abstract class AuraBoundBuff : WCSharp.Buffs.BoundBuff
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [Buff](WCSharp.Buffs.Buff.md 'WCSharp\.Buffs\.Buff') &#129106; [BoundBuff](WCSharp.Buffs.BoundBuff.md 'WCSharp\.Buffs\.BoundBuff') &#129106; AuraBoundBuff

| Constructors | |
| :--- | :--- |
| [AuraBoundBuff\(unit, unit\)](WCSharp.Buffs.AuraBoundBuff.AuraBoundBuff(WCSharp.Api.unit,WCSharp.Api.unit).md 'WCSharp\.Buffs\.AuraBoundBuff\.AuraBoundBuff\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)') | Will set Caster, CastingPlayer, Target and TargetPlayer accordingly\. |

| Methods | |
| :--- | :--- |
| [OnStack\(Buff\)](WCSharp.Buffs.AuraBoundBuff.OnStack(WCSharp.Buffs.Buff).md 'WCSharp\.Buffs\.AuraBoundBuff\.OnStack\(WCSharp\.Buffs\.Buff\)') | Executes whenever this buff receives a new stack via [Add\(Buff, StackBehaviour\)](WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).md 'WCSharp\.Buffs\.BuffSystem\.Add\(WCSharp\.Buffs\.Buff, WCSharp\.Buffs\.StackBehaviour\)')\.   AuraBoundBuffs will always have their [Stacks](WCSharp.Buffs.Buff.Stacks.md 'WCSharp\.Buffs\.Buff\.Stacks') property set to the number of aura bearers applying the aura. |
