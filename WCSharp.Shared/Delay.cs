﻿using System;
using System.Collections.Generic;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.Shared
{
	/// <summary>
	/// Basic helper class to create 0 second delays on executing actions.
	/// <para>This can be used to circumvent various issues, such as unit AI locking up if you give them a new order at the same time as they start an attack.</para>
	/// </summary>
	public static class Delay
	{
		private static readonly timer timer = CreateTimer();
		private static readonly List<Action> funcs = new();
		private static Action execute = ExecuteAll;

		/// <summary>
		/// Call this method to automatically wrap your actions in a try/catch, so that exceptions that lead back to <see cref="Delay"/> will automatically output information.
		/// <para>It is recommended to use compilation time conditions to not call this on release mode.</para>
		/// </summary>
		public static void EnableDebug()
		{
			execute = ExecuteAllDebug;
		}

		/// <summary>
		/// <para>Will execute the given action after a 0 second delay, which translates to a single frame.</para>
		/// <para>This can be used to circumvent various issues, such as unit AI locking up if you give them a new order at the same time as they start an attack.</para>
		/// </summary>
		public static void Add(Action func)
		{
			if (funcs.Count == 0)
			{
				TimerStart(timer, 0.0f, false, execute);
			}
			funcs.Add(func);
		}

		private static void ExecuteAll()
		{
			for (var i = 0; i < funcs.Count; i++)
			{
				funcs[i]();
			}
			funcs.Clear();
		}

		private static void ExecuteAllDebug()
		{
			try
			{
				for (var i = 0; i < funcs.Count; i++)
				{
					funcs[i]();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
			funcs.Clear();
		}
	}
}
