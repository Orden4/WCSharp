#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events').[SmoothDisposableTrigger&lt;T&gt;](WCSharp.Events.SmoothDisposableTrigger_T_.md 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>')

## SmoothDisposableTrigger\<T\> Constructors

| Overloads | |
| :--- | :--- |
| [SmoothDisposableTrigger\(float, float\)](WCSharp.Events.SmoothDisposableTrigger_T_.#ctor.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float) 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(float, float\)') | Creates a new smooth trigger which will individually trigger supplied actions every given interval\.   [tickInterval](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).tickInterval 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(float, float\)\.tickInterval') will be rounded to the nearest multiple of [tickRate](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).tickRate 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(float, float\)\.tickRate') |
| [SmoothDisposableTrigger\(int, float\)](WCSharp.Events.SmoothDisposableTrigger_T_.#ctor.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float) 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(int, float\)') | Creates a new smooth trigger which will individually trigger supplied actions every given interval\.   Interval is equal to [ticksPerAction](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).ticksPerAction 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(int, float\)\.ticksPerAction')*[tickRate](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).tickRate 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(int, float\)\.tickRate'). |

<a name='ctor.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float)'></a>

## SmoothDisposableTrigger\(float, float\) Constructor

Creates a new smooth trigger which will individually trigger supplied actions every given interval\.

[tickInterval](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).tickInterval 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(float, float\)\.tickInterval') will be rounded to the nearest multiple of [tickRate](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).tickRate 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(float, float\)\.tickRate')

```csharp
public SmoothDisposableTrigger(float tickInterval, float tickRate=1f/32f);
```
#### Parameters

<a name='WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).tickInterval'></a>

`tickInterval` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The amount of time between each [Action\(\)](WCSharp.Events.ISmoothDisposableAction.Action().md 'WCSharp\.Events\.ISmoothDisposableAction\.Action\(\)') call\.

<a name='WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).tickRate'></a>

`tickRate` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Expresses the smoothness of the trigger\. Ideally use multiples of [SYSTEM\_INTERVAL](WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp\.Events\.PeriodicEvents\.SYSTEM\_INTERVAL')\.

<a name='ctor.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float)'></a>

## SmoothDisposableTrigger\(int, float\) Constructor

Creates a new smooth trigger which will individually trigger supplied actions every given interval\.

Interval is equal to [ticksPerAction](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).ticksPerAction 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(int, float\)\.ticksPerAction')*[tickRate](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).tickRate 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(int, float\)\.tickRate').

```csharp
public SmoothDisposableTrigger(int ticksPerAction, float tickRate=1f/32f);
```
#### Parameters

<a name='WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).ticksPerAction'></a>

`ticksPerAction` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of times that [tickRate](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).tickRate 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(int, float\)\.tickRate') should pass between each [Action\(\)](WCSharp.Events.ISmoothDisposableAction.Action().md 'WCSharp\.Events\.ISmoothDisposableAction\.Action\(\)') call\.

<a name='WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).tickRate'></a>

`tickRate` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Expresses the smoothness of the trigger\. Ideally use multiples of [SYSTEM\_INTERVAL](WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp\.Events\.PeriodicEvents\.SYSTEM\_INTERVAL')\.