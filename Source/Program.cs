using System;
using System.Collections.Generic;
using Source.Missiles;
using WCSharp.SaveLoad;
using WCSharp.Utils;
using static War3Api.Common;

namespace Source
{
	public static class Program
	{
		public static void Main(string[] args)
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
				//SET THESE IF YOU USE THE SAVE / LOAD SYSTEM!
				// Otherwise, you may remove them.
				SaveSystem.Hash1 = 7;
				SaveSystem.Hash2 = 13;
				SaveSystem.SaveFolder = "";

				//				var a = @"{
				//""A"":true,
				//""B"":6,
				//""C"":6,
				//""D"":6,
				//""E"":6,
				//""F"":6,
				//""G"":6,
				//""H"":6,
				//""I"":6,
				//""J"":6,
				//""K"":6,
				//""L"":6,
				//""M"":6,
				//""N"":""Hello world"",
				//""O"":2,
				//""P"": {
				//	""Nest"":4
				//},
				//""Q"": [{""Nest"":1},{""Nest"":2},{""Nest"":4}],
				//""R"": {
				//	""56"":""Hello"",
				//	""-112"":""World"" 
				//}
				//}
				//";
				//				var b = JsonConvert.Deserialize<Test>(a);
				//				Console.WriteLine(b.P.Nest);
				//				foreach (var item in b.R)
				//				{
				//					Console.WriteLine($"{item.Key}-{item.Value}");
				//				}

				//				Console.WriteLine(JsonConvert.Serialize(b));
				//				SyncService.Subscribe<Test>(x =>
				//				{
				//					var @string = JsonConvert.Serialize(x);
				//					Console.WriteLine(@string);
				//				});
				//				SyncService.Send(b);

				Arcing.Initialise();
				Curving.Initialise();
				Homing.Initialise();
				Momentum.Initialise();
				Orbital.Initialise();
				Straight.Initialise();

				var trigger = CreateTrigger();
				TriggerAddAction(trigger, () => Console.WriteLine($"{BlzGetTriggerSyncData()}"));
				foreach (var player in Util.GetPlayersPresent())
				{
					BlzTriggerRegisterPlayerSyncEvent(trigger, player, "syncTest", false);
				}
				var timer = CreateTimer();
				TimerStart(timer, 5.0f, true, Sync);
			}
			catch (Exception ex)
			{
				DisplayTextToPlayer(GetLocalPlayer(), 0, 0, ex.Message);
			}
		}

		public static void Sync()
		{
			Console.WriteLine("=========================");
			Console.WriteLine("=========================");
			Console.WriteLine("=========================");
			var total = 0;
			for (var i = 0; i < 10; i++)
			{
				BlzSendSyncData("syncTest", $"Message {total++} from {GetPlayerId(GetLocalPlayer())}");
			}
		}
	}

	public class SerializeTest
	{
		public int PropertyGetSet { get; set; } = 1;
		public int Field = 3;

		protected int ProtectedProperty { get; set; } = 4;
		private int PrivateProperty { get; set; } = 5;
		internal int InternalProperty { get; set; } = 6;

		public Test Test { get; set; } = new Test();
	}

	public class Test
	{
		public bool A { get; set; }
		public byte B { get; set; }
		public sbyte C { get; set; }
		public char D { get; set; }
		public decimal E { get; set; }
		public double F { get; set; }
		public float G { get; set; }
		public int H { get; set; }
		public uint I { get; set; }
		public long J { get; set; }
		public ulong K { get; set; }
		public short L { get; set; }
		public ushort M { get; set; }
		public string N { get; set; }
		public TestEnum O { get; set; }
		public NestedClass P { get; set; }
		public List<NestedClass> Q { get; set; }
		public Dictionary<int, string> R { get; set; }
	}

	public class NestedClass
	{
		public int Nest { get; set; }
	}

	public enum TestEnum
	{
		Hello = 1,
		World = 2
	}
}
