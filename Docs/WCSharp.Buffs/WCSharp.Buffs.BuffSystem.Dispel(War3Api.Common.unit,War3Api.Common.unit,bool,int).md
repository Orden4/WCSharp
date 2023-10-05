#### [WCSharp.Buffs](README.md 'README')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[BuffSystem](WCSharp.Buffs.BuffSystem.md 'WCSharp.Buffs.BuffSystem')

## BuffSystem.Dispel(unit, unit, bool, int) Method

Attempts to dispel buffs from the target. Buff types are ignored.

```csharp
public static System.Collections.Generic.List<WCSharp.Buffs.Dispel> Dispel(War3Api.Common.unit target, War3Api.Common.unit dispeller, bool isBeneficial, int dispelAmount);
```
#### Parameters

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int).target'></a>

`target` [War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')

The target to dispel from.

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int).dispeller'></a>

`dispeller` [War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')

The caster of the dispel effect.

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int).isBeneficial'></a>

`isBeneficial` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Whether to dispel beneficial or detrimental buffs.

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int).dispelAmount'></a>

`dispelAmount` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The maximum number of buffs to dispel.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Dispel](WCSharp.Buffs.Dispel.md 'WCSharp.Buffs.Dispel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
All dispels.