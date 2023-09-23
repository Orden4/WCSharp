#### [WCSharp.Buffs](index.md 'index')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff')

## Buff.OnDispel(unit, int) Method

Executes when an attempt is made to dispel the target. Return the number of dispel charges consmed.  
  
If after this method is called the Stacks is at 0, the buff is automatically disposed.

```csharp
public virtual int OnDispel(War3Api.Common.unit dispeller, int dispelCharges);
```
#### Parameters

<a name='WCSharp.Buffs.Buff.OnDispel(War3Api.Common.unit,int).dispeller'></a>

`dispeller` [War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')

<a name='WCSharp.Buffs.Buff.OnDispel(War3Api.Common.unit,int).dispelCharges'></a>

`dispelCharges` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')