#### [WCSharp.Shared](index.md 'index')
### [WCSharp.Shared.Data](WCSharp.Shared.Data.md 'WCSharp.Shared.Data')

## Point Class

Data class for a simple point coordinate.

```csharp
public class Point :
System.IEquatable<WCSharp.Shared.Data.Point>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Point

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Point](WCSharp.Shared.Data.Point.md 'WCSharp.Shared.Data.Point')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Point(float, float)](WCSharp.Shared.Data.Point.Point(float,float).md 'WCSharp.Shared.Data.Point.Point(float, float)') | Creates a new point at the given X and Y cooridnates. |

| Properties | |
| :--- | :--- |
| [X](WCSharp.Shared.Data.Point.X.md 'WCSharp.Shared.Data.Point.X') | The X-coordinate of this point. |
| [Y](WCSharp.Shared.Data.Point.Y.md 'WCSharp.Shared.Data.Point.Y') | The Y-coordinate of this point. |

| Methods | |
| :--- | :--- |
| [Equals(object)](WCSharp.Shared.Data.Point.Equals(object).md 'WCSharp.Shared.Data.Point.Equals(object)') | Determines whether the specified object is equal to the current object. |
| [GetHashCode()](WCSharp.Shared.Data.Point.GetHashCode().md 'WCSharp.Shared.Data.Point.GetHashCode()') | Serves as the default hash function. |

| Operators | |
| :--- | :--- |
| [operator ==(Point, Point)](WCSharp.Shared.Data.Point.op_Equality(WCSharp.Shared.Data.Point,WCSharp.Shared.Data.Point).md 'WCSharp.Shared.Data.Point.op_Equality(WCSharp.Shared.Data.Point, WCSharp.Shared.Data.Point)') | True if the X and Y coordinates of the two points match. |
| [operator !=(Point, Point)](WCSharp.Shared.Data.Point.op_Inequality(WCSharp.Shared.Data.Point,WCSharp.Shared.Data.Point).md 'WCSharp.Shared.Data.Point.op_Inequality(WCSharp.Shared.Data.Point, WCSharp.Shared.Data.Point)') | True if the X and Y coordinates of the two points do not match. |
