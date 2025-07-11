#### [WCSharp\.Missiles](README.md 'README')
### [WCSharp\.Missiles](WCSharp.Missiles.md 'WCSharp\.Missiles').[MomentumMissile](WCSharp.Missiles.MomentumMissile.md 'WCSharp\.Missiles\.MomentumMissile')

## MomentumMissile Constructors

| Overloads | |
| :--- | :--- |
| [MomentumMissile\(player, float, float, float, float\)](WCSharp.Missiles.MomentumMissile.#ctor.md#WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.player,float,float,float,float) 'WCSharp\.Missiles\.MomentumMissile\.MomentumMissile\(WCSharp\.Api\.player, float, float, float, float\)') | Creates a new missile instance with the given parameters\. |
| [MomentumMissile\(player, float, float, unit\)](WCSharp.Missiles.MomentumMissile.#ctor.md#WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.player,float,float,WCSharp.Api.unit) 'WCSharp\.Missiles\.MomentumMissile\.MomentumMissile\(WCSharp\.Api\.player, float, float, WCSharp\.Api\.unit\)') | Creates a new missile instance with the given parameters\.   Will automatically set [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp\.Missiles\.Missile\.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp\.Missiles\.Missile\.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp\.Missiles\.Missile\.TargetY'). |
| [MomentumMissile\(unit, float, float\)](WCSharp.Missiles.MomentumMissile.#ctor.md#WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.unit,float,float) 'WCSharp\.Missiles\.MomentumMissile\.MomentumMissile\(WCSharp\.Api\.unit, float, float\)') | Creates a new missile instance with the given parameters\.   Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp\.Missiles\.Missile\.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp\.Missiles\.Missile\.CasterX') and [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp\.Missiles\.Missile\.CasterY'). |
| [MomentumMissile\(unit, unit\)](WCSharp.Missiles.MomentumMissile.#ctor.md#WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.unit,WCSharp.Api.unit) 'WCSharp\.Missiles\.MomentumMissile\.MomentumMissile\(WCSharp\.Api\.unit, WCSharp\.Api\.unit\)') | Creates a new missile instance with the given parameters\.   Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp\.Missiles\.Missile\.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp\.Missiles\.Missile\.CasterX'), [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp\.Missiles\.Missile\.CasterY'),             [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp\.Missiles\.Missile\.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp\.Missiles\.Missile\.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp\.Missiles\.Missile\.TargetY'). |

<a name='ctor.md#WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.player,float,float,float,float)'></a>

## MomentumMissile\(player, float, float, float, float\) Constructor

Creates a new missile instance with the given parameters\.

```csharp
public MomentumMissile(WCSharp.Api.player castingPlayer, float casterX, float casterY, float targetX, float targetY);
```
#### Parameters

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.player,float,float,float,float).castingPlayer'></a>

`castingPlayer` [WCSharp\.Api\.player](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.player 'WCSharp\.Api\.player')

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.player,float,float,float,float).casterX'></a>

`casterX` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.player,float,float,float,float).casterY'></a>

`casterY` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.player,float,float,float,float).targetX'></a>

`targetX` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.player,float,float,float,float).targetY'></a>

`targetY` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='ctor.md#WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.player,float,float,WCSharp.Api.unit)'></a>

## MomentumMissile\(player, float, float, unit\) Constructor

Creates a new missile instance with the given parameters\.

Will automatically set [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp\.Missiles\.Missile\.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp\.Missiles\.Missile\.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp\.Missiles\.Missile\.TargetY').

```csharp
public MomentumMissile(WCSharp.Api.player castingPlayer, float casterX, float casterY, WCSharp.Api.unit target);
```
#### Parameters

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.player,float,float,WCSharp.Api.unit).castingPlayer'></a>

`castingPlayer` [WCSharp\.Api\.player](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.player 'WCSharp\.Api\.player')

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.player,float,float,WCSharp.Api.unit).casterX'></a>

`casterX` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.player,float,float,WCSharp.Api.unit).casterY'></a>

`casterY` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.player,float,float,WCSharp.Api.unit).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='ctor.md#WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.unit,float,float)'></a>

## MomentumMissile\(unit, float, float\) Constructor

Creates a new missile instance with the given parameters\.

Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp\.Missiles\.Missile\.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp\.Missiles\.Missile\.CasterX') and [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp\.Missiles\.Missile\.CasterY').

```csharp
public MomentumMissile(WCSharp.Api.unit caster, float targetX, float targetY);
```
#### Parameters

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.unit,float,float).caster'></a>

`caster` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.unit,float,float).targetX'></a>

`targetX` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.unit,float,float).targetY'></a>

`targetY` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='ctor.md#WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.unit,WCSharp.Api.unit)'></a>

## MomentumMissile\(unit, unit\) Constructor

Creates a new missile instance with the given parameters\.

Will automatically set [CastingPlayer](WCSharp.Missiles.Missile.CastingPlayer.md 'WCSharp\.Missiles\.Missile\.CastingPlayer'), [CasterX](WCSharp.Missiles.Missile.CasterX.md 'WCSharp\.Missiles\.Missile\.CasterX'), [CasterY](WCSharp.Missiles.Missile.CasterY.md 'WCSharp\.Missiles\.Missile\.CasterY'),
            [TargetPlayer](WCSharp.Missiles.Missile.TargetPlayer.md 'WCSharp\.Missiles\.Missile\.TargetPlayer'), [TargetX](WCSharp.Missiles.Missile.TargetX.md 'WCSharp\.Missiles\.Missile\.TargetX') and [TargetY](WCSharp.Missiles.Missile.TargetY.md 'WCSharp\.Missiles\.Missile\.TargetY').

```csharp
public MomentumMissile(WCSharp.Api.unit caster, WCSharp.Api.unit target);
```
#### Parameters

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.unit,WCSharp.Api.unit).caster'></a>

`caster` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')

<a name='WCSharp.Missiles.MomentumMissile.MomentumMissile(WCSharp.Api.unit,WCSharp.Api.unit).target'></a>

`target` [WCSharp\.Api\.unit](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.unit 'WCSharp\.Api\.unit')