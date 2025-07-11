#### [WCSharp\.SaveLoad](README.md 'README')
### [WCSharp\.SaveLoad](WCSharp.SaveLoad.md 'WCSharp\.SaveLoad').[SaveableExtensions](WCSharp.SaveLoad.SaveableExtensions.md 'WCSharp\.SaveLoad\.SaveableExtensions')

## SaveableExtensions\.Clone\<T\>\(this T\) Method

Creates a clone of the given save by converting it to JSON and back, and re\-sets the player and save slot\.

Useful for if you want to create a clone to compare save data before and after a game.

```csharp
public static T Clone<T>(this T saveable)
    where T : WCSharp.SaveLoad.Saveable;
```
#### Type parameters

<a name='WCSharp.SaveLoad.SaveableExtensions.Clone_T_(thisT).T'></a>

`T`
#### Parameters

<a name='WCSharp.SaveLoad.SaveableExtensions.Clone_T_(thisT).saveable'></a>

`saveable` [T](WCSharp.SaveLoad.SaveableExtensions.Clone_T_(thisT).md#WCSharp.SaveLoad.SaveableExtensions.Clone_T_(thisT).T 'WCSharp\.SaveLoad\.SaveableExtensions\.Clone\<T\>\(this T\)\.T')

#### Returns
[T](WCSharp.SaveLoad.SaveableExtensions.Clone_T_(thisT).md#WCSharp.SaveLoad.SaveableExtensions.Clone_T_(thisT).T 'WCSharp\.SaveLoad\.SaveableExtensions\.Clone\<T\>\(this T\)\.T')