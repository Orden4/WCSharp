#### [WCSharp\.DateTime](README.md 'README')
### [WCSharp\.DateTime](WCSharp.DateTime.md 'WCSharp\.DateTime').[WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp\.DateTime\.WcDateTime')

## WcDateTime\.ToString Method

| Overloads | |
| :--- | :--- |
| [ToString\(\)](WCSharp.DateTime.WcDateTime.ToString.md#WCSharp.DateTime.WcDateTime.ToString() 'WCSharp\.DateTime\.WcDateTime\.ToString\(\)') | Outputs this [WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp\.DateTime\.WcDateTime') in the default format of "yyyy\-MM\-dd HH:mm:ss"\. |
| [ToString\(string\)](WCSharp.DateTime.WcDateTime.ToString.md#WCSharp.DateTime.WcDateTime.ToString(string) 'WCSharp\.DateTime\.WcDateTime\.ToString\(string\)') | Returns a string representation using the given format\.   Supports standard C# format specifiers for year, month, day, hour, minute and second.  See the wiki for more information on the format specification.  Alternatively, use [Format\(string\)](WCSharp.DateTime.WcDateTime.Format(string).md 'WCSharp\.DateTime\.WcDateTime\.Format\(string\)') for a C/Lua style format. |

<a name='WCSharp.DateTime.WcDateTime.ToString()'></a>

## WcDateTime\.ToString\(\) Method

Outputs this [WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp\.DateTime\.WcDateTime') in the default format of "yyyy\-MM\-dd HH:mm:ss"\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='WCSharp.DateTime.WcDateTime.ToString(string)'></a>

## WcDateTime\.ToString\(string\) Method

Returns a string representation using the given format\.

Supports standard C# format specifiers for year, month, day, hour, minute and second.

See the wiki for more information on the format specification.

Alternatively, use [Format\(string\)](WCSharp.DateTime.WcDateTime.Format(string).md 'WCSharp\.DateTime\.WcDateTime\.Format\(string\)') for a C/Lua style format.

```csharp
public string ToString(string format);
```
#### Parameters

<a name='WCSharp.DateTime.WcDateTime.ToString(string).format'></a>

`format` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The format to print the date in\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')