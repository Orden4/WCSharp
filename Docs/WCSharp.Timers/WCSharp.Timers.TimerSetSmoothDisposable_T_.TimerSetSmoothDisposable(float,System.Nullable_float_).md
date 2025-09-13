#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers').[TimerSetSmoothDisposable&lt;T&gt;](WCSharp.Timers.TimerSetSmoothDisposable_T_.md 'WCSharp\.Timers\.TimerSetSmoothDisposable\<T\>')

## TimerSetSmoothDisposable\(float, Nullable\<float\>\) Constructor

Creates a new timer set with the given parameters\.

```csharp
public TimerSetSmoothDisposable(float timeout, System.Nullable<float> rootTimeout=null);
```
#### Parameters

<a name='WCSharp.Timers.TimerSetSmoothDisposable_T_.TimerSetSmoothDisposable(float,System.Nullable_float_).timeout'></a>

`timeout` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The time interval between each execution of the timer\.

<a name='WCSharp.Timers.TimerSetSmoothDisposable_T_.TimerSetSmoothDisposable(float,System.Nullable_float_).rootTimeout'></a>

`rootTimeout` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The time interval of the smoothing timer\. See [RootTimeout](WCSharp.Timers.TimerSetSmooth_T_.RootTimeout.md 'WCSharp\.Timers\.TimerSetSmooth\<T\>\.RootTimeout') for more info\.

Leaving this at default ([null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')) will make it use the highest precision ([TickInterval](WCSharp.Timers.TimerSystem.TickInterval.md 'WCSharp\.Timers\.TimerSystem\.TickInterval')) at all times.