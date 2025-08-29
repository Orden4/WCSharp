#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions').[SpecializedExtensions](WCSharp.Shared.Extensions.SpecializedExtensions.md 'WCSharp\.Shared\.Extensions\.SpecializedExtensions')

## SpecializedExtensions\.DirectNil Method

| Overloads | |
| :--- | :--- |
| [DirectNil&lt;T&gt;\(this List&lt;T&gt;\)](WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil.md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_) 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNil\<T\>\(this System\.Collections\.Generic\.List\<T\>\)') | Abuses how lists work in lua in order to cheaply remove the final element\.   If you already know the size of the list, use [DirectNil&lt;T&gt;\(this List&lt;T&gt;, int\)](WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil.md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_,int) 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNil\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)') instead.  <b>Warning:</b> When using direct methods, indexing is 1-based.  <b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this. |
| [DirectNil&lt;T&gt;\(this List&lt;T&gt;, int\)](WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil.md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_,int) 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNil\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)') | Abuses how lists work in lua in order to cheaply remove the final element\.   <b>Warning:</b> When using direct methods, indexing is 1-based.  <b>Warning:</b>[count](WCSharp.Shared.Extensions.SpecializedExtensions.md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_,int).count 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNil\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)\.count') must be equal to [System\.Collections\.Generic\.List&lt;&gt;\.Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count 'System\.Collections\.Generic\.List\`1\.Count').  <b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this. |

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_)'></a>

## SpecializedExtensions\.DirectNil\<T\>\(this List\<T\>\) Method

Abuses how lists work in lua in order to cheaply remove the final element\.

If you already know the size of the list, use [DirectNil&lt;T&gt;\(this List&lt;T&gt;, int\)](WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil.md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_,int) 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNil\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)') instead.

<b>Warning:</b> When using direct methods, indexing is 1-based.

<b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.

```csharp
public static void DirectNil<T>(this System.Collections.Generic.List<T> list);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_).list'></a>

`list` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](WCSharp.Shared.Extensions.SpecializedExtensions.md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_).T 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNil\<T\>\(this System\.Collections\.Generic\.List\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to modify\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_,int)'></a>

## SpecializedExtensions\.DirectNil\<T\>\(this List\<T\>, int\) Method

Abuses how lists work in lua in order to cheaply remove the final element\.

<b>Warning:</b> When using direct methods, indexing is 1-based.

<b>Warning:</b>[count](WCSharp.Shared.Extensions.SpecializedExtensions.md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_,int).count 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNil\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)\.count') must be equal to [System\.Collections\.Generic\.List&lt;&gt;\.Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count 'System\.Collections\.Generic\.List\`1\.Count').

<b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.

```csharp
public static void DirectNil<T>(this System.Collections.Generic.List<T> list, int count);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_,int).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_,int).list'></a>

`list` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](WCSharp.Shared.Extensions.SpecializedExtensions.md#WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_,int).T 'WCSharp\.Shared\.Extensions\.SpecializedExtensions\.DirectNil\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to modify\.

<a name='WCSharp.Shared.Extensions.SpecializedExtensions.DirectNil_T_(thisSystem.Collections.Generic.List_T_,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

This should always be equal to [System\.Collections\.Generic\.List&lt;&gt;\.Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count 'System\.Collections\.Generic\.List\`1\.Count')\.