#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared](WCSharp.Shared.md 'WCSharp\.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp\.Shared\.Util')

## Util\.EnumeratePlayers Method

| Overloads | |
| :--- | :--- |
| [EnumeratePlayers\(\)](WCSharp.Shared.Util.EnumeratePlayers.md#WCSharp.Shared.Util.EnumeratePlayers() 'WCSharp\.Shared\.Util\.EnumeratePlayers\(\)') | Returns all players\. |
| [EnumeratePlayers\(playerslotstate, mapcontrol\)](WCSharp.Shared.Util.EnumeratePlayers.md#WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol) 'WCSharp\.Shared\.Util\.EnumeratePlayers\(WCSharp\.Api\.playerslotstate, WCSharp\.Api\.mapcontrol\)') | Returns all players matching the given [playerslotstate](WCSharp.Shared.Util.md#WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol).playerslotstate 'WCSharp\.Shared\.Util\.EnumeratePlayers\(WCSharp\.Api\.playerslotstate, WCSharp\.Api\.mapcontrol\)\.playerslotstate') and [mapcontrol](WCSharp.Shared.Util.md#WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol).mapcontrol 'WCSharp\.Shared\.Util\.EnumeratePlayers\(WCSharp\.Api\.playerslotstate, WCSharp\.Api\.mapcontrol\)\.mapcontrol')\. |

<a name='WCSharp.Shared.Util.EnumeratePlayers()'></a>

## Util\.EnumeratePlayers\(\) Method

Returns all players\.

```csharp
public static System.Collections.Generic.IEnumerable<WCSharp.Api.player> EnumeratePlayers();
```

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[WCSharp\.Api\.player](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.player 'WCSharp\.Api\.player')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol)'></a>

## Util\.EnumeratePlayers\(playerslotstate, mapcontrol\) Method

Returns all players matching the given [playerslotstate](WCSharp.Shared.Util.md#WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol).playerslotstate 'WCSharp\.Shared\.Util\.EnumeratePlayers\(WCSharp\.Api\.playerslotstate, WCSharp\.Api\.mapcontrol\)\.playerslotstate') and [mapcontrol](WCSharp.Shared.Util.md#WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol).mapcontrol 'WCSharp\.Shared\.Util\.EnumeratePlayers\(WCSharp\.Api\.playerslotstate, WCSharp\.Api\.mapcontrol\)\.mapcontrol')\.

```csharp
public static System.Collections.Generic.IEnumerable<WCSharp.Api.player> EnumeratePlayers(WCSharp.Api.playerslotstate playerslotstate=null, WCSharp.Api.mapcontrol mapcontrol=null);
```
#### Parameters

<a name='WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol).playerslotstate'></a>

`playerslotstate` [WCSharp\.Api\.playerslotstate](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.playerslotstate 'WCSharp\.Api\.playerslotstate')

The [WCSharp\.Api\.playerslotstate](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.playerslotstate 'WCSharp\.Api\.playerslotstate') that players should have\. Defaults to [WCSharp\.Api\.Common\.PLAYER\_SLOT\_STATE\_PLAYING](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.common.player_slot_state_playing 'WCSharp\.Api\.Common\.PLAYER\_SLOT\_STATE\_PLAYING')\.

<a name='WCSharp.Shared.Util.EnumeratePlayers(WCSharp.Api.playerslotstate,WCSharp.Api.mapcontrol).mapcontrol'></a>

`mapcontrol` [WCSharp\.Api\.mapcontrol](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.mapcontrol 'WCSharp\.Api\.mapcontrol')

The [WCSharp\.Api\.mapcontrol](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.mapcontrol 'WCSharp\.Api\.mapcontrol') that players should have\. Defaults to [WCSharp\.Api\.Common\.MAP\_CONTROL\_USER](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.common.map_control_user 'WCSharp\.Api\.Common\.MAP\_CONTROL\_USER')\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[WCSharp\.Api\.player](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.player 'WCSharp\.Api\.player')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')