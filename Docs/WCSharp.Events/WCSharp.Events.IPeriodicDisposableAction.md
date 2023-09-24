#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events')

## IPeriodicDisposableAction Interface

Interface for defining periodic actions. If your periodic action does not have actions that it should perform when ended, use [IPeriodicAction](WCSharp.Events.IPeriodicAction.md 'WCSharp.Events.IPeriodicAction') instead.

```csharp
public interface IPeriodicDisposableAction
```

| Properties | |
| :--- | :--- |
| [Active](WCSharp.Events.IPeriodicDisposableAction.Active.md 'WCSharp.Events.IPeriodicDisposableAction.Active') | Indicates the active state of this IPeriodicAction. Set this to false to disable and dispose this instance. |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Events.IPeriodicDisposableAction.Action().md 'WCSharp.Events.IPeriodicDisposableAction.Action()') | The action that will be invoked every period by [PeriodicDisposableTrigger&lt;T&gt;](WCSharp.Events.PeriodicDisposableTrigger_T_.md 'WCSharp.Events.PeriodicDisposableTrigger<T>'). |
| [Dispose()](WCSharp.Events.IPeriodicDisposableAction.Dispose().md 'WCSharp.Events.IPeriodicDisposableAction.Dispose()') | Automatically called after [Active](WCSharp.Events.IPeriodicDisposableAction.Active.md 'WCSharp.Events.IPeriodicDisposableAction.Active') is set to false. |
