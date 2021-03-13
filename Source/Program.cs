using System;
using Source.Missiles;
using WCSharp.Utils;
using static War3Api.Common;

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
			try
			{
				Util.Debug("Hello, world.");

				Arcing.Initialise();
				Curving.Initialise();
				Homing.Initialise();
				Momentum.Initialise();
				Orbital.Initialise();
				Straight.Initialise();
			}
			catch (Exception ex)
			{
				DisplayTextToPlayer(GetLocalPlayer(), 0, 0, ex.Message);
			}
		}
	}
}
