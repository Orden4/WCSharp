#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared](WCSharp.Shared.md 'WCSharp\.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp\.Shared\.Util')

## Util\.CreateDamageText\(float, bool, bool, float, float, float, float\) Method

Creates a "damage text" style of floating text at the target location\.

Size is expected to be GUI-like values (it gets multiplied by [TEXT\_SIZE\_MULTIPLIER](WCSharp.Shared.Util.TEXT_SIZE_MULTIPLIER.md 'WCSharp\.Shared\.Util\.TEXT\_SIZE\_MULTIPLIER')).

By default, the text will start to fade after 2 seconds, and be fully removed after 4 seconds.

```csharp
public static WCSharp.Api.texttag CreateDamageText(float damage, bool isHeal, bool isCritical, float size, float x, float y, float height);
```
#### Parameters

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).damage'></a>

`damage` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The damage number to display \(will round to whole numbers\)\.

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).isHeal'></a>

`isHeal` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If true, will color green\.

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).isCritical'></a>

`isCritical` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If true, will add an exclamation mark\.

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).size'></a>

`size` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The size of the text\. See GUI\.

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).x'></a>

`x` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The x position that the text should be created at\.

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).y'></a>

`y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The y position that the text should be created at\.

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).height'></a>

`height` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The height that the text should be created at, relative to the target \(x, y\) position\.

#### Returns
[WCSharp\.Api\.texttag](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.texttag 'WCSharp\.Api\.texttag')