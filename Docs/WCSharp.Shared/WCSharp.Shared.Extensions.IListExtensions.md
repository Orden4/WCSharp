#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions')

## IListExtensions Class

Extension class that defines a number of methods to simplify working with lists, in particular within context of Warcraft III\.

```csharp
public static class IListExtensions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; IListExtensions

| Methods | |
| :--- | :--- |
| [IterateWithRemoval&lt;T&gt;\(this IList&lt;T&gt;, Func&lt;T,bool&gt;\)](WCSharp.Shared.Extensions.IListExtensions.IterateWithRemoval_T_(thisSystem.Collections.Generic.IList_T_,System.Func_T,bool_).md 'WCSharp\.Shared\.Extensions\.IListExtensions\.IterateWithRemoval\<T\>\(this System\.Collections\.Generic\.IList\<T\>, System\.Func\<T,bool\>\)') | Due to C\# to Lua conversion difficulties, standard ways of enumerating a list while removing items from it may not work\. This extension method will safely iterate the list, and remove any which return false\.   Alternatively, you can use a standard reverse order iteration, as this will still work correctly. |
