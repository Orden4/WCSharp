#### [WCSharp.Buffs](README.md 'README')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs')

## AuraSystem Class

Tracks and runs all active [IAura](WCSharp.Buffs.IAura.md 'WCSharp.Buffs.IAura') instances.

```csharp
public static class AuraSystem
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; AuraSystem

| Properties | |
| :--- | :--- |
| [Auras](WCSharp.Buffs.AuraSystem.Auras.md 'WCSharp.Buffs.AuraSystem.Auras') | All active buffs. |

| Methods | |
| :--- | :--- |
| [Add(IAura)](WCSharp.Buffs.AuraSystem.Add(WCSharp.Buffs.IAura).md 'WCSharp.Buffs.AuraSystem.Add(WCSharp.Buffs.IAura)') | Adds the given [aura](WCSharp.Buffs.AuraSystem.Add(WCSharp.Buffs.IAura).md#WCSharp.Buffs.AuraSystem.Add(WCSharp.Buffs.IAura).aura 'WCSharp.Buffs.AuraSystem.Add(WCSharp.Buffs.IAura).aura') to the system. |
| [RegisterForOwnershipChanges()](WCSharp.Buffs.AuraSystem.RegisterForOwnershipChanges().md 'WCSharp.Buffs.AuraSystem.RegisterForOwnershipChanges()') | By default, [CastingPlayer](WCSharp.Buffs.IAura.CastingPlayer.md 'WCSharp.Buffs.IAura.CastingPlayer') is not updated when a unit changes owner.<br/><br/><br/>This adds an event to pass over all auras and update [CastingPlayer](WCSharp.Buffs.IAura.CastingPlayer.md 'WCSharp.Buffs.IAura.CastingPlayer') on ownership changes.<br/><br/>This will ignore ownership changes of unit type 'xxxx' ([UNIT_TYPE_DUMMY](../WCSharp.Dummies/WCSharp.Dummies.DummySystem.UNIT_TYPE_DUMMY.md 'WCSharp.Dummies.DummySystem.UNIT_TYPE_DUMMY')). |
