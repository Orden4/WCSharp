#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events').[IPeriodicDisposableAction](WCSharp.Events.IPeriodicDisposableAction.md 'WCSharp\.Events\.IPeriodicDisposableAction')

## IPeriodicDisposableAction\.Dispose\(\) Method

Automatically called after [Active](WCSharp.Events.IPeriodicDisposableAction.Active.md 'WCSharp\.Events\.IPeriodicDisposableAction\.Active') is set to false\.

Note: If set to active from outside of the [Action\(\)](WCSharp.Events.IPeriodicDisposableAction.Action().md 'WCSharp\.Events\.IPeriodicDisposableAction\.Action\(\)') class, this will only be called on the next interval.

```csharp
void Dispose();
```