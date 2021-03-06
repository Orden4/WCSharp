using System;
using System.Collections.Generic;
using System.Linq;
using static War3Api.Common;

namespace WCSharp.Utils.Data
{
	/// <summary>
	/// Data class that mimics the functions of the standard Rect.cs while providing access to WC3 rect and region representations.
	/// </summary>
	public class Rectangle : IDisposable
	{
		public static Rectangle WorldBounds { get; private set; } = new Rectangle(GetWorldBounds());

		private rect rect;
		private region region;

		public float Left { get; private set; }
		public float Bottom { get; private set; }
		public float Right { get; private set; }
		public float Top { get; private set; }
		public rect Rect
		{
			get
			{
				if (this.rect == null)
				{
					this.rect = Rect(Left, Bottom, Right, Top);
				}

				return this.rect;
			}
		}
		public region Region
		{
			get
			{
				if (this.region == null)
				{
					this.region = CreateRegion();
					RegionAddRect(this.region, Rect);
				}

				return this.region;
			}
		}

		public float Width => Right - Left;
		public float Height => Top - Bottom;

		public Point TopLeft => new Point(Left, Top);
		public Point TopRight => new Point(Right, Top);
		public Point BottomLeft => new Point(Left, Bottom);
		public Point BottomRight => new Point(Right, Bottom);
		public Point Center => new Point((Left + Right) / 2, (Bottom + Top) / 2);

		/// <summary>
		/// A Rectangle is empty if its width or height is 0.
		/// </summary>
		public bool IsEmpty => Width == 0 || Height == 0;

		public Rectangle(rect rect)
		{
			Left = GetRectMinX(rect);
			Bottom = GetRectMinY(rect);
			Right = GetRectMaxX(rect);
			Top = GetRectMaxY(rect);
			this.rect = rect;
		}

		public Rectangle(float left, float bottom, float right, float top)
		{
			Left = Math.Min(left, right);
			Bottom = Math.Min(bottom, top);
			Right = right;
			Top = top;
		}

		/// <summary>
		/// Creates a Rectangle that can encompass all of the given points within its surface area.
		/// </summary>
		public Rectangle(IEnumerable<Point> points)
		{
			var list = points.ToList();
			if (list.Count != 0)
			{
				Left = WorldBounds.Right;
				Bottom = WorldBounds.Top;
				Right = WorldBounds.Left;
				Top = WorldBounds.Bottom;

				foreach (var point in list)
				{
					Left = Math.Min(Left, point.X);
					Bottom = Math.Min(Bottom, point.Y);
					Right = Math.Max(Right, point.X);
					Top = Math.Max(Top, point.Y);
				}
			}
		}

		public static bool operator ==(Rectangle rect1, Rectangle rect2)
		{
			return rect1.Left == rect2.Left && rect1.Bottom == rect2.Bottom && rect1.Right == rect2.Right && rect1.Top == rect2.Top;
		}

		public static bool operator !=(Rectangle rect1, Rectangle rect2)
		{
			return rect1.Left != rect2.Left || rect1.Bottom != rect2.Bottom || rect1.Right != rect2.Right || rect1.Top != rect2.Top;
		}

		/// <summary>
		/// Retrieves a random (inclusive) point in this rectangle.
		/// </summary>
		public Point GetRandomPoint()
		{
			return new Point(GetRandomReal(Left, Right), GetRandomReal(Bottom, Top));
		}

		/// <summary>
		/// Returns whether the given coordinates are located within this Rectangle.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public bool Contains(float x, float y)
		{
			return Left <= x && Bottom <= y && Right >= x && Top >= y;
		}

		/// <summary>
		/// Returns whether the given Point is located within this Rectangle.
		/// </summary>
		/// <param name="point"></param>
		/// <returns></returns>
		public bool Contains(Point point)
		{
			return Contains(point.X, point.Y);
		}

		/// <summary>
		/// Returns whether the given Rectangle is located fully within this Rectangle.
		/// </summary>
		public bool Contains(Rectangle rect)
		{
			return Left <= rect.Left && Bottom <= rect.Bottom && Right >= rect.Right && Top >= rect.Top;
		}

		/// <summary>
		/// Returns whether this Rectangle has any point where it touches or overlaps with the given Rectangle.
		/// </summary>
		public bool IntersectsWith(Rectangle rect)
		{
			return rect.Left <= Right &&
				rect.Right >= Left &&
				rect.Top <= Bottom &&
				rect.Bottom >= Top;
		}

		/// <summary>
		/// Returns a new Rectangle that represents the union of the two given Rectangles. Meaning, a new square that can encompass both.
		/// </summary>
		public static Rectangle Union(Rectangle rect1, Rectangle rect2)
		{
			return new Rectangle(
				Math.Min(rect1.Left, rect2.Left),
				Math.Min(rect1.Bottom, rect2.Bottom),
				Math.Max(rect1.Right, rect2.Right),
				Math.Max(rect1.Top, rect2.Top)
			);
		}

		/// <summary>
		/// Returns a new Rectangle that represents the intersection of the two given Rectangles. Meaning, the area in which they overlap.
		/// </summary>
		public static Rectangle Intersect(Rectangle rect1, Rectangle rect2)
		{
			return new Rectangle(
				Math.Max(rect1.Left, rect2.Left),
				Math.Max(rect1.Bottom, rect2.Bottom),
				Math.Min(rect1.Right, rect2.Right),
				Math.Min(rect1.Top, rect2.Top)
			);
		}

		/// <summary>
		/// Returns a new Rectangle that is offset by the given coordinates, using <see cref="TopLeft"/> as the origin for movement.
		/// </summary>
		public static Rectangle Offset(Rectangle rect, float x, float y)
		{
			return new Rectangle(
				rect.Left + x,
				rect.Bottom + y,
				rect.Right + x,
				rect.Top + y
			);
		}

		/// <summary>
		/// Returns a new Rectangle that is inflated by the given width and height in all directions.
		/// <para>The increase on each side is half the width/height.</para>
		/// </summary>
		public static Rectangle Inflate(Rectangle rect, float width, float height)
		{
			return new Rectangle(
				rect.Left - (width / 2),
				rect.Bottom - (height / 2),
				rect.Right + (width / 2),
				rect.Top + (height / 2)
			);
		}

		/// <summary>
		/// Returns a new Rectangle that is scaled up by the given scaling factors.
		/// </summary>
		public static Rectangle Scale(Rectangle rect, float scaleWidth, float scaleHeight)
		{
			return Inflate(rect, rect.Width * scaleWidth / 2, rect.Width * scaleHeight / 2);
		}

		/// <summary>
		/// Must be called in order to safely garbage collect <see cref="Rect"/> and <see cref="Region"/>.
		/// </summary>
		public void Dispose()
		{
			if (this.rect != null)
			{
				RemoveRect(this.rect);
				this.rect = null;
			}

			if (this.region != null)
			{
				RemoveRegion(this.region);
				this.region = null;
			}
		}

		public override bool Equals(object obj)
		{
			return obj is Rectangle rect &&
				Left == rect.Left &&
				Bottom == rect.Bottom &&
				Right == rect.Right &&
				Top == rect.Top;
		}

		public override int GetHashCode()
		{
			var hashCode = -481391125;
			hashCode = (hashCode * -1521134295) + Left.GetHashCode();
			hashCode = (hashCode * -1521134295) + Bottom.GetHashCode();
			hashCode = (hashCode * -1521134295) + Right.GetHashCode();
			hashCode = (hashCode * -1521134295) + Top.GetHashCode();
			return hashCode;
		}
	}
}
