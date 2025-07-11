#### [WCSharp\.DateTime](README.md 'README')
### [WCSharp\.DateTime](WCSharp.DateTime.md 'WCSharp\.DateTime').[WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp\.DateTime\.WcDateTime')

## WcDateTime\.GetCurrentTime\(Action\<WcDateTime\>, DateTimeSyncMethod\) Method

This will produce a synchronised time for all players\. The given action will be called once a synchronised time has been determined\.

This is done by individually querying the time, synchronizing this data across all players, and then deciding an overall time.

```csharp
public static void GetCurrentTime(System.Action<WCSharp.DateTime.WcDateTime> action, WCSharp.DateTime.DateTimeSyncMethod method=WCSharp.DateTime.DateTimeSyncMethod.BestFit);
```
#### Parameters

<a name='WCSharp.DateTime.WcDateTime.GetCurrentTime(System.Action_WCSharp.DateTime.WcDateTime_,WCSharp.DateTime.DateTimeSyncMethod).action'></a>

`action` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp\.DateTime\.WcDateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')

This action will be called when the synchronised time is determined\.

<a name='WCSharp.DateTime.WcDateTime.GetCurrentTime(System.Action_WCSharp.DateTime.WcDateTime_,WCSharp.DateTime.DateTimeSyncMethod).method'></a>

`method` [DateTimeSyncMethod](WCSharp.DateTime.DateTimeSyncMethod.md 'WCSharp\.DateTime\.DateTimeSyncMethod')

The method it should use for determining the synchronised time\.