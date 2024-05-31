#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[SmoothDisposableTrigger&lt;T&gt;](WCSharp.Events.SmoothDisposableTrigger_T_.md 'WCSharp.Events.SmoothDisposableTrigger<T>')

## SmoothDisposableTrigger(float, float) Constructor

Creates a new smooth trigger which will individually trigger supplied actions every given interval.  
  
[tickInterval](WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).tickInterval 'WCSharp.Events.SmoothDisposableTrigger<T>.SmoothDisposableTrigger(float, float).tickInterval') will be rounded to the nearest multiple of [tickRate](WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).tickRate 'WCSharp.Events.SmoothDisposableTrigger<T>.SmoothDisposableTrigger(float, float).tickRate')

```csharp
public SmoothDisposableTrigger(float tickInterval, float tickRate=1f/32f);
```
#### Parameters

<a name='WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).tickInterval'></a>

`tickInterval` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The amount of time between each [Action()](WCSharp.Events.ISmoothDisposableAction.Action().md 'WCSharp.Events.ISmoothDisposableAction.Action()') call.

<a name='WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).tickRate'></a>

`tickRate` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

Expresses the smoothness of the trigger. Ideally use multiples of [SYSTEM_INTERVAL](WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL').