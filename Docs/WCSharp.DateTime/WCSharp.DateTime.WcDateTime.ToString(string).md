### [WCSharp.DateTime](WCSharp.DateTime.md 'WCSharp.DateTime').[WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp.DateTime.WcDateTime')

## WcDateTime.ToString(string) Method

Returns a string representation using the given format.  
  
Supports standard C# format specifiers for year, month, day, hour, minute and second.  
  
See the wiki for more information on the format specification.  
  
Alternatively, use [Format(string)](WCSharp.DateTime.WcDateTime.Format(string).md 'WCSharp.DateTime.WcDateTime.Format(string)') for a C/Lua style format.

```csharp
public string ToString(string format);
```
#### Parameters

<a name='WCSharp.DateTime.WcDateTime.ToString(string).format'></a>

`format` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The format to print the date in.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')