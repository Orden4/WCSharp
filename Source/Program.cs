using System;
using Source.Missiles;
using WCSharp.Api;
using WCSharp.Events;
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
			var hfoo = unit.Create(player.Create(0), FourCC("hfoo"), 0, 0, 270);
			PlayerUnitEvents.Register(UnitEvent.Damaging, () => Console.WriteLine("!"), hfoo);

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
