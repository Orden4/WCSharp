#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers')

## TimerSetCollectiveDisposable\<T\> Class

Timer that contains a set of [ICollectiveDisposableAction](WCSharp.Timers.ICollectiveDisposableAction.md 'WCSharp\.Timers\.ICollectiveDisposableAction') that will all be executed at once per timeout\.

```csharp
public class TimerSetCollectiveDisposable<T> : WCSharp.Timers.TimerSetCollective<T>
    where T : WCSharp.Timers.ICollectiveDisposableAction
```
#### Type parameters

<a name='WCSharp.Timers.TimerSetCollectiveDisposable_T_.T'></a>

`T`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [WCSharp\.Timers\.TimerSet&lt;](WCSharp.Timers.TimerSet_T_.md 'WCSharp\.Timers\.TimerSet\<T\>')[T](WCSharp.Timers.TimerSetCollectiveDisposable_T_.md#WCSharp.Timers.TimerSetCollectiveDisposable_T_.T 'WCSharp\.Timers\.TimerSetCollectiveDisposable\<T\>\.T')[&gt;](WCSharp.Timers.TimerSet_T_.md 'WCSharp\.Timers\.TimerSet\<T\>') &#129106; [WCSharp\.Timers\.TimerSetCollective&lt;](WCSharp.Timers.TimerSetCollective_T_.md 'WCSharp\.Timers\.TimerSetCollective\<T\>')[T](WCSharp.Timers.TimerSetCollectiveDisposable_T_.md#WCSharp.Timers.TimerSetCollectiveDisposable_T_.T 'WCSharp\.Timers\.TimerSetCollectiveDisposable\<T\>\.T')[&gt;](WCSharp.Timers.TimerSetCollective_T_.md 'WCSharp\.Timers\.TimerSetCollective\<T\>') &#129106; TimerSetCollectiveDisposable\<T\>

| Constructors | |
| :--- | :--- |
| [TimerSetCollectiveDisposable\(float\)](WCSharp.Timers.TimerSetCollectiveDisposable_T_.TimerSetCollectiveDisposable(float).md 'WCSharp\.Timers\.TimerSetCollectiveDisposable\<T\>\.TimerSetCollectiveDisposable\(float\)') | Creates a new timer set with the given parameters\. |

| Methods | |
| :--- | :--- |
| [Action\(\)](WCSharp.Timers.TimerSetCollectiveDisposable_T_.Action().md 'WCSharp\.Timers\.TimerSetCollectiveDisposable\<T\>\.Action\(\)') | Automatically called by the timer system whenever the actions timer expires\. |
