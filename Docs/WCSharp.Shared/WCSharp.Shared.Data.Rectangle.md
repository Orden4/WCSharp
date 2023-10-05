#### [WCSharp.Shared](README.md 'README')
### [WCSharp.Shared.Data](WCSharp.Shared.Data.md 'WCSharp.Shared.Data')

## Rectangle Class

Data class that mimics the functions of the standard Rect.cs while providing access to WC3 rect and region representations.

```csharp
public class Rectangle :
System.IDisposable,
System.IEquatable<WCSharp.Shared.Data.Rectangle>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Rectangle

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Rectangle](WCSharp.Shared.Data.Rectangle.md 'WCSharp.Shared.Data.Rectangle')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Rectangle(float, float, float, float)](WCSharp.Shared.Data.Rectangle.Rectangle(float,float,float,float).md 'WCSharp.Shared.Data.Rectangle.Rectangle(float, float, float, float)') | Creates a new rectangle with the given set of coordinates. |
| [Rectangle(IEnumerable&lt;Point&gt;)](WCSharp.Shared.Data.Rectangle.Rectangle(System.Collections.Generic.IEnumerable_WCSharp.Shared.Data.Point_).md 'WCSharp.Shared.Data.Rectangle.Rectangle(System.Collections.Generic.IEnumerable<WCSharp.Shared.Data.Point>)') | Creates a Rectangle that encompasses all of the given points within its surface area. |
| [Rectangle(rect)](WCSharp.Shared.Data.Rectangle.Rectangle(War3Api.Common.rect).md 'WCSharp.Shared.Data.Rectangle.Rectangle(War3Api.Common.rect)') | Creates a new rectangle using the given Warcraft III rect as a base. |

| Properties | |
| :--- | :--- |
| [Bottom](WCSharp.Shared.Data.Rectangle.Bottom.md 'WCSharp.Shared.Data.Rectangle.Bottom') | The bottom-most Y coordinate. |
| [BottomLeft](WCSharp.Shared.Data.Rectangle.BottomLeft.md 'WCSharp.Shared.Data.Rectangle.BottomLeft') | The point corresponding to the bottom-left of the rectangle. |
| [BottomRight](WCSharp.Shared.Data.Rectangle.BottomRight.md 'WCSharp.Shared.Data.Rectangle.BottomRight') | The point corresponding to the bottom-right of the rectangle. |
| [Center](WCSharp.Shared.Data.Rectangle.Center.md 'WCSharp.Shared.Data.Rectangle.Center') | The point corresponding to the center of the rectangle. |
| [Height](WCSharp.Shared.Data.Rectangle.Height.md 'WCSharp.Shared.Data.Rectangle.Height') | The distance between the top-most and bottom-most coordinates. |
| [IsEmpty](WCSharp.Shared.Data.Rectangle.IsEmpty.md 'WCSharp.Shared.Data.Rectangle.IsEmpty') | A Rectangle is empty if its width or height is 0. |
| [Left](WCSharp.Shared.Data.Rectangle.Left.md 'WCSharp.Shared.Data.Rectangle.Left') | The left-most X coordinate. |
| [Rect](WCSharp.Shared.Data.Rectangle.Rect.md 'WCSharp.Shared.Data.Rectangle.Rect') | The Warcraft III rect. Generated on demand. |
| [Region](WCSharp.Shared.Data.Rectangle.Region.md 'WCSharp.Shared.Data.Rectangle.Region') | The Warcraft III region. Generated on demand. |
| [Right](WCSharp.Shared.Data.Rectangle.Right.md 'WCSharp.Shared.Data.Rectangle.Right') | The right-most X coordinate. |
| [Top](WCSharp.Shared.Data.Rectangle.Top.md 'WCSharp.Shared.Data.Rectangle.Top') | The top-most Y coordinate. |
| [TopLeft](WCSharp.Shared.Data.Rectangle.TopLeft.md 'WCSharp.Shared.Data.Rectangle.TopLeft') | The point corresponding to the top-left of the rectangle. |
| [TopRight](WCSharp.Shared.Data.Rectangle.TopRight.md 'WCSharp.Shared.Data.Rectangle.TopRight') | The point corresponding to the top-right of the rectangle. |
| [Width](WCSharp.Shared.Data.Rectangle.Width.md 'WCSharp.Shared.Data.Rectangle.Width') | The distance between the right-most and left-most coordinates. |
| [WorldBounds](WCSharp.Shared.Data.Rectangle.WorldBounds.md 'WCSharp.Shared.Data.Rectangle.WorldBounds') | Represents the world bounds of the map. Automatically initialised. |

| Methods | |
| :--- | :--- |
| [Contains(float, float)](WCSharp.Shared.Data.Rectangle.Contains(float,float).md 'WCSharp.Shared.Data.Rectangle.Contains(float, float)') | Returns whether the given coordinates are located within this Rectangle. |
| [Contains(Point)](WCSharp.Shared.Data.Rectangle.Contains(WCSharp.Shared.Data.Point).md 'WCSharp.Shared.Data.Rectangle.Contains(WCSharp.Shared.Data.Point)') | Returns whether the given Point is located within this Rectangle. |
| [Contains(Rectangle)](WCSharp.Shared.Data.Rectangle.Contains(WCSharp.Shared.Data.Rectangle).md 'WCSharp.Shared.Data.Rectangle.Contains(WCSharp.Shared.Data.Rectangle)') | Returns whether the given Rectangle is located fully within this Rectangle. |
| [Dispose()](WCSharp.Shared.Data.Rectangle.Dispose().md 'WCSharp.Shared.Data.Rectangle.Dispose()') | Must be called in order to safely garbage collect [Rect](WCSharp.Shared.Data.Rectangle.Rect.md 'WCSharp.Shared.Data.Rectangle.Rect') and [Region](WCSharp.Shared.Data.Rectangle.Region.md 'WCSharp.Shared.Data.Rectangle.Region'). |
| [Equals(object)](WCSharp.Shared.Data.Rectangle.Equals(object).md 'WCSharp.Shared.Data.Rectangle.Equals(object)') | Determines whether the specified object is equal to the current object. |
| [GetHashCode()](WCSharp.Shared.Data.Rectangle.GetHashCode().md 'WCSharp.Shared.Data.Rectangle.GetHashCode()') | Serves as the default hash function. |
| [GetRandomPoint()](WCSharp.Shared.Data.Rectangle.GetRandomPoint().md 'WCSharp.Shared.Data.Rectangle.GetRandomPoint()') | Retrieves a random (inclusive) point in this rectangle. |
| [Inflate(Rectangle, float, float)](WCSharp.Shared.Data.Rectangle.Inflate(WCSharp.Shared.Data.Rectangle,float,float).md 'WCSharp.Shared.Data.Rectangle.Inflate(WCSharp.Shared.Data.Rectangle, float, float)') | Returns a new Rectangle that is inflated by the given width and height in all directions.<br/><br/><br/>The increase on each side is half the width/height. |
| [Intersect(Rectangle, Rectangle)](WCSharp.Shared.Data.Rectangle.Intersect(WCSharp.Shared.Data.Rectangle,WCSharp.Shared.Data.Rectangle).md 'WCSharp.Shared.Data.Rectangle.Intersect(WCSharp.Shared.Data.Rectangle, WCSharp.Shared.Data.Rectangle)') | Returns a new Rectangle that represents the intersection of the two given Rectangles. Meaning, the area in which they overlap. |
| [IntersectsWith(Rectangle)](WCSharp.Shared.Data.Rectangle.IntersectsWith(WCSharp.Shared.Data.Rectangle).md 'WCSharp.Shared.Data.Rectangle.IntersectsWith(WCSharp.Shared.Data.Rectangle)') | Returns whether this Rectangle has any point where it touches or overlaps with the given Rectangle. |
| [Offset(Rectangle, float, float)](WCSharp.Shared.Data.Rectangle.Offset(WCSharp.Shared.Data.Rectangle,float,float).md 'WCSharp.Shared.Data.Rectangle.Offset(WCSharp.Shared.Data.Rectangle, float, float)') | Returns a new Rectangle that is offset by the given coordinates, using [TopLeft](WCSharp.Shared.Data.Rectangle.TopLeft.md 'WCSharp.Shared.Data.Rectangle.TopLeft') as the origin for movement. |
| [Scale(Rectangle, float, float)](WCSharp.Shared.Data.Rectangle.Scale(WCSharp.Shared.Data.Rectangle,float,float).md 'WCSharp.Shared.Data.Rectangle.Scale(WCSharp.Shared.Data.Rectangle, float, float)') | Returns a new Rectangle that is scaled up by the given scaling factors. |
| [Union(Rectangle, Rectangle)](WCSharp.Shared.Data.Rectangle.Union(WCSharp.Shared.Data.Rectangle,WCSharp.Shared.Data.Rectangle).md 'WCSharp.Shared.Data.Rectangle.Union(WCSharp.Shared.Data.Rectangle, WCSharp.Shared.Data.Rectangle)') | Returns a new Rectangle that represents the union of the two given Rectangles. Meaning, a new square that can encompass both. |

| Operators | |
| :--- | :--- |
| [operator ==(Rectangle, Rectangle)](WCSharp.Shared.Data.Rectangle.op_Equality(WCSharp.Shared.Data.Rectangle,WCSharp.Shared.Data.Rectangle).md 'WCSharp.Shared.Data.Rectangle.op_Equality(WCSharp.Shared.Data.Rectangle, WCSharp.Shared.Data.Rectangle)') | True if all coordinates of [rect1](WCSharp.Shared.Data.Rectangle.op_Equality(WCSharp.Shared.Data.Rectangle,WCSharp.Shared.Data.Rectangle).md#WCSharp.Shared.Data.Rectangle.op_Equality(WCSharp.Shared.Data.Rectangle,WCSharp.Shared.Data.Rectangle).rect1 'WCSharp.Shared.Data.Rectangle.op_Equality(WCSharp.Shared.Data.Rectangle, WCSharp.Shared.Data.Rectangle).rect1') match those of [rect2](WCSharp.Shared.Data.Rectangle.op_Equality(WCSharp.Shared.Data.Rectangle,WCSharp.Shared.Data.Rectangle).md#WCSharp.Shared.Data.Rectangle.op_Equality(WCSharp.Shared.Data.Rectangle,WCSharp.Shared.Data.Rectangle).rect2 'WCSharp.Shared.Data.Rectangle.op_Equality(WCSharp.Shared.Data.Rectangle, WCSharp.Shared.Data.Rectangle).rect2'). |
| [operator !=(Rectangle, Rectangle)](WCSharp.Shared.Data.Rectangle.op_Inequality(WCSharp.Shared.Data.Rectangle,WCSharp.Shared.Data.Rectangle).md 'WCSharp.Shared.Data.Rectangle.op_Inequality(WCSharp.Shared.Data.Rectangle, WCSharp.Shared.Data.Rectangle)') | True if any coordinates of [rect1](WCSharp.Shared.Data.Rectangle.op_Inequality(WCSharp.Shared.Data.Rectangle,WCSharp.Shared.Data.Rectangle).md#WCSharp.Shared.Data.Rectangle.op_Inequality(WCSharp.Shared.Data.Rectangle,WCSharp.Shared.Data.Rectangle).rect1 'WCSharp.Shared.Data.Rectangle.op_Inequality(WCSharp.Shared.Data.Rectangle, WCSharp.Shared.Data.Rectangle).rect1') do not match those of [rect2](WCSharp.Shared.Data.Rectangle.op_Inequality(WCSharp.Shared.Data.Rectangle,WCSharp.Shared.Data.Rectangle).md#WCSharp.Shared.Data.Rectangle.op_Inequality(WCSharp.Shared.Data.Rectangle,WCSharp.Shared.Data.Rectangle).rect2 'WCSharp.Shared.Data.Rectangle.op_Inequality(WCSharp.Shared.Data.Rectangle, WCSharp.Shared.Data.Rectangle).rect2'). |
