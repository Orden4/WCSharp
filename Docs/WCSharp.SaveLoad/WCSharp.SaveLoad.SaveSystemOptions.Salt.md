#### [WCSharp.SaveLoad](index.md 'index')
### [WCSharp.SaveLoad](WCSharp.SaveLoad.md 'WCSharp.SaveLoad').[SaveSystemOptions](WCSharp.SaveLoad.SaveSystemOptions.md 'WCSharp.SaveLoad.SaveSystemOptions')

## SaveSystemOptions.Salt Property

May not be empty. The salt to use on the string. You can just type something random, or generate something with [https://www.random.org/strings/](https://www.random.org/strings/ 'https://www.random.org/strings/').  
  
You may use any length of salt, but around 16 is sufficient.  
  
This should never be changed after release of a map, as changing it will invalidate all existing save files.

```csharp
public string Salt { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')