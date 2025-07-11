#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[BuffSystem](WCSharp.Buffs.BuffSystem.md 'WCSharp\.Buffs\.BuffSystem')

## BuffSystem\.Dispel Method

| Overloads | |
| :--- | :--- |
| [Dispel\(unit, unit, bool, int\)](WCSharp.Buffs.BuffSystem.Dispel.md#WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int) 'WCSharp\.Buffs\.BuffSystem\.Dispel\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, bool, int\)') | Attempts to dispel buffs from the target\. Buff types are ignored\. |
| [Dispel\(unit, unit, bool, int, string\)](WCSharp.Buffs.BuffSystem.Dispel.md#WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string) 'WCSharp\.Buffs\.BuffSystem\.Dispel\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, bool, int, string\)') | Attempts to dispel buffs from the target with the given dispel type\. |
| [Dispel\(unit, unit, bool, int, string\[\]\)](WCSharp.Buffs.BuffSystem.Dispel.md#WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string[]) 'WCSharp\.Buffs\.BuffSystem\.Dispel\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, bool, int, string\[\]\)') | Attempts to dispel buffs with any of the given dispel types\. |
| [Dispel\(unit, unit, bool, int, List&lt;string&gt;, List&lt;string&gt;\)](WCSharp.Buffs.BuffSystem.Dispel.md#WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_) 'WCSharp\.Buffs\.BuffSystem\.Dispel\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, bool, int, System\.Collections\.Generic\.List\<string\>, System\.Collections\.Generic\.List\<string\>\)') | For more complex buff hierarchies\. Attempts to dispel buffs with any of the given dispel types, unless it has an excluded type\. |

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int)'></a>

## BuffSystem\.Dispel\(unit, unit, bool, int\) Method

Attempts to dispel buffs from the target\. Buff types are ignored\.

```csharp
public static System.Collections.Generic.List<WCSharp.Buffs.Dispel> Dispel(WCSharp.Api.unit target, WCSharp.Api.unit dispeller, bool isBeneficial, int dispelAmount);
```
#### Parameters

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The target to dispel from\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int).dispeller'></a>

`dispeller` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The caster of the dispel effect\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int).isBeneficial'></a>

`isBeneficial` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to dispel beneficial or detrimental buffs\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int).dispelAmount'></a>

`dispelAmount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of buffs to dispel\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Dispel](WCSharp.Buffs.Dispel.md 'WCSharp\.Buffs\.Dispel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
All dispels\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string)'></a>

## BuffSystem\.Dispel\(unit, unit, bool, int, string\) Method

Attempts to dispel buffs from the target with the given dispel type\.

```csharp
public static System.Collections.Generic.List<WCSharp.Buffs.Dispel> Dispel(WCSharp.Api.unit target, WCSharp.Api.unit dispeller, bool isBeneficial, int dispelAmount, string dispelType);
```
#### Parameters

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The target to dispel from\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string).dispeller'></a>

`dispeller` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The caster of the dispel effect\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string).isBeneficial'></a>

`isBeneficial` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to dispel beneficial or detrimental buffs\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string).dispelAmount'></a>

`dispelAmount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of buffs to dispel\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string).dispelType'></a>

`dispelType` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The type of buffs that can be dispelled\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Dispel](WCSharp.Buffs.Dispel.md 'WCSharp\.Buffs\.Dispel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
All dispels\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string[])'></a>

## BuffSystem\.Dispel\(unit, unit, bool, int, string\[\]\) Method

Attempts to dispel buffs with any of the given dispel types\.

```csharp
public static System.Collections.Generic.List<WCSharp.Buffs.Dispel> Dispel(WCSharp.Api.unit target, WCSharp.Api.unit dispeller, bool isBeneficial, int dispelAmount, params string[] dispelTypes);
```
#### Parameters

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string[]).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The target to dispel from\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string[]).dispeller'></a>

`dispeller` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The caster of the dispel effect\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string[]).isBeneficial'></a>

`isBeneficial` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to dispel beneficial or detrimental buffs\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string[]).dispelAmount'></a>

`dispelAmount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of buffs to dispel\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,string[]).dispelTypes'></a>

`dispelTypes` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The buff types that can be dispelled\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Dispel](WCSharp.Buffs.Dispel.md 'WCSharp\.Buffs\.Dispel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
All dispels\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_)'></a>

## BuffSystem\.Dispel\(unit, unit, bool, int, List\<string\>, List\<string\>\) Method

For more complex buff hierarchies\. Attempts to dispel buffs with any of the given dispel types, unless it has an excluded type\.

```csharp
public static System.Collections.Generic.List<WCSharp.Buffs.Dispel> Dispel(WCSharp.Api.unit target, WCSharp.Api.unit dispeller, bool isBeneficial, int dispelAmount, System.Collections.Generic.List<string> dispelTypes, System.Collections.Generic.List<string> exclusions);
```
#### Parameters

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The target to dispel from\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_).dispeller'></a>

`dispeller` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The caster of the dispel effect\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_).isBeneficial'></a>

`isBeneficial` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to dispel beneficial or detrimental buffs\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_).dispelAmount'></a>

`dispelAmount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of buffs to dispel\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_).dispelTypes'></a>

`dispelTypes` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The buff types that can be dispelled\.

<a name='WCSharp.Buffs.BuffSystem.Dispel(WCSharp.Api.unit,WCSharp.Api.unit,bool,int,System.Collections.Generic.List_string_,System.Collections.Generic.List_string_).exclusions'></a>

`exclusions` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

Will not dispel buffs with any of the given exclusion types\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Dispel](WCSharp.Buffs.Dispel.md 'WCSharp\.Buffs\.Dispel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
All dispels\.