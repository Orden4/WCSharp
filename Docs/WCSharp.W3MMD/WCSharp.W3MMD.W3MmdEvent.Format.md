### [WCSharp.W3MMD](WCSharp.W3MMD.md 'WCSharp.W3MMD').[W3MmdEvent](WCSharp.W3MMD.W3MmdEvent.md 'WCSharp.W3MMD.W3MmdEvent')

## W3MmdEvent.Format Property

The format of the event.  
  
E.g., for a player kills player event, we'd do "{0} killed {1}" where {0} is the first argument (the killer) and {1} is the second argument (the victim).

```csharp
public string Format { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')