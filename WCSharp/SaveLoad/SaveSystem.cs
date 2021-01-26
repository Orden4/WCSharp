using System;
using System.Collections.Generic;
using System.Linq;
using WCSharp.Utils;
using static War3Api.Common;

namespace WCSharp.SaveLoad
{
	public class SaveSystem
	{
		/// <summary>
		/// Pick any prime number from <see href="http://www.mathematical.com/primes0to1000k.html"/> or a similar site.
		/// </summary>
		public static int Hash1 { get; set; } = 773299;
		/// <summary>
		/// Pick any prime number from <see href="http://www.mathematical.com/primes0to1000k.html"/> or a similar site.
		/// </summary>
		public static int Hash2 { get; set; } = 218641;
		/// <summary>
		/// The folder in which to store the saves.
		/// </summary>
		public static string SaveFolder { get; set; }
		/// <summary>
		/// Whether saves are bound to the name of the player. If true, saves will have the player name contained in the filename,
		/// and upon loading this will be matched with the current player's name.
		/// <para>Attempting to load a save tied to a different username will result in a new save file being created instead.</para>
		/// </summary>
		public static bool BindSavesToPlayerName { get; set; } = true;

		private static readonly List<int> abilityIds = new List<int>
		{
			1097690227, // Amls
			1097359726, // Ahan
			1098018659, // Aroc
			1097689443, // Amic
			1097689452, // Amil
			1097034854, // Aclf
			1097035111, // Acmg
			1097098598, // Adef
			1097099635, // Adis
			1097228916, // Afbt
		};

		private static List<string> originalTooltips;
		private static readonly Dictionary<int, SyncMessage> syncMessages = new Dictionary<int, SyncMessage>();
		private static bool sizeWarningGiven;

		internal const string PACKET_PREAMBLE = "_packetPreamble";
		internal const string PACKET_MESSAGE = "_packetMessage";
		internal const string SAVE_HASH = "_saveHash";
		internal const string SAVE_SLOT = "_saveSlot";
		internal const string PREAMBLE_MESSAGE_COUNT = "_messageCount";
		internal const string PREAMBLE_SAVE_SLOT = "_saveSlot";
		private const int MAX_PACKET_SIZE = 200;

		public delegate void SaveLoaded(Save save);
		/// <summary>
		/// Use this to receive loaded saves. Saves may be empty.
		/// </summary>
		public static event SaveLoaded OnSaveLoaded;

#pragma warning disable IDE0052 // Remove unread private members
		private static readonly object initialiser = Initialise();
#pragma warning restore IDE0052 // Remove unread private members
		private static object Initialise()
		{
			var maxPlayers = GetBJMaxPlayers();

			var preambleTrigger = CreateTrigger();
			TriggerAddAction(preambleTrigger, HandlePreamble);
			var messageTrigger = CreateTrigger();
			TriggerAddAction(messageTrigger, HandleMessage);

			for (var i = 0; i < maxPlayers; i++)
			{
				var player = Player(i);
				BlzTriggerRegisterPlayerSyncEvent(preambleTrigger, player, PACKET_PREAMBLE, false);
				BlzTriggerRegisterPlayerSyncEvent(messageTrigger, player, PACKET_MESSAGE, false);
			}

			return null;
		}

		private static void HandlePreamble()
		{
			var player = GetTriggerPlayer();
			var data = BlzGetTriggerSyncData();
			var preamble = new Save(data);
			if (preamble.TryGetValue(PREAMBLE_MESSAGE_COUNT, out int messageCount) &&
				preamble.TryGetValue(PREAMBLE_SAVE_SLOT, out int saveSlot))
			{
				var playerId = GetPlayerId(player);
				var syncMessage = new SyncMessage(player, saveSlot, messageCount);
				syncMessages.Add(playerId, syncMessage);
				EvaluateSyncMessage(syncMessage);

				if (messageCount > 5 && !sizeWarningGiven)
				{
					sizeWarningGiven = true;
					Util.Debug("WARNING: More than 50% of the save file storage space is in use. Please contact the mapmaker to increase storage space.");
				}
			}
		}

		private static void HandleMessage()
		{
			var playerId = GetPlayerId(GetTriggerPlayer());
			var data = BlzGetTriggerSyncData();

			if (syncMessages.TryGetValue(playerId, out var syncMessage))
			{
				syncMessage.Data += data;
				syncMessage.MessagesRemaining--;
				EvaluateSyncMessage(syncMessage);
			}
		}

		private static void EvaluateSyncMessage(SyncMessage syncMessage)
		{
			if (syncMessage.MessagesRemaining == 0)
			{
				var save = syncMessage.ToSave();
				OnSaveLoaded?.Invoke(save);
				syncMessages.Remove(GetPlayerId(syncMessage.Player));
			}
		}

		private static void Preprocess()
		{
			originalTooltips = abilityIds
				.Select(x => BlzGetAbilityTooltip(x, 0))
				.ToList();
		}

		/// <summary>
		/// Loads a save for the given player, using the given slot.
		/// <para>The save slot must be between 1 and 10.</para>
		/// <para>If no save exists on the given slot, will load an empty save.</para>
		/// <para>Use <see cref="OnSaveLoaded"/> to receive the save.</para>
		/// </summary>
		/// <param name="player">The player to create the save for.</param>
		/// <param name="saveSlot">The slot to save to.</param>
		public static void Load(player player, int saveSlot = 1)
		{
			if (originalTooltips == null)
			{
				Preprocess();
			}

			if (GetLocalPlayer() != player || string.IsNullOrEmpty(SaveFolder))
			{
				return;
			}

			var filename = GetFileName(player, saveSlot);
			Preloader(filename);
			var data = "";

			for (var i = 0; i < abilityIds.Count; i++)
			{
				var abilityId = abilityIds[i];
				var originalTooltip = originalTooltips[i];
				var packet = BlzGetAbilityTooltip(abilityId, 0);
				BlzSetAbilityTooltip(abilityId, originalTooltip, 0);
				if (packet == originalTooltip)
				{
					break;
				}
				else
				{
					data += packet;
				}
			}

			var numberOfPackets = Math.Ceiling(data.Length / (float)MAX_PACKET_SIZE);
			var preamble = new Save
			{
				{ PREAMBLE_MESSAGE_COUNT, numberOfPackets },
				{ PREAMBLE_SAVE_SLOT, saveSlot }
			};
			BlzSendSyncData(PACKET_PREAMBLE, preamble.ToString());

			for (var i = 0; i < numberOfPackets; i++)
			{
				var startIndex = i * MAX_PACKET_SIZE;
				var endIndex = Math.Min(startIndex + MAX_PACKET_SIZE, data.Length - startIndex);
				BlzSendSyncData(PACKET_MESSAGE, data.Substring(startIndex, endIndex));
			}
		}

		/// <summary>
		/// Stores a save for the given player.
		/// </summary>
		/// <param name="save">The save to store.</param>
		public static void Save(Save save)
		{
			if (GetLocalPlayer() != save.Player || string.IsNullOrEmpty(SaveFolder))
			{
				return;
			}

			var filename = GetFileName(save);
			var data = save.ToString().Replace("\"", "\\\"");
			if (data.Length > MAX_PACKET_SIZE * abilityIds.Count)
			{
				Util.Debug("ERROR: Maximum save file size has been reached. Unable to save file. Please contact the mapmaker to increase storage space.");
				return;
			}

			PreloadGenClear();
			PreloadGenStart();
			for (var i = 0; i * MAX_PACKET_SIZE < data.Length; i++)
			{
				var nextAbilityId = abilityIds[i];
				var startIndex = i * MAX_PACKET_SIZE;
				var endIndex = Math.Min(startIndex + MAX_PACKET_SIZE, data.Length - startIndex);
				Preload($"\" )\ncall BlzSetAbilityTooltip({nextAbilityId}, \"{data.Substring(startIndex, endIndex)}\", 0)//");
			}
			Preload($"\" )\nendfunction\nfunction a takes nothing returns nothing\n //");
			PreloadGenEnd(filename);
		}

		/// <summary>
		/// Adds an additional ability id for use as temporary data storage.
		/// <para>By default, you have 2000 characters to use as storage. If you approach that limit, expand the ability ids used at the start of the game using this method.</para>
		/// </summary>
		/// <param name="abilityId"></param>
		public static void AddAbilityId(int abilityId)
		{
			if (originalTooltips == null)
			{
				abilityIds.Add(abilityId);
			}
		}

		private static string GetFileName(Save save)
		{
			return GetFileName(save.Player, save.SaveSlot);
		}

		private static string GetFileName(player player, int saveSlot)
		{
			if (BindSavesToPlayerName)
			{
				return $"{SaveFolder}\\{GetPlayerName(player)}-save-{saveSlot}.pld";
			}
			else
			{
				return $"{SaveFolder}\\save-{saveSlot}.pld";
			}
		}
	}
}
