#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions').[GroupExtensions](WCSharp.Shared.Extensions.GroupExtensions.md 'WCSharp\.Shared\.Extensions\.GroupExtensions')

## GroupExtensions\.Enumerate Method

| Overloads | |
| :--- | :--- |
| [Enumerate\(this group\)](WCSharp.Shared.Extensions.GroupExtensions.Enumerate.md#WCSharp.Shared.Extensions.GroupExtensions.Enumerate(thisWCSharp.Api.group) 'WCSharp\.Shared\.Extensions\.GroupExtensions\.Enumerate\(this WCSharp\.Api\.group\)') | Enumerates all units within the [group](WCSharp.Shared.Extensions.GroupExtensions.md#WCSharp.Shared.Extensions.GroupExtensions.Enumerate(thisWCSharp.Api.group).group 'WCSharp\.Shared\.Extensions\.GroupExtensions\.Enumerate\(this WCSharp\.Api\.group\)\.group')\. This will empty the group in the process\. |
| [Enumerate\(this group, Func&lt;unit,bool&gt;\)](WCSharp.Shared.Extensions.GroupExtensions.Enumerate.md#WCSharp.Shared.Extensions.GroupExtensions.Enumerate(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_) 'WCSharp\.Shared\.Extensions\.GroupExtensions\.Enumerate\(this WCSharp\.Api\.group, System\.Func\<WCSharp\.Api\.unit,bool\>\)') | Enumerates all units within the group that match the given filter\. This will empty the group in the process\. |

<a name='WCSharp.Shared.Extensions.GroupExtensions.Enumerate(thisWCSharp.Api.group)'></a>

## GroupExtensions\.Enumerate\(this group\) Method

Enumerates all units within the [group](WCSharp.Shared.Extensions.GroupExtensions.md#WCSharp.Shared.Extensions.GroupExtensions.Enumerate(thisWCSharp.Api.group).group 'WCSharp\.Shared\.Extensions\.GroupExtensions\.Enumerate\(this WCSharp\.Api\.group\)\.group')\. This will empty the group in the process\.

```csharp
public static System.Collections.Generic.IEnumerable<WCSharp.Api.unit> Enumerate(this WCSharp.Api.group group);
```
#### Parameters

<a name='WCSharp.Shared.Extensions.GroupExtensions.Enumerate(thisWCSharp.Api.group).group'></a>

`group` [WCSharp\.Api\.group](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.group 'WCSharp\.Api\.group')

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='WCSharp.Shared.Extensions.GroupExtensions.Enumerate(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_)'></a>

## GroupExtensions\.Enumerate\(this group, Func\<unit,bool\>\) Method

Enumerates all units within the group that match the given filter\. This will empty the group in the process\.

```csharp
public static System.Collections.Generic.IEnumerable<WCSharp.Api.unit> Enumerate(this WCSharp.Api.group group, System.Func<WCSharp.Api.unit,bool> filter);
```
#### Parameters

<a name='WCSharp.Shared.Extensions.GroupExtensions.Enumerate(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).group'></a>

`group` [WCSharp\.Api\.group](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.group 'WCSharp\.Api\.group')

<a name='WCSharp.Shared.Extensions.GroupExtensions.Enumerate(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).filter'></a>

`filter` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')