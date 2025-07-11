#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[Aura&lt;T&gt;](WCSharp.Buffs.Aura_T_.md 'WCSharp\.Buffs\.Aura\<T\>')

## Aura\<T\>\.CastingPlayer Property

The owner of the caster\. Automatically set on application\.

Does NOT update automatically! If this is desired, you can use [RegisterForOwnershipChanges\(\)](WCSharp.Buffs.BuffSystem.RegisterForOwnershipChanges().md 'WCSharp\.Buffs\.BuffSystem\.RegisterForOwnershipChanges\(\)').

```csharp
public WCSharp.Api.player CastingPlayer { get; set; }
```

Implements [CastingPlayer](WCSharp.Buffs.IAura.CastingPlayer.md 'WCSharp\.Buffs\.IAura\.CastingPlayer')

#### Property Value
[WCSharp\.Api\.player](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.player 'WCSharp\.Api\.player')