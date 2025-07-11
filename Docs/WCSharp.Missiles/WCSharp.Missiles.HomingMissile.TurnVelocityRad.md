#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[HomingMissile](WCSharp.Missiles.HomingMissile.md 'WCSharp\.Missiles\.HomingMissile')

## HomingMissile\.TurnVelocityRad Property

The speed at which the missile can turn, expressed in radians per [SYSTEM\_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp\.Events\.PeriodicEvents\.SYSTEM\_INTERVAL') tick \(0\.03125\)\.

Alternatively, use [TurnRate](WCSharp.Missiles.HomingMissile.TurnRate.md 'WCSharp\.Missiles\.HomingMissile\.TurnRate') or [TurnPeriod](WCSharp.Missiles.HomingMissile.TurnPeriod.md 'WCSharp\.Missiles\.HomingMissile\.TurnPeriod').

```csharp
public float TurnVelocityRad { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')