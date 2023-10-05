#### [WCSharp.Buffs](README.md 'README')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs')

## Dispel Class

Represents a dispel attempt on a buff. Will be returned even if the dispel was resisted (i.e. no stacks were dispelled).

```csharp
public class Dispel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Dispel

| Properties | |
| :--- | :--- |
| [Buff](WCSharp.Buffs.Dispel.Buff.md 'WCSharp.Buffs.Dispel.Buff') | The buff that was (attempted to be) dispelled. |
| [BuffStacksDispelled](WCSharp.Buffs.Dispel.BuffStacksDispelled.md 'WCSharp.Buffs.Dispel.BuffStacksDispelled') | How many buff charges were dispelled. If negative, the charges were increased. |
| [DispelChargesConsumed](WCSharp.Buffs.Dispel.DispelChargesConsumed.md 'WCSharp.Buffs.Dispel.DispelChargesConsumed') | How many dispel charges were consumed. If negative, it added to the dispel charges remaining. |
| [FullyDispelled](WCSharp.Buffs.Dispel.FullyDispelled.md 'WCSharp.Buffs.Dispel.FullyDispelled') | Whether the buff was fully dispelled. |
