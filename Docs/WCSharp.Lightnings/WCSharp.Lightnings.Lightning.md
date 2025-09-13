#### [WCSharp\.Lightnings](README.md 'README')
### [WCSharp\.Lightnings](WCSharp.Lightnings.md 'WCSharp\.Lightnings')

## Lightning Class

Represents a single lightning instance\. Add to [LightningSystem](WCSharp.Lightnings.LightningSystem.md 'WCSharp\.Lightnings\.LightningSystem') to activate\.

```csharp
public class Lightning : WCSharp.Timers.ICollectiveAction, WCSharp.Timers.ITimerAction
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Lightning

Implements [ICollectiveAction](../WCSharp.Timers/WCSharp.Timers.ICollectiveAction.md 'WCSharp\.Timers\.ICollectiveAction'), [ITimerAction](../WCSharp.Timers/WCSharp.Timers.ITimerAction.md 'WCSharp\.Timers\.ITimerAction')

| Constructors | |
| :--- | :--- |
| [Lightning\(string, float, float, float, float\)](WCSharp.Lightnings.Lightning.#ctor.md#WCSharp.Lightnings.Lightning.Lightning(string,float,float,float,float) 'WCSharp\.Lightnings\.Lightning\.Lightning\(string, float, float, float, float\)') | Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning') instance with the given parameters\. |
| [Lightning\(string, float, float, unit\)](WCSharp.Lightnings.Lightning.#ctor.md#WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit) 'WCSharp\.Lightnings\.Lightning\.Lightning\(string, float, float, WCSharp\.Api\.unit\)') | Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning') instance with the given parameters\.   Will automatically set [TargetX](WCSharp.Lightnings.Lightning.TargetX.md 'WCSharp\.Lightnings\.Lightning\.TargetX') and [TargetY](WCSharp.Lightnings.Lightning.TargetY.md 'WCSharp\.Lightnings\.Lightning\.TargetY'). |
| [Lightning\(string, unit, float, float\)](WCSharp.Lightnings.Lightning.#ctor.md#WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float) 'WCSharp\.Lightnings\.Lightning\.Lightning\(string, WCSharp\.Api\.unit, float, float\)') | Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning') instance with the given parameters\.   Will automatically set [CasterX](WCSharp.Lightnings.Lightning.CasterX.md 'WCSharp\.Lightnings\.Lightning\.CasterX') and [CasterY](WCSharp.Lightnings.Lightning.CasterY.md 'WCSharp\.Lightnings\.Lightning\.CasterY'). |
| [Lightning\(string, unit, unit\)](WCSharp.Lightnings.Lightning.#ctor.md#WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit) 'WCSharp\.Lightnings\.Lightning\.Lightning\(string, WCSharp\.Api\.unit, WCSharp\.Api\.unit\)') | Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning') instance with the given parameters\.   Will automatically set [CasterX](WCSharp.Lightnings.Lightning.CasterX.md 'WCSharp\.Lightnings\.Lightning\.CasterX'), [CasterY](WCSharp.Lightnings.Lightning.CasterY.md 'WCSharp\.Lightnings\.Lightning\.CasterY'), [TargetX](WCSharp.Lightnings.Lightning.TargetX.md 'WCSharp\.Lightnings\.Lightning\.TargetX') and [TargetY](WCSharp.Lightnings.Lightning.TargetY.md 'WCSharp\.Lightnings\.Lightning\.TargetY'). |

| Properties | |
| :--- | :--- |
| [Active](WCSharp.Lightnings.Lightning.Active.md 'WCSharp\.Lightnings\.Lightning\.Active') | Used to indicate whether the timer should remain active or not\.   Set to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') automatically.  Set to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') to disable the loop. |
| [Alpha](WCSharp.Lightnings.Lightning.Alpha.md 'WCSharp\.Lightnings\.Lightning\.Alpha') | The alpha \(transparency\) of this lightning\. Setting this to 0 means the lightning is invisible\. |
| [Blue](WCSharp.Lightnings.Lightning.Blue.md 'WCSharp\.Lightnings\.Lightning\.Blue') | The blue color of this lightning\. Setting this to 0 means all blue will be removed from the lightning\. |
| [Caster](WCSharp.Lightnings.Lightning.Caster.md 'WCSharp\.Lightnings\.Lightning\.Caster') | The caster of the lightning\. Setting this means that the lightning will follow the caster when the caster moves\. |
| [CasterHeightOffset](WCSharp.Lightnings.Lightning.CasterHeightOffset.md 'WCSharp\.Lightnings\.Lightning\.CasterHeightOffset') | The height that this lightning should originate from\. By default, this is the ground\. |
| [CasterX](WCSharp.Lightnings.Lightning.CasterX.md 'WCSharp\.Lightnings\.Lightning\.CasterX') | The X coordinate from which this lightning was fired\. While [Caster](WCSharp.Lightnings.Lightning.Caster.md 'WCSharp\.Lightnings\.Lightning\.Caster') is alive, this will automatically be updated\. |
| [CasterY](WCSharp.Lightnings.Lightning.CasterY.md 'WCSharp\.Lightnings\.Lightning\.CasterY') | The Y coordinate from which this lightning was fired\. While [Caster](WCSharp.Lightnings.Lightning.Caster.md 'WCSharp\.Lightnings\.Lightning\.Caster') is alive, this will automatically be updated\. |
| [Duration](WCSharp.Lightnings.Lightning.Duration.md 'WCSharp\.Lightnings\.Lightning\.Duration') | The duration that this lightning should last in total\. |
| [FadeDuration](WCSharp.Lightnings.Lightning.FadeDuration.md 'WCSharp\.Lightnings\.Lightning\.FadeDuration') | The length of time over which the lightning will fade\. |
| [Green](WCSharp.Lightnings.Lightning.Green.md 'WCSharp\.Lightnings\.Lightning\.Green') | The green color of this lightning\. Setting this to 0 means all green will be removed from the lightning\. |
| [Red](WCSharp.Lightnings.Lightning.Red.md 'WCSharp\.Lightnings\.Lightning\.Red') | The red color of this lightning\. Setting this to 0 means all red will be removed from the lightning\. |
| [Target](WCSharp.Lightnings.Lightning.Target.md 'WCSharp\.Lightnings\.Lightning\.Target') | The target of the lightning\. Setting this means that the lightning will follow the target when the target moves\. |
| [TargetHeightOffset](WCSharp.Lightnings.Lightning.TargetHeightOffset.md 'WCSharp\.Lightnings\.Lightning\.TargetHeightOffset') | The height that this lightning should aim at\. By default, this is the ground\. |
| [TargetX](WCSharp.Lightnings.Lightning.TargetX.md 'WCSharp\.Lightnings\.Lightning\.TargetX') | The X coordinate that this lightning is targeting\. While [Target](WCSharp.Lightnings.Lightning.Target.md 'WCSharp\.Lightnings\.Lightning\.Target') is alive, this will automatically be updated\. |
| [TargetY](WCSharp.Lightnings.Lightning.TargetY.md 'WCSharp\.Lightnings\.Lightning\.TargetY') | The Y coordinate that this lightning is targeting\. While [Target](WCSharp.Lightnings.Lightning.Target.md 'WCSharp\.Lightnings\.Lightning\.Target') is alive, this will automatically be updated\. |

| Methods | |
| :--- | :--- |
| [Action\(\)](WCSharp.Lightnings.Lightning.Action().md 'WCSharp\.Lightnings\.Lightning\.Action\(\)') | Called by the system\. Do not call yourself\. |
| [BeforeTickIntervalChanged\(float, float\)](WCSharp.Lightnings.Lightning.BeforeTickIntervalChanged(float,float).md 'WCSharp\.Lightnings\.Lightning\.BeforeTickIntervalChanged\(float, float\)') | Override if adjustments are needed when the tick interval is changed\.   Ensure that the base is still called. |
| [StartFade\(\)](WCSharp.Lightnings.Lightning.StartFade().md 'WCSharp\.Lightnings\.Lightning\.StartFade\(\)') | For lightnings that last until cancelled \(meaning duration is excessively high\), this method can be used to start the fade out process when desired\. |
