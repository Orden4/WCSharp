#### [WCSharp.Missiles](index.md 'index')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles')

## BasicMissile Class

Basic missile that will go from unit/location A to unit/location B.  
  
The main feature for this missile is that missiles can arc.

```csharp
public abstract class BasicMissile : WCSharp.Missiles.Missile
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Missile](WCSharp.Missiles.Missile.md 'WCSharp.Missiles.Missile') &#129106; BasicMissile

| Constructors | |
| :--- | :--- |
| [BasicMissile(player, float, float, float, float)](WCSharp.Missiles.BasicMissile.BasicMissile(War3Api.Common.player,float,float,float,float).md 'WCSharp.Missiles.BasicMissile.BasicMissile(War3Api.Common.player, float, float, float, float)') | Creates a new missile instance with the given parameters. |
| [BasicMissile(player, float, float, unit)](WCSharp.Missiles.BasicMissile.BasicMissile(War3Api.Common.player,float,float,War3Api.Common.unit).md 'WCSharp.Missiles.BasicMissile.BasicMissile(War3Api.Common.player, float, float, War3Api.Common.unit)') | Creates a new missile instance with the given parameters.<br/><br/><br/>Will automatically set [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp.Missiles.Missile.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp.Missiles.Missile.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp.Missiles.Missile.TargetY'). |
| [BasicMissile(unit, float, float)](WCSharp.Missiles.BasicMissile.BasicMissile(War3Api.Common.unit,float,float).md 'WCSharp.Missiles.BasicMissile.BasicMissile(War3Api.Common.unit, float, float)') | Creates a new missile instance with the given parameters.<br/><br/><br/>Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp.Missiles.Missile.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp.Missiles.Missile.CasterX') and [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp.Missiles.Missile.CasterY'). |
| [BasicMissile(unit, unit)](WCSharp.Missiles.BasicMissile.BasicMissile(War3Api.Common.unit,War3Api.Common.unit).md 'WCSharp.Missiles.BasicMissile.BasicMissile(War3Api.Common.unit, War3Api.Common.unit)') | Creates a new missile instance with the given parameters.<br/><br/><br/>Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp.Missiles.Missile.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp.Missiles.Missile.CasterX'), [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp.Missiles.Missile.CasterY'),<br/>            [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp.Missiles.Missile.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp.Missiles.Missile.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp.Missiles.Missile.TargetY'). |

| Properties | |
| :--- | :--- |
| [Arc](WCSharp.Missiles.BasicMissile.Arc.md 'WCSharp.Missiles.BasicMissile.Arc') | The arc of the missile. Closely matches the object editor arc values.<br/><br/><br/>If you want a fixed height arc, set the Arc equal to (arc height/distance to target). |
| [CasterZ](WCSharp.Missiles.BasicMissile.CasterZ.md 'WCSharp.Missiles.BasicMissile.CasterZ') | The Z coordinate from which the missile was fired.<br/><br/><br/>By default, this is equal to UnitFlyHeight + [CasterLaunchZ](WCSharp.Missiles.Missile.CasterLaunchZ.md 'WCSharp.Missiles.Missile.CasterLaunchZ') + GetLocationZ. |
| [IsArcing](WCSharp.Missiles.BasicMissile.IsArcing.md 'WCSharp.Missiles.BasicMissile.IsArcing') | Whether the projectile is currently performing an arc motion.<br/><br/><br/>Automatically set at launch according to the [Arc](WCSharp.Missiles.BasicMissile.Arc.md 'WCSharp.Missiles.BasicMissile.Arc') value.<br/><br/>This is automatically disabled if the target moves more than 50 units in a single [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') tick (0.03125).<br/><br/>Warning: Setting this to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') mid-flight will cause the stored caster position to be changed to the missiles current position. |
| [MissileZ](WCSharp.Missiles.BasicMissile.MissileZ.md 'WCSharp.Missiles.BasicMissile.MissileZ') | The current Z position of the missile.<br/><br/><br/>Depending on the type of missile, MissileZ sets may be ignored. |
| [Mode](WCSharp.Missiles.BasicMissile.Mode.md 'WCSharp.Missiles.BasicMissile.Mode') | The current flight mode of the projectile.<br/><br/><br/>Automatically set at launch unless changed to a value other than [Default](WCSharp.Missiles.BasicMissile.FlightMode.md#WCSharp.Missiles.BasicMissile.FlightMode.Default 'WCSharp.Missiles.BasicMissile.FlightMode.Default'). |
| [Speed](WCSharp.Missiles.BasicMissile.Speed.md 'WCSharp.Missiles.BasicMissile.Speed') | The speed of the missile, expressed in units per second. |
| [SpeedPerTick](WCSharp.Missiles.BasicMissile.SpeedPerTick.md 'WCSharp.Missiles.BasicMissile.SpeedPerTick') | The speed of the missile, expressed in units per [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL'). |
| [TargetZ](WCSharp.Missiles.BasicMissile.TargetZ.md 'WCSharp.Missiles.BasicMissile.TargetZ') | The Z coordinate that this missile is moving towards.<br/><br/><br/>While [Target](WCSharp.Missiles.Missile.Target.md 'WCSharp.Missiles.Missile.Target') is alive, this will automatically be updated.<br/><br/>By default, this is equal to UnitFlyHeight + [TargetImpactZ](WCSharp.Missiles.Missile.TargetImpactZ.md 'WCSharp.Missiles.Missile.TargetImpactZ') + GetLocationZ. |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Missiles.BasicMissile.Action().md 'WCSharp.Missiles.BasicMissile.Action()') | Called by the system. Do not call yourself. |
| [Launch()](WCSharp.Missiles.BasicMissile.Launch().md 'WCSharp.Missiles.BasicMissile.Launch()') | Called by the system. Do not call yourself. |
