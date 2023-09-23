#### [WCSharp.W3MMD](index.md 'index')
### [WCSharp.W3MMD](WCSharp.W3MMD.md 'WCSharp.W3MMD')

## W3Mmd Class

The main class responsible for creating and managing W3MMD variable and data emissions.  
  
Note: You should define your variables and events a few seconds before interacting with them.

```csharp
public static class W3Mmd
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; W3Mmd

| Methods | |
| :--- | :--- |
| [DefineEvent(string, string, string[])](WCSharp.W3MMD.W3Mmd.DefineEvent(string,string,string[]).md 'WCSharp.W3MMD.W3Mmd.DefineEvent(string, string, string[])') | Defines an event that can occur multiple times.<br/><br/><br/>Equivalent to creating a new [W3MmdEvent](WCSharp.W3MMD.W3MmdEvent.md 'WCSharp.W3MMD.W3MmdEvent'). |
| [DefineFloat(string, W3MmdGoalType, W3MmdSuggestionType)](WCSharp.W3MMD.W3Mmd.DefineFloat(string,WCSharp.W3MMD.W3MmdGoalType,WCSharp.W3MMD.W3MmdSuggestionType).md 'WCSharp.W3MMD.W3Mmd.DefineFloat(string, WCSharp.W3MMD.W3MmdGoalType, WCSharp.W3MMD.W3MmdSuggestionType)') | Defines a player float variable that can be mutated throughout the game.<br/><br/><br/>Equivalent to creating a new [W3MmdFloatVar](WCSharp.W3MMD.W3MmdFloatVar.md 'WCSharp.W3MMD.W3MmdFloatVar'). |
| [DefineInt(string, W3MmdGoalType, W3MmdSuggestionType)](WCSharp.W3MMD.W3Mmd.DefineInt(string,WCSharp.W3MMD.W3MmdGoalType,WCSharp.W3MMD.W3MmdSuggestionType).md 'WCSharp.W3MMD.W3Mmd.DefineInt(string, WCSharp.W3MMD.W3MmdGoalType, WCSharp.W3MMD.W3MmdSuggestionType)') | Defines a player int variable that can be mutated throughout the game.<br/><br/><br/>Equivalent to creating a new [W3MmdIntVar](WCSharp.W3MMD.W3MmdIntVar.md 'WCSharp.W3MMD.W3MmdIntVar'). |
| [DefineString(string, W3MmdSuggestionType)](WCSharp.W3MMD.W3Mmd.DefineString(string,WCSharp.W3MMD.W3MmdSuggestionType).md 'WCSharp.W3MMD.W3Mmd.DefineString(string, WCSharp.W3MMD.W3MmdSuggestionType)') | Defines a player string variable that can be mutated throughout the game.<br/><br/><br/>Useful for classifications.<br/><br/>Equivalent to creating a new [W3MmdStringVar](WCSharp.W3MMD.W3MmdStringVar.md 'WCSharp.W3MMD.W3MmdStringVar'). |
| [EmitCustom(string, string)](WCSharp.W3MMD.W3Mmd.EmitCustom(string,string).md 'WCSharp.W3MMD.W3Mmd.EmitCustom(string, string)') | Emits custom data that may be used by parsers/viewers.<br/><br/><br/>See the W3MMD.spec at https://github.com/PBug90/w3gPlus for more information. |
| [ForceInit()](WCSharp.W3MMD.W3Mmd.ForceInit().md 'WCSharp.W3MMD.W3Mmd.ForceInit()') | <br/><br/>W3MMD is automatically initialised when defining any event or variable.<br/>            As such, this method is only necessary to call if you exclusively use SetPlayerFlag and/or EmitCustom. |
| [SetPlayerFlag(int, W3MmdFlag)](WCSharp.W3MMD.W3Mmd.SetPlayerFlag(int,WCSharp.W3MMD.W3MmdFlag).md 'WCSharp.W3MMD.W3Mmd.SetPlayerFlag(int, WCSharp.W3MMD.W3MmdFlag)') | Sets a player's flag to be consumed by a parser. |
| [SetPlayerFlag(player, W3MmdFlag)](WCSharp.W3MMD.W3Mmd.SetPlayerFlag(War3Api.Common.player,WCSharp.W3MMD.W3MmdFlag).md 'WCSharp.W3MMD.W3Mmd.SetPlayerFlag(War3Api.Common.player, WCSharp.W3MMD.W3MmdFlag)') | Sets a player's flag to be consumed by a parser. |
