#### [WCSharp\.Buffs](README.md 'README')
### [WCSharp\.Buffs](WCSharp.Buffs.md 'WCSharp\.Buffs').[BoundBuff](WCSharp.Buffs.BoundBuff.md 'WCSharp\.Buffs\.BoundBuff')

## BoundBuff\.BindDummyCast\(int, int, int, int, player\) Method

Will use the [DummySystem](../WCSharp.Dummies/WCSharp.Dummies.DummySystem.md 'WCSharp\.Dummies\.DummySystem') to cast the given buffing ability on the target and then track it to synchronise removal\.

```csharp
public void BindDummyCast(int abilityId, int buffId, int orderId, int level=1, WCSharp.Api.player dummyPlayer=null);
```
#### Parameters

<a name='WCSharp.Buffs.BoundBuff.BindDummyCast(int,int,int,int,WCSharp.Api.player).abilityId'></a>

`abilityId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The ability ID which applies the buff that should be tracked

<a name='WCSharp.Buffs.BoundBuff.BindDummyCast(int,int,int,int,WCSharp.Api.player).buffId'></a>

`buffId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The buff ID to track

<a name='WCSharp.Buffs.BoundBuff.BindDummyCast(int,int,int,int,WCSharp.Api.player).orderId'></a>

`orderId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The order ID of the ability to cast

<a name='WCSharp.Buffs.BoundBuff.BindDummyCast(int,int,int,int,WCSharp.Api.player).level'></a>

`level` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The level of the ability to cast

<a name='WCSharp.Buffs.BoundBuff.BindDummyCast(int,int,int,int,WCSharp.Api.player).dummyPlayer'></a>

`dummyPlayer` [WCSharp\.Api\.player](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.player 'WCSharp\.Api\.player')

Who the owner of the dummy should be set to, defaults to Neutral Passive