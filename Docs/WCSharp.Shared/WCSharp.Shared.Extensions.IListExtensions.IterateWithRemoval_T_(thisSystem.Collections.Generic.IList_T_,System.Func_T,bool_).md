#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions').[IListExtensions](WCSharp.Shared.Extensions.IListExtensions.md 'WCSharp\.Shared\.Extensions\.IListExtensions')

## IListExtensions\.IterateWithRemoval\<T\>\(this IList\<T\>, Func\<T,bool\>\) Method

Due to C\# to Lua conversion difficulties, standard ways of enumerating a list while removing items from it may not work\.
This extension method will safely iterate the list, and remove any which return false\.

Alternatively, you can use a standard reverse order iteration, as this will still work correctly.

```csharp
public static void IterateWithRemoval<T>(this System.Collections.Generic.IList<T> list, System.Func<T,bool> func);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.IterateWithRemoval_T_(thisSystem.Collections.Generic.IList_T_,System.Func_T,bool_).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.IterateWithRemoval_T_(thisSystem.Collections.Generic.IList_T_,System.Func_T,bool_).list'></a>

`list` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[T](WCSharp.Shared.Extensions.IListExtensions.IterateWithRemoval_T_(thisSystem.Collections.Generic.IList_T_,System.Func_T,bool_).md#WCSharp.Shared.Extensions.IListExtensions.IterateWithRemoval_T_(thisSystem.Collections.Generic.IList_T_,System.Func_T,bool_).T 'WCSharp\.Shared\.Extensions\.IListExtensions\.IterateWithRemoval\<T\>\(this System\.Collections\.Generic\.IList\<T\>, System\.Func\<T,bool\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

<a name='WCSharp.Shared.Extensions.IListExtensions.IterateWithRemoval_T_(thisSystem.Collections.Generic.IList_T_,System.Func_T,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](WCSharp.Shared.Extensions.IListExtensions.IterateWithRemoval_T_(thisSystem.Collections.Generic.IList_T_,System.Func_T,bool_).md#WCSharp.Shared.Extensions.IListExtensions.IterateWithRemoval_T_(thisSystem.Collections.Generic.IList_T_,System.Func_T,bool_).T 'WCSharp\.Shared\.Extensions\.IListExtensions\.IterateWithRemoval\<T\>\(this System\.Collections\.Generic\.IList\<T\>, System\.Func\<T,bool\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')