#### [WCSharp.Buffs](README.md 'README')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs')

## RollingBuff<T> Class

A specialized buff for handling multiple underlying buffs, each with their own duration. The buff will tick only once, but the durations of all underlying buffs are managed individually.

```csharp
public abstract class RollingBuff<T> : WCSharp.Buffs.Buff
    where T : WCSharp.Buffs.RollingBuff<T>
```
#### Type parameters

<a name='WCSharp.Buffs.RollingBuff_T_.T'></a>

`T`

This should be the type implementing this abstract.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff') &#129106; RollingBuff<T>

| Constructors | |
| :--- | :--- |
| [RollingBuff(unit, unit)](WCSharp.Buffs.RollingBuff_T_.RollingBuff(War3Api.Common.unit,War3Api.Common.unit).md 'WCSharp.Buffs.RollingBuff<T>.RollingBuff(War3Api.Common.unit, War3Api.Common.unit)') | Will set Caster, CastingPlayer, Target and TargetPlayer accordingly. |

| Properties | |
| :--- | :--- |
| [Buffs](WCSharp.Buffs.RollingBuff_T_.Buffs.md 'WCSharp.Buffs.RollingBuff<T>.Buffs') | All buffs contained in this stack.<br/><br/><br/>Note that this is only filled for the main stack. |
| [Interval](WCSharp.Buffs.RollingBuff_T_.Interval.md 'WCSharp.Buffs.RollingBuff<T>.Interval') | The time, in seconds, between each tick. |
| [IntervalLeft](WCSharp.Buffs.RollingBuff_T_.IntervalLeft.md 'WCSharp.Buffs.RollingBuff<T>.IntervalLeft') | The time, in seconds, remaining until the next tick. |
| [IsMainStack](WCSharp.Buffs.RollingBuff_T_.IsMainStack.md 'WCSharp.Buffs.RollingBuff<T>.IsMainStack') | Whether the current instance is the main stack (i.e. the instance that manages underlying instances). |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Buffs.RollingBuff_T_.Action().md 'WCSharp.Buffs.RollingBuff<T>.Action()') | Called by the system. Do not call yourself. |
| [Apply()](WCSharp.Buffs.RollingBuff_T_.Apply().md 'WCSharp.Buffs.RollingBuff<T>.Apply()') | Called by the system. Do not call yourself. |
| [Dispose()](WCSharp.Buffs.RollingBuff_T_.Dispose().md 'WCSharp.Buffs.RollingBuff<T>.Dispose()') | Automatically called after [Active](WCSharp.Buffs.Buff.Active.md 'WCSharp.Buffs.Buff.Active') is set to false.<br/><br/><br/>Automatically called by the system. Do not call yourself. |
| [OnExpireStack(T)](WCSharp.Buffs.RollingBuff_T_.OnExpireStack(T).md 'WCSharp.Buffs.RollingBuff<T>.OnExpireStack(T)') | Executes whenever a stack expires (executed from the main stack). |
| [OnStack(Buff)](WCSharp.Buffs.RollingBuff_T_.OnStack(WCSharp.Buffs.Buff).md 'WCSharp.Buffs.RollingBuff<T>.OnStack(WCSharp.Buffs.Buff)') | Executes whenever this buff receives a new stack via [Add(Buff, StackBehaviour)](WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).md 'WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff, WCSharp.Buffs.StackBehaviour)').<br/>When overriding this method, you should always invoke base.OnStack(newStack). |
| [OnTick()](WCSharp.Buffs.RollingBuff_T_.OnTick().md 'WCSharp.Buffs.RollingBuff<T>.OnTick()') | Executes every [Interval](WCSharp.Buffs.RollingBuff_T_.Interval.md 'WCSharp.Buffs.RollingBuff<T>.Interval'). |
