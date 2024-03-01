#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared')

## Delay Class

Basic helper class to create 0 second delays on executing actions.  
  
This can be used to circumvent various issues, such as unit AI locking up if you give them a new order at the same time as they start an attack.

```csharp
public static class Delay
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Delay

| Methods | |
| :--- | :--- |
| [Add(Action)](WCSharp.Shared.Delay.Add(System.Action).md 'WCSharp.Shared.Delay.Add(System.Action)') | <br/><br/>Will execute the given action after a 0 second delay, which translates to a single frame.<br/><br/>This can be used to circumvent various issues, such as unit AI locking up if you give them a new order at the same time as they start an attack. |
| [EnableDebug()](WCSharp.Shared.Delay.EnableDebug().md 'WCSharp.Shared.Delay.EnableDebug()') | Call this method to automatically wrap your actions in a try/catch, so that exceptions that lead back to [Delay](WCSharp.Shared.Delay.md 'WCSharp.Shared.Delay') will automatically output information.<br/><br/><br/>It is recommended to use compilation time conditions to not call this on release mode. |
