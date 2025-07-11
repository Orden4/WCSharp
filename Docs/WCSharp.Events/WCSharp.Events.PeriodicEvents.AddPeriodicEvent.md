#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events').[PeriodicEvents](WCSharp.Events.PeriodicEvents.md 'WCSharp\.Events\.PeriodicEvents')

## PeriodicEvents\.AddPeriodicEvent Method

| Overloads | |
| :--- | :--- |
| [AddPeriodicEvent\(Func&lt;bool&gt;, double\)](WCSharp.Events.PeriodicEvents.AddPeriodicEvent.md#WCSharp.Events.PeriodicEvents.AddPeriodicEvent(System.Func_bool_,double) 'WCSharp\.Events\.PeriodicEvents\.AddPeriodicEvent\(System\.Func\<bool\>, double\)') | Adds the given method to the periodic system\. In most cases, you can ignore the return value\. |
| [AddPeriodicEvent\(PeriodicEvent\)](WCSharp.Events.PeriodicEvents.AddPeriodicEvent.md#WCSharp.Events.PeriodicEvents.AddPeriodicEvent(WCSharp.Events.PeriodicEvent) 'WCSharp\.Events\.PeriodicEvents\.AddPeriodicEvent\(WCSharp\.Events\.PeriodicEvent\)') | Shorthand in case you already have an existing PeriodicEvent to resume\. |

<a name='WCSharp.Events.PeriodicEvents.AddPeriodicEvent(System.Func_bool_,double)'></a>

## PeriodicEvents\.AddPeriodicEvent\(Func\<bool\>, double\) Method

Adds the given method to the periodic system\. In most cases, you can ignore the return value\.

```csharp
public static WCSharp.Events.PeriodicEvent AddPeriodicEvent(System.Func<bool> method, double period=1.0/32.0);
```
#### Parameters

<a name='WCSharp.Events.PeriodicEvents.AddPeriodicEvent(System.Func_bool_,double).method'></a>

`method` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')

The method to execute\. Must return a boolean to indicate whether to continue looping or abort the periodic event\.

<a name='WCSharp.Events.PeriodicEvents.AddPeriodicEvent(System.Func_bool_,double).period'></a>

`period` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The speed at which this event should fire\.

Periods below [SYSTEM\_INTERVAL](WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp\.Events\.PeriodicEvents\.SYSTEM\_INTERVAL') (0.03125) will run multiple times on certain ticks.

#### Returns
[PeriodicEvent](WCSharp.Events.PeriodicEvent.md 'WCSharp\.Events\.PeriodicEvent')

<a name='WCSharp.Events.PeriodicEvents.AddPeriodicEvent(WCSharp.Events.PeriodicEvent)'></a>

## PeriodicEvents\.AddPeriodicEvent\(PeriodicEvent\) Method

Shorthand in case you already have an existing PeriodicEvent to resume\.

```csharp
public static void AddPeriodicEvent(WCSharp.Events.PeriodicEvent timerEvent);
```
#### Parameters

<a name='WCSharp.Events.PeriodicEvents.AddPeriodicEvent(WCSharp.Events.PeriodicEvent).timerEvent'></a>

`timerEvent` [PeriodicEvent](WCSharp.Events.PeriodicEvent.md 'WCSharp\.Events\.PeriodicEvent')