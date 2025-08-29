#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions').[SpecializedExtensions](WCSharp.Shared.Extensions.SpecializedExtensions.md 'WCSharp\.Shared\.Extensions\.SpecializedExtensions')

## SpecializedExtensions\.DirectSwap\<T\>\(this IList\<T\>, int, int\) Method

Slightly more efficient way to swap two items in a list\.

<b>Warning:</b> When using direct methods, indexing is 1-based.

<b>Warning:</b> Does not check for bounds.

<b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.

```csharp
public static void DirectSwap<T>(this System.Collections.Generic.IList<T> list, int first, int second);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectSwap_T_(thisSystem.Collections.Generic.IList_T_,int,int).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectSwap_T_(thisSystem.Collections.Generic.IList_T_,int,int).list'></a>

`list` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[T](WCSharp.Shared.Extensions.SpecializedExtensions.DirectSwap_T_(thisSystem.Collections.Generic.IList_T_,int,int).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectSwap_T_(thisSystem.Collections.Generic.IList_T_,int,int).T 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectSwap\<T\>\(this System\.Collections\.Generic\.IList\<T\>, int, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The list to modify\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectSwap_T_(thisSystem.Collections.Generic.IList_T_,int,int).first'></a>

`first` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The first index\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectSwap_T_(thisSystem.Collections.Generic.IList_T_,int,int).second'></a>

`second` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The second index\.