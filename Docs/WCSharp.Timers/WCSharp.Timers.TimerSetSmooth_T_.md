#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers')

## TimerSetSmooth\<T\> Class

Timer that contains a set of [ISmoothAction](WCSharp.Timers.ISmoothAction.md 'WCSharp\.Timers\.ISmoothAction')\.

Each action has its own individual timeout.

```csharp
public class TimerSetSmooth<T> : WCSharp.Timers.TimerSet<T>
    where T : WCSharp.Timers.ISmoothAction
```
#### Type parameters

<a name='WCSharp.Timers.TimerSetSmooth_T_.T'></a>

`T`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [WCSharp\.Timers\.TimerSet&lt;](WCSharp.Timers.TimerSet_T_.md 'WCSharp\.Timers\.TimerSet\<T\>')[T](WCSharp.Timers.TimerSetSmooth_T_.md#WCSharp.Timers.TimerSetSmooth_T_.T 'WCSharp\.Timers\.TimerSetSmooth\<T\>\.T')[&gt;](WCSharp.Timers.TimerSet_T_.md 'WCSharp\.Timers\.TimerSet\<T\>') &#129106; TimerSetSmooth\<T\>

Derived  
&#8627; [TimerSetSmoothDisposable&lt;T&gt;](WCSharp.Timers.TimerSetSmoothDisposable_T_.md 'WCSharp\.Timers\.TimerSetSmoothDisposable\<T\>')

| Constructors | |
| :--- | :--- |
| [TimerSetSmooth\(float, Nullable&lt;float&gt;\)](WCSharp.Timers.TimerSetSmooth_T_.TimerSetSmooth(float,System.Nullable_float_).md 'WCSharp\.Timers\.TimerSetSmooth\<T\>\.TimerSetSmooth\(float, System\.Nullable\<float\>\)') | Creates a new timer set with the given parameters\. |

| Properties | |
| :--- | :--- |
| [RootTimeout](WCSharp.Timers.TimerSetSmooth_T_.RootTimeout.md 'WCSharp\.Timers\.TimerSetSmooth\<T\>\.RootTimeout') | The time interval of the smoothing timer\.   All actions internally tick down in increments specified by this property.  For example, setting timeout to 1 and root timeout to 0.125 will make the timers expire every second,             with each check being 0.125 seconds apart. |

| Methods | |
| :--- | :--- |
| [Action\(\)](WCSharp.Timers.TimerSetSmooth_T_.Action().md 'WCSharp\.Timers\.TimerSetSmooth\<T\>\.Action\(\)') | Automatically called by the timer system whenever the actions timer expires\. |
| [SetRootTimeout\(Nullable&lt;float&gt;\)](WCSharp.Timers.TimerSetSmooth_T_.SetRootTimeout(System.Nullable_float_).md 'WCSharp\.Timers\.TimerSetSmooth\<T\>\.SetRootTimeout\(System\.Nullable\<float\>\)') | Changes the root timeout of the smoothing timer\.   See [RootTimeout](WCSharp.Timers.TimerSetSmooth_T_.RootTimeout.md 'WCSharp\.Timers\.TimerSetSmooth\<T\>\.RootTimeout') for more info.  Leaving this at default ([null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')) will make it use the highest precision ([TickInterval](WCSharp.Timers.TimerSystem.TickInterval.md 'WCSharp\.Timers\.TimerSystem\.TickInterval')) at all times. |
| [SetTimeout\(float\)](WCSharp.Timers.TimerSetSmooth_T_.SetTimeout(float).md 'WCSharp\.Timers\.TimerSetSmooth\<T\>\.SetTimeout\(float\)') | Changes the timeout of each individual action within this smooth set\.   The [TimerRemaining](WCSharp.Timers.ISmoothAction.TimerRemaining.md 'WCSharp\.Timers\.ISmoothAction\.TimerRemaining') is adjusted accordingly to ensure a smooth transition. |
