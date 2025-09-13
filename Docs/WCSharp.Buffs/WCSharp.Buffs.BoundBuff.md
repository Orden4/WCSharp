#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs')

## BoundBuff Class

BoundBuffs have additional logic for binding the buff to an in\-game buff with support of the [DummySystem](../WCSharp.Dummies/WCSharp.Dummies.DummySystem.md 'WCSharp\.Dummies\.DummySystem')\.

As a result, this buff works a little differently, and you should read the wiki in order to see how you should handle these buffs.

```csharp
public class BoundBuff : WCSharp.Buffs.Buff
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [Buff](WCSharp.Buffs.Buff.md 'WCSharp\.Buffs\.Buff') &#129106; BoundBuff

Derived  
&#8627; [AuraBoundBuff](WCSharp.Buffs.AuraBoundBuff.md 'WCSharp\.Buffs\.AuraBoundBuff')

| Constructors | |
| :--- | :--- |
| [BoundBuff\(unit, unit\)](WCSharp.Buffs.BoundBuff.BoundBuff(WCSharp.Api.unit,WCSharp.Api.unit).md 'WCSharp\.Buffs\.BoundBuff\.BoundBuff\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)') | Will set Caster, CastingPlayer, Target and TargetPlayer accordingly\. |

| Properties | |
| :--- | :--- |
| [BindLeeway](WCSharp.Buffs.BoundBuff.BindLeeway.md 'WCSharp\.Buffs\.BoundBuff\.BindLeeway') | Used to prevent the buff from being immediately dropped\. Intended to give some leeway for the dummy\-based bind\.   This is decreased by 1 every [TickInterval](WCSharp.Buffs.BuffSystem.TickInterval.md 'WCSharp\.Buffs\.BuffSystem\.TickInterval'), once it becomes 0 or less it will remove this buff if the in-game buff is not present.  Automatically set to 0 once it detects the buff on the target.  Defaults to 8 (0.25s). |
| [BuffId](WCSharp.Buffs.BoundBuff.BuffId.md 'WCSharp\.Buffs\.BoundBuff\.BuffId') | The WC3 buff ID to track\.   If the given buff is no longer on the unit, this buff instance will be disposed.  You do not need to set this if you use [BindAura\(int, int, int\)](WCSharp.Buffs.BoundBuff.BindAura(int,int,int).md 'WCSharp\.Buffs\.BoundBuff\.BindAura\(int, int, int\)') or [BindDummyCast\(int, int, int, int, player\)](WCSharp.Buffs.BoundBuff.BindDummyCast(int,int,int,int,WCSharp.Api.player).md 'WCSharp\.Buffs\.BoundBuff\.BindDummyCast\(int, int, int, int, WCSharp\.Api\.player\)'). |
| [Interval](WCSharp.Buffs.BoundBuff.Interval.md 'WCSharp\.Buffs\.BoundBuff\.Interval') | The time, in seconds, between each tick\. |
| [IntervalLeft](WCSharp.Buffs.BoundBuff.IntervalLeft.md 'WCSharp\.Buffs\.BoundBuff\.IntervalLeft') | The time, in seconds, remaining until the next tick\. |

| Methods | |
| :--- | :--- |
| [Action\(\)](WCSharp.Buffs.BoundBuff.Action().md 'WCSharp\.Buffs\.BoundBuff\.Action\(\)') | Called by the system\. Do not call yourself\. |
| [Apply\(\)](WCSharp.Buffs.BoundBuff.Apply().md 'WCSharp\.Buffs\.BoundBuff\.Apply\(\)') | Called by the system\. Do not call yourself\. |
| [BindAura\(int, int, int\)](WCSharp.Buffs.BoundBuff.BindAura(int,int,int).md 'WCSharp\.Buffs\.BoundBuff\.BindAura\(int, int, int\)') | Will add the given aura to the unit if necessary and set its level accordingly\. The aura will automatically be hidden from the command UI and removed when the buff is removed\. |
| [BindDummyCast\(int, int, int, int, player\)](WCSharp.Buffs.BoundBuff.BindDummyCast(int,int,int,int,WCSharp.Api.player).md 'WCSharp\.Buffs\.BoundBuff\.BindDummyCast\(int, int, int, int, WCSharp\.Api\.player\)') | Will use the [DummySystem](../WCSharp.Dummies/WCSharp.Dummies.DummySystem.md 'WCSharp\.Dummies\.DummySystem') to cast the given buffing ability on the target and then track it to synchronise removal\. |
| [Dispose\(\)](WCSharp.Buffs.BoundBuff.Dispose().md 'WCSharp\.Buffs\.BoundBuff\.Dispose\(\)') | Automatically called after [Active](WCSharp.Buffs.Buff.Active.md 'WCSharp\.Buffs\.Buff\.Active') is set to false\.   Automatically called by the system. Do not call yourself. |
| [OnStack\(Buff\)](WCSharp.Buffs.BoundBuff.OnStack(WCSharp.Buffs.Buff).md 'WCSharp\.Buffs\.BoundBuff\.OnStack\(WCSharp\.Buffs\.Buff\)') | Executes whenever this buff receives a new stack via [Add\(Buff, StackBehaviour\)](WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).md 'WCSharp\.Buffs\.BuffSystem\.Add\(WCSharp\.Buffs\.Buff, WCSharp\.Buffs\.StackBehaviour\)')\.   By default, BoundBuff will return [Consume](WCSharp.Buffs.StackResult.md#WCSharp.Buffs.StackResult.Consume 'WCSharp\.Buffs\.StackResult\.Consume'). |
| [OnTick\(\)](WCSharp.Buffs.BoundBuff.OnTick().md 'WCSharp\.Buffs\.BoundBuff\.OnTick\(\)') | Executes every [Interval](WCSharp.Buffs.BoundBuff.Interval.md 'WCSharp\.Buffs\.BoundBuff\.Interval')\. |
