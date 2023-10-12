#### [WCSharp.SaveLoad](README.md 'README')
### [WCSharp.SaveLoad](WCSharp.SaveLoad.md 'WCSharp.SaveLoad')

## SaveSystem<T> Class

System capable of saving C# data structures on a players local files to create save files that can be loaded at a later date/map.

```csharp
public class SaveSystem<T> :
System.IDisposable
    where T : WCSharp.SaveLoad.Saveable
```
#### Type parameters

<a name='WCSharp.SaveLoad.SaveSystem_T_.T'></a>

`T`

The [Saveable](WCSharp.SaveLoad.Saveable.md 'WCSharp.SaveLoad.Saveable') type that this instance will be saving/loading

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SaveSystem<T>

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

| Constructors | |
| :--- | :--- |
| [SaveSystem(SaveSystemOptions)](WCSharp.SaveLoad.SaveSystem_T_.SaveSystem(WCSharp.SaveLoad.SaveSystemOptions).md 'WCSharp.SaveLoad.SaveSystem<T>.SaveSystem(WCSharp.SaveLoad.SaveSystemOptions)') | Creates a new [SaveSystem&lt;T&gt;](WCSharp.SaveLoad.SaveSystem_T_.md 'WCSharp.SaveLoad.SaveSystem<T>') instance with the given [options](WCSharp.SaveLoad.SaveSystem_T_.SaveSystem(WCSharp.SaveLoad.SaveSystemOptions).md#WCSharp.SaveLoad.SaveSystem_T_.SaveSystem(WCSharp.SaveLoad.SaveSystemOptions).options 'WCSharp.SaveLoad.SaveSystem<T>.SaveSystem(WCSharp.SaveLoad.SaveSystemOptions).options'). |

| Methods | |
| :--- | :--- |
| [Dispose()](WCSharp.SaveLoad.SaveSystem_T_.Dispose().md 'WCSharp.SaveLoad.SaveSystem<T>.Dispose()') | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. |
| [Load(player, int)](WCSharp.SaveLoad.SaveSystem_T_.Load(WCSharp.Api.player,int).md 'WCSharp.SaveLoad.SaveSystem<T>.Load(WCSharp.Api.player, int)') | Loads a save for the given player on the given save slot.<br/><br/><br/>If no save exists on the given slot, or if loading failed for any reason, a new, empty save will be returned.<br/><br/>Use [OnSaveLoaded](WCSharp.SaveLoad.SaveSystem_T_.OnSaveLoaded.md 'WCSharp.SaveLoad.SaveSystem<T>.OnSaveLoaded') to receive the save. |
| [Save(T)](WCSharp.SaveLoad.SaveSystem_T_.Save(T).md 'WCSharp.SaveLoad.SaveSystem<T>.Save(T)') | Writes the given saveable to file for the player who owns the save. |

| Events | |
| :--- | :--- |
| [OnSaveLoaded](WCSharp.SaveLoad.SaveSystem_T_.OnSaveLoaded.md 'WCSharp.SaveLoad.SaveSystem<T>.OnSaveLoaded') | This event will be invoked when a new save is loaded in, providing the given class and a boolean indicating whether the save is newly created or not. |
