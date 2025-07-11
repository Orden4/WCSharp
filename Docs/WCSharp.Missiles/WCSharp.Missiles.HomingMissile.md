#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles')

## HomingMissile Class

Homing missile with a fixed speed that will attempt to aim itself at the target, restricted by turn speed\.

Note: Does not have any behaviour to avoid endlessly circling the enemy.
            I recommend using it with a collision radius or such so that exact collisions aren't required.

```csharp
public abstract class HomingMissile : WCSharp.Missiles.Missile
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [Missile](WCSharp.Missiles.Missile.md 'WCSharp\.Missiles\.Missile') &#129106; HomingMissile

| Constructors | |
| :--- | :--- |
| [HomingMissile\(player, float, float, float, float\)](WCSharp.Missiles.HomingMissile.#ctor.md#WCSharp.Missiles.HomingMissile.HomingMissile(WCSharp.Api.player,float,float,float,float) 'WCSharp\.Missiles\.HomingMissile\.HomingMissile\(WCSharp\.Api\.player, float, float, float, float\)') | Creates a new missile instance with the given parameters\. |
| [HomingMissile\(player, float, float, unit\)](WCSharp.Missiles.HomingMissile.#ctor.md#WCSharp.Missiles.HomingMissile.HomingMissile(WCSharp.Api.player,float,float,WCSharp.Api.unit) 'WCSharp\.Missiles\.HomingMissile\.HomingMissile\(WCSharp\.Api\.player, float, float, WCSharp\.Api\.unit\)') | Creates a new missile instance with the given parameters\.   Will automatically set [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp\.Missiles\.Missile\.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp\.Missiles\.Missile\.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp\.Missiles\.Missile\.TargetY'). |
| [HomingMissile\(unit, float, float\)](WCSharp.Missiles.HomingMissile.#ctor.md#WCSharp.Missiles.HomingMissile.HomingMissile(WCSharp.Api.unit,float,float) 'WCSharp\.Missiles\.HomingMissile\.HomingMissile\(WCSharp\.Api\.unit, float, float\)') | Creates a new missile instance with the given parameters\.   Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp\.Missiles\.Missile\.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp\.Missiles\.Missile\.CasterX') and [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp\.Missiles\.Missile\.CasterY'). |
| [HomingMissile\(unit, unit\)](WCSharp.Missiles.HomingMissile.#ctor.md#WCSharp.Missiles.HomingMissile.HomingMissile(WCSharp.Api.unit,WCSharp.Api.unit) 'WCSharp\.Missiles\.HomingMissile\.HomingMissile\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)') | Creates a new missile instance with the given parameters\.   Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp\.Missiles\.Missile\.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp\.Missiles\.Missile\.CasterX'), [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp\.Missiles\.Missile\.CasterY'),             [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp\.Missiles\.Missile\.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp\.Missiles\.Missile\.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp\.Missiles\.Missile\.TargetY'). |

| Properties | |
| :--- | :--- |
| [CasterZ](WCSharp.Missiles.HomingMissile.CasterZ.md 'WCSharp\.Missiles\.HomingMissile\.CasterZ') | The Z coordinate from which the missile was fired\.   By default, this is equal to UnitFlyHeight + [CasterLaunchZ](WCSharp.Missiles.Missile.CasterLaunchZ.md 'WCSharp\.Missiles\.Missile\.CasterLaunchZ') + GetLocationZ. |
| [InitialAngle](WCSharp.Missiles.HomingMissile.InitialAngle.md 'WCSharp\.Missiles\.HomingMissile\.InitialAngle') | The initial angle in degrees\. If left at null, will default to the angle towards the target\. |
| [MissileZ](WCSharp.Missiles.HomingMissile.MissileZ.md 'WCSharp\.Missiles\.HomingMissile\.MissileZ') | The current Z position of the missile\.   Depending on the type of missile, MissileZ sets may be ignored. |
| [Mode](WCSharp.Missiles.HomingMissile.Mode.md 'WCSharp\.Missiles\.HomingMissile\.Mode') | The current flight mode of the projectile\.   Automatically set at launch unless changed to a value other than [Default](WCSharp.Missiles.HomingMissile.FlightMode.md#WCSharp.Missiles.HomingMissile.FlightMode.Default 'WCSharp\.Missiles\.HomingMissile\.FlightMode\.Default'). |
| [Speed](WCSharp.Missiles.HomingMissile.Speed.md 'WCSharp\.Missiles\.HomingMissile\.Speed') | The speed of the missile, expressed in units per second\.   Alternatively, use [SpeedPerTick](WCSharp.Missiles.Missile.SpeedPerTick.md 'WCSharp\.Missiles\.Missile\.SpeedPerTick'). |
| [SpeedPerTick](WCSharp.Missiles.HomingMissile.SpeedPerTick.md 'WCSharp\.Missiles\.HomingMissile\.SpeedPerTick') | The speed of the missile, expressed in units per [SYSTEM\_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp\.Events\.PeriodicEvents\.SYSTEM\_INTERVAL')\.   Alternatively, use [Speed](WCSharp.Missiles.Missile.Speed.md 'WCSharp\.Missiles\.Missile\.Speed'). |
| [TargetZ](WCSharp.Missiles.HomingMissile.TargetZ.md 'WCSharp\.Missiles\.HomingMissile\.TargetZ') | The Z coordinate that this missile is moving towards\.   While [Target](WCSharp.Missiles.Missile.Target.md 'WCSharp\.Missiles\.Missile\.Target') is alive, this will automatically be updated.  By default, this is equal to UnitFlyHeight + [TargetImpactZ](WCSharp.Missiles.Missile.TargetImpactZ.md 'WCSharp\.Missiles\.Missile\.TargetImpactZ') + GetLocationZ. |
| [TurnPeriod](WCSharp.Missiles.HomingMissile.TurnPeriod.md 'WCSharp\.Missiles\.HomingMissile\.TurnPeriod') | The rate at which the missile can turn, expressed in degrees per second\.   Alternatively, use [TurnVelocityRad](WCSharp.Missiles.HomingMissile.TurnVelocityRad.md 'WCSharp\.Missiles\.HomingMissile\.TurnVelocityRad') or [TurnRate](WCSharp.Missiles.HomingMissile.TurnRate.md 'WCSharp\.Missiles\.HomingMissile\.TurnRate'). |
| [TurnRate](WCSharp.Missiles.HomingMissile.TurnRate.md 'WCSharp\.Missiles\.HomingMissile\.TurnRate') | The rate at which the missile can turn, expressed in degrees per second\.   Alternatively, use [TurnVelocityRad](WCSharp.Missiles.HomingMissile.TurnVelocityRad.md 'WCSharp\.Missiles\.HomingMissile\.TurnVelocityRad') or [TurnPeriod](WCSharp.Missiles.HomingMissile.TurnPeriod.md 'WCSharp\.Missiles\.HomingMissile\.TurnPeriod'). |
| [TurnVelocityRad](WCSharp.Missiles.HomingMissile.TurnVelocityRad.md 'WCSharp\.Missiles\.HomingMissile\.TurnVelocityRad') | The speed at which the missile can turn, expressed in radians per [SYSTEM\_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp\.Events\.PeriodicEvents\.SYSTEM\_INTERVAL') tick \(0\.03125\)\.   Alternatively, use [TurnRate](WCSharp.Missiles.HomingMissile.TurnRate.md 'WCSharp\.Missiles\.HomingMissile\.TurnRate') or [TurnPeriod](WCSharp.Missiles.HomingMissile.TurnPeriod.md 'WCSharp\.Missiles\.HomingMissile\.TurnPeriod'). |

| Methods | |
| :--- | :--- |
| [Action\(\)](WCSharp.Missiles.HomingMissile.Action().md 'WCSharp\.Missiles\.HomingMissile\.Action\(\)') | Called by the system\. Do not call yourself\. |
| [Launch\(\)](WCSharp.Missiles.HomingMissile.Launch().md 'WCSharp\.Missiles\.HomingMissile\.Launch\(\)') | Called by the system\. Do not call yourself\. |
