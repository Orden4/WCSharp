#### [WCSharp.Events](index.md 'index')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events')

## IPeriodicAction Interface

Interface for defining periodic actions. If your periodic action has actions that it should perform when ended, use [IPeriodicDisposableAction](WCSharp.Events.IPeriodicDisposableAction.md 'WCSharp.Events.IPeriodicDisposableAction') instead.

```csharp
public interface IPeriodicAction
```

| Properties | |
| :--- | :--- |
| [Active](WCSharp.Events.IPeriodicAction.Active.md 'WCSharp.Events.IPeriodicAction.Active') | Indicates the active state of this IPeriodicAction. Set this to false to disable and remove this instance. |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Events.IPeriodicAction.Action().md 'WCSharp.Events.IPeriodicAction.Action()') | The action that will be invoked every period by [PeriodicTrigger&lt;T&gt;](WCSharp.Events.PeriodicTrigger_T_.md 'WCSharp.Events.PeriodicTrigger<T>'). |
