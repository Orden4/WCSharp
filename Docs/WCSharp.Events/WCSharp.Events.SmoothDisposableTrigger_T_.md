#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events')

## SmoothDisposableTrigger\<T\> Class

Helpful class that can be used to batch together multiple smooth events of the same type\. Will automatically remove inactive triggers, and
subscribe/unsubscribe from [PeriodicEvents](WCSharp.Events.PeriodicEvents.md 'WCSharp\.Events\.PeriodicEvents') based on whether any triggers are active\.

```csharp
public class SmoothDisposableTrigger<T>
    where T : class, WCSharp.Events.ISmoothDisposableAction
```
#### Type parameters

<a name='WCSharp.Events.SmoothDisposableTrigger_T_.T'></a>

`T`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; SmoothDisposableTrigger\<T\>

| Constructors | |
| :--- | :--- |
| [SmoothDisposableTrigger\(float, float\)](WCSharp.Events.SmoothDisposableTrigger_T_.#ctor.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float) 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(float, float\)') | Creates a new smooth trigger which will individually trigger supplied actions every given interval\.   [tickInterval](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).tickInterval 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(float, float\)\.tickInterval') will be rounded to the nearest multiple of [tickRate](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(float,float).tickRate 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(float, float\)\.tickRate') |
| [SmoothDisposableTrigger\(int, float\)](WCSharp.Events.SmoothDisposableTrigger_T_.#ctor.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float) 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(int, float\)') | Creates a new smooth trigger which will individually trigger supplied actions every given interval\.   Interval is equal to [ticksPerAction](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).ticksPerAction 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(int, float\)\.ticksPerAction')*[tickRate](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.SmoothDisposableTrigger(int,float).tickRate 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.SmoothDisposableTrigger\(int, float\)\.tickRate'). |

| Properties | |
| :--- | :--- |
| [Actions](WCSharp.Events.SmoothDisposableTrigger_T_.Actions.md 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.Actions') | All currently active smooth actions within this smooth trigger\. |

| Methods | |
| :--- | :--- |
| [Add\(T\)](WCSharp.Events.SmoothDisposableTrigger_T_.Add(T).md 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.Add\(T\)') | Adds the given [smoothDisposableTrigger](WCSharp.Events.SmoothDisposableTrigger_T_.Add(T).md#WCSharp.Events.SmoothDisposableTrigger_T_.Add(T).smoothDisposableTrigger 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.Add\(T\)\.smoothDisposableTrigger') to automatic management\.   The first action call will occur after the tick interval. If this isn't desired, adjust [TicksLeft](WCSharp.Events.ISmoothDisposableAction.TicksLeft.md 'WCSharp\.Events\.ISmoothDisposableAction\.TicksLeft') after calling this. |
