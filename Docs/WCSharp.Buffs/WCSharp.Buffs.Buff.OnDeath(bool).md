#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[Buff](WCSharp.Buffs.Buff.md 'WCSharp\.Buffs\.Buff')

## Buff\.OnDeath\(bool\) Method

Executes immediately after [Target](WCSharp.Buffs.Buff.Target.md 'WCSharp\.Buffs\.Buff\.Target') dies\.

Note: [killingBlow](WCSharp.Buffs.Buff.OnDeath(bool).md#WCSharp.Buffs.Buff.OnDeath(bool).killingBlow 'WCSharp\.Buffs\.Buff\.OnDeath\(bool\)\.killingBlow') will be true if the unit dies while the buffs actions are being evaluated.
            It may not be directly responsible for the death due to asynchronous events.

```csharp
public virtual void OnDeath(bool killingBlow);
```
#### Parameters

<a name='WCSharp.Buffs.Buff.OnDeath(bool).killingBlow'></a>

`killingBlow` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')