#### [WCSharp\.Knockbacks](README.md 'README')
### [WCSharp\.Knockbacks](WCSharp.Knockbacks.md 'WCSharp\.Knockbacks')

## KnockbackSystem Class

Keeps track of all active knockbacks\.

```csharp
public static class KnockbackSystem
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; KnockbackSystem

| Properties | |
| :--- | :--- |
| [Knockbacks](WCSharp.Knockbacks.KnockbackSystem.Knockbacks.md 'WCSharp\.Knockbacks\.KnockbackSystem\.Knockbacks') | All active knockbacks\. |
| [TickInterval](WCSharp.Knockbacks.KnockbackSystem.TickInterval.md 'WCSharp\.Knockbacks\.KnockbackSystem\.TickInterval') | The interval between each update of the system\.   Use [SetTickInterval\(float\)](WCSharp.Knockbacks.KnockbackSystem.SetTickInterval(float).md 'WCSharp\.Knockbacks\.KnockbackSystem\.SetTickInterval\(float\)') to adjust. |

| Methods | |
| :--- | :--- |
| [Add\(Knockback\)](WCSharp.Knockbacks.KnockbackSystem.Add(WCSharp.Knockbacks.Knockback).md 'WCSharp\.Knockbacks\.KnockbackSystem\.Add\(WCSharp\.Knockbacks\.Knockback\)') | Adds the given knockback to the system\. This will also initialise or alter some values according to the knockbacks' properties\. |
| [SetTickInterval\(float\)](WCSharp.Knockbacks.KnockbackSystem.SetTickInterval(float).md 'WCSharp\.Knockbacks\.KnockbackSystem\.SetTickInterval\(float\)') | Changes the tick interval to the desired value\.   Note that the actual change occurs after a 0 second delay.  Calls [BeforeTickIntervalChanged\(float, float\)](WCSharp.Knockbacks.Knockback.BeforeTickIntervalChanged(float,float).md 'WCSharp\.Knockbacks\.Knockback\.BeforeTickIntervalChanged\(float, float\)') to adjust existing knockbacks. |
