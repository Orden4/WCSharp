#### [WCSharp.Buffs](README.md 'README')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[Buff](WCSharp.Buffs.Buff.md 'WCSharp.Buffs.Buff')

## Buff.TargetPlayer Property

The owner of the target. Automatically set on application.  
  
Does NOT update automatically! If this is desired, you can use [RegisterForOwnershipChanges()](WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges().md 'WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges()').

```csharp
public WCSharp.Api.player TargetPlayer { get; set; }
```

#### Property Value
[WCSharp.Api.player](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.player 'WCSharp.Api.player')