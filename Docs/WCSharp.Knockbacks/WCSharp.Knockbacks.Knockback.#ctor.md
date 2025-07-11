#### [WCSharp\.Knockbacks](README.md 'README')
### [WCSharp\.Knockbacks](WCSharp.Knockbacks.md 'WCSharp\.Knockbacks').[Knockback](WCSharp.Knockbacks.Knockback.md 'WCSharp\.Knockbacks\.Knockback')

## Knockback Constructors

| Overloads | |
| :--- | :--- |
| [Knockback\(unit, float, float, float\)](WCSharp.Knockbacks.Knockback.#ctor.md#WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float) 'WCSharp\.Knockbacks\.Knockback\.Knockback\(WCSharp\.Api\.unit, float, float, float\)') | Knocks the target the given distance towards the given angle \(in degrees\) over the given duration\. |
| [Knockback\(unit, float, float, float, float\)](WCSharp.Knockbacks.Knockback.#ctor.md#WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float,float) 'WCSharp\.Knockbacks\.Knockback\.Knockback\(WCSharp\.Api\.unit, float, float, float, float\)') | Knocks the target the given distance towards the given location over the given duration\. |

<a name='ctor.md#WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float)'></a>

## Knockback\(unit, float, float, float\) Constructor

Knocks the target the given distance towards the given angle \(in degrees\) over the given duration\.

```csharp
public Knockback(WCSharp.Api.unit target, float distance, float duration, float angle);
```
#### Parameters

<a name='WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The target to perform the knockback on

<a name='WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float).distance'></a>

`distance` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The distance in units to knock the target back

<a name='WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float).duration'></a>

`duration` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The duration in seconds over which the target should be knocked back

<a name='WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float).angle'></a>

`angle` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

In degrees\.

<a name='ctor.md#WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float,float)'></a>

## Knockback\(unit, float, float, float, float\) Constructor

Knocks the target the given distance towards the given location over the given duration\.

```csharp
public Knockback(WCSharp.Api.unit target, float distance, float duration, float targetX, float targetY);
```
#### Parameters

<a name='WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float,float).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float,float).distance'></a>

`distance` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float,float).duration'></a>

`duration` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float,float).targetX'></a>

`targetX` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float,float).targetY'></a>

`targetY` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')