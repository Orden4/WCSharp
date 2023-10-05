#### [WCSharp.Json](README.md 'README')
### [WCSharp.Json](WCSharp.Json.md 'WCSharp.Json').[JsonConvert](WCSharp.Json.JsonConvert.md 'WCSharp.Json.JsonConvert')

## JsonConvert.TryDeserialize(string, Type, object) Method

Attempts to convert the given JSON string into the specified generic class.  
  
Please read the documentation for details on what can and cannot be (de)serialized.

```csharp
public static bool TryDeserialize(string input, System.Type deserializeType, out object data);
```
#### Parameters

<a name='WCSharp.Json.JsonConvert.TryDeserialize(string,System.Type,object).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='WCSharp.Json.JsonConvert.TryDeserialize(string,System.Type,object).deserializeType'></a>

`deserializeType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

<a name='WCSharp.Json.JsonConvert.TryDeserialize(string,System.Type,object).data'></a>

`data` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')