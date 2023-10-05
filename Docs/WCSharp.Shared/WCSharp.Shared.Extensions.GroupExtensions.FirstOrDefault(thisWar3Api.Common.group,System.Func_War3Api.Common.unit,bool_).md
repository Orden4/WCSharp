#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared.Extensions](WCSharp.Shared.Extensions.md 'WCSharp.Shared.Extensions').[GroupExtensions](WCSharp.Shared.Extensions.GroupExtensions.md 'WCSharp.Shared.Extensions.GroupExtensions')

## GroupExtensions.FirstOrDefault(this group, Func<unit,bool>) Method

Finds the first unit in the [group](WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).md#WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).group 'WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(this War3Api.Common.group, System.Func<War3Api.Common.unit,bool>).group') that matches the given [predicate](WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).md#WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).predicate 'WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(this War3Api.Common.group, System.Func<War3Api.Common.unit,bool>).predicate').  
  
If you need to call this more than once, use ToList and Linq methods instead.

```csharp
public static War3Api.Common.unit FirstOrDefault(this War3Api.Common.group group, System.Func<War3Api.Common.unit,bool> predicate);
```
#### Parameters

<a name='WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).group'></a>

`group` [War3Api.Common.group](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.group 'War3Api.Common.group')

<a name='WCSharp.Shared.Extensions.GroupExtensions.FirstOrDefault(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

#### Returns
[War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')