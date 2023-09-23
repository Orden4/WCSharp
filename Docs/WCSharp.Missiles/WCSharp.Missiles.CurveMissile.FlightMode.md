#### [WCSharp.Missiles](index.md 'index')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles').[CurveMissile](WCSharp.Missiles.CurveMissile.md 'WCSharp.Missiles.CurveMissile')

## CurveMissile.FlightMode Enum

The flight modes of this missile type.

```csharp
public enum CurveMissile.FlightMode
```
### Fields

<a name='WCSharp.Missiles.CurveMissile.FlightMode.Default'></a>

`Default` 0

Default value prior to the missile being launched.  
  
Will change to [Direct](WCSharp.Missiles.CurveMissile.FlightMode.md#WCSharp.Missiles.CurveMissile.FlightMode.Direct 'WCSharp.Missiles.CurveMissile.FlightMode.Direct') if launched from a high altitude or with a non-zero [Arc](WCSharp.Missiles.CurveMissile.Arc.md 'WCSharp.Missiles.CurveMissile.Arc').

<a name='WCSharp.Missiles.CurveMissile.FlightMode.Direct'></a>

`Direct` 2

The missile will ignore the height of the terrain.

<a name='WCSharp.Missiles.CurveMissile.FlightMode.FollowTerrain'></a>

`FollowTerrain` 1

The missile will follow the height of the terrain.