#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared](WCSharp.Shared.md 'WCSharp\.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp\.Shared\.Util')

## Util\.IsAttackerBehindUnit Method

| Overloads | |
| :--- | :--- |
| [IsAttackerBehindUnit\(float, float, unit, float\)](WCSharp.Shared.Util.IsAttackerBehindUnit.md#WCSharp.Shared.Util.IsAttackerBehindUnit(float,float,WCSharp.Api.unit,float) 'WCSharp\.Shared\.Util\.IsAttackerBehindUnit\(float, float, WCSharp\.Api\.unit, float\)') |   Determines whether the attacker is behind the attacked with the given tolerance in degrees.  A tolerance of 360 would mean the target can be attacked from anywhere while being considered "behind". |
| [IsAttackerBehindUnit\(float, unit, float\)](WCSharp.Shared.Util.IsAttackerBehindUnit.md#WCSharp.Shared.Util.IsAttackerBehindUnit(float,WCSharp.Api.unit,float) 'WCSharp\.Shared\.Util\.IsAttackerBehindUnit\(float, WCSharp\.Api\.unit, float\)') |   Determines whether the attacker is behind the attacked with the given tolerance in degrees.  A tolerance of 360 would mean the target can be attacked from anywhere while being considered "behind". |
| [IsAttackerBehindUnit\(unit, unit, float\)](WCSharp.Shared.Util.IsAttackerBehindUnit.md#WCSharp.Shared.Util.IsAttackerBehindUnit(WCSharp.Api.unit,WCSharp.Api.unit,float) 'WCSharp\.Shared\.Util\.IsAttackerBehindUnit\(WCSharp\.Api\.unit, WCSharp\.Api\.unit, float\)') |   Determines whether the attacker is behind the attacked with the given tolerance in degrees.  A tolerance of 360 would mean the target can be attacked from anywhere while being considered "behind". |

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(float,float,WCSharp.Api.unit,float)'></a>

## Util\.IsAttackerBehindUnit\(float, float, unit, float\) Method


Determines whether the attacker is behind the attacked with the given tolerance in degrees.

A tolerance of 360 would mean the target can be attacked from anywhere while being considered "behind".

```csharp
public static bool IsAttackerBehindUnit(float attackerX, float attackerY, WCSharp.Api.unit attacked, float tolerance);
```
#### Parameters

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(float,float,WCSharp.Api.unit,float).attackerX'></a>

`attackerX` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The X position of the attacker\.

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(float,float,WCSharp.Api.unit,float).attackerY'></a>

`attackerY` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The Y position of the attacker\.

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(float,float,WCSharp.Api.unit,float).attacked'></a>

`attacked` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The unit being attacked\.

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(float,float,WCSharp.Api.unit,float).tolerance'></a>

`tolerance` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

In degrees\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(float,WCSharp.Api.unit,float)'></a>

## Util\.IsAttackerBehindUnit\(float, unit, float\) Method


Determines whether the attacker is behind the attacked with the given tolerance in degrees.

A tolerance of 360 would mean the target can be attacked from anywhere while being considered "behind".

```csharp
public static bool IsAttackerBehindUnit(float attackerAngle, WCSharp.Api.unit attacked, float tolerance);
```
#### Parameters

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(float,WCSharp.Api.unit,float).attackerAngle'></a>

`attackerAngle` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The angle of the attacker\.

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(float,WCSharp.Api.unit,float).attacked'></a>

`attacked` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The unit being attacked\.

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(float,WCSharp.Api.unit,float).tolerance'></a>

`tolerance` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

In degrees\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(WCSharp.Api.unit,WCSharp.Api.unit,float)'></a>

## Util\.IsAttackerBehindUnit\(unit, unit, float\) Method


Determines whether the attacker is behind the attacked with the given tolerance in degrees.

A tolerance of 360 would mean the target can be attacked from anywhere while being considered "behind".

```csharp
public static bool IsAttackerBehindUnit(WCSharp.Api.unit attacker, WCSharp.Api.unit attacked, float tolerance);
```
#### Parameters

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(WCSharp.Api.unit,WCSharp.Api.unit,float).attacker'></a>

`attacker` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The unit performing the attack\.

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(WCSharp.Api.unit,WCSharp.Api.unit,float).attacked'></a>

`attacked` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The unit being attacked\.

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(WCSharp.Api.unit,WCSharp.Api.unit,float).tolerance'></a>

`tolerance` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

In degrees\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')