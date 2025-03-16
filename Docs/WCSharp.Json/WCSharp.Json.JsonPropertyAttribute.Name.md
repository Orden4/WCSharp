#### [WCSharp.Json](README.md 'README')
### [WCSharp.Json](WCSharp.Json.md 'WCSharp.Json').[JsonPropertyAttribute](WCSharp.Json.JsonPropertyAttribute.md 'WCSharp.Json.JsonPropertyAttribute')

## JsonPropertyAttribute.Name Property

The JSON name that the file should use during serializing/deserializing.  
  
During deserializing, the real name may still be used if the attribute name cannot be matched on.  
  
Note: If you provide a name that is identical to the name of another property, the result will be ambigious.

```csharp
public string Name { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')