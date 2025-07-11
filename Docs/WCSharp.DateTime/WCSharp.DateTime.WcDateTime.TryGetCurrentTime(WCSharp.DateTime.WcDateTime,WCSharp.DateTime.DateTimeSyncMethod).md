#### [WCSharp\.DateTime](README.md 'README')
### [WCSharp\.DateTime](WCSharp.DateTime.md 'WCSharp\.DateTime').[WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp\.DateTime\.WcDateTime')

## WcDateTime\.TryGetCurrentTime\(WcDateTime, DateTimeSyncMethod\) Method

This will attempt to immediately return a synchronised time for all players, if it has already been calculated\.
If it has not been calculated, this will return false\.

If it has not been calculated, will start a calculation procedure behind the scenes, but this will take some time.

```csharp
public static bool TryGetCurrentTime(out WCSharp.DateTime.WcDateTime wcDateTime, WCSharp.DateTime.DateTimeSyncMethod method=WCSharp.DateTime.DateTimeSyncMethod.BestFit);
```
#### Parameters

<a name='WCSharp.DateTime.WcDateTime.TryGetCurrentTime(WCSharp.DateTime.WcDateTime,WCSharp.DateTime.DateTimeSyncMethod).wcDateTime'></a>

`wcDateTime` [WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp\.DateTime\.WcDateTime')

The synchronised time, if available\.

<a name='WCSharp.DateTime.WcDateTime.TryGetCurrentTime(WCSharp.DateTime.WcDateTime,WCSharp.DateTime.DateTimeSyncMethod).method'></a>

`method` [DateTimeSyncMethod](WCSharp.DateTime.DateTimeSyncMethod.md 'WCSharp\.DateTime\.DateTimeSyncMethod')

The method it should use for determining the synchronised time\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Whether the retrieval was successful\.