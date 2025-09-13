#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[MissileSystem](WCSharp.Missiles.MissileSystem.md 'WCSharp\.Missiles\.MissileSystem')

## MissileSystem\.SetTickInterval\(float\) Method

Changes the tick interval to the desired value\.

Note that the actual change occurs after a 0 second delay.

Calls [BeforeTickIntervalChanged\(float, float\)](WCSharp.Missiles.Missile.BeforeTickIntervalChanged(float,float).md 'WCSharp\.Missiles\.Missile\.BeforeTickIntervalChanged\(float, float\)') to adjust existing missiles.

```csharp
public static void SetTickInterval(float tickInterval);
```
#### Parameters

<a name='WCSharp.Missiles.MissileSystem.SetTickInterval(float).tickInterval'></a>

`tickInterval` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')