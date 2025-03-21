#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared.Extensions](WCSharp.Shared.Extensions.md 'WCSharp.Shared.Extensions').[IListExtensions](WCSharp.Shared.Extensions.IListExtensions.md 'WCSharp.Shared.Extensions.IListExtensions')

## IListExtensions.ClearLast<T>(this List<T>, int) Method

Abuses how lists work in lua in order to cheaply remove the final elements.

```csharp
public static void ClearLast<T>(this System.Collections.Generic.List<T> list, int amount);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int).list'></a>

`list` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int).md#WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int).T 'WCSharp.Shared.Extensions.IListExtensions.ClearLast<T>(this System.Collections.Generic.List<T>, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

The list to modify.

<a name='WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int).amount'></a>

`amount` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of elements to remove.