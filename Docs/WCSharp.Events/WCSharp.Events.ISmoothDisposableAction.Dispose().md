#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[ISmoothDisposableAction](WCSharp.Events.ISmoothDisposableAction.md 'WCSharp.Events.ISmoothDisposableAction')

## ISmoothDisposableAction.Dispose() Method

Automatically called after [Active](WCSharp.Events.ISmoothDisposableAction.Active.md 'WCSharp.Events.ISmoothDisposableAction.Active') is set to false.  
  
Note: If set to active from outside of the [Action()](WCSharp.Events.ISmoothDisposableAction.Action().md 'WCSharp.Events.ISmoothDisposableAction.Action()') class, this will only be called on the next interval.

```csharp
void Dispose();
```