#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers').[TimerSetSmooth&lt;T&gt;](WCSharp.Timers.TimerSetSmooth_T_.md 'WCSharp\.Timers\.TimerSetSmooth\<T\>')

## TimerSetSmooth\<T\>\.SetRootTimeout\(Nullable\<float\>\) Method

Changes the root timeout of the smoothing timer\.

See [RootTimeout](WCSharp.Timers.TimerSetSmooth_T_.RootTimeout.md 'WCSharp\.Timers\.TimerSetSmooth\<T\>\.RootTimeout') for more info.

Leaving this at default ([null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')) will make it use the highest precision ([TickInterval](WCSharp.Timers.TimerSystem.TickInterval.md 'WCSharp\.Timers\.TimerSystem\.TickInterval')) at all times.

```csharp
public void SetRootTimeout(System.Nullable<float> rootTimeout=null);
```
#### Parameters

<a name='WCSharp.Timers.TimerSetSmooth_T_.SetRootTimeout(System.Nullable_float_).rootTimeout'></a>

`rootTimeout` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')