#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[BoundBuff](WCSharp.Buffs.BoundBuff.md 'WCSharp\.Buffs\.BoundBuff')

## BoundBuff\.OnStack\(Buff\) Method

Executes whenever this buff receives a new stack via [Add\(Buff, StackBehaviour\)](WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).md 'WCSharp\.Buffs\.BuffSystem\.Add\(WCSharp\.Buffs\.Buff, WCSharp\.Buffs\.StackBehaviour\)')\.

By default, BoundBuff will return [Consume](WCSharp.Buffs.StackResult.md#WCSharp.Buffs.StackResult.Consume 'WCSharp\.Buffs\.StackResult\.Consume').

```csharp
public override WCSharp.Buffs.StackResult OnStack(WCSharp.Buffs.Buff newStack);
```
#### Parameters

<a name='WCSharp.Buffs.BoundBuff.OnStack(WCSharp.Buffs.Buff).newStack'></a>

`newStack` [Buff](WCSharp.Buffs.Buff.md 'WCSharp\.Buffs\.Buff')

#### Returns
[StackResult](WCSharp.Buffs.StackResult.md 'WCSharp\.Buffs\.StackResult')