#### [WCSharp.W3MMD](README.md 'README')
### [WCSharp.W3MMD](WCSharp.W3MMD.md 'WCSharp.W3MMD')

## W3MmdStringVar Class

Controls a W3MMD variable of type [String](WCSharp.W3MMD.W3MmdVariableType.md#WCSharp.W3MMD.W3MmdVariableType.String 'WCSharp.W3MMD.W3MmdVariableType.String').

```csharp
public class W3MmdStringVar :
WCSharp.W3MMD.IW3MmdVar
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; W3MmdStringVar

Implements [IW3MmdVar](WCSharp.W3MMD.IW3MmdVar.md 'WCSharp.W3MMD.IW3MmdVar')

| Constructors | |
| :--- | :--- |
| [W3MmdStringVar(string, W3MmdSuggestionType)](WCSharp.W3MMD.W3MmdStringVar.W3MmdStringVar(string,WCSharp.W3MMD.W3MmdSuggestionType).md 'WCSharp.W3MMD.W3MmdStringVar.W3MmdStringVar(string, WCSharp.W3MMD.W3MmdSuggestionType)') | Defines a player string variable that can be mutated throughout the game.<br/><br/><br/>Useful to classifications. |

| Properties | |
| :--- | :--- |
| [GoalType](WCSharp.W3MMD.W3MmdStringVar.GoalType.md 'WCSharp.W3MMD.W3MmdStringVar.GoalType') | The variable's sort order, i.e. whether it's better to have high or low values. |
| [Name](WCSharp.W3MMD.W3MmdStringVar.Name.md 'WCSharp.W3MMD.W3MmdStringVar.Name') | The name of the W3MMD variable. |
| [SuggestionType](WCSharp.W3MMD.W3MmdStringVar.SuggestionType.md 'WCSharp.W3MMD.W3MmdStringVar.SuggestionType') | A suggestion for what the parser should do for tracking the variable. |
| [VariableType](WCSharp.W3MMD.W3MmdStringVar.VariableType.md 'WCSharp.W3MMD.W3MmdStringVar.VariableType') | The variable's type. |

| Methods | |
| :--- | :--- |
| [Set(int, string)](WCSharp.W3MMD.W3MmdStringVar.Set(int,string).md 'WCSharp.W3MMD.W3MmdStringVar.Set(int, string)') | Sets this variable to the given [value](WCSharp.W3MMD.W3MmdStringVar.Set(int,string).md#WCSharp.W3MMD.W3MmdStringVar.Set(int,string).value 'WCSharp.W3MMD.W3MmdStringVar.Set(int, string).value') for the given [playerId](WCSharp.W3MMD.W3MmdStringVar.Set(int,string).md#WCSharp.W3MMD.W3MmdStringVar.Set(int,string).playerId 'WCSharp.W3MMD.W3MmdStringVar.Set(int, string).playerId'). |
| [Set(player, string)](WCSharp.W3MMD.W3MmdStringVar.Set(War3Api.Common.player,string).md 'WCSharp.W3MMD.W3MmdStringVar.Set(War3Api.Common.player, string)') | Sets this variable to the given [value](WCSharp.W3MMD.W3MmdStringVar.Set(War3Api.Common.player,string).md#WCSharp.W3MMD.W3MmdStringVar.Set(War3Api.Common.player,string).value 'WCSharp.W3MMD.W3MmdStringVar.Set(War3Api.Common.player, string).value') for the given [player](WCSharp.W3MMD.W3MmdStringVar.Set(War3Api.Common.player,string).md#WCSharp.W3MMD.W3MmdStringVar.Set(War3Api.Common.player,string).player 'WCSharp.W3MMD.W3MmdStringVar.Set(War3Api.Common.player, string).player'). |
