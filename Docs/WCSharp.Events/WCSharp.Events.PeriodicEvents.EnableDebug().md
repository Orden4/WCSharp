### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[PeriodicEvents](WCSharp.Events.PeriodicEvents.md 'WCSharp.Events.PeriodicEvents')

## PeriodicEvents.EnableDebug() Method

Call this method to automatically wrap your actions in a try/catch, so that exceptions that lead back to [PeriodicEvents](WCSharp.Events.PeriodicEvents.md 'WCSharp.Events.PeriodicEvents') will automatically output  
information.  
  
It is recommended to use compilation time conditions to not call this on release mode.

```csharp
public static void EnableDebug();
```