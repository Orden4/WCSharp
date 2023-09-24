#### [WCSharp.Missiles](README.md 'README')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles')

## OrbitalMissile Class

Missile that will orbit the specified target.  
  
Note: this missile calls [OnImpact()](WCSharp.Missiles.Missile.OnImpact().md 'WCSharp.Missiles.Missile.OnImpact()') when the target dies.

```csharp
public abstract class OrbitalMissile : WCSharp.Missiles.Missile
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Missile](WCSharp.Missiles.Missile.md 'WCSharp.Missiles.Missile') &#129106; OrbitalMissile

| Properties | |
| :--- | :--- |
| [CasterZ](WCSharp.Missiles.OrbitalMissile.CasterZ.md 'WCSharp.Missiles.OrbitalMissile.CasterZ') | The Z coordinate from which the missile was fired.<br/><br/><br/>By default, this is equal to UnitFlyHeight + [CasterLaunchZ](WCSharp.Missiles.Missile.CasterLaunchZ.md 'WCSharp.Missiles.Missile.CasterLaunchZ') + GetLocationZ. |
| [MissileZ](WCSharp.Missiles.OrbitalMissile.MissileZ.md 'WCSharp.Missiles.OrbitalMissile.MissileZ') | The current Z position of the missile.<br/><br/><br/>Depending on the type of missile, MissileZ sets may be ignored. |
| [Mode](WCSharp.Missiles.OrbitalMissile.Mode.md 'WCSharp.Missiles.OrbitalMissile.Mode') | The current flight mode of the projectile.<br/><br/><br/>Automatically set at launch unless changed to a value other than [Default](WCSharp.Missiles.OrbitalMissile.FlightMode.md#WCSharp.Missiles.OrbitalMissile.FlightMode.Default 'WCSharp.Missiles.OrbitalMissile.FlightMode.Default'). |
| [OrbitalAngle](WCSharp.Missiles.OrbitalMissile.OrbitalAngle.md 'WCSharp.Missiles.OrbitalMissile.OrbitalAngle') | The current angle from the target of the orbit to the missile, expressed in degrees.<br/><br/><br/>Automatically set to a random angle. |
| [OrbitalAngleRad](WCSharp.Missiles.OrbitalMissile.OrbitalAngleRad.md 'WCSharp.Missiles.OrbitalMissile.OrbitalAngleRad') | The current angle from the target of the orbit to the missile, expressed in radians.<br/><br/><br/>Ranges between 0 (inclusive) and 2pi (exclusive).<br/><br/>Automatically set to a random angle. |
| [OrbitalPeriod](WCSharp.Missiles.OrbitalMissile.OrbitalPeriod.md 'WCSharp.Missiles.OrbitalMissile.OrbitalPeriod') | The amount of time it takes to make one rotation in seconds.<br/><br/><br/>Use negative values to go clockwise.<br/><br/>This can be used instead of [Speed](WCSharp.Missiles.OrbitalMissile.Speed.md 'WCSharp.Missiles.OrbitalMissile.Speed'), and will ensure a consistent orbital period through [Range](WCSharp.Missiles.OrbitalMissile.Range.md 'WCSharp.Missiles.OrbitalMissile.Range') adjustments. |
| [OrbitalVelocityRad](WCSharp.Missiles.OrbitalMissile.OrbitalVelocityRad.md 'WCSharp.Missiles.OrbitalMissile.OrbitalVelocityRad') | The speed at which the missile is orbiting, expressed in radians per [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') tick (0.03125). |
| [Range](WCSharp.Missiles.OrbitalMissile.Range.md 'WCSharp.Missiles.OrbitalMissile.Range') | The distance at which the [OrbitalMissile](WCSharp.Missiles.OrbitalMissile.md 'WCSharp.Missiles.OrbitalMissile') orbits from the origin.<br/><br/><br/>The speed of the missile after a range adjustment is determined by whether it was set via [Speed](WCSharp.Missiles.OrbitalMissile.Speed.md 'WCSharp.Missiles.OrbitalMissile.Speed') or [OrbitalPeriod](WCSharp.Missiles.OrbitalMissile.OrbitalPeriod.md 'WCSharp.Missiles.OrbitalMissile.OrbitalPeriod'). |
| [Speed](WCSharp.Missiles.OrbitalMissile.Speed.md 'WCSharp.Missiles.OrbitalMissile.Speed') | The speed of the missile, expressed in units per second.<br/><br/><br/>Use negative values to go clockwise.<br/><br/>This can be used instead of [OrbitalPeriod](WCSharp.Missiles.OrbitalMissile.OrbitalPeriod.md 'WCSharp.Missiles.OrbitalMissile.OrbitalPeriod'), and will ensure a consistent speed for the missile itself through [Range](WCSharp.Missiles.OrbitalMissile.Range.md 'WCSharp.Missiles.OrbitalMissile.Range') adjustments. |
| [SpeedPerTick](WCSharp.Missiles.OrbitalMissile.SpeedPerTick.md 'WCSharp.Missiles.OrbitalMissile.SpeedPerTick') | The speed of the missile, expressed in units per [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') tick (0.03125).<br/><br/><br/>Use negative values to go clockwise.<br/><br/>This can be used instead of [OrbitalPeriod](WCSharp.Missiles.OrbitalMissile.OrbitalPeriod.md 'WCSharp.Missiles.OrbitalMissile.OrbitalPeriod'), and will ensure a consistent speed for the missile itself through [Range](WCSharp.Missiles.OrbitalMissile.Range.md 'WCSharp.Missiles.OrbitalMissile.Range') adjustments. |
| [TargetZ](WCSharp.Missiles.OrbitalMissile.TargetZ.md 'WCSharp.Missiles.OrbitalMissile.TargetZ') | The Z coordinate that this missile is moving towards.<br/><br/><br/>While [Target](WCSharp.Missiles.Missile.Target.md 'WCSharp.Missiles.Missile.Target') is alive, this will automatically be updated.<br/><br/>By default, this is equal to UnitFlyHeight + [TargetImpactZ](WCSharp.Missiles.Missile.TargetImpactZ.md 'WCSharp.Missiles.Missile.TargetImpactZ') + GetLocationZ. |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Missiles.OrbitalMissile.Action().md 'WCSharp.Missiles.OrbitalMissile.Action()') | Called by the system. Do not call yourself. |
| [Launch()](WCSharp.Missiles.OrbitalMissile.Launch().md 'WCSharp.Missiles.OrbitalMissile.Launch()') | Called by the system. Do not call yourself. |
