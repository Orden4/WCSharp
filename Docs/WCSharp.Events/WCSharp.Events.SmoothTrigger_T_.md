#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events')

## SmoothTrigger<T> Class

Helpful class that can be used to batch together multiple smooth events of the same type. Will automatically remove inactive triggers, and  
subscribe/unsubscribe from [PeriodicEvents](WCSharp.Events.PeriodicEvents.md 'WCSharp.Events.PeriodicEvents') based on whether any triggers are active.  
  
Unlike [PeriodicTrigger&lt;T&gt;](WCSharp.Events.PeriodicTrigger_T_.md 'WCSharp.Events.PeriodicTrigger<T>'), all actions will not trigger simultaneously, since each action is counted down separately.

```csharp
public class SmoothTrigger<T>
    where T : WCSharp.Events.ISmoothAction
```
#### Type parameters

<a name='WCSharp.Events.SmoothTrigger_T_.T'></a>

`T`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SmoothTrigger<T>

| Constructors | |
| :--- | :--- |
| [SmoothTrigger(float, float)](WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).md 'WCSharp.Events.SmoothTrigger<T>.SmoothTrigger(float, float)') | Creates a new smooth trigger which will individually trigger supplied actions every given interval.<br/><br/><br/>[tickInterval](WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).tickInterval 'WCSharp.Events.SmoothTrigger<T>.SmoothTrigger(float, float).tickInterval') will be rounded to the nearest multiple of [tickRate](WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(float,float).tickRate 'WCSharp.Events.SmoothTrigger<T>.SmoothTrigger(float, float).tickRate') |
| [SmoothTrigger(int, float)](WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).md 'WCSharp.Events.SmoothTrigger<T>.SmoothTrigger(int, float)') | Creates a new smooth trigger which will individually trigger supplied actions every given interval.<br/><br/><br/>Interval is equal to [ticksPerAction](WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).ticksPerAction 'WCSharp.Events.SmoothTrigger<T>.SmoothTrigger(int, float).ticksPerAction')*[tickRate](WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).md#WCSharp.Events.SmoothTrigger_T_.SmoothTrigger(int,float).tickRate 'WCSharp.Events.SmoothTrigger<T>.SmoothTrigger(int, float).tickRate'). |

| Properties | |
| :--- | :--- |
| [Actions](WCSharp.Events.SmoothTrigger_T_.Actions.md 'WCSharp.Events.SmoothTrigger<T>.Actions') | All currently active smooth actions within this smooth trigger. |

| Methods | |
| :--- | :--- |
| [Add(T)](WCSharp.Events.SmoothTrigger_T_.Add(T).md 'WCSharp.Events.SmoothTrigger<T>.Add(T)') | Adds the given [smoothTrigger](WCSharp.Events.SmoothTrigger_T_.Add(T).md#WCSharp.Events.SmoothTrigger_T_.Add(T).smoothTrigger 'WCSharp.Events.SmoothTrigger<T>.Add(T).smoothTrigger') to automatic management.<br/><br/><br/>The first action call will occur after the tick interval. If this isn't desired, adjust [TicksLeft](WCSharp.Events.ISmoothAction.TicksLeft.md 'WCSharp.Events.ISmoothAction.TicksLeft') after calling this. |
