#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers')

## ITimerAction Interface

Interface for any kind of timer\-based action\.

```csharp
public interface ITimerAction
```

Derived  
&#8627; [ICollectiveAction](WCSharp.Timers.ICollectiveAction.md 'WCSharp\.Timers\.ICollectiveAction')  
&#8627; [ICollectiveDisposableAction](WCSharp.Timers.ICollectiveDisposableAction.md 'WCSharp\.Timers\.ICollectiveDisposableAction')  
&#8627; [ISmoothAction](WCSharp.Timers.ISmoothAction.md 'WCSharp\.Timers\.ISmoothAction')  
&#8627; [ISmoothDisposableAction](WCSharp.Timers.ISmoothDisposableAction.md 'WCSharp\.Timers\.ISmoothDisposableAction')  
&#8627; [Timer](WCSharp.Timers.Timer.md 'WCSharp\.Timers\.Timer')  
&#8627; [TimerSet&lt;T&gt;](WCSharp.Timers.TimerSet_T_.md 'WCSharp\.Timers\.TimerSet\<T\>')

| Properties | |
| :--- | :--- |
| [Active](WCSharp.Timers.ITimerAction.Active.md 'WCSharp\.Timers\.ITimerAction\.Active') | Used to indicate whether the timer should remain active or not\.   Set to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') automatically.  Set to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') to disable the loop. |

| Methods | |
| :--- | :--- |
| [Action\(\)](WCSharp.Timers.ITimerAction.Action().md 'WCSharp\.Timers\.ITimerAction\.Action\(\)') | Automatically called by the timer system whenever the actions timer expires\. |
