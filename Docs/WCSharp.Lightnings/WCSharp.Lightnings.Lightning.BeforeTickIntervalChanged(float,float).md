#### [WCSharp\.Lightnings](README.md 'README')
### [WCSharp\.Lightnings](WCSharp.Lightnings.md 'WCSharp\.Lightnings').[Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning')

## Lightning\.BeforeTickIntervalChanged\(float, float\) Method

Override if adjustments are needed when the tick interval is changed\.

Ensure that the base is still called.

```csharp
public virtual void BeforeTickIntervalChanged(float oldTickInterval, float newTickInterval);
```
#### Parameters

<a name='WCSharp.Lightnings.Lightning.BeforeTickIntervalChanged(float,float).oldTickInterval'></a>

`oldTickInterval` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Lightnings.Lightning.BeforeTickIntervalChanged(float,float).newTickInterval'></a>

`newTickInterval` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')