#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp.Shared.Util')

## Util.IsInRange(unit, unit, float) Method

Determines whether the distance from [source](WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).source 'WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit, WCSharp.Api.unit, float).source') unit to [target](WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).target 'WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit, WCSharp.Api.unit, float).target') unit is less than [range](WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).range 'WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit, WCSharp.Api.unit, float).range').  
  
Performance is a little better than DistanceBetweenPoints if you don't care about the exact distance.

```csharp
public static bool IsInRange(WCSharp.Api.unit source, WCSharp.Api.unit target, float range);
```
#### Parameters

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).source'></a>

`source` [WCSharp.Api.unit](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.unit 'WCSharp.Api.unit')

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).target'></a>

`target` [WCSharp.Api.unit](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.unit 'WCSharp.Api.unit')

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).range'></a>

`range` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')