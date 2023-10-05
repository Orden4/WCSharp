#### [WCSharp.Buffs](README.md 'README')

## WCSharp.Buffs Namespace

| Classes | |
| :--- | :--- |
| [Aura&lt;T&gt;](WCSharp.Buffs.Aura_T_.md 'WCSharp.Buffs.Aura<T>') | Auras constantly apply/refresh a linked [Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff') on valid targets in range. |
| [AuraBoundBuff](WCSharp.Buffs.AuraBoundBuff.md 'WCSharp.Buffs.AuraBoundBuff') | This class is identical to [BoundBuff](WCSharp.Buffs.BoundBuff.md 'WCSharp.Buffs.BoundBuff'), except that it implements a default [OnStack(Buff)](WCSharp.Buffs.AuraBoundBuff.OnStack(WCSharp.Buffs.Buff).md 'WCSharp.Buffs.AuraBoundBuff.OnStack(WCSharp.Buffs.Buff)') behaviour that better<br/>matches standard aura behaviour.<br/><br/><br/>The [Stacks](WCSharp.Buffs.Buff.Stacks.md 'WCSharp.Buffs.Buff.Stacks') property will be set to the number of aura bearers applying the aura. |
| [AuraSystem](WCSharp.Buffs.AuraSystem.md 'WCSharp.Buffs.AuraSystem') | Tracks and runs all active [IAura](WCSharp.Buffs.IAura.md 'WCSharp.Buffs.IAura') instances. |
| [AutoBuff](WCSharp.Buffs.AutoBuff.md 'WCSharp.Buffs.AutoBuff') | AutoBuffs are buffs which automatically tick for a specified damage/healing amount.<br/><br/><br/>If automatic damage/healing is not required, it is recommended to use [TickingBuff](WCSharp.Buffs.TickingBuff.md 'WCSharp.Buffs.TickingBuff') instead. |
| [BoundBuff](WCSharp.Buffs.BoundBuff.md 'WCSharp.Buffs.BoundBuff') | BoundBuffs have additional logic for binding the buff to an in-game buff with support of the [DummySystem](../WCSharp.Dummies/WCSharp.Dummies.DummySystem.md 'WCSharp.Dummies.DummySystem').<br/><br/><br/>As a result, this buff works a little differently, and you should read the wiki in order to see how you should handle these buffs. |
| [Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff') | The most basic buff implementation, with almost all logic undefined.<br/><br/><br/>It is recommended to use one of the more concrete types instead, such as [PassiveBuff](WCSharp.Buffs.PassiveBuff.md 'WCSharp.Buffs.PassiveBuff'). |
| [BuffSystem](WCSharp.Buffs.BuffSystem.md 'WCSharp.Buffs.BuffSystem') | Tracks and runs all active [Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff') instances. |
| [Dispel](WCSharp.Buffs.Dispel.md 'WCSharp.Buffs.Dispel') | Represents a dispel attempt on a buff. Will be returned even if the dispel was resisted (i.e. no stacks were dispelled). |
| [PassiveBuff](WCSharp.Buffs.PassiveBuff.md 'WCSharp.Buffs.PassiveBuff') | A very basic buff implementation that simply applies and removes itself according to its duration. |
| [RollingBuff&lt;T&gt;](WCSharp.Buffs.RollingBuff_T_.md 'WCSharp.Buffs.RollingBuff<T>') | A specialized buff for handling multiple underlying buffs, each with their own duration. The buff will tick only once, but the durations of all underlying buffs are managed individually. |
| [TickingBuff](WCSharp.Buffs.TickingBuff.md 'WCSharp.Buffs.TickingBuff') | A simple buff that only adds a ticking behaviour, allowing an action to be performed every interval.<br/>If you simply want to damage/heal every tick, you can use [AutoBuff](WCSharp.Buffs.AutoBuff.md 'WCSharp.Buffs.AutoBuff') instead to simplify the process. |

| Interfaces | |
| :--- | :--- |
| [IAura](WCSharp.Buffs.IAura.md 'WCSharp.Buffs.IAura') | Backing interface for auras, since different auras can otherwise not be stored in a generic way. |

| Enums | |
| :--- | :--- |
| [StackBehaviour](WCSharp.Buffs.StackBehaviour.md 'WCSharp.Buffs.StackBehaviour') | An enum to indicate how buffs should be stacked. |
| [StackResult](WCSharp.Buffs.StackResult.md 'WCSharp.Buffs.StackResult') | An enum to indicate how the buffs were stacked. |
