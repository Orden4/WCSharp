#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[HomingMissile](WCSharp.Missiles.HomingMissile.md 'WCSharp\.Missiles\.HomingMissile')

## HomingMissile\.BeforeTickIntervalChanged\(float, float\) Method

Override if adjustments are needed when the tick interval is changed\.

Ensure that the base is still called.

```csharp
public override void BeforeTickIntervalChanged(float oldTickInterval, float newTickInterval);
```
#### Parameters

<a name='WCSharp.Missiles.HomingMissile.BeforeTickIntervalChanged(float,float).oldTickInterval'></a>

`oldTickInterval` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Missiles.HomingMissile.BeforeTickIntervalChanged(float,float).newTickInterval'></a>

`newTickInterval` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')