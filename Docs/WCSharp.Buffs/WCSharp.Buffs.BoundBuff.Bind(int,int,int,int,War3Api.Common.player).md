#### [WCSharp.Buffs](index.md 'index')
### [WCSharp.Buffs](WCSharp.Buffs.md 'WCSharp.Buffs').[BoundBuff](WCSharp.Buffs.BoundBuff.md 'WCSharp.Buffs.BoundBuff')

## BoundBuff.Bind(int, int, int, int, player) Method

Will use the [DummySystem](../WCSharp.Dummies/WCSharp.Dummies.DummySystem.md 'WCSharp.Dummies.DummySystem') to cast the given buffing ability on the target and then track it to synchronise removal.

```csharp
public void Bind(int abilityId, int buffId, int orderId, int level=1, War3Api.Common.player dummyPlayer=null);
```
#### Parameters

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int,int,War3Api.Common.player).abilityId'></a>

`abilityId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The ability ID which applies the buff that should be tracked

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int,int,War3Api.Common.player).buffId'></a>

`buffId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The buff ID to track

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int,int,War3Api.Common.player).orderId'></a>

`orderId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The order ID of the ability to cast

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int,int,War3Api.Common.player).level'></a>

`level` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The level of the ability to cast

<a name='WCSharp.Buffs.BoundBuff.Bind(int,int,int,int,War3Api.Common.player).dummyPlayer'></a>

`dummyPlayer` [War3Api.Common.player](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.player 'War3Api.Common.player')

Who the owner of the dummy should be set to, defaults to Neutral Passive