### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff')

## Buff.Active Property

Indicates the active state of this buff. Setting this to false will cause it to be removed on the next update cycle (at most [SYSTEM_INTERVAL](../WCSharp.Events/WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') later).

```csharp
public bool Active { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')