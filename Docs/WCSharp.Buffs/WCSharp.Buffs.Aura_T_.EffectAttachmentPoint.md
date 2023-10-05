#### [WCSharp.Buffs](README.md 'README')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[Aura&lt;T&gt;](WCSharp.Buffs.Aura_T_.md 'WCSharp.Buffs.Aura<T>')

## Aura<T>.EffectAttachmentPoint Property

The attachment point for the effect.  
  
If changed while the aura is already active, will destroy and recreate the effect at the desired attachment point.  
  
Defaults to origin.

```csharp
public string EffectAttachmentPoint { get; set; }
```

Implements [EffectAttachmentPoint](WCSharp.Buffs.IAura.EffectAttachmentPoint.md 'WCSharp.Buffs.IAura.EffectAttachmentPoint')

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')