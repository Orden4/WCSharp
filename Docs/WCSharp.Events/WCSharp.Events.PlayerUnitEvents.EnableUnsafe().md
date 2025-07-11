#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp.Events.PlayerUnitEvents')

## PlayerUnitEvents.EnableUnsafe() Method

Call this method to avoid guarding against exceptions within your events.  
  
This can improve performance and debug information, but can cause very unpredictable errors when exceptions do occur.

```csharp
public static void EnableUnsafe();
```