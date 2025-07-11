#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[MomentumMissile](WCSharp.Missiles.MomentumMissile.md 'WCSharp\.Missiles\.MomentumMissile')

## MomentumMissile\.FlightMode Enum

The flight modes of this missile type\.

```csharp
public enum MomentumMissile.FlightMode
```
### Fields

<a name='WCSharp.Missiles.MomentumMissile.FlightMode.Default'></a>

`Default` 0

Default value prior to the missile being launched\.

Will automatically change to [FollowTerrain](WCSharp.Missiles.MomentumMissile.FlightMode.md#WCSharp.Missiles.MomentumMissile.FlightMode.FollowTerrain 'WCSharp\.Missiles\.MomentumMissile\.FlightMode\.FollowTerrain').

<a name='WCSharp.Missiles.MomentumMissile.FlightMode.FollowTerrain'></a>

`FollowTerrain` 1

The missile will follow the height of the terrain\.

<a name='WCSharp.Missiles.MomentumMissile.FlightMode.Direct'></a>

`Direct` 2

The missile will ignore the height of the terrain\.