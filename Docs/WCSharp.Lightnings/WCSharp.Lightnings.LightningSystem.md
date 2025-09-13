#### [WCSharp\.Lightnings](README.md 'README')
### [WCSharp\.Lightnings](WCSharp.Lightnings.md 'WCSharp\.Lightnings')

## LightningSystem Class

Tracks and runs all active [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning') instances\.

```csharp
public static class LightningSystem
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; LightningSystem

| Properties | |
| :--- | :--- |
| [Lightnings](WCSharp.Lightnings.LightningSystem.Lightnings.md 'WCSharp\.Lightnings\.LightningSystem\.Lightnings') | All active lightnings\. |
| [TickInterval](WCSharp.Lightnings.LightningSystem.TickInterval.md 'WCSharp\.Lightnings\.LightningSystem\.TickInterval') | The interval between each update of the system\.   Use [SetTickInterval\(float\)](WCSharp.Lightnings.LightningSystem.SetTickInterval(float).md 'WCSharp\.Lightnings\.LightningSystem\.SetTickInterval\(float\)') to adjust. |

| Methods | |
| :--- | :--- |
| [Add\(Lightning\)](WCSharp.Lightnings.LightningSystem.Add(WCSharp.Lightnings.Lightning).md 'WCSharp\.Lightnings\.LightningSystem\.Add\(WCSharp\.Lightnings\.Lightning\)') | Adds the given [lightning](WCSharp.Lightnings.LightningSystem.Add(WCSharp.Lightnings.Lightning).md#WCSharp.Lightnings.LightningSystem.Add(WCSharp.Lightnings.Lightning).lightning 'WCSharp\.Lightnings\.LightningSystem\.Add\(WCSharp\.Lightnings\.Lightning\)\.lightning') to the system\. This will also initialise or alter some values according to the lightnings' properties\. |
| [SetTickInterval\(float\)](WCSharp.Lightnings.LightningSystem.SetTickInterval(float).md 'WCSharp\.Lightnings\.LightningSystem\.SetTickInterval\(float\)') | Changes the tick interval to the desired value\.   Note that the actual change occurs after a 0 second delay.  Calls [BeforeTickIntervalChanged\(float, float\)](WCSharp.Lightnings.Lightning.BeforeTickIntervalChanged(float,float).md 'WCSharp\.Lightnings\.Lightning\.BeforeTickIntervalChanged\(float, float\)') to adjust existing lightnings. |
