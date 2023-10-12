#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared.Extensions](WCSharp.Shared.Extensions.md 'WCSharp.Shared.Extensions').[GroupExtensions](WCSharp.Shared.Extensions.GroupExtensions.md 'WCSharp.Shared.Extensions.GroupExtensions')

## GroupExtensions.ToList(this group, Func<unit,bool>) Method

Returns a [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') containing all units within the given [group](WCSharp.Shared.Extensions.GroupExtensions.ToList(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).md#WCSharp.Shared.Extensions.GroupExtensions.ToList(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).group 'WCSharp.Shared.Extensions.GroupExtensions.ToList(this WCSharp.Api.group, System.Func<WCSharp.Api.unit,bool>).group') that match the [predicate](WCSharp.Shared.Extensions.GroupExtensions.ToList(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).md#WCSharp.Shared.Extensions.GroupExtensions.ToList(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).predicate 'WCSharp.Shared.Extensions.GroupExtensions.ToList(this WCSharp.Api.group, System.Func<WCSharp.Api.unit,bool>).predicate').

```csharp
public static System.Collections.Generic.List<WCSharp.Api.unit> ToList(this WCSharp.Api.group group, System.Func<WCSharp.Api.unit,bool> predicate);
```
#### Parameters

<a name='WCSharp.Shared.Extensions.GroupExtensions.ToList(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).group'></a>

`group` [WCSharp.Api.group](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.group 'WCSharp.Api.group')

<a name='WCSharp.Shared.Extensions.GroupExtensions.ToList(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[WCSharp.Api.unit](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.unit 'WCSharp.Api.unit')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[WCSharp.Api.unit](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.unit 'WCSharp.Api.unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')