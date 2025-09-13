#### [WCSharp\.Lightnings](README.md 'README')
### [WCSharp\.Lightnings](WCSharp.Lightnings.md 'WCSharp\.Lightnings').[LightningSystem](WCSharp.Lightnings.LightningSystem.md 'WCSharp\.Lightnings\.LightningSystem')

## LightningSystem\.SetTickInterval\(float\) Method

Changes the tick interval to the desired value\.

Note that the actual change occurs after a 0 second delay.

Calls [BeforeTickIntervalChanged\(float, float\)](WCSharp.Lightnings.Lightning.BeforeTickIntervalChanged(float,float).md 'WCSharp\.Lightnings\.Lightning\.BeforeTickIntervalChanged\(float, float\)') to adjust existing lightnings.

```csharp
public static void SetTickInterval(float tickInterval);
```
#### Parameters

<a name='WCSharp.Lightnings.LightningSystem.SetTickInterval(float).tickInterval'></a>

`tickInterval` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')