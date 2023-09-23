#### [WCSharp.Shared](index.md 'index')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp.Shared.Util')

## Util.EnumeratePlayers(playerslotstate, mapcontrol) Method

Returns all players matching the given [playerslotstate](WCSharp.Shared.Util.EnumeratePlayers(War3Api.Common.playerslotstate,War3Api.Common.mapcontrol).md#WCSharp.Shared.Util.EnumeratePlayers(War3Api.Common.playerslotstate,War3Api.Common.mapcontrol).playerslotstate 'WCSharp.Shared.Util.EnumeratePlayers(War3Api.Common.playerslotstate, War3Api.Common.mapcontrol).playerslotstate') and [mapcontrol](WCSharp.Shared.Util.EnumeratePlayers(War3Api.Common.playerslotstate,War3Api.Common.mapcontrol).md#WCSharp.Shared.Util.EnumeratePlayers(War3Api.Common.playerslotstate,War3Api.Common.mapcontrol).mapcontrol 'WCSharp.Shared.Util.EnumeratePlayers(War3Api.Common.playerslotstate, War3Api.Common.mapcontrol).mapcontrol').

```csharp
public static System.Collections.Generic.IEnumerable<War3Api.Common.player> EnumeratePlayers(War3Api.Common.playerslotstate playerslotstate=null, War3Api.Common.mapcontrol mapcontrol=null);
```
#### Parameters

<a name='WCSharp.Shared.Util.EnumeratePlayers(War3Api.Common.playerslotstate,War3Api.Common.mapcontrol).playerslotstate'></a>

`playerslotstate` [War3Api.Common.playerslotstate](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.playerslotstate 'War3Api.Common.playerslotstate')

The [War3Api.Common.playerslotstate](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.playerslotstate 'War3Api.Common.playerslotstate') that players should have. Defaults to [War3Api.Common.PLAYER_SLOT_STATE_PLAYING](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.PLAYER_SLOT_STATE_PLAYING 'War3Api.Common.PLAYER_SLOT_STATE_PLAYING').

<a name='WCSharp.Shared.Util.EnumeratePlayers(War3Api.Common.playerslotstate,War3Api.Common.mapcontrol).mapcontrol'></a>

`mapcontrol` [War3Api.Common.mapcontrol](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.mapcontrol 'War3Api.Common.mapcontrol')

The [War3Api.Common.mapcontrol](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.mapcontrol 'War3Api.Common.mapcontrol') that players should have. Defaults to [War3Api.Common.MAP_CONTROL_USER](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.MAP_CONTROL_USER 'War3Api.Common.MAP_CONTROL_USER').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[War3Api.Common.player](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.player 'War3Api.Common.player')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')