#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions').[SpecializedExtensions](WCSharp.Shared.Extensions.SpecializedExtensions.md 'WCSharp\.Shared\.Extensions\.SpecializedExtensions')

## SpecializedExtensions\.DirectNilShift\<T\>\(this List\<T\>, int, int\) Method

Moves the final element to the given index, then removes the final element\.

<b>Warning:</b> When using direct methods, indexing is 1-based.

<b>Warning:</b> Does not check for bounds.

<b>Warning:</b>[count](WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilShift_T_(thisSystem.Collections.Generic.List_T_,int,int).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilShift_T_(thisSystem.Collections.Generic.List_T_,int,int).count 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNilShift\<T\>\(this System\.Collections\.Generic\.List\<T\>, int, int\)\.count') must be equal to [System\.Collections\.Generic\.List&lt;&gt;\.Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count 'System\.Collections\.Generic\.List\`1\.Count').

<b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.

```csharp
public static void DirectNilShift<T>(this System.Collections.Generic.List<T> list, int index, int count);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilShift_T_(thisSystem.Collections.Generic.List_T_,int,int).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilShift_T_(thisSystem.Collections.Generic.List_T_,int,int).list'></a>

`list` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilShift_T_(thisSystem.Collections.Generic.List_T_,int,int).md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilShift_T_(thisSystem.Collections.Generic.List_T_,int,int).T 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNilShift\<T\>\(this System\.Collections\.Generic\.List\<T\>, int, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to modify\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilShift_T_(thisSystem.Collections.Generic.List_T_,int,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index to move the final item to\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilShift_T_(thisSystem.Collections.Generic.List_T_,int,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

This should always be equal to [System\.Collections\.Generic\.List&lt;&gt;\.Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count 'System\.Collections\.Generic\.List\`1\.Count')\.