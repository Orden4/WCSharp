#### [WCSharp\.SaveLoad](README.md 'README')
### [WCSharp\.SaveLoad](WCSharp.SaveLoad.md 'WCSharp\.SaveLoad').[SaveSystemOptions](WCSharp.SaveLoad.SaveSystemOptions.md 'WCSharp\.SaveLoad\.SaveSystemOptions')

## SaveSystemOptions\.BindSavesToPlayerName Property

Whether saves are bound to the name of the player\. If true, saves will have the player name contained in the filename,
and upon loading this will be matched with the current player's name\.

Attempting to load a save tied to a different username will result in a new save file being created instead.

This should never be changed after release of a map, as changing it will invalidate all existing save files.

Defaults to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool').

```csharp
public bool BindSavesToPlayerName { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')