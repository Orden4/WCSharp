### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events')

## PeriodicEvents Class

Keeps track of all periodic events. The system runs at an interval defined by [SYSTEM_INTERVAL](WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') (0.03125).

```csharp
public static class PeriodicEvents
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PeriodicEvents

| Fields | |
| :--- | :--- |
| [SYSTEM_INTERVAL](WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') | The speed at which the system operates. |

| Methods | |
| :--- | :--- |
| [AddPeriodicEvent(Func&lt;bool&gt;, double)](WCSharp.Events.PeriodicEvents.AddPeriodicEvent(System.Func_bool_,double).md 'WCSharp.Events.PeriodicEvents.AddPeriodicEvent(System.Func<bool>, double)') | Adds the given method to the periodic system. In most cases, you can ignore the return value. |
| [AddPeriodicEvent(PeriodicEvent)](WCSharp.Events.PeriodicEvents.AddPeriodicEvent(WCSharp.Events.PeriodicEvent).md 'WCSharp.Events.PeriodicEvents.AddPeriodicEvent(WCSharp.Events.PeriodicEvent)') | Shorthand in case you already have an existing PeriodicEvent to resume. |
| [EnableDebug()](WCSharp.Events.PeriodicEvents.EnableDebug().md 'WCSharp.Events.PeriodicEvents.EnableDebug()') | Call this method to automatically wrap your actions in a try/catch, so that exceptions that lead back to [PeriodicEvents](WCSharp.Events.PeriodicEvents.md 'WCSharp.Events.PeriodicEvents') will automatically output<br/>information.<br/><br/><br/>It is recommended to use compilation time conditions to not call this on release mode. |
