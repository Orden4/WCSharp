#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[Missile](WCSharp.Missiles.Missile.md 'WCSharp\.Missiles\.Missile')

## Missile\.TargetsHit Property


Keeps track of all units collided with thus far.

Null if [CollisionRadius](WCSharp.Missiles.Missile.CollisionRadius.md 'WCSharp\.Missiles\.Missile\.CollisionRadius') has never been set to a value greater than 0.

Removing a unit from this means [OnCollision\(unit\)](WCSharp.Missiles.Missile.OnCollision(WCSharp.Api.unit).md 'WCSharp\.Missiles\.Missile\.OnCollision\(WCSharp\.Api\.unit\)') will trigger for that unit once more.

```csharp
public System.Collections.Generic.HashSet<WCSharp.Api.unit> TargetsHit { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')