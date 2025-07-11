#### [WCSharp\.W3MMD](README.md 'README')
### [WCSharp\.W3MMD](WCSharp.W3MMD.md 'WCSharp\.W3MMD').[W3MmdStringVar](WCSharp.W3MMD.W3MmdStringVar.md 'WCSharp\.W3MMD\.W3MmdStringVar')

## W3MmdStringVar\(string, W3MmdSuggestionType\) Constructor

Defines a player string variable that can be mutated throughout the game\.

Useful to classifications.

```csharp
public W3MmdStringVar(string name, WCSharp.W3MMD.W3MmdSuggestionType suggestionType);
```
#### Parameters

<a name='WCSharp.W3MMD.W3MmdStringVar.W3MmdStringVar(string,WCSharp.W3MMD.W3MmdSuggestionType).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Name of the variable\.

<a name='WCSharp.W3MMD.W3MmdStringVar.W3MmdStringVar(string,WCSharp.W3MMD.W3MmdSuggestionType).suggestionType'></a>

`suggestionType` [W3MmdSuggestionType](WCSharp.W3MMD.W3MmdSuggestionType.md 'WCSharp\.W3MMD\.W3MmdSuggestionType')

A suggestion for how a parser/viewer should treat the output values\.

#### Exceptions

[System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception')  
If the name is not between 1 and 32 characters long\.