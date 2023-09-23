### [WCSharp.W3MMD](WCSharp.W3MMD.md 'WCSharp.W3MMD').[W3Mmd](WCSharp.W3MMD.W3Mmd.md 'WCSharp.W3MMD.W3Mmd')

## W3Mmd.DefineEvent(string, string, string[]) Method

Defines an event that can occur multiple times.  
  
Equivalent to creating a new [W3MmdEvent](WCSharp.W3MMD.W3MmdEvent.md 'WCSharp.W3MMD.W3MmdEvent').

```csharp
public static WCSharp.W3MMD.W3MmdEvent DefineEvent(string name, string format, params string[] arguments);
```
#### Parameters

<a name='WCSharp.W3MMD.W3Mmd.DefineEvent(string,string,string[]).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the event.

<a name='WCSharp.W3MMD.W3Mmd.DefineEvent(string,string,string[]).format'></a>

`format` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

String to format an event into a user-consumable string.  
  
e.g., for a player kills player event, we'd do "{0} killed {1}" where {0} is the first argument (the killer) and {1} is the second argument (the victim).

<a name='WCSharp.W3MMD.W3Mmd.DefineEvent(string,string,string[]).arguments'></a>

`arguments` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

Name of the arguments. e.g., ["killer", "victim"].

#### Returns
[W3MmdEvent](WCSharp.W3MMD.W3MmdEvent.md 'WCSharp.W3MMD.W3MmdEvent')

#### Exceptions

[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
If the name is not between 1 and 32 characters long.