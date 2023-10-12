#### [WCSharp.Knockbacks](README.md 'README')
### [WCSharp.Knockbacks](WCSharp.Knockbacks.md 'WCSharp.Knockbacks')

## Knockback Class

Represents a single knockback instance. Add to [KnockbackSystem](WCSharp.Knockbacks.KnockbackSystem.md 'WCSharp.Knockbacks.KnockbackSystem') to activate.

```csharp
public class Knockback :
WCSharp.Events.IPeriodicAction
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Knockback

Implements [IPeriodicAction](../WCSharp.Events/WCSharp.Events.IPeriodicAction.md 'WCSharp.Events.IPeriodicAction')

| Constructors | |
| :--- | :--- |
| [Knockback(unit, float, float, float)](WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float).md 'WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit, float, float, float)') | Knocks the target the given distance towards the given angle (in degrees) over the given duration. |
| [Knockback(unit, float, float, float, float)](WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float,float).md 'WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit, float, float, float, float)') | Knocks the target the given distance towards the given location over the given duration. |

| Fields | |
| :--- | :--- |
| [EFFECT1_PERIOD](WCSharp.Knockbacks.Knockback.EFFECT1_PERIOD.md 'WCSharp.Knockbacks.Knockback.EFFECT1_PERIOD') | The interval between [Effect1](WCSharp.Knockbacks.Knockback.Effect1.md 'WCSharp.Knockbacks.Knockback.Effect1') spawns. |
| [EFFECT2_PERIOD](WCSharp.Knockbacks.Knockback.EFFECT2_PERIOD.md 'WCSharp.Knockbacks.Knockback.EFFECT2_PERIOD') | The interval between [Effect2](WCSharp.Knockbacks.Knockback.Effect2.md 'WCSharp.Knockbacks.Knockback.Effect2') spawns. |

| Properties | |
| :--- | :--- |
| [Active](WCSharp.Knockbacks.Knockback.Active.md 'WCSharp.Knockbacks.Knockback.Active') | Setting this to false will immediately end the knockback. |
| [Angle](WCSharp.Knockbacks.Knockback.Angle.md 'WCSharp.Knockbacks.Knockback.Angle') | The angle of the knockback in radians. |
| [Effect1](WCSharp.Knockbacks.Knockback.Effect1.md 'WCSharp.Knockbacks.Knockback.Effect1') | This effect will be spawned every 1.0 seconds on the target using [Effect1AttachmentPoint](WCSharp.Knockbacks.Knockback.Effect1AttachmentPoint.md 'WCSharp.Knockbacks.Knockback.Effect1AttachmentPoint'). |
| [Effect1AttachmentPoint](WCSharp.Knockbacks.Knockback.Effect1AttachmentPoint.md 'WCSharp.Knockbacks.Knockback.Effect1AttachmentPoint') | The attachment point to use for [Effect1](WCSharp.Knockbacks.Knockback.Effect1.md 'WCSharp.Knockbacks.Knockback.Effect1'). |
| [Effect2](WCSharp.Knockbacks.Knockback.Effect2.md 'WCSharp.Knockbacks.Knockback.Effect2') | This effect will be spawned every 0.125 on the target using [Effect2AttachmentPoint](WCSharp.Knockbacks.Knockback.Effect2AttachmentPoint.md 'WCSharp.Knockbacks.Knockback.Effect2AttachmentPoint'). |
| [Effect2AttachmentPoint](WCSharp.Knockbacks.Knockback.Effect2AttachmentPoint.md 'WCSharp.Knockbacks.Knockback.Effect2AttachmentPoint') | The attachment point to use for [Effect2](WCSharp.Knockbacks.Knockback.Effect2.md 'WCSharp.Knockbacks.Knockback.Effect2'). |
| [Speed](WCSharp.Knockbacks.Knockback.Speed.md 'WCSharp.Knockbacks.Knockback.Speed') | The distance traversed per [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') (0.03125). |
| [SpeedDropoff](WCSharp.Knockbacks.Knockback.SpeedDropoff.md 'WCSharp.Knockbacks.Knockback.SpeedDropoff') | The amount of speed lost per [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') (0.03125). |
| [Target](WCSharp.Knockbacks.Knockback.Target.md 'WCSharp.Knockbacks.Knockback.Target') | The target of the knockback. |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Knockbacks.Knockback.Action().md 'WCSharp.Knockbacks.Knockback.Action()') | Called by the system. Do not call yourself. |
| [Merge(Knockback)](WCSharp.Knockbacks.Knockback.Merge(WCSharp.Knockbacks.Knockback).md 'WCSharp.Knockbacks.Knockback.Merge(WCSharp.Knockbacks.Knockback)') | Merges the force of the given knockback into this knockback. Typically though, you can also just have both knockbacks active simultaneously and achieve the same effect. |
