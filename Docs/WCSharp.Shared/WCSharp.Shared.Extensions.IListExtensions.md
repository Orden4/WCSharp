#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared.Extensions](WCSharp.Shared.Extensions.md 'WCSharp.Shared.Extensions')

## IListExtensions Class

Extension class that defines a number of methods to simplify working with lists, in particular within context of Warcraft III.

```csharp
public static class IListExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IListExtensions

| Methods | |
| :--- | :--- |
| [ClearLast&lt;T&gt;(this List&lt;T&gt;, int)](WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int).md 'WCSharp.Shared.Extensions.IListExtensions.ClearLast<T>(this System.Collections.Generic.List<T>, int)') | Abuses how lists work in lua in order to cheaply remove the final elements. |
| [ClearLast&lt;T&gt;(this List&lt;T&gt;, int, int)](WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int,int).md 'WCSharp.Shared.Extensions.IListExtensions.ClearLast<T>(this System.Collections.Generic.List<T>, int, int)') | Abuses how lists work in lua in order to cheaply remove the final elements.<br/><br/><br/>WARNING! If [count](WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int,int).md#WCSharp.Shared.Extensions.IListExtensions.ClearLast_T_(thisSystem.Collections.Generic.List_T_,int,int).count 'WCSharp.Shared.Extensions.IListExtensions.ClearLast<T>(this System.Collections.Generic.List<T>, int, int).count') is NOT equal to [System.Collections.Generic.List&lt;&gt;.Count](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1.Count 'System.Collections.Generic.List`1.Count'), you WILL cause major bugs! |
| [IterateWithRemoval&lt;T&gt;(this IList&lt;T&gt;, Func&lt;T,bool&gt;)](WCSharp.Shared.Extensions.IListExtensions.IterateWithRemoval_T_(thisSystem.Collections.Generic.IList_T_,System.Func_T,bool_).md 'WCSharp.Shared.Extensions.IListExtensions.IterateWithRemoval<T>(this System.Collections.Generic.IList<T>, System.Func<T,bool>)') | Due to C# to Lua conversion difficulties, standard ways of enumerating a list while removing items from it may not work.<br/>This extension method will safely iterate the list, and remove any which return false.<br/><br/><br/>Alternatively, you can use a standard reverse order iteration, as this will still work correctly. |
| [Nil&lt;T&gt;(this List&lt;T&gt;)](WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_).md 'WCSharp.Shared.Extensions.IListExtensions.Nil<T>(this System.Collections.Generic.List<T>)') | Abuses how lists work in lua in order to cheaply remove the final element.<br/><br/><br/>If you already know the size of the list, use [Nil&lt;T&gt;(this List&lt;T&gt;, int)](WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int).md 'WCSharp.Shared.Extensions.IListExtensions.Nil<T>(this System.Collections.Generic.List<T>, int)') instead. |
| [Nil&lt;T&gt;(this List&lt;T&gt;, int)](WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int).md 'WCSharp.Shared.Extensions.IListExtensions.Nil<T>(this System.Collections.Generic.List<T>, int)') | Abuses how lists work in lua in order to cheaply remove the final element.<br/><br/><br/>WARNING! If [count](WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int).md#WCSharp.Shared.Extensions.IListExtensions.Nil_T_(thisSystem.Collections.Generic.List_T_,int).count 'WCSharp.Shared.Extensions.IListExtensions.Nil<T>(this System.Collections.Generic.List<T>, int).count') is NOT equal to [System.Collections.Generic.List&lt;&gt;.Count](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1.Count 'System.Collections.Generic.List`1.Count'), you WILL cause major bugs! |
