#### [WCSharp.Shared](index.md 'index')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared')

## Base64 Class

Conversion courtesy of http://lua-users.org/wiki/BaseSixtyFour

```csharp
public class Base64
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Base64

| Constructors | |
| :--- | :--- |
| [Base64(string)](WCSharp.Shared.Base64.Base64(string).md 'WCSharp.Shared.Base64.Base64(string)') | Creates a new Base64 generator with the given character set.<br/><br/><br/>A custom character set must be exactly 64 characters long and use the same set of characters as regular Base64. You can only change the order.<br/><br/>Default: ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/ |

| Methods | |
| :--- | :--- |
| [Decode(string)](WCSharp.Shared.Base64.Decode(string).md 'WCSharp.Shared.Base64.Decode(string)') | Converts the given Base64 string into a regular string. |
| [Encode(string)](WCSharp.Shared.Base64.Encode(string).md 'WCSharp.Shared.Base64.Encode(string)') | Converts the given string into a Base64 string. |
| [FromBase64(string)](WCSharp.Shared.Base64.FromBase64(string).md 'WCSharp.Shared.Base64.FromBase64(string)') | Converts the given Base64 to text with the default character set. |
| [ToBase64(string)](WCSharp.Shared.Base64.ToBase64(string).md 'WCSharp.Shared.Base64.ToBase64(string)') | Converts the given text to Base64 with the default character set. |
