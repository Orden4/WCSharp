#### [WCSharp.W3MMD](index.md 'index')
### [WCSharp.W3MMD](WCSharp.W3MMD.md 'WCSharp.W3MMD').[W3Mmd](WCSharp.W3MMD.W3Mmd.md 'WCSharp.W3MMD.W3Mmd')

## W3Mmd.DefineFloat(string, W3MmdGoalType, W3MmdSuggestionType) Method

Defines a player float variable that can be mutated throughout the game.  
  
Equivalent to creating a new [W3MmdFloatVar](WCSharp.W3MMD.W3MmdFloatVar.md 'WCSharp.W3MMD.W3MmdFloatVar').

```csharp
public static WCSharp.W3MMD.W3MmdFloatVar DefineFloat(string name, WCSharp.W3MMD.W3MmdGoalType goalType, WCSharp.W3MMD.W3MmdSuggestionType suggestionType);
```
#### Parameters

<a name='WCSharp.W3MMD.W3Mmd.DefineFloat(string,WCSharp.W3MMD.W3MmdGoalType,WCSharp.W3MMD.W3MmdSuggestionType).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the variable.

<a name='WCSharp.W3MMD.W3Mmd.DefineFloat(string,WCSharp.W3MMD.W3MmdGoalType,WCSharp.W3MMD.W3MmdSuggestionType).goalType'></a>

`goalType` [W3MmdGoalType](WCSharp.W3MMD.W3MmdGoalType.md 'WCSharp.W3MMD.W3MmdGoalType')

Whether the player is trying to get a high or low value (or none).

<a name='WCSharp.W3MMD.W3Mmd.DefineFloat(string,WCSharp.W3MMD.W3MmdGoalType,WCSharp.W3MMD.W3MmdSuggestionType).suggestionType'></a>

`suggestionType` [W3MmdSuggestionType](WCSharp.W3MMD.W3MmdSuggestionType.md 'WCSharp.W3MMD.W3MmdSuggestionType')

A suggestion for how a parser/viewer should treat the output values.

#### Returns
[W3MmdFloatVar](WCSharp.W3MMD.W3MmdFloatVar.md 'WCSharp.W3MMD.W3MmdFloatVar')

#### Exceptions

[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
If the name is not between 1 and 32 characters long.