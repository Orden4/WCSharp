#### [WCSharp.SaveLoad](README.md 'README')
### [WCSharp.SaveLoad](WCSharp.SaveLoad.md 'WCSharp.SaveLoad').[SaveSystemOptions](WCSharp.SaveLoad.SaveSystemOptions.md 'WCSharp.SaveLoad.SaveSystemOptions')

## SaveSystemOptions.Hash2 Property

Must be greater than 0. It is recommended to simply pick any prime number from [http://www.mathematical.com/primes0to1000k.html](http://www.mathematical.com/primes0to1000k.html 'http://www.mathematical.com/primes0to1000k.html') or a similar site.  
  
This should never be changed after release of a map, as changing it will invalidate all existing save files.

```csharp
public int Hash2 { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')