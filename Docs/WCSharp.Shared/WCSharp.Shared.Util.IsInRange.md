#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared](WCSharp.Shared.md 'WCSharp\.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp\.Shared\.Util')

## Util\.IsInRange Method

| Overloads | |
| :--- | :--- |
| [IsInRange\(float, float, float, float, float\)](WCSharp.Shared.Util.IsInRange.md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float) 'WCSharp\.Shared\.Util\.IsInRange\(float, float, float, float, float\)') | Determines whether the distance from \([x1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).x1 'WCSharp\.Shared\.Util\.IsInRange\(float, float, float, float, float\)\.x1'), [y1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).y1 'WCSharp\.Shared\.Util\.IsInRange\(float, float, float, float, float\)\.y1')\) to \([x2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).x2 'WCSharp\.Shared\.Util\.IsInRange\(float, float, float, float, float\)\.x2'), [y2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).y2 'WCSharp\.Shared\.Util\.IsInRange\(float, float, float, float, float\)\.y2')\) is less than [range](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).range 'WCSharp\.Shared\.Util\.IsInRange\(float, float, float, float, float\)\.range')\.   Performance is a little better than DistanceBetweenPoints if you don't care about the exact distance. |
| [IsInRange\(float, float, unit, float\)](WCSharp.Shared.Util.IsInRange.md#WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float) 'WCSharp\.Shared\.Util\.IsInRange\(float, float, WCSharp\.Api\.unit, float\)') | Determines whether the distance from \([x1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float).x1 'WCSharp\.Shared\.Util\.IsInRange\(float, float, WCSharp\.Api\.unit, float\)\.x1'), [y1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float).y1 'WCSharp\.Shared\.Util\.IsInRange\(float, float, WCSharp\.Api\.unit, float\)\.y1')\) to [target](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float).target 'WCSharp\.Shared\.Util\.IsInRange\(float, float, WCSharp\.Api\.unit, float\)\.target') unit is less than [range](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float).range 'WCSharp\.Shared\.Util\.IsInRange\(float, float, WCSharp\.Api\.unit, float\)\.range')\.   Performance is a little better than DistanceBetweenPoints if you don't care about the exact distance. |
| [IsInRange\(unit, float, float, float\)](WCSharp.Shared.Util.IsInRange.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float) 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, float, float, float\)') | Determines whether the distance from [source](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).source 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, float, float, float\)\.source') unit to \([x2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).x2 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, float, float, float\)\.x2'), [y2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).y2 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, float, float, float\)\.y2')\) is less than [range](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).range 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, float, float, float\)\.range')\.   Performance is a little better than DistanceBetweenPoints if you don't care about the exact distance. |
| [IsInRange\(unit, unit, float\)](WCSharp.Shared.Util.IsInRange.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float) 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, float\)') | Determines whether the distance from [source](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).source 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, float\)\.source') unit to [target](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).target 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, float\)\.target') unit is less than [range](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).range 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, float\)\.range')\.   Performance is a little better than DistanceBetweenPoints if you don't care about the exact distance. |

<a name='WCSharp.Shared.Util.IsInRange(float,float,float,float,float)'></a>

## Util\.IsInRange\(float, float, float, float, float\) Method

Determines whether the distance from \([x1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).x1 'WCSharp\.Shared\.Util\.IsInRange\(float, float, float, float, float\)\.x1'), [y1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).y1 'WCSharp\.Shared\.Util\.IsInRange\(float, float, float, float, float\)\.y1')\) to \([x2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).x2 'WCSharp\.Shared\.Util\.IsInRange\(float, float, float, float, float\)\.x2'), [y2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).y2 'WCSharp\.Shared\.Util\.IsInRange\(float, float, float, float, float\)\.y2')\) is less than [range](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,float,float,float).range 'WCSharp\.Shared\.Util\.IsInRange\(float, float, float, float, float\)\.range')\.

Performance is a little better than DistanceBetweenPoints if you don't care about the exact distance.

```csharp
public static bool IsInRange(float x1, float y1, float x2, float y2, float range);
```
#### Parameters

<a name='WCSharp.Shared.Util.IsInRange(float,float,float,float,float).x1'></a>

`x1` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.IsInRange(float,float,float,float,float).y1'></a>

`y1` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.IsInRange(float,float,float,float,float).x2'></a>

`x2` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.IsInRange(float,float,float,float,float).y2'></a>

`y2` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.IsInRange(float,float,float,float,float).range'></a>

`range` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float)'></a>

## Util\.IsInRange\(float, float, unit, float\) Method

Determines whether the distance from \([x1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float).x1 'WCSharp\.Shared\.Util\.IsInRange\(float, float, WCSharp\.Api\.unit, float\)\.x1'), [y1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float).y1 'WCSharp\.Shared\.Util\.IsInRange\(float, float, WCSharp\.Api\.unit, float\)\.y1')\) to [target](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float).target 'WCSharp\.Shared\.Util\.IsInRange\(float, float, WCSharp\.Api\.unit, float\)\.target') unit is less than [range](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float).range 'WCSharp\.Shared\.Util\.IsInRange\(float, float, WCSharp\.Api\.unit, float\)\.range')\.

Performance is a little better than DistanceBetweenPoints if you don't care about the exact distance.

```csharp
public static bool IsInRange(float x1, float y1, WCSharp.Api.unit target, float range);
```
#### Parameters

<a name='WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float).x1'></a>

`x1` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float).y1'></a>

`y1` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Shared.Util.IsInRange(float,float,WCSharp.Api.unit,float).range'></a>

`range` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float)'></a>

## Util\.IsInRange\(unit, float, float, float\) Method

Determines whether the distance from [source](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).source 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, float, float, float\)\.source') unit to \([x2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).x2 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, float, float, float\)\.x2'), [y2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).y2 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, float, float, float\)\.y2')\) is less than [range](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).range 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, float, float, float\)\.range')\.

Performance is a little better than DistanceBetweenPoints if you don't care about the exact distance.

```csharp
public static bool IsInRange(WCSharp.Api.unit source, float x2, float y2, float range);
```
#### Parameters

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).source'></a>

`source` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).x2'></a>

`x2` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).y2'></a>

`y2` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,float,float,float).range'></a>

`range` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float)'></a>

## Util\.IsInRange\(unit, unit, float\) Method

Determines whether the distance from [source](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).source 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, float\)\.source') unit to [target](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).target 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, float\)\.target') unit is less than [range](WCSharp.Shared.Util.md#WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).range 'WCSharp\.Shared\.Util\.IsInRange\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, float\)\.range')\.

Performance is a little better than DistanceBetweenPoints if you don't care about the exact distance.

```csharp
public static bool IsInRange(WCSharp.Api.unit source, WCSharp.Api.unit target, float range);
```
#### Parameters

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).source'></a>

`source` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Shared.Util.IsInRange(WCSharp.Api.unit,WCSharp.Api.unit,float).range'></a>

`range` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')