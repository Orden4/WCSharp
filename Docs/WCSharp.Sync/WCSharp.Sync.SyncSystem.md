#### [WCSharp.Sync](index.md 'index')
### [WCSharp.Sync](WCSharp.Sync.md 'WCSharp.Sync')

## SyncSystem Class

The [SyncSystem](WCSharp.Sync.SyncSystem.md 'WCSharp.Sync.SyncSystem') sets up a communication channel via the BlzSync functions and allows for the transfer of generically typed data  
across it. Data is automatically split into packets to allow for any amount of data to be transferred across.

```csharp
public static class SyncSystem
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SyncSystem

### Remarks
This system reserves the sync prefixes __WCSharpSyncHeaders and __WCSharpSyncPackets. Nothing else should use these prefixes to send data.

| Methods | |
| :--- | :--- |
| [EnableDebug()](WCSharp.Sync.SyncSystem.EnableDebug().md 'WCSharp.Sync.SyncSystem.EnableDebug()') | Call this method to automatically wrap your actions in a try/catch, so that exceptions that lead back to the SyncSystem will automatically output information.<br/><br/><br/>It is recommended to use compilation time conditions to not call this on release mode. |
| [Send&lt;T&gt;(T)](WCSharp.Sync.SyncSystem.Send_T_(T).md 'WCSharp.Sync.SyncSystem.Send<T>(T)') | Syncs the given data across all clients. Use [Subscribe&lt;T&gt;(Action&lt;T&gt;)](WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).md 'WCSharp.Sync.SyncSystem.Subscribe<T>(System.Action<T>)') in order to set up receiving of certain types of messages. |
| [Subscribe&lt;T&gt;(Action&lt;T&gt;)](WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).md 'WCSharp.Sync.SyncSystem.Subscribe<T>(System.Action<T>)') | Subscribes the given [handler](WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).md#WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).handler 'WCSharp.Sync.SyncSystem.Subscribe<T>(System.Action<T>).handler') to be called when messages of type [T](WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).md#WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).T 'WCSharp.Sync.SyncSystem.Subscribe<T>(System.Action<T>).T') are sent across the [SyncSystem](WCSharp.Sync.SyncSystem.md 'WCSharp.Sync.SyncSystem'). |
| [Unsubscribe&lt;T&gt;(Action&lt;T&gt;)](WCSharp.Sync.SyncSystem.Unsubscribe_T_(System.Action_T_).md 'WCSharp.Sync.SyncSystem.Unsubscribe<T>(System.Action<T>)') | Unsubscribes the given [handler](WCSharp.Sync.SyncSystem.Unsubscribe_T_(System.Action_T_).md#WCSharp.Sync.SyncSystem.Unsubscribe_T_(System.Action_T_).handler 'WCSharp.Sync.SyncSystem.Unsubscribe<T>(System.Action<T>).handler') from the [SyncSystem](WCSharp.Sync.SyncSystem.md 'WCSharp.Sync.SyncSystem'). |
