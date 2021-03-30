using System;
using System.Collections.Generic;
using WCSharp.Events;

namespace WCSharp.DateTime
{
	/// <summary>
	/// Represents an instant in time, with a precision in seconds.
	/// </summary>
	public class WcDateTime : IComparable, IComparable<WcDateTime>, IEquatable<WcDateTime>
	{
		#region Standard
		private enum DatePart
		{
			Year,
			DayOfYear,
			Month,
			Day
		}

		internal readonly int seconds;

		/// <summary>
		/// Returns the number of whole seconds in this <see cref="WcDateTime"/> (as a timestamp).
		/// </summary>
		public int Second => this.seconds % WcTimeSpan.SECONDS_PER_MINUTE;
		/// <summary>
		/// Returns the number of whole minutes in this <see cref="WcDateTime"/> (as a timestamp).
		/// </summary>
		public int Minute => this.seconds % WcTimeSpan.SECONDS_PER_HOUR / WcTimeSpan.SECONDS_PER_MINUTE;
		/// <summary>
		/// Returns the number of whole hours in this <see cref="WcDateTime"/> (as a timestamp).
		/// </summary>
		public int Hour => this.seconds % WcTimeSpan.SECONDS_PER_DAY / WcTimeSpan.SECONDS_PER_HOUR;
		/// <summary>
		/// Returns the number of whole days in this <see cref="WcDateTime"/> (as a timestamp).
		/// </summary>
		public int Day => GetDatePart(DatePart.Day);
		/// <summary>
		/// Returns the number of whole months in this <see cref="WcDateTime"/> (as a timestamp).
		/// </summary>
		public int Month => GetDatePart(DatePart.Month);
		/// <summary>
		/// Returns the number of whole years in this <see cref="WcDateTime"/> (as a timestamp).
		/// </summary>
		public int Year => GetDatePart(DatePart.Year);
		/// <summary>
		/// Returns the current day of the week.
		/// </summary>
		public DayOfWeek DayOfWeek
		{
			get
			{
				var dayOfWeek = this.seconds / WcTimeSpan.SECONDS_PER_DAY % 7;
				if (dayOfWeek < 0)
				{
					dayOfWeek = 7 + dayOfWeek;
				}
				return dayOfWeek switch
				{
					0 => DayOfWeek.Thursday,
					1 => DayOfWeek.Friday,
					2 => DayOfWeek.Saturday,
					3 => DayOfWeek.Sunday,
					4 => DayOfWeek.Monday,
					5 => DayOfWeek.Tuesday,
					6 => DayOfWeek.Wednesday,
					_ => throw new NotImplementedException(),
				};
			}
		}
		/// <summary>
		/// Returns the current day of the year.
		/// </summary>
		public int DayOfYear => GetDatePart(DatePart.DayOfYear);
		/// <summary>
		/// Returns the current date (hour/minutes/seconds removed).
		/// </summary>
		public WcDateTime Date
		{
			get
			{
				GetDatePart(out var year, out var month, out var day);
				return new WcDateTime(year, month, day);
			}
		}
		/// <summary>
		/// Returns a <see cref="WcTimeSpan"/> representing the hour, minute and second of the day.
		/// </summary>
		public WcTimeSpan TimeOfDay => new WcTimeSpan(Hour, Minute, Second);

		/// <summary>
		/// Returns the zero <see cref="WcDateTime"/> value, equivalent to January 1st, 1970, 00:00:00.
		/// </summary>
		public static WcDateTime Zero => new WcDateTime(0);
		/// <summary>
		/// Returns the minimum <see cref="WcDateTime"/> value, equivalent to December 13th, 1901, 20:45:52.
		/// </summary>
		public static WcDateTime MinValue => new WcDateTime(int.MinValue);
		/// <summary>
		/// Returns the maximum <see cref="WcDateTime"/> value, equivalent to January 19, 2038, 03:14:07.
		/// </summary>
		public static WcDateTime MaxValue => new WcDateTime(int.MaxValue);

		private const int DAYS_PER_4_YEARS = (365 * 4) + 1;
		private static readonly int[] daysToMonth366 = new[] { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334, 365 };
		private static readonly int[] daysToMonth365 = new[] { 0, 31, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335, 366 };

		/// <summary>
		/// Creates a new <see cref="WcDateTime"/> with the given number of seconds since January 1st, 1970, 00:00:00.
		/// </summary>
		/// <param name="seconds"></param>
		public WcDateTime(int seconds)
		{
			this.seconds = seconds;
		}

		/// <summary>
		/// Creates a new <see cref="WcDateTime"/> with the given year, month and day.
		/// <para>The given date must be between January 1st, 1970, 00:00:00 and January 19, 2038, 03:14:07.</para>
		/// </summary>
		/// <param name="year">The year. Must be between 1970 and 2038.</param>
		/// <param name="month">The month of the year. Must be between 1 and 12.</param>
		/// <param name="day">The day of the month.</param>
		public WcDateTime(int year, int month, int day) : this(year, month, day, 0, 0, 0)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="year">The year. Must be between 1970 and 2038.</param>
		/// <param name="month">The month of the year. Must be between 1 and 12.</param>
		/// <param name="day">The day of the month.</param>
		/// <param name="hour">The hour of the day. Must be between 0 and 23.</param>
		/// <param name="minutes">The minutes of the hour. Must be between 0 and 59.</param>
		/// <param name="seconds">The seconds of the minute. Must be between 0 and 59.</param>
		public WcDateTime(int year, int month, int day, int hour, int minutes, int seconds)
		{
			if (year < 1970 || year > 2038)
				throw new ArgumentException("WcDateTime before 1970 or after 2038 are not supported.");
			if (month < 1 || month > 12)
				throw new ArgumentException("Month cannot be less than 1 or greater than 12.");
			if (hour < 0 || hour > 23)
				throw new ArgumentException("Hour cannot be less than 0 or greater than 23.");
			if (minutes < 0 || minutes > 59)
				throw new ArgumentException("Minutes cannot be less than 0 or greater than 59.");
			if (seconds < 0 || seconds > 59)
				throw new ArgumentException("Seconds cannot be less than 0 or greater than 59.");

			for (var i = 1970; i < year; i++)
			{
				if (i % 4 == 0)
				{
					this.seconds += WcTimeSpan.SECONDS_PER_DAY * 366;
				}
				else
				{
					this.seconds += WcTimeSpan.SECONDS_PER_DAY * 365;
				}
			}

			var months = year % 4 == 0 ? daysToMonth366 : daysToMonth365;
			if (day < 0 || day > months[month] - months[month - 1])
				throw new ArgumentException($"Days cannot be less than 0 or greater the number of days in the current month ({months[month] - months[month - 1]}).");

			this.seconds +=
				(months[month - 1] * WcTimeSpan.SECONDS_PER_DAY) +
				((day - 1) * WcTimeSpan.SECONDS_PER_DAY) +
				(hour * WcTimeSpan.SECONDS_PER_HOUR) +
				(minutes * WcTimeSpan.SECONDS_PER_MINUTE) +
				seconds;
		}

		public static WcDateTime operator +(WcDateTime a, WcTimeSpan b)
		{
			return new WcDateTime(a.seconds - b.seconds);
		}

		public static WcDateTime operator -(WcDateTime a, WcTimeSpan b)
		{
			return new WcDateTime(a.seconds - b.seconds);
		}

		public static WcTimeSpan operator -(WcDateTime a, WcDateTime b)
		{
			return new WcTimeSpan(a.seconds - b.seconds);
		}

		public static bool operator ==(WcDateTime a, WcDateTime b)
		{
			return a.seconds == b.seconds;
		}

		public static bool operator !=(WcDateTime a, WcDateTime b)
		{
			return a.seconds != b.seconds;
		}

		public static bool operator <(WcDateTime a, WcDateTime b)
		{
			return a.seconds < b.seconds;
		}

		public static bool operator <=(WcDateTime a, WcDateTime b)
		{
			return a.seconds <= b.seconds;
		}

		public static bool operator >(WcDateTime a, WcDateTime b)
		{
			return a.seconds > b.seconds;
		}

		public static bool operator >=(WcDateTime a, WcDateTime b)
		{
			return a.seconds >= b.seconds;
		}

		private int GetDatePart(DatePart part)
		{
			// n = number of days since 1970/1/1
			var n = this.seconds / WcTimeSpan.SECONDS_PER_DAY;
			// y4 = number of whole 4-year periods since 1970/1/1
			var y4 = n / DAYS_PER_4_YEARS;
			// n = day in current 4-year period
			n -= y4 * DAYS_PER_4_YEARS;
			// y1 = number of whole years within 4-year period
			var y1 = n == 1095
				? 2
				: n / 365;
			// Can be 4 if last day of last year
			y1 = Math.Min(y1, 3);

			// compute year
			var year = 1970 + (y4 * 4) + y1;
			if (part == DatePart.Year)
			{
				return year;
			}

			// n = day number within year
			n -= n >= 1096
				? (y1 * 365) + 1
				: y1 * 365;
			if (part == DatePart.DayOfYear)
			{
				return n;
			}

			// Get days to months depending on leap year
			var days = y1 == 2 ? daysToMonth366 : daysToMonth365;
			// All months have less than 32 days, so n >> 5 is a good conservative estimate for the month
			var month = (n >> 5) + 1;
			while (n >= days[month])
			{
				month++;
			}
			return part == DatePart.Month
				? month
				: n - days[month - 1] + 1;
		}

		private void GetDatePart(out int year, out int month, out int day)
		{
			// n = number of days since 1970/1/1
			var n = this.seconds / WcTimeSpan.SECONDS_PER_DAY;
			// y4 = number of whole 4-year periods since 1970/1/1
			var y4 = n / DAYS_PER_4_YEARS;
			// n = day in current 4-year period
			n -= y4 * DAYS_PER_4_YEARS;
			// y1 = number of whole years within 4-year period
			var y1 = n == 1095
				? 2
				: n / 365;
			// Can be 4 if last day of last year
			y1 = Math.Min(y1, 3);

			// compute year
			year = 1970 + (y4 * 4) + y1;

			// n = day number within year
			n -= n >= 1096
				? (y1 * 365) + 1
				: y1 * 365;
			// Get days to months depending on leap year
			var days = y1 == 2 ? daysToMonth366 : daysToMonth365;
			// All months have less than 32 days, so n >> 5 is a good conservative estimate for the month
			month = (n >> 5) + 1;
			//Util.Debug(month);
			while (n >= days[month])
			{
				month++;
			}
			day = n - days[month - 1] + 1;
		}

		/// <summary>
		/// Returns a new <see cref="WcDateTime"/> that is an amount of time indicated by <paramref name="value"/> into the future.
		/// </summary>
		/// <param name="value">The amount of time to move this instance into the future.</param>
		public WcDateTime Add(WcTimeSpan value)
		{
			return new WcDateTime(this.seconds + value.seconds);
		}

		/// <summary>
		/// Returns a new <see cref="WcDateTime"/> that is an amount of time indicated by <paramref name="value"/> into the past.
		/// </summary>
		/// <param name="value">The amount of time to move this instance into the past.</param>
		public WcTimeSpan Subtract(WcDateTime value)
		{
			return this - value;
		}

		/// <summary>
		/// Returns a new <see cref="WcDateTime"/> that is a given number of seconds into the future.
		/// </summary>
		/// <param name="value">The amount of seconds to move this instance into the future.</param>
		public WcDateTime AddSeconds(int seconds)
		{
			return new WcDateTime(this.seconds + seconds);
		}

		/// <summary>
		/// Returns a new <see cref="WcDateTime"/> that is a given number of minutes into the future.
		/// </summary>
		/// <param name="value">The amount of minutes to move this instance into the future.</param>
		public WcDateTime AddMinutes(int minutes)
		{
			return new WcDateTime(this.seconds + (minutes * WcTimeSpan.SECONDS_PER_MINUTE));
		}

		/// <summary>
		/// Returns a new <see cref="WcDateTime"/> that is a given number of hours into the future.
		/// </summary>
		/// <param name="value">The amount of hours to move this instance into the future.</param>
		public WcDateTime AddHours(int hours)
		{
			return new WcDateTime(this.seconds + (hours * WcTimeSpan.SECONDS_PER_HOUR));
		}

		/// <summary>
		/// Returns a new <see cref="WcDateTime"/> that is a given number of days into the future.
		/// </summary>
		/// <param name="value">The amount of days to move this instance into the future.</param>
		public WcDateTime AddDays(int days)
		{
			return new WcDateTime(this.seconds + (days * WcTimeSpan.SECONDS_PER_DAY));
		}

		/// <summary>
		/// Returns a new <see cref="WcDateTime"/> that is a given number of months into the future.
		/// </summary>
		/// <param name="value">The amount of months to move this instance into the future.</param>
		public WcDateTime AddMonths(int months)
		{
			GetDatePart(out var year, out var month, out var day);
			year += (month + months) / 12;
			month = ((month - 1 + months) % 12) + 1;
			var daysPerMonth = year % 4 == 0 ? daysToMonth366 : daysToMonth365;
			day = Math.Min(daysPerMonth[month], day);

			return new WcDateTime(year, month, day, Hour, Minute, Second);
		}

		/// <summary>
		/// Returns a new <see cref="WcDateTime"/> that is a given number of years into the future.
		/// </summary>
		/// <param name="value">The amount of years to move this instance into the future.</param>
		public WcDateTime AddYears(int years)
		{
			return AddMonths(years * 12);
		}

		public int CompareTo(object obj)
		{
			return obj is WcDateTime other
				? CompareTo(other)
				: throw new ArgumentException("Cannot compare WcDateTime to non-WcDateTime object");
		}

		public int CompareTo(WcDateTime other)
		{
			return this.seconds.CompareTo(other.seconds);
		}

		public bool Equals(WcDateTime other)
		{
			return this.seconds == other.seconds;
		}

		public override bool Equals(object obj)
		{
			return obj is WcDateTime other && this.seconds == other.seconds;
		}

		public override int GetHashCode()
		{
			return this.seconds;
		}

		public override string ToString()
		{
			return ToString("yyyy-MM-dd HH:mm:ss");
		}

		/// <summary>
		/// Returns a string representation using the given format.
		/// </summary>
		/// <param name="format">The format to print the string in.</param>
		public string ToString(string format)
		{
			GetDatePart(out var year, out var month, out var day);

			// Lord, forgive me, for I have sinned.
			if (format.Contains("yyyyy"))
				format = format.Replace("yyyyy", ZeroPad(year % 100000, 5));
			else if (format.Contains("yyyy"))
				format = format.Replace("yyyy", ZeroPad(year % 10000, 4));
			else if (format.Contains("yyy"))
				format = format.Replace("yyy", ZeroPad(year % 1000, 3));
			else if (format.Contains("yy"))
				format = format.Replace("yy", ZeroPad(year % 100, 2));
			else if (format.Contains("y"))
				format = format.Replace("y", (year % 100).ToString());

			if (format.Contains("MM"))
				format = format.Replace("MM", ZeroPad(Month, 2));
			else if (format.Contains("M"))
				format = format.Replace("M", Month.ToString());

			if (format.Contains("dd"))
				format = format.Replace("dd", ZeroPad(day, 2));
			else if (format.Contains("d"))
				format = format.Replace("d", day.ToString());

			if (format.Contains("hh"))
				format = format.Replace("hh", ZeroPad((Hour + 1) % 12, 2));
			else if (format.Contains("h"))
				format = format.Replace("h", ((Hour + 1) % 12).ToString());
			else if (format.Contains("HH"))
				format = format.Replace("HH", ZeroPad(Hour, 2));
			else if (format.Contains("H"))
				format = format.Replace("H", Hour.ToString());

			if (format.Contains("mm"))
				format = format.Replace("mm", ZeroPad(Minute, 2));
			else if (format.Contains("m"))
				format = format.Replace("m", Minute.ToString());

			if (format.Contains("ss"))
				format = format.Replace("ss", ZeroPad(Second, 2));
			else if (format.Contains("s"))
				format = format.Replace("s", Second.ToString());

			if (format.Contains("t"))
				format = format.Replace("t", Hour >= 12 ? "P" : "A");
			else if (format.Contains("tt"))
				format = format.Replace("tt", Hour >= 12 ? "PM" : "AM");

			return format;
		}

		internal static string ZeroPad(int number, int length)
		{
			var str = number.ToString();
			while (str.Length < length)
			{
				str = "0" + str;
			}
			return str;
		}

		public static WcDateTime Deserialize(string @string)
		{
			if (int.TryParse(@string, out var seconds))
			{
				return new WcDateTime(seconds);
			}

			return null;
		}

		public static string Serialize(WcDateTime wcDateTime)
		{
			return wcDateTime.seconds.ToString();
		}
		#endregion

		#region Sync service
		/// <summary>
		/// The time for the local player.
		/// <para>WARNING: Be careful when using this! You may trigger a desync!</para>
		/// <para>For a danger-free timestamp, use <see cref="GetCurrentTime(Action{WcDateTime}, DateTimeSyncMethod)"/>.</para>
		/// </summary>
		public static WcDateTime LocalTime
		{
			get
			{
				var seconds = 0;
#if __CSharpLua__
	/*[[
	seconds = os.time()
	]]*/
#endif
				return new WcDateTime(seconds);
			}
		}

		private static int baseTime = -1;
		private static readonly Dictionary<DateTimeSyncMethod, int> offsetByMethod = new Dictionary<DateTimeSyncMethod, int>();

		/// <summary>
		/// This will produce a synchronised time for all players. The given action will be called once a synchronised time has been determined.
		/// <para>This is done by individually querying the time, synchronizing this data across all players, and then deciding an overall time.</para>
		/// </summary>
		/// <param name="action">This action will be called when the synchronised time is determined.</param>
		/// <param name="method">The method it should use for determining the synchronised time.</param>
		public static void GetCurrentTime(Action<WcDateTime> action, DateTimeSyncMethod method = DateTimeSyncMethod.BestFit)
		{
			if (offsetByMethod.TryGetValue(method, out var offset))
			{
				action?.Invoke(new WcDateTime(baseTime + offset));
			}
			else
			{
				var system = new DateTimeSystem(method, action);
				system.Run();
			}
		}

		/// <summary>
		/// This will attempt to immediately return a synchronised time for all players, if it has already been calculated.
		/// If it has not been calculated, this will return false.
		/// <para>If it has not been calculated, will start a calculation procedure behind the scenes, but this will take some time.</para>
		/// </summary>
		/// <param name="wcDateTime">The synchronised time, if available.</param>
		/// <param name="method">The method it should use for determining the synchronised time.</param>
		/// <returns>Whether the retrieval was successful.</returns>
		public static bool TryGetCurrentTime(out WcDateTime wcDateTime, DateTimeSyncMethod method = DateTimeSyncMethod.BestFit)
		{
			if (offsetByMethod.TryGetValue(method, out var offset))
			{
				wcDateTime = new WcDateTime(baseTime + offset);
				return true;
			}
			else
			{
				wcDateTime = null;
				var system = new DateTimeSystem(method);
				system.Run();
				return false;
			}
		}

		internal static void StoreSynchronisedTime(int seconds, DateTimeSyncMethod method)
		{
			if (!offsetByMethod.ContainsKey(method))
			{
				if (baseTime < 0)
				{
					baseTime = seconds;
					PeriodicEvents.AddPeriodicEvent(() =>
					{
						baseTime++;
						return true;
					}, 1f);
				}

				offsetByMethod.Add(method, seconds - baseTime);
			}
		}
		#endregion
	}
}
