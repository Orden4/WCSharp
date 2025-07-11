#### [WCSharp\.Lightnings](README.md 'README')
### [WCSharp\.Lightnings](WCSharp.Lightnings.md 'WCSharp\.Lightnings').[Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning')

## Lightning\.Dispose\(\) Method

Automatically called after [Active](../WCSharp.Events/WCSharp.Events.IPeriodicDisposableAction.Active.md 'WCSharp\.Events\.IPeriodicDisposableAction\.Active') is set to false\.

Note: If set to active from outside of the [Action\(\)](../WCSharp.Events/WCSharp.Events.IPeriodicDisposableAction.Action().md 'WCSharp\.Events\.IPeriodicDisposableAction\.Action') class, this will only be called on the next interval.

```csharp
public void Dispose();
```

Implements [Dispose\(\)](../WCSharp.Events/WCSharp.Events.IPeriodicDisposableAction.Dispose().md 'WCSharp\.Events\.IPeriodicDisposableAction\.Dispose')