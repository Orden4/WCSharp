#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared](WCSharp.Shared.md 'WCSharp\.Shared').[Util](WCSharp.Shared.Util.md 'WCSharp\.Shared\.Util')

## Util\.CreateFloatText\(string, float, float, float, float, int, int, int\) Method

Creates a floating text at the target location\.

Size is expected to be GUI-like values (it gets multiplied by [TEXT\_SIZE\_MULTIPLIER](WCSharp.Shared.Util.TEXT_SIZE_MULTIPLIER.md 'WCSharp\.Shared\.Util\.TEXT\_SIZE\_MULTIPLIER')).

By default, the text will start to fade after 2 seconds, and be fully removed after 4 seconds.

```csharp
public static WCSharp.Api.texttag CreateFloatText(string text, float size, float x, float y, float height, int red, int green, int blue);
```
#### Parameters

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text to display\.

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).size'></a>

`size` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The size of the text\. See GUI\.

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).x'></a>

`x` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The x position that the text should be created at\.

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).y'></a>

`y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The y position that the text should be created at\.

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).height'></a>

`height` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The height that the text should be created at, relative to the target \(x, y\) position\.

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).red'></a>

`red` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The red value of the text\. Should be in the range of 0 \(none\) to 255 \(pure red\)\.

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).green'></a>

`green` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The green value of the text\. Should be in the range of 0 \(none\) to 255 \(pure green\)\.

<a name='WCSharp.Shared.Util.CreateFloatText(string,float,float,float,float,int,int,int).blue'></a>

`blue` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The blue value of the text\. Should be in the range of 0 \(none\) to 255 \(pure blue\)\.

#### Returns
[WCSharp\.Api\.texttag](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.texttag 'WCSharp\.Api\.texttag')