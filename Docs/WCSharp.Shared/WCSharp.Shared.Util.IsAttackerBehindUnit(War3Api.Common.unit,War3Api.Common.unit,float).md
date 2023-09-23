#### [WCSharp.Shared](index.md 'index')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp.Shared.Util')

## Util.IsAttackerBehindUnit(unit, unit, float) Method

  
Determines whether the attacker is behind the attacked with the given tolerance in degrees.  
  
A tolerance of 360 would mean the target can be attacked from anywhere while being considered "behind".

```csharp
public static bool IsAttackerBehindUnit(War3Api.Common.unit attacker, War3Api.Common.unit attacked, float tolerance);
```
#### Parameters

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(War3Api.Common.unit,War3Api.Common.unit,float).attacker'></a>

`attacker` [War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')

The unit performing the attack.

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(War3Api.Common.unit,War3Api.Common.unit,float).attacked'></a>

`attacked` [War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')

The unit being attacked.

<a name='WCSharp.Shared.Util.IsAttackerBehindUnit(War3Api.Common.unit,War3Api.Common.unit,float).tolerance'></a>

`tolerance` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

In degrees.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')