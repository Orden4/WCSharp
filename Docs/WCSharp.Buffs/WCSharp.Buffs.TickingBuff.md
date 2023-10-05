#### [WCSharp.Buffs](README.md 'README')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs')

## TickingBuff Class

A simple buff that only adds a ticking behaviour, allowing an action to be performed every interval.  
If you simply want to damage/heal every tick, you can use [AutoBuff](WCSharp.Buffs.AutoBuff.md 'WCSharp.Buffs.AutoBuff') instead to simplify the process.

```csharp
public abstract class TickingBuff : WCSharp.Buffs.Buff
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff') &#129106; TickingBuff

| Constructors | |
| :--- | :--- |
| [TickingBuff(unit, unit)](WCSharp.Buffs.TickingBuff.TickingBuff(War3Api.Common.unit,War3Api.Common.unit).md 'WCSharp.Buffs.TickingBuff.TickingBuff(War3Api.Common.unit, War3Api.Common.unit)') | Will set Caster, CastingPlayer, Target and TargetPlayer accordingly. |

| Properties | |
| :--- | :--- |
| [Interval](WCSharp.Buffs.TickingBuff.Interval.md 'WCSharp.Buffs.TickingBuff.Interval') | The time, in seconds, between each tick. |
| [IntervalLeft](WCSharp.Buffs.TickingBuff.IntervalLeft.md 'WCSharp.Buffs.TickingBuff.IntervalLeft') | The time, in seconds, remaining until the next tick. |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Buffs.TickingBuff.Action().md 'WCSharp.Buffs.TickingBuff.Action()') | Called by the system. Do not call yourself. |
| [Apply()](WCSharp.Buffs.TickingBuff.Apply().md 'WCSharp.Buffs.TickingBuff.Apply()') | Called by the system. Do not call yourself. |
| [Dispose()](WCSharp.Buffs.TickingBuff.Dispose().md 'WCSharp.Buffs.TickingBuff.Dispose()') | Automatically called after [Active](WCSharp.Buffs.Buff.Active.md 'WCSharp.Buffs.Buff.Active') is set to false.<br/><br/><br/>Automatically called by the system. Do not call yourself. |
| [OnTick()](WCSharp.Buffs.TickingBuff.OnTick().md 'WCSharp.Buffs.TickingBuff.OnTick()') | Executes every [Interval](WCSharp.Buffs.TickingBuff.Interval.md 'WCSharp.Buffs.TickingBuff.Interval'). |
