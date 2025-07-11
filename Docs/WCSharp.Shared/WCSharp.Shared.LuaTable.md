#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared](WCSharp.Shared.md 'WCSharp\.Shared')

## LuaTable Class

Represents a table in Lua in a way that is easier to work with from C\#\.

```csharp
public class LuaTable : System.Collections.Generic.IDictionary<object, object>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.IEnumerable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; LuaTable

Implements [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2'), [System\.Collections\.Generic\.ICollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')[System\.Collections\.Generic\.KeyValuePair&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Collections\.Generic\.KeyValuePair&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')

| Constructors | |
| :--- | :--- |
| [LuaTable\(object\)](WCSharp.Shared.LuaTable.LuaTable(object).md 'WCSharp\.Shared\.LuaTable\.LuaTable\(object\)') | Initialises a new [LuaTable](WCSharp.Shared.LuaTable.md 'WCSharp\.Shared\.LuaTable') and adds all pairs located on the table into the dictionary\. |

| Properties | |
| :--- | :--- |
| [Count](WCSharp.Shared.LuaTable.Count.md 'WCSharp\.Shared\.LuaTable\.Count') | Gets the number of elements contained in the [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')\. |
| [Keys](WCSharp.Shared.LuaTable.Keys.md 'WCSharp\.Shared\.LuaTable\.Keys') | Gets an [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1') containing the keys of the [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')\. |
| [Table](WCSharp.Shared.LuaTable.Table.md 'WCSharp\.Shared\.LuaTable\.Table') | The actual Lua table that this dictionary is mapping\. |
| [Values](WCSharp.Shared.LuaTable.Values.md 'WCSharp\.Shared\.LuaTable\.Values') | Gets an [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1') containing the values in the [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')\. |

| Methods | |
| :--- | :--- |
| [Clear\(\)](WCSharp.Shared.LuaTable.Clear().md 'WCSharp\.Shared\.LuaTable\.Clear\(\)') | Removes all items from the [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')\. |
| [GetEnumerator\(\)](WCSharp.Shared.LuaTable.GetEnumerator().md 'WCSharp\.Shared\.LuaTable\.GetEnumerator\(\)') | Returns an enumerator that iterates through the collection\. |
