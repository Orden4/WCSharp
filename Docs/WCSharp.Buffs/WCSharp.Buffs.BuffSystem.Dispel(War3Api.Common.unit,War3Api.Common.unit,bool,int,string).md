### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[BuffSystem](WCSharp.Buffs.BuffSystem.md 'WCSharp.Buffs.BuffSystem')

## BuffSystem.Dispel(unit, unit, bool, int, string) Method

Attempts to dispel buffs from the target with the given dispel type.

```csharp
public static System.Collections.Generic.List<WCSharp.Buffs.Dispel> Dispel(War3Api.Common.unit target, War3Api.Common.unit dispeller, bool isBeneficial, int dispelAmount, string dispelType);
```
#### Parameters

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int,string).target'></a>

`target` [War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')

The target to dispel from.

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int,string).dispeller'></a>

`dispeller` [War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')

The caster of the dispel effect.

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int,string).isBeneficial'></a>

`isBeneficial` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Whether to dispel beneficial or detrimental buffs.

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int,string).dispelAmount'></a>

`dispelAmount` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The maximum number of buffs to dispel.

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int,string).dispelType'></a>

`dispelType` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The type of buffs that can be dispelled.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Dispel](WCSharp.Buffs.Dispel.md 'WCSharp.Buffs.Dispel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
All dispels.