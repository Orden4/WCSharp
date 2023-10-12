#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp.Shared.Util')

## Util.EnumeratePlayers(playerslotstate, mapcontrol) Method

Returns all players matching the given [playerslotstate](WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol).md#WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol).playerslotstate 'WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate, WCSharp.Api.mapcontrol).playerslotstate') and [mapcontrol](WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol).md#WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol).mapcontrol 'WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate, WCSharp.Api.mapcontrol).mapcontrol').

```csharp
public static System.Collections.Generic.IEnumerable<WCSharp.Api.player> EnumeratePlayers(WCSharp.Api.playerslotstate playerslotstate=null, WCSharp.Api.mapcontrol mapcontrol=null);
```
#### Parameters

<a name='WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol).playerslotstate'></a>

`playerslotstate` [WCSharp.Api.playerslotstate](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.playerslotstate 'WCSharp.Api.playerslotstate')

The [WCSharp.Api.playerslotstate](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.playerslotstate 'WCSharp.Api.playerslotstate') that players should have. Defaults to [WCSharp.Api.Common.PLAYER_SLOT_STATE_PLAYING](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.Common.PLAYER_SLOT_STATE_PLAYING 'WCSharp.Api.Common.PLAYER_SLOT_STATE_PLAYING').

<a name='WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol).mapcontrol'></a>

`mapcontrol` [WCSharp.Api.mapcontrol](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.mapcontrol 'WCSharp.Api.mapcontrol')

The [WCSharp.Api.mapcontrol](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.mapcontrol 'WCSharp.Api.mapcontrol') that players should have. Defaults to [WCSharp.Api.Common.MAP_CONTROL_USER](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.Common.MAP_CONTROL_USER 'WCSharp.Api.Common.MAP_CONTROL_USER').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[WCSharp.Api.player](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.player 'WCSharp.Api.player')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')