#### [WCSharp.Events](README.md 'README')
### [WCSharp.Events](WCSharp.Events.md 'WCSharp.Events').[ISmoothAction](WCSharp.Events.ISmoothAction.md 'WCSharp.Events.ISmoothAction')

## ISmoothAction.TicksLeft Property

The number of ticks remaining before the next tick.  
  
This is always set to the actions per tick before [Action()](WCSharp.Events.ISmoothAction.Action().md 'WCSharp.Events.ISmoothAction.Action()') is called.

```csharp
int TicksLeft { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')