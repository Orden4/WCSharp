#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[CurveMissile](WCSharp.Missiles.CurveMissile.md 'WCSharp\.Missiles\.CurveMissile')

## CurveMissile\.IsArcingOrCurving Property

Whether the projectile is currently performing an arc or curve motion\.

Automatically set at launch according to the [Arc](WCSharp.Missiles.CurveMissile.Arc.md 'WCSharp\.Missiles\.CurveMissile\.Arc') and [Curve](WCSharp.Missiles.CurveMissile.Curve.md 'WCSharp\.Missiles\.CurveMissile\.Curve')/[CurveRad](WCSharp.Missiles.CurveMissile.CurveRad.md 'WCSharp\.Missiles\.CurveMissile\.CurveRad') value.

This is automatically disabled if the target moves more than 50 units in a single [TickInterval](WCSharp.Missiles.MissileSystem.TickInterval.md 'WCSharp\.Missiles\.MissileSystem\.TickInterval') tick (0.03125).

Warning: Setting this to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') mid-flight will cause the stored caster position to be changed to the missiles current position.

```csharp
public bool IsArcingOrCurving { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')