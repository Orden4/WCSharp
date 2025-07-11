#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events')

## ISmoothDisposableAction Interface

Interface for defining smooth actions\. If your smooth action does not have actions that it should perform when ended, use [ISmoothAction](WCSharp.Events.ISmoothAction.md 'WCSharp\.Events\.ISmoothAction') instead\.

```csharp
public interface ISmoothDisposableAction
```

| Properties | |
| :--- | :--- |
| [Active](WCSharp.Events.ISmoothDisposableAction.Active.md 'WCSharp\.Events\.ISmoothDisposableAction\.Active') | Indicates the active state of this [ISmoothDisposableAction](WCSharp.Events.ISmoothDisposableAction.md 'WCSharp\.Events\.ISmoothDisposableAction')\. Set this to false to disable and remove this instance\. |
| [TicksLeft](WCSharp.Events.ISmoothDisposableAction.TicksLeft.md 'WCSharp\.Events\.ISmoothDisposableAction\.TicksLeft') | The number of ticks remaining before the next tick\.   This is always set to the actions per tick before [Action\(\)](WCSharp.Events.ISmoothDisposableAction.Action().md 'WCSharp\.Events\.ISmoothDisposableAction\.Action\(\)') is called. |

| Methods | |
| :--- | :--- |
| [Action\(\)](WCSharp.Events.ISmoothDisposableAction.Action().md 'WCSharp\.Events\.ISmoothDisposableAction\.Action\(\)') | The action that will be invoked every period by [SmoothDisposableTrigger&lt;T&gt;](WCSharp.Events.SmoothDisposableTrigger_T_.md 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>')\. |
| [Dispose\(\)](WCSharp.Events.ISmoothDisposableAction.Dispose().md 'WCSharp\.Events\.ISmoothDisposableAction\.Dispose\(\)') | Automatically called after [Active](WCSharp.Events.ISmoothDisposableAction.Active.md 'WCSharp\.Events\.ISmoothDisposableAction\.Active') is set to false\.   Note: If set to active from outside of the [Action\(\)](WCSharp.Events.ISmoothDisposableAction.Action().md 'WCSharp\.Events\.ISmoothDisposableAction\.Action\(\)') class, this will only be called on the next interval. |
