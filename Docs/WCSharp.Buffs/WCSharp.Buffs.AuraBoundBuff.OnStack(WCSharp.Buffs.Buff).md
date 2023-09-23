#### [WCSharp.Buffs](index.md 'index')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[AuraBoundBuff](WCSharp.Buffs.AuraBoundBuff.md 'WCSharp.Buffs.AuraBoundBuff')

## AuraBoundBuff.OnStack(Buff) Method

Executes whenever this buff receives a new stack via [Add(Buff, StackBehaviour)](WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).md 'WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff, WCSharp.Buffs.StackBehaviour)').  
  
AuraBoundBuffs will always have their [Stacks](WCSharp.Buffs.Buff.Stacks.md 'WCSharp.Buffs.Buff.Stacks') property set to the number of aura bearers applying the aura.

```csharp
public sealed override WCSharp.Buffs.StackResult OnStack(WCSharp.Buffs.Buff newStack);
```
#### Parameters

<a name='WCSharp.Buffs.AuraBoundBuff.OnStack(WCSharp.Buffs.Buff).newStack'></a>

`newStack` [Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff')

#### Returns
[StackResult](WCSharp.Buffs.StackResult.md 'WCSharp.Buffs.StackResult')