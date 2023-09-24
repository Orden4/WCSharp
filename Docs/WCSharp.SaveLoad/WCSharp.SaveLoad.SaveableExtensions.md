#### [WCSharp.SaveLoad](README.md 'README')
### [WCSharp.SaveLoad](WCSharp.SaveLoad.md 'WCSharp.SaveLoad')

## SaveableExtensions Class

Provides some type-explicit extension methods for [Saveable](WCSharp.SaveLoad.Saveable.md 'WCSharp.SaveLoad.Saveable')s.

```csharp
public static class SaveableExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SaveableExtensions

| Methods | |
| :--- | :--- |
| [Clone&lt;T&gt;(this T)](WCSharp.SaveLoad.SaveableExtensions.Clone_T_(thisT).md 'WCSharp.SaveLoad.SaveableExtensions.Clone<T>(this T)') | Creates a clone of the given save by converting it to JSON and back, and re-sets the player and save slot.<br/><br/><br/>Useful for if you want to create a clone to compare save data before and after a game. |
