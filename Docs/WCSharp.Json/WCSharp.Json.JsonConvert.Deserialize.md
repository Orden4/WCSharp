#### [WCSharp\.Json](README.md 'README')
### [WCSharp\.Json](WCSharp.Json.md 'WCSharp\.Json').[JsonConvert](WCSharp.Json.JsonConvert.md 'WCSharp\.Json\.JsonConvert')

## JsonConvert\.Deserialize Method

| Overloads | |
| :--- | :--- |
| [Deserialize\(string, Type\)](WCSharp.Json.JsonConvert.Deserialize.md#WCSharp.Json.JsonConvert.Deserialize(string,System.Type) 'WCSharp\.Json\.JsonConvert\.Deserialize\(string, System\.Type\)') | Converts the given JSON string into the specified generic class\.   Please read the documentation for details on what can and cannot be (de)serialized. |
| [Deserialize&lt;T&gt;\(string\)](WCSharp.Json.JsonConvert.Deserialize.md#WCSharp.Json.JsonConvert.Deserialize_T_(string) 'WCSharp\.Json\.JsonConvert\.Deserialize\<T\>\(string\)') | Converts the given JSON string into the specified generic class\.   Please read the documentation for details on what can and cannot be (de)serialized. |

<a name='WCSharp.Json.JsonConvert.Deserialize(string,System.Type)'></a>

## JsonConvert\.Deserialize\(string, Type\) Method

Converts the given JSON string into the specified generic class\.

Please read the documentation for details on what can and cannot be (de)serialized.

```csharp
public static object Deserialize(string input, System.Type deserializeType);
```
#### Parameters

<a name='WCSharp.Json.JsonConvert.Deserialize(string,System.Type).input'></a>

`input` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='WCSharp.Json.JsonConvert.Deserialize(string,System.Type).deserializeType'></a>

`deserializeType` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

<a name='WCSharp.Json.JsonConvert.Deserialize_T_(string)'></a>

## JsonConvert\.Deserialize\<T\>\(string\) Method

Converts the given JSON string into the specified generic class\.

Please read the documentation for details on what can and cannot be (de)serialized.

```csharp
public static T Deserialize<T>(string input);
```
#### Type parameters

<a name='WCSharp.Json.JsonConvert.Deserialize_T_(string).T'></a>

`T`
#### Parameters

<a name='WCSharp.Json.JsonConvert.Deserialize_T_(string).input'></a>

`input` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

#### Returns
[T](WCSharp.Json.JsonConvert.md#WCSharp.Json.JsonConvert.Deserialize_T_(string).T 'WCSharp\.Json\.JsonConvert\.Deserialize\<T\>\(string\)\.T')