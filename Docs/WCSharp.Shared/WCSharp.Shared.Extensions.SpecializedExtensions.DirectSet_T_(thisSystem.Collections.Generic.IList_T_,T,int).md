#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions').[SpecializedExtensions](WCSharp.Shared.Extensions.SpecializedExtensions.md 'WCSharp\.Shared\.Extensions\.SpecializedExtensions')

## SpecializedExtensions\.DirectSet\<T\>\(this IList\<T\>, T, int\) Method

Slightly more efficient way to set or add an item to a list\.

Can be used to add as long as [index](WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).index 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectSet\<T\>\(this System\.Collections\.Generic\.IList\<T\>, T, int\)\.index') is equal to [list](WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).list 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectSet\<T\>\(this System\.Collections\.Generic\.IList\<T\>, T, int\)\.list').Count.

<b>Warning:</b> When using direct methods, indexing is 1-based.

<b>Warning:</b> Do not use if [item](WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).item 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectSet\<T\>\(this System\.Collections\.Generic\.IList\<T\>, T, int\)\.item') may be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null').

<b>Warning:</b> Does not check for bounds.

<b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.

```csharp
public static void DirectSet<T>(this System.Collections.Generic.IList<T> list, T item, int index);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).list'></a>

`list` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[T](WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).T 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectSet\<T\>\(this System\.Collections\.Generic\.IList\<T\>, T, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The list to modify\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).item'></a>

`item` [T](WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).T 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectSet\<T\>\(this System\.Collections\.Generic\.IList\<T\>, T, int\)\.T')

The item to set/add\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectSet_T_(thisSystem.Collections.Generic.IList_T_,T,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index to place it at\.