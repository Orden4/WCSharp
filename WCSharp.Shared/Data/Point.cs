using System;

namespace WCSharp.Shared.Data
{
	/// <summary>
	/// Data class for a simple point coordinate.
	/// </summary>
	public class Point : IEquatable<Point>
	{
		/// <summary>
		/// The X-coordinate of this point.
		/// </summary>
		public float X { get; set; }
		/// <summary>
		/// The Y-coordinate of this point.
		/// </summary>
		public float Y { get; set; }

		/// <summary>
		/// Creates a new point at the given X and Y cooridnates.
		/// </summary>
		public Point(float x, float y)
		{
			X = x;
			Y = y;
		}

		/// <summary>
		/// True if the X and Y coordinates of the two points match.
		/// </summary>
		public static bool operator ==(Point point1, Point point2)
		{
			return point1 is null ? point2 is null : point1.Equals(point2);
		}

		/// <summary>
		/// True if the X and Y coordinates of the two points do not match.
		/// </summary>
		public static bool operator !=(Point point1, Point point2)
		{
			return !(point1 == point2);
		}

		/// <inheritdoc/>
		public bool Equals(Point other)
		{
			return other is not null
				&& X == other.X
				&& Y == other.Y;
		}

		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return obj is Point point && Equals(point);
		}

		/// <inheritdoc/>
		public override int GetHashCode()
		{
			return HashCode.Combine(X, Y);
		}
	}
}
