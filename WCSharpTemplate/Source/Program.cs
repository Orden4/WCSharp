﻿using System;
using WCSharp.Events;
using WCSharp.Sync;
using static War3Api.Common;

namespace Source
{
	public static class Program
	{
		public static bool Debug { get; private set; } = false;

		public static void Main()
		{
			// Delay a little since some stuff can break otherwise
			var timer = CreateTimer();
			TimerStart(timer, 0.01f, false, () =>
			{
				DestroyTimer(timer);
				Start();
			});
		}

		private static void Start()
		{
			try
			{
#if DEBUG
				// This part of the code will only run if the map is compiled in Debug mode
				Debug = true;
				Console.WriteLine("This map is in debug mode. The map may not function as expected.");
				// By calling these methods, whenever these systems call external code (i.e. your code),
				// they will wrap the call in a try-catch and output any errors to the chat for easier debugging
				PeriodicEvents.EnableDebug();
				PlayerUnitEvents.EnableDebug();
				SyncSystem.EnableDebug();
#endif

				Console.WriteLine("Hello, Azeroth.");
			}
			catch (Exception ex)
			{
				DisplayTextToPlayer(GetLocalPlayer(), 0, 0, ex.Message);
			}
		}
	}
}
