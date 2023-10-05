#### [WCSharp.SaveLoad](README.md 'README')
### [WCSharp.SaveLoad](WCSharp.SaveLoad.md 'WCSharp.SaveLoad')

## SaveSystemOptions Class

Defines a set of options for a [SaveSystem&lt;T&gt;](WCSharp.SaveLoad.SaveSystem_T_.md 'WCSharp.SaveLoad.SaveSystem<T>').  
  
The [SaveFolder](WCSharp.SaveLoad.SaveSystemOptions.SaveFolder.md 'WCSharp.SaveLoad.SaveSystemOptions.SaveFolder'), [Salt](WCSharp.SaveLoad.SaveSystemOptions.Salt.md 'WCSharp.SaveLoad.SaveSystemOptions.Salt'), [Hash1](WCSharp.SaveLoad.SaveSystemOptions.Hash1.md 'WCSharp.SaveLoad.SaveSystemOptions.Hash1') and [Hash2](WCSharp.SaveLoad.SaveSystemOptions.Hash2.md 'WCSharp.SaveLoad.SaveSystemOptions.Hash2') properties are required.

```csharp
public class SaveSystemOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SaveSystemOptions

| Properties | |
| :--- | :--- |
| [Base64Provider](WCSharp.SaveLoad.SaveSystemOptions.Base64Provider.md 'WCSharp.SaveLoad.SaveSystemOptions.Base64Provider') | Optional. The save is encoded in Base64, if you want, you can provide a custom Base64 provider to effectively scramble the save.<br/><br/><br/>This does not change much in terms of protection, but makes it harder for people to inspect save files.<br/><br/>This should never be changed after release of a map, as changing it will invalidate all existing save files. |
| [BindSavesToPlayerName](WCSharp.SaveLoad.SaveSystemOptions.BindSavesToPlayerName.md 'WCSharp.SaveLoad.SaveSystemOptions.BindSavesToPlayerName') | Whether saves are bound to the name of the player. If true, saves will have the player name contained in the filename,<br/>and upon loading this will be matched with the current player's name.<br/><br/><br/>Attempting to load a save tied to a different username will result in a new save file being created instead.<br/><br/>This should never be changed after release of a map, as changing it will invalidate all existing save files. |
| [Hash1](WCSharp.SaveLoad.SaveSystemOptions.Hash1.md 'WCSharp.SaveLoad.SaveSystemOptions.Hash1') | Must be greater than 0. It is recommended to simply pick any prime number from [http://www.mathematical.com/primes0to1000k.html](http://www.mathematical.com/primes0to1000k.html 'http://www.mathematical.com/primes0to1000k.html') or a similar site.<br/><br/><br/>This should never be changed after release of a map, as changing it will invalidate all existing save files. |
| [Hash2](WCSharp.SaveLoad.SaveSystemOptions.Hash2.md 'WCSharp.SaveLoad.SaveSystemOptions.Hash2') | Must be greater than 0. It is recommended to simply pick any prime number from [http://www.mathematical.com/primes0to1000k.html](http://www.mathematical.com/primes0to1000k.html 'http://www.mathematical.com/primes0to1000k.html') or a similar site.<br/><br/><br/>This should never be changed after release of a map, as changing it will invalidate all existing save files. |
| [Salt](WCSharp.SaveLoad.SaveSystemOptions.Salt.md 'WCSharp.SaveLoad.SaveSystemOptions.Salt') | May not be empty. The salt to use on the string. You can just type something random, or generate something with [https://www.random.org/strings/](https://www.random.org/strings/ 'https://www.random.org/strings/').<br/><br/><br/>You may use any length of salt, but around 16 is sufficient.<br/><br/>This should never be changed after release of a map, as changing it will invalidate all existing save files. |
| [SaveFolder](WCSharp.SaveLoad.SaveSystemOptions.SaveFolder.md 'WCSharp.SaveLoad.SaveSystemOptions.SaveFolder') | May not be empty. The folder in which to store the saves. |
| [Suffix](WCSharp.SaveLoad.SaveSystemOptions.Suffix.md 'WCSharp.SaveLoad.SaveSystemOptions.Suffix') | Optional. The given string will be added to the filename of any save stored. |
