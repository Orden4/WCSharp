#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers')

## TimerSetSmoothDisposable\<T\> Class

Timer that contains a set of [ISmoothDisposableAction](WCSharp.Timers.ISmoothDisposableAction.md 'WCSharp\.Timers\.ISmoothDisposableAction')\.

Each action has its own individual timeout.

```csharp
public class TimerSetSmoothDisposable<T> : WCSharp.Timers.TimerSetSmooth<T>
    where T : class, WCSharp.Timers.ISmoothDisposableAction
```
#### Type parameters

<a name='WCSharp.Timers.TimerSetSmoothDisposable_T_.T'></a>

`T`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [WCSharp\.Timers\.TimerSet&lt;](WCSharp.Timers.TimerSet_T_.md 'WCSharp\.Timers\.TimerSet\<T\>')[T](WCSharp.Timers.TimerSetSmoothDisposable_T_.md#WCSharp.Timers.TimerSetSmoothDisposable_T_.T 'WCSharp\.Timers\.TimerSetSmoothDisposable\<T\>\.T')[&gt;](WCSharp.Timers.TimerSet_T_.md 'WCSharp\.Timers\.TimerSet\<T\>') &#129106; [WCSharp\.Timers\.TimerSetSmooth&lt;](WCSharp.Timers.TimerSetSmooth_T_.md 'WCSharp\.Timers\.TimerSetSmooth\<T\>')[T](WCSharp.Timers.TimerSetSmoothDisposable_T_.md#WCSharp.Timers.TimerSetSmoothDisposable_T_.T 'WCSharp\.Timers\.TimerSetSmoothDisposable\<T\>\.T')[&gt;](WCSharp.Timers.TimerSetSmooth_T_.md 'WCSharp\.Timers\.TimerSetSmooth\<T\>') &#129106; TimerSetSmoothDisposable\<T\>

| Constructors | |
| :--- | :--- |
| [TimerSetSmoothDisposable\(float, Nullable&lt;float&gt;\)](WCSharp.Timers.TimerSetSmoothDisposable_T_.TimerSetSmoothDisposable(float,System.Nullable_float_).md 'WCSharp\.Timers\.TimerSetSmoothDisposable\<T\>\.TimerSetSmoothDisposable\(float, System\.Nullable\<float\>\)') | Creates a new timer set with the given parameters\. |

| Methods | |
| :--- | :--- |
| [Action\(\)](WCSharp.Timers.TimerSetSmoothDisposable_T_.Action().md 'WCSharp\.Timers\.TimerSetSmoothDisposable\<T\>\.Action\(\)') | Automatically called by the timer system whenever the actions timer expires\. |
