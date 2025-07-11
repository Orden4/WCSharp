#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared](WCSharp.Shared.md 'WCSharp\.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp\.Shared\.Util')

## Util\.IsAttackerInfrontUnit\(unit, unit, float\) Method


Determines whether the attacker is in front of the attacked with the given tolerance in degrees.

A tolerance of 360 means the target can be attacked from anywhere while being considered "infront".

```csharp
public static bool IsAttackerInfrontUnit(WCSharp.Api.unit attacker, WCSharp.Api.unit attacked, float tolerance);
```
#### Parameters

<a name='WCSharp.Shared.Util.IsAttackerInfrontUnit(WCSharp.Api.unit,WCSharp.Api.unit,float).attacker'></a>

`attacker` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The unit performing the attack\.

<a name='WCSharp.Shared.Util.IsAttackerInfrontUnit(WCSharp.Api.unit,WCSharp.Api.unit,float).attacked'></a>

`attacked` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The unit being attacked\.

<a name='WCSharp.Shared.Util.IsAttackerInfrontUnit(WCSharp.Api.unit,WCSharp.Api.unit,float).tolerance'></a>

`tolerance` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

In degrees\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')