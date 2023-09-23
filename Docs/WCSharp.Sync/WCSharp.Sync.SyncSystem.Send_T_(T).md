### [WCSharp.Sync](WCSharp.Sync.md 'WCSharp.Sync').[SyncSystem](WCSharp.Sync.SyncSystem.md 'WCSharp.Sync.SyncSystem')

## SyncSystem.Send<T>(T) Method

Syncs the given data across all clients. Use [Subscribe&lt;T&gt;(Action&lt;T&gt;)](WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).md 'WCSharp.Sync.SyncSystem.Subscribe<T>(System.Action<T>)') in order to set up receiving of certain types of messages.

```csharp
public static void Send<T>(T message)
    where T : class;
```
#### Type parameters

<a name='WCSharp.Sync.SyncSystem.Send_T_(T).T'></a>

`T`
#### Parameters

<a name='WCSharp.Sync.SyncSystem.Send_T_(T).message'></a>

`message` [T](WCSharp.Sync.SyncSystem.Send_T_(T).md#WCSharp.Sync.SyncSystem.Send_T_(T).T 'WCSharp.Sync.SyncSystem.Send<T>(T).T')