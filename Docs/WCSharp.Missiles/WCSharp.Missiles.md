## WCSharp.Missiles Namespace

| Classes | |
| :--- | :--- |
| [BasicMissile](WCSharp.Missiles.BasicMissile.md 'WCSharp.Missiles.BasicMissile') | Basic missile that will go from unit/location A to unit/location B.<br/><br/><br/>The main feature for this missile is that missiles can arc. |
| [CurveMissile](WCSharp.Missiles.CurveMissile.md 'WCSharp.Missiles.CurveMissile') | Advanced missile that allows for arcing/curving motions, i.e. a boomerang motion.<br/><br/><br/>If you do not use the [Curve](WCSharp.Missiles.CurveMissile.Curve.md 'WCSharp.Missiles.CurveMissile.Curve') property, you should use [BasicMissile](WCSharp.Missiles.BasicMissile.md 'WCSharp.Missiles.BasicMissile') instead for greater performance and<br/>            identical features. |
| [HomingMissile](WCSharp.Missiles.HomingMissile.md 'WCSharp.Missiles.HomingMissile') | Homing missile with a fixed speed that will attempt to aim itself at the target, restricted by turn speed.<br/><br/><br/>Note: Does not have any behaviour to avoid endlessly circling the enemy.<br/>            I recommend using it with a collision radius or such so that exact collisions aren't required. |
| [Missile](WCSharp.Missiles.Missile.md 'WCSharp.Missiles.Missile') | Fundamental missile class that provides the properties and methods that are shared by (virtually) all missiles.<br/><br/><br/>Unless you wish to define a new movement pattern for missiles, you should use one of the derived classes instead. |
| [MissileSystem](WCSharp.Missiles.MissileSystem.md 'WCSharp.Missiles.MissileSystem') | Tracks and runs all active [Missile](WCSharp.Missiles.Missile.md 'WCSharp.Missiles.Missile') instances. |
| [MomentumMissile](WCSharp.Missiles.MomentumMissile.md 'WCSharp.Missiles.MomentumMissile') | Homing-type missile that is based on momentum. Every tick, it will accelerate itself towards the target, up to a maximum speed.<br/><br/><br/>Note that the actual acceleration when adjusting its angle towards the target can be significantly less than specified.<br/><br/>It is recommended to use at least a little bit of [ImpactLeeway](WCSharp.Missiles.Missile.ImpactLeeway.md 'WCSharp.Missiles.Missile.ImpactLeeway') when using this missile. |
| [OrbitalMissile](WCSharp.Missiles.OrbitalMissile.md 'WCSharp.Missiles.OrbitalMissile') | Missile that will orbit the specified target.<br/><br/><br/>Note: this missile calls [OnImpact()](WCSharp.Missiles.Missile.OnImpact().md 'WCSharp.Missiles.Missile.OnImpact()') when the target dies. |

| Enums | |
| :--- | :--- |
| [BasicMissile.FlightMode](WCSharp.Missiles.BasicMissile.FlightMode.md 'WCSharp.Missiles.BasicMissile.FlightMode') | The flight modes of this missile type. |
| [CurveMissile.FlightMode](WCSharp.Missiles.CurveMissile.FlightMode.md 'WCSharp.Missiles.CurveMissile.FlightMode') | The flight modes of this missile type. |
| [HomingMissile.FlightMode](WCSharp.Missiles.HomingMissile.FlightMode.md 'WCSharp.Missiles.HomingMissile.FlightMode') | The flight modes of this missile type. |
| [MomentumMissile.FlightMode](WCSharp.Missiles.MomentumMissile.FlightMode.md 'WCSharp.Missiles.MomentumMissile.FlightMode') | The flight modes of this missile type. |
| [OrbitalMissile.FlightMode](WCSharp.Missiles.OrbitalMissile.FlightMode.md 'WCSharp.Missiles.OrbitalMissile.FlightMode') | The flight modes of this missile type. |
