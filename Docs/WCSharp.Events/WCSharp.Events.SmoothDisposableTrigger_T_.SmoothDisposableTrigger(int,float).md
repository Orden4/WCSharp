#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[SmoothDisposableTrigger&lt;T&gt;](WCSharp.Events.SmoothDisposableTrigger_T_.md 'WCSharp.Events.SmoothDisposableTrigger<T>')

## SmoothDisposableTrigger(int, float) Constructor

Creates a new smooth trigger which will individually trigger supplied actions every given interval.  
  
Interval is equal to [ticksPerAction](WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).ticksPerAction 'WCSharp.Events.SmoothDisposableTrigger<T>.SmoothDisposableTrigger(int, float).ticksPerAction')*[tickRate](WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).tickRate 'WCSharp.Events.SmoothDisposableTrigger<T>.SmoothDisposableTrigger(int, float).tickRate').

```csharp
public SmoothDisposableTrigger(int ticksPerAction, float tickRate=1f/32f);
```
#### Parameters

<a name='WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).ticksPerAction'></a>

`ticksPerAction` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of times that [tickRate](WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).tickRate 'WCSharp.Events.SmoothDisposableTrigger<T>.SmoothDisposableTrigger(int, float).tickRate') should pass between each [Action()](WCSharp.Events.ISmoothDisposableAction.Action().md 'WCSharp.Events.ISmoothDisposableAction.Action()') call.

<a name='WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).tickRate'></a>

`tickRate` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

Expresses the smoothness of the trigger. Ideally use multiples of [SYSTEM_INTERVAL](WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL').