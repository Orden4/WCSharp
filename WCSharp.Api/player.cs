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

		/// @CSharpLua.Get = "GetPlayerColor({0})"
		/// @CSharpLua.Set = "SetPlayerColor({0}, {1})"
		public extern playercolor Color { get; set; }
		/// @CSharpLua.Get = "GetPlayerName({0})"
		/// @CSharpLua.Set = "SetPlayerName({0}, {1})"
		public extern string Name { get; set; }
		/// @CSharpLua.Get = "GetPlayerStartLocation({0})"
		/// @CSharpLua.Set = "SetPlayerStartLocation({0}, {1})"
		public extern int StartLocation { get; set; }
		/// @CSharpLua.Get = "GetPlayerTeam({0})"
		/// @CSharpLua.Set = "SetPlayerTeam({0}, {1})"
		public extern int Team { get; set; }
		/// @CSharpLua.Get = "GetPlayerController({0})"
		/// @CSharpLua.Set = "SetPlayerController({0}, {1})"
		public extern mapcontrol Controller { get; set; }
		/// @CSharpLua.Get = "GetPlayerHandicap({0})"
		/// @CSharpLua.Set = "SetPlayerHandicap({0}, {1})"
		public extern float Handicap { get; set; }
		/// @CSharpLua.Get = "GetPlayerHandicapXP({0})"
		/// @CSharpLua.Set = "SetPlayerHandicapXP({0}, {1})"
		public extern float HandicapXp { get; set; }
		/// @CSharpLua.Get = "GetPlayerHandicapReviveTime({0})"
		/// @CSharpLua.Set = "SetPlayerHandicapReviveTime({0}, {1})"
		public extern float HandicapReviveTime { get; set; }
		/// @CSharpLua.Get = "GetPlayerHandicapDamage({0})"
		/// @CSharpLua.Set = "SetPlayerHandicapDamage({0}, {1})"
		public extern float HandicapDamage { get; set; }

		/// @CSharpLua.Get = "GetPlayerId({0})"
		public extern int Id { get; }
		/// @CSharpLua.Get = "GetPlayerRace({0})"
		public extern race Race { get; }
		/// @CSharpLua.Get = "GetPlayerSlotState({0})"
		public extern playerslotstate SlotState { get; }
		/// @CSharpLua.Get = "GetPlayerSelectable({0})"
		public extern bool Selectable { get; }
		/// @CSharpLua.Get = "IsPlayerObserver({0})"
		public extern bool IsObserver { get; }
		/// @CSharpLua.Get = "BlzGetPlayerTownHallCount({0})"
		public extern int TownHallCount { get; }

		/// @CSharpLua.Get = "GetPlayerState({0}, PLAYER_STATE_GAME_RESULT)"
		/// @CSharpLua.Set = "SetPlayerState({0}, PLAYER_STATE_GAME_RESULT, {1})"
		public extern int GameResult { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({0}, PLAYER_STATE_RESOURCE_GOLD)"
		/// @CSharpLua.Set = "SetPlayerState({0}, PLAYER_STATE_RESOURCE_GOLD, {1})"
		public extern int Gold { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({0}, PLAYER_STATE_RESOURCE_LUMBER)"
		/// @CSharpLua.Set = "SetPlayerState({0}, PLAYER_STATE_RESOURCE_LUMBER, {1})"
		public extern int Lumber { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({0}, PLAYER_STATE_RESOURCE_HERO_TOKENS)"
		/// @CSharpLua.Set = "SetPlayerState({0}, PLAYER_STATE_RESOURCE_HERO_TOKENS, {1})"
		public extern int HeroTokens { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({0}, PLAYER_STATE_RESOURCE_FOOD_CAP)"
		/// @CSharpLua.Set = "SetPlayerState({0}, PLAYER_STATE_RESOURCE_FOOD_CAP, {1})"
		public extern int FoodCap { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({0}, PLAYER_STATE_RESOURCE_FOOD_USED)"
		/// @CSharpLua.Set = "SetPlayerState({0}, PLAYER_STATE_RESOURCE_FOOD_USED, {1})"
		public extern int FoodUsed { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({0}, PLAYER_STATE_FOOD_CAP_CEILING)"
		/// @CSharpLua.Set = "SetPlayerState({0}, PLAYER_STATE_FOOD_CAP_CEILING, {1})"
		public extern int FoodCapCeiling { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({0}, PLAYER_STATE_GOLD_UPKEEP_RATE)"
		/// @CSharpLua.Set = "SetPlayerState({0}, PLAYER_STATE_GOLD_UPKEEP_RATE, {1})"
		public extern int GoldUpkeepRate { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({0}, PLAYER_STATE_LUMBER_UPKEEP_RATE)"
		/// @CSharpLua.Set = "SetPlayerState({0}, PLAYER_STATE_LUMBER_UPKEEP_RATE, {1})"
		public extern int LumberUpkeepRate { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({0}, PLAYER_STATE_GOLD_GATHERED)"
		/// @CSharpLua.Set = "SetPlayerState({0}, PLAYER_STATE_GOLD_GATHERED, {1})"
		public extern int GoldGathered { get; set; }
		/// @CSharpLua.Get = "GetPlayerState({0}, PLAYER_STATE_LUMBER_GATHERED)"
		/// @CSharpLua.Set = "SetPlayerState({0}, PLAYER_STATE_LUMBER_GATHERED, {1})"
		public extern int LumberGathered { get; set; }

		/// @CSharpLua.Template = "GetPlayerState({0}, {1})"
		public extern int GetState(playerstate playerState);
		/// @CSharpLua.Template = "SetPlayerState({0}, {1}, {2})"
		public extern void SetState(playerstate playerState, int value);

		/// @CSharpLua.Template = "GetPlayerTaxRate({0}, {1}, PLAYER_STATE_RESOURCE_GOLD)"
		public extern int GetGoldTaxRate(player otherPlayer);
		/// @CSharpLua.Template = "SetPlayerTaxRate({0}, {1}, PLAYER_STATE_RESOURCE_GOLD, {2})"
		public extern void SetGoldTaxRate(player otherPlayer, int percent);

		/// @CSharpLua.Template = "GetPlayerTaxRate({0}, {1}, PLAYER_STATE_RESOURCE_LUMBER)"
		public extern int GetLumberTaxRate(player otherPlayer);
		/// @CSharpLua.Template = "SetPlayerTaxRate({0}, {1}, PLAYER_STATE_RESOURCE_LUMBER, {2})"
		public extern void SetLumberTaxRate(player otherPlayer, int percent);

		/// @CSharpLua.Template = "GetPlayerAlliance({0}, {1}, {2})"
		public extern bool GetAlliance(player otherPlayer, alliancetype allianceType);
		/// @CSharpLua.Template = "SetPlayerAlliance({0}, {1}, {2}, {3})"
		public extern void SetAlliance(player otherPlayer, alliancetype allianceType, bool value);

		/// @CSharpLua.Template = "GetPlayerTechMaxAllowed({0}, {1})"
		public extern int GetTechMaxAllowed(int techId);
		/// @CSharpLua.Template = "SetPlayerTechMaxAllowed({0}, {1}, {2})"
		public extern void SetTechMaxAllowed(int techId, int maximum);

		/// @CSharpLua.Template = "GetPlayerTechResearched({0}, {1})"
		public extern int GetTechResearched(int techId, bool specificOnly = true);
		/// @CSharpLua.Template = "SetPlayerTechResearched({0}, {1})"
		public extern int SetTechResearched(int techId, int level);
		/// @CSharpLua.Template = "AddPlayerTechResearched({0}, {1}, {2})"
		public extern int IncreaseTechResearched(int techId, int levels = 1);
		/// @CSharpLua.Template = "BlzDecPlayerTechResearched({0}, {1}, {2})"
		public extern int DecreaseTechResearched(int techId, int levels = 1);

		/// @CSharpLua.Template = "GetPlayerTechCount({0}, {1}, {2})"
		public extern int GetTechCount(int techId, bool specificOnly = true);
		/// @CSharpLua.Template = "GetPlayerUnitCount({0}, {1})"
		public extern int GetUnitCount(bool includeIncomplete = false);
		/// @CSharpLua.Template = "GetPlayerTypedUnitCount({0}, {1}, {2}, {3})"
		public extern int GetUnitCount(string unitType, bool includeIncomplete = false, bool includeUpgrades = false);
		/// @CSharpLua.Template = "GetPlayerStructureCount({0}, {1})"
		public extern int GetStructureCount(bool includeIncomplete = false);

		/// @CSharpLua.Template = "IsPlayerRacePrefSet({0}, {1})"
		public extern void IsRacePreference(racepreference racepreference);
		/// @CSharpLua.Template = "IsPlayerAlly({0}, {1})"
		public extern bool IsAlly(player otherPlayer);
		/// @CSharpLua.Template = "IsPlayerEnemy({0}, {1})"
		public extern bool IsEnemy(player otherPlayer);
		/// @CSharpLua.Template = "IsVisibleToPlayer({0}, {1}, {2})"
		public extern bool IsVisible(float x, float y);
		/// @CSharpLua.Template = "IsFoggedToPlayer({0}, {1}, {2})"
		public extern bool IsFogged(float x, float y);
		/// @CSharpLua.Template = "IsMaskedToPlayer({0}, {1}, {2})"
		public extern bool IsMasked(float x, float y);

		/// @CSharpLua.Template = "SetPlayerRaceSelectable({0}, {1})"
		public extern void SetRaceSelectable(bool raceSelectable);
		/// @CSharpLua.Template = "SetPlayerRacePreference({0}, {1})"
		public extern void SetRacePreference(racepreference racePreference);
		/// @CSharpLua.Template = "SetPlayerAbilityAvailable({0}, {1}, {2})"
		public extern void SetAbilityAvailable(int abilityId, bool available);

		/// @CSharpLua.Template = "IssueNeutralImmediateOrder({0}, {2}, {1})"
		public extern bool IssueNeutralImmediateOrder(string order, unit neutralStructure);
		/// @CSharpLua.Template = "IssueNeutralImmediateOrderById({0}, {2}, {1})"
		public extern bool IssueNeutralImmediateOrder(int order, unit neutralStructure);
		/// @CSharpLua.Template = "IssueNeutralPointOrder({0}, {2}, {1}, {3}, {4})"
		public extern bool IssueNeutralPointOrder(string order, unit neutralStructure, float x, float y);
		/// @CSharpLua.Template = "IssueNeutralPointOrderById({0}, {2}, {1}, {3}, {4})"
		public extern bool IssueNeutralPointOrder(int order, unit neutralStructure, float x, float y);
		/// @CSharpLua.Template = "IssueNeutralTargetOrder({0}, {2}, {1}, {3})"
		public extern bool IssueNeutralTargetOrder(string order, unit neutralStructure, widget target);
		/// @CSharpLua.Template = "IssueNeutralTargetOrderById({0}, {2}, {1}, {3})"
		public extern bool IssueNeutralTargetOrder(int order, unit neutralStructure, widget target);

		/// @CSharpLua.Template = "ForcePlayerStartLocation({0}, {1})"
		public extern void ForceStartLocation(int startLocation);
		/// @CSharpLua.Template = "SetPlayerUnitsOwner({0}, {1})"
		public extern void SetUnitsOwner(int newOwnerPlayerId);
		/// @CSharpLua.Template = "CripplePlayer({0}, {1}, {2})"
		public extern void Cripple(force toForce, bool value);
		/// @CSharpLua.Template = "RemovePlayer({0}, {1})"
		public extern void Remove(playergameresult gameResult);
		/// @CSharpLua.Template = "CachePlayerHeroData({0})"
		public extern void CacheHeroData();

		/// @CSharpLua.Template = "DisplayTextToPlayer({0}, {2}, {3}, {1})"
		public extern void DisplayTextTo(string message, float x = 0, float y = 0);
		/// @CSharpLua.Template = "DisplayTextToPlayer({0}, {2}, {3}, {1})"
		public extern void DisplayTimedTextTo(string message, float duration, float x = 0, float y = 0);
		/// @CSharpLua.Template = "DisplayTextToPlayer({0}, {2}, {3}, {1})"
		public extern void DisplayTimedTextFrom(string message, float duration, float x = 0, float y = 0);
	}
}
