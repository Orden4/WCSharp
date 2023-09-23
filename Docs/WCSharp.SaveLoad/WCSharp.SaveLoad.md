#### [WCSharp.SaveLoad](index.md 'index')

## WCSharp.SaveLoad Namespace

| Classes | |
| :--- | :--- |
| [LoadResultExtensions](WCSharp.SaveLoad.LoadResultExtensions.md 'WCSharp.SaveLoad.LoadResultExtensions') | Extension class for [LoadResult](WCSharp.SaveLoad.LoadResult.md 'WCSharp.SaveLoad.LoadResult')s. |
| [Saveable](WCSharp.SaveLoad.Saveable.md 'WCSharp.SaveLoad.Saveable') | Abstract class containing the definitions that the SaveSystem needs in order to save and load your custom save data. |
| [SaveableExtensions](WCSharp.SaveLoad.SaveableExtensions.md 'WCSharp.SaveLoad.SaveableExtensions') | Provides some type-explicit extension methods for [Saveable](WCSharp.SaveLoad.Saveable.md 'WCSharp.SaveLoad.Saveable')s. |
| [SaveSystem](WCSharp.SaveLoad.SaveSystem.md 'WCSharp.SaveLoad.SaveSystem') | Contains logic shared between all different generic [SaveSystem&lt;T&gt;](WCSharp.SaveLoad.SaveSystem_T_.md 'WCSharp.SaveLoad.SaveSystem<T>') instances. |
| [SaveSystem&lt;T&gt;](WCSharp.SaveLoad.SaveSystem_T_.md 'WCSharp.SaveLoad.SaveSystem<T>') | System capable of saving C# data structures on a players local files to create save files that can be loaded at a later date/map. |
| [SaveSystemOptions](WCSharp.SaveLoad.SaveSystemOptions.md 'WCSharp.SaveLoad.SaveSystemOptions') | Defines a set of options for a [SaveSystem&lt;T&gt;](WCSharp.SaveLoad.SaveSystem_T_.md 'WCSharp.SaveLoad.SaveSystem<T>').<br/><br/><br/>The [SaveFolder](WCSharp.SaveLoad.SaveSystemOptions.SaveFolder.md 'WCSharp.SaveLoad.SaveSystemOptions.SaveFolder'), [Salt](WCSharp.SaveLoad.SaveSystemOptions.Salt.md 'WCSharp.SaveLoad.SaveSystemOptions.Salt'), [Hash1](WCSharp.SaveLoad.SaveSystemOptions.Hash1.md 'WCSharp.SaveLoad.SaveSystemOptions.Hash1') and [Hash2](WCSharp.SaveLoad.SaveSystemOptions.Hash2.md 'WCSharp.SaveLoad.SaveSystemOptions.Hash2') properties are required. |

| Enums | |
| :--- | :--- |
| [LoadResult](WCSharp.SaveLoad.LoadResult.md 'WCSharp.SaveLoad.LoadResult') | Indicates the state of the loaded save file. |

| Delegates | |
| :--- | :--- |
| [SaveSystem&lt;T&gt;.OnSaveLoadedHandler(T, LoadResult)](WCSharp.SaveLoad.SaveSystem_T_.OnSaveLoadedHandler(T,WCSharp.SaveLoad.LoadResult).md 'WCSharp.SaveLoad.SaveSystem<T>.OnSaveLoadedHandler(T, WCSharp.SaveLoad.LoadResult)') | Event handler for when a save is loaded. The save will be instantiated even if it is empty or failed to load. |
