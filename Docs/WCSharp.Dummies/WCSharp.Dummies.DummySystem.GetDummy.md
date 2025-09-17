#### [WCSharp\.Dummies](README.md 'README')
### [WCSharp\.Dummies](WCSharp.Dummies.md 'WCSharp\.Dummies').[DummySystem](WCSharp.Dummies.DummySystem.md 'WCSharp\.Dummies\.DummySystem')

## DummySystem\.GetDummy Method

| Overloads | |
| :--- | :--- |
| [GetDummy\(\)](WCSharp.Dummies.DummySystem.GetDummy.md#WCSharp.Dummies.DummySystem.GetDummy() 'WCSharp\.Dummies\.DummySystem\.GetDummy\(\)') | Requests an available dummy\. |
| [GetDummy\(float, float, float, player\)](WCSharp.Dummies.DummySystem.GetDummy.md#WCSharp.Dummies.DummySystem.GetDummy(float,float,float,WCSharp.Api.player) 'WCSharp\.Dummies\.DummySystem\.GetDummy\(float, float, float, WCSharp\.Api\.player\)') | Requests an available dummy at the given coordinates and under control of the given player\. |
| [GetDummy\(float, float, player\)](WCSharp.Dummies.DummySystem.GetDummy.md#WCSharp.Dummies.DummySystem.GetDummy(float,float,WCSharp.Api.player) 'WCSharp\.Dummies\.DummySystem\.GetDummy\(float, float, WCSharp\.Api\.player\)') | Requests an available dummy at the given coordinates, optionally under control of the given player\. |

<a name='WCSharp.Dummies.DummySystem.GetDummy()'></a>

## DummySystem\.GetDummy\(\) Method

Requests an available dummy\.

```csharp
public static WCSharp.Api.unit GetDummy();
```

#### Returns
[WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Dummies.DummySystem.GetDummy(float,float,float,WCSharp.Api.player)'></a>

## DummySystem\.GetDummy\(float, float, float, player\) Method

Requests an available dummy at the given coordinates and under control of the given player\.

```csharp
public static WCSharp.Api.unit GetDummy(float x, float y, float z, WCSharp.Api.player player);
```
#### Parameters

<a name='WCSharp.Dummies.DummySystem.GetDummy(float,float,float,WCSharp.Api.player).x'></a>

`x` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Dummies.DummySystem.GetDummy(float,float,float,WCSharp.Api.player).y'></a>

`y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Dummies.DummySystem.GetDummy(float,float,float,WCSharp.Api.player).z'></a>

`z` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Dummies.DummySystem.GetDummy(float,float,float,WCSharp.Api.player).player'></a>

`player` [WCSharp\.Api\.player](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.player 'WCSharp\.Api\.player')

#### Returns
[WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Dummies.DummySystem.GetDummy(float,float,WCSharp.Api.player)'></a>

## DummySystem\.GetDummy\(float, float, player\) Method

Requests an available dummy at the given coordinates, optionally under control of the given player\.

```csharp
public static WCSharp.Api.unit GetDummy(float x, float y, WCSharp.Api.player player=null);
```
#### Parameters

<a name='WCSharp.Dummies.DummySystem.GetDummy(float,float,WCSharp.Api.player).x'></a>

`x` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Dummies.DummySystem.GetDummy(float,float,WCSharp.Api.player).y'></a>

`y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Dummies.DummySystem.GetDummy(float,float,WCSharp.Api.player).player'></a>

`player` [WCSharp\.Api\.player](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.player 'WCSharp\.Api\.player')

#### Returns
[WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')