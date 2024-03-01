#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared').[Delay](WCSharp.Shared.Delay.md 'WCSharp.Shared.Delay')

## Delay.EnableDebug() Method

Call this method to automatically wrap your actions in a try/catch, so that exceptions that lead back to [Delay](WCSharp.Shared.Delay.md 'WCSharp.Shared.Delay') will automatically output information.  
  
It is recommended to use compilation time conditions to not call this on release mode.

```csharp
public static void EnableDebug();
```