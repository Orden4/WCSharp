#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared](WCSharp.Shared.md 'WCSharp\.Shared').[Delay](WCSharp.Shared.Delay.md 'WCSharp\.Shared\.Delay')

## Delay\.Add\(Action\) Method


Will execute the given action after a 0 second delay, which translates to a single frame.

This can be used to circumvent various issues, such as unit AI locking up if you give them a new order at the same time as they start an attack.

```csharp
public static void Add(System.Action func);
```
#### Parameters

<a name='WCSharp.Shared.Delay.Add(System.Action).func'></a>

`func` [System\.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action 'System\.Action')