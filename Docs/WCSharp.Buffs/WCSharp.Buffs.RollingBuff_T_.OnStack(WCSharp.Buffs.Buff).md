#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[RollingBuff&lt;T&gt;](WCSharp.Buffs.RollingBuff_T_.md 'WCSharp\.Buffs\.RollingBuff\<T\>')

## RollingBuff\<T\>\.OnStack\(Buff\) Method

Executes whenever this buff receives a new stack via [Add\(Buff, StackBehaviour\)](WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).md 'WCSharp\.Buffs\.BuffSystem\.Add\(WCSharp\.Buffs\.Buff, WCSharp\.Buffs\.StackBehaviour\)')\.
When overriding this method, you should always invoke base\.OnStack\(newStack\)\.

```csharp
public override WCSharp.Buffs.StackResult OnStack(WCSharp.Buffs.Buff newStack);
```
#### Parameters

<a name='WCSharp.Buffs.RollingBuff_T_.OnStack(WCSharp.Buffs.Buff).newStack'></a>

`newStack` [Buff](WCSharp.Buffs.Buff.md 'WCSharp\.Buffs\.Buff')

#### Returns
[StackResult](WCSharp.Buffs.StackResult.md 'WCSharp\.Buffs\.StackResult')