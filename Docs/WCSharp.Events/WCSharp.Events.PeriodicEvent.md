### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events')

## PeriodicEvent Class

Represents a single periodic event that will invoke [Method](WCSharp.Events.PeriodicEvent.Method.md 'WCSharp.Events.PeriodicEvent.Method') every [Interval](WCSharp.Events.PeriodicEvent.Interval.md 'WCSharp.Events.PeriodicEvent.Interval').

```csharp
public class PeriodicEvent
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PeriodicEvent

| Constructors | |
| :--- | :--- |
| [PeriodicEvent(Func&lt;bool&gt;, double)](WCSharp.Events.PeriodicEvent.PeriodicEvent(System.Func_bool_,double).md 'WCSharp.Events.PeriodicEvent.PeriodicEvent(System.Func<bool>, double)') | Creates a new periodic event that will call the given method every interval.<br/>Must be added to [PeriodicEvents](WCSharp.Events.PeriodicEvents.md 'WCSharp.Events.PeriodicEvents') in order to be active. |

| Properties | |
| :--- | :--- |
| [Interval](WCSharp.Events.PeriodicEvent.Interval.md 'WCSharp.Events.PeriodicEvent.Interval') | Specifies the time in seconds of a single loop of this periodic event.. |
| [IntervalLeft](WCSharp.Events.PeriodicEvent.IntervalLeft.md 'WCSharp.Events.PeriodicEvent.IntervalLeft') | Indicates the time remaining until it will invoke [Method](WCSharp.Events.PeriodicEvent.Method.md 'WCSharp.Events.PeriodicEvent.Method'). |
| [Method](WCSharp.Events.PeriodicEvent.Method.md 'WCSharp.Events.PeriodicEvent.Method') | The function that will be invoked every [Interval](WCSharp.Events.PeriodicEvent.Interval.md 'WCSharp.Events.PeriodicEvent.Interval'). Return true for the event to be repeated. |
