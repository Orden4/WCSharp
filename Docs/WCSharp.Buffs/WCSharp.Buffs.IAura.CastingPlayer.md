#### [WCSharp.Buffs](README.md 'README')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[IAura](WCSharp.Buffs.IAura.md 'WCSharp.Buffs.IAura')

## IAura.CastingPlayer Property

The owner of the caster. Automatically set on application.  
  
Does NOT update automatically! If this is desired, you can use [RegisterForOwnershipChanges()](WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges().md 'WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges()').

```csharp
WCSharp.Api.player CastingPlayer { get; set; }
```

#### Property Value
[WCSharp.Api.player](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.player 'WCSharp.Api.player')