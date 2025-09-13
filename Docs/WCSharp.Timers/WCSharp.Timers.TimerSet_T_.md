#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers')

## TimerSet\<T\> Class

The base type for all timer sets\.

```csharp
public abstract class TimerSet<T> : WCSharp.Timers.ITimerAction
    where T : WCSharp.Timers.ITimerAction
```
#### Type parameters

<a name='WCSharp.Timers.TimerSet_T_.T'></a>

`T`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; TimerSet\<T\>

Derived  
&#8627; [TimerSetCollective&lt;T&gt;](WCSharp.Timers.TimerSetCollective_T_.md 'WCSharp\.Timers\.TimerSetCollective\<T\>')  
&#8627; [TimerSetSmooth&lt;T&gt;](WCSharp.Timers.TimerSetSmooth_T_.md 'WCSharp\.Timers\.TimerSetSmooth\<T\>')

Implements [ITimerAction](WCSharp.Timers.ITimerAction.md 'WCSharp\.Timers\.ITimerAction')

| Properties | |
| :--- | :--- |
| [Actions](WCSharp.Timers.TimerSet_T_.Actions.md 'WCSharp\.Timers\.TimerSet\<T\>\.Actions') | The currently active actions within this timer set\. |
| [Active](WCSharp.Timers.TimerSet_T_.Active.md 'WCSharp\.Timers\.TimerSet\<T\>\.Active') | Used to indicate whether the timer should remain active or not\.   Set to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') automatically.  Set to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') to disable the loop. |
| [Timeout](WCSharp.Timers.TimerSet_T_.Timeout.md 'WCSharp\.Timers\.TimerSet\<T\>\.Timeout') | The time in seconds after which the timer will execute\. |

| Methods | |
| :--- | :--- |
| [Action\(\)](WCSharp.Timers.TimerSet_T_.Action().md 'WCSharp\.Timers\.TimerSet\<T\>\.Action\(\)') | Automatically called by the timer system whenever the actions timer expires\. |
| [Add\(T\)](WCSharp.Timers.TimerSet_T_.Add(T).md 'WCSharp\.Timers\.TimerSet\<T\>\.Add\(T\)') | Will add the given action to this timer set, tracking it for execution whenever the timeout expires\. |
| [SetTimeout\(float\)](WCSharp.Timers.TimerSet_T_.SetTimeout(float).md 'WCSharp\.Timers\.TimerSet\<T\>\.SetTimeout\(float\)') | Changes the timeout of the timer set\.   See the individual implementations on more details, as each type of timer set has its own quirks to doing this. |
