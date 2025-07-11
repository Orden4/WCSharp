#### [WCSharp\.DateTime](README.md 'README')
### [WCSharp\.DateTime](WCSharp.DateTime.md 'WCSharp\.DateTime').[WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp\.DateTime\.WcDateTime')

## WcDateTime\.Format\(string\) Method

Formats the given time in seconds according to the given format\.

For more information regarding the format, see [http://www\.cplusplus\.com/reference/ctime/strftime/](http://www.cplusplus.com/reference/ctime/strftime/ 'http://www\.cplusplus\.com/reference/ctime/strftime/').

Alternatively, use [ToString\(string\)](WCSharp.DateTime.WcDateTime.ToString.md#WCSharp.DateTime.WcDateTime.ToString(string) 'WCSharp\.DateTime\.WcDateTime\.ToString\(string\)') for a C# style format.

```csharp
public string Format(string format);
```
#### Parameters

<a name='WCSharp.DateTime.WcDateTime.Format(string).format'></a>

`format` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The format to print the date in\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')