namespace WCSharp.Utils.Data
{
	/// <summary>
	/// Data class for a simple point coordinate.
	/// </summary>
	public class Point
	{
		public float X { get; set; }
		public float Y { get; set; }

		public Point(float x, float y)
		{
			X = x;
			Y = y;
		}

		public static bool operator ==(Point point1, Point point2)
		{
			return point1.X == point2.X && point1.X == point2.X;
		}

		public static bool operator !=(Point point1, Point point2)
		{
			return point1.X != point2.X || point1.X != point2.X;
		}

		public override bool Equals(object obj)
		{
			return obj is Point point &&
				   X == point.X &&
				   Y == point.Y;
		}

		public override int GetHashCode()
		{
			var hashCode = 1861411795;
			hashCode = (hashCode * -1521134295) + X.GetHashCode();
			hashCode = (hashCode * -1521134295) + Y.GetHashCode();
			return hashCode;
		}
	}
}
