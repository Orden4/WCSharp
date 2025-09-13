#### [WCSharp\.Knockbacks](README.md 'README')
### [WCSharp\.Knockbacks](WCSharp.Knockbacks.md 'WCSharp\.Knockbacks')

## Knockback Class

Represents a single knockback instance\. Add to [KnockbackSystem](WCSharp.Knockbacks.KnockbackSystem.md 'WCSharp\.Knockbacks\.KnockbackSystem') to activate\.

```csharp
public class Knockback : WCSharp.Timers.ICollectiveAction, WCSharp.Timers.ITimerAction
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Knockback

Implements [ICollectiveAction](../WCSharp.Timers/WCSharp.Timers.ICollectiveAction.md 'WCSharp\.Timers\.ICollectiveAction'), [ITimerAction](../WCSharp.Timers/WCSharp.Timers.ITimerAction.md 'WCSharp\.Timers\.ITimerAction')

| Constructors | |
| :--- | :--- |
| [Knockback\(unit, float, float, float\)](WCSharp.Knockbacks.Knockback.#ctor.md#WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float) 'WCSharp\.Knockbacks\.Knockback\.Knockback\(WCSharp\.Api\.unit, float, float, float\)') | Knocks the target the given distance towards the given angle \(in degrees\) over the given duration\. |
| [Knockback\(unit, float, float, float, float\)](WCSharp.Knockbacks.Knockback.#ctor.md#WCSharp.Knockbacks.Knockback.Knockback(WCSharp.Api.unit,float,float,float,float) 'WCSharp\.Knockbacks\.Knockback\.Knockback\(WCSharp\.Api\.unit, float, float, float, float\)') | Knocks the target the given distance towards the given location over the given duration\. |

| Fields | |
| :--- | :--- |
| [EFFECT1\_PERIOD](WCSharp.Knockbacks.Knockback.EFFECT1_PERIOD.md 'WCSharp\.Knockbacks\.Knockback\.EFFECT1\_PERIOD') | The interval between [Effect1](WCSharp.Knockbacks.Knockback.Effect1.md 'WCSharp\.Knockbacks\.Knockback\.Effect1') spawns\. |
| [EFFECT2\_PERIOD](WCSharp.Knockbacks.Knockback.EFFECT2_PERIOD.md 'WCSharp\.Knockbacks\.Knockback\.EFFECT2\_PERIOD') | The interval between [Effect2](WCSharp.Knockbacks.Knockback.Effect2.md 'WCSharp\.Knockbacks\.Knockback\.Effect2') spawns\. |

| Properties | |
| :--- | :--- |
| [Active](WCSharp.Knockbacks.Knockback.Active.md 'WCSharp\.Knockbacks\.Knockback\.Active') | Setting this to false will immediately end the knockback\. |
| [Angle](WCSharp.Knockbacks.Knockback.Angle.md 'WCSharp\.Knockbacks\.Knockback\.Angle') | The angle of the knockback in radians\. |
| [Effect1](WCSharp.Knockbacks.Knockback.Effect1.md 'WCSharp\.Knockbacks\.Knockback\.Effect1') | This effect will be spawned every 1\.0 seconds on the target using [Effect1AttachmentPoint](WCSharp.Knockbacks.Knockback.Effect1AttachmentPoint.md 'WCSharp\.Knockbacks\.Knockback\.Effect1AttachmentPoint')\. |
| [Effect1AttachmentPoint](WCSharp.Knockbacks.Knockback.Effect1AttachmentPoint.md 'WCSharp\.Knockbacks\.Knockback\.Effect1AttachmentPoint') | The attachment point to use for [Effect1](WCSharp.Knockbacks.Knockback.Effect1.md 'WCSharp\.Knockbacks\.Knockback\.Effect1')\. |
| [Effect2](WCSharp.Knockbacks.Knockback.Effect2.md 'WCSharp\.Knockbacks\.Knockback\.Effect2') | This effect will be spawned every 0\.125 on the target using [Effect2AttachmentPoint](WCSharp.Knockbacks.Knockback.Effect2AttachmentPoint.md 'WCSharp\.Knockbacks\.Knockback\.Effect2AttachmentPoint')\. |
| [Effect2AttachmentPoint](WCSharp.Knockbacks.Knockback.Effect2AttachmentPoint.md 'WCSharp\.Knockbacks\.Knockback\.Effect2AttachmentPoint') | The attachment point to use for [Effect2](WCSharp.Knockbacks.Knockback.Effect2.md 'WCSharp\.Knockbacks\.Knockback\.Effect2')\. |
| [Speed](WCSharp.Knockbacks.Knockback.Speed.md 'WCSharp\.Knockbacks\.Knockback\.Speed') | The distance traversed per [TickInterval](WCSharp.Knockbacks.KnockbackSystem.TickInterval.md 'WCSharp\.Knockbacks\.KnockbackSystem\.TickInterval')\. |
| [SpeedDropoff](WCSharp.Knockbacks.Knockback.SpeedDropoff.md 'WCSharp\.Knockbacks\.Knockback\.SpeedDropoff') | The amount of speed lost per [TickInterval](WCSharp.Knockbacks.KnockbackSystem.TickInterval.md 'WCSharp\.Knockbacks\.KnockbackSystem\.TickInterval')\. |
| [Target](WCSharp.Knockbacks.Knockback.Target.md 'WCSharp\.Knockbacks\.Knockback\.Target') | The target of the knockback\. |

| Methods | |
| :--- | :--- |
| [Action\(\)](WCSharp.Knockbacks.Knockback.Action().md 'WCSharp\.Knockbacks\.Knockback\.Action\(\)') | Called by the system\. Do not call yourself\. |
| [BeforeTickIntervalChanged\(float, float\)](WCSharp.Knockbacks.Knockback.BeforeTickIntervalChanged(float,float).md 'WCSharp\.Knockbacks\.Knockback\.BeforeTickIntervalChanged\(float, float\)') | Override if adjustments are needed when the tick interval is changed\.   Ensure that the base is still called. |
| [Merge\(Knockback\)](WCSharp.Knockbacks.Knockback.Merge(WCSharp.Knockbacks.Knockback).md 'WCSharp\.Knockbacks\.Knockback\.Merge\(WCSharp\.Knockbacks\.Knockback\)') | Merges the force of the given knockback into this knockback\. Typically though, you can also just have both knockbacks active simultaneously and achieve the same effect\. |
