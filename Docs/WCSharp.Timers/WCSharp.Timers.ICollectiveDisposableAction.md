#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers')

## ICollectiveDisposableAction Interface

Collective actions are executed all at the same time whenever their timer expires\.

Use this variant if you need to clean up when the action is ended.

```csharp
public interface ICollectiveDisposableAction : WCSharp.Timers.ICollectiveAction, WCSharp.Timers.ITimerAction
```

Implements [ICollectiveAction](WCSharp.Timers.ICollectiveAction.md 'WCSharp\.Timers\.ICollectiveAction'), [ITimerAction](WCSharp.Timers.ITimerAction.md 'WCSharp\.Timers\.ITimerAction')

| Methods | |
| :--- | :--- |
| [Dispose\(\)](WCSharp.Timers.ICollectiveDisposableAction.Dispose().md 'WCSharp\.Timers\.ICollectiveDisposableAction\.Dispose\(\)') | Automatically called after [Active](WCSharp.Timers.ITimerAction.Active.md 'WCSharp\.Timers\.ITimerAction\.Active') is set to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\. |
