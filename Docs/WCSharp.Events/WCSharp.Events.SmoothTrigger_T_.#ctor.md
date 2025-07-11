#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events').[SmoothTrigger&lt;T&gt;](WCSharp.Events.SmoothTrigger_T_.md 'WCSharp\.Events\.SmoothTrigger\<T\>')

## SmoothTrigger\<T\> Constructors

| Overloads | |
| :--- | :--- |
| [SmoothTrigger\(float, float\)](WCSharp.Events.SmoothTrigger_T_.#ctor.md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float) 'WCSharp\.Events\.SmoothTrigger\<T\>\.SmoothTrigger\(float, float\)') | Creates a new smooth trigger which will individually trigger supplied actions every given interval\.   [tickInterval](WCSharp.Events.SmoothTrigger_T_.md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).tickInterval 'WCSharp\.Events\.SmoothTrigger\<T\>\.SmoothTrigger\(float, float\)\.tickInterval') will be rounded to the nearest multiple of [tickRate](WCSharp.Events.SmoothTrigger_T_.md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).tickRate 'WCSharp\.Events\.SmoothTrigger\<T\>\.SmoothTrigger\(float, float\)\.tickRate') |
| [SmoothTrigger\(int, float\)](WCSharp.Events.SmoothTrigger_T_.#ctor.md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float) 'WCSharp\.Events\.SmoothTrigger\<T\>\.SmoothTrigger\(int, float\)') | Creates a new smooth trigger which will individually trigger supplied actions every given interval\.   Interval is equal to [ticksPerAction](WCSharp.Events.SmoothTrigger_T_.md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).ticksPerAction 'WCSharp\.Events\.SmoothTrigger\<T\>\.SmoothTrigger\(int, float\)\.ticksPerAction')*[tickRate](WCSharp.Events.SmoothTrigger_T_.md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).tickRate 'WCSharp\.Events\.SmoothTrigger\<T\>\.SmoothTrigger\(int, float\)\.tickRate'). |

<a name='ctor.md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float)'></a>

## SmoothTrigger\(float, float\) Constructor

Creates a new smooth trigger which will individually trigger supplied actions every given interval\.

[tickInterval](WCSharp.Events.SmoothTrigger_T_.md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).tickInterval 'WCSharp\.Events\.SmoothTrigger\<T\>\.SmoothTrigger\(float, float\)\.tickInterval') will be rounded to the nearest multiple of [tickRate](WCSharp.Events.SmoothTrigger_T_.md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).tickRate 'WCSharp\.Events\.SmoothTrigger\<T\>\.SmoothTrigger\(float, float\)\.tickRate')

```csharp
public SmoothTrigger(float tickInterval, float tickRate=1f/32f);
```
#### Parameters

<a name='WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).tickInterval'></a>

`tickInterval` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The amount of time between each [Action\(\)](WCSharp.Events.ISmoothAction.Action().md 'WCSharp\.Events\.ISmoothAction\.Action\(\)') call\.

<a name='WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).tickRate'></a>

`tickRate` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Expresses the smoothness of the trigger\. Ideally use multiples of [SYSTEM\_INTERVAL](WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp\.Events\.PeriodicEvents\.SYSTEM\_INTERVAL')\.

<a name='ctor.md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float)'></a>

## SmoothTrigger\(int, float\) Constructor

Creates a new smooth trigger which will individually trigger supplied actions every given interval\.

Interval is equal to [ticksPerAction](WCSharp.Events.SmoothTrigger_T_.md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).ticksPerAction 'WCSharp\.Events\.SmoothTrigger\<T\>\.SmoothTrigger\(int, float\)\.ticksPerAction')*[tickRate](WCSharp.Events.SmoothTrigger_T_.md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).tickRate 'WCSharp\.Events\.SmoothTrigger\<T\>\.SmoothTrigger\(int, float\)\.tickRate').

```csharp
public SmoothTrigger(int ticksPerAction, float tickRate=1f/32f);
```
#### Parameters

<a name='WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).ticksPerAction'></a>

`ticksPerAction` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of times that [tickRate](WCSharp.Events.SmoothTrigger_T_.md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).tickRate 'WCSharp\.Events\.SmoothTrigger\<T\>\.SmoothTrigger\(int, float\)\.tickRate') should pass between each [Action\(\)](WCSharp.Events.ISmoothAction.Action().md 'WCSharp\.Events\.ISmoothAction\.Action\(\)') call\.

<a name='WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).tickRate'></a>

`tickRate` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Expresses the smoothness of the trigger\. Ideally use multiples of [SYSTEM\_INTERVAL](WCSharp.Events.PeriodicEvents.SYSTEM_INTERVAL.md 'WCSharp\.Events\.PeriodicEvents\.SYSTEM\_INTERVAL')\.