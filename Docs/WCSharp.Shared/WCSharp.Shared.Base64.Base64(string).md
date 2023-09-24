#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared').[Base64](WCSharp.Shared.Base64.md 'WCSharp.Shared.Base64')

## Base64(string) Constructor

Creates a new Base64 generator with the given character set.  
  
A custom character set must be exactly 64 characters long and use the same set of characters as regular Base64. You can only change the order.  
  
Default: ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/

```csharp
public Base64(string charset="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/");
```
#### Parameters

<a name='WCSharp.Shared.Base64.Base64(string).charset'></a>

`charset` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')