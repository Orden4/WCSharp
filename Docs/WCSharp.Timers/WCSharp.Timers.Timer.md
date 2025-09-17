#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers')

## Timer Class

A timer dedicated to a single action\.

```csharp
public class Timer : WCSharp.Timers.ITimerAction
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Timer

Implements [ITimerAction](WCSharp.Timers.ITimerAction.md 'WCSharp\.Timers\.ITimerAction')

| Constructors | |
| :--- | :--- |
| [Timer\(Action&lt;Timer&gt;, float\)](WCSharp.Timers.Timer.Timer(System.Action_WCSharp.Timers.Timer_,float).md 'WCSharp\.Timers\.Timer\.Timer\(System\.Action\<WCSharp\.Timers\.Timer\>, float\)') | Creates a new timer\.   Use [Add\(Timer\)](WCSharp.Timers.TimerSystem.Add.md#WCSharp.Timers.TimerSystem.Add(WCSharp.Timers.Timer) 'WCSharp\.Timers\.TimerSystem\.Add\(WCSharp\.Timers\.Timer\)') to activate. |

| Properties | |
| :--- | :--- |
| [Active](WCSharp.Timers.Timer.Active.md 'WCSharp\.Timers\.Timer\.Active') | Used to indicate whether the timer should remain active or not\.   Set to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') automatically.  Set to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') to disable the loop. |
| [Timeout](WCSharp.Timers.Timer.Timeout.md 'WCSharp\.Timers\.Timer\.Timeout') | The time interval per execution\. |
| [TimerAction](WCSharp.Timers.Timer.TimerAction.md 'WCSharp\.Timers\.Timer\.TimerAction') | The action to be executed when the timer expires\. |

| Methods | |
| :--- | :--- |
| [Action\(\)](WCSharp.Timers.Timer.Action().md 'WCSharp\.Timers\.Timer\.Action\(\)') | Automatically called by the timer system whenever the actions timer expires\. |
| [SetTimeout\(float\)](WCSharp.Timers.Timer.SetTimeout(float).md 'WCSharp\.Timers\.Timer\.SetTimeout\(float\)') | Changes the timeout to the given value\.   Note that the timing of the first tick after changing the timeout is unreliable. |
