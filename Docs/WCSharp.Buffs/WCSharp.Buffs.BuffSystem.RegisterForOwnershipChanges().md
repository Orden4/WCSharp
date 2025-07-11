#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[BuffSystem](WCSharp.Buffs.BuffSystem.md 'WCSharp\.Buffs\.BuffSystem')

## BuffSystem\.RegisterForOwnershipChanges\(\) Method

By default, [CastingPlayer](WCSharp.Buffs.Buff.CastingPlayer.md 'WCSharp\.Buffs\.Buff\.CastingPlayer') and [TargetPlayer](WCSharp.Buffs.Buff.TargetPlayer.md 'WCSharp\.Buffs\.Buff\.TargetPlayer') are not updated when a unit changes owner\.

This adds an event to pass over all auras and update [CastingPlayer](WCSharp.Buffs.Buff.CastingPlayer.md 'WCSharp\.Buffs\.Buff\.CastingPlayer') and [TargetPlayer](WCSharp.Buffs.Buff.TargetPlayer.md 'WCSharp\.Buffs\.Buff\.TargetPlayer') on ownership changes.

This will ignore ownership changes of unit type 'xxxx' ([UNIT\_TYPE\_DUMMY](../WCSharp.Dummies/WCSharp.Dummies.DummySystem.UNIT_TYPE_DUMMY.md 'WCSharp\.Dummies\.DummySystem\.UNIT\_TYPE\_DUMMY')).

```csharp
public static void RegisterForOwnershipChanges();
```