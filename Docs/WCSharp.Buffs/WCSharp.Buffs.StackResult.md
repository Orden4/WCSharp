#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs')

## StackResult Enum

An enum to indicate how the buffs were stacked\.

```csharp
public enum StackResult
```
### Fields

<a name='WCSharp.Buffs.StackResult.Reject'></a>

`Reject` 0

Reject the stack attempt \(apply separately\)\.

<a name='WCSharp.Buffs.StackResult.Stack'></a>

`Stack` 1

Keep old buff, discard new buff\.

<a name='WCSharp.Buffs.StackResult.Consume'></a>

`Consume` 2

Keep new buff, discard old buff\.