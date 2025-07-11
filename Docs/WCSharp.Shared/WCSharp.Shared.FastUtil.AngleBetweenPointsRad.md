#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared](WCSharp.Shared.md 'WCSharp\.Shared').[FastUtil](WCSharp.Shared.FastUtil.md 'WCSharp\.Shared\.FastUtil')

## FastUtil\.AngleBetweenPointsRad Method

| Overloads | |
| :--- | :--- |
| [AngleBetweenPointsRad\(float, float, unit\)](WCSharp.Shared.FastUtil.AngleBetweenPointsRad.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(float,float,WCSharp.Api.unit) 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(float, float, WCSharp\.Api\.unit\)') | Calculates the angle in radians from \([x1](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(float,float,WCSharp.Api.unit).x1 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(float, float, WCSharp\.Api\.unit\)\.x1'), [y1](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(float,float,WCSharp.Api.unit).y1 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(float, float, WCSharp\.Api\.unit\)\.y1')\) to [target](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(float,float,WCSharp.Api.unit).target 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(float, float, WCSharp\.Api\.unit\)\.target') unit\.   [target](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(float,float,WCSharp.Api.unit).target 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(float, float, WCSharp\.Api\.unit\)\.target') must be pre-calculated. |
| [AngleBetweenPointsRad\(unit, float, float\)](WCSharp.Shared.FastUtil.AngleBetweenPointsRad.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,float,float) 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, float, float\)') | Calculates the angle in radians from [source](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,float,float).source 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, float, float\)\.source') unit to \([x2](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,float,float).x2 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, float, float\)\.x2'), [y2](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,float,float).y2 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, float, float\)\.y2')\)\.   [source](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,float,float).source 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, float, float\)\.source') must be pre-calculated. |
| [AngleBetweenPointsRad\(unit, unit\)](WCSharp.Shared.FastUtil.AngleBetweenPointsRad.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,WCSharp.Api.unit) 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)') | Calculates the angle in radians from [source](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,WCSharp.Api.unit).source 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.source') unit to [target](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,WCSharp.Api.unit).target 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.target') unit\.   All parameters must be pre-calculated. |

<a name='WCSharp.Shared.FastUtil.AngleBetweenPointsRad(float,float,WCSharp.Api.unit)'></a>

## FastUtil\.AngleBetweenPointsRad\(float, float, unit\) Method

Calculates the angle in radians from \([x1](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(float,float,WCSharp.Api.unit).x1 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(float, float, WCSharp\.Api\.unit\)\.x1'), [y1](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(float,float,WCSharp.Api.unit).y1 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(float, float, WCSharp\.Api\.unit\)\.y1')\) to [target](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(float,float,WCSharp.Api.unit).target 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(float, float, WCSharp\.Api\.unit\)\.target') unit\.

[target](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(float,float,WCSharp.Api.unit).target 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(float, float, WCSharp\.Api\.unit\)\.target') must be pre-calculated.

```csharp
public static float AngleBetweenPointsRad(float x1, float y1, WCSharp.Api.unit target);
```
#### Parameters

<a name='WCSharp.Shared.FastUtil.AngleBetweenPointsRad(float,float,WCSharp.Api.unit).x1'></a>

`x1` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPointsRad(float,float,WCSharp.Api.unit).y1'></a>

`y1` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPointsRad(float,float,WCSharp.Api.unit).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,float,float)'></a>

## FastUtil\.AngleBetweenPointsRad\(unit, float, float\) Method

Calculates the angle in radians from [source](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,float,float).source 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, float, float\)\.source') unit to \([x2](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,float,float).x2 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, float, float\)\.x2'), [y2](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,float,float).y2 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, float, float\)\.y2')\)\.

[source](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,float,float).source 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, float, float\)\.source') must be pre-calculated.

```csharp
public static float AngleBetweenPointsRad(WCSharp.Api.unit source, float x2, float y2);
```
#### Parameters

<a name='WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,float,float).source'></a>

`source` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,float,float).x2'></a>

`x2` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,float,float).y2'></a>

`y2` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,WCSharp.Api.unit)'></a>

## FastUtil\.AngleBetweenPointsRad\(unit, unit\) Method

Calculates the angle in radians from [source](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,WCSharp.Api.unit).source 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.source') unit to [target](WCSharp.Shared.FastUtil.md#WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,WCSharp.Api.unit).target 'WCSharp\.Shared\.FastUtil\.AngleBetweenPointsRad\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.target') unit\.

All parameters must be pre-calculated.

```csharp
public static float AngleBetweenPointsRad(WCSharp.Api.unit source, WCSharp.Api.unit target);
```
#### Parameters

<a name='WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,WCSharp.Api.unit).source'></a>

`source` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Shared.FastUtil.AngleBetweenPointsRad(WCSharp.Api.unit,WCSharp.Api.unit).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')