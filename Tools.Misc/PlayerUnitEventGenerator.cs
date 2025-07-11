using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Tools.DataClasses;

namespace Tools
{
	public class PlayerUnitEventGenerator
	{
		private readonly List<PlayerUnitEvent> playerUnitEvents;
		private readonly Dictionary<string, int> idByClass;

		private StreamWriter stream;

		private PlayerUnitEventGenerator(IEnumerable<PlayerUnitEvent> playerUnitEvents)
		{
			this.playerUnitEvents = playerUnitEvents.OrderBy(x => x.Class).ThenBy(x => x.Enum).ToList();
			this.idByClass = new Dictionary<string, int>();
		}

		public static void Run(string input, string output)
		{
			var playerUnitEvents = JsonConvert.DeserializeObject<List<PlayerUnitEvent>>(File.ReadAllText(input));
			new PlayerUnitEventGenerator(playerUnitEvents).Run(output);
		}

		private void Run(string output)
		{
			if (File.Exists(output))
				File.Delete(output);

			this.stream = new StreamWriter(File.OpenWrite(output));

			foreach (var eventsByClass in this.playerUnitEvents.GroupBy(x => x.Class))
			{
				this.stream.WriteLine($"========== {eventsByClass.Key} ==========");
				foreach (var playerUnitEvent in eventsByClass.OrderBy(x => x.Enum))
				{
					OutputEnum(playerUnitEvent);
				}
			}

			this.stream.WriteLine($"========== Native player unit event mapping ==========");
			foreach (var playerUnitEvent in this.playerUnitEvents)
			{
				OutputNativePlayerUnitEventMapping(playerUnitEvent);
			}

			this.stream.WriteLine($"========== Native unit event mapping ==========");
			foreach (var playerUnitEvent in this.playerUnitEvents)
			{
				OutputNativeUnitEventMapping(playerUnitEvent);
			}

			this.stream.WriteLine($"========== Func mapping ==========");
			foreach (var playerUnitEvent in this.playerUnitEvents)
			{
				OutputFuncMapping(playerUnitEvent);
			}

			this.stream.Dispose();
			this.stream = null;
		}

		private void OutputEnum(PlayerUnitEvent playerUnitEvent)
		{
			if (string.IsNullOrWhiteSpace(playerUnitEvent.PlayerUnitEventFunc))
				return;

			var id = GetId(playerUnitEvent.Class);
			var description = "Based on ";
			if (!string.IsNullOrWhiteSpace(playerUnitEvent.NativeUnitEvent))
			{
				description += playerUnitEvent.NativeUnitEvent;
			}
			else if (!string.IsNullOrWhiteSpace(playerUnitEvent.NativePlayerUnitEvent))
			{
				description += playerUnitEvent.NativePlayerUnitEvent;
			}
			else
			{
				description = playerUnitEvent.Description;
			}

			this.stream.WriteLine(@$"		/// <summary>");
			this.stream.WriteLine(@$"		/// {description}");
			this.stream.WriteLine(@$"		/// </summary>");
			this.stream.WriteLine(@$"		{playerUnitEvent.Enum} = {id},");
		}

		private void OutputNativePlayerUnitEventMapping(PlayerUnitEvent playerUnitEvent)
		{
			//if (!string.IsNullOrWhiteSpace(playerUnitEvent.NativeUnitEvent))
			//	return;

			if (string.IsNullOrWhiteSpace(playerUnitEvent.NativePlayerUnitEvent))
				return;

			this.stream.WriteLine(@$"			{{ (int){playerUnitEvent.Class}.{playerUnitEvent.Enum}, {playerUnitEvent.NativePlayerUnitEvent} }},");
		}

		private void OutputNativeUnitEventMapping(PlayerUnitEvent playerUnitEvent)
		{
			if (string.IsNullOrWhiteSpace(playerUnitEvent.NativeUnitEvent) || string.IsNullOrWhiteSpace(playerUnitEvent.NativePlayerUnitEvent))
				return;

			this.stream.WriteLine(@$"			{{ (int){playerUnitEvent.Class}.{playerUnitEvent.Enum}, {playerUnitEvent.NativeUnitEvent} }},");
		}

		private void OutputFuncMapping(PlayerUnitEvent playerUnitEvent)
		{
			if (string.IsNullOrWhiteSpace(playerUnitEvent.PlayerUnitEventFunc))
				return;

			this.stream.WriteLine(@$"			{{ (int){playerUnitEvent.Class}.{playerUnitEvent.Enum}, () => {playerUnitEvent.PlayerUnitEventFunc} }},");
		}

		private int GetId(string @class)
		{
			if (this.idByClass.TryGetValue(@class, out var nextId))
			{
				this.idByClass[@class] = ++nextId;
			}
			else
			{
				this.idByClass[@class] = nextId = (this.idByClass.Count * 100) + 1;
			}

			return nextId;
		}
	}
}
