#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[BasicMissile](WCSharp.Missiles.BasicMissile.md 'WCSharp\.Missiles\.BasicMissile')

## BasicMissile\.TargetZ Property

The Z coordinate that this missile is moving towards\.

While [Target](WCSharp.Missiles.Missile.Target.md 'WCSharp\.Missiles\.Missile\.Target') is alive, this will automatically be updated.

By default, this is equal to UnitFlyHeight + [TargetImpactZ](WCSharp.Missiles.Missile.TargetImpactZ.md 'WCSharp\.Missiles\.Missile\.TargetImpactZ') + GetLocationZ.

```csharp
public sealed override float TargetZ { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')