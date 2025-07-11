#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared](WCSharp.Shared.md 'WCSharp\.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp\.Shared\.Util')

## Util\.AngleBetweenPoints Method

| Overloads | |
| :--- | :--- |
| [AngleBetweenPoints\(float, float, float, float\)](WCSharp.Shared.Util.AngleBetweenPoints.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float) 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, float, float\)') | Calculates the angle in degrees from \([x1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float).x1 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, float, float\)\.x1'), [y1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float).y1 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, float, float\)\.y1')\) to \([x2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float).x2 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, float, float\)\.x2'), [y2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float).y2 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, float, float\)\.y2')\)\. |
| [AngleBetweenPoints\(float, float, unit\)](WCSharp.Shared.Util.AngleBetweenPoints.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,WCSharp.Api.unit) 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)') | Calculates the angle in degrees from \([x1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,WCSharp.Api.unit).x1 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.x1'), [y1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,WCSharp.Api.unit).y1 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.y1')\) to [target](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,WCSharp.Api.unit).target 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.target') unit\. |
| [AngleBetweenPoints\(unit, float, float\)](WCSharp.Shared.Util.AngleBetweenPoints.md#WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,float,float) 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)') | Calculates the angle in degrees from [source](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,float,float).source 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.source') unit to \([x2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,float,float).x2 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.x2'), [y2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,float,float).y2 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.y2')\)\. |
| [AngleBetweenPoints\(unit, unit\)](WCSharp.Shared.Util.AngleBetweenPoints.md#WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit) 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)') | Calculates the angle in degrees from [source](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit).source 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.source') unit to [target](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit).target 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.target') unit\. |

<a name='WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float)'></a>

## Util\.AngleBetweenPoints\(float, float, float, float\) Method

Calculates the angle in degrees from \([x1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float).x1 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, float, float\)\.x1'), [y1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float).y1 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, float, float\)\.y1')\) to \([x2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float).x2 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, float, float\)\.x2'), [y2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float).y2 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, float, float\)\.y2')\)\.

```csharp
public static float AngleBetweenPoints(float x1, float y1, float x2, float y2);
```
#### Parameters

<a name='WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float).x1'></a>

`x1` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float).y1'></a>

`y1` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float).x2'></a>

`x2` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.AngleBetweenPoints(float,float,float,float).y2'></a>

`y2` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.AngleBetweenPoints(float,float,WCSharp.Api.unit)'></a>

## Util\.AngleBetweenPoints\(float, float, unit\) Method

Calculates the angle in degrees from \([x1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,WCSharp.Api.unit).x1 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.x1'), [y1](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,WCSharp.Api.unit).y1 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.y1')\) to [target](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(float,float,WCSharp.Api.unit).target 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(float, float, WCSharp\.Api\.unit\)\.target') unit\.

```csharp
public static float AngleBetweenPoints(float x1, float y1, WCSharp.Api.unit target);
```
#### Parameters

<a name='WCSharp.Shared.Util.AngleBetweenPoints(float,float,WCSharp.Api.unit).x1'></a>

`x1` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.AngleBetweenPoints(float,float,WCSharp.Api.unit).y1'></a>

`y1` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.AngleBetweenPoints(float,float,WCSharp.Api.unit).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,float,float)'></a>

## Util\.AngleBetweenPoints\(unit, float, float\) Method

Calculates the angle in degrees from [source](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,float,float).source 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.source') unit to \([x2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,float,float).x2 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.x2'), [y2](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,float,float).y2 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(WCSharp\.Api\.unit, float, float\)\.y2')\)\.

```csharp
public static float AngleBetweenPoints(WCSharp.Api.unit source, float x2, float y2);
```
#### Parameters

<a name='WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,float,float).source'></a>

`source` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,float,float).x2'></a>

`x2` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,float,float).y2'></a>

`y2` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit)'></a>

## Util\.AngleBetweenPoints\(unit, unit\) Method

Calculates the angle in degrees from [source](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit).source 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.source') unit to [target](WCSharp.Shared.Util.md#WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit).target 'WCSharp\.Shared\.Util\.AngleBetweenPoints\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.target') unit\.

```csharp
public static float AngleBetweenPoints(WCSharp.Api.unit source, WCSharp.Api.unit target);
```
#### Parameters

<a name='WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit).source'></a>

`source` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Shared.Util.AngleBetweenPoints(WCSharp.Api.unit,WCSharp.Api.unit).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')