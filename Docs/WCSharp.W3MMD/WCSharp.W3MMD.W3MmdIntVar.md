### [WCSharp.W3MMD](WCSharp.W3MMD.md 'WCSharp.W3MMD')

## W3MmdIntVar Class

Controls a W3MMD variable of type [Integer](WCSharp.W3MMD.W3MmdVariableType.md#WCSharp.W3MMD.W3MmdVariableType.Integer 'WCSharp.W3MMD.W3MmdVariableType.Integer').

```csharp
public class W3MmdIntVar :
WCSharp.W3MMD.IW3MmdVar
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; W3MmdIntVar

Implements [IW3MmdVar](WCSharp.W3MMD.IW3MmdVar.md 'WCSharp.W3MMD.IW3MmdVar')

| Constructors | |
| :--- | :--- |
| [W3MmdIntVar(string, W3MmdGoalType, W3MmdSuggestionType)](WCSharp.W3MMD.W3MmdIntVar.W3MmdIntVar(string,WCSharp.W3MMD.W3MmdGoalType,WCSharp.W3MMD.W3MmdSuggestionType).md 'WCSharp.W3MMD.W3MmdIntVar.W3MmdIntVar(string, WCSharp.W3MMD.W3MmdGoalType, WCSharp.W3MMD.W3MmdSuggestionType)') | Defines a player int variable that can be mutated throughout the game. |

| Properties | |
| :--- | :--- |
| [GoalType](WCSharp.W3MMD.W3MmdIntVar.GoalType.md 'WCSharp.W3MMD.W3MmdIntVar.GoalType') | The variable's sort order, i.e. whether it's better to have high or low values. |
| [Name](WCSharp.W3MMD.W3MmdIntVar.Name.md 'WCSharp.W3MMD.W3MmdIntVar.Name') | The name of the W3MMD variable. |
| [SuggestionType](WCSharp.W3MMD.W3MmdIntVar.SuggestionType.md 'WCSharp.W3MMD.W3MmdIntVar.SuggestionType') | A suggestion for what the parser should do for tracking the variable. |
| [VariableType](WCSharp.W3MMD.W3MmdIntVar.VariableType.md 'WCSharp.W3MMD.W3MmdIntVar.VariableType') | The variable's type. |

| Methods | |
| :--- | :--- |
| [Add(int, int)](WCSharp.W3MMD.W3MmdIntVar.Add(int,int).md 'WCSharp.W3MMD.W3MmdIntVar.Add(int, int)') | Adds the given [value](WCSharp.W3MMD.W3MmdIntVar.Add(int,int).md#WCSharp.W3MMD.W3MmdIntVar.Add(int,int).value 'WCSharp.W3MMD.W3MmdIntVar.Add(int, int).value') to this variable for the given [playerId](WCSharp.W3MMD.W3MmdIntVar.Add(int,int).md#WCSharp.W3MMD.W3MmdIntVar.Add(int,int).playerId 'WCSharp.W3MMD.W3MmdIntVar.Add(int, int).playerId'). |
| [Add(player, int)](WCSharp.W3MMD.W3MmdIntVar.Add(War3Api.Common.player,int).md 'WCSharp.W3MMD.W3MmdIntVar.Add(War3Api.Common.player, int)') | Adds the given [value](WCSharp.W3MMD.W3MmdIntVar.Add(War3Api.Common.player,int).md#WCSharp.W3MMD.W3MmdIntVar.Add(War3Api.Common.player,int).value 'WCSharp.W3MMD.W3MmdIntVar.Add(War3Api.Common.player, int).value') to this variable for the given [player](WCSharp.W3MMD.W3MmdIntVar.Add(War3Api.Common.player,int).md#WCSharp.W3MMD.W3MmdIntVar.Add(War3Api.Common.player,int).player 'WCSharp.W3MMD.W3MmdIntVar.Add(War3Api.Common.player, int).player'). |
| [Set(int, int)](WCSharp.W3MMD.W3MmdIntVar.Set(int,int).md 'WCSharp.W3MMD.W3MmdIntVar.Set(int, int)') | Sets this variable to the given [value](WCSharp.W3MMD.W3MmdIntVar.Set(int,int).md#WCSharp.W3MMD.W3MmdIntVar.Set(int,int).value 'WCSharp.W3MMD.W3MmdIntVar.Set(int, int).value') for the given [playerId](WCSharp.W3MMD.W3MmdIntVar.Set(int,int).md#WCSharp.W3MMD.W3MmdIntVar.Set(int,int).playerId 'WCSharp.W3MMD.W3MmdIntVar.Set(int, int).playerId'). |
| [Set(player, int)](WCSharp.W3MMD.W3MmdIntVar.Set(War3Api.Common.player,int).md 'WCSharp.W3MMD.W3MmdIntVar.Set(War3Api.Common.player, int)') | Sets this variable to the given [value](WCSharp.W3MMD.W3MmdIntVar.Set(War3Api.Common.player,int).md#WCSharp.W3MMD.W3MmdIntVar.Set(War3Api.Common.player,int).value 'WCSharp.W3MMD.W3MmdIntVar.Set(War3Api.Common.player, int).value') for the given [player](WCSharp.W3MMD.W3MmdIntVar.Set(War3Api.Common.player,int).md#WCSharp.W3MMD.W3MmdIntVar.Set(War3Api.Common.player,int).player 'WCSharp.W3MMD.W3MmdIntVar.Set(War3Api.Common.player, int).player'). |
| [Subtract(int, int)](WCSharp.W3MMD.W3MmdIntVar.Subtract(int,int).md 'WCSharp.W3MMD.W3MmdIntVar.Subtract(int, int)') | Subtracts the given [value](WCSharp.W3MMD.W3MmdIntVar.Subtract(int,int).md#WCSharp.W3MMD.W3MmdIntVar.Subtract(int,int).value 'WCSharp.W3MMD.W3MmdIntVar.Subtract(int, int).value') to this variable for the given [playerId](WCSharp.W3MMD.W3MmdIntVar.Subtract(int,int).md#WCSharp.W3MMD.W3MmdIntVar.Subtract(int,int).playerId 'WCSharp.W3MMD.W3MmdIntVar.Subtract(int, int).playerId'). |
| [Subtract(player, int)](WCSharp.W3MMD.W3MmdIntVar.Subtract(War3Api.Common.player,int).md 'WCSharp.W3MMD.W3MmdIntVar.Subtract(War3Api.Common.player, int)') | Subtracts the given [value](WCSharp.W3MMD.W3MmdIntVar.Subtract(War3Api.Common.player,int).md#WCSharp.W3MMD.W3MmdIntVar.Subtract(War3Api.Common.player,int).value 'WCSharp.W3MMD.W3MmdIntVar.Subtract(War3Api.Common.player, int).value') to this variable for the given [player](WCSharp.W3MMD.W3MmdIntVar.Subtract(War3Api.Common.player,int).md#WCSharp.W3MMD.W3MmdIntVar.Subtract(War3Api.Common.player,int).player 'WCSharp.W3MMD.W3MmdIntVar.Subtract(War3Api.Common.player, int).player'). |
