#### [WCSharp.Missiles](README.md 'README')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles')

## MomentumMissile Class

Homing-type missile that is based on momentum. Every tick, it will accelerate itself towards the target, up to a maximum speed.  
  
Note that the actual acceleration when adjusting its angle towards the target can be significantly less than specified.  
  
It is recommended to use at least a little bit of [ImpactLeeway](WCSharp.Missiles.Missile.ImpactLeeway.md 'WCSharp.Missiles.Missile.ImpactLeeway') when using this missile.

```csharp
public abstract class MomentumMissile : WCSharp.Missiles.Missile
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Missile](WCSharp.Missiles.Missile.md 'WCSharp.Missiles.Missile') &#129106; MomentumMissile

| Constructors | |
| :--- | :--- |
| [MomentumMissile(player, float, float, float, float)](WCSharp.Missiles.MomentumMissile.MomentumMissile(War3Api.Common.player,float,float,float,float).md 'WCSharp.Missiles.MomentumMissile.MomentumMissile(War3Api.Common.player, float, float, float, float)') | Creates a new missile instance with the given parameters. |
| [MomentumMissile(player, float, float, unit)](WCSharp.Missiles.MomentumMissile.MomentumMissile(War3Api.Common.player,float,float,War3Api.Common.unit).md 'WCSharp.Missiles.MomentumMissile.MomentumMissile(War3Api.Common.player, float, float, War3Api.Common.unit)') | Creates a new missile instance with the given parameters.<br/><br/><br/>Will automatically set [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp.Missiles.Missile.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp.Missiles.Missile.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp.Missiles.Missile.TargetY'). |
| [MomentumMissile(unit, float, float)](WCSharp.Missiles.MomentumMissile.MomentumMissile(War3Api.Common.unit,float,float).md 'WCSharp.Missiles.MomentumMissile.MomentumMissile(War3Api.Common.unit, float, float)') | Creates a new missile instance with the given parameters.<br/><br/><br/>Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp.Missiles.Missile.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp.Missiles.Missile.CasterX') and [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp.Missiles.Missile.CasterY'). |
| [MomentumMissile(unit, unit)](WCSharp.Missiles.MomentumMissile.MomentumMissile(War3Api.Common.unit,War3Api.Common.unit).md 'WCSharp.Missiles.MomentumMissile.MomentumMissile(War3Api.Common.unit, War3Api.Common.unit)') | Creates a new missile instance with the given parameters.<br/><br/><br/>Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp.Missiles.Missile.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp.Missiles.Missile.CasterX'), [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp.Missiles.Missile.CasterY'),<br/>            [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp.Missiles.Missile.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp.Missiles.Missile.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp.Missiles.Missile.TargetY'). |

| Properties | |
| :--- | :--- |
| [Acceleration](WCSharp.Missiles.MomentumMissile.Acceleration.md 'WCSharp.Missiles.MomentumMissile.Acceleration') | The acceleration in units per second.<br/><br/><br/>This is used to make adjustments to the trajectory.<br/><br/>Alternatively, use [AccelerationPerTick](WCSharp.Missiles.MomentumMissile.AccelerationPerTick.md 'WCSharp.Missiles.MomentumMissile.AccelerationPerTick'). |
| [AccelerationPerTick](WCSharp.Missiles.MomentumMissile.AccelerationPerTick.md 'WCSharp.Missiles.MomentumMissile.AccelerationPerTick') | The acceleration in units per [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') (0.03125).<br/><br/><br/>This is used to make adjustments to the trajectory.<br/><br/>Alternatively, use [Acceleration](WCSharp.Missiles.MomentumMissile.Acceleration.md 'WCSharp.Missiles.MomentumMissile.Acceleration'). |
| [CasterZ](WCSharp.Missiles.MomentumMissile.CasterZ.md 'WCSharp.Missiles.MomentumMissile.CasterZ') | The Z coordinate from which the missile was fired.<br/><br/><br/>By default, this is equal to UnitFlyHeight + [CasterLaunchZ](WCSharp.Missiles.Missile.CasterLaunchZ.md 'WCSharp.Missiles.Missile.CasterLaunchZ') + GetLocationZ. |
| [InitialAngle](WCSharp.Missiles.MomentumMissile.InitialAngle.md 'WCSharp.Missiles.MomentumMissile.InitialAngle') | The initial angle in degrees. If left at null, will default to the angle towards the target. |
| [MaximumSpeed](WCSharp.Missiles.MomentumMissile.MaximumSpeed.md 'WCSharp.Missiles.MomentumMissile.MaximumSpeed') | The maximum speed in units per second.<br/><br/><br/>Alternatively, use [MaximumSpeedPerTick](WCSharp.Missiles.MomentumMissile.MaximumSpeedPerTick.md 'WCSharp.Missiles.MomentumMissile.MaximumSpeedPerTick'). |
| [MaximumSpeedPerTick](WCSharp.Missiles.MomentumMissile.MaximumSpeedPerTick.md 'WCSharp.Missiles.MomentumMissile.MaximumSpeedPerTick') | The maximum speed in units per [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') (0.03125).<br/><br/><br/>Alternatively, use [MaximumSpeed](WCSharp.Missiles.MomentumMissile.MaximumSpeed.md 'WCSharp.Missiles.MomentumMissile.MaximumSpeed'). |
| [MissileZ](WCSharp.Missiles.MomentumMissile.MissileZ.md 'WCSharp.Missiles.MomentumMissile.MissileZ') | The current Z position of the missile.<br/><br/><br/>Depending on the type of missile, MissileZ sets may be ignored. |
| [Mode](WCSharp.Missiles.MomentumMissile.Mode.md 'WCSharp.Missiles.MomentumMissile.Mode') | The current flight mode of the projectile.<br/><br/><br/>Automatically set at launch unless changed to a value other than [Default](WCSharp.Missiles.MomentumMissile.FlightMode.md#WCSharp.Missiles.MomentumMissile.FlightMode.Default 'WCSharp.Missiles.MomentumMissile.FlightMode.Default'). |
| [Speed](WCSharp.Missiles.MomentumMissile.Speed.md 'WCSharp.Missiles.MomentumMissile.Speed') | The speed of the missile, expressed in units per second.<br/><br/><br/>Alternatively, use [SpeedPerTick](WCSharp.Missiles.Missile.SpeedPerTick.md 'WCSharp.Missiles.Missile.SpeedPerTick'). |
| [SpeedPerTick](WCSharp.Missiles.MomentumMissile.SpeedPerTick.md 'WCSharp.Missiles.MomentumMissile.SpeedPerTick') | The speed of the missile, expressed in units per [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL').<br/><br/><br/>Alternatively, use [Speed](WCSharp.Missiles.Missile.Speed.md 'WCSharp.Missiles.Missile.Speed'). |
| [TargetZ](WCSharp.Missiles.MomentumMissile.TargetZ.md 'WCSharp.Missiles.MomentumMissile.TargetZ') | The Z coordinate that this missile is moving towards.<br/><br/><br/>While [Target](WCSharp.Missiles.Missile.Target.md 'WCSharp.Missiles.Missile.Target') is alive, this will automatically be updated.<br/><br/>By default, this is equal to UnitFlyHeight + [TargetImpactZ](WCSharp.Missiles.Missile.TargetImpactZ.md 'WCSharp.Missiles.Missile.TargetImpactZ') + GetLocationZ. |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Missiles.MomentumMissile.Action().md 'WCSharp.Missiles.MomentumMissile.Action()') | Called by the system. Do not call yourself. |
| [Launch()](WCSharp.Missiles.MomentumMissile.Launch().md 'WCSharp.Missiles.MomentumMissile.Launch()') | Called by the system. Do not call yourself. |
