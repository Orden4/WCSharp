### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles')

## CurveMissile Class

Advanced missile that allows for arcing/curving motions, i.e. a boomerang motion.  
  
If you do not use the [Curve](WCSharp.Missiles.CurveMissile.Curve.md 'WCSharp.Missiles.CurveMissile.Curve') property, you should use [BasicMissile](WCSharp.Missiles.BasicMissile.md 'WCSharp.Missiles.BasicMissile') instead for greater performance and  
            identical features.

```csharp
public abstract class CurveMissile : WCSharp.Missiles.Missile
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Missile](WCSharp.Missiles.Missile.md 'WCSharp.Missiles.Missile') &#129106; CurveMissile

| Constructors | |
| :--- | :--- |
| [CurveMissile(player, float, float, float, float)](WCSharp.Missiles.CurveMissile.CurveMissile(War3Api.Common.player,float,float,float,float).md 'WCSharp.Missiles.CurveMissile.CurveMissile(War3Api.Common.player, float, float, float, float)') | Creates a new missile instance with the given parameters. |
| [CurveMissile(player, float, float, unit)](WCSharp.Missiles.CurveMissile.CurveMissile(War3Api.Common.player,float,float,War3Api.Common.unit).md 'WCSharp.Missiles.CurveMissile.CurveMissile(War3Api.Common.player, float, float, War3Api.Common.unit)') | Creates a new missile instance with the given parameters.<br/><br/><br/>Will automatically set [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp.Missiles.Missile.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp.Missiles.Missile.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp.Missiles.Missile.TargetY'). |
| [CurveMissile(unit, float, float)](WCSharp.Missiles.CurveMissile.CurveMissile(War3Api.Common.unit,float,float).md 'WCSharp.Missiles.CurveMissile.CurveMissile(War3Api.Common.unit, float, float)') | Creates a new missile instance with the given parameters.<br/><br/><br/>Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp.Missiles.Missile.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp.Missiles.Missile.CasterX') and [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp.Missiles.Missile.CasterY'). |
| [CurveMissile(unit, unit)](WCSharp.Missiles.CurveMissile.CurveMissile(War3Api.Common.unit,War3Api.Common.unit).md 'WCSharp.Missiles.CurveMissile.CurveMissile(War3Api.Common.unit, War3Api.Common.unit)') | Creates a new missile instance with the given parameters.<br/><br/><br/>Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp.Missiles.Missile.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp.Missiles.Missile.CasterX'), [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp.Missiles.Missile.CasterY'),<br/>            [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp.Missiles.Missile.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp.Missiles.Missile.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp.Missiles.Missile.TargetY'). |

| Properties | |
| :--- | :--- |
| [Arc](WCSharp.Missiles.CurveMissile.Arc.md 'WCSharp.Missiles.CurveMissile.Arc') | The arc of the missile. Closely matches the object editor arc values.<br/><br/><br/>If you want a fixed height arc, set the Arc equal to (arc height/distance to target). |
| [CasterZ](WCSharp.Missiles.CurveMissile.CasterZ.md 'WCSharp.Missiles.CurveMissile.CasterZ') | The Z coordinate from which the missile was fired.<br/><br/><br/>By default, this is equal to UnitFlyHeight + [CasterLaunchZ](WCSharp.Missiles.Missile.CasterLaunchZ.md 'WCSharp.Missiles.Missile.CasterLaunchZ') + GetLocationZ. |
| [Curve](WCSharp.Missiles.CurveMissile.Curve.md 'WCSharp.Missiles.CurveMissile.Curve') | The curve of the projectile, expressed in degrees.<br/><br/><br/>This alters the arc, a 90 or -90 degree curve is a boomerang. |
| [CurveRad](WCSharp.Missiles.CurveMissile.CurveRad.md 'WCSharp.Missiles.CurveMissile.CurveRad') | The curve of the projectile, expressed in radians.<br/><br/><br/>This alters the arc, a pi/2 or -pi/2 degree curve is a boomerang. |
| [IsArcingOrCurving](WCSharp.Missiles.CurveMissile.IsArcingOrCurving.md 'WCSharp.Missiles.CurveMissile.IsArcingOrCurving') | Whether the projectile is currently performing an arc or curve motion.<br/><br/><br/>Automatically set at launch according to the [Arc](WCSharp.Missiles.CurveMissile.Arc.md 'WCSharp.Missiles.CurveMissile.Arc') and [Curve](WCSharp.Missiles.CurveMissile.Curve.md 'WCSharp.Missiles.CurveMissile.Curve')/[CurveRad](WCSharp.Missiles.CurveMissile.CurveRad.md 'WCSharp.Missiles.CurveMissile.CurveRad') value.<br/><br/>This is automatically disabled if the target moves more than 50 units in a single [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') tick (0.03125).<br/><br/>Warning: Setting this to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') mid-flight will cause the stored caster position to be changed to the missiles current position. |
| [MissileZ](WCSharp.Missiles.CurveMissile.MissileZ.md 'WCSharp.Missiles.CurveMissile.MissileZ') | The current Z position of the missile.<br/><br/><br/>Depending on the type of missile, MissileZ sets may be ignored. |
| [Mode](WCSharp.Missiles.CurveMissile.Mode.md 'WCSharp.Missiles.CurveMissile.Mode') | The current flight mode of the projectile.<br/><br/><br/>Automatically set at launch unless changed to a value other than [Default](WCSharp.Missiles.CurveMissile.FlightMode.md#WCSharp.Missiles.CurveMissile.FlightMode.Default 'WCSharp.Missiles.CurveMissile.FlightMode.Default'). |
| [OriginX](WCSharp.Missiles.CurveMissile.OriginX.md 'WCSharp.Missiles.CurveMissile.OriginX') | The internal X of the missile without the arc/curve. |
| [OriginY](WCSharp.Missiles.CurveMissile.OriginY.md 'WCSharp.Missiles.CurveMissile.OriginY') | The internal Y of the missile without the arc/curve. |
| [OriginZ](WCSharp.Missiles.CurveMissile.OriginZ.md 'WCSharp.Missiles.CurveMissile.OriginZ') | The internal Z of the missile without the arc/curve and terrain height. |
| [Speed](WCSharp.Missiles.CurveMissile.Speed.md 'WCSharp.Missiles.CurveMissile.Speed') | The speed of the missile, expressed in units per second. |
| [SpeedPerTick](WCSharp.Missiles.CurveMissile.SpeedPerTick.md 'WCSharp.Missiles.CurveMissile.SpeedPerTick') | The speed of the missile, expressed in units per [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL'). |
| [TargetZ](WCSharp.Missiles.CurveMissile.TargetZ.md 'WCSharp.Missiles.CurveMissile.TargetZ') | The Z coordinate that this missile is moving towards.<br/><br/><br/>While [Target](WCSharp.Missiles.Missile.Target.md 'WCSharp.Missiles.Missile.Target') is alive, this will automatically be updated.<br/><br/>By default, this is equal to UnitFlyHeight + [TargetImpactZ](WCSharp.Missiles.Missile.TargetImpactZ.md 'WCSharp.Missiles.Missile.TargetImpactZ') + GetLocationZ. |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Missiles.CurveMissile.Action().md 'WCSharp.Missiles.CurveMissile.Action()') | Called by the system. Do not call yourself. |
| [Launch()](WCSharp.Missiles.CurveMissile.Launch().md 'WCSharp.Missiles.CurveMissile.Launch()') | Called by the system. Do not call yourself. |
