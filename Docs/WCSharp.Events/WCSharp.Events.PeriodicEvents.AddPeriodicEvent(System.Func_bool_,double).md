#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[PeriodicEvents](WCSharp.Events.PeriodicEvents.md 'WCSharp.Events.PeriodicEvents')

## PeriodicEvents.AddPeriodicEvent(Func<bool>, double) Method

Adds the given method to the periodic system. In most cases, you can ignore the return value.

```csharp
public static WCSharp.Events.PeriodicEvent AddPeriodicEvent(System.Func<bool> method, double period=1.0/32.0);
```
#### Parameters

<a name='WCSharp.Events.PeriodicEvents.AddPeriodicEvent(System.Func_bool_,double).method'></a>

`method` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The method to execute. Must return a boolean to indicate whether to continue looping or abort the periodic event.

<a name='WCSharp.Events.PeriodicEvents.AddPeriodicEvent(System.Func_bool_,double).period'></a>

`period` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The speed at which this event should fire.  
  
Periods below [SYSTEM_INTERVAL](WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL') (0.03125) will run multiple times on certain ticks.

#### Returns
[PeriodicEvent](WCSharp.Events.PeriodicEvent.md 'WCSharp.Events.PeriodicEvent')