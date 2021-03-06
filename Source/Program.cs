using System;
using WCSharp.SaveLoad;
using static War3Api.Common;

namespace Source
{
	public static class Program
	{
		private static timer timer;

		public static void Main(string[] args)
		{
			// Delay a little since some stuff can break otherwise
			timer = CreateTimer();
			TimerStart(timer, 0.01f, false, Start);
		}

		private static void Start()
		{
			DestroyTimer(timer);
			timer = null;

			try
			{
				// SET THESE IF YOU USE THE SAVE/LOAD SYSTEM!
				// Otherwise, you may remove them.
				SaveSystem.Hash1 = 7;
				SaveSystem.Hash2 = 13;
				SaveSystem.SaveFolder = "";
			}
			catch (Exception ex)
			{
				DisplayTextToPlayer(GetLocalPlayer(), 0, 0, ex.Message);
			}
		}
	}
}
