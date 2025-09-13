#### [WCSharp\.Timers](README.md 'README')
### [WCSharp\.Timers](WCSharp.Timers.md 'WCSharp\.Timers').[TimerSetSmooth&lt;T&gt;](WCSharp.Timers.TimerSetSmooth_T_.md 'WCSharp\.Timers\.TimerSetSmooth\<T\>')

## TimerSetSmooth\<T\>\.RootTimeout Property

The time interval of the smoothing timer\.

All actions internally tick down in increments specified by this property.

For example, setting timeout to 1 and root timeout to 0.125 will make the timers expire every second,
            with each check being 0.125 seconds apart.

```csharp
public float RootTimeout { get; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')