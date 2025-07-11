#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[BoundBuff](WCSharp.Buffs.BoundBuff.md 'WCSharp\.Buffs\.BoundBuff')

## BoundBuff\.BindLeeway Property

Used to prevent the buff from being immediately dropped\. Intended to give some leeway for the dummy\-based bind\.

This is decreased by 1 every [SYSTEM\_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp\.Events\.PeriodicEvents\.SYSTEM\_INTERVAL'), once it becomes 0 or less it will remove this buff if the in-game buff is not present.

Automatically set to 0 once it detects the buff on the target.

Defaults to 8 (0.25s).

```csharp
public int BindLeeway { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')