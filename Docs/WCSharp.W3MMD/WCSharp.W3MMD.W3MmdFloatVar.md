#### [WCSharp.W3MMD](README.md 'README')
### [WCSharp.W3MMD](WCSharp.W3MMD.md 'WCSharp.W3MMD')

## W3MmdFloatVar Class

Controls a W3MMD variable of type [Float](WCSharp.W3MMD.W3MmdVariableType.md#WCSharp.W3MMD.W3MmdVariableType.Float 'WCSharp.W3MMD.W3MmdVariableType.Float').

```csharp
public class W3MmdFloatVar :
WCSharp.W3MMD.IW3MmdVar
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; W3MmdFloatVar

Implements [IW3MmdVar](WCSharp.W3MMD.IW3MmdVar.md 'WCSharp.W3MMD.IW3MmdVar')

| Constructors | |
| :--- | :--- |
| [W3MmdFloatVar(string, W3MmdGoalType, W3MmdSuggestionType)](WCSharp.W3MMD.W3MmdFloatVar.W3MmdFloatVar(string,WCSharp.W3MMD.W3MmdGoalType,WCSharp.W3MMD.W3MmdSuggestionType).md 'WCSharp.W3MMD.W3MmdFloatVar.W3MmdFloatVar(string, WCSharp.W3MMD.W3MmdGoalType, WCSharp.W3MMD.W3MmdSuggestionType)') | Defines a player float variable that can be mutated throughout the game. |

| Properties | |
| :--- | :--- |
| [GoalType](WCSharp.W3MMD.W3MmdFloatVar.GoalType.md 'WCSharp.W3MMD.W3MmdFloatVar.GoalType') | The variable's sort order, i.e. whether it's better to have high or low values. |
| [Name](WCSharp.W3MMD.W3MmdFloatVar.Name.md 'WCSharp.W3MMD.W3MmdFloatVar.Name') | The name of the W3MMD variable. |
| [SuggestionType](WCSharp.W3MMD.W3MmdFloatVar.SuggestionType.md 'WCSharp.W3MMD.W3MmdFloatVar.SuggestionType') | A suggestion for what the parser should do for tracking the variable. |
| [VariableType](WCSharp.W3MMD.W3MmdFloatVar.VariableType.md 'WCSharp.W3MMD.W3MmdFloatVar.VariableType') | The variable's type. |

| Methods | |
| :--- | :--- |
| [Add(int, float)](WCSharp.W3MMD.W3MmdFloatVar.Add(int,float).md 'WCSharp.W3MMD.W3MmdFloatVar.Add(int, float)') | Adds the given [value](WCSharp.W3MMD.W3MmdFloatVar.Add(int,float).md#WCSharp.W3MMD.W3MmdFloatVar.Add(int,float).value 'WCSharp.W3MMD.W3MmdFloatVar.Add(int, float).value') to this variable for the given [playerId](WCSharp.W3MMD.W3MmdFloatVar.Add(int,float).md#WCSharp.W3MMD.W3MmdFloatVar.Add(int,float).playerId 'WCSharp.W3MMD.W3MmdFloatVar.Add(int, float).playerId'). |
| [Add(player, float)](WCSharp.W3MMD.W3MmdFloatVar.Add(War3Api.Common.player,float).md 'WCSharp.W3MMD.W3MmdFloatVar.Add(War3Api.Common.player, float)') | Adds the given [value](WCSharp.W3MMD.W3MmdFloatVar.Add(War3Api.Common.player,float).md#WCSharp.W3MMD.W3MmdFloatVar.Add(War3Api.Common.player,float).value 'WCSharp.W3MMD.W3MmdFloatVar.Add(War3Api.Common.player, float).value') to this variable for the given [player](WCSharp.W3MMD.W3MmdFloatVar.Add(War3Api.Common.player,float).md#WCSharp.W3MMD.W3MmdFloatVar.Add(War3Api.Common.player,float).player 'WCSharp.W3MMD.W3MmdFloatVar.Add(War3Api.Common.player, float).player'). |
| [Set(int, float)](WCSharp.W3MMD.W3MmdFloatVar.Set(int,float).md 'WCSharp.W3MMD.W3MmdFloatVar.Set(int, float)') | Sets this variable to the given [value](WCSharp.W3MMD.W3MmdFloatVar.Set(int,float).md#WCSharp.W3MMD.W3MmdFloatVar.Set(int,float).value 'WCSharp.W3MMD.W3MmdFloatVar.Set(int, float).value') for the given [playerId](WCSharp.W3MMD.W3MmdFloatVar.Set(int,float).md#WCSharp.W3MMD.W3MmdFloatVar.Set(int,float).playerId 'WCSharp.W3MMD.W3MmdFloatVar.Set(int, float).playerId'). |
| [Set(player, float)](WCSharp.W3MMD.W3MmdFloatVar.Set(War3Api.Common.player,float).md 'WCSharp.W3MMD.W3MmdFloatVar.Set(War3Api.Common.player, float)') | Sets this variable to the given [value](WCSharp.W3MMD.W3MmdFloatVar.Set(War3Api.Common.player,float).md#WCSharp.W3MMD.W3MmdFloatVar.Set(War3Api.Common.player,float).value 'WCSharp.W3MMD.W3MmdFloatVar.Set(War3Api.Common.player, float).value') for the given [player](WCSharp.W3MMD.W3MmdFloatVar.Set(War3Api.Common.player,float).md#WCSharp.W3MMD.W3MmdFloatVar.Set(War3Api.Common.player,float).player 'WCSharp.W3MMD.W3MmdFloatVar.Set(War3Api.Common.player, float).player'). |
| [Subtract(int, float)](WCSharp.W3MMD.W3MmdFloatVar.Subtract(int,float).md 'WCSharp.W3MMD.W3MmdFloatVar.Subtract(int, float)') | Subtracts the given [value](WCSharp.W3MMD.W3MmdFloatVar.Subtract(int,float).md#WCSharp.W3MMD.W3MmdFloatVar.Subtract(int,float).value 'WCSharp.W3MMD.W3MmdFloatVar.Subtract(int, float).value') to this variable for the given [playerId](WCSharp.W3MMD.W3MmdFloatVar.Subtract(int,float).md#WCSharp.W3MMD.W3MmdFloatVar.Subtract(int,float).playerId 'WCSharp.W3MMD.W3MmdFloatVar.Subtract(int, float).playerId'). |
| [Subtract(player, float)](WCSharp.W3MMD.W3MmdFloatVar.Subtract(War3Api.Common.player,float).md 'WCSharp.W3MMD.W3MmdFloatVar.Subtract(War3Api.Common.player, float)') | Subtracts the given [value](WCSharp.W3MMD.W3MmdFloatVar.Subtract(War3Api.Common.player,float).md#WCSharp.W3MMD.W3MmdFloatVar.Subtract(War3Api.Common.player,float).value 'WCSharp.W3MMD.W3MmdFloatVar.Subtract(War3Api.Common.player, float).value') to this variable for the given [player](WCSharp.W3MMD.W3MmdFloatVar.Subtract(War3Api.Common.player,float).md#WCSharp.W3MMD.W3MmdFloatVar.Subtract(War3Api.Common.player,float).player 'WCSharp.W3MMD.W3MmdFloatVar.Subtract(War3Api.Common.player, float).player'). |
