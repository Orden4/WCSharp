### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[BuffSystem](WCSharp.Buffs.BuffSystem.md 'WCSharp.Buffs.BuffSystem')

## BuffSystem.Dispel(unit, unit, bool, int, List<string>, List<string>) Method

For more complex buff hierarchies. Attempts to dispel buffs with any of the given dispel types, unless it has an excluded type.

```csharp
public static System.Collections.Generic.List<WCSharp.Buffs.Dispel> Dispel(War3Api.Common.unit target, War3Api.Common.unit dispeller, bool isBeneficial, int dispelAmount, System.Collections.Generic.List<string> dispelTypes, System.Collections.Generic.List<string> exclusions);
```
#### Parameters

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_).target'></a>

`target` [War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')

The target to dispel from.

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_).dispeller'></a>

`dispeller` [War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')

The caster of the dispel effect.

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_).isBeneficial'></a>

`isBeneficial` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Whether to dispel beneficial or detrimental buffs.

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_).dispelAmount'></a>

`dispelAmount` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The maximum number of buffs to dispel.

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_).dispelTypes'></a>

`dispelTypes` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

The buff types that can be dispelled.

<a name='WCSharp.Buffs.BuffSystem.Dispel(War3Api.Common.unit,War3Api.Common.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_).exclusions'></a>

`exclusions` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

Will not dispel buffs with any of the given exclusion types.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Dispel](WCSharp.Buffs.Dispel.md 'WCSharp.Buffs.Dispel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
All dispels.