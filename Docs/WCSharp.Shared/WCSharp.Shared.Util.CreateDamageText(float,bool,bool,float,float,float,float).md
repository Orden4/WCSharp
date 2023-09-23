#### [WCSharp.Shared](index.md 'index')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp.Shared.Util')

## Util.CreateDamageText(float, bool, bool, float, float, float, float) Method

Creates a "damage text" style of floating text at the target location.  
  
Size is expected to be GUI-like values (it gets multiplied by [TEXT_SIZE_MULTIPLIER](WCSharp.Shared.Util.TEXT_SIZE_MULTIPLIER.md 'WCSharp.Shared.Util.TEXT_SIZE_MULTIPLIER')).  
  
By default, the text will start to fade after 2 seconds, and be fully removed after 4 seconds.

```csharp
public static War3Api.Common.texttag CreateDamageText(float damage, bool isHeal, bool isCritical, float size, float x, float y, float height);
```
#### Parameters

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).damage'></a>

`damage` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The damage number to display (will round to whole numbers).

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).isHeal'></a>

`isHeal` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If true, will color green.

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).isCritical'></a>

`isCritical` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If true, will add an exclamation mark.

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).size'></a>

`size` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The size of the text. See GUI.

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).x'></a>

`x` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The x position that the text should be created at.

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).y'></a>

`y` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The y position that the text should be created at.

<a name='WCSharp.Shared.Util.CreateDamageText(float,bool,bool,float,float,float,float).height'></a>

`height` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The height that the text should be created at, relative to the target (x, y) position.

#### Returns
[War3Api.Common.texttag](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.texttag 'War3Api.Common.texttag')