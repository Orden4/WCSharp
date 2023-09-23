#### [WCSharp.Shared](index.md 'index')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared')

## Lua Class

Helper class for directly executing Lua without needing the __CSharpLua__ directive.  
  
This is only really useful if you cannot use __CSharpLua__, e.g. when making packages.

```csharp
public static class Lua
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Lua

| Methods | |
| :--- | :--- |
| [Call(object, object[])](WCSharp.Shared.Lua.Call(object,object[]).md 'WCSharp.Shared.Lua.Call(object, object[])') | Converts into raw lua in the form of "obj(args)".<br/><br/><br/>This works for functions with any number of arguments, including 0. |
| [End()](WCSharp.Shared.Lua.End().md 'WCSharp.Shared.Lua.End()') | Converts into raw lua in the form of "end" |
| [ForPairs(object, object, object)](WCSharp.Shared.Lua.ForPairs(object,object,object).md 'WCSharp.Shared.Lua.ForPairs(object, object, object)') | Converts into raw lua in the form of "for keyName,valueName in pairs(table) do" |
| [Load(string)](WCSharp.Shared.Lua.Load(string).md 'WCSharp.Shared.Lua.Load(string)') | Converts into raw lua in the form of "load(code)". |
