#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[PeriodicEvent](WCSharp.Events.PeriodicEvent.md 'WCSharp.Events.PeriodicEvent')

## PeriodicEvent.Method Property

The function that will be invoked every [Interval](WCSharp.Events.PeriodicEvent.Interval.md 'WCSharp.Events.PeriodicEvent.Interval'). Return true for the event to be repeated.

```csharp
public System.Func<bool> Method { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')