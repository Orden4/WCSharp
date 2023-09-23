#### [WCSharp.Missiles](index.md 'index')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles').[MissileSystem](WCSharp.Missiles.MissileSystem.md 'WCSharp.Missiles.MissileSystem')

## MissileSystem.RegisterForOwnershipChanges() Method

By default, [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp.Missiles.Missile.CastingPlayer') and [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp.Missiles.Missile.TargetPlayer') are not updated when a unit changes owner.  
  
This adds an event to pass over all missiles and update [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp.Missiles.Missile.CastingPlayer') and [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp.Missiles.Missile.TargetPlayer') on ownership changes.  
  
This will ignore ownership changes of unit type 'xxxx' (WCSharp's dummy unit type).

```csharp
public static void RegisterForOwnershipChanges();
```