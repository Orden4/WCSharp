#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared.Extensions](WCSharp.Shared.Extensions.md 'WCSharp.Shared.Extensions').[GroupExtensions](WCSharp.Shared.Extensions.GroupExtensions.md 'WCSharp.Shared.Extensions.GroupExtensions')

## GroupExtensions.Enumerate(this group, Func<unit,bool>) Method

Enumerates all units within the group that match the given filter. This will empty the group in the process.

```csharp
public static System.Collections.Generic.IEnumerable<War3Api.Common.unit> Enumerate(this War3Api.Common.group group, System.Func<War3Api.Common.unit,bool> filter);
```
#### Parameters

<a name='WCSharp.Shared.Extensions.GroupExtensions.Enumerate(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).group'></a>

`group` [War3Api.Common.group](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.group 'War3Api.Common.group')

<a name='WCSharp.Shared.Extensions.GroupExtensions.Enumerate(thisWar3Api.Common.group,System.Func_War3Api.Common.unit,bool_).filter'></a>

`filter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')