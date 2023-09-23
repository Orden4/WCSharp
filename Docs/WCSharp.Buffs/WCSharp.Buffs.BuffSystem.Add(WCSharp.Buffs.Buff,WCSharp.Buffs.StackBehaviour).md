#### [WCSharp.Buffs](index.md 'index')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[BuffSystem](WCSharp.Buffs.BuffSystem.md 'WCSharp.Buffs.BuffSystem')

## BuffSystem.Add(Buff, StackBehaviour) Method

Adds the given [buff](WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).md#WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).buff 'WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff, WCSharp.Buffs.StackBehaviour).buff') to the system. If addition is successful, will invoke [OnApply()](WCSharp.Buffs.Buff.OnApply().md 'WCSharp.Buffs.Buff.OnApply()').

```csharp
public static WCSharp.Buffs.Buff Add(WCSharp.Buffs.Buff buff, WCSharp.Buffs.StackBehaviour stackBehaviour=WCSharp.Buffs.StackBehaviour.None);
```
#### Parameters

<a name='WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).buff'></a>

`buff` [Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff')

<a name='WCSharp.Buffs.BuffSystem.Add(WCSharp.Buffs.Buff,WCSharp.Buffs.StackBehaviour).stackBehaviour'></a>

`stackBehaviour` [StackBehaviour](WCSharp.Buffs.StackBehaviour.md 'WCSharp.Buffs.StackBehaviour')

#### Returns
[Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff')  
The buff that was applied, or the buff whose stacks were added to.