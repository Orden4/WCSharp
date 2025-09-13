#### [WCSharp\.Timers](README.md 'README')

## WCSharp\.Timers Namespace

| Classes | |
| :--- | :--- |
| [Timer](WCSharp.Timers.Timer.md 'WCSharp\.Timers\.Timer') | A timer dedicated to a single action\. |
| [TimerSet&lt;T&gt;](WCSharp.Timers.TimerSet_T_.md 'WCSharp\.Timers\.TimerSet\<T\>') | The base type for all timer sets\. |
| [TimerSetCollective&lt;T&gt;](WCSharp.Timers.TimerSetCollective_T_.md 'WCSharp\.Timers\.TimerSetCollective\<T\>') | Timer that contains a set of [ICollectiveAction](WCSharp.Timers.ICollectiveAction.md 'WCSharp\.Timers\.ICollectiveAction') that will all be executed at once per timeout\. |
| [TimerSetCollectiveDisposable&lt;T&gt;](WCSharp.Timers.TimerSetCollectiveDisposable_T_.md 'WCSharp\.Timers\.TimerSetCollectiveDisposable\<T\>') | Timer that contains a set of [ICollectiveDisposableAction](WCSharp.Timers.ICollectiveDisposableAction.md 'WCSharp\.Timers\.ICollectiveDisposableAction') that will all be executed at once per timeout\. |
| [TimerSetSmooth&lt;T&gt;](WCSharp.Timers.TimerSetSmooth_T_.md 'WCSharp\.Timers\.TimerSetSmooth\<T\>') | Timer that contains a set of [ISmoothAction](WCSharp.Timers.ISmoothAction.md 'WCSharp\.Timers\.ISmoothAction')\.   Each action has its own individual timeout. |
| [TimerSetSmoothDisposable&lt;T&gt;](WCSharp.Timers.TimerSetSmoothDisposable_T_.md 'WCSharp\.Timers\.TimerSetSmoothDisposable\<T\>') | Timer that contains a set of [ISmoothDisposableAction](WCSharp.Timers.ISmoothDisposableAction.md 'WCSharp\.Timers\.ISmoothDisposableAction')\.   Each action has its own individual timeout. |
| [TimerSystem](WCSharp.Timers.TimerSystem.md 'WCSharp\.Timers\.TimerSystem') | System responsible for bundling timers together in an efficient manner\. |

| Interfaces | |
| :--- | :--- |
| [ICollectiveAction](WCSharp.Timers.ICollectiveAction.md 'WCSharp\.Timers\.ICollectiveAction') | Collective actions are executed all at the same time whenever their timer expires\. |
| [ICollectiveDisposableAction](WCSharp.Timers.ICollectiveDisposableAction.md 'WCSharp\.Timers\.ICollectiveDisposableAction') | Collective actions are executed all at the same time whenever their timer expires\.   Use this variant if you need to clean up when the action is ended. |
| [ISmoothAction](WCSharp.Timers.ISmoothAction.md 'WCSharp\.Timers\.ISmoothAction') | Smooth actions are executed separately, allowing for more fine\-grained timings\. |
| [ISmoothDisposableAction](WCSharp.Timers.ISmoothDisposableAction.md 'WCSharp\.Timers\.ISmoothDisposableAction') | Smooth actions are executed separately, allowing for more fine\-grained timings\.   Use this variant if you need to clean up when the action is ended. |
| [ITimerAction](WCSharp.Timers.ITimerAction.md 'WCSharp\.Timers\.ITimerAction') | Interface for any kind of timer\-based action\. |

| Delegates | |
| :--- | :--- |
| [TickIntervalChangedEventHandler\(float, float\)](WCSharp.Timers.TickIntervalChangedEventHandler(float,float).md 'WCSharp\.Timers\.TickIntervalChangedEventHandler\(float, float\)') | Delegate for responding to the tick interval of a timer being changed\. |
