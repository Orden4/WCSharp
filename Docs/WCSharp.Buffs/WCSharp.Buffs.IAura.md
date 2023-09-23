#### [WCSharp.Buffs](index.md 'index')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs')

## IAura Interface

Backing interface for auras, since different auras can otherwise not be stored in a generic way.

```csharp
public interface IAura :
WCSharp.Events.IPeriodicDisposableAction
```

Derived  
&#8627; [Aura&lt;T&gt;](WCSharp.Buffs.Aura_T_.md 'WCSharp.Buffs.Aura<T>')

Implements [IPeriodicDisposableAction](../WCSharp.Events/WCSharp.Events.IPeriodicDisposableAction.md 'WCSharp.Events.IPeriodicDisposableAction')

| Properties | |
| :--- | :--- |
| [Caster](WCSharp.Buffs.IAura.Caster.md 'WCSharp.Buffs.IAura.Caster') | The caster. |
| [CastingPlayer](WCSharp.Buffs.IAura.CastingPlayer.md 'WCSharp.Buffs.IAura.CastingPlayer') | The owner of the caster. Automatically set on application.<br/><br/><br/>Does NOT update automatically! If this is desired, you can use [RegisterForOwnershipChanges()](WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges().md 'WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges()'). |
| [Duration](WCSharp.Buffs.IAura.Duration.md 'WCSharp.Buffs.IAura.Duration') | The duration in seconds of buffs applied by this aura.<br/><br/><br/>Unless you're making a pulsing aura, you will want the [Duration](WCSharp.Buffs.IAura.Duration.md 'WCSharp.Buffs.IAura.Duration') to be greater than the [SearchInterval](WCSharp.Buffs.IAura.SearchInterval.md 'WCSharp.Buffs.IAura.SearchInterval'). |
| [Effect](WCSharp.Buffs.IAura.Effect.md 'WCSharp.Buffs.IAura.Effect') | The effect used by the aura. Creation of the effect should be done by setting [EffectString](WCSharp.Buffs.IAura.EffectString.md 'WCSharp.Buffs.IAura.EffectString'), not by setting this property. |
| [EffectAttachmentPoint](WCSharp.Buffs.IAura.EffectAttachmentPoint.md 'WCSharp.Buffs.IAura.EffectAttachmentPoint') | The attachment point for the effect.<br/><br/><br/>If changed while the aura is already active, will destroy and recreate the effect at the desired attachment point.<br/><br/>Defaults to origin. |
| [EffectScale](WCSharp.Buffs.IAura.EffectScale.md 'WCSharp.Buffs.IAura.EffectScale') | |
| [EffectString](WCSharp.Buffs.IAura.EffectString.md 'WCSharp.Buffs.IAura.EffectString') | The path of the effect to use. Leave empty for no effect.<br/><br/><br/>If changed while the aura is already active, will destroy and recreate the effect. |
| [Radius](WCSharp.Buffs.IAura.Radius.md 'WCSharp.Buffs.IAura.Radius') | The range within which units must be for the aura to be applied to them. |
| [SearchInterval](WCSharp.Buffs.IAura.SearchInterval.md 'WCSharp.Buffs.IAura.SearchInterval') | How long in seconds between applications of this aura. |
| [SearchIntervalLeft](WCSharp.Buffs.IAura.SearchIntervalLeft.md 'WCSharp.Buffs.IAura.SearchIntervalLeft') | How long in seconds until this aura will next be applied to valid units in range. |
| [StackBehaviour](WCSharp.Buffs.IAura.StackBehaviour.md 'WCSharp.Buffs.IAura.StackBehaviour') | The stack behaviour of buffs applied by this aura.<br/><br/><br/>Note that even with [None](WCSharp.Buffs.StackBehaviour.md#WCSharp.Buffs.StackBehaviour.None 'WCSharp.Buffs.StackBehaviour.None'), auras will still only stack once per aura instance. |

| Methods | |
| :--- | :--- |
| [Apply()](WCSharp.Buffs.IAura.Apply().md 'WCSharp.Buffs.IAura.Apply()') | Called by the system. Do not call yourself. |
| [GetActiveBuffs()](WCSharp.Buffs.IAura.GetActiveBuffs().md 'WCSharp.Buffs.IAura.GetActiveBuffs()') | Returns all generic buffs currently active for this aura. |
