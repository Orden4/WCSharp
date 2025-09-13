#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers')

## TimerSetCollective\<T\> Class

Timer that contains a set of [ICollectiveAction](WCSharp.Timers.ICollectiveAction.md 'WCSharp\.Timers\.ICollectiveAction') that will all be executed at once per timeout\.

```csharp
public class TimerSetCollective<T> : WCSharp.Timers.TimerSet<T>
    where T : WCSharp.Timers.ICollectiveAction
```
#### Type parameters

<a name='WCSharp.Timers.TimerSetCollective_T_.T'></a>

`T`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [WCSharp\.Timers\.TimerSet&lt;](WCSharp.Timers.TimerSet_T_.md 'WCSharp\.Timers\.TimerSet\<T\>')[T](WCSharp.Timers.TimerSetCollective_T_.md#WCSharp.Timers.TimerSetCollective_T_.T 'WCSharp\.Timers\.TimerSetCollective\<T\>\.T')[&gt;](WCSharp.Timers.TimerSet_T_.md 'WCSharp\.Timers\.TimerSet\<T\>') &#129106; TimerSetCollective\<T\>

Derived  
&#8627; [TimerSetCollectiveDisposable&lt;T&gt;](WCSharp.Timers.TimerSetCollectiveDisposable_T_.md 'WCSharp\.Timers\.TimerSetCollectiveDisposable\<T\>')

| Constructors | |
| :--- | :--- |
| [TimerSetCollective\(float\)](WCSharp.Timers.TimerSetCollective_T_.TimerSetCollective(float).md 'WCSharp\.Timers\.TimerSetCollective\<T\>\.TimerSetCollective\(float\)') | Creates a new timer set with the given parameters\. |

| Methods | |
| :--- | :--- |
| [Action\(\)](WCSharp.Timers.TimerSetCollective_T_.Action().md 'WCSharp\.Timers\.TimerSetCollective\<T\>\.Action\(\)') | Automatically called by the timer system whenever the actions timer expires\. |
| [SetTimeout\(float\)](WCSharp.Timers.TimerSetCollective_T_.SetTimeout(float).md 'WCSharp\.Timers\.TimerSetCollective\<T\>\.SetTimeout\(float\)') | Changes the timeout to the given value\.   Note that the timing of the first tick after changing the timeout is unreliable. |
