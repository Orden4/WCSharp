#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers').[TimerSystem](WCSharp.Timers.TimerSystem.md 'WCSharp\.Timers\.TimerSystem')

## TimerSystem\.EnableDebug\(\) Method

Call this method to automatically wrap your actions in a try/catch, so that exceptions that lead back to [TimerSystem](WCSharp.Timers.TimerSystem.md 'WCSharp\.Timers\.TimerSystem') will automatically output
information\.

It is recommended to use compilation time conditions to not call this on release mode.

```csharp
public static void EnableDebug();
```