#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp.Shared.Util')

## Util.IsAttackerBehindUnit(float, float, unit, float) Method

  
Determines whether the attacker is behind the attacked with the given tolerance in degrees.  
  
A tolerance of 360 would mean the target can be attacked from anywhere while being considered "behind".

```csharp
public static bool IsAttackerBehindUnit(float attackerX, float attackerY, War3Api.Common.unit attacked, float tolerance);
```
#### Parameters

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(float,float,War3Api.Common.unit,float).attackerX'></a>

`attackerX` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The X position of the attacker.

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(float,float,War3Api.Common.unit,float).attackerY'></a>

`attackerY` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The Y position of the attacker.

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(float,float,War3Api.Common.unit,float).attacked'></a>

`attacked` [War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')

The unit being attacked.

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(float,float,War3Api.Common.unit,float).tolerance'></a>

`tolerance` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

In degrees.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')