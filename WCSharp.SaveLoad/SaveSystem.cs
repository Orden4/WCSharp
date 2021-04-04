using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCSharp.Json;
using WCSharp.Shared;
using WCSharp.Sync;
using static War3Api.Common;

namespace WCSharp.SaveLoad
{
	/// <summary>
	/// System capable of saving C# data structures on a players local files to create save files that can be loaded at a later date/map.
	/// </summary>
	/// <typeparam name="T">The <see cref="Saveable"/> type that this instance will be saving/loading</typeparam>
	public class SaveSystem<T> : IDisposable
		where T : Saveable
	{
		internal const int CURRENT_VERSION = 1;
		private const int PACKET_SIZE = 185;

		private static List<string> originalTooltips;
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

		/// <summary>
		/// Adds an additional ability id for use as temporary data storage.
		/// <para>By default, you have 2000 characters to use as storage. If you approach that limit, expand the ability ids used at the start of the game using this method.</para>
		/// <para>This should be done upon map start, before anything attempts to use the SaveSystem.</para>
		/// </summary>
		/// <param name="abilityId"></param>
		public static void AddAbilityId(int abilityId)
		{
			if (originalTooltips == null)
			{
				abilityIds.Add(abilityId);
			}
		}

		private readonly string saveFolder;
		private readonly string salt;
		private readonly int hash1;
		private readonly int hash2;
		private readonly bool bindSavesToPlayerName;
		private readonly string suffix;
		private readonly Base64 base64;

		/// <summary>
		/// Event handler for when a save is loaded. Note that the save will be instantiated even if it is empty.
		/// </summary>
		/// <param name="save">The save that was loaded.</param>
		/// <param name="isEmptySave">Whether the save file is empty (i.e. did not exist before).</param>
		public delegate void OnSaveLoadedHandler(T save, bool isEmptySave);

		/// <summary>
		/// This event will be invoked when a new save is loaded in, providing the given class and a boolean indicating whether the save is newly created or not.
		/// </summary>
		public event OnSaveLoadedHandler OnSaveLoaded;

		/// <summary>
		/// Creates a new <see cref="SaveSystem{T}"/> instance with the given <paramref name="options"/>.
		/// </summary>
		public SaveSystem(SaveSystemOptions options)
		{
			if (originalTooltips == null)
			{
				originalTooltips = abilityIds
					.Select(x => BlzGetAbilityTooltip(x, 0))
					.ToList();
			}

			this.saveFolder = options.SaveFolder;
			this.hash1 = options.Hash1;
			this.hash2 = options.Hash2;
			this.salt = options.Salt;
			this.bindSavesToPlayerName = options.BindSavesToPlayerName;
			this.suffix = options.Suffix ?? "";
			this.base64 = options.Base64Provider ?? new Base64();

			if (string.IsNullOrWhiteSpace(this.saveFolder))
				throw new ArgumentException("ERROR: Must define a non-empty save folder for the SaveSystem.");
			if (string.IsNullOrWhiteSpace(this.salt))
				throw new ArgumentException("ERROR: Must define a non-empty save folder for the SaveSystem.");
			if (this.hash1 <= 0)
				throw new ArgumentException("ERROR: Must define a positive non-zero hash1 for the SaveSystem.");
			if (this.hash2 <= 0)
				throw new ArgumentException("ERROR: Must define a positive non-zero hash2 for the SaveSystem.");

			var illegalCharacters = new char[] { '<', '>', ':', '"', '/', '\\', '|', '?', '*' };
			foreach (var ch in illegalCharacters)
			{
				if (this.saveFolder.Contains(ch))
					throw new ArgumentException($"ERROR: SaveFolder cannot contain {ch} as this is an illegal filename character.");
				if (this.suffix.Contains(ch))
					throw new ArgumentException($"ERROR: Suffix cannot contain {ch} as this is an illegal filename character.");
			}

			if (this.suffix != "" && !this.suffix.StartsWith("-"))
				this.suffix = "-" + this.suffix;

			SyncSystem.Subscribe<SaveLoadedMessage<T>>(HandleSaveLoadedMessage);
		}

		private void HandleSaveLoadedMessage(SaveLoadedMessage<T> message)
		{
			var data = message.SaveData ?? Activator.CreateInstance<T>();
			data.player = Player(message.PlayerId);
			data.saveSlot = message.SaveSlot;
			OnSaveLoaded?.Invoke(data, message.SaveData == null);
		}

		/// <summary>
		/// Writes the given saveable to file for the player who owns the save.
		/// </summary>
		/// <param name="saveable">The saveable to save.</param>
		public void Save(T saveable)
		{
			// This code must only execute for the local player
			if (GetLocalPlayer() != saveable.player)
			{
				return;
			}

			var save = new Save<T>
			{
				Version = CURRENT_VERSION,
				HashCode = GetSaveHash(JsonConvert.Serialize(saveable), saveable.player),
				SaveData = saveable,
			};

			var contents = this.base64.Encode(JsonConvert.Serialize(save));

			var filename = GetFileName(saveable.player, saveable.saveSlot);
			if (contents.Length > PACKET_SIZE * abilityIds.Count)
			{
				Console.WriteLine("ERROR: Maximum save file size has been reached. Unable to save file. Please contact the mapmaker to increase storage space.");
				return;
			}

			PreloadGenClear();
			PreloadGenStart();
			for (var i = 0; i * PACKET_SIZE < contents.Length; i++)
			{
				var nextAbilityId = abilityIds[i];
				var startIndex = i * PACKET_SIZE;
				var endIndex = Math.Min(contents.Length - startIndex, PACKET_SIZE);
				Preload($"\" )\ncall BlzSetAbilityTooltip({nextAbilityId}, \"{contents.Substring(startIndex, endIndex)}\", 0)//");
			}
			Preload($"\" )\nendfunction\nfunction a takes nothing returns nothing\n //");
			PreloadGenEnd(filename);
		}

		/// <summary>
		/// Loads a save for the given player, using the given slot.
		/// <para>If no save exists on the given slot, will load an empty save.</para>
		/// <para>Use <see cref="HandleSaveLoadedMessage"/> to receive the save.</para>
		/// </summary>
		/// <param name="player">The player to create the save for.</param>
		/// <param name="saveSlot">The slot to save to.</param>
		public void Load(player player, int saveSlot = 1)
		{
			// This code must only execute for the local player
			if (GetLocalPlayer() != player)
			{
				return;
			}

			var filename = GetFileName(player, saveSlot);
			Preloader(filename);
			var sb = new StringBuilder();

			for (var i = 0; i < abilityIds.Count; i++)
			{
				var abilityId = abilityIds[i];
				var originalTooltip = originalTooltips[i];

				var packet = BlzGetAbilityTooltip(abilityId, 0);
				if (packet == originalTooltip)
				{
					if (i * 2 > abilityIds.Count)
					{
						Console.WriteLine("WARNING: More than 50% of the save file storage space is in use. Please contact the mapmaker to increase storage space.");
					}
					break;
				}
				else
				{
					BlzSetAbilityTooltip(abilityId, originalTooltip, 0);
					sb.Append(packet);
				}
			}

			var save = TryLoadSave(sb);
			var message = new SaveLoadedMessage<T>
			{
				PlayerId = GetPlayerId(player),
				SaveSlot = saveSlot
			};

			if (save?.SaveData != null && save.HashCode == GetSaveHash(JsonConvert.Serialize(save.SaveData), player))
			{
				message.SaveData = save.SaveData;
			}

			SyncSystem.Send(message);
		}

		private Save<T> TryLoadSave(StringBuilder sb)
		{
			try
			{
				var contents = this.base64.Decode(sb.ToString());
				var save = JsonConvert.Deserialize<Save<T>>(contents);
				return save;
			}
			catch (Exception)
			{
				return null;
			}
		}

		private string GetFileName(player player, int saveSlot)
		{
			if (this.bindSavesToPlayerName)
			{
				return $"{this.saveFolder}\\{GetPlayerName(player)}-save-{saveSlot}{this.suffix}.pld";
			}
			else
			{
				return $"{this.saveFolder}\\save-{saveSlot}{this.suffix}.pld";
			}
		}

		private int GetSaveHash(string saveData, player player)
		{
			unchecked
			{
				var hash = HashString(this.hash1, saveData);
				if (this.bindSavesToPlayerName)
				{
					hash = HashString(hash, GetPlayerName(player));
				}
				hash = HashString(hash, this.salt);

				return hash;
			}
		}

		private int HashString(int hash, string @string)
		{
			unchecked
			{
				foreach (var ch in @string)
				{
					hash = (hash * this.hash2) ^ ch;
				}

				return hash;
			}
		}

		/// <inheritdoc/>
		public void Dispose()
		{
			SyncSystem.Unsubscribe<SaveLoadedMessage<T>>(HandleSaveLoadedMessage);
		}
	}
}
