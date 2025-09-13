#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[Buff](WCSharp.Buffs.Buff.md 'WCSharp\.Buffs\.Buff')

## Buff\.Active Property

Indicates the active state of this buff\. Setting this to false will cause it to be removed on the next update cycle \(at most [TickInterval](WCSharp.Buffs.BuffSystem.TickInterval.md 'WCSharp\.Buffs\.BuffSystem\.TickInterval') later\)\.

```csharp
public bool Active { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')