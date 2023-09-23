### [WCSharp.DateTime](WCSharp.DateTime.md 'WCSharp.DateTime')

## DateTimeSyncMethod Enum

Defines a number of different methods by which a synchronised [WcDateTime](WCSharp.DateTime.WcDateTime.md 'WCSharp.DateTime.WcDateTime') can be calculated.

```csharp
public enum DateTimeSyncMethod
```
### Fields

<a name='WCSharp.DateTime.DateTimeSyncMethod.Average'></a>

`Average` 2

Picks the average time of all players.

<a name='WCSharp.DateTime.DateTimeSyncMethod.BestFit'></a>

`BestFit` 3

Picks the time that minimizes the time difference of the chosen time compared to that of all players.  
  
In practice, this means it will pick the middle player on uneven player counts, or the one closest to the average from the two middle players on even player counts.

<a name='WCSharp.DateTime.DateTimeSyncMethod.Earliest'></a>

`Earliest` 0

Picks the earliest time among all players.

<a name='WCSharp.DateTime.DateTimeSyncMethod.Latest'></a>

`Latest` 1

Picks the latest time among all players.