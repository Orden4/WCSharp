#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions').[SpecializedExtensions](WCSharp.Shared.Extensions.SpecializedExtensions.md 'WCSharp\.Shared\.Extensions\.SpecializedExtensions')

## SpecializedExtensions\.DirectMove\<T\>\(this IList\<T\>, int, int\) Method

Slightly more efficient way to move an item to another index\.

<b>Warning:</b> When using direct methods, indexing is 1-based.

<b>Warning:</b> Does not check for bounds.

<b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.

```csharp
public static void DirectMove<T>(this System.Collections.Generic.IList<T> list, int sourceIndex, int destinationIndex);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectMove_T_(thisSystem.Collections.Generic.IList_T_,int,int).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectMove_T_(thisSystem.Collections.Generic.IList_T_,int,int).list'></a>

`list` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[T](WCSharp.Shared.Extensions.SpecializedExtensions.DirectMove_T_(thisSystem.Collections.Generic.IList_T_,int,int).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectMove_T_(thisSystem.Collections.Generic.IList_T_,int,int).T 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectMove\<T\>\(this System\.Collections\.Generic\.IList\<T\>, int, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The list to modify\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectMove_T_(thisSystem.Collections.Generic.IList_T_,int,int).sourceIndex'></a>

`sourceIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the item to be moved\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectMove_T_(thisSystem.Collections.Generic.IList_T_,int,int).destinationIndex'></a>

`destinationIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index to move to\.