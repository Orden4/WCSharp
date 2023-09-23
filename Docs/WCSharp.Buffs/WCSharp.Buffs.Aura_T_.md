### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs')

## Aura<T> Class

Auras constantly apply/refresh a linked [Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff') on valid targets in range.

```csharp
public abstract class Aura<T> :
WCSharp.Buffs.IAura,
WCSharp.Events.IPeriodicDisposableAction
    where T : WCSharp.Buffs.Buff
```
#### Type parameters

<a name='WCSharp.Buffs.Aura_T_.T'></a>

`T`

The buff that will be applied by this aura.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Aura<T>

Implements [IAura](WCSharp.Buffs.IAura.md 'WCSharp.Buffs.IAura'), [IPeriodicDisposableAction](../WCSharp.Events/WCSharp.Events.IPeriodicDisposableAction.md 'WCSharp.Events.IPeriodicDisposableAction')

| Constructors | |
| :--- | :--- |
| [Aura(unit)](WCSharp.Buffs.Aura_T_.Aura(War3Api.Common.unit).md 'WCSharp.Buffs.Aura<T>.Aura(War3Api.Common.unit)') | Creates a new aura centered around the given caster. |

| Properties | |
| :--- | :--- |
| [Active](WCSharp.Buffs.Aura_T_.Active.md 'WCSharp.Buffs.Aura<T>.Active') | Indicates the active state of this IPeriodicAction. Set this to false to disable and dispose this instance. |
| [Caster](WCSharp.Buffs.Aura_T_.Caster.md 'WCSharp.Buffs.Aura<T>.Caster') | The caster. |
| [CastingPlayer](WCSharp.Buffs.Aura_T_.CastingPlayer.md 'WCSharp.Buffs.Aura<T>.CastingPlayer') | The owner of the caster. Automatically set on application.<br/><br/><br/>Does NOT update automatically! If this is desired, you can use [RegisterForOwnershipChanges()](WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges().md 'WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges()'). |
| [Duration](WCSharp.Buffs.Aura_T_.Duration.md 'WCSharp.Buffs.Aura<T>.Duration') | The duration in seconds of buffs applied by this aura. Defaults to 3.1.<br/><br/><br/>Unless you're making a pulsing aura, you will want the [Duration](WCSharp.Buffs.Aura_T_.Duration.md 'WCSharp.Buffs.Aura<T>.Duration') to be greater than the [SearchInterval](WCSharp.Buffs.Aura_T_.SearchInterval.md 'WCSharp.Buffs.Aura<T>.SearchInterval'). |
| [Effect](WCSharp.Buffs.Aura_T_.Effect.md 'WCSharp.Buffs.Aura<T>.Effect') | The effect used by the aura. Creation of the effect should be done by setting [EffectString](WCSharp.Buffs.IAura.EffectString.md 'WCSharp.Buffs.IAura.EffectString'), not by setting this property. |
| [EffectAttachmentPoint](WCSharp.Buffs.Aura_T_.EffectAttachmentPoint.md 'WCSharp.Buffs.Aura<T>.EffectAttachmentPoint') | The attachment point for the effect.<br/><br/><br/>If changed while the aura is already active, will destroy and recreate the effect at the desired attachment point.<br/><br/>Defaults to origin. |
| [EffectScale](WCSharp.Buffs.Aura_T_.EffectScale.md 'WCSharp.Buffs.Aura<T>.EffectScale') | |
| [EffectString](WCSharp.Buffs.Aura_T_.EffectString.md 'WCSharp.Buffs.Aura<T>.EffectString') | The path of the effect to use. Leave empty for no effect.<br/><br/><br/>If changed while the aura is already active, will destroy and recreate the effect. |
| [Radius](WCSharp.Buffs.Aura_T_.Radius.md 'WCSharp.Buffs.Aura<T>.Radius') | The range within which units must be for the aura to be applied to them. |
| [SearchInterval](WCSharp.Buffs.Aura_T_.SearchInterval.md 'WCSharp.Buffs.Aura<T>.SearchInterval') | How long in seconds between applications of this aura. Defaults to 1.0. |
| [SearchIntervalLeft](WCSharp.Buffs.Aura_T_.SearchIntervalLeft.md 'WCSharp.Buffs.Aura<T>.SearchIntervalLeft') | How long in seconds until this aura will next be applied to valid units in range. |
| [StackBehaviour](WCSharp.Buffs.Aura_T_.StackBehaviour.md 'WCSharp.Buffs.Aura<T>.StackBehaviour') | The stack behaviour of buffs applied by this aura.<br/><br/><br/>Note that even with [None](WCSharp.Buffs.StackBehaviour.md#WCSharp.Buffs.StackBehaviour.None 'WCSharp.Buffs.StackBehaviour.None'), auras will still only stack once per aura instance. |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Buffs.Aura_T_.Action().md 'WCSharp.Buffs.Aura<T>.Action()') | The action that will be invoked every period by [PeriodicDisposableTrigger&lt;T&gt;](../WCSharp.Events/WCSharp.Events.PeriodicDisposableTrigger_T_.md 'WCSharp.Events.PeriodicDisposableTrigger`1'). |
| [Apply()](WCSharp.Buffs.Aura_T_.Apply().md 'WCSharp.Buffs.Aura<T>.Apply()') | Called by the system. Do not call yourself. |
| [Dispose()](WCSharp.Buffs.Aura_T_.Dispose().md 'WCSharp.Buffs.Aura<T>.Dispose()') | Automatically called after [Active](../WCSharp.Events/WCSharp.Events.IPeriodicDisposableAction.Active.md 'WCSharp.Events.IPeriodicDisposableAction.Active') is set to false. |
| [GetActiveBuffs()](WCSharp.Buffs.Aura_T_.GetActiveBuffs().md 'WCSharp.Buffs.Aura<T>.GetActiveBuffs()') | Returns all generic buffs currently active for this aura. |
