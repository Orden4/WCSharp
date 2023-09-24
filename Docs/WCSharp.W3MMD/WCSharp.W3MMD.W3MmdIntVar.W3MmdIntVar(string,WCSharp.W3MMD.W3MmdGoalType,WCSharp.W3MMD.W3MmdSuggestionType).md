#### [WCSharp.W3MMD](README.md 'README')
### [WCSharp.W3MMD](WCSharp.W3MMD.md 'WCSharp.W3MMD').[W3MmdIntVar](WCSharp.W3MMD.W3MmdIntVar.md 'WCSharp.W3MMD.W3MmdIntVar')

## W3MmdIntVar(string, W3MmdGoalType, W3MmdSuggestionType) Constructor

Defines a player int variable that can be mutated throughout the game.

```csharp
public W3MmdIntVar(string name, WCSharp.W3MMD.W3MmdGoalType goalType, WCSharp.W3MMD.W3MmdSuggestionType suggestionType);
```
#### Parameters

<a name='WCSharp.W3MMD.W3MmdIntVar.W3MmdIntVar(string,WCSharp.W3MMD.W3MmdGoalType,WCSharp.W3MMD.W3MmdSuggestionType).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the variable.

<a name='WCSharp.W3MMD.W3MmdIntVar.W3MmdIntVar(string,WCSharp.W3MMD.W3MmdGoalType,WCSharp.W3MMD.W3MmdSuggestionType).goalType'></a>

`goalType` [W3MmdGoalType](WCSharp.W3MMD.W3MmdGoalType.md 'WCSharp.W3MMD.W3MmdGoalType')

Whether the player is trying to get a high or low value (or none).

<a name='WCSharp.W3MMD.W3MmdIntVar.W3MmdIntVar(string,WCSharp.W3MMD.W3MmdGoalType,WCSharp.W3MMD.W3MmdSuggestionType).suggestionType'></a>

`suggestionType` [W3MmdSuggestionType](WCSharp.W3MMD.W3MmdSuggestionType.md 'WCSharp.W3MMD.W3MmdSuggestionType')

A suggestion for how a parser/viewer should treat the output values.

#### Exceptions

[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
If the name is not between 1 and 32 characters long.