#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[SmoothTrigger&lt;T&gt;](WCSharp.Events.SmoothTrigger_T_.md 'WCSharp.Events.SmoothTrigger<T>')

## SmoothTrigger(int, float) Constructor

Creates a new smooth trigger which will individually trigger supplied actions every given interval.  
  
Interval is equal to [ticksPerAction](WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).ticksPerAction 'WCSharp.Events.SmoothTrigger<T>.SmoothTrigger(int, float).ticksPerAction')*[tickRate](WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).tickRate 'WCSharp.Events.SmoothTrigger<T>.SmoothTrigger(int, float).tickRate').

```csharp
public SmoothTrigger(int ticksPerAction, float tickRate=1f/32f);
```
#### Parameters

<a name='WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).ticksPerAction'></a>

`ticksPerAction` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of times that [tickRate](WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).tickRate 'WCSharp.Events.SmoothTrigger<T>.SmoothTrigger(int, float).tickRate') should pass between each [Action()](WCSharp.Events.ISmoothAction.Action().md 'WCSharp.Events.ISmoothAction.Action()') call.

<a name='WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).tickRate'></a>

`tickRate` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

Expresses the smoothness of the trigger. Ideally use multiples of [SYSTEM_INTERVAL](WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL').