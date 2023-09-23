### [WCSharp.DateTime](WCSharp.DateTime.md 'WCSharp.DateTime').[WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp.DateTime.WcDateTime')

## WcDateTime.Deserialize(string) Method

Attempts to parse the given string as the number of seconds since January 1st, 1970.

```csharp
public static WCSharp.DateTime.WcDateTime Deserialize(string @string);
```
#### Parameters

<a name='WCSharp.DateTime.WcDateTime.Deserialize(string).string'></a>

`string` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Returns
[WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp.DateTime.WcDateTime')  
Null if [string](WCSharp.DateTime.WcDateTime.Deserialize(string).md#WCSharp.DateTime.WcDateTime.Deserialize(string).string 'WCSharp.DateTime.WcDateTime.Deserialize(string).string') is not a valid integer.