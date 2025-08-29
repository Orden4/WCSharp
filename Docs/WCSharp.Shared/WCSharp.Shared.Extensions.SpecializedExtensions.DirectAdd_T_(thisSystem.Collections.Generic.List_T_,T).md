#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions').[SpecializedExtensions](WCSharp.Shared.Extensions.SpecializedExtensions.md 'WCSharp\.Shared\.Extensions\.SpecializedExtensions')

## SpecializedExtensions\.DirectAdd\<T\>\(this List\<T\>, T\) Method

Slightly more efficient way to add an item to an array or list\.

If you already know the size of the list, use [DirectSet&lt;T&gt;\(this IList&lt;T&gt;, T, int\)](WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).md 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectSet\<T\>\(this System\.Collections\.Generic\.IList\<T\>, T, int\)') instead.

<b>Warning:</b> When using direct methods, indexing is 1-based.

<b>Warning:</b> Do not use if [item](WCSharp.Shared.Extensions.SpecializedExtensions.DirectAdd_T_(thisSystem.Collections.Generic.List_T_,T).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectAdd_T_(thisSystem.Collections.Generic.List_T_,T).item 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectAdd\<T\>\(this System\.Collections\.Generic\.List\<T\>, T\)\.item') may be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null').

<b>Warning:</b> Does not check for bounds.

<b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.

```csharp
public static void DirectAdd<T>(this System.Collections.Generic.List<T> list, T item);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectAdd_T_(thisSystem.Collections.Generic.List_T_,T).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectAdd_T_(thisSystem.Collections.Generic.List_T_,T).list'></a>

`list` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](WCSharp.Shared.Extensions.SpecializedExtensions.DirectAdd_T_(thisSystem.Collections.Generic.List_T_,T).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectAdd_T_(thisSystem.Collections.Generic.List_T_,T).T 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectAdd\<T\>\(this System\.Collections\.Generic\.List\<T\>, T\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to modify\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectAdd_T_(thisSystem.Collections.Generic.List_T_,T).item'></a>

`item` [T](WCSharp.Shared.Extensions.SpecializedExtensions.DirectAdd_T_(thisSystem.Collections.Generic.List_T_,T).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectAdd_T_(thisSystem.Collections.Generic.List_T_,T).T 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectAdd\<T\>\(this System\.Collections\.Generic\.List\<T\>, T\)\.T')

The item to add\.