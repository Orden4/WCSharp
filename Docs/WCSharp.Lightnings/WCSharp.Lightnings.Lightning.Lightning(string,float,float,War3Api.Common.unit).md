### [WCSharp.Lightnings](WCSharp.Lightnings.md 'WCSharp.Lightnings').[Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp.Lightnings.Lightning')

## Lightning(string, float, float, unit) Constructor

Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp.Lightnings.Lightning') instance with the given parameters.  
  
Will automatically set [TargetX](WCSharp.Lightnings.Lightning.TargetX.md 'WCSharp.Lightnings.Lightning.TargetX') and [TargetY](WCSharp.Lightnings.Lightning.TargetY.md 'WCSharp.Lightnings.Lightning.TargetY').

```csharp
public Lightning(string name, float casterX, float casterY, War3Api.Common.unit target);
```
#### Parameters

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,War3Api.Common.unit).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the lightning effect. See [https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/](https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/ 'https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/').

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,War3Api.Common.unit).casterX'></a>

`casterX` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,War3Api.Common.unit).casterY'></a>

`casterY` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,War3Api.Common.unit).target'></a>

`target` [War3Api.Common.unit](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.unit 'War3Api.Common.unit')

The target of the lightning. Will automatically update the position when [target](WCSharp.Lightnings.Lightning.Lightning(string,float,float,War3Api.Common.unit).md#WCSharp.Lightnings.Lightning.Lightning(string,float,float,War3Api.Common.unit).target 'WCSharp.Lightnings.Lightning.Lightning(string, float, float, War3Api.Common.unit).target') moves.