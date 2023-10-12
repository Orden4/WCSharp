#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared.Extensions](WCSharp.Shared.Extensions.md 'WCSharp.Shared.Extensions').[GroupExtensions](WCSharp.Shared.Extensions.GroupExtensions.md 'WCSharp.Shared.Extensions.GroupExtensions')

## GroupExtensions.FirstOrDefault(this group, Func<unit,bool>) Method

Finds the first unit in the [group](WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).md#WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).group 'WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(this WCSharp.Api.group, System.Func<WCSharp.Api.unit,bool>).group') that matches the given [predicate](WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).md#WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).predicate 'WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(this WCSharp.Api.group, System.Func<WCSharp.Api.unit,bool>).predicate').  
  
If you need to call this more than once, use ToList and Linq methods instead.

```csharp
public static WCSharp.Api.unit FirstOrDefault(this WCSharp.Api.group group, System.Func<WCSharp.Api.unit,bool> predicate);
```
#### Parameters

<a name='WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).group'></a>

`group` [WCSharp.Api.group](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.group 'WCSharp.Api.group')

<a name='WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[WCSharp.Api.unit](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.unit 'WCSharp.Api.unit')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

#### Returns
[WCSharp.Api.unit](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.unit 'WCSharp.Api.unit')