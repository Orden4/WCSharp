#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[OrbitalMissile](WCSharp.Missiles.OrbitalMissile.md 'WCSharp\.Missiles\.OrbitalMissile')

## OrbitalMissile\.SpeedPerTick Property

The speed of the missile, expressed in units per [TickInterval](WCSharp.Missiles.MissileSystem.TickInterval.md 'WCSharp\.Missiles\.MissileSystem\.TickInterval') tick \(0\.03125\)\.

Use negative values to go clockwise.

Alternatively, use [Speed](WCSharp.Missiles.OrbitalMissile.Speed.md 'WCSharp\.Missiles\.OrbitalMissile\.Speed'), [OrbitalVelocityRad](WCSharp.Missiles.OrbitalMissile.OrbitalVelocityRad.md 'WCSharp\.Missiles\.OrbitalMissile\.OrbitalVelocityRad') or [OrbitalPeriod](WCSharp.Missiles.OrbitalMissile.OrbitalPeriod.md 'WCSharp\.Missiles\.OrbitalMissile\.OrbitalPeriod').

```csharp
public sealed override float SpeedPerTick { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')