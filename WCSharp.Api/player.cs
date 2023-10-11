namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class player : agent
	{
		internal player()
		{
		}

		/// @CSharpLua.Template = "Player({0})"
		public static extern player Create(int playerId);
		/// @CSharpLua.Get = "GetLocalPlayer()"
		public static extern player LocalPlayer { get; }
		/// @CSharpLua.Get = "Player(bj_PLAYER_NEUTRAL_VICTIM)"
		public static extern player NeutralVictim { get; }
		/// @CSharpLua.Get = "Player(bj_PLAYER_NEUTRAL_EXTRA)"
		public static extern player NeutralExtra { get; }
		/// @CSharpLua.Get = "Player(PLAYER_NEUTRAL_PASSIVE)"
		public static extern player NeutralPassive { get; }
		/// @CSharpLua.Get = "Player(PLAYER_NEUTRAL_AGGRESSIVE)"
		public static extern player NeutralAggressive { get; }

		/// @CSharpLua.Get = "bj_PLAYER_NEUTRAL_VICTIM"
		public static extern int NeutralVictimId { get; }
		/// @CSharpLua.Get = "bj_PLAYER_NEUTRAL_EXTRA"
		public static extern int NeutralExtraId { get; }
		/// @CSharpLua.Get = "PLAYER_NEUTRAL_PASSIVE"
		public static extern int NeutralPassiveId { get; }
		/// @CSharpLua.Get = "PLAYER_NEUTRAL_AGGRESSIVE"
		public static extern int NeutralAggressiveId { get; }
		/// @CSharpLua.Get = "bj_MAX_PLAYERS"
		public static extern int MaxPlayers { get; }
		/// @CSharpLua.Get = "bj_MAX_PLAYER_SLOTS"
		public static extern int MaxPlayerSlots { get; }
		/// @CSharpLua.Get = "GetPlayers()"
		public static extern int Count { get; }

		/// @CSharpLua.Get = "GetPlayerColor({this})"
		/// @CSharpLua.Set = "SetPlayerColor({this}, {0})"
		public extern playercolor Color { get; set; }
		/// @CSharpLua.Get = "GetPlayerName({this})"
		/// @CSharpLua.Set = "SetPlayerName({this}, {0})"
		public extern string Name { get; set; }
		/// @CSharpLua.Get = "GetPlayerStartLocation({this})"
		/// @CSharpLua.Set = "SetPlayerStartLocation({this}, {0})"
		public extern int StartLocation { get; set; }
		/// @CSharpLua.Get = "GetPlayerTeam({this})"
		/// @CSharpLua.Set = "SetPlayerTeam({this}, {0})"
		public extern int Team { get; set; }
		/// @CSharpLua.Get = "GetPlayerController({this})"
		/// @CSharpLua.Set = "SetPlayerController({this}, {0})"
		public extern mapcontrol Controller { get; set; }
		/// @CSharpLua.Get = "GetPlayerHandicap({this})"
		/// @CSharpLua.Set = "SetPlayerHandicap({this}, {0})"
		public extern float Handicap { get; set; }
		/// @CSharpLua.Get = "GetPlayerHandicapXP({this})"
		/// @CSharpLua.Set = "SetPlayerHandicapXP({this}, {0})"
		public extern float HandicapXp { get; set; }
		/// @CSharpLua.Get = "GetPlayerHandicapReviveTime({this})"
		/// @CSharpLua.Set = "SetPlayerHandicapReviveTime({this}, {0})"
		public extern float HandicapReviveTime { get; set; }
		/// @CSharpLua.Get = "GetPlayerHandicapDamage({this})"
		/// @CSharpLua.Set = "SetPlayerHandicapDamage({this}, {0})"
		public extern float HandicapDamage { get; set; }

		/// @CSharpLua.Get = "PlayerGetLeaderboard({this})"
		/// @CSharpLua.Set = "PlayerSetLeaderboard({this}, {0})"
		public extern leaderboard Leaderboard { get; set; }

		/// @CSharpLua.Get = "GetPlayerId({this})"
		public extern int Id { get; }
		/// @CSharpLua.Get = "GetPlayerRace({this})"
		public extern race Race { get; }
		/// @CSharpLua.Get = "GetPlayerSlotState({this})"
		public extern playerslotstate SlotState { get; }
		/// @CSharpLua.Get = "GetPlayerSelectable({this})"
		public extern bool Selectable { get; }
		/// @CSharpLua.Get = "IsPlayerObserver({this})"
		public extern bool IsObserver { get; }
		/// @CSharpLua.Get = "BlzGetPlayerTownHallCount({this})"
		public extern int TownHallCount { get; }

		/// @CSharpLua.Get = "GetPlayerState({this}, PLAYER_STATE_GAME_RESULT)"
		/// @CSharpLua.Set = "SetPlayerState({this}, PLAYER_STATE_GAME_RESULT, {0})"
		public extern int GameResult { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({this}, PLAYER_STATE_RESOURCE_GOLD)"
		/// @CSharpLua.Set = "SetPlayerState({this}, PLAYER_STATE_RESOURCE_GOLD, {0})"
		public extern int Gold { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({this}, PLAYER_STATE_RESOURCE_LUMBER)"
		/// @CSharpLua.Set = "SetPlayerState({this}, PLAYER_STATE_RESOURCE_LUMBER, {0})"
		public extern int Lumber { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({this}, PLAYER_STATE_RESOURCE_HERO_TOKENS)"
		/// @CSharpLua.Set = "SetPlayerState({this}, PLAYER_STATE_RESOURCE_HERO_TOKENS, {0})"
		public extern int HeroTokens { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({this}, PLAYER_STATE_RESOURCE_FOOD_CAP)"
		/// @CSharpLua.Set = "SetPlayerState({this}, PLAYER_STATE_RESOURCE_FOOD_CAP, {0})"
		public extern int FoodCap { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({this}, PLAYER_STATE_RESOURCE_FOOD_USED)"
		/// @CSharpLua.Set = "SetPlayerState({this}, PLAYER_STATE_RESOURCE_FOOD_USED, {0})"
		public extern int FoodUsed { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({this}, PLAYER_STATE_FOOD_CAP_CEILING)"
		/// @CSharpLua.Set = "SetPlayerState({this}, PLAYER_STATE_FOOD_CAP_CEILING, {0})"
		public extern int FoodCapCeiling { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({this}, PLAYER_STATE_GOLD_UPKEEP_RATE)"
		/// @CSharpLua.Set = "SetPlayerState({this}, PLAYER_STATE_GOLD_UPKEEP_RATE, {0})"
		public extern int GoldUpkeepRate { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({this}, PLAYER_STATE_LUMBER_UPKEEP_RATE)"
		/// @CSharpLua.Set = "SetPlayerState({this}, PLAYER_STATE_LUMBER_UPKEEP_RATE, {0})"
		public extern int LumberUpkeepRate { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({this}, PLAYER_STATE_GOLD_GATHERED)"
		/// @CSharpLua.Set = "SetPlayerState({this}, PLAYER_STATE_GOLD_GATHERED, {0})"
		public extern int GoldGathered { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({this}, PLAYER_STATE_LUMBER_GATHERED)"
		/// @CSharpLua.Set = "SetPlayerState({this}, PLAYER_STATE_LUMBER_GATHERED, {0})"
		public extern int LumberGathered { get; set; }

		/// @CSharpLua.Template = "GetPlayerState({this}, {0})"
		public extern int GetState(playerstate playerState);
		/// @CSharpLua.Template = "SetPlayerState({this}, {0}, {1})"
		public extern void SetState(playerstate playerState, int value);

		/// @CSharpLua.Template = "GetPlayerTaxRate({this}, {0}, PLAYER_STATE_RESOURCE_GOLD)"
		public extern int GetGoldTaxRate(player otherPlayer);
		/// @CSharpLua.Template = "SetPlayerTaxRate({this}, {0}, PLAYER_STATE_RESOURCE_GOLD, {1})"
		public extern void SetGoldTaxRate(player otherPlayer, int percent);

		/// @CSharpLua.Template = "GetPlayerTaxRate({this}, {0}, PLAYER_STATE_RESOURCE_LUMBER)"
		public extern int GetLumberTaxRate(player otherPlayer);
		/// @CSharpLua.Template = "SetPlayerTaxRate({this}, {0}, PLAYER_STATE_RESOURCE_LUMBER, {1})"
		public extern void SetLumberTaxRate(player otherPlayer, int percent);

		/// @CSharpLua.Template = "GetPlayerAlliance({this}, {0}, {1})"
		public extern bool GetAlliance(player otherPlayer, alliancetype allianceType);
		/// @CSharpLua.Template = "SetPlayerAlliance({this}, {0}, {1}, {2})"
		public extern void SetAlliance(player otherPlayer, alliancetype allianceType, bool value);

		/// @CSharpLua.Template = "GetPlayerTechMaxAllowed({this}, {0})"
		public extern int GetTechMaxAllowed(int techId);
		/// @CSharpLua.Template = "SetPlayerTechMaxAllowed({this}, {0}, {1})"
		public extern void SetTechMaxAllowed(int techId, int maximum);

		/// @CSharpLua.Template = "GetPlayerTechResearched({this}, {0}, {1})"
		public extern bool GetTechResearched(int techId, bool specificOnly = true);
		/// @CSharpLua.Template = "SetPlayerTechResearched({this}, {0}, {1})"
		public extern void SetTechResearched(int techId, int level);
		/// @CSharpLua.Template = "AddPlayerTechResearched({this}, {0}, {1})"
		public extern void IncreaseTechResearched(int techId, int levels = 1);
		/// @CSharpLua.Template = "BlzDecPlayerTechResearched({this}, {0}, {1})"
		public extern void DecreaseTechResearched(int techId, int levels = 1);

		/// @CSharpLua.Template = "GetPlayerScore({this}, {0})"
		public extern int GetScore(playerscore playerScore);
		/// @CSharpLua.Template = "GetPlayerTechCount({this}, {0}, {1})"
		public extern int GetTechCount(int techId, bool specificOnly = true);
		/// @CSharpLua.Template = "GetPlayerUnitCount({this}, {0})"
		public extern int GetUnitCount(bool includeIncomplete = false);
		/// @CSharpLua.Template = "GetPlayerTypedUnitCount({this}, {0}, {1}, {2})"
		public extern int GetUnitCount(string unitType, bool includeIncomplete = false, bool includeUpgrades = false);
		/// @CSharpLua.Template = "GetPlayerStructureCount({this}, {0})"
		public extern int GetStructureCount(bool includeIncomplete = false);

		/// @CSharpLua.Template = "IsPlayerRacePrefSet({this}, {0})"
		public extern bool IsRacePreference(racepreference racepreference);
		/// @CSharpLua.Template = "IsPlayerAlly({this}, {0})"
		public extern bool IsAlly(player otherPlayer);
		/// @CSharpLua.Template = "IsPlayerEnemy({this}, {0})"
		public extern bool IsEnemy(player otherPlayer);
		/// @CSharpLua.Template = "IsVisibleToPlayer({0}, {1}, {this})"
		public extern bool IsVisible(float x, float y);
		/// @CSharpLua.Template = "IsFoggedToPlayer({0}, {1}, {this})"
		public extern bool IsFogged(float x, float y);
		/// @CSharpLua.Template = "IsMaskedToPlayer({0}, {1}, {this})"
		public extern bool IsMasked(float x, float y);

		/// @CSharpLua.Template = "SetPlayerRaceSelectable({this}, {0})"
		public extern void SetRaceSelectable(bool raceSelectable);
		/// @CSharpLua.Template = "SetPlayerRacePreference({this}, {0})"
		public extern void SetRacePreference(racepreference racePreference);
		/// @CSharpLua.Template = "SetPlayerAbilityAvailable({this}, {0}, {1})"
		public extern void SetAbilityAvailable(int abilityId, bool available);

		/// @CSharpLua.Template = "IssueNeutralImmediateOrder({this}, {1}, {0})"
		public extern bool IssueNeutralImmediateOrder(string order, unit neutralStructure);
		/// @CSharpLua.Template = "IssueNeutralImmediateOrderById({this}, {1}, {0})"
		public extern bool IssueNeutralImmediateOrder(int order, unit neutralStructure);
		/// @CSharpLua.Template = "IssueNeutralPointOrder({this}, {1}, {0}, {2}, {3})"
		public extern bool IssueNeutralPointOrder(string order, unit neutralStructure, float x, float y);
		/// @CSharpLua.Template = "IssueNeutralPointOrderById({this}, {1}, {0}, {2}, {3})"
		public extern bool IssueNeutralPointOrder(int order, unit neutralStructure, float x, float y);
		/// @CSharpLua.Template = "IssueNeutralTargetOrder({this}, {1}, {0}, {2})"
		public extern bool IssueNeutralTargetOrder(string order, unit neutralStructure, widget target);
		/// @CSharpLua.Template = "IssueNeutralTargetOrderById({this}, {1}, {0}, {2})"
		public extern bool IssueNeutralTargetOrder(int order, unit neutralStructure, widget target);

		/// @CSharpLua.Template = "ForcePlayerStartLocation({this}, {0})"
		public extern void ForceStartLocation(int startLocation);
		/// @CSharpLua.Template = "SetPlayerUnitsOwner({this}, {0})"
		public extern void SetUnitsOwner(int newOwnerPlayerId);
		/// @CSharpLua.Template = "CripplePlayer({this}, {0}, {1})"
		public extern void Cripple(force toForce, bool value);
		/// @CSharpLua.Template = "RemovePlayer({this}, {0})"
		public extern void Remove(playergameresult gameResult);
		/// @CSharpLua.Template = "CachePlayerHeroData({this})"
		public extern void CacheHeroData();

		/// @CSharpLua.Template = "DisplayTextToPlayer({this}, {1}, {2}, {0})"
		public extern void DisplayTextTo(string message, float x = 0, float y = 0);
		/// @CSharpLua.Template = "DisplayTimedTextToPlayer({this}, {2}, {3}, {0}, {1})"
		public extern void DisplayTimedTextTo(float duration, string message, float x = 0, float y = 0);
		/// @CSharpLua.Template = "DisplayTimedTextFromPlayer({this}, {2}, {3}, {0}, {1})"
		public extern void DisplayTimedTextFrom(float duration, string message, float x = 0, float y = 0);
	}
}
