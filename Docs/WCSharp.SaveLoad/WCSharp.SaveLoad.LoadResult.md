#### [WCSharp.SaveLoad](README.md 'README')
### [WCSharp.SaveLoad](WCSharp.SaveLoad.md 'WCSharp.SaveLoad')

## LoadResult Enum

Indicates the state of the loaded save file.

```csharp
public enum LoadResult
```
### Fields

<a name='WCSharp.SaveLoad.LoadResult.FailedDecode'></a>

`FailedDecode` 1

Indicates that the Base64 decoding of the save failed.  
  
This could be the result of a faulty version upgrade, or because the save was tampered with.

<a name='WCSharp.SaveLoad.LoadResult.FailedDeserialize'></a>

`FailedDeserialize` 2

Indicates that the deserialization of the save failed.  
  
This is likely the result of a faulty version upgrade, but could also indicate save tampering.

<a name='WCSharp.SaveLoad.LoadResult.FailedHash'></a>

`FailedHash` 3

Indicates that the hash of the save did not match.  
  
This likely means that the save was tampered with.

<a name='WCSharp.SaveLoad.LoadResult.NewSave'></a>

`NewSave` 0

Indicates that no existing save was found and a new one was created.

<a name='WCSharp.SaveLoad.LoadResult.Success'></a>

`Success` 4

Indicates that an existing save was loaded successfully.