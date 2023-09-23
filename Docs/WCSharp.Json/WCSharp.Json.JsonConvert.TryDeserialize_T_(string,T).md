### [WCSharp.Json](WCSharp.Json.md 'WCSharp.Json').[JsonConvert](WCSharp.Json.JsonConvert.md 'WCSharp.Json.JsonConvert')

## JsonConvert.TryDeserialize<T>(string, T) Method

Attempts to convert the given JSON string into the specified generic class.  
  
Please read the documentation for details on what can and cannot be (de)serialized.

```csharp
public static bool TryDeserialize<T>(string input, out T data);
```
#### Type parameters

<a name='WCSharp.Json.JsonConvert.TryDeserialize_T_(string,T).T'></a>

`T`
#### Parameters

<a name='WCSharp.Json.JsonConvert.TryDeserialize_T_(string,T).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='WCSharp.Json.JsonConvert.TryDeserialize_T_(string,T).data'></a>

`data` [T](WCSharp.Json.JsonConvert.TryDeserialize_T_(string,T).md#WCSharp.Json.JsonConvert.TryDeserialize_T_(string,T).T 'WCSharp.Json.JsonConvert.TryDeserialize<T>(string, T).T')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')