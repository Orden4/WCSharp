#### [WCSharp.Missiles](index.md 'index')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles').[OrbitalMissile](WCSharp.Missiles.OrbitalMissile.md 'WCSharp.Missiles.OrbitalMissile')

## OrbitalMissile.SpeedPerTick Property

The speed of the missile, expressed in units per [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') tick (0.03125).  
  
Use negative values to go clockwise.  
  
This can be used instead of [OrbitalPeriod](WCSharp.Missiles.OrbitalMissile.OrbitalPeriod.md 'WCSharp.Missiles.OrbitalMissile.OrbitalPeriod'), and will ensure a consistent speed for the missile itself through [Range](WCSharp.Missiles.OrbitalMissile.Range.md 'WCSharp.Missiles.OrbitalMissile.Range') adjustments.

```csharp
public sealed override float SpeedPerTick { get; set; }
```

#### Property Value
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')