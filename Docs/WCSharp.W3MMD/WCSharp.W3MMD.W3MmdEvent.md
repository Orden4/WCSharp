#### [WCSharp.W3MMD](README.md 'README')
### [WCSharp.W3MMD](WCSharp.W3MMD.md 'WCSharp.W3MMD')

## W3MmdEvent Class

Represents a W3MMD event. For example, "X killed Y".

```csharp
public class W3MmdEvent
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; W3MmdEvent

| Constructors | |
| :--- | :--- |
| [W3MmdEvent(string, string, string[])](WCSharp.W3MMD.W3MmdEvent.W3MmdEvent(string,string,string[]).md 'WCSharp.W3MMD.W3MmdEvent.W3MmdEvent(string, string, string[])') | Defines an event that can occur multiple times. |

| Properties | |
| :--- | :--- |
| [ArgumentCount](WCSharp.W3MMD.W3MmdEvent.ArgumentCount.md 'WCSharp.W3MMD.W3MmdEvent.ArgumentCount') | The number of arguments. |
| [Arguments](WCSharp.W3MMD.W3MmdEvent.Arguments.md 'WCSharp.W3MMD.W3MmdEvent.Arguments') | The names of the arguments. e.g., ["killer", "victim"] |
| [Format](WCSharp.W3MMD.W3MmdEvent.Format.md 'WCSharp.W3MMD.W3MmdEvent.Format') | The format of the event.<br/><br/><br/>E.g., for a player kills player event, we'd do "{0} killed {1}" where {0} is the first argument (the killer) and {1} is the second argument (the victim). |
| [Name](WCSharp.W3MMD.W3MmdEvent.Name.md 'WCSharp.W3MMD.W3MmdEvent.Name') | The name of the event. |

| Methods | |
| :--- | :--- |
| [Emit(string[])](WCSharp.W3MMD.W3MmdEvent.Emit(string[]).md 'WCSharp.W3MMD.W3MmdEvent.Emit(string[])') | Emits a new event with the given parameters. |
