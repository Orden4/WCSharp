#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared.Extensions](WCSharp.Shared.Extensions.md 'WCSharp.Shared.Extensions').[GroupExtensions](WCSharp.Shared.Extensions.GroupExtensions.md 'WCSharp.Shared.Extensions.GroupExtensions')

## GroupExtensions.ToList(this group, Func<unit,bool>) Method

Returns a [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') containing all units within the given [group](WCSharp.Shared.Extensions.GroupExtensions.ToList(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).md#WCSharp.Shared.Extensions.GroupExtensions.ToList(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).group 'WCSharp.Shared.Extensions.GroupExtensions.ToList(this War3Api.Common.group, System.Func<War3Api.Common.unit,bool>).group') that match the [predicate](WCSharp.Shared.Extensions.GroupExtensions.ToList(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).md#WCSharp.Shared.Extensions.GroupExtensions.ToList(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).predicate 'WCSharp.Shared.Extensions.GroupExtensions.ToList(this War3Api.Common.group, System.Func<War3Api.Common.unit,bool>).predicate').

```csharp
public static System.Collections.Generic.List<War3Api.Common.unit> ToList(this War3Api.Common.group group, System.Func<War3Api.Common.unit,bool> predicate);
```
#### Parameters

<a name='WCSharp.Shared.Extensions.GroupExtensions.ToList(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).group'></a>

`group` [War3Api.Common.group](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.group 'War3Api.Common.group')

<a name='WCSharp.Shared.Extensions.GroupExtensions.ToList(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')