#### [WCSharp.Buffs](README.md 'README')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff')

## Buff.OnStack(Buff) Method

Executes whenever this buff receives a new stack via [Add(Buff, StackBehaviour)](WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).md 'WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff, WCSharp.Buffs.StackBehaviour)').  
  
By default, the stacks of [newStack](WCSharp.Buffs.Buff.OnStack(WCSharp.Buffs.Buff).md#WCSharp.Buffs.Buff.OnStack(WCSharp.Buffs.Buff).newStack 'WCSharp.Buffs.Buff.OnStack(WCSharp.Buffs.Buff).newStack') are added to this buff and [Stack](WCSharp.Buffs.StackResult.md#WCSharp.Buffs.StackResult.Stack 'WCSharp.Buffs.StackResult.Stack') is returned.

```csharp
public virtual WCSharp.Buffs.StackResult OnStack(WCSharp.Buffs.Buff newStack);
```
#### Parameters

<a name='WCSharp.Buffs.Buff.OnStack(WCSharp.Buffs.Buff).newStack'></a>

`newStack` [Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff')

#### Returns
[StackResult](WCSharp.Buffs.StackResult.md 'WCSharp.Buffs.StackResult')