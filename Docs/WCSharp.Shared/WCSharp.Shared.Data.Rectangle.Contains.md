#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Data](WCSharp.Shared.Data.md 'WCSharp\.Shared\.Data').[Rectangle](WCSharp.Shared.Data.Rectangle.md 'WCSharp\.Shared\.Data\.Rectangle')

## Rectangle\.Contains Method

| Overloads | |
| :--- | :--- |
| [Contains\(float, float\)](WCSharp.Shared.Data.Rectangle.Contains.md#WCSharp.Shared.Data.Rectangle.Contains(float,float) 'WCSharp\.Shared\.Data\.Rectangle\.Contains\(float, float\)') | Returns whether the given coordinates are located within this Rectangle\. |
| [Contains\(Point\)](WCSharp.Shared.Data.Rectangle.Contains.md#WCSharp.Shared.Data.Rectangle.Contains(WCSharp.Shared.Data.Point) 'WCSharp\.Shared\.Data\.Rectangle\.Contains\(WCSharp\.Shared\.Data\.Point\)') | Returns whether the given Point is located within this Rectangle\. |
| [Contains\(Rectangle\)](WCSharp.Shared.Data.Rectangle.Contains.md#WCSharp.Shared.Data.Rectangle.Contains(WCSharp.Shared.Data.Rectangle) 'WCSharp\.Shared\.Data\.Rectangle\.Contains\(WCSharp\.Shared\.Data\.Rectangle\)') | Returns whether the given Rectangle is located fully within this Rectangle\. |

<a name='WCSharp.Shared.Data.Rectangle.Contains(float,float)'></a>

## Rectangle\.Contains\(float, float\) Method

Returns whether the given coordinates are located within this Rectangle\.

```csharp
public bool Contains(float x, float y);
```
#### Parameters

<a name='WCSharp.Shared.Data.Rectangle.Contains(float,float).x'></a>

`x` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Data.Rectangle.Contains(float,float).y'></a>

`y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='WCSharp.Shared.Data.Rectangle.Contains(WCSharp.Shared.Data.Point)'></a>

## Rectangle\.Contains\(Point\) Method

Returns whether the given Point is located within this Rectangle\.

```csharp
public bool Contains(WCSharp.Shared.Data.Point point);
```
#### Parameters

<a name='WCSharp.Shared.Data.Rectangle.Contains(WCSharp.Shared.Data.Point).point'></a>

`point` [Point](WCSharp.Shared.Data.Point.md 'WCSharp\.Shared\.Data\.Point')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='WCSharp.Shared.Data.Rectangle.Contains(WCSharp.Shared.Data.Rectangle)'></a>

## Rectangle\.Contains\(Rectangle\) Method

Returns whether the given Rectangle is located fully within this Rectangle\.

```csharp
public bool Contains(WCSharp.Shared.Data.Rectangle rect);
```
#### Parameters

<a name='WCSharp.Shared.Data.Rectangle.Contains(WCSharp.Shared.Data.Rectangle).rect'></a>

`rect` [Rectangle](WCSharp.Shared.Data.Rectangle.md 'WCSharp\.Shared\.Data\.Rectangle')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')