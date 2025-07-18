#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[MomentumMissile](WCSharp.Missiles.MomentumMissile.md 'WCSharp\.Missiles\.MomentumMissile')

## MomentumMissile\.AccelerationPerTick Property

The acceleration in units per [SYSTEM\_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp\.Events\.PeriodicEvents\.SYSTEM\_INTERVAL') \(0\.03125\)\.

This is used to make adjustments to the trajectory.

Alternatively, use [Acceleration](WCSharp.Missiles.MomentumMissile.Acceleration.md 'WCSharp\.Missiles\.MomentumMissile\.Acceleration').

```csharp
public float AccelerationPerTick { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')