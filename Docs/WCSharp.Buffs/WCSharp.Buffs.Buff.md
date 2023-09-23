#### [WCSharp.Buffs](index.md 'index')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs')

## Buff Class

The most basic buff implementation, with almost all logic undefined.  
  
It is recommended to use one of the more concrete types instead, such as [PassiveBuff](WCSharp.Buffs.PassiveBuff.md 'WCSharp.Buffs.PassiveBuff').

```csharp
public abstract class Buff
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Buff

Derived  
&#8627; [AutoBuff](WCSharp.Buffs.AutoBuff.md 'WCSharp.Buffs.AutoBuff')  
&#8627; [BoundBuff](WCSharp.Buffs.BoundBuff.md 'WCSharp.Buffs.BoundBuff')  
&#8627; [PassiveBuff](WCSharp.Buffs.PassiveBuff.md 'WCSharp.Buffs.PassiveBuff')  
&#8627; [RollingBuff&lt;T&gt;](WCSharp.Buffs.RollingBuff_T_.md 'WCSharp.Buffs.RollingBuff<T>')  
&#8627; [TickingBuff](WCSharp.Buffs.TickingBuff.md 'WCSharp.Buffs.TickingBuff')

| Constructors | |
| :--- | :--- |
| [Buff(unit, unit)](WCSharp.Buffs.Buff.Buff(War3Api.Common.unit,War3Api.Common.unit).md 'WCSharp.Buffs.Buff.Buff(War3Api.Common.unit, War3Api.Common.unit)') | Will set Caster, CastingPlayer, Target and TargetPlayer accordingly. |

| Properties | |
| :--- | :--- |
| [Active](WCSharp.Buffs.Buff.Active.md 'WCSharp.Buffs.Buff.Active') | Indicates the active state of this buff. Setting this to false will cause it to be removed on the next update cycle (at most [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') later). |
| [BuffTypes](WCSharp.Buffs.Buff.BuffTypes.md 'WCSharp.Buffs.Buff.BuffTypes') | The buff types, used primarily for dispelling. e.g. magic, physical, undispellable, etc. |
| [Caster](WCSharp.Buffs.Buff.Caster.md 'WCSharp.Buffs.Buff.Caster') | The unit that applied the buff. |
| [CastingPlayer](WCSharp.Buffs.Buff.CastingPlayer.md 'WCSharp.Buffs.Buff.CastingPlayer') | The owner of the caster. Automatically set on application.<br/><br/><br/>Does NOT update automatically! If this is desired, you can use [RegisterForOwnershipChanges()](WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges().md 'WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges()'). |
| [Duration](WCSharp.Buffs.Buff.Duration.md 'WCSharp.Buffs.Buff.Duration') | The remaining duration before this buff expires. |
| [Effect](WCSharp.Buffs.Buff.Effect.md 'WCSharp.Buffs.Buff.Effect') | The effect being used by the missile. Creation of the effect should be done by setting [EffectString](WCSharp.Buffs.Buff.EffectString.md 'WCSharp.Buffs.Buff.EffectString'), not by setting this property. |
| [EffectAttachmentPoint](WCSharp.Buffs.Buff.EffectAttachmentPoint.md 'WCSharp.Buffs.Buff.EffectAttachmentPoint') | The attachment point for the effect.<br/><br/><br/>If changed while the buff is already active, will destroy and recreate the effect at the desired attachment point.<br/><br/>Defaults to origin. |
| [EffectScale](WCSharp.Buffs.Buff.EffectScale.md 'WCSharp.Buffs.Buff.EffectScale') | The effect scale of the missile.<br/><br/><br/>If modified mid-flight, automatically modifies the missile. |
| [EffectString](WCSharp.Buffs.Buff.EffectString.md 'WCSharp.Buffs.Buff.EffectString') | The path of the effect to use. Leave empty for no effect.<br/><br/><br/>If changed while the buff is already active, will destroy and recreate the effect. |
| [IsBeneficial](WCSharp.Buffs.Buff.IsBeneficial.md 'WCSharp.Buffs.Buff.IsBeneficial') | Whether this buff is beneficial or detrimental to the target. |
| [Stacks](WCSharp.Buffs.Buff.Stacks.md 'WCSharp.Buffs.Buff.Stacks') | The number of stacks of this buff currently active on the target.<br/><br/><br/>Defaults to 1. |
| [Target](WCSharp.Buffs.Buff.Target.md 'WCSharp.Buffs.Buff.Target') | The target to which this buff is attached. |
| [TargetPlayer](WCSharp.Buffs.Buff.TargetPlayer.md 'WCSharp.Buffs.Buff.TargetPlayer') | The owner of the target. Automatically set on application.<br/><br/><br/>Does NOT update automatically! If this is desired, you can use [RegisterForOwnershipChanges()](WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges().md 'WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges()'). |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Buffs.Buff.Action().md 'WCSharp.Buffs.Buff.Action()') | Called by the system. Do not call yourself. |
| [Apply()](WCSharp.Buffs.Buff.Apply().md 'WCSharp.Buffs.Buff.Apply()') | Called by the system. Do not call yourself. |
| [Dispose()](WCSharp.Buffs.Buff.Dispose().md 'WCSharp.Buffs.Buff.Dispose()') | Automatically called after [Active](WCSharp.Buffs.Buff.Active.md 'WCSharp.Buffs.Buff.Active') is set to false.<br/><br/><br/>Automatically called by the system. Do not call yourself. |
| [OnApply()](WCSharp.Buffs.Buff.OnApply().md 'WCSharp.Buffs.Buff.OnApply()') | Executes immediately upon application of the buff. |
| [OnDeath(bool)](WCSharp.Buffs.Buff.OnDeath(bool).md 'WCSharp.Buffs.Buff.OnDeath(bool)') | Executes immediately after [Target](WCSharp.Buffs.Buff.Target.md 'WCSharp.Buffs.Buff.Target') dies.<br/><br/><br/>Note: [killingBlow](WCSharp.Buffs.Buff.OnDeath(bool).md#WCSharp.Buffs.Buff.OnDeath(bool).killingBlow 'WCSharp.Buffs.Buff.OnDeath(bool).killingBlow') will be true if the unit dies while the buffs actions are being evaluated.<br/>            It may not be directly responsible for the death due to asynchronous events. |
| [OnDispel(unit, int)](WCSharp.Buffs.Buff.OnDispel(War3Api.Common.unit,int).md 'WCSharp.Buffs.Buff.OnDispel(War3Api.Common.unit, int)') | Executes when an attempt is made to dispel the target. Return the number of dispel charges consmed.<br/><br/><br/>If after this method is called the Stacks is at 0, the buff is automatically disposed. |
| [OnDispose()](WCSharp.Buffs.Buff.OnDispose().md 'WCSharp.Buffs.Buff.OnDispose()') | Executes when the buff is removed for any reason whatsoever. |
| [OnExpire()](WCSharp.Buffs.Buff.OnExpire().md 'WCSharp.Buffs.Buff.OnExpire()') | Executes when the buff expires by reaching the end of its duration. Does not trigger when the buff is removed via a dispel or target dies. |
| [OnStack(Buff)](WCSharp.Buffs.Buff.OnStack(WCSharp.Buffs.Buff).md 'WCSharp.Buffs.Buff.OnStack(WCSharp.Buffs.Buff)') | Executes whenever this buff receives a new stack via [Add(Buff, StackBehaviour)](WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).md 'WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff, WCSharp.Buffs.StackBehaviour)').<br/><br/><br/>By default, the stacks of [newStack](WCSharp.Buffs.Buff.OnStack(WCSharp.Buffs.Buff).md#WCSharp.Buffs.Buff.OnStack(WCSharp.Buffs.Buff).newStack 'WCSharp.Buffs.Buff.OnStack(WCSharp.Buffs.Buff).newStack') are added to this buff and [Stack](WCSharp.Buffs.StackResult.md#WCSharp.Buffs.StackResult.Stack 'WCSharp.Buffs.StackResult.Stack') is returned. |
| [RemoveInstantly()](WCSharp.Buffs.Buff.RemoveInstantly().md 'WCSharp.Buffs.Buff.RemoveInstantly()') | Will instantly remove this buff from the unit, including calling [OnDispose()](WCSharp.Buffs.Buff.OnDispose().md 'WCSharp.Buffs.Buff.OnDispose()') and any other relevant steps.<br/><br/><br/>It's recommended to just set [Active](WCSharp.Buffs.Buff.Active.md 'WCSharp.Buffs.Buff.Active') to false unless the removal should not be delayed for some reason. |
