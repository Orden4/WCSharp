#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Extensions](WCSharp.Shared.Extensions.md 'WCSharp\.Shared\.Extensions').[GroupExtensions](WCSharp.Shared.Extensions.GroupExtensions.md 'WCSharp\.Shared\.Extensions\.GroupExtensions')

## GroupExtensions\.ToHashSet Method

| Overloads | |
| :--- | :--- |
| [ToHashSet\(this group\)](WCSharp.Shared.Extensions.GroupExtensions.ToHashSet.md#WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWCSharp.Api.group) 'WCSharp\.Shared\.Extensions\.GroupExtensions\.ToHashSet\(this WCSharp\.Api\.group\)') | Returns a [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing all units within the given [group](WCSharp.Shared.Extensions.GroupExtensions.md#WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWCSharp.Api.group).group 'WCSharp\.Shared\.Extensions\.GroupExtensions\.ToHashSet\(this WCSharp\.Api\.group\)\.group')\. |
| [ToHashSet\(this group, Func&lt;unit,bool&gt;\)](WCSharp.Shared.Extensions.GroupExtensions.ToHashSet.md#WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_) 'WCSharp\.Shared\.Extensions\.GroupExtensions\.ToHashSet\(this WCSharp\.Api\.group, System\.Func\<WCSharp\.Api\.unit,bool\>\)') | Returns a [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing all units within the given [group](WCSharp.Shared.Extensions.GroupExtensions.md#WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).group 'WCSharp\.Shared\.Extensions\.GroupExtensions\.ToHashSet\(this WCSharp\.Api\.group, System\.Func\<WCSharp\.Api\.unit,bool\>\)\.group') that match the [predicate](WCSharp.Shared.Extensions.GroupExtensions.md#WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).predicate 'WCSharp\.Shared\.Extensions\.GroupExtensions\.ToHashSet\(this WCSharp\.Api\.group, System\.Func\<WCSharp\.Api\.unit,bool\>\)\.predicate')\. |

<a name='WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWCSharp.Api.group)'></a>

## GroupExtensions\.ToHashSet\(this group\) Method

Returns a [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing all units within the given [group](WCSharp.Shared.Extensions.GroupExtensions.md#WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWCSharp.Api.group).group 'WCSharp\.Shared\.Extensions\.GroupExtensions\.ToHashSet\(this WCSharp\.Api\.group\)\.group')\.

```csharp
public static System.Collections.Generic.HashSet<WCSharp.Api.unit> ToHashSet(this WCSharp.Api.group group);
```
#### Parameters

<a name='WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWCSharp.Api.group).group'></a>

`group` [WCSharp\.Api\.group](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.group 'WCSharp\.Api\.group')

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')

<a name='WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_)'></a>

## GroupExtensions\.ToHashSet\(this group, Func\<unit,bool\>\) Method

Returns a [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing all units within the given [group](WCSharp.Shared.Extensions.GroupExtensions.md#WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).group 'WCSharp\.Shared\.Extensions\.GroupExtensions\.ToHashSet\(this WCSharp\.Api\.group, System\.Func\<WCSharp\.Api\.unit,bool\>\)\.group') that match the [predicate](WCSharp.Shared.Extensions.GroupExtensions.md#WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).predicate 'WCSharp\.Shared\.Extensions\.GroupExtensions\.ToHashSet\(this WCSharp\.Api\.group, System\.Func\<WCSharp\.Api\.unit,bool\>\)\.predicate')\.

```csharp
public static System.Collections.Generic.HashSet<WCSharp.Api.unit> ToHashSet(this WCSharp.Api.group group, System.Func<WCSharp.Api.unit,bool> predicate);
```
#### Parameters

<a name='WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).group'></a>

`group` [WCSharp\.Api\.group](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.group 'WCSharp\.Api\.group')

<a name='WCSharp.Shared.Extensions.GroupExtensions.ToHashSet(thisWCSharp.Api.group,System.Func_WCSharp.Api.unit,bool_).predicate'></a>

`predicate` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')