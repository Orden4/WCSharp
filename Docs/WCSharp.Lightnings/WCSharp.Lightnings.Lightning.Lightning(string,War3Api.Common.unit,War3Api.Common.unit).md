#### [WCSharp.Lightnings](README.md 'README')
### [WCSharp.Lightnings](WCSharp.Lightnings.md 'WCSharp.Lightnings').[Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp.Lightnings.Lightning')

## Lightning(string, unit, unit) Constructor

Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp.Lightnings.Lightning') instance with the given parameters.  
  
Will automatically set [CasterX](WCSharp.Lightnings.Lightning.CasterX.md 'WCSharp.Lightnings.Lightning.CasterX'), [CasterY](WCSharp.Lightnings.Lightning.CasterY.md 'WCSharp.Lightnings.Lightning.CasterY'), [TargetX](WCSharp.Lightnings.Lightning.TargetX.md 'WCSharp.Lightnings.Lightning.TargetX') and [TargetY](WCSharp.Lightnings.Lightning.TargetY.md 'WCSharp.Lightnings.Lightning.TargetY').

```csharp
public Lightning(string name, War3Api.Common.unit caster, War3Api.Common.unit target);
```
#### Parameters

<a name='WCSharp.Lightnings.Lightning.Lightning(string,War3Api.Common.unit,War3Api.Common.unit).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the lightning effect. See [https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/](https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/ 'https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/').

<a name='WCSharp.Lightnings.Lightning.Lightning(string,War3Api.Common.unit,War3Api.Common.unit).caster'></a>

`caster` [War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')

The source of the lightning. Will automatically update the position when [caster](WCSharp.Lightnings.Lightning.Lightning(string,War3Api.Common.unit,War3Api.Common.unit).md#WCSharp.Lightnings.Lightning.Lightning(string,War3Api.Common.unit,War3Api.Common.unit).caster 'WCSharp.Lightnings.Lightning.Lightning(string, War3Api.Common.unit, War3Api.Common.unit).caster') moves.

<a name='WCSharp.Lightnings.Lightning.Lightning(string,War3Api.Common.unit,War3Api.Common.unit).target'></a>

`target` [War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')

The target of the lightning. Will automatically update the position when [target](WCSharp.Lightnings.Lightning.Lightning(string,War3Api.Common.unit,War3Api.Common.unit).md#WCSharp.Lightnings.Lightning.Lightning(string,War3Api.Common.unit,War3Api.Common.unit).target 'WCSharp.Lightnings.Lightning.Lightning(string, War3Api.Common.unit, War3Api.Common.unit).target') moves.