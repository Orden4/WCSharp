#### [WCSharp.Events](index.md 'index')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events')

## PeriodicTrigger<T> Class

Helpful class that can be used to batch together multiple periodic events of the same type. Will automatically remove inactive triggers, and  
subscribe/unsubscribe from [PeriodicEvents](WCSharp.Events.PeriodicEvents.md 'WCSharp.Events.PeriodicEvents') based on whether any triggers are active.

```csharp
public class PeriodicTrigger<T>
    where T : WCSharp.Events.IPeriodicAction
```
#### Type parameters

<a name='WCSharp.Events.PeriodicTrigger_T_.T'></a>

`T`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PeriodicTrigger<T>

| Constructors | |
| :--- | :--- |
| [PeriodicTrigger(float)](WCSharp.Events.PeriodicTrigger_T_.PeriodicTrigger(float).md 'WCSharp.Events.PeriodicTrigger<T>.PeriodicTrigger(float)') | |

| Properties | |
| :--- | :--- |
| [Actions](WCSharp.Events.PeriodicTrigger_T_.Actions.md 'WCSharp.Events.PeriodicTrigger<T>.Actions') | All currently active periodic actions within this periodic trigger. |

| Methods | |
| :--- | :--- |
| [Add(T)](WCSharp.Events.PeriodicTrigger_T_.Add(T).md 'WCSharp.Events.PeriodicTrigger<T>.Add(T)') | Adds the given periodicTrigger to automatic management. |
