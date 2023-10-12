#### [WCSharp.Lightnings](README.md 'README')
### [WCSharp.Lightnings](WCSharp.Lightnings.md 'WCSharp.Lightnings').[Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp.Lightnings.Lightning')

## Lightning(string, float, float, unit) Constructor

Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp.Lightnings.Lightning') instance with the given parameters.  
  
Will automatically set [TargetX](WCSharp.Lightnings.Lightning.TargetX.md 'WCSharp.Lightnings.Lightning.TargetX') and [TargetY](WCSharp.Lightnings.Lightning.TargetY.md 'WCSharp.Lightnings.Lightning.TargetY').

```csharp
public Lightning(string name, float casterX, float casterY, WCSharp.Api.unit target);
```
#### Parameters

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the lightning effect. See [https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/](https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/ 'https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/').

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit).casterX'></a>

`casterX` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit).casterY'></a>

`casterY` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit).target'></a>

`target` [WCSharp.Api.unit](https://docs.microsoft.com/en-us/dotnet/api/WCSharp.Api.unit 'WCSharp.Api.unit')

The target of the lightning. Will automatically update the position when [target](WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit).md#WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit).target 'WCSharp.Lightnings.Lightning.Lightning(string, float, float, WCSharp.Api.unit).target') moves.