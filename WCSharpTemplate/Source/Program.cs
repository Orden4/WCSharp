using System;
using WCSharp.Api;
using WCSharp.Events;
using WCSharp.Shared;
using WCSharp.Sync;
using static WCSharp.Api.Common;

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
				Delay.EnableDebug();
#endif

				// Both styles compile to the same output
				// WCSharp style, left footman
				var u = unit.Create(player.Create(0), FourCC("hfoo"), -200, 0);
				u.MaxMana = 250;
				u.MaxLife += 700;

				// War3Api style, right footman
				u = CreateUnit(Player(0), FourCC("hfoo"), 200, 0, 270);
				BlzSetUnitMaxMana(u, 250);
				BlzSetUnitMaxHP(u, BlzGetUnitMaxHP(u) + 700);

				Console.WriteLine("Hello, Azeroth.");
			}
			catch (Exception ex)
			{
				DisplayTextToPlayer(GetLocalPlayer(), 0, 0, ex.Message);
			}
		}
	}
}
