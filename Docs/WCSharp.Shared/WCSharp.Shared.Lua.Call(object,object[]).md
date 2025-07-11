#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared](WCSharp.Shared.md 'WCSharp\.Shared').[Lua](WCSharp.Shared.Lua.md 'WCSharp\.Shared\.Lua')

## Lua\.Call\(object, object\[\]\) Method

Converts into raw lua in the form of "obj\(args\)"\.

This works for functions with any number of arguments, including 0.

```csharp
public static object Call(object obj, params object[] args);
```
#### Parameters

<a name='WCSharp.Shared.Lua.Call(object,object[]).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

<a name='WCSharp.Shared.Lua.Call(object,object[]).args'></a>

`args` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')