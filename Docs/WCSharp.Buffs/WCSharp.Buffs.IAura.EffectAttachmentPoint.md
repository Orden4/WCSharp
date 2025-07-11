#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[IAura](WCSharp.Buffs.IAura.md 'WCSharp\.Buffs\.IAura')

## IAura\.EffectAttachmentPoint Property

The attachment point for the effect\.

If changed while the aura is already active, will destroy and recreate the effect at the desired attachment point.

Defaults to origin.

```csharp
string EffectAttachmentPoint { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')