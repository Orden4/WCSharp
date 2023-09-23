#### [WCSharp.Missiles](index.md 'index')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles').[OrbitalMissile](WCSharp.Missiles.OrbitalMissile.md 'WCSharp.Missiles.OrbitalMissile')

## OrbitalMissile.FlightMode Enum

The flight modes of this missile type.

```csharp
public enum OrbitalMissile.FlightMode
```
### Fields

<a name='WCSharp.Missiles.OrbitalMissile.FlightMode.BestFit'></a>

`BestFit` 3

Essentially [TargetBased](WCSharp.Missiles.OrbitalMissile.FlightMode.md#WCSharp.Missiles.OrbitalMissile.FlightMode.TargetBased 'WCSharp.Missiles.OrbitalMissile.FlightMode.TargetBased') but with extra logic to avoid clipping into terrain.

<a name='WCSharp.Missiles.OrbitalMissile.FlightMode.Default'></a>

`Default` 0

Default value prior to the missile being launched.  
  
Will automatically change to [BestFit](WCSharp.Missiles.OrbitalMissile.FlightMode.md#WCSharp.Missiles.OrbitalMissile.FlightMode.BestFit 'WCSharp.Missiles.OrbitalMissile.FlightMode.BestFit').

<a name='WCSharp.Missiles.OrbitalMissile.FlightMode.MissileBased'></a>

`MissileBased` 1

The missile will use the terrain height at the position of the missile itself.

<a name='WCSharp.Missiles.OrbitalMissile.FlightMode.None'></a>

`None` 4

The height of the missile will never be adjusted.

<a name='WCSharp.Missiles.OrbitalMissile.FlightMode.TargetBased'></a>

`TargetBased` 2

The missile will use the terrain height at the position of the target that it is orbiting.  
  
This can result in the missile clipping through terrain, you can use [BestFit](WCSharp.Missiles.OrbitalMissile.FlightMode.md#WCSharp.Missiles.OrbitalMissile.FlightMode.BestFit 'WCSharp.Missiles.OrbitalMissile.FlightMode.BestFit') to avoid this.