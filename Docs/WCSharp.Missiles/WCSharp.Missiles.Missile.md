#### [WCSharp.Missiles](README.md 'README')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles')

## Missile Class

Fundamental missile class that provides the properties and methods that are shared by (virtually) all missiles.  
  
Unless you wish to define a new movement pattern for missiles, you should use one of the derived classes instead.

```csharp
public abstract class Missile :
WCSharp.Events.IPeriodicDisposableAction
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Missile

Derived  
&#8627; [BasicMissile](WCSharp.Missiles.BasicMissile.md 'WCSharp.Missiles.BasicMissile')  
&#8627; [CurveMissile](WCSharp.Missiles.CurveMissile.md 'WCSharp.Missiles.CurveMissile')  
&#8627; [HomingMissile](WCSharp.Missiles.HomingMissile.md 'WCSharp.Missiles.HomingMissile')  
&#8627; [MomentumMissile](WCSharp.Missiles.MomentumMissile.md 'WCSharp.Missiles.MomentumMissile')  
&#8627; [OrbitalMissile](WCSharp.Missiles.OrbitalMissile.md 'WCSharp.Missiles.OrbitalMissile')

Implements [IPeriodicDisposableAction](../WCSharp.Events/WCSharp.Events.IPeriodicDisposableAction.md 'WCSharp.Events.IPeriodicDisposableAction')

| Constructors | |
| :--- | :--- |
| [Missile(player, float, float, float, float)](WCSharp.Missiles.Missile.Missile(War3Api.Common.player,float,float,float,float).md 'WCSharp.Missiles.Missile.Missile(War3Api.Common.player, float, float, float, float)') | Creates a new missile instance with the given parameters. |
| [Missile(player, float, float, unit)](WCSharp.Missiles.Missile.Missile(War3Api.Common.player,float,float,War3Api.Common.unit).md 'WCSharp.Missiles.Missile.Missile(War3Api.Common.player, float, float, War3Api.Common.unit)') | Creates a new missile instance with the given parameters.<br/><br/><br/>Will automatically set [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp.Missiles.Missile.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp.Missiles.Missile.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp.Missiles.Missile.TargetY'). |
| [Missile(unit, float, float)](WCSharp.Missiles.Missile.Missile(War3Api.Common.unit,float,float).md 'WCSharp.Missiles.Missile.Missile(War3Api.Common.unit, float, float)') | Creates a new missile instance with the given parameters.<br/><br/><br/>Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp.Missiles.Missile.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp.Missiles.Missile.CasterX') and [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp.Missiles.Missile.CasterY'). |
| [Missile(unit, unit)](WCSharp.Missiles.Missile.Missile(War3Api.Common.unit,War3Api.Common.unit).md 'WCSharp.Missiles.Missile.Missile(War3Api.Common.unit, War3Api.Common.unit)') | Creates a new missile instance with the given parameters.<br/><br/><br/>Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp.Missiles.Missile.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp.Missiles.Missile.CasterX'), [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp.Missiles.Missile.CasterY'),<br/>            [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp.Missiles.Missile.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp.Missiles.Missile.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp.Missiles.Missile.TargetY'). |

| Properties | |
| :--- | :--- |
| [Active](WCSharp.Missiles.Missile.Active.md 'WCSharp.Missiles.Missile.Active') | Whether the missile is active. This is automatically set to false prior to calling [OnImpact()](WCSharp.Missiles.Missile.OnImpact().md 'WCSharp.Missiles.Missile.OnImpact()'). |
| [Caster](WCSharp.Missiles.Missile.Caster.md 'WCSharp.Missiles.Missile.Caster') | The caster, if it exists. |
| [CasterLaunchZ](WCSharp.Missiles.Missile.CasterLaunchZ.md 'WCSharp.Missiles.Missile.CasterLaunchZ') | Use this to adjust the origin height of the missile when firing, as it will by default fire from the ground (plus unit flying height). |
| [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp.Missiles.Missile.CasterX') | The X coordinate from which the missile was fired. |
| [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp.Missiles.Missile.CasterY') | The Y coordinate from which the missile was fired. |
| [CasterZ](WCSharp.Missiles.Missile.CasterZ.md 'WCSharp.Missiles.Missile.CasterZ') | The Z coordinate from which the missile was fired.<br/><br/><br/>By default, this is equal to UnitFlyHeight + [CasterLaunchZ](WCSharp.Missiles.Missile.CasterLaunchZ.md 'WCSharp.Missiles.Missile.CasterLaunchZ') + GetLocationZ. |
| [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp.Missiles.Missile.CastingPlayer') | The owner of the caster. Automatically set on launch.<br/><br/><br/>Does NOT update automatically! If this is desired, you can use [RegisterForOwnershipChanges()](WCSharp.Missiles.MissileSystem.RegisterForOwnershipChanges().md 'WCSharp.Missiles.MissileSystem.RegisterForOwnershipChanges()'). |
| [CollisionRadius](WCSharp.Missiles.Missile.CollisionRadius.md 'WCSharp.Missiles.Missile.CollisionRadius') | The collision radius of the missile which is used to trigger [OnCollision(unit)](WCSharp.Missiles.Missile.OnCollision(War3Api.Common.unit).md 'WCSharp.Missiles.Missile.OnCollision(War3Api.Common.unit)').<br/><br/><br/>Leave at default (0) to disable. Will ignore values below 0. |
| [CurrentAngle](WCSharp.Missiles.Missile.CurrentAngle.md 'WCSharp.Missiles.Missile.CurrentAngle') | Identical to [Yaw](WCSharp.Missiles.Missile.Yaw.md 'WCSharp.Missiles.Missile.Yaw'). |
| [Effect](WCSharp.Missiles.Missile.Effect.md 'WCSharp.Missiles.Missile.Effect') | The effect being used by the missile. Creation of the effect should be done by setting [EffectString](WCSharp.Missiles.Missile.EffectString.md 'WCSharp.Missiles.Missile.EffectString'), not by setting this property. |
| [EffectScale](WCSharp.Missiles.Missile.EffectScale.md 'WCSharp.Missiles.Missile.EffectScale') | The effect scale of the missile.<br/><br/><br/>If changed mid-flight, automatically modifies the missile. |
| [EffectString](WCSharp.Missiles.Missile.EffectString.md 'WCSharp.Missiles.Missile.EffectString') | The effect string of the missile. If empty/null, the missile will be invisible.<br/><br/><br/>If changed mid-flight, automatically modifies the missile. |
| [ImpactLeeway](WCSharp.Missiles.Missile.ImpactLeeway.md 'WCSharp.Missiles.Missile.ImpactLeeway') | By default impact triggers when the distance to the target is less than the missile's speed per tick.<br/><br/><br/>Use this to increase that distance by a static number (default 0). |
| [InternalCasterZ](WCSharp.Missiles.Missile.InternalCasterZ.md 'WCSharp.Missiles.Missile.InternalCasterZ') | The internal Z coordinate of the caster. This is what the system uses and may or may not be the actual position.<br/><br/><br/>For standard purposes, you should use [CasterZ](WCSharp.Missiles.Missile.CasterZ.md 'WCSharp.Missiles.Missile.CasterZ') instead. |
| [InternalMissileZ](WCSharp.Missiles.Missile.InternalMissileZ.md 'WCSharp.Missiles.Missile.InternalMissileZ') | The internal Z coordinate of the missile. This is what the system uses and may or may not be the actual position.<br/><br/><br/>For standard purposes, you should use [MissileZ](WCSharp.Missiles.Missile.MissileZ.md 'WCSharp.Missiles.Missile.MissileZ') instead. |
| [InternalTargetZ](WCSharp.Missiles.Missile.InternalTargetZ.md 'WCSharp.Missiles.Missile.InternalTargetZ') | The internal Z coordinate of the target. This is what the system uses and may or may not be the actual position.<br/><br/><br/>For standard purposes, you should use [TargetZ](WCSharp.Missiles.Missile.TargetZ.md 'WCSharp.Missiles.Missile.TargetZ') instead. |
| [Interval](WCSharp.Missiles.Missile.Interval.md 'WCSharp.Missiles.Missile.Interval') | The interval at which the missile will call [OnPeriodic()](WCSharp.Missiles.Missile.OnPeriodic().md 'WCSharp.Missiles.Missile.OnPeriodic()').<br/><br/><br/>Leave at default (0) to disable.<br/><br/>Intervals lower with [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') will occassionally run multiple times per tick. |
| [IntervalLeft](WCSharp.Missiles.Missile.IntervalLeft.md 'WCSharp.Missiles.Missile.IntervalLeft') | The time left until the next call to [OnPeriodic()](WCSharp.Missiles.Missile.OnPeriodic().md 'WCSharp.Missiles.Missile.OnPeriodic()'). |
| [MissileX](WCSharp.Missiles.Missile.MissileX.md 'WCSharp.Missiles.Missile.MissileX') | The current X position of the missile.<br/><br/><br/>Depending on the type of missile, MissileX sets may be ignored. |
| [MissileY](WCSharp.Missiles.Missile.MissileY.md 'WCSharp.Missiles.Missile.MissileY') | The current Y position of the missile.<br/><br/><br/>Depending on the type of missile, MissileY sets may be ignored. |
| [MissileZ](WCSharp.Missiles.Missile.MissileZ.md 'WCSharp.Missiles.Missile.MissileZ') | The current Z position of the missile.<br/><br/><br/>Depending on the type of missile, MissileZ sets may be ignored. |
| [Pitch](WCSharp.Missiles.Missile.Pitch.md 'WCSharp.Missiles.Missile.Pitch') | The pitch of the projectile. Defined in degrees.<br/><br/><br/>Depending on the type of missile, pitch sets may be ignored. |
| [PitchRad](WCSharp.Missiles.Missile.PitchRad.md 'WCSharp.Missiles.Missile.PitchRad') | The pitch of the projectile, expressed in radians.<br/><br/><br/>Depending on the type of missile, pitch sets may be ignored. |
| [Roll](WCSharp.Missiles.Missile.Roll.md 'WCSharp.Missiles.Missile.Roll') | The roll of the projectile, expressed in degrees.<br/><br/><br/>Depending on the type of missile, roll sets may be ignored. |
| [RollRad](WCSharp.Missiles.Missile.RollRad.md 'WCSharp.Missiles.Missile.RollRad') | The roll of the projectile, expressed in radians.<br/><br/><br/>Depending on the type of missile, roll sets may be ignored. |
| [Speed](WCSharp.Missiles.Missile.Speed.md 'WCSharp.Missiles.Missile.Speed') | The speed of the missile, expressed in units per second. |
| [SpeedPerTick](WCSharp.Missiles.Missile.SpeedPerTick.md 'WCSharp.Missiles.Missile.SpeedPerTick') | The speed of the missile, expressed in units per [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL'). |
| [SpinPeriod](WCSharp.Missiles.Missile.SpinPeriod.md 'WCSharp.Missiles.Missile.SpinPeriod') | The amount of time it takes for the projectile to spin once during flight in seconds.<br/><br/><br/>Use negative values to go clockwise. |
| [SpinVelocityRad](WCSharp.Missiles.Missile.SpinVelocityRad.md 'WCSharp.Missiles.Missile.SpinVelocityRad') | The velocity of the spin, expressed in radians per [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL').<br/><br/><br/>Use negative values to go clockwise. |
| [Target](WCSharp.Missiles.Missile.Target.md 'WCSharp.Missiles.Missile.Target') | The target, if it exists. If the target dies during travel, this is set to null. |
| [TargetImpactZ](WCSharp.Missiles.Missile.TargetImpactZ.md 'WCSharp.Missiles.Missile.TargetImpactZ') | Use this to adjust the target height of the missile, as it will by default aim towards the ground (plus unit flying height). |
| [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp.Missiles.Missile.TargetPlayer') | The owner of the target. Automatically set on launch.<br/><br/><br/>Does NOT update automatically! If this is desired, you can use [RegisterForOwnershipChanges()](WCSharp.Missiles.MissileSystem.RegisterForOwnershipChanges().md 'WCSharp.Missiles.MissileSystem.RegisterForOwnershipChanges()'). |
| [TargetsHit](WCSharp.Missiles.Missile.TargetsHit.md 'WCSharp.Missiles.Missile.TargetsHit') | <br/><br/>Keeps track of all units collided with thus far.<br/><br/>Null if [CollisionRadius](WCSharp.Missiles.Missile.CollisionRadius.md 'WCSharp.Missiles.Missile.CollisionRadius') has never been set to a value greater than 0.<br/><br/>Removing a unit from this means [OnCollision(unit)](WCSharp.Missiles.Missile.OnCollision(War3Api.Common.unit).md 'WCSharp.Missiles.Missile.OnCollision(War3Api.Common.unit)') will trigger for that unit once more. |
| [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp.Missiles.Missile.TargetX') | The X coordinate that this missile is moving towards. While [Target](WCSharp.Missiles.Missile.Target.md 'WCSharp.Missiles.Missile.Target') is alive, this will automatically be updated. |
| [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp.Missiles.Missile.TargetY') | The Y coordinate that this missile is moving towards. While [Target](WCSharp.Missiles.Missile.Target.md 'WCSharp.Missiles.Missile.Target') is alive, this will automatically be updated. |
| [TargetZ](WCSharp.Missiles.Missile.TargetZ.md 'WCSharp.Missiles.Missile.TargetZ') | The Z coordinate that this missile is moving towards.<br/><br/><br/>While [Target](WCSharp.Missiles.Missile.Target.md 'WCSharp.Missiles.Missile.Target') is alive, this will automatically be updated.<br/><br/>By default, this is equal to UnitFlyHeight + [TargetImpactZ](WCSharp.Missiles.Missile.TargetImpactZ.md 'WCSharp.Missiles.Missile.TargetImpactZ') + GetLocationZ. |
| [Yaw](WCSharp.Missiles.Missile.Yaw.md 'WCSharp.Missiles.Missile.Yaw') | The yaw of the projectile, expressed in degrees.<br/><br/><br/>Depending on the type of missile, yaw sets may be ignored. |
| [YawRad](WCSharp.Missiles.Missile.YawRad.md 'WCSharp.Missiles.Missile.YawRad') | The yaw of the projectile, expressed in radians.<br/><br/><br/>Depending on the type of missile, yaw sets may be ignored. |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Missiles.Missile.Action().md 'WCSharp.Missiles.Missile.Action()') | Called by the system. Do not call yourself. |
| [Dispose()](WCSharp.Missiles.Missile.Dispose().md 'WCSharp.Missiles.Missile.Dispose()') | Automatically called after [Active](../WCSharp.Events/WCSharp.Events.IPeriodicDisposableAction.Active.md 'WCSharp.Events.IPeriodicDisposableAction.Active') is set to false. |
| [Launch()](WCSharp.Missiles.Missile.Launch().md 'WCSharp.Missiles.Missile.Launch()') | Called by the system. Do not call yourself. |
| [OnCollision(unit)](WCSharp.Missiles.Missile.OnCollision(War3Api.Common.unit).md 'WCSharp.Missiles.Missile.OnCollision(War3Api.Common.unit)') | <br/><br/>Override this method if your missile has an effect that should trigger when colliding with another unit.<br/><br/>For this to be active, [CollisionRadius](WCSharp.Missiles.Missile.CollisionRadius.md 'WCSharp.Missiles.Missile.CollisionRadius') must be greater than 0.<br/><br/>Note that there is no filter on this collision. This is called whenever it collides with anything not in [TargetsHit](WCSharp.Missiles.Missile.TargetsHit.md 'WCSharp.Missiles.Missile.TargetsHit').<br/><br/>Before this method is called, the [unit](WCSharp.Missiles.Missile.OnCollision(War3Api.Common.unit).md#WCSharp.Missiles.Missile.OnCollision(War3Api.Common.unit).unit 'WCSharp.Missiles.Missile.OnCollision(War3Api.Common.unit).unit') is added to [TargetsHit](WCSharp.Missiles.Missile.TargetsHit.md 'WCSharp.Missiles.Missile.TargetsHit'). |
| [OnDispose()](WCSharp.Missiles.Missile.OnDispose().md 'WCSharp.Missiles.Missile.OnDispose()') | Override this method if your missile has an effect that should trigger when it is destroyed for any reason. |
| [OnImpact()](WCSharp.Missiles.Missile.OnImpact().md 'WCSharp.Missiles.Missile.OnImpact()') | Override this method if your missile has an impact effect.<br/><br/><br/>[Active](WCSharp.Missiles.Missile.Active.md 'WCSharp.Missiles.Missile.Active') is automatically set to false prior to calling this method. If you do not want the missile to end, you need to set [Active](WCSharp.Missiles.Missile.Active.md 'WCSharp.Missiles.Missile.Active') back to true. |
| [OnPeriodic()](WCSharp.Missiles.Missile.OnPeriodic().md 'WCSharp.Missiles.Missile.OnPeriodic()') | <br/><br/>Override this method if your missile has a periodic effect.<br/><br/>For this to be active, [Interval](WCSharp.Missiles.Missile.Interval.md 'WCSharp.Missiles.Missile.Interval') must be greater than 0. |
