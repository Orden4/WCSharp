using System;

namespace WCSharp.DateTime
{
	/// <summary>
	/// Represents a duration of time, with a precision in seconds.
	/// </summary>
	public class WcTimeSpan : IComparable, IComparable<WcTimeSpan>, IEquatable<WcTimeSpan>
	{
		/// <summary>
		/// The number of seconds in a minute.
		/// </summary>
		public const int SECONDS_PER_MINUTE = 60;
		/// <summary>
		/// The number of seconds in an hour.
		/// </summary>
		public const int SECONDS_PER_HOUR = 3600;
		/// <summary>
		/// The number of seconds in a day.
		/// </summary>
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
		/// Returns the time that Warcraft III has been running for the current player.
		/// <para>WARNING: Be careful when using this! You may trigger a desync!</para>
		/// </summary>
		public static WcTimeSpan LocalPlaytime => new WcTimeSpan((int)Os.Clock());

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

		/// <summary>
		/// Returns a new <see cref="WcTimeSpan"/> that is the negation of the time represented by <paramref name="a"/>.
		/// </summary>
		public static WcTimeSpan operator -(WcTimeSpan a)
		{
			return new WcTimeSpan(-a.seconds);
		}

		/// <summary>
		/// Returns a new <see cref="WcTimeSpan"/> that is equal to <paramref name="a"/> minus <paramref name="b"/>.
		/// </summary>
		public static WcTimeSpan operator -(WcTimeSpan a, WcTimeSpan b)
		{
			return new WcTimeSpan(a.seconds - b.seconds);
		}

		/// <summary>
		/// Since no changes are required, simply returns the given <see cref="WcTimeSpan"/>.
		/// </summary>
		public static WcTimeSpan operator +(WcTimeSpan a)
		{
			return a;
		}

		/// <summary>
		/// Returns a new <see cref="WcTimeSpan"/> that is equal to <paramref name="a"/> plus <paramref name="b"/>.
		/// </summary>
		public static WcTimeSpan operator +(WcTimeSpan a, WcTimeSpan b)
		{
			return new WcTimeSpan(a.seconds + b.seconds);
		}

		/// <summary>
		/// Returns true if <paramref name="a"/> represents an equally long time as <paramref name="b"/>.
		/// </summary>
		public static bool operator ==(WcTimeSpan a, WcTimeSpan b)
		{
			return a.seconds == b.seconds;
		}

		/// Returns true if <paramref name="a"/> does not represent an equally long time as <paramref name="b"/>.
		public static bool operator !=(WcTimeSpan a, WcTimeSpan b)
		{
			return a.seconds != b.seconds;
		}

		/// Returns true if <paramref name="a"/> represents a shorter time than <paramref name="b"/>.
		public static bool operator <(WcTimeSpan a, WcTimeSpan b)
		{
			return a.seconds < b.seconds;
		}

		/// Returns true if <paramref name="a"/> represents a shorter or equivalent time as <paramref name="b"/>.
		public static bool operator <=(WcTimeSpan a, WcTimeSpan b)
		{
			return a.seconds <= b.seconds;
		}

		/// Returns true if <paramref name="a"/> represents a longer time than <paramref name="b"/>.
		public static bool operator >(WcTimeSpan a, WcTimeSpan b)
		{
			return a.seconds > b.seconds;
		}

		/// Returns true if <paramref name="a"/> represents a longer or equivalent time as <paramref name="b"/>.
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

		/// <inheritdoc/>
		public int CompareTo(object obj)
		{
			return obj is WcDateTime other
				? CompareTo(other)
				: throw new ArgumentException("Cannot compare WcTimeSpan to non-WcTimeSpan object");
		}

		/// <inheritdoc/>
		public int CompareTo(WcTimeSpan other)
		{
			return this.seconds.CompareTo(other.seconds);
		}

		/// <inheritdoc/>
		public bool Equals(WcTimeSpan other)
		{
			return this.seconds == other.seconds;
		}

		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return obj is WcTimeSpan other && this.seconds == other.seconds;
		}

		/// <inheritdoc/>
		public override int GetHashCode()
		{
			return this.seconds;
		}

		/// <summary>
		/// Outputs this <see cref="WcTimeSpan"/> in the standard format of "d:hh:mm:ss" or "hh:mm:ss" if less than 1 day.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Days > 0
				? ToString("d:hh:mm:ss")
				: ToString("hh:mm:ss");
		}

		/// <summary>
		/// Returns a string representation using the given format.
		/// <para>See the wiki for more information on the format specification.</para>
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

		/// <summary>
		/// Attempts to parse the given string as the number of seconds.
		/// </summary>
		/// <returns>Null if <paramref name="string"/> is not a valid integer.</returns>
		public static WcTimeSpan Deserialize(string @string)
		{
			if (int.TryParse(@string, out var seconds))
			{
				return new WcTimeSpan(seconds);
			}

			return null;
		}

		/// <summary>
		/// Returns a string representing the number of seconds contained in <paramref name="wcTimeSpan"/>.
		/// </summary>
		public static string Serialize(WcTimeSpan wcTimeSpan)
		{
			return wcTimeSpan.seconds.ToString();
		}
	}
}
