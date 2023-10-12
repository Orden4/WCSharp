using System;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.W3MMD
{
	/// <summary>
	/// The main class responsible for creating and managing W3MMD variable and data emissions.
	/// <para>Note: You should define your variables and events a few seconds before interacting with them.</para>
	/// </summary>
	public static class W3Mmd
	{
		private static readonly gamecache cache = Init();
		private static int messageId = 0;

		private static gamecache Init()
		{
			FlushGameCache(InitGameCache("MMD.dat"));
			var mmdCache = InitGameCache("MMD.dat");

			Emit("init version 1 1", mmdCache);

			for (var i = 0; i < GetBJMaxPlayers(); i++)
			{
				var player = Player(i);
				if (GetPlayerController(player) == MAP_CONTROL_USER &&
					GetPlayerSlotState(player) != PLAYER_SLOT_STATE_EMPTY)
				{
					Emit($"init pid {i} {GetPlayerName(player).Pack()}", mmdCache);
				}
			}

			return mmdCache;
		}

		/// <summary>
		/// <para>W3MMD is automatically initialised when defining any event or variable.</para>
		/// As such, this method is only necessary to call if you exclusively use SetPlayerFlag and/or EmitCustom.
		/// </summary>
		public static void ForceInit() { }

		/// <summary>
		/// Select a player to emit the message.
		/// </summary>
		private static player GetEmitter()
		{
			var maxPlayers = GetBJMaxPlayers();
			for (var i = 0; i < 1000; i++)
			{
				var player = Player(GetRandomInt(0, maxPlayers));
				if (GetPlayerController(player) == MAP_CONTROL_USER &&
					GetPlayerSlotState(player) == PLAYER_SLOT_STATE_PLAYING)
				{
					return player;
				}
			}
			throw new Exception("w3mmd: could not find an emitter");
		}

		internal static void DefineVar(string packedName, W3MmdVariableType variableType, W3MmdGoalType goalType, W3MmdSuggestionType suggestionType)
		{
			Emit($"DefVarP {packedName} {variableType.Pack()} {goalType.Pack()} {suggestionType.Pack()}");
		}

		/// <summary>
		/// Emits a message to be consumed by a parser.
		/// </summary>
		internal static void Emit(string message, gamecache mmdCache = null)
		{
			var thisMessageId = messageId++;
			var emitter = GetEmitter();

			// Only the emitter should emit
			if (emitter != GetLocalPlayer())
				return;

			mmdCache ??= cache;
			StoreInteger(
				mmdCache,
				$"val:{thisMessageId}",
				message,
				thisMessageId * message.Length % 127
			);
			SyncStoredInteger(mmdCache, $"val:{thisMessageId}", message);
		}

		/// <summary>
		/// Sets a player's flag to be consumed by a parser.
		/// </summary>
		/// <param name="player">Player for who the flag is set.</param>
		/// <param name="flag">The flag value to set.</param>
		public static void SetPlayerFlag(player player, W3MmdFlag flag)
		{
			SetPlayerFlag(GetPlayerId(player), flag);
		}

		/// <summary>
		/// Sets a player's flag to be consumed by a parser.
		/// </summary>
		/// <param name="playerId">PlayerId for who the flag is set.</param>
		/// <param name="flag">The flag value to set.</param>
		public static void SetPlayerFlag(int playerId, W3MmdFlag flag)
		{
			Emit($"FlagP {playerId} {flag.Pack()}");
		}

		/// <summary>
		/// Emits custom data that may be used by parsers/viewers.
		/// <para>See the W3MMD.spec at https://github.com/PBug90/w3gPlus for more information.</para>
		/// </summary>
		/// <param name="key">A key to identify the data.</param>
		/// <param name="data">The data emitted.</param>
		public static void EmitCustom(string key, string data)
		{
			Emit($"custom {key.Pack()} {data.Pack()}");
		}

		/// <summary>
		/// Defines an event that can occur multiple times.
		/// <para>Equivalent to creating a new <see cref="W3MmdEvent"/>.</para>
		/// </summary>
		/// <param name="name">Name of the event.</param>
		/// <param name="format">
		/// String to format an event into a user-consumable string.
		/// <para>e.g., for a player kills player event, we'd do "{0} killed {1}" where {0} is the first argument (the killer) and {1} is the second argument (the victim).</para>
		/// </param>
		/// <param name="arguments">Name of the arguments. e.g., ["killer", "victim"].</param>
		/// <exception cref="Exception">If the name is not between 1 and 32 characters long.</exception>
		public static W3MmdEvent DefineEvent(string name, string format, params string[] arguments)
		{
			return new W3MmdEvent(name, format, arguments);
		}

		/// <summary>
		/// Defines a player float variable that can be mutated throughout the game.
		/// <para>Equivalent to creating a new <see cref="W3MmdFloatVar"/>.</para>
		/// </summary>
		/// <param name="name">Name of the variable.</param>
		/// <param name="goalType">Whether the player is trying to get a high or low value (or none).</param>
		/// <param name="suggestionType">A suggestion for how a parser/viewer should treat the output values.</param>
		/// <exception cref="Exception">If the name is not between 1 and 32 characters long.</exception>
		public static W3MmdFloatVar DefineFloat(string name, W3MmdGoalType goalType, W3MmdSuggestionType suggestionType)
		{
			return new W3MmdFloatVar(name, goalType, suggestionType);
		}

		/// <summary>
		/// Defines a player int variable that can be mutated throughout the game.
		/// <para>Equivalent to creating a new <see cref="W3MmdIntVar"/>.</para>
		/// </summary>
		/// <param name="name">Name of the variable.</param>
		/// <param name="goalType">Whether the player is trying to get a high or low value (or none).</param>
		/// <param name="suggestionType">A suggestion for how a parser/viewer should treat the output values.</param>
		/// <exception cref="Exception">If the name is not between 1 and 32 characters long.</exception>
		public static W3MmdIntVar DefineInt(string name, W3MmdGoalType goalType, W3MmdSuggestionType suggestionType)
		{
			return new W3MmdIntVar(name, goalType, suggestionType);
		}

		/// <summary>
		/// Defines a player string variable that can be mutated throughout the game.
		/// <para>Useful for classifications.</para>
		/// <para>Equivalent to creating a new <see cref="W3MmdStringVar"/>.</para>
		/// </summary>
		/// <param name="name">Name of the variable.</param>
		/// <param name="suggestionType">A suggestion for how a parser/viewer should treat the value.</param>
		/// <exception cref="Exception">If the name is not between 1 and 32 characters long.</exception>
		public static W3MmdStringVar DefineString(string name, W3MmdSuggestionType suggestionType)
		{
			return new W3MmdStringVar(name, suggestionType);
		}
	}
}
