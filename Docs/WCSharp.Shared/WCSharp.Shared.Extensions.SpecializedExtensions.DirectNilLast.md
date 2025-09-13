#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions').[SpecializedExtensions](WCSharp.Shared.Extensions.SpecializedExtensions.md 'WCSharp\.Shared\.Extensions\.SpecializedExtensions')

## SpecializedExtensions\.DirectNilLast Method

| Overloads | |
| :--- | :--- |
| [DirectNilLast&lt;T&gt;\(this List&lt;T&gt;, int\)](WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast.md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast_T_(thisSystem.Collections.Generic.List_T_,int) 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNilLast\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)') | Slightly more efficient way to remove the final elements in a list\.   <b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this. |
| [DirectNilLast&lt;T&gt;\(this List&lt;T&gt;, int, int\)](WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast.md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast_T_(thisSystem.Collections.Generic.List_T_,int,int) 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNilLast\<T\>\(this System\.Collections\.Generic\.List\<T\>, int, int\)') | Slightly more efficient way to remove the final elements in a list\.   <b>Warning:</b> Does not check for bounds.  <b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this. |

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast_T_(thisSystem.Collections.Generic.List_T_,int)'></a>

## SpecializedExtensions\.DirectNilLast\<T\>\(this List\<T\>, int\) Method

Slightly more efficient way to remove the final elements in a list\.

<b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.

```csharp
public static void DirectNilLast<T>(this System.Collections.Generic.List<T> list, int amount);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast_T_(thisSystem.Collections.Generic.List_T_,int).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast_T_(thisSystem.Collections.Generic.List_T_,int).list'></a>

`list` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](WCSharp.Shared.Extensions.SpecializedExtensions.md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast_T_(thisSystem.Collections.Generic.List_T_,int).T 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNilLast\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to modify\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast_T_(thisSystem.Collections.Generic.List_T_,int).amount'></a>

`amount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of elements to remove\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast_T_(thisSystem.Collections.Generic.List_T_,int,int)'></a>

## SpecializedExtensions\.DirectNilLast\<T\>\(this List\<T\>, int, int\) Method

Slightly more efficient way to remove the final elements in a list\.

<b>Warning:</b> Does not check for bounds.

<b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.

```csharp
public static void DirectNilLast<T>(this System.Collections.Generic.List<T> list, int amount, int count);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast_T_(thisSystem.Collections.Generic.List_T_,int,int).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast_T_(thisSystem.Collections.Generic.List_T_,int,int).list'></a>

`list` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](WCSharp.Shared.Extensions.SpecializedExtensions.md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast_T_(thisSystem.Collections.Generic.List_T_,int,int).T 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNilLast\<T\>\(this System\.Collections\.Generic\.List\<T\>, int, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to modify\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast_T_(thisSystem.Collections.Generic.List_T_,int,int).amount'></a>

`amount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of elements to remove\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNilLast_T_(thisSystem.Collections.Generic.List_T_,int,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

This must be equal to [System\.Collections\.Generic\.List&lt;&gt;\.Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count 'System\.Collections\.Generic\.List\`1\.Count')\.