#### [WCSharp.Missiles](README.md 'README')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles').[HomingMissile](WCSharp.Missiles.HomingMissile.md 'WCSharp.Missiles.HomingMissile')

## HomingMissile.FlightMode Enum

The flight modes of this missile type.

```csharp
public enum HomingMissile.FlightMode
```
### Fields

<a name='WCSharp.Missiles.HomingMissile.FlightMode.Default'></a>

`Default` 0

Default value prior to the missile being launched.  
  
Will automatically change to [FollowTerrain](WCSharp.Missiles.HomingMissile.FlightMode.md#WCSharp.Missiles.HomingMissile.FlightMode.FollowTerrain 'WCSharp.Missiles.HomingMissile.FlightMode.FollowTerrain').

<a name='WCSharp.Missiles.HomingMissile.FlightMode.Direct'></a>

`Direct` 2

The missile will ignore the height of the terrain.

<a name='WCSharp.Missiles.HomingMissile.FlightMode.FollowTerrain'></a>

`FollowTerrain` 1

The missile will follow the height of the terrain.