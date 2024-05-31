using System;
using System.Collections.Generic;
using System.Text;
using WCSharp.Api;
using WCSharp.Json;
using WCSharp.Shared;
using WCSharp.Sync;
using static WCSharp.Api.Common;

namespace WCSharp.SaveLoad
{
	/// <summary>
	/// Contains logic shared between all different generic <see cref="SaveSystem{T}"/> instances.
	/// </summary>
	public class SaveSystem
	{

		private static int NextId { get; set; }

		internal static List<string> OriginalTooltips { get; } = new();
		internal static List<int> AbilityIds { get; } = new()
		{
			1097690227, // Amls
			1098018659, // Aroc
			1097689443, // Amic
			1097689452, // Amil
			1097034854, // Aclf
			1097035111, // Acmg
			1097098598, // Adef
			1097099635, // Adis
			1097228916, // Afbt
			1097228907, // Afbk
			1097231467, // Aflk
			1097231457, // Afla
			1097300322, // Agyb
			1097233256, // Afsh
			1097360737, // Ahea
			1097428582, // Ainf
			1097430643, // Aivs
			1097688166, // Amdf
			1097102451, // Adts
			1097889894, // Apxf
			1097886841, // Aply
			1097364080, // Ahrp
			1095267425, // AHta
			1098083439, // Aslo
			1098084467, // Asps
			1098085480, // Asth
			1098085480, // Agyv
			1098085480, // Aast
			1098085480, // Abtl
			1098085480, // Sbtl
		};

		/// <summary>
		/// Adds an additional ability id for use as temporary data storage.
		/// <para>By default, you have 6000 characters to use as storage. If you approach that limit, expand the ability ids used at the start of the game using this method.</para>
		/// <para>This should be done upon map start, before anything attempts to use the SaveSystem.</para>
		/// <para>The default includes most of the Human abilities:</para>
		/// <para>Amls, Ahan, Aroc, Amic, Amil, Aclf, Acmg, Adef, Adis, Afbt, Afbk, Aflk, Afla, Agyb, Afsh,
		/// Ahea, Ahlh, Ainf, Aivs, Ahri, Amdf, Adts, Apxf, Aply, Ahrp, AHta, Aslo, Asps, Asth, Ahsb</para>
		/// </summary>
		/// <param name="abilityId"></param>
		public static void AddAbilityId(int abilityId)
		{
			if (OriginalTooltips == null)
			{
				if (AbilityIds.Contains(abilityId))
				{
					throw new ArgumentException($"ERROR: Tooltip {abilityId} is already in use by the save system.");
				}
				AbilityIds.Add(abilityId);
			}
		}

		internal static void Init()
		{
			for (var i = 0; i < AbilityIds.Count; i++)
			{
				var tooltip = BlzGetAbilityTooltip(AbilityIds[i], 0);
				if (tooltip != "Tool tip missing!")
				{
					OriginalTooltips.Add(tooltip);
				}
				else
				{
					throw new ArgumentException($"ERROR: Tooltip {AbilityIds[i]} cannot be modified for the SaveLoad system. See the WCSharp wiki for more info on Save/Load storage space.");
				}
			}
		}

		internal static int GetNextId()
		{
			return ++NextId;
		}
	}

