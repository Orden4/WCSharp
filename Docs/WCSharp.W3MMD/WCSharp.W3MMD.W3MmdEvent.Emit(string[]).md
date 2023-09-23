#### [WCSharp.W3MMD](index.md 'index')
### [WCSharp.W3MMD](WCSharp.W3MMD.md 'WCSharp.W3MMD').[W3MmdEvent](WCSharp.W3MMD.W3MmdEvent.md 'WCSharp.W3MMD.W3MmdEvent')

## W3MmdEvent.Emit(string[]) Method

Emits a new event with the given parameters.

```csharp
public void Emit(params string[] args);
```
#### Parameters

<a name='WCSharp.W3MMD.W3MmdEvent.Emit(string[]).args'></a>

`args` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

A number of arguments equal to [ArgumentCount](WCSharp.W3MMD.W3MmdEvent.ArgumentCount.md 'WCSharp.W3MMD.W3MmdEvent.ArgumentCount').

#### Exceptions

[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
If the number of arguments provided does not match [ArgumentCount](WCSharp.W3MMD.W3MmdEvent.ArgumentCount.md 'WCSharp.W3MMD.W3MmdEvent.ArgumentCount').