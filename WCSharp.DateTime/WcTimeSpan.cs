using System;

namespace WCSharp.DateTime
{
	/// <summary>
	/// Represents a duration of time, with a precision in seconds.
	/// </summary>
	public class WcTimeSpan : IComparable, IComparable<WcTimeSpan>, IEquatable<WcTimeSpan>
	{
		public const int SECONDS_PER_MINUTE = 60;
		public const int SECONDS_PER_HOUR = 3600;
		public const int SECONDS_PER_DAY = 86400;

		internal readonly int seconds;

		/// <summary>
		/// The number of whole seconds in this <see cref="WcTimeSpan"/> (as a timestamp).
		/// </summary>
		public int Seconds => this.seconds % SECONDS_PER_MINUTE;
		/// <summary>
		/// The number of whole minutes in this <see cref="WcTimeSpan"/> (as a timestamp).
		/// </summary>
		public int Minutes => this.seconds % SECONDS_PER_HOUR / SECONDS_PER_MINUTE;
		/// <summary>
		/// The number of whole hours in this <see cref="WcTimeSpan"/> (as a timestamp).
		/// </summary>
		public int Hours => this.seconds % SECONDS_PER_DAY / SECONDS_PER_HOUR;
		/// <summary>
		/// The number of whole days in this <see cref="WcTimeSpan"/> (as a timestamp).
		/// </summary>
		public int Days => this.seconds / SECONDS_PER_DAY;

		/// <summary>
		/// The total length of this <see cref="WcTimeSpan"/> represented in seconds.
		/// </summary>
		public float TotalSeconds => this.seconds;
		/// <summary>
		/// The total length of this <see cref="WcTimeSpan"/> represented in minutes.
		/// </summary>
		public float TotalMinutes => (float)this.seconds / SECONDS_PER_MINUTE;
		/// <summary>
		/// The total length of this <see cref="WcTimeSpan"/> represented in hours.
		/// </summary>
		public float TotalHours => (float)this.seconds / SECONDS_PER_HOUR;
		/// <summary>
		/// The total length of this <see cref="WcTimeSpan"/> represented in days.
		/// </summary>
		public float TotalDays => (float)this.seconds / SECONDS_PER_DAY;

		/// <summary>
		/// A timespan with a duration of 0.
		/// </summary>
		public static WcTimeSpan Zero => new WcTimeSpan(0);
		/// <summary>
		/// A timespan with a duration of <see cref="int.MinValue"/> (in seconds).
		/// </summary>
		public static WcTimeSpan MinValue => new WcTimeSpan(int.MinValue);
		/// <summary>
		/// A timespan with a duration of <see cref="int.MaxValue"/> (in seconds).
		/// </summary>
		public static WcTimeSpan MaxValue => new WcTimeSpan(int.MaxValue);

		/// <summary>
		/// Creates a new <see cref="WcTimeSpan"/> instance with a duration of the given number of seconds.
		/// </summary>
		public WcTimeSpan(int seconds)
		{
			this.seconds = seconds;
		}

		/// <summary>
		/// Creates a new <see cref="WcTimeSpan"/> instance with a duration of the given number of hours, minutes and seconds.
		/// </summary>
		public WcTimeSpan(int hours, int minutes, int seconds)
		{
			this.seconds =
				(hours * SECONDS_PER_HOUR) +
				(minutes * SECONDS_PER_MINUTE) +
				seconds;
		}

		/// <summary>
		/// Creates a new <see cref="WcTimeSpan"/> instance with a duration of the given number of days, hours, minutes and seconds.
		/// </summary>
		public WcTimeSpan(int days, int hours, int minutes, int seconds)
		{
			this.seconds =
				(days * SECONDS_PER_DAY) +
				(hours * SECONDS_PER_HOUR) +
				(minutes * SECONDS_PER_MINUTE) +
				seconds;
		}

		public static WcTimeSpan operator -(WcTimeSpan a)
		{
			return new WcTimeSpan(-a.seconds);
		}

		public static WcTimeSpan operator -(WcTimeSpan a, WcTimeSpan b)
		{
			return new WcTimeSpan(a.seconds - b.seconds);
		}

		public static WcTimeSpan operator +(WcTimeSpan a)
		{
			return a;
		}

		public static WcTimeSpan operator +(WcTimeSpan a, WcTimeSpan b)
		{
			return new WcTimeSpan(a.seconds + b.seconds);
		}

		public static bool operator ==(WcTimeSpan a, WcTimeSpan b)
		{
			return a.seconds == b.seconds;
		}

		public static bool operator !=(WcTimeSpan a, WcTimeSpan b)
		{
			return a.seconds != b.seconds;
		}

		public static bool operator <(WcTimeSpan a, WcTimeSpan b)
		{
			return a.seconds < b.seconds;
		}

		public static bool operator <=(WcTimeSpan a, WcTimeSpan b)
		{
			return a.seconds <= b.seconds;
		}

		public static bool operator >(WcTimeSpan a, WcTimeSpan b)
		{
			return a.seconds > b.seconds;
		}

		public static bool operator >=(WcTimeSpan a, WcTimeSpan b)
		{
			return a.seconds >= b.seconds;
		}

		/// <summary>
		/// Returns a new <see cref="WcTimeSpan"/> whose value is the sum of this instance and the given object.
		/// </summary>
		public WcTimeSpan Add(WcTimeSpan value)
		{
			return new WcTimeSpan(this.seconds + value.seconds);
		}

		/// <summary>
		/// Returns a new <see cref="WcTimeSpan"/> whose value is the difference of this instance and the given object.
		/// </summary>
		public WcTimeSpan Subtract(WcTimeSpan value)
		{
			return new WcTimeSpan(this.seconds - value.seconds);
		}

		/// <summary>
		/// Returns a new <see cref="WcTimeSpan"/> whose value is the absolute value of this instance.
		/// </summary>
		public WcTimeSpan Duration()
		{
			return new WcTimeSpan(Math.Abs(this.seconds));
		}

		/// <summary>
		/// Returns a new <see cref="WcTimeSpan"/> whose value is the negated value of this instance.
		/// </summary>
		public WcTimeSpan Negate()
		{
			return new WcTimeSpan(-this.seconds);
		}

		public int CompareTo(object obj)
		{
			return obj is WcDateTime other
				? CompareTo(other)
				: throw new ArgumentException("Cannot compare WcTimeSpan to non-WcTimeSpan object");
		}

		public int CompareTo(WcTimeSpan other)
		{
			return this.seconds.CompareTo(other.seconds);
		}

		public bool Equals(WcTimeSpan other)
		{
			return this.seconds == other.seconds;
		}

		public override bool Equals(object obj)
		{
			return obj is WcTimeSpan other && this.seconds == other.seconds;
		}

		public override int GetHashCode()
		{
			return this.seconds;
		}

		public override string ToString()
		{
			return Days > 0
				? ToString("d:hh:mm:ss")
				: ToString("hh:mm:ss");
		}

		/// <summary>
		/// Returns a string representation using the given format.
		/// </summary>
		/// <param name="format">The format to print the string in.</param>
		public string ToString(string format)
		{
			// Lord, forgive me, for I have sinned.
			if (format.Contains("d"))
				format = format.Replace("d", Days.ToString());

			if (format.Contains("hh"))
				format = format.Replace("hh", WcDateTime.ZeroPad(Hours, 2));
			else if (format.Contains("h"))
				format = format.Replace("h", Hours.ToString());

			if (format.Contains("mm"))
				format = format.Replace("mm", WcDateTime.ZeroPad(Minutes, 2));
			else if (format.Contains("m"))
				format = format.Replace("m", Minutes.ToString());

			if (format.Contains("ss"))
				format = format.Replace("ss", WcDateTime.ZeroPad(Seconds, 2));
			else if (format.Contains("s"))
				format = format.Replace("s", Seconds.ToString());

			return format;
		}

		public static WcTimeSpan Deserialize(string @string)
		{
			if (int.TryParse(@string, out var seconds))
			{
				return new WcTimeSpan(seconds);
			}

			return null;
		}

		public static string Serialize(WcTimeSpan wcTimeSpan)
		{
			return wcTimeSpan.seconds.ToString();
		}
	}
}
