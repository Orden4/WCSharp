#### [WCSharp.SaveLoad](README.md 'README')
### [WCSharp.SaveLoad](WCSharp.SaveLoad.md 'WCSharp.SaveLoad').[SaveSystem&lt;T&gt;](WCSharp.SaveLoad.SaveSystem_T_.md 'WCSharp.SaveLoad.SaveSystem<T>')

## SaveSystem<T>.Load(player, int) Method

Loads a save for the given player on the given save slot.  
  
If no save exists on the given slot, or if loading failed for any reason, a new, empty save will be returned.  
  
Use [OnSaveLoaded](WCSharp.SaveLoad.SaveSystem_T_.OnSaveLoaded.md 'WCSharp.SaveLoad.SaveSystem<T>.OnSaveLoaded') to receive the save.

```csharp
public void Load(War3Api.Common.player player, int saveSlot=1);
```
#### Parameters

<a name='WCSharp.SaveLoad.SaveSystem_T_.Load(War3Api.Common.player,int).player'></a>

`player` [War3Api.Common.player](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.player 'War3Api.Common.player')

The player to create the save for.

<a name='WCSharp.SaveLoad.SaveSystem_T_.Load(War3Api.Common.player,int).saveSlot'></a>

`saveSlot` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The slot to save to.