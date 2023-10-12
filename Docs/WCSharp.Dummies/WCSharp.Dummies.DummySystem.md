#### [WCSharp.Dummies](README.md 'README')
### [WCSharp.Dummies](WCSharp.Dummies.md 'WCSharp.Dummies')

## DummySystem Class

Tracks and recycles all dummy units on the map. Will automatically create more if necessary.

```csharp
public static class DummySystem
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DummySystem

| Fields | |
| :--- | :--- |
| [UNIT_TYPE_DUMMY](WCSharp.Dummies.DummySystem.UNIT_TYPE_DUMMY.md 'WCSharp.Dummies.DummySystem.UNIT_TYPE_DUMMY') | Corresponds to the code 'xxxx' |

| Methods | |
| :--- | :--- |
| [GetDummy()](WCSharp.Dummies.DummySystem.GetDummy().md 'WCSharp.Dummies.DummySystem.GetDummy()') | Requests an available dummy. |
| [GetDummy(float, float, float, player)](WCSharp.Dummies.DummySystem.GetDummy(float,float,float,WCSharp.Api.player).md 'WCSharp.Dummies.DummySystem.GetDummy(float, float, float, WCSharp.Api.player)') | Requests an available dummy at the given coordinates and under control of the given player. |
| [RecycleDummy(unit, float)](WCSharp.Dummies.DummySystem.RecycleDummy(WCSharp.Api.unit,float).md 'WCSharp.Dummies.DummySystem.RecycleDummy(WCSharp.Api.unit, float)') | Call this when you are done with a dummy. The dummy will become available for use again after the [recycleTime](WCSharp.Dummies.DummySystem.RecycleDummy(WCSharp.Api.unit,float).md#WCSharp.Dummies.DummySystem.RecycleDummy(WCSharp.Api.unit,float).recycleTime 'WCSharp.Dummies.DummySystem.RecycleDummy(WCSharp.Api.unit, float).recycleTime'). |
