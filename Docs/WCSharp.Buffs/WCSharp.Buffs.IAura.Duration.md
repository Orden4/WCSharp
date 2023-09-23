#### [WCSharp.Buffs](index.md 'index')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[IAura](WCSharp.Buffs.IAura.md 'WCSharp.Buffs.IAura')

## IAura.Duration Property

The duration in seconds of buffs applied by this aura.  
  
Unless you're making a pulsing aura, you will want the [Duration](WCSharp.Buffs.IAura.Duration.md 'WCSharp.Buffs.IAura.Duration') to be greater than the [SearchInterval](WCSharp.Buffs.IAura.SearchInterval.md 'WCSharp.Buffs.IAura.SearchInterval').

```csharp
float Duration { get; set; }
```

#### Property Value
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')