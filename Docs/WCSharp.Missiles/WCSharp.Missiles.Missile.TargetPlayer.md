#### [WCSharp.Missiles](README.md 'README')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles').[Missile](WCSharp.Missiles.Missile.md 'WCSharp.Missiles.Missile')

## Missile.TargetPlayer Property

The owner of the target. Automatically set on launch.  
  
Does NOT update automatically! If this is desired, you can use [RegisterForOwnershipChanges()](WCSharp.Missiles.MissileSystem.RegisterForOwnershipChanges().md 'WCSharp.Missiles.MissileSystem.RegisterForOwnershipChanges()').

```csharp
public WCSharp.Api.player TargetPlayer { get; set; }
```

#### Property Value
[WCSharp.Api.player](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.player 'WCSharp.Api.player')