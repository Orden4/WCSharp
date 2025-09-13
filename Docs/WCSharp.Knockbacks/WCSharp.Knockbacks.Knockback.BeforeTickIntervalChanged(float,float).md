#### [WCSharp\.Knockbacks](README.md 'README')
### [WCSharp\.Knockbacks](WCSharp.Knockbacks.md 'WCSharp\.Knockbacks').[Knockback](WCSharp.Knockbacks.Knockback.md 'WCSharp\.Knockbacks\.Knockback')

## Knockback\.BeforeTickIntervalChanged\(float, float\) Method

Override if adjustments are needed when the tick interval is changed\.

Ensure that the base is still called.

```csharp
public virtual void BeforeTickIntervalChanged(float oldTickInterval, float newTickInterval);
```
#### Parameters

<a name='WCSharp.Knockbacks.Knockback.BeforeTickIntervalChanged(float,float).oldTickInterval'></a>

`oldTickInterval` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Knockbacks.Knockback.BeforeTickIntervalChanged(float,float).newTickInterval'></a>

`newTickInterval` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')