#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[SmoothTrigger&lt;T&gt;](WCSharp.Events.SmoothTrigger_T_.md 'WCSharp.Events.SmoothTrigger<T>')

## SmoothTrigger<T>.Add(T) Method

Adds the given [smoothTrigger](WCSharp.Events.SmoothTrigger_T_.Add(T).md#WCSharp.Events.SmoothTrigger_T_.Add(T).smoothTrigger 'WCSharp.Events.SmoothTrigger<T>.Add(T).smoothTrigger') to automatic management.  
  
The first action call will occur after the tick interval. If this isn't desired, adjust [TicksLeft](WCSharp.Events.ISmoothAction.TicksLeft.md 'WCSharp.Events.ISmoothAction.TicksLeft') after calling this.

```csharp
public void Add(T smoothTrigger);
```
#### Parameters

<a name='WCSharp.Events.SmoothTrigger_T_.Add(T).smoothTrigger'></a>

`smoothTrigger` [T](WCSharp.Events.SmoothTrigger_T_.md#WCSharp.Events.SmoothTrigger_T_.T 'WCSharp.Events.SmoothTrigger<T>.T')