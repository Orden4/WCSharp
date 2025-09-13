#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers').[TimerSetSmooth&lt;T&gt;](WCSharp.Timers.TimerSetSmooth_T_.md 'WCSharp\.Timers\.TimerSetSmooth\<T\>')

## TimerSetSmooth\<T\>\.SetTimeout\(float\) Method

Changes the timeout of each individual action within this smooth set\.

The [TimerRemaining](WCSharp.Timers.ISmoothAction.TimerRemaining.md 'WCSharp\.Timers\.ISmoothAction\.TimerRemaining') is adjusted accordingly to ensure a smooth transition.

```csharp
public override void SetTimeout(float timeout);
```
#### Parameters

<a name='WCSharp.Timers.TimerSetSmooth_T_.SetTimeout(float).timeout'></a>

`timeout` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')