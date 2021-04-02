namespace WCSharp.Lua
{
	/// <summary>
	/// Exposes some of the os methods within Lua
	/// </summary>
	public static class Os
	{
		/// <summary>
		/// Returns the time in seconds that Warcraft III has been running.
		/// <para>WARNING! This is different for each player and if you don't know what you are doing you may trigger a desync!</para>
		/// </summary>
		public static float Clock()
		{
			var value = 0;
#if __CSharpLua__
/*[[
value = os.clock()
]]*/
#endif
			return value;
		}

		/// <summary>
		/// Returns the current time in seconds since January 1st, 1970, 00:00:00 UTC.
		/// <para>WARNING! This is different for each player and if you don't know what you are doing you may trigger a desync!</para>
		/// </summary>
		public static int Time()
		{
			var value = 0;
#if __CSharpLua__
/*[[
value = os.time()
]]*/
#endif
			return value;
		}

		/// <summary>
		/// Formats the given time in seconds according to the given format.
		/// <para>For more information regarding the format, see <see href="http://www.cplusplus.com/reference/ctime/strftime/"/>.</para>
		/// </summary>
		/// <param name="format">The format to print the date in.</param>
		/// <param name="time">The number of seconds since January 1st, 1970, 00:00:00.</param>
		/// <returns></returns>
		public static string Date(string format, int time)
		{
			object value = null;
#if __CSharpLua__
/*[[
value = os.date(format)
]]*/
#endif
			if (value is string @string)
			{
				return @string;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// Retrieves the current time as a <see cref="LuaTable"/>.
		/// <para>For more information, see <see href="http://lua-users.org/wiki/OsLibraryTutorial"/>.</para>
		/// <para>WARNING! This is different for each player and if you don't know what you are doing you may trigger a desync!</para>
		/// </summary>
		public static LuaTable Date(bool utc = false)
		{
			object value = null;
			var format = utc ? "!*t" : "*t";
#if __CSharpLua__
/*[[
value = os.date(format)
]]*/
#endif
			return new LuaTable(value);
		}
	}
}
