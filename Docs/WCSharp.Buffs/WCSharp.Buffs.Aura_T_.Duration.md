### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[Aura&lt;T&gt;](WCSharp.Buffs.Aura_T_.md 'WCSharp.Buffs.Aura<T>')

## Aura<T>.Duration Property

The duration in seconds of buffs applied by this aura. Defaults to 3.1.  
  
Unless you're making a pulsing aura, you will want the [Duration](WCSharp.Buffs.Aura_T_.Duration.md 'WCSharp.Buffs.Aura<T>.Duration') to be greater than the [SearchInterval](WCSharp.Buffs.Aura_T_.SearchInterval.md 'WCSharp.Buffs.Aura<T>.SearchInterval').

```csharp
public float Duration { get; set; }
```

Implements [Duration](WCSharp.Buffs.IAura.Duration.md 'WCSharp.Buffs.IAura.Duration')

#### Property Value
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')