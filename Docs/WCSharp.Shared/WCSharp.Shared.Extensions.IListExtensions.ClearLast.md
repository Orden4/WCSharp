#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions').[IListExtensions](WCSharp.Shared.Extensions.IListExtensions.md 'WCSharp\.Shared\.Extensions\.IListExtensions')

## IListExtensions\.ClearLast Method

| Overloads | |
| :--- | :--- |
| [ClearLast&lt;T&gt;\(this List&lt;T&gt;, int\)](WCSharp.Shared.Extensions.IListExtensions.ClearLast.md#WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int) 'WCSharp\.Shared\.Extensions\.IListExtensions\.ClearLast\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)') | Abuses how lists work in lua in order to cheaply remove the final elements\. |
| [ClearLast&lt;T&gt;\(this List&lt;T&gt;, int, int\)](WCSharp.Shared.Extensions.IListExtensions.ClearLast.md#WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int,int) 'WCSharp\.Shared\.Extensions\.IListExtensions\.ClearLast\<T\>\(this System\.Collections\.Generic\.List\<T\>, int, int\)') | Abuses how lists work in lua in order to cheaply remove the final elements\.   WARNING! If [count](WCSharp.Shared.Extensions.IListExtensions.md#WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int,int).count 'WCSharp\.Shared\.Extensions\.IListExtensions\.ClearLast\<T\>\(this System\.Collections\.Generic\.List\<T\>, int, int\)\.count') is NOT equal to [System\.Collections\.Generic\.List&lt;&gt;\.Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count 'System\.Collections\.Generic\.List\`1\.Count'), you WILL cause major bugs! |

<a name='WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int)'></a>

## IListExtensions\.ClearLast\<T\>\(this List\<T\>, int\) Method

Abuses how lists work in lua in order to cheaply remove the final elements\.

```csharp
public static void ClearLast<T>(this System.Collections.Generic.List<T> list, int amount);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int).list'></a>

`list` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](WCSharp.Shared.Extensions.IListExtensions.md#WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int).T 'WCSharp\.Shared\.Extensions\.IListExtensions\.ClearLast\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to modify\.

<a name='WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int).amount'></a>

`amount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of elements to remove\.

<a name='WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int,int)'></a>

## IListExtensions\.ClearLast\<T\>\(this List\<T\>, int, int\) Method

Abuses how lists work in lua in order to cheaply remove the final elements\.

WARNING! If [count](WCSharp.Shared.Extensions.IListExtensions.md#WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int,int).count 'WCSharp\.Shared\.Extensions\.IListExtensions\.ClearLast\<T\>\(this System\.Collections\.Generic\.List\<T\>, int, int\)\.count') is NOT equal to [System\.Collections\.Generic\.List&lt;&gt;\.Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count 'System\.Collections\.Generic\.List\`1\.Count'), you WILL cause major bugs!

```csharp
public static void ClearLast<T>(this System.Collections.Generic.List<T> list, int amount, int count);
```
#### Type parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int,int).T'></a>

`T`
#### Parameters

<a name='WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int,int).list'></a>

`list` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](WCSharp.Shared.Extensions.IListExtensions.md#WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int,int).T 'WCSharp\.Shared\.Extensions\.IListExtensions\.ClearLast\<T\>\(this System\.Collections\.Generic\.List\<T\>, int, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to modify\.

<a name='WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int,int).amount'></a>

`amount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of elements to remove\.

<a name='WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

This MUST be equal to [System\.Collections\.Generic\.List&lt;&gt;\.Count](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count 'System\.Collections\.Generic\.List\`1\.Count'), else you WILL cause major bugs\!