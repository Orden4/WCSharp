#### [WCSharp.Missiles](index.md 'index')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles')

## MissileSystem Class

Tracks and runs all active [Missile](WCSharp.Missiles.Missile.md 'WCSharp.Missiles.Missile') instances.

```csharp
public static class MissileSystem
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MissileSystem

| Properties | |
| :--- | :--- |
| [Missiles](WCSharp.Missiles.MissileSystem.Missiles.md 'WCSharp.Missiles.MissileSystem.Missiles') | All active missiles. |

| Methods | |
| :--- | :--- |
| [Add(Missile)](WCSharp.Missiles.MissileSystem.Add(WCSharp.Missiles.Missile).md 'WCSharp.Missiles.MissileSystem.Add(WCSharp.Missiles.Missile)') | Adds the given [missile](WCSharp.Missiles.MissileSystem.Add(WCSharp.Missiles.Missile).md#WCSharp.Missiles.MissileSystem.Add(WCSharp.Missiles.Missile).missile 'WCSharp.Missiles.MissileSystem.Add(WCSharp.Missiles.Missile).missile') to the system. |
| [RegisterForOwnershipChanges()](WCSharp.Missiles.MissileSystem.RegisterForOwnershipChanges().md 'WCSharp.Missiles.MissileSystem.RegisterForOwnershipChanges()') | By default, [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp.Missiles.Missile.CastingPlayer') and [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp.Missiles.Missile.TargetPlayer') are not updated when a unit changes owner.<br/><br/><br/>This adds an event to pass over all missiles and update [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp.Missiles.Missile.CastingPlayer') and [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp.Missiles.Missile.TargetPlayer') on ownership changes.<br/><br/>This will ignore ownership changes of unit type 'xxxx' (WCSharp's dummy unit type). |
