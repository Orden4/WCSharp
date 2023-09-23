#### [WCSharp.Missiles](index.md 'index')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles').[Missile](WCSharp.Missiles.Missile.md 'WCSharp.Missiles.Missile')

## Missile.Interval Property

The interval at which the missile will call [OnPeriodic()](WCSharp.Missiles.Missile.OnPeriodic().md 'WCSharp.Missiles.Missile.OnPeriodic()').  
  
Leave at default (0) to disable.  
  
Intervals lower with [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') will occassionally run multiple times per tick.

```csharp
public float Interval { get; set; }
```

#### Property Value
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')