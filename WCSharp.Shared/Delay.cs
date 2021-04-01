using System;
using System.Collections.Generic;
using static War3Api.Common;

namespace WCSharp.Utils
{
	/// <summary>
	/// Basic helper class to create 0 second delays on executing actions.
	/// <para>This can be used to circumvent various issues, such as unit AI locking up if you give them a new order at the same time as they start an attack.</para>
	/// </summary>
	public static class Delay
	{
		private static readonly timer timer = CreateTimer();
		private static readonly List<Action> funcs = new List<Action>();

		/// <summary>
		/// <para>Will execute the given action after a 0 second delay, which translates to a single frame.</para>
		/// <para>This can be used to circumvent various issues, such as unit AI locking up if you give them a new order at the same time as they start an attack.</para>
		/// </summary>
		public static void Add(Action func)
		{
			if (funcs.Count == 0)
			{
				TimerStart(timer, 0.0f, false, ExecuteAll);
			}
			funcs.Add(func);
		}

		private static void ExecuteAll()
		{
			foreach (var func in funcs)
			{
				func();
			}
			funcs.Clear();
		}
	}
}
