#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events')

## ISmoothAction Interface

Interface for defining smooth actions. If your smooth action has actions that it should perform when ended, use [ISmoothDisposableAction](WCSharp.Events.ISmoothDisposableAction.md 'WCSharp.Events.ISmoothDisposableAction') instead.

```csharp
public interface ISmoothAction
```

| Properties | |
| :--- | :--- |
| [Active](WCSharp.Events.ISmoothAction.Active.md 'WCSharp.Events.ISmoothAction.Active') | Indicates the active state of this [ISmoothAction](WCSharp.Events.ISmoothAction.md 'WCSharp.Events.ISmoothAction'). Set this to false to disable and remove this instance. |
| [TicksLeft](WCSharp.Events.ISmoothAction.TicksLeft.md 'WCSharp.Events.ISmoothAction.TicksLeft') | The number of ticks remaining before the next tick.<br/><br/><br/>This is always set to the actions per tick before [Action()](WCSharp.Events.ISmoothAction.Action().md 'WCSharp.Events.ISmoothAction.Action()') is called. |

| Methods | |
| :--- | :--- |
| [Action()](WCSharp.Events.ISmoothAction.Action().md 'WCSharp.Events.ISmoothAction.Action()') | The action that will be invoked every period by [SmoothTrigger&lt;T&gt;](WCSharp.Events.SmoothTrigger_T_.md 'WCSharp.Events.SmoothTrigger<T>'). |
