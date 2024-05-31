#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[SmoothTrigger&lt;T&gt;](WCSharp.Events.SmoothTrigger_T_.md 'WCSharp.Events.SmoothTrigger<T>')

## SmoothTrigger(float, float) Constructor

Creates a new smooth trigger which will individually trigger supplied actions every given interval.  
  
[tickInterval](WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).tickInterval 'WCSharp.Events.SmoothTrigger<T>.SmoothTrigger(float, float).tickInterval') will be rounded to the nearest multiple of [tickRate](WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).tickRate 'WCSharp.Events.SmoothTrigger<T>.SmoothTrigger(float, float).tickRate')

```csharp
public SmoothTrigger(float tickInterval, float tickRate=1f/32f);
```
#### Parameters

<a name='WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).tickInterval'></a>

`tickInterval` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The amount of time between each [Action()](WCSharp.Events.ISmoothAction.Action().md 'WCSharp.Events.ISmoothAction.Action()') call.

<a name='WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).tickRate'></a>

`tickRate` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

Expresses the smoothness of the trigger. Ideally use multiples of [SYSTEM_INTERVAL](WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL').