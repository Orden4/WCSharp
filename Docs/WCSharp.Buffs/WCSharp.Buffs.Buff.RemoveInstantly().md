#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[Buff](WCSharp.Buffs.Buff.md 'WCSharp\.Buffs\.Buff')

## Buff\.RemoveInstantly\(\) Method

Will instantly remove this buff from the unit, including calling [OnDispose\(\)](WCSharp.Buffs.Buff.OnDispose().md 'WCSharp\.Buffs\.Buff\.OnDispose\(\)') and any other relevant steps\.

It's recommended to just set [Active](WCSharp.Buffs.Buff.Active.md 'WCSharp\.Buffs\.Buff\.Active') to false unless the removal should not be delayed for some reason.

```csharp
public void RemoveInstantly();
```