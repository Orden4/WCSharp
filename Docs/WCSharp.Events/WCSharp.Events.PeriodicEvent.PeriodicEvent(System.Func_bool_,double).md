#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events').[PeriodicEvent](WCSharp.Events.PeriodicEvent.md 'WCSharp\.Events\.PeriodicEvent')

## PeriodicEvent\(Func\<bool\>, double\) Constructor

Creates a new periodic event that will call the given method every interval\.
Must be added to [PeriodicEvents](WCSharp.Events.PeriodicEvents.md 'WCSharp\.Events\.PeriodicEvents') in order to be active\.

```csharp
public PeriodicEvent(System.Func<bool> method, double interval);
```
#### Parameters

<a name='WCSharp.Events.PeriodicEvent.PeriodicEvent(System.Func_bool_,double).method'></a>

`method` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')

<a name='WCSharp.Events.PeriodicEvent.PeriodicEvent(System.Func_bool_,double).interval'></a>

`interval` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')