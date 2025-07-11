#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[Buff](WCSharp.Buffs.Buff.md 'WCSharp\.Buffs\.Buff')

## Buff\.OnDispel\(unit, int\) Method

Executes when an attempt is made to dispel the target\. Return the number of dispel charges consmed\.

If after this method is called the Stacks is at 0, the buff is automatically disposed.

```csharp
public virtual int OnDispel(WCSharp.Api.unit dispeller, int dispelCharges);
```
#### Parameters

<a name='WCSharp.Buffs.Buff.OnDispel(WCSharp.Api.unit,int).dispeller'></a>

`dispeller` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Buffs.Buff.OnDispel(WCSharp.Api.unit,int).dispelCharges'></a>

`dispelCharges` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')