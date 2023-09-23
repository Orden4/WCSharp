#### [WCSharp.Shared](index.md 'index')
### [WCSharp.Shared.Extensions](WCSharp.Shared.Extensions.md 'WCSharp.Shared.Extensions').[GroupExtensions](WCSharp.Shared.Extensions.GroupExtensions.md 'WCSharp.Shared.Extensions.GroupExtensions')

## GroupExtensions.ToHashSet(this group, Func<unit,bool>) Method

Returns a [System.Collections.Generic.HashSet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1') containing all units within the given [group](WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).md#WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).group 'WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(this War3Api.Common.group, System.Func<War3Api.Common.unit,bool>).group') that match the [predicate](WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).md#WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).predicate 'WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(this War3Api.Common.group, System.Func<War3Api.Common.unit,bool>).predicate').

```csharp
public static System.Collections.Generic.HashSet<War3Api.Common.unit> ToHashSet(this War3Api.Common.group group, System.Func<War3Api.Common.unit,bool> predicate);
```
#### Parameters

<a name='WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).group'></a>

`group` [War3Api.Common.group](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.group 'War3Api.Common.group')

<a name='WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

#### Returns
[System.Collections.Generic.HashSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')[War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')