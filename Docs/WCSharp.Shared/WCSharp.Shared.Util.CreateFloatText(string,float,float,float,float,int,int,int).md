#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared](WCSharp.Shared.md 'WCSharp.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp.Shared.Util')

## Util.CreateFloatText(string, float, float, float, float, int, int, int) Method

Creates a floating text at the target location.  
  
Size is expected to be GUI-like values (it gets multiplied by [TEXT_SIZE_MULTIPLIER](WCSharp.Shared.Util.TEXT_SIZE_MULTIPLIER.md 'WCSharp.Shared.Util.TEXT_SIZE_MULTIPLIER')).  
  
By default, the text will start to fade after 2 seconds, and be fully removed after 4 seconds.

```csharp
public static War3Api.Common.texttag CreateFloatText(string text, float size, float x, float y, float height, int red, int green, int blue);
```
#### Parameters

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).text'></a>

`text` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The text to display.

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).size'></a>

`size` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The size of the text. See GUI.

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).x'></a>

`x` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The x position that the text should be created at.

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).y'></a>

`y` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The y position that the text should be created at.

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).height'></a>

`height` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The height that the text should be created at, relative to the target (x, y) position.

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).red'></a>

`red` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The red value of the text. Should be in the range of 0 (none) to 255 (pure red).

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).green'></a>

`green` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The green value of the text. Should be in the range of 0 (none) to 255 (pure green).

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).blue'></a>

`blue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The blue value of the text. Should be in the range of 0 (none) to 255 (pure blue).

#### Returns
[War3Api.Common.texttag](https://docs.microsoft.com/en-us/dotnet/api/War3Api.Common.texttag 'War3Api.Common.texttag')