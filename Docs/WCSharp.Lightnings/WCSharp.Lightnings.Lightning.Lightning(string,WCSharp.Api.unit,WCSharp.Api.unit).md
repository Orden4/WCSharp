#### [WCSharp.Lightnings](README.md 'README')
### [WCSharp.Lightnings](WCSharp.Lightnings.md 'WCSharp.Lightnings').[Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp.Lightnings.Lightning')

## Lightning(string, unit, unit) Constructor

Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp.Lightnings.Lightning') instance with the given parameters.  
  
Will automatically set [CasterX](WCSharp.Lightnings.Lightning.CasterX.md 'WCSharp.Lightnings.Lightning.CasterX'), [CasterY](WCSharp.Lightnings.Lightning.CasterY.md 'WCSharp.Lightnings.Lightning.CasterY'), [TargetX](WCSharp.Lightnings.Lightning.TargetX.md 'WCSharp.Lightnings.Lightning.TargetX') and [TargetY](WCSharp.Lightnings.Lightning.TargetY.md 'WCSharp.Lightnings.Lightning.TargetY').

```csharp
public Lightning(string name, WCSharp.Api.unit caster, WCSharp.Api.unit target);
```
#### Parameters

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the lightning effect. See [https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/](https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/ 'https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/').

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit).caster'></a>

`caster` [WCSharp.Api.unit](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.unit 'WCSharp.Api.unit')

The source of the lightning. Will automatically update the position when [caster](WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit).md#WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit).caster 'WCSharp.Lightnings.Lightning.Lightning(string, WCSharp.Api.unit, WCSharp.Api.unit).caster') moves.

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit).target'></a>

`target` [WCSharp.Api.unit](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.unit 'WCSharp.Api.unit')

The target of the lightning. Will automatically update the position when [target](WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit).md#WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit).target 'WCSharp.Lightnings.Lightning.Lightning(string, WCSharp.Api.unit, WCSharp.Api.unit).target') moves.