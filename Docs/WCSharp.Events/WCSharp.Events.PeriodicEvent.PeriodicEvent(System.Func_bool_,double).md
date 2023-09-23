#### [WCSharp.Events](index.md 'index')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[PeriodicEvent](WCSharp.Events.PeriodicEvent.md 'WCSharp.Events.PeriodicEvent')

## PeriodicEvent(Func<bool>, double) Constructor

Creates a new periodic event that will call the given method every interval.  
Must be added to [PeriodicEvents](WCSharp.Events.PeriodicEvents.md 'WCSharp.Events.PeriodicEvents') in order to be active.

```csharp
public PeriodicEvent(System.Func<bool> method, double interval);
```
#### Parameters

<a name='WCSharp.Events.PeriodicEvent.PeriodicEvent(System.Func_bool_,double).method'></a>

`method` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='WCSharp.Events.PeriodicEvent.PeriodicEvent(System.Func_bool_,double).interval'></a>

`interval` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')