#### [WCSharp.Json](README.md 'README')
### [WCSharp.Json](WCSharp.Json.md 'WCSharp.Json')

## JsonPropertyAttribute Class

Defines properties for the serializing and deserializing of WCSharp.JSON objects.

```csharp
public class JsonPropertyAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; JsonPropertyAttribute

| Constructors | |
| :--- | :--- |
| [JsonPropertyAttribute(string)](WCSharp.Json.JsonPropertyAttribute.JsonPropertyAttribute(string).md 'WCSharp.Json.JsonPropertyAttribute.JsonPropertyAttribute(string)') | Creates a new [JsonPropertyAttribute](WCSharp.Json.JsonPropertyAttribute.md 'WCSharp.Json.JsonPropertyAttribute') to configure the way that a property is serialized/deserialized. |

| Properties | |
| :--- | :--- |
| [Name](WCSharp.Json.JsonPropertyAttribute.Name.md 'WCSharp.Json.JsonPropertyAttribute.Name') | The JSON name that the file should use during serializing/deserializing.<br/><br/><br/>During deserializing, the real name may still be used if the attribute name cannot be matched on.<br/><br/>Note: If you provide a name that is identical to the name of another property, the result will be ambigious. |
