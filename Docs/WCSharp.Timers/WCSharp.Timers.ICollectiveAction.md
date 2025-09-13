#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers')

## ICollectiveAction Interface

Collective actions are executed all at the same time whenever their timer expires\.

```csharp
public interface ICollectiveAction : WCSharp.Timers.ITimerAction
```

Derived  
&#8627; [ICollectiveDisposableAction](WCSharp.Timers.ICollectiveDisposableAction.md 'WCSharp\.Timers\.ICollectiveDisposableAction')

Implements [ITimerAction](WCSharp.Timers.ITimerAction.md 'WCSharp\.Timers\.ITimerAction')