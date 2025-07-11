#### [WCSharp\.Json](README.md 'README')
### [WCSharp\.Json](WCSharp.Json.md 'WCSharp\.Json').[JsonConvert](WCSharp.Json.JsonConvert.md 'WCSharp\.Json\.JsonConvert')

## JsonConvert\.TryDeserialize Method

| Overloads | |
| :--- | :--- |
| [TryDeserialize\(string, Type, object\)](WCSharp.Json.JsonConvert.TryDeserialize.md#WCSharp.Json.JsonConvert.TryDeserialize(string,System.Type,object) 'WCSharp\.Json\.JsonConvert\.TryDeserialize\(string, System\.Type, object\)') | Attempts to convert the given JSON string into the specified generic class\.   Please read the documentation for details on what can and cannot be (de)serialized. |
| [TryDeserialize&lt;T&gt;\(string, T\)](WCSharp.Json.JsonConvert.TryDeserialize.md#WCSharp.Json.JsonConvert.TryDeserialize_T_(string,T) 'WCSharp\.Json\.JsonConvert\.TryDeserialize\<T\>\(string, T\)') | Attempts to convert the given JSON string into the specified generic class\.   Please read the documentation for details on what can and cannot be (de)serialized. |

<a name='WCSharp.Json.JsonConvert.TryDeserialize(string,System.Type,object)'></a>

## JsonConvert\.TryDeserialize\(string, Type, object\) Method

Attempts to convert the given JSON string into the specified generic class\.

Please read the documentation for details on what can and cannot be (de)serialized.

```csharp
public static bool TryDeserialize(string input, System.Type deserializeType, out object data);
```
#### Parameters

<a name='WCSharp.Json.JsonConvert.TryDeserialize(string,System.Type,object).input'></a>

`input` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='WCSharp.Json.JsonConvert.TryDeserialize(string,System.Type,object).deserializeType'></a>

`deserializeType` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

<a name='WCSharp.Json.JsonConvert.TryDeserialize(string,System.Type,object).data'></a>

`data` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='WCSharp.Json.JsonConvert.TryDeserialize_T_(string,T)'></a>

## JsonConvert\.TryDeserialize\<T\>\(string, T\) Method

Attempts to convert the given JSON string into the specified generic class\.

Please read the documentation for details on what can and cannot be (de)serialized.

```csharp
public static bool TryDeserialize<T>(string input, out T data);
```
#### Type parameters

<a name='WCSharp.Json.JsonConvert.TryDeserialize_T_(string,T).T'></a>

`T`
#### Parameters

<a name='WCSharp.Json.JsonConvert.TryDeserialize_T_(string,T).input'></a>

`input` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='WCSharp.Json.JsonConvert.TryDeserialize_T_(string,T).data'></a>

`data` [T](WCSharp.Json.JsonConvert.md#WCSharp.Json.JsonConvert.TryDeserialize_T_(string,T).T 'WCSharp\.Json\.JsonConvert\.TryDeserialize\<T\>\(string, T\)\.T')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')