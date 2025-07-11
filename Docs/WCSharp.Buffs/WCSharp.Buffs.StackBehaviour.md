#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs')

## StackBehaviour Enum

An enum to indicate how buffs should be stacked\.

```csharp
public enum StackBehaviour
```
### Fields

<a name='WCSharp.Buffs.StackBehaviour.None'></a>

`None` 0

This buff will not stack in any way\. All buffs will be applied individually\.

<a name='WCSharp.Buffs.StackBehaviour.Stack'></a>

`Stack` 1

This buff will stack with all instances of itself\.

<a name='WCSharp.Buffs.StackBehaviour.StackCaster'></a>

`StackCaster` 2

This buff will stack with all instances of itself cast by the same unit\.

<a name='WCSharp.Buffs.StackBehaviour.StackPlayer'></a>

`StackPlayer` 3

This buff will stack with all instances of itself cast by the same player\.