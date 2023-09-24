#### [WCSharp.Buffs](README.md 'README')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs')

## AutoBuff Class

AutoBuffs are buffs which automatically tick for a specified damage/healing amount.  
  
If automatic damage/healing is not required, it is recommended to use [TickingBuff](WCSharp.Buffs.TickingBuff.md 'WCSharp.Buffs.TickingBuff') instead.

```csharp
public abstract class AutoBuff : WCSharp.Buffs.Buff
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff') &#129106; AutoBuff

| Constructors | |
| :--- | :--- |
| [AutoBuff(unit, unit)](WCSharp.Buffs.AutoBuff.AutoBuff(War3Api.Common.unit,War3Api.Common.unit).md 'WCSharp.Buffs.AutoBuff.AutoBuff(War3Api.Common.unit, War3Api.Common.unit)') | Will set Caster, CastingPlayer, Target and TargetPlayer accordingly. |

| Properties | |
| :--- | :--- |
| [AttackType](WCSharp.Buffs.AutoBuff.AttackType.md 'WCSharp.Buffs.AutoBuff.AttackType') | The attack type to use when dealing damage via the built-in [DamagePerInterval](WCSharp.Buffs.AutoBuff.DamagePerInterval.md 'WCSharp.Buffs.AutoBuff.DamagePerInterval') property. |
| [DamagePerInterval](WCSharp.Buffs.AutoBuff.DamagePerInterval.md 'WCSharp.Buffs.AutoBuff.DamagePerInterval') | The damage to apply on each tick. Set to negative to heal.<br/><br/><br/>The damage dealer is the caster if the caster is alive, otherwise the target itself. |
| [DamageType](WCSharp.Buffs.AutoBuff.DamageType.md 'WCSharp.Buffs.AutoBuff.DamageType') | The damage type to use when dealing damage via the built-in [DamagePerInterval](WCSharp.Buffs.AutoBuff.DamagePerInterval.md 'WCSharp.Buffs.AutoBuff.DamagePerInterval') property. |
| [Interval](WCSharp.Buffs.AutoBuff.Interval.md 'WCSharp.Buffs.AutoBuff.Interval') | The time, in seconds, between each tick. |
| [IntervalLeft](WCSharp.Buffs.AutoBuff.IntervalLeft.md 'WCSharp.Buffs.AutoBuff.IntervalLeft') | The time, in seconds, remaining until the next tick. |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Buffs.AutoBuff.Action().md 'WCSharp.Buffs.AutoBuff.Action()') | Called by the system. Do not call yourself. |
| [Apply()](WCSharp.Buffs.AutoBuff.Apply().md 'WCSharp.Buffs.AutoBuff.Apply()') | Called by the system. Do not call yourself. |
| [Dispose()](WCSharp.Buffs.AutoBuff.Dispose().md 'WCSharp.Buffs.AutoBuff.Dispose()') | Automatically called after [Active](WCSharp.Buffs.Buff.Active.md 'WCSharp.Buffs.Buff.Active') is set to false.<br/><br/><br/>Automatically called by the system. Do not call yourself. |
| [OnTick()](WCSharp.Buffs.AutoBuff.OnTick().md 'WCSharp.Buffs.AutoBuff.OnTick()') | Executes every [Interval](WCSharp.Buffs.AutoBuff.Interval.md 'WCSharp.Buffs.AutoBuff.Interval').<br/><br/><br/>This is called BEFORE the automatic damage/healing occurs. |
