#### [WCSharp.Missiles](index.md 'index')
### [WCSharp.Missiles](WCSharp.Missiles.md 'WCSharp.Missiles').[Missile](WCSharp.Missiles.Missile.md 'WCSharp.Missiles.Missile')

## Missile.OnImpact() Method

Override this method if your missile has an impact effect.  
  
[Active](WCSharp.Missiles.Missile.Active.md 'WCSharp.Missiles.Missile.Active') is automatically set to false prior to calling this method. If you do not want the missile to end, you need to set [Active](WCSharp.Missiles.Missile.Active.md 'WCSharp.Missiles.Missile.Active') back to true.

```csharp
public virtual void OnImpact();
```