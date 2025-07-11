#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[OrbitalMissile](WCSharp.Missiles.OrbitalMissile.md 'WCSharp\.Missiles\.OrbitalMissile')

## OrbitalMissile\.Range Property

The distance at which the [OrbitalMissile](WCSharp.Missiles.OrbitalMissile.md 'WCSharp\.Missiles\.OrbitalMissile') orbits from the origin\.

The speed of the missile after a range adjustment is determined by whether it was set via [Speed](WCSharp.Missiles.OrbitalMissile.Speed.md 'WCSharp\.Missiles\.OrbitalMissile\.Speed')/[SpeedPerTick](WCSharp.Missiles.OrbitalMissile.SpeedPerTick.md 'WCSharp\.Missiles\.OrbitalMissile\.SpeedPerTick')
            or [OrbitalPeriod](WCSharp.Missiles.OrbitalMissile.OrbitalPeriod.md 'WCSharp\.Missiles\.OrbitalMissile\.OrbitalPeriod')/[OrbitalVelocityRad](WCSharp.Missiles.OrbitalMissile.OrbitalVelocityRad.md 'WCSharp\.Missiles\.OrbitalMissile\.OrbitalVelocityRad').

```csharp
public float Range { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')