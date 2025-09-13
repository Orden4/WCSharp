#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers')

## TimerSystem Class

System responsible for bundling timers together in an efficient manner\.

```csharp
public static class TimerSystem
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; TimerSystem

| Fields | |
| :--- | :--- |
| [DEFAULT\_TICK\_INTERVAL](WCSharp.Timers.TimerSystem.DEFAULT_TICK_INTERVAL.md 'WCSharp\.Timers\.TimerSystem\.DEFAULT\_TICK\_INTERVAL') | The default interval between each tick of the system, equal to 32 ticks per second\. |

| Properties | |
| :--- | :--- |
| [TickInterval](WCSharp.Timers.TimerSystem.TickInterval.md 'WCSharp\.Timers\.TimerSystem\.TickInterval') | The current interval between each tick of the system\.   Use [SetTickInterval\(float\)](WCSharp.Timers.TimerSystem.SetTickInterval(float).md 'WCSharp\.Timers\.TimerSystem\.SetTickInterval\(float\)') to adjust. |

| Methods | |
| :--- | :--- |
| [Add\(Action&lt;Timer&gt;, float\)](WCSharp.Timers.TimerSystem.Add.md#WCSharp.Timers.TimerSystem.Add(System.Action_WCSharp.Timers.Timer_,float) 'WCSharp\.Timers\.TimerSystem\.Add\(System\.Action\<WCSharp\.Timers\.Timer\>, float\)') | Creates a new dedicated timer for the given action\. |
| [Add\(Timer\)](WCSharp.Timers.TimerSystem.Add.md#WCSharp.Timers.TimerSystem.Add(WCSharp.Timers.Timer) 'WCSharp\.Timers\.TimerSystem\.Add\(WCSharp\.Timers\.Timer\)') | Reactivates the given timer\. |
| [EnableDebug\(\)](WCSharp.Timers.TimerSystem.EnableDebug().md 'WCSharp\.Timers\.TimerSystem\.EnableDebug\(\)') | Call this method to automatically wrap your actions in a try/catch, so that exceptions that lead back to [TimerSystem](WCSharp.Timers.TimerSystem.md 'WCSharp\.Timers\.TimerSystem') will automatically output information\.   It is recommended to use compilation time conditions to not call this on release mode. |
| [SetTickInterval\(float\)](WCSharp.Timers.TimerSystem.SetTickInterval(float).md 'WCSharp\.Timers\.TimerSystem\.SetTickInterval\(float\)') | Changes [TickInterval](WCSharp.Timers.TimerSystem.TickInterval.md 'WCSharp\.Timers\.TimerSystem\.TickInterval') to [tickInterval](WCSharp.Timers.TimerSystem.SetTickInterval(float).md#WCSharp.Timers.TimerSystem.SetTickInterval(float).tickInterval 'WCSharp\.Timers\.TimerSystem\.SetTickInterval\(float\)\.tickInterval') after a 0 second delay\.   It is strongly recommended to use multiples of 2 as tick interval (e.g. 1/16, 1/32, 1/64, etc).  Setting this to 0 or less will pause the system. |

| Events | |
| :--- | :--- |
| [OnTickIntervalChanged](WCSharp.Timers.TimerSystem.OnTickIntervalChanged.md 'WCSharp\.Timers\.TimerSystem\.OnTickIntervalChanged') | Event for responding to changes in the tick interval\. |
