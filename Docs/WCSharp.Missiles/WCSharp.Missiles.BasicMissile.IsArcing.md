#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[BasicMissile](WCSharp.Missiles.BasicMissile.md 'WCSharp\.Missiles\.BasicMissile')

## BasicMissile\.IsArcing Property

Whether the projectile is currently performing an arc motion\.

Automatically set at launch according to the [Arc](WCSharp.Missiles.BasicMissile.Arc.md 'WCSharp\.Missiles\.BasicMissile\.Arc') value.

This is automatically disabled if the target moves more than 50 units in a single [SYSTEM\_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp\.Events\.PeriodicEvents\.SYSTEM\_INTERVAL') tick (0.03125).

Warning: Setting this to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') mid-flight will cause the stored caster position to be changed to the missiles current position.

```csharp
public bool IsArcing { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')