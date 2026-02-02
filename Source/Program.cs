using System;
using Source.Missiles;
using WCSharp.Api;
using WCSharp.Events;
using WCSharp.Missiles;
using WCSharp.Shared;
using WCSharp.Sync;
using WCSharp.Timers;
using static WCSharp.Api.Common;

namespace Source
{
	public static class Program
	{
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
			PlayerUnitEvents.EnableDebug();
			SyncSystem.EnableDebug();
			Delay.EnableDebug();
			TimerSystem.EnableDebug();

			TimerSystem.SetTickInterval(1f / 64);
			MissileSystem.SetTickInterval(1f / 64);

			var t = timer.Create();
			t.Start(5f, true, () =>
			{
				var interval = TimerSystem.TickInterval > 0 ? 0 : TimerSystem.DEFAULT_TICK_INTERVAL;
				TimerSystem.SetTickInterval(interval);
				Console.WriteLine(interval);
			});

			var hfoo = unit.Create(player.Create(0), FourCC("hfoo"), 0, 0, 270);

			var trials = 1000;
			var sw = Os.Clock();

			sw = Os.Clock();
			for (var i = 0; i < trials; i++)
			{
			}
			Console.WriteLine($"Baseline: {Os.Clock() - sw}");

			Arcing.Initialise();
			Curving.Initialise();
			Homing.Initialise();
			Momentum.Initialise();
			Orbital.Initialise();
			Straight.Initialise();
		}
	}

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	internal static class Os
	{
		/// @CSharpLua.Template = "os.date({0})"
		public static extern object Date(string format);

		/// @CSharpLua.Template = "os.date({0}, {1})"
		public static extern string Date(string format, int seconds);

		/// @CSharpLua.Template = "os.clock()"
		public static extern float Clock();
	}
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
}
