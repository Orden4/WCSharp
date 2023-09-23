### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[AuraSystem](WCSharp.Buffs.AuraSystem.md 'WCSharp.Buffs.AuraSystem')

## AuraSystem.RegisterForOwnershipChanges() Method

By default, [CastingPlayer](WCSharp.Buffs.IAura.CastingPlayer.md 'WCSharp.Buffs.IAura.CastingPlayer') is not updated when a unit changes owner.  
  
This adds an event to pass over all auras and update [CastingPlayer](WCSharp.Buffs.IAura.CastingPlayer.md 'WCSharp.Buffs.IAura.CastingPlayer') on ownership changes.  
  
This will ignore ownership changes of unit type 'xxxx' ([UNIT_TYPE_DUMMY](../WCSharp.Dummies/WCSharp.Dummies.DummySystem.UNIT_TYPE_DUMMY.md 'WCSharp.Dummies.DummySystem.UNIT_TYPE_DUMMY')).

```csharp
public static void RegisterForOwnershipChanges();
```