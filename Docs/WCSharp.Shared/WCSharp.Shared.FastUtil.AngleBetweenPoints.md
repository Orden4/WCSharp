#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared](WCSharp.Shared.md 'WCSharp\.Shared').[FastUtil](WCSharp.Shared.FastUtil.md 'WCSharp\.Shared\.FastUtil')

## FastUtil\.AngleBetweenPoints Method

| Overloads | |
| :--- | :--- |
| [AngleBetweenPoints\(float, float, unit\)](WCSharp.Shared.FastUtil.AngleBetweenPoints.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(float,float,WCSharp.Api.unit) 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)') | Calculates the angle in degrees from \([x1](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(float,float,WCSharp.Api.unit).x1 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.x1'), [y1](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(float,float,WCSharp.Api.unit).y1 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.y1')\) to [target](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(float,float,WCSharp.Api.unit).target 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.target') unit\.   [target](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(float,float,WCSharp.Api.unit).target 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.target') must be pre-calculated. |
| [AngleBetweenPoints\(unit, float, float\)](WCSharp.Shared.FastUtil.AngleBetweenPoints.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,float,float) 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)') | Calculates the angle in degrees from [source](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,float,float).source 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.source') unit to \([x2](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,float,float).x2 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.x2'), [y2](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,float,float).y2 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.y2')\)\.   [source](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,float,float).source 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.source') must be pre-calculated. |
| [AngleBetweenPoints\(unit, unit\)](WCSharp.Shared.FastUtil.AngleBetweenPoints.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit) 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)') | Calculates the angle in degrees from [source](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit).source 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.source') unit to [target](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit).target 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.target') unit\.   All parameters must be pre-calculated. |

<a name='WCSharp.Shared.FastUtil.AngleBetweenPoints(float,float,WCSharp.Api.unit)'></a>

## FastUtil\.AngleBetweenPoints\(float, float, unit\) Method

Calculates the angle in degrees from \([x1](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(float,float,WCSharp.Api.unit).x1 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.x1'), [y1](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(float,float,WCSharp.Api.unit).y1 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.y1')\) to [target](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(float,float,WCSharp.Api.unit).target 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.target') unit\.

[target](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(float,float,WCSharp.Api.unit).target 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.target') must be pre-calculated.

```csharp
public static float AngleBetweenPoints(float x1, float y1, WCSharp.Api.unit target);
```
#### Parameters

<a name='WCSharp.Shared.FastUtil.AngleBetweenPoints(float,float,WCSharp.Api.unit).x1'></a>

`x1` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPoints(float,float,WCSharp.Api.unit).y1'></a>

`y1` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPoints(float,float,WCSharp.Api.unit).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,float,float)'></a>

## FastUtil\.AngleBetweenPoints\(unit, float, float\) Method

Calculates the angle in degrees from [source](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,float,float).source 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.source') unit to \([x2](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,float,float).x2 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.x2'), [y2](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,float,float).y2 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.y2')\)\.

[source](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,float,float).source 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.source') must be pre-calculated.

```csharp
public static float AngleBetweenPoints(WCSharp.Api.unit source, float x2, float y2);
```
#### Parameters

<a name='WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,float,float).source'></a>

`source` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,float,float).x2'></a>

`x2` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,float,float).y2'></a>

`y2` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit)'></a>

## FastUtil\.AngleBetweenPoints\(unit, unit\) Method

Calculates the angle in degrees from [source](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit).source 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.source') unit to [target](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit).target 'WCSharp\.Shared\.FastUtil\.AngleBetweenPoints\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.target') unit\.

All parameters must be pre-calculated.

```csharp
public static float AngleBetweenPoints(WCSharp.Api.unit source, WCSharp.Api.unit target);
```
#### Parameters

<a name='WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit).source'></a>

`source` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')