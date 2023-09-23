### [WCSharp.W3MMD](WCSharp.W3MMD.md 'WCSharp.W3MMD')

## W3MmdFlag Enum

Represents the state of the player.  
  
For any particular player, only the last value set over the course of a game matters.

```csharp
public enum W3MmdFlag
```
### Fields

<a name='WCSharp.W3MMD.W3MmdFlag.Drawer'></a>

`Drawer` 0

The player ended in a draw.

<a name='WCSharp.W3MMD.W3MmdFlag.Leaver'></a>

`Leaver` 3

The player left.

<a name='WCSharp.W3MMD.W3MmdFlag.Loser'></a>

`Loser` 1

The player lost.

<a name='WCSharp.W3MMD.W3MmdFlag.Practicing'></a>

`Practicing` 4

The player is practicing.

<a name='WCSharp.W3MMD.W3MmdFlag.Winner'></a>

`Winner` 2

The player won.