using System;

namespace WCSharp.Shared.Data
{
	/// <summary>
	/// Data class for a simple point coordinate.
	/// </summary>
	public class Point
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
			return point1.X == point2.X && point1.Y == point2.Y;
		}

		/// <summary>
		/// True if the X and Y coordinates of the two points do not match.
		/// </summary>
		public static bool operator !=(Point point1, Point point2)
		{
			return point1.X != point2.X || point1.Y != point2.Y;
		}

		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return obj is Point point &&
				   X == point.X &&
				   Y == point.Y;
		}

		/// <inheritdoc/>
		public override int GetHashCode()
		{
			return HashCode.Combine(X, Y);
		}
	}
}