	/// <summary>
	/// System capable of saving C# data structures on a players local files to create save files that can be loaded at a later date/map.
	/// </summary>
	/// <typeparam name="T">The <see cref="Saveable"/> type that this instance will be saving/loading</typeparam>
	public class SaveSystem<T> : IDisposable
		where T : Saveable
	{
		/// <summary>
		/// Current state: Fully backwards compatible starting from v2.0 (incompatible with v1.x since it uses only basic reflection, due to lacking metadata).
		/// Version 1 - Uses multiple tooltips, stores save data as an object, updating the properties on the object could cause the hash to fail.
		/// Version 2a - Uses multiple tooltips, stores the save data as a singular string to avoid the pitfall of version 1.
		/// Version 2b - Same as 2a, but uses a single tooltip via overloading the Preload(End) functions. Did not actually increment the version value since not doing so allowed for forward compatability with 0 risk.
		/// </summary>
		internal const int CURRENT_VERSION = 2;
		private const int PACKET_SIZE = 239;

		private readonly int id;
		private readonly string saveFolder;
		private readonly string salt;
		private readonly int hash1;
		private readonly int hash2;
		private readonly bool bindSavesToPlayerName;
		private readonly bool attemptToLoadNewerVersions;
		private readonly string suffix;
		private readonly Base64 base64;

		/// <summary>
		/// Event handler for when a save is loaded. The save will be instantiated even if it is empty or failed to load.
		/// </summary>
		/// <param name="save">The save that was loaded.</param>
		/// <param name="loadResult">Indicates the state of the loaded save file, i.e. whether it's a newly created save, an existing save, or if it failed to load.</param>
		public delegate void OnSaveLoadedHandler(T save, LoadResult loadResult);

		/// <summary>
		/// This event will be invoked when a new save is loaded in, providing the given class and a boolean indicating whether the save is newly created or not.
		/// </summary>
		public event OnSaveLoadedHandler OnSaveLoaded;

		/// <summary>
		/// Creates a new <see cref="SaveSystem{T}"/> instance with the given <paramref name="options"/>.
		/// </summary>
		public SaveSystem(SaveSystemOptions options)
		{
			if (SaveSystem.OriginalTooltips.Count == 0)
			{
				SaveSystem.Init();
			}

			this.id = SaveSystem.GetNextId();
			this.saveFolder = options.SaveFolder;
			this.hash1 = options.Hash1;
			this.hash2 = options.Hash2;
			this.salt = options.Salt;
			this.bindSavesToPlayerName = options.BindSavesToPlayerName;
			this.attemptToLoadNewerVersions = options.AttemptToLoadNewerVersions;
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
			for (var i = 0; i < illegalCharacters.Length; i++)
			{
				var ch = illegalCharacters[i];
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
			if (message.SaveSystemId != this.id)
				return;

			var data = message.SaveData ?? Activator.CreateInstance<T>();
			data.player = Player(message.PlayerId);
			data.saveSlot = message.SaveSlot;
			OnSaveLoaded?.Invoke(data, message.LoadResult);
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

			var saveData = JsonConvert.Serialize(saveable);
			var save = new Save<T>
			{
				Version = CURRENT_VERSION,
				HashCode = GetSaveHash(saveData, saveable.player),
				SaveString = saveData,
			};

			var contents = this.base64.Encode(JsonConvert.Serialize(save));

			var filename = GetFileName(saveable.player, saveable.saveSlot);
			PreloadGenClear();
			PreloadGenStart();
			Preload("\" )\n//!beginusercode\nlocal l=0;local o={};Preload=function(s)l=l+1;o[l]=s;end;PreloadEnd=function()BlzSetAbilityTooltip(1097690227,table.concat(o),0)end\n//!endusercode\n//");
			for (var i = 0; i * PACKET_SIZE < contents.Length; i++)
			{
				var startIndex = i * PACKET_SIZE;
				var endIndex = Math.Min(contents.Length - startIndex, PACKET_SIZE);
				Preload(contents.Substring(startIndex, endIndex));
			}
			PreloadGenEnd(filename);
		}

		/// <summary>
		/// Loads a save for the given player on the given save slot.
		/// <para>If no save exists on the given slot, or if loading failed for any reason, a new, empty save will be returned.</para>
		/// <para>Use <see cref="OnSaveLoaded"/> to receive the save.</para>
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

			Preloader(GetFileName(player, saveSlot));
			var sb = new StringBuilder();

			for (var i = 0; i < SaveSystem.AbilityIds.Count; i++)
			{
				var abilityId = SaveSystem.AbilityIds[i];
				var originalTooltip = SaveSystem.OriginalTooltips[i];

				var packet = BlzGetAbilityTooltip(abilityId, 0);
				if (packet == originalTooltip)
				{
					break;
				}
				else
				{
					BlzSetAbilityTooltip(abilityId, originalTooltip, 0);
					sb.Append(packet);
				}
			}

			var loadResult = TryDecode(sb, out var save);
			var message = new SaveLoadedMessage<T>
			{
				SaveSystemId = this.id,
				PlayerId = GetPlayerId(player),
				SaveSlot = saveSlot,
				LoadResult = loadResult
			};

			if (save != null)
			{
				if (save.Version == 1)
				{
					// Version 1 used a flawed way of verifying the hash, but we allow loading it anyway for backwards compatability.
					if (save.SaveData != null)
					{
						if (save.HashCode == GetSaveHash(JsonConvert.Serialize(save.SaveData), player))
						{
							message.SaveData = save.SaveData;
						}
						else
						{
							message.LoadResult = LoadResult.FailedHash;
						}
					}
				}
				else if (save.Version == 2 || this.attemptToLoadNewerVersions)
				{
					if (save.Version != 2)
					{
						Console.WriteLine("WARNING: Save found was of a more recent version than this map supports. Attempting to load anyway.");
					}

					// Version 2 stores the save data as a string so that we don't have to re-serialize it in order to verify the hash, as re-serializing it may change the save.
					if (!string.IsNullOrEmpty(save.SaveString))
					{
						if (TryDeserialize(save.SaveString, out var saveDataObject))
						{
							message.SaveData = saveDataObject;
						}
						else
						{
							message.LoadResult = LoadResult.FailedDeserialize;
						}
					}
				}
				else
				{
					Console.WriteLine("ERROR: Save found was of a more recent version than this map supports.");
				}
			}

			SyncSystem.Send(message);
		}

		private LoadResult TryDecode(StringBuilder sb, out Save<T> save)
		{
			var saveData = sb.ToString();
			if (string.IsNullOrEmpty(saveData))
			{
				save = null;
				return LoadResult.NewSave;
			}

			var result = LoadResult.FailedDecode;
			try
			{
				var contents = this.base64.Decode(saveData);
				result = LoadResult.FailedDeserialize;
				save = JsonConvert.Deserialize<Save<T>>(contents);
				return LoadResult.Success;
			}
			catch (Exception)
			{
				save = null;
				return result;
			}
		}

		private static bool TryDeserialize(string saveData, out T saveDataObject)
		{
			try
			{
				saveDataObject = JsonConvert.Deserialize<T>(saveData);
				return true;
			}
			catch (Exception)
			{
				saveDataObject = null;
				return false;
			}
		}

		private string GetFileName(player player, int saveSlot)
		{
			return this.bindSavesToPlayerName
				? $"{this.saveFolder}\\{GetPlayerName(player)}-save-{saveSlot}{this.suffix}.pld"
				: $"{this.saveFolder}\\save-{saveSlot}{this.suffix}.pld";
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
				for (var i = 0; i < @string.Length; i++)
				{
					hash = (hash * this.hash2) ^ @string[i];
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
