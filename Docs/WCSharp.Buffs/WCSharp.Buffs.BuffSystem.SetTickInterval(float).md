#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[BuffSystem](WCSharp.Buffs.BuffSystem.md 'WCSharp\.Buffs\.BuffSystem')

## BuffSystem\.SetTickInterval\(float\) Method

Changes the tick interval to the desired value\.

Note that the actual change occurs after a 0 second delay.

Calls [BeforeTickIntervalChanged\(float, float\)](WCSharp.Buffs.Buff.BeforeTickIntervalChanged(float,float).md 'WCSharp\.Buffs\.Buff\.BeforeTickIntervalChanged\(float, float\)') to adjust existing missiles.

```csharp
public static void SetTickInterval(float tickInterval);
```
#### Parameters

<a name='WCSharp.Buffs.BuffSystem.SetTickInterval(float).tickInterval'></a>

`tickInterval` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')