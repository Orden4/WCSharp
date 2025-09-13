#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers').[TimerSystem](WCSharp.Timers.TimerSystem.md 'WCSharp\.Timers\.TimerSystem')

## TimerSystem\.Add Method

| Overloads | |
| :--- | :--- |
| [Add\(Action&lt;Timer&gt;, float\)](WCSharp.Timers.TimerSystem.Add.md#WCSharp.Timers.TimerSystem.Add(System.Action_WCSharp.Timers.Timer_,float) 'WCSharp\.Timers\.TimerSystem\.Add\(System\.Action\<WCSharp\.Timers\.Timer\>, float\)') | Creates a new dedicated timer for the given action\. |
| [Add\(Timer\)](WCSharp.Timers.TimerSystem.Add.md#WCSharp.Timers.TimerSystem.Add(WCSharp.Timers.Timer) 'WCSharp\.Timers\.TimerSystem\.Add\(WCSharp\.Timers\.Timer\)') | Reactivates the given timer\. |

<a name='WCSharp.Timers.TimerSystem.Add(System.Action_WCSharp.Timers.Timer_,float)'></a>

## TimerSystem\.Add\(Action\<Timer\>, float\) Method

Creates a new dedicated timer for the given action\.

```csharp
public static WCSharp.Timers.Timer Add(System.Action<WCSharp.Timers.Timer> timerAction, float timeout);
```
#### Parameters

<a name='WCSharp.Timers.TimerSystem.Add(System.Action_WCSharp.Timers.Timer_,float).timerAction'></a>

`timerAction` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[Timer](WCSharp.Timers.Timer.md 'WCSharp\.Timers\.Timer')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')

<a name='WCSharp.Timers.TimerSystem.Add(System.Action_WCSharp.Timers.Timer_,float).timeout'></a>

`timeout` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

#### Returns
[Timer](WCSharp.Timers.Timer.md 'WCSharp\.Timers\.Timer')

<a name='WCSharp.Timers.TimerSystem.Add(WCSharp.Timers.Timer)'></a>

## TimerSystem\.Add\(Timer\) Method

Reactivates the given timer\.

```csharp
public static void Add(WCSharp.Timers.Timer timer);
```
#### Parameters

<a name='WCSharp.Timers.TimerSystem.Add(WCSharp.Timers.Timer).timer'></a>

`timer` [Timer](WCSharp.Timers.Timer.md 'WCSharp\.Timers\.Timer')