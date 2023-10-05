#### [WCSharp.Missiles](README.md 'README')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles').[Missile](WCSharp.Missiles.Missile.md 'WCSharp.Missiles.Missile')

## Missile.TargetsHit Property

  
Keeps track of all units collided with thus far.  
  
Null if [CollisionRadius](WCSharp.Missiles.Missile.CollisionRadius.md 'WCSharp.Missiles.Missile.CollisionRadius') has never been set to a value greater than 0.  
  
Removing a unit from this means [OnCollision(unit)](WCSharp.Missiles.Missile.OnCollision(War3Api.Common.unit).md 'WCSharp.Missiles.Missile.OnCollision(War3Api.Common.unit)') will trigger for that unit once more.

```csharp
public System.Collections.Generic.HashSet<War3Api.Common.unit> TargetsHit { get; set; }
```

#### Property Value
[System.Collections.Generic.HashSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')[War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')