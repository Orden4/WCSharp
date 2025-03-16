#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp.Shared.Util')

## Util.IsInRange(float, float, float, float, float) Method

Determines whether the distance from ([x1](WCSharp.Shared.Util.IsInRange(float,float,float,float,float).md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).x1 'WCSharp.Shared.Util.IsInRange(float, float, float, float, float).x1'), [y1](WCSharp.Shared.Util.IsInRange(float,float,float,float,float).md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).y1 'WCSharp.Shared.Util.IsInRange(float, float, float, float, float).y1')) to ([x2](WCSharp.Shared.Util.IsInRange(float,float,float,float,float).md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).x2 'WCSharp.Shared.Util.IsInRange(float, float, float, float, float).x2'), [y2](WCSharp.Shared.Util.IsInRange(float,float,float,float,float).md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).y2 'WCSharp.Shared.Util.IsInRange(float, float, float, float, float).y2')) is less than [range](WCSharp.Shared.Util.IsInRange(float,float,float,float,float).md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).range 'WCSharp.Shared.Util.IsInRange(float, float, float, float, float).range').  
  
Performance is a little better than DistanceBetweenPoints if you don't care about the exact distance.

```csharp
public static bool IsInRange(float x1, float y1, float x2, float y2, float range);
```
#### Parameters

<a name='WCSharp.Shared.Util.IsInRange(float,float,float,float,float).x1'></a>

`x1` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='WCSharp.Shared.Util.IsInRange(float,float,float,float,float).y1'></a>

`y1` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='WCSharp.Shared.Util.IsInRange(float,float,float,float,float).x2'></a>

`x2` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='WCSharp.Shared.Util.IsInRange(float,float,float,float,float).y2'></a>

`y2` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='WCSharp.Shared.Util.IsInRange(float,float,float,float,float).range'></a>

`range` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')