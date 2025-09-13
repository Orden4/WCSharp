#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers')

## ISmoothDisposableAction Interface

Smooth actions are executed separately, allowing for more fine\-grained timings\.

Use this variant if you need to clean up when the action is ended.

```csharp
public interface ISmoothDisposableAction : WCSharp.Timers.ISmoothAction, WCSharp.Timers.ITimerAction
```

Implements [ISmoothAction](WCSharp.Timers.ISmoothAction.md 'WCSharp\.Timers\.ISmoothAction'), [ITimerAction](WCSharp.Timers.ITimerAction.md 'WCSharp\.Timers\.ITimerAction')

| Methods | |
| :--- | :--- |
| [Dispose\(\)](WCSharp.Timers.ISmoothDisposableAction.Dispose().md 'WCSharp\.Timers\.ISmoothDisposableAction\.Dispose\(\)') | Automatically called after [Active](WCSharp.Timers.ITimerAction.Active.md 'WCSharp\.Timers\.ITimerAction\.Active') is set to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\. |
