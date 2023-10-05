#### [WCSharp.Sync](README.md 'README')
### [WCSharp.Sync](WCSharp.Sync.md 'WCSharp.Sync').[SyncSystem](WCSharp.Sync.SyncSystem.md 'WCSharp.Sync.SyncSystem')

## SyncSystem.Subscribe<T>(Action<T>) Method

Subscribes the given [handler](WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).md#WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).handler 'WCSharp.Sync.SyncSystem.Subscribe<T>(System.Action<T>).handler') to be called when messages of type [T](WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).md#WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).T 'WCSharp.Sync.SyncSystem.Subscribe<T>(System.Action<T>).T') are sent across the [SyncSystem](WCSharp.Sync.SyncSystem.md 'WCSharp.Sync.SyncSystem').

```csharp
public static void Subscribe<T>(System.Action<T> handler)
    where T : class;
```
#### Type parameters

<a name='WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).T'></a>

`T`
#### Parameters

<a name='WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).handler'></a>

`handler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).md#WCSharp.Sync.SyncSystem.Subscribe_T_(System.Action_T_).T 'WCSharp.Sync.SyncSystem.Subscribe<T>(System.Action<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')