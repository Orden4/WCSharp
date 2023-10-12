#### [WCSharp.Lightnings](README.md 'README')
### [WCSharp.Lightnings](WCSharp.Lightnings.md 'WCSharp.Lightnings').[Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp.Lightnings.Lightning')

## Lightning(string, unit, float, float) Constructor

Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp.Lightnings.Lightning') instance with the given parameters.  
  
Will automatically set [CasterX](WCSharp.Lightnings.Lightning.CasterX.md 'WCSharp.Lightnings.Lightning.CasterX') and [CasterY](WCSharp.Lightnings.Lightning.CasterY.md 'WCSharp.Lightnings.Lightning.CasterY').

```csharp
public Lightning(string name, WCSharp.Api.unit caster, float targetX, float targetY);
```
#### Parameters

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the lightning effect. See [https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/](https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/ 'https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/').

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float).caster'></a>

`caster` [WCSharp.Api.unit](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.unit 'WCSharp.Api.unit')

The source of the lightning. Will automatically update the position when [caster](WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float).md#WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float).caster 'WCSharp.Lightnings.Lightning.Lightning(string, WCSharp.Api.unit, float, float).caster') moves.

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float).targetX'></a>

`targetX` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float).targetY'></a>

`targetY` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')