﻿using System;
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
				Console.WriteLine("Hello, Azeroth.");
			}
			catch (Exception ex)
			{
				DisplayTextToPlayer(GetLocalPlayer(), 0, 0, ex.Message);
			}
		}
	}
}
