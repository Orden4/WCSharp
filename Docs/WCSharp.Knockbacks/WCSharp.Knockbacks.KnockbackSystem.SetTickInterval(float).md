#### [WCSharp\.Knockbacks](README.md 'README')
### [WCSharp\.Knockbacks](WCSharp.Knockbacks.md 'WCSharp\.Knockbacks').[KnockbackSystem](WCSharp.Knockbacks.KnockbackSystem.md 'WCSharp\.Knockbacks\.KnockbackSystem')

## KnockbackSystem\.SetTickInterval\(float\) Method

Changes the tick interval to the desired value\.

Note that the actual change occurs after a 0 second delay.

Calls [BeforeTickIntervalChanged\(float, float\)](WCSharp.Knockbacks.Knockback.BeforeTickIntervalChanged(float,float).md 'WCSharp\.Knockbacks\.Knockback\.BeforeTickIntervalChanged\(float, float\)') to adjust existing knockbacks.

```csharp
public static void SetTickInterval(float tickInterval);
```
#### Parameters

<a name='WCSharp.Knockbacks.KnockbackSystem.SetTickInterval(float).tickInterval'></a>

`tickInterval` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')