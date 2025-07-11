#### [WCSharp\.Lightnings](README.md 'README')
### [WCSharp\.Lightnings](WCSharp.Lightnings.md 'WCSharp\.Lightnings').[Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning')

## Lightning Constructors

| Overloads | |
| :--- | :--- |
| [Lightning\(string, float, float, float, float\)](WCSharp.Lightnings.Lightning.#ctor.md#WCSharp.Lightnings.Lightning.Lightning(string,float,float,float,float) 'WCSharp\.Lightnings\.Lightning\.Lightning\(string, float, float, float, float\)') | Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning') instance with the given parameters\. |
| [Lightning\(string, float, float, unit\)](WCSharp.Lightnings.Lightning.#ctor.md#WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit) 'WCSharp\.Lightnings\.Lightning\.Lightning\(string, float, float, WCSharp\.Api\.unit\)') | Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning') instance with the given parameters\.   Will automatically set [TargetX](WCSharp.Lightnings.Lightning.TargetX.md 'WCSharp\.Lightnings\.Lightning\.TargetX') and [TargetY](WCSharp.Lightnings.Lightning.TargetY.md 'WCSharp\.Lightnings\.Lightning\.TargetY'). |
| [Lightning\(string, unit, float, float\)](WCSharp.Lightnings.Lightning.#ctor.md#WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float) 'WCSharp\.Lightnings\.Lightning\.Lightning\(string, WCSharp\.Api\.unit, float, float\)') | Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning') instance with the given parameters\.   Will automatically set [CasterX](WCSharp.Lightnings.Lightning.CasterX.md 'WCSharp\.Lightnings\.Lightning\.CasterX') and [CasterY](WCSharp.Lightnings.Lightning.CasterY.md 'WCSharp\.Lightnings\.Lightning\.CasterY'). |
| [Lightning\(string, unit, unit\)](WCSharp.Lightnings.Lightning.#ctor.md#WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit) 'WCSharp\.Lightnings\.Lightning\.Lightning\(string, WCSharp\.Api\.unit, WCSharp\.Api\.unit\)') | Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning') instance with the given parameters\.   Will automatically set [CasterX](WCSharp.Lightnings.Lightning.CasterX.md 'WCSharp\.Lightnings\.Lightning\.CasterX'), [CasterY](WCSharp.Lightnings.Lightning.CasterY.md 'WCSharp\.Lightnings\.Lightning\.CasterY'), [TargetX](WCSharp.Lightnings.Lightning.TargetX.md 'WCSharp\.Lightnings\.Lightning\.TargetX') and [TargetY](WCSharp.Lightnings.Lightning.TargetY.md 'WCSharp\.Lightnings\.Lightning\.TargetY'). |

<a name='ctor.md#WCSharp.Lightnings.Lightning.Lightning(string,float,float,float,float)'></a>

## Lightning\(string, float, float, float, float\) Constructor

Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning') instance with the given parameters\.

```csharp
public Lightning(string name, float casterX, float casterY, float targetX, float targetY);
```
#### Parameters

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,float,float).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the lightning effect\. See [https://www\.hiveworkshop\.com/threads/beginners\-guide\-to\-lightning\-effects\.220370/](https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/ 'https://www\.hiveworkshop\.com/threads/beginners\-guide\-to\-lightning\-effects\.220370/')\.

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,float,float).casterX'></a>

`casterX` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,float,float).casterY'></a>

`casterY` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,float,float).targetX'></a>

`targetX` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,float,float).targetY'></a>

`targetY` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='ctor.md#WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit)'></a>

## Lightning\(string, float, float, unit\) Constructor

Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning') instance with the given parameters\.

Will automatically set [TargetX](WCSharp.Lightnings.Lightning.TargetX.md 'WCSharp\.Lightnings\.Lightning\.TargetX') and [TargetY](WCSharp.Lightnings.Lightning.TargetY.md 'WCSharp\.Lightnings\.Lightning\.TargetY').

```csharp
public Lightning(string name, float casterX, float casterY, WCSharp.Api.unit target);
```
#### Parameters

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the lightning effect\. See [https://www\.hiveworkshop\.com/threads/beginners\-guide\-to\-lightning\-effects\.220370/](https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/ 'https://www\.hiveworkshop\.com/threads/beginners\-guide\-to\-lightning\-effects\.220370/')\.

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit).casterX'></a>

`casterX` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit).casterY'></a>

`casterY` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The target of the lightning\. Will automatically update the position when [target](WCSharp.Lightnings.Lightning.md#WCSharp.Lightnings.Lightning.Lightning(string,float,float,WCSharp.Api.unit).target 'WCSharp\.Lightnings\.Lightning\.Lightning\(string, float, float, WCSharp\.Api\.unit\)\.target') moves\.

<a name='ctor.md#WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float)'></a>

## Lightning\(string, unit, float, float\) Constructor

Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning') instance with the given parameters\.

Will automatically set [CasterX](WCSharp.Lightnings.Lightning.CasterX.md 'WCSharp\.Lightnings\.Lightning\.CasterX') and [CasterY](WCSharp.Lightnings.Lightning.CasterY.md 'WCSharp\.Lightnings\.Lightning\.CasterY').

```csharp
public Lightning(string name, WCSharp.Api.unit caster, float targetX, float targetY);
```
#### Parameters

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the lightning effect\. See [https://www\.hiveworkshop\.com/threads/beginners\-guide\-to\-lightning\-effects\.220370/](https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/ 'https://www\.hiveworkshop\.com/threads/beginners\-guide\-to\-lightning\-effects\.220370/')\.

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float).caster'></a>

`caster` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The source of the lightning\. Will automatically update the position when [caster](WCSharp.Lightnings.Lightning.md#WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float).caster 'WCSharp\.Lightnings\.Lightning\.Lightning\(string, WCSharp\.Api\.unit, float, float\)\.caster') moves\.

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float).targetX'></a>

`targetX` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,float,float).targetY'></a>

`targetY` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='ctor.md#WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit)'></a>

## Lightning\(string, unit, unit\) Constructor

Creates a new [Lightning](WCSharp.Lightnings.Lightning.md 'WCSharp\.Lightnings\.Lightning') instance with the given parameters\.

Will automatically set [CasterX](WCSharp.Lightnings.Lightning.CasterX.md 'WCSharp\.Lightnings\.Lightning\.CasterX'), [CasterY](WCSharp.Lightnings.Lightning.CasterY.md 'WCSharp\.Lightnings\.Lightning\.CasterY'), [TargetX](WCSharp.Lightnings.Lightning.TargetX.md 'WCSharp\.Lightnings\.Lightning\.TargetX') and [TargetY](WCSharp.Lightnings.Lightning.TargetY.md 'WCSharp\.Lightnings\.Lightning\.TargetY').

```csharp
public Lightning(string name, WCSharp.Api.unit caster, WCSharp.Api.unit target);
```
#### Parameters

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the lightning effect\. See [https://www\.hiveworkshop\.com/threads/beginners\-guide\-to\-lightning\-effects\.220370/](https://www.hiveworkshop.com/threads/beginners-guide-to-lightning-effects.220370/ 'https://www\.hiveworkshop\.com/threads/beginners\-guide\-to\-lightning\-effects\.220370/')\.

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit).caster'></a>

`caster` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The source of the lightning\. Will automatically update the position when [caster](WCSharp.Lightnings.Lightning.md#WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit).caster 'WCSharp\.Lightnings\.Lightning\.Lightning\(string, WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.caster') moves\.

<a name='WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

The target of the lightning\. Will automatically update the position when [target](WCSharp.Lightnings.Lightning.md#WCSharp.Lightnings.Lightning.Lightning(string,WCSharp.Api.unit,WCSharp.Api.unit).target 'WCSharp\.Lightnings\.Lightning\.Lightning\(string, WCSharp\.Api\.unit, WCSharp\.Api\.unit\)\.target') moves\.