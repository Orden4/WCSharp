#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[BoundBuff](WCSharp.Buffs.BoundBuff.md 'WCSharp\.Buffs\.BoundBuff')

## BoundBuff\.Bind Method

| Overloads | |
| :--- | :--- |
| [Bind\(int, int, int\)](WCSharp.Buffs.BoundBuff.Bind.md#WCSharp.Buffs.BoundBuff.Bind(int,int,int) 'WCSharp\.Buffs\.BoundBuff\.Bind\(int, int, int\)') | Will add the given aura to the unit if necessary and set its level accordingly\. The aura will automatically be hidden from the command UI and removed when the buff is removed\. |
| [Bind\(int, int, int, int, player\)](WCSharp.Buffs.BoundBuff.Bind.md#WCSharp.Buffs.BoundBuff.Bind(int,int,int,int,WCSharp.Api.player) 'WCSharp\.Buffs\.BoundBuff\.Bind\(int, int, int, int, WCSharp\.Api\.player\)') | Will use the [DummySystem](../WCSharp.Dummies/WCSharp.Dummies.DummySystem.md 'WCSharp\.Dummies\.DummySystem') to cast the given buffing ability on the target and then track it to synchronise removal\. |

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int)'></a>

## BoundBuff\.Bind\(int, int, int\) Method

Will add the given aura to the unit if necessary and set its level accordingly\. The aura will automatically be hidden from the command UI
and removed when the buff is removed\.

```csharp
public void Bind(int auraId, int buffId, int level=1);
```
#### Parameters

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int).auraId'></a>

`auraId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int).buffId'></a>

`buffId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int).level'></a>

`level` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int,int,WCSharp.Api.player)'></a>

## BoundBuff\.Bind\(int, int, int, int, player\) Method

Will use the [DummySystem](../WCSharp.Dummies/WCSharp.Dummies.DummySystem.md 'WCSharp\.Dummies\.DummySystem') to cast the given buffing ability on the target and then track it to synchronise removal\.

```csharp
public void Bind(int abilityId, int buffId, int orderId, int level=1, WCSharp.Api.player dummyPlayer=null);
```
#### Parameters

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int,int,WCSharp.Api.player).abilityId'></a>

`abilityId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The ability ID which applies the buff that should be tracked

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int,int,WCSharp.Api.player).buffId'></a>

`buffId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The buff ID to track

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int,int,WCSharp.Api.player).orderId'></a>

`orderId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The order ID of the ability to cast

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int,int,WCSharp.Api.player).level'></a>

`level` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The level of the ability to cast

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int,int,WCSharp.Api.player).dummyPlayer'></a>

`dummyPlayer` [WCSharp\.Api\.player](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.player 'WCSharp\.Api\.player')

Who the owner of the dummy should be set to, defaults to Neutral Passive