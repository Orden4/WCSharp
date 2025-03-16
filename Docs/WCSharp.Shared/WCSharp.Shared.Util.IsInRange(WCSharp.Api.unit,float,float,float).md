#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp.Shared.Util')

## Util.IsInRange(unit, float, float, float) Method

Determines whether the distance from [source](WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).source 'WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit, float, float, float).source') unit to ([x2](WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).x2 'WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit, float, float, float).x2'), [y2](WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).y2 'WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit, float, float, float).y2')) is less than [range](WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).range 'WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit, float, float, float).range').  
  
Performance is a little better than DistanceBetweenPoints if you don't care about the exact distance.

```csharp
public static bool IsInRange(WCSharp.Api.unit source, float x2, float y2, float range);
```
#### Parameters

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).source'></a>

`source` [WCSharp.Api.unit](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.unit 'WCSharp.Api.unit')

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).x2'></a>

`x2` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).y2'></a>

`y2` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).range'></a>

`range` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')