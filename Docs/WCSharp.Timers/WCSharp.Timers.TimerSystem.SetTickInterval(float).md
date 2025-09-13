#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers').[TimerSystem](WCSharp.Timers.TimerSystem.md 'WCSharp\.Timers\.TimerSystem')

## TimerSystem\.SetTickInterval\(float\) Method

Changes [TickInterval](WCSharp.Timers.TimerSystem.TickInterval.md 'WCSharp\.Timers\.TimerSystem\.TickInterval') to [tickInterval](WCSharp.Timers.TimerSystem.SetTickInterval(float).md#WCSharp.Timers.TimerSystem.SetTickInterval(float).tickInterval 'WCSharp\.Timers\.TimerSystem\.SetTickInterval\(float\)\.tickInterval') after a 0 second delay\.

It is strongly recommended to use multiples of 2 as tick interval (e.g. 1/16, 1/32, 1/64, etc).

Setting this to 0 or less will pause the system.

```csharp
public static void SetTickInterval(float tickInterval);
```
#### Parameters

<a name='WCSharp.Timers.TimerSystem.SetTickInterval(float).tickInterval'></a>

`tickInterval` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')