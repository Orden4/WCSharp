#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[BasicMissile](WCSharp.Missiles.BasicMissile.md 'WCSharp\.Missiles\.BasicMissile')

## BasicMissile\.FlightMode Enum

The flight modes of this missile type\.

```csharp
public enum BasicMissile.FlightMode
```
### Fields

<a name='WCSharp.Missiles.BasicMissile.FlightMode.Default'></a>

`Default` 0

Default value prior to the missile being launched\.

Will change to [Direct](WCSharp.Missiles.BasicMissile.FlightMode.md#WCSharp.Missiles.BasicMissile.FlightMode.Direct 'WCSharp\.Missiles\.BasicMissile\.FlightMode\.Direct') if launched from a high altitude or with a non-zero [Arc](WCSharp.Missiles.BasicMissile.Arc.md 'WCSharp\.Missiles\.BasicMissile\.Arc').

<a name='WCSharp.Missiles.BasicMissile.FlightMode.FollowTerrain'></a>

`FollowTerrain` 1

The missile will follow the height of the terrain\.

<a name='WCSharp.Missiles.BasicMissile.FlightMode.Direct'></a>

`Direct` 2

The missile will ignore the height of the terrain\.