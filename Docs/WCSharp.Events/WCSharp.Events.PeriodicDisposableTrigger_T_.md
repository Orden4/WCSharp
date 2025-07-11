#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events')

## PeriodicDisposableTrigger\<T\> Class

Helpful class that can be used to batch together multiple periodic events of the same type\. Will automatically remove inactive triggers, and
subscribe/unsubscribe from [PeriodicEvents](WCSharp.Events.PeriodicEvents.md 'WCSharp\.Events\.PeriodicEvents') based on whether any triggers are active\.

Has additional functionality for disposing of actions when they end.

```csharp
public class PeriodicDisposableTrigger<T>
    where T : WCSharp.Events.IPeriodicDisposableAction
```
#### Type parameters

<a name='WCSharp.Events.PeriodicDisposableTrigger_T_.T'></a>

`T`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; PeriodicDisposableTrigger\<T\>

| Constructors | |
| :--- | :--- |
| [PeriodicDisposableTrigger\(float\)](WCSharp.Events.PeriodicDisposableTrigger_T_.PeriodicDisposableTrigger(float).md 'WCSharp\.Events\.PeriodicDisposableTrigger\<T\>\.PeriodicDisposableTrigger\(float\)') | Creates a new periodic trigger which will trigger all supplied actions every given [period](WCSharp.Events.PeriodicDisposableTrigger_T_.PeriodicDisposableTrigger(float).md#WCSharp.Events.PeriodicDisposableTrigger_T_.PeriodicDisposableTrigger(float).period 'WCSharp\.Events\.PeriodicDisposableTrigger\<T\>\.PeriodicDisposableTrigger\(float\)\.period')\. |

| Properties | |
| :--- | :--- |
| [Actions](WCSharp.Events.PeriodicDisposableTrigger_T_.Actions.md 'WCSharp\.Events\.PeriodicDisposableTrigger\<T\>\.Actions') | All currently active periodic actions within this periodic trigger\. |

| Methods | |
| :--- | :--- |
| [Add\(T\)](WCSharp.Events.PeriodicDisposableTrigger_T_.Add(T).md 'WCSharp\.Events\.PeriodicDisposableTrigger\<T\>\.Add\(T\)') | Adds the given [periodicDisposableTrigger](WCSharp.Events.PeriodicDisposableTrigger_T_.Add(T).md#WCSharp.Events.PeriodicDisposableTrigger_T_.Add(T).periodicDisposableTrigger 'WCSharp\.Events\.PeriodicDisposableTrigger\<T\>\.Add\(T\)\.periodicDisposableTrigger') to automatic management\. |
