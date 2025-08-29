#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[BoundBuff](WCSharp.Buffs.BoundBuff.md 'WCSharp\.Buffs\.BoundBuff')

## BoundBuff\.BuffId Property

The WC3 buff ID to track\.

If the given buff is no longer on the unit, this buff instance will be disposed.

You do not need to set this if you use [BindAura\(int, int, int\)](WCSharp.Buffs.BoundBuff.BindAura(int,int,int).md 'WCSharp\.Buffs\.BoundBuff\.BindAura\(int, int, int\)') or [BindDummyCast\(int, int, int, int, player\)](WCSharp.Buffs.BoundBuff.BindDummyCast(int,int,int,int,WCSharp.Api.player).md 'WCSharp\.Buffs\.BoundBuff\.BindDummyCast\(int, int, int, int, WCSharp\.Api\.player\)').

```csharp
public int BuffId { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')