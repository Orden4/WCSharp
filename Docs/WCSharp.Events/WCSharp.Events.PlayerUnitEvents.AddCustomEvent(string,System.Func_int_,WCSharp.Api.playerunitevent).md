#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp.Events.PlayerUnitEvents')

## PlayerUnitEvents.AddCustomEvent(string, Func<int>, playerunitevent) Method

Defines a custom event with the given [identifier](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).md#WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).identifier 'WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string, System.Func<int>, WCSharp.Api.playerunitevent).identifier') and [filter](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).md#WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).filter 'WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string, System.Func<int>, WCSharp.Api.playerunitevent).filter') that responds to events of  
the given [nativeEvent](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).md#WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).nativeEvent 'WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string, System.Func<int>, WCSharp.Api.playerunitevent).nativeEvent').

```csharp
public static void AddCustomEvent(string identifier, System.Func<int> filter, WCSharp.Api.playerunitevent nativeEvent);
```
#### Parameters

<a name='WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).identifier'></a>

`identifier` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).filter'></a>

`filter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).nativeEvent'></a>

`nativeEvent` [WCSharp.Api.playerunitevent](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.playerunitevent 'WCSharp.Api.playerunitevent')