#### [WCSharp\.Shared](README.md 'README')
### [WCSharp\.Shared\.Data](WCSharp.Shared.Data.md 'WCSharp\.Shared\.Data').[Rectangle](WCSharp.Shared.Data.Rectangle.md 'WCSharp\.Shared\.Data\.Rectangle')

## Rectangle Constructors

| Overloads | |
| :--- | :--- |
| [Rectangle\(float, float, float, float\)](WCSharp.Shared.Data.Rectangle.#ctor.md#WCSharp.Shared.Data.Rectangle.Rectangle(float,float,float,float) 'WCSharp\.Shared\.Data\.Rectangle\.Rectangle\(float, float, float, float\)') | Creates a new rectangle with the given set of coordinates\. |
| [Rectangle\(IEnumerable&lt;Point&gt;\)](WCSharp.Shared.Data.Rectangle.#ctor.md#WCSharp.Shared.Data.Rectangle.Rectangle(System.Collections.Generic.IEnumerable_WCSharp.Shared.Data.Point_) 'WCSharp\.Shared\.Data\.Rectangle\.Rectangle\(System\.Collections\.Generic\.IEnumerable\<WCSharp\.Shared\.Data\.Point\>\)') | Creates a Rectangle that encompasses all of the given points within its surface area\. |
| [Rectangle\(rect\)](WCSharp.Shared.Data.Rectangle.#ctor.md#WCSharp.Shared.Data.Rectangle.Rectangle(WCSharp.Api.rect) 'WCSharp\.Shared\.Data\.Rectangle\.Rectangle\(WCSharp\.Api\.rect\)') | Creates a new rectangle using the given Warcraft III rect as a base\. |

<a name='ctor.md#WCSharp.Shared.Data.Rectangle.Rectangle(float,float,float,float)'></a>

## Rectangle\(float, float, float, float\) Constructor

Creates a new rectangle with the given set of coordinates\.

```csharp
public Rectangle(float left, float bottom, float right, float top);
```
#### Parameters

<a name='WCSharp.Shared.Data.Rectangle.Rectangle(float,float,float,float).left'></a>

`left` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Data.Rectangle.Rectangle(float,float,float,float).bottom'></a>

`bottom` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Data.Rectangle.Rectangle(float,float,float,float).right'></a>

`right` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='WCSharp.Shared.Data.Rectangle.Rectangle(float,float,float,float).top'></a>

`top` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='ctor.md#WCSharp.Shared.Data.Rectangle.Rectangle(System.Collections.Generic.IEnumerable_WCSharp.Shared.Data.Point_)'></a>

## Rectangle\(IEnumerable\<Point\>\) Constructor

Creates a Rectangle that encompasses all of the given points within its surface area\.

```csharp
public Rectangle(System.Collections.Generic.IEnumerable<WCSharp.Shared.Data.Point> points);
```
#### Parameters

<a name='WCSharp.Shared.Data.Rectangle.Rectangle(System.Collections.Generic.IEnumerable_WCSharp.Shared.Data.Point_).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point](WCSharp.Shared.Data.Point.md 'WCSharp\.Shared\.Data\.Point')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='ctor.md#WCSharp.Shared.Data.Rectangle.Rectangle(WCSharp.Api.rect)'></a>

## Rectangle\(rect\) Constructor

Creates a new rectangle using the given Warcraft III rect as a base\.

```csharp
public Rectangle(WCSharp.Api.rect rect);
```
#### Parameters

<a name='WCSharp.Shared.Data.Rectangle.Rectangle(WCSharp.Api.rect).rect'></a>

`rect` [WCSharp\.Api\.rect](https://learn.microsoft.com/en-us/dotnet/api/wcsharp.api.rect 'WCSharp\.Api\.rect')