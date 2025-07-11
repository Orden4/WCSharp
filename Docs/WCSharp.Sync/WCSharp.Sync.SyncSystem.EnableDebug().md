#### [WCSharp\.Sync](README.md 'README')
### [WCSharp\.Sync](WCSharp.Sync.md 'WCSharp\.Sync').[SyncSystem](WCSharp.Sync.SyncSystem.md 'WCSharp\.Sync\.SyncSystem')

## SyncSystem\.EnableDebug\(\) Method

Call this method to automatically wrap your actions in a try/catch, so that exceptions that lead back to the SyncSystem will automatically output information\.

It is recommended to use compilation time conditions to not call this on release mode.

```csharp
public static void EnableDebug();
```