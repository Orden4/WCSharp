#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers')

## ISmoothAction Interface

Smooth actions are executed separately, allowing for more fine\-grained timings\.

```csharp
public interface ISmoothAction : WCSharp.Timers.ITimerAction
```

Derived  
&#8627; [ISmoothDisposableAction](WCSharp.Timers.ISmoothDisposableAction.md 'WCSharp\.Timers\.ISmoothDisposableAction')

Implements [ITimerAction](WCSharp.Timers.ITimerAction.md 'WCSharp\.Timers\.ITimerAction')

| Properties | |
| :--- | :--- |
| [TimerRemaining](WCSharp.Timers.ISmoothAction.TimerRemaining.md 'WCSharp\.Timers\.ISmoothAction\.TimerRemaining') | The time left until the next tick\. |
