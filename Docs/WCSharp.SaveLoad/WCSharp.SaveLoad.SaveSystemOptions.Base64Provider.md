#### [WCSharp.SaveLoad](README.md 'README')
### [WCSharp.SaveLoad](WCSharp.SaveLoad.md 'WCSharp.SaveLoad').[SaveSystemOptions](WCSharp.SaveLoad.SaveSystemOptions.md 'WCSharp.SaveLoad.SaveSystemOptions')

## SaveSystemOptions.Base64Provider Property

Optional. The save is encoded in Base64, if you want, you can provide a custom Base64 provider to effectively scramble the save.  
  
This does not change much in terms of protection, but makes it harder for people to inspect save files.  
  
This should never be changed after release of a map, as changing it will invalidate all existing save files.

```csharp
public WCSharp.Shared.Base64 Base64Provider { get; set; }
```

#### Property Value
[Base64](../WCSharp.Shared/WCSharp.Shared.Base64.md 'WCSharp.Shared.Base64')