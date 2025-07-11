#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events').[SmoothDisposableTrigger&lt;T&gt;](WCSharp.Events.SmoothDisposableTrigger_T_.md 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>')

## SmoothDisposableTrigger\<T\>\.Add\(T\) Method

Adds the given [smoothDisposableTrigger](WCSharp.Events.SmoothDisposableTrigger_T_.Add(T).md#WCSharp.Events.SmoothDisposableTrigger_T_.Add(T).smoothDisposableTrigger 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.Add\(T\)\.smoothDisposableTrigger') to automatic management\.

The first action call will occur after the tick interval. If this isn't desired, adjust [TicksLeft](WCSharp.Events.ISmoothDisposableAction.TicksLeft.md 'WCSharp\.Events\.ISmoothDisposableAction\.TicksLeft') after calling this.

```csharp
public void Add(T smoothDisposableTrigger);
```
#### Parameters

<a name='WCSharp.Events.SmoothDisposableTrigger_T_.Add(T).smoothDisposableTrigger'></a>

`smoothDisposableTrigger` [T](WCSharp.Events.SmoothDisposableTrigger_T_.md#WCSharp.Events.SmoothDisposableTrigger_T_.T 'WCSharp\.Events\.SmoothDisposableTrigger\<T\>\.T')