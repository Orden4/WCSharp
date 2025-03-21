#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared.Extensions](WCSharp.Shared.Extensions.md 'WCSharp.Shared.Extensions').[IListExtensions](WCSharp.Shared.Extensions.IListExtensions.md 'WCSharp.Shared.Extensions.IListExtensions')

## IListExtensions.Nil<T>(this List<T>) Method

Abuses how lists work in lua in order to cheaply remove the final element.  
  
If you already know the size of the list, use [Nil&lt;T&gt;(this List&lt;T&gt;, int)](WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int).md 'WCSharp.Shared.Extensions.IListExtensions.Nil<T>(this System.Collections.Generic.List<T>, int)') instead.

```csharp
public static void Nil<T>(this System.Collections.Generic.List<T> list);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_).list'></a>

`list` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_).md#WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_).T 'WCSharp.Shared.Extensions.IListExtensions.Nil<T>(this System.Collections.Generic.List<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

The list to modify.