#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[Missile](WCSharp.Missiles.Missile.md 'WCSharp\.Missiles\.Missile')

## Missile\.OnCollision\(unit\) Method


Override this method if your missile has an effect that should trigger when colliding with another unit.

For this to be active, [CollisionRadius](WCSharp.Missiles.Missile.CollisionRadius.md 'WCSharp\.Missiles\.Missile\.CollisionRadius') must be greater than 0.

Note that there is no filter on this collision. This is called whenever it collides with anything not in [TargetsHit](WCSharp.Missiles.Missile.TargetsHit.md 'WCSharp\.Missiles\.Missile\.TargetsHit').

Before this method is called, the [unit](WCSharp.Missiles.Missile.OnCollision(WCSharp.Api.unit).md#WCSharp.Missiles.Missile.OnCollision(WCSharp.Api.unit).unit 'WCSharp\.Missiles\.Missile\.OnCollision\(WCSharp\.Api\.unit\)\.unit') is added to [TargetsHit](WCSharp.Missiles.Missile.TargetsHit.md 'WCSharp\.Missiles\.Missile\.TargetsHit').

```csharp
public virtual void OnCollision(WCSharp.Api.unit unit);
```
#### Parameters

<a name='WCSharp.Missiles.Missile.OnCollision(WCSharp.Api.unit).unit'></a>

`unit` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')