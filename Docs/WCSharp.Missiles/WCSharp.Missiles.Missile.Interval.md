#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[Missile](WCSharp.Missiles.Missile.md 'WCSharp\.Missiles\.Missile')

## Missile\.Interval Property

The interval at which the missile will call [OnPeriodic\(\)](WCSharp.Missiles.Missile.OnPeriodic().md 'WCSharp\.Missiles\.Missile\.OnPeriodic\(\)')\.

Leave at default (0) to disable.

Intervals lower than [TickInterval](WCSharp.Missiles.MissileSystem.TickInterval.md 'WCSharp\.Missiles\.MissileSystem\.TickInterval') may run multiple times per tick.

```csharp
public float Interval { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')