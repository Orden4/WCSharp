### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events')

## PeriodicDisposableTrigger<T> Class

Helpful class that can be used to batch together multiple periodic events of the same type. Will automatically remove inactive triggers, and  
subscribe/unsubscribe from [PeriodicEvents](WCSharp.Events.PeriodicEvents.md 'WCSharp.Events.PeriodicEvents') based on whether any triggers are active.

```csharp
public class PeriodicDisposableTrigger<T>
    where T : WCSharp.Events.IPeriodicDisposableAction
```
#### Type parameters

<a name='WCSharp.Events.PeriodicDisposableTrigger_T_.T'></a>

`T`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PeriodicDisposableTrigger<T>

| Constructors | |
| :--- | :--- |
| [PeriodicDisposableTrigger(float)](WCSharp.Events.PeriodicDisposableTrigger_T_.PeriodicDisposableTrigger(float).md 'WCSharp.Events.PeriodicDisposableTrigger<T>.PeriodicDisposableTrigger(float)') | |

| Properties | |
| :--- | :--- |
| [Actions](WCSharp.Events.PeriodicDisposableTrigger_T_.Actions.md 'WCSharp.Events.PeriodicDisposableTrigger<T>.Actions') | All currently active periodic actions within this periodic trigger. |

| Methods | |
| :--- | :--- |
| [Add(T)](WCSharp.Events.PeriodicDisposableTrigger_T_.Add(T).md 'WCSharp.Events.PeriodicDisposableTrigger<T>.Add(T)') | Adds the given periodicTrigger to automatic management. |
