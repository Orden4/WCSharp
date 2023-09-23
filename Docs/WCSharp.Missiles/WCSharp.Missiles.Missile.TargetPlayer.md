### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles').[Missile](WCSharp.Missiles.Missile.md 'WCSharp.Missiles.Missile')

## Missile.TargetPlayer Property

The owner of the target. Automatically set on launch.  
  
Does NOT update automatically! If this is desired, you can use [RegisterForOwnershipChanges()](WCSharp.Missiles.MissileSystem.RegisterForOwnershipChanges().md 'WCSharp.Missiles.MissileSystem.RegisterForOwnershipChanges()').

```csharp
public War3Api.Common.player TargetPlayer { get; set; }
```

#### Property Value
[War3Api.Common.player](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.player 'War3Api.Common.player')