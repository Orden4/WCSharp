#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions').[IListExtensions](WCSharp.Shared.Extensions.IListExtensions.md 'WCSharp\.Shared\.Extensions\.IListExtensions')

## IListExtensions\.Nil Method

| Overloads | |
| :--- | :--- |
| [Nil&lt;T&gt;\(this List&lt;T&gt;\)](WCSharp.Shared.Extensions.IListExtensions.Nil.md#WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_) 'WCSharp\.Shared\.Extensions\.IListExtensions\.Nil\<T\>\(this System\.Collections\.Generic\.List\<T\>\)') | Abuses how lists work in lua in order to cheaply remove the final element\.   If you already know the size of the list, use [Nil&lt;T&gt;\(this List&lt;T&gt;, int\)](WCSharp.Shared.Extensions.IListExtensions.Nil.md#WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int) 'WCSharp\.Shared\.Extensions\.IListExtensions\.Nil\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)') instead. |
| [Nil&lt;T&gt;\(this List&lt;T&gt;, int\)](WCSharp.Shared.Extensions.IListExtensions.Nil.md#WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int) 'WCSharp\.Shared\.Extensions\.IListExtensions\.Nil\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)') | Abuses how lists work in lua in order to cheaply remove the final element\.   WARNING! If [count](WCSharp.Shared.Extensions.IListExtensions.md#WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int).count 'WCSharp\.Shared\.Extensions\.IListExtensions\.Nil\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)\.count') is NOT equal to [System\.Collections\.Generic\.List&lt;&gt;\.Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count 'System\.Collections\.Generic\.List\`1\.Count'), you WILL cause major bugs! |

<a name='WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_)'></a>

## IListExtensions\.Nil\<T\>\(this List\<T\>\) Method

Abuses how lists work in lua in order to cheaply remove the final element\.

If you already know the size of the list, use [Nil&lt;T&gt;\(this List&lt;T&gt;, int\)](WCSharp.Shared.Extensions.IListExtensions.Nil.md#WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int) 'WCSharp\.Shared\.Extensions\.IListExtensions\.Nil\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)') instead.

```csharp
public static void Nil<T>(this System.Collections.Generic.List<T> list);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_).list'></a>

`list` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](WCSharp.Shared.Extensions.IListExtensions.md#WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_).T 'WCSharp\.Shared\.Extensions\.IListExtensions\.Nil\<T\>\(this System\.Collections\.Generic\.List\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to modify\.

<a name='WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int)'></a>

## IListExtensions\.Nil\<T\>\(this List\<T\>, int\) Method

Abuses how lists work in lua in order to cheaply remove the final element\.

WARNING! If [count](WCSharp.Shared.Extensions.IListExtensions.md#WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int).count 'WCSharp\.Shared\.Extensions\.IListExtensions\.Nil\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)\.count') is NOT equal to [System\.Collections\.Generic\.List&lt;&gt;\.Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count 'System\.Collections\.Generic\.List\`1\.Count'), you WILL cause major bugs!

```csharp
public static void Nil<T>(this System.Collections.Generic.List<T> list, int count);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int).list'></a>

`list` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](WCSharp.Shared.Extensions.IListExtensions.md#WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int).T 'WCSharp\.Shared\.Extensions\.IListExtensions\.Nil\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to modify\.

<a name='WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

This MUST be equal to [System\.Collections\.Generic\.List&lt;&gt;\.Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count 'System\.Collections\.Generic\.List\`1\.Count'), else you WILL cause major bugs\!