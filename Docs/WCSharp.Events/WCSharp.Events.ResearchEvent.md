#### [WCSharp\.Events](README.md 'README')
### [WCSharp\.Events](WCSharp.Events.md 'WCSharp\.Events')

## ResearchEvent Enum

Defines all built\-in ResearchEvents supported by [PlayerUnitEvents](WCSharp.Events.PlayerUnitEvents.md 'WCSharp\.Events\.PlayerUnitEvents')\.

All of these events fire based on a research id filter.

Custom events can also be specified via [AddCustomEvent\(string, Func&lt;int&gt;, playerunitevent\)](WCSharp.Events.PlayerUnitEvents.AddCustomEvent(string,System.Func_int_,WCSharp.Api.playerunitevent).md 'WCSharp\.Events\.PlayerUnitEvents\.AddCustomEvent\(string, System\.Func\<int\>, WCSharp\.Api\.playerunitevent\)').

```csharp
public enum ResearchEvent
```
### Fields

<a name='WCSharp.Events.ResearchEvent.IsCancelled'></a>

`IsCancelled` 501

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_CANCEL

<a name='WCSharp.Events.ResearchEvent.IsFinished'></a>

`IsFinished` 502

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_FINISH

<a name='WCSharp.Events.ResearchEvent.IsStarted'></a>

`IsStarted` 503

Based on EVENT\_PLAYER\_UNIT\_RESEARCH\_START