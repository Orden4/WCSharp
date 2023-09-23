#### [WCSharp.SaveLoad](index.md 'index')
### [WCSharp.SaveLoad](WCSharp.SaveLoad.md 'WCSharp.SaveLoad').[SaveSystem&lt;T&gt;](WCSharp.SaveLoad.SaveSystem_T_.md 'WCSharp.SaveLoad.SaveSystem<T>')

## SaveSystem<T>.OnSaveLoadedHandler(T, LoadResult) Delegate

Event handler for when a save is loaded. The save will be instantiated even if it is empty or failed to load.

```csharp
public delegate void SaveSystem<T>.OnSaveLoadedHandler(T save, WCSharp.SaveLoad.LoadResult loadResult)
    where T : WCSharp.SaveLoad.Saveable;
```
#### Type parameters

<a name='WCSharp.SaveLoad.SaveSystem_T_.OnSaveLoadedHandler(T,WCSharp.SaveLoad.LoadResult).T'></a>

`T`
#### Parameters

<a name='WCSharp.SaveLoad.SaveSystem_T_.OnSaveLoadedHandler(T,WCSharp.SaveLoad.LoadResult).save'></a>

`save` [T](WCSharp.SaveLoad.SaveSystem_T_.OnSaveLoadedHandler(T,WCSharp.SaveLoad.LoadResult).md#WCSharp.SaveLoad.SaveSystem_T_.OnSaveLoadedHandler(T,WCSharp.SaveLoad.LoadResult).T 'WCSharp.SaveLoad.SaveSystem<T>.OnSaveLoadedHandler(T, WCSharp.SaveLoad.LoadResult).T')

The save that was loaded.

<a name='WCSharp.SaveLoad.SaveSystem_T_.OnSaveLoadedHandler(T,WCSharp.SaveLoad.LoadResult).loadResult'></a>

`loadResult` [LoadResult](WCSharp.SaveLoad.LoadResult.md 'WCSharp.SaveLoad.LoadResult')

Indicates the state of the loaded save file, i.e. whether it's a newly created save, an existing save, or if it failed to load.