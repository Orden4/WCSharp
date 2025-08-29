#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions').[SpecializedExtensions](WCSharp.Shared.Extensions.SpecializedExtensions.md 'WCSharp\.Shared\.Extensions\.SpecializedExtensions')

## SpecializedExtensions\.DirectGet\<T\>\(this IList\<T\>, int\) Method

Slightly more efficient way to get an item from a list\.

<b>Warning:</b> When using direct methods, indexing is 1-based.

<b>Warning:</b> Do not use if the value may be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null').

<b>Warning:</b> Does not check for bounds.

```csharp
public static T DirectGet<T>(this System.Collections.Generic.IList<T> list, int index);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectGet_T_(thisSystem.Collections.Generic.IList_T_,int).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectGet_T_(thisSystem.Collections.Generic.IList_T_,int).list'></a>

`list` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[T](WCSharp.Shared.Extensions.SpecializedExtensions.DirectGet_T_(thisSystem.Collections.Generic.IList_T_,int).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectGet_T_(thisSystem.Collections.Generic.IList_T_,int).T 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectGet\<T\>\(this System\.Collections\.Generic\.IList\<T\>, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The list to retrieve from\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectGet_T_(thisSystem.Collections.Generic.IList_T_,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index to get\.

#### Returns
[T](WCSharp.Shared.Extensions.SpecializedExtensions.DirectGet_T_(thisSystem.Collections.Generic.IList_T_,int).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectGet_T_(thisSystem.Collections.Generic.IList_T_,int).T 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectGet\<T\>\(this System\.Collections\.Generic\.IList\<T\>, int\)\.T')