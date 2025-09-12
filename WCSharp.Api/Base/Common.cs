using System;
using WCSharp.Api.Enums;

namespace WCSharp.Api
{
#pragma warning disable IDE1006 // Naming Styles
	/// @CSharpLua.Ignore
	public static partial class Common
	{
		/// @CSharpLua.Template = "ConvertRace({0})"
		public static extern race ConvertRace(int i);
		/// @CSharpLua.Template = "ConvertAllianceType({0})"
		public static extern alliancetype ConvertAllianceType(int i);
		/// @CSharpLua.Template = "ConvertRacePref({0})"
		public static extern racepreference ConvertRacePref(int i);
		/// @CSharpLua.Template = "ConvertIGameState({0})"
		public static extern igamestate ConvertIGameState(int i);
		/// @CSharpLua.Template = "ConvertFGameState({0})"
		public static extern fgamestate ConvertFGameState(int i);
		/// @CSharpLua.Template = "ConvertPlayerState({0})"
		public static extern playerstate ConvertPlayerState(int i);
		/// @CSharpLua.Template = "ConvertPlayerScore({0})"
		public static extern playerscore ConvertPlayerScore(int i);
		/// @CSharpLua.Template = "ConvertPlayerGameResult({0})"
		public static extern playergameresult ConvertPlayerGameResult(int i);
		/// @CSharpLua.Template = "ConvertUnitState({0})"
		public static extern unitstate ConvertUnitState(int i);
		/// @CSharpLua.Template = "ConvertAIDifficulty({0})"
		public static extern aidifficulty ConvertAIDifficulty(int i);
		/// @CSharpLua.Template = "ConvertGameEvent({0})"
		public static extern gameevent ConvertGameEvent(int i);
		/// @CSharpLua.Template = "ConvertPlayerEvent({0})"
		public static extern playerevent ConvertPlayerEvent(int i);
		/// @CSharpLua.Template = "ConvertPlayerUnitEvent({0})"
		public static extern playerunitevent ConvertPlayerUnitEvent(int i);
		/// @CSharpLua.Template = "ConvertWidgetEvent({0})"
		public static extern widgetevent ConvertWidgetEvent(int i);
		/// @CSharpLua.Template = "ConvertDialogEvent({0})"
		public static extern dialogevent ConvertDialogEvent(int i);
		/// @CSharpLua.Template = "ConvertUnitEvent({0})"
		public static extern unitevent ConvertUnitEvent(int i);
		/// @CSharpLua.Template = "ConvertLimitOp({0})"
		public static extern limitop ConvertLimitOp(int i);
		/// @CSharpLua.Template = "ConvertUnitType({0})"
		public static extern unittype ConvertUnitType(int i);
		/// @CSharpLua.Template = "ConvertGameSpeed({0})"
		public static extern gamespeed ConvertGameSpeed(int i);
		/// @CSharpLua.Template = "ConvertPlacement({0})"
		public static extern placement ConvertPlacement(int i);
		/// @CSharpLua.Template = "ConvertStartLocPrio({0})"
		public static extern startlocprio ConvertStartLocPrio(int i);
		/// @CSharpLua.Template = "ConvertGameDifficulty({0})"
		public static extern gamedifficulty ConvertGameDifficulty(int i);
		/// @CSharpLua.Template = "ConvertGameType({0})"
		public static extern gametype ConvertGameType(int i);
		/// @CSharpLua.Template = "ConvertMapFlag({0})"
		public static extern mapflag ConvertMapFlag(int i);
		/// @CSharpLua.Template = "ConvertMapVisibility({0})"
		public static extern mapvisibility ConvertMapVisibility(int i);
		/// @CSharpLua.Template = "ConvertMapSetting({0})"
		public static extern mapsetting ConvertMapSetting(int i);
		/// @CSharpLua.Template = "ConvertMapDensity({0})"
		public static extern mapdensity ConvertMapDensity(int i);
		/// @CSharpLua.Template = "ConvertMapControl({0})"
		public static extern mapcontrol ConvertMapControl(int i);
		/// @CSharpLua.Template = "ConvertPlayerColor({0})"
		public static extern playercolor ConvertPlayerColor(int i);
		/// @CSharpLua.Template = "ConvertPlayerSlotState({0})"
		public static extern playerslotstate ConvertPlayerSlotState(int i);
		/// @CSharpLua.Template = "ConvertVolumeGroup({0})"
		public static extern volumegroup ConvertVolumeGroup(int i);
		/// @CSharpLua.Template = "ConvertCameraField({0})"
		public static extern camerafield ConvertCameraField(int i);
		/// @CSharpLua.Template = "ConvertBlendMode({0})"
		public static extern blendmode ConvertBlendMode(int i);
		/// @CSharpLua.Template = "ConvertRarityControl({0})"
		public static extern raritycontrol ConvertRarityControl(int i);
		/// @CSharpLua.Template = "ConvertTexMapFlags({0})"
		public static extern texmapflags ConvertTexMapFlags(int i);
		/// @CSharpLua.Template = "ConvertFogState({0})"
		public static extern fogstate ConvertFogState(int i);
		/// @CSharpLua.Template = "ConvertEffectType({0})"
		public static extern effecttype ConvertEffectType(int i);
		/// @CSharpLua.Template = "ConvertVersion({0})"
		public static extern version ConvertVersion(int i);
		/// @CSharpLua.Template = "ConvertItemType({0})"
		public static extern itemtype ConvertItemType(int i);
		/// @CSharpLua.Template = "ConvertAttackType({0})"
		public static extern attacktype ConvertAttackType(AttackType attackType);
		/// @CSharpLua.Template = "ConvertDamageType({0})"
		public static extern damagetype ConvertDamageType(int i);
		/// @CSharpLua.Template = "ConvertWeaponType({0})"
		public static extern weapontype ConvertWeaponType(int i);
		/// @CSharpLua.Template = "ConvertSoundType({0})"
		public static extern soundtype ConvertSoundType(int i);
		/// @CSharpLua.Template = "ConvertPathingType({0})"
		public static extern pathingtype ConvertPathingType(int i);
		/// @CSharpLua.Template = "ConvertMouseButtonType({0})"
		public static extern mousebuttontype ConvertMouseButtonType(int i);
		/// @CSharpLua.Template = "ConvertAnimType({0})"
		public static extern animtype ConvertAnimType(int i);
		/// @CSharpLua.Template = "ConvertSubAnimType({0})"
		public static extern subanimtype ConvertSubAnimType(int i);
		/// @CSharpLua.Template = "ConvertOriginFrameType({0})"
		public static extern originframetype ConvertOriginFrameType(int i);
		/// @CSharpLua.Template = "ConvertFramePointType({0})"
		public static extern framepointtype ConvertFramePointType(int i);
		/// @CSharpLua.Template = "ConvertTextAlignType({0})"
		public static extern textaligntype ConvertTextAlignType(int i);
		/// @CSharpLua.Template = "ConvertFrameEventType({0})"
		public static extern frameeventtype ConvertFrameEventType(int i);
		/// @CSharpLua.Template = "ConvertOsKeyType({0})"
		public static extern oskeytype ConvertOsKeyType(int i);
		/// @CSharpLua.Template = "ConvertAbilityIntegerField({0})"
		public static extern abilityintegerfield ConvertAbilityIntegerField(int i);
		/// @CSharpLua.Template = "ConvertAbilityRealField({0})"
		public static extern abilityrealfield ConvertAbilityRealField(int i);
		/// @CSharpLua.Template = "ConvertAbilityBooleanField({0})"
		public static extern abilitybooleanfield ConvertAbilityBooleanField(int i);
		/// @CSharpLua.Template = "ConvertAbilityStringField({0})"
		public static extern abilitystringfield ConvertAbilityStringField(int i);
		/// @CSharpLua.Template = "ConvertAbilityIntegerLevelField({0})"
		public static extern abilityintegerlevelfield ConvertAbilityIntegerLevelField(int i);
		/// @CSharpLua.Template = "ConvertAbilityRealLevelField({0})"
		public static extern abilityreallevelfield ConvertAbilityRealLevelField(int i);
		/// @CSharpLua.Template = "ConvertAbilityBooleanLevelField({0})"
		public static extern abilitybooleanlevelfield ConvertAbilityBooleanLevelField(int i);
		/// @CSharpLua.Template = "ConvertAbilityStringLevelField({0})"
		public static extern abilitystringlevelfield ConvertAbilityStringLevelField(int i);
		/// @CSharpLua.Template = "ConvertAbilityIntegerLevelArrayField({0})"
		public static extern abilityintegerlevelarrayfield ConvertAbilityIntegerLevelArrayField(int i);
		/// @CSharpLua.Template = "ConvertAbilityRealLevelArrayField({0})"
		public static extern abilityreallevelarrayfield ConvertAbilityRealLevelArrayField(int i);
		/// @CSharpLua.Template = "ConvertAbilityBooleanLevelArrayField({0})"
		public static extern abilitybooleanlevelarrayfield ConvertAbilityBooleanLevelArrayField(int i);
		/// @CSharpLua.Template = "ConvertAbilityStringLevelArrayField({0})"
		public static extern abilitystringlevelarrayfield ConvertAbilityStringLevelArrayField(int i);
		/// @CSharpLua.Template = "ConvertUnitIntegerField({0})"
		public static extern unitintegerfield ConvertUnitIntegerField(int i);
		/// @CSharpLua.Template = "ConvertUnitRealField({0})"
		public static extern unitrealfield ConvertUnitRealField(int i);
		/// @CSharpLua.Template = "ConvertUnitBooleanField({0})"
		public static extern unitbooleanfield ConvertUnitBooleanField(int i);
		/// @CSharpLua.Template = "ConvertUnitStringField({0})"
		public static extern unitstringfield ConvertUnitStringField(int i);
		/// @CSharpLua.Template = "ConvertUnitWeaponIntegerField({0})"
		public static extern unitweaponintegerfield ConvertUnitWeaponIntegerField(int i);
		/// @CSharpLua.Template = "ConvertUnitWeaponRealField({0})"
		public static extern unitweaponrealfield ConvertUnitWeaponRealField(int i);
		/// @CSharpLua.Template = "ConvertUnitWeaponBooleanField({0})"
		public static extern unitweaponbooleanfield ConvertUnitWeaponBooleanField(int i);
		/// @CSharpLua.Template = "ConvertUnitWeaponStringField({0})"
		public static extern unitweaponstringfield ConvertUnitWeaponStringField(int i);
		/// @CSharpLua.Template = "ConvertItemIntegerField({0})"
		public static extern itemintegerfield ConvertItemIntegerField(int i);
		/// @CSharpLua.Template = "ConvertItemRealField({0})"
		public static extern itemrealfield ConvertItemRealField(int i);
		/// @CSharpLua.Template = "ConvertItemBooleanField({0})"
		public static extern itembooleanfield ConvertItemBooleanField(int i);
		/// @CSharpLua.Template = "ConvertItemStringField({0})"
		public static extern itemstringfield ConvertItemStringField(int i);
		/// @CSharpLua.Template = "ConvertMoveType({0})"
		public static extern movetype ConvertMoveType(int i);
		/// @CSharpLua.Template = "ConvertTargetFlag({0})"
		public static extern targetflag ConvertTargetFlag(int i);
		/// @CSharpLua.Template = "ConvertArmorType({0})"
		public static extern armortype ConvertArmorType(int i);
		/// @CSharpLua.Template = "ConvertHeroAttribute({0})"
		public static extern heroattribute ConvertHeroAttribute(int i);
		/// @CSharpLua.Template = "ConvertDefenseType({0})"
		public static extern defensetype ConvertDefenseType(int i);
		/// @CSharpLua.Template = "ConvertRegenType({0})"
		public static extern regentype ConvertRegenType(int i);
		/// @CSharpLua.Template = "ConvertUnitCategory({0})"
		public static extern unitcategory ConvertUnitCategory(int i);
		/// @CSharpLua.Template = "ConvertPathingFlag({0})"
		public static extern pathingflag ConvertPathingFlag(int i);
		/// @CSharpLua.Template = "OrderId({0})"
		public static extern int OrderId(string orderIdString);
		/// @CSharpLua.Template = "OrderId2String({0})"
		public static extern string OrderId2String(int orderId);
		/// @CSharpLua.Template = "UnitId({0})"
		public static extern int UnitId(string unitIdString);
		/// @CSharpLua.Template = "UnitId2String({0})"
		public static extern string UnitId2String(int unitId);
		/// @CSharpLua.Template = "AbilityId({0})"
		public static extern int AbilityId(string abilityIdString);
		/// @CSharpLua.Template = "AbilityId2String({0})"
		public static extern string AbilityId2String(int abilityId);
		/// @CSharpLua.Template = "GetObjectName({0})"
		public static extern string GetObjectName(int objectId);
		/// @CSharpLua.Template = "GetBJMaxPlayers()"
		public static extern int GetBJMaxPlayers();
		/// @CSharpLua.Template = "GetBJPlayerNeutralVictim()"
		public static extern int GetBJPlayerNeutralVictim();
		/// @CSharpLua.Template = "GetBJPlayerNeutralExtra()"
		public static extern int GetBJPlayerNeutralExtra();
		/// @CSharpLua.Template = "GetBJMaxPlayerSlots()"
		public static extern int GetBJMaxPlayerSlots();
		/// @CSharpLua.Template = "GetPlayerNeutralPassive()"
		public static extern int GetPlayerNeutralPassive();
		/// @CSharpLua.Template = "GetPlayerNeutralAggressive()"
		public static extern int GetPlayerNeutralAggressive();
		/// @CSharpLua.Template = "FALSE"
		public const bool FALSE = false;
		/// @CSharpLua.Template = "TRUE"
		public const bool TRUE = true;
		/// @CSharpLua.Template = "JASS_MAX_ARRAY_SIZE"
		public const int JASS_MAX_ARRAY_SIZE = 32768;
		/// @CSharpLua.Template = "PLAYER_NEUTRAL_PASSIVE"
		public static readonly int PLAYER_NEUTRAL_PASSIVE = GetPlayerNeutralPassive();
		/// @CSharpLua.Template = "PLAYER_NEUTRAL_AGGRESSIVE"
		public static readonly int PLAYER_NEUTRAL_AGGRESSIVE = GetPlayerNeutralAggressive();
		/// @CSharpLua.Template = "PLAYER_COLOR_RED"
		public static readonly playercolor PLAYER_COLOR_RED = ConvertPlayerColor(0);
		/// @CSharpLua.Template = "PLAYER_COLOR_BLUE"
		public static readonly playercolor PLAYER_COLOR_BLUE = ConvertPlayerColor(1);
		/// @CSharpLua.Template = "PLAYER_COLOR_CYAN"
		public static readonly playercolor PLAYER_COLOR_CYAN = ConvertPlayerColor(2);
		/// @CSharpLua.Template = "PLAYER_COLOR_PURPLE"
		public static readonly playercolor PLAYER_COLOR_PURPLE = ConvertPlayerColor(3);
		/// @CSharpLua.Template = "PLAYER_COLOR_YELLOW"
		public static readonly playercolor PLAYER_COLOR_YELLOW = ConvertPlayerColor(4);
		/// @CSharpLua.Template = "PLAYER_COLOR_ORANGE"
		public static readonly playercolor PLAYER_COLOR_ORANGE = ConvertPlayerColor(5);
		/// @CSharpLua.Template = "PLAYER_COLOR_GREEN"
		public static readonly playercolor PLAYER_COLOR_GREEN = ConvertPlayerColor(6);
		/// @CSharpLua.Template = "PLAYER_COLOR_PINK"
		public static readonly playercolor PLAYER_COLOR_PINK = ConvertPlayerColor(7);
		/// @CSharpLua.Template = "PLAYER_COLOR_LIGHT_GRAY"
		public static readonly playercolor PLAYER_COLOR_LIGHT_GRAY = ConvertPlayerColor(8);
		/// @CSharpLua.Template = "PLAYER_COLOR_LIGHT_BLUE"
		public static readonly playercolor PLAYER_COLOR_LIGHT_BLUE = ConvertPlayerColor(9);
		/// @CSharpLua.Template = "PLAYER_COLOR_AQUA"
		public static readonly playercolor PLAYER_COLOR_AQUA = ConvertPlayerColor(10);
		/// @CSharpLua.Template = "PLAYER_COLOR_BROWN"
		public static readonly playercolor PLAYER_COLOR_BROWN = ConvertPlayerColor(11);
		/// @CSharpLua.Template = "PLAYER_COLOR_MAROON"
		public static readonly playercolor PLAYER_COLOR_MAROON = ConvertPlayerColor(12);
		/// @CSharpLua.Template = "PLAYER_COLOR_NAVY"
		public static readonly playercolor PLAYER_COLOR_NAVY = ConvertPlayerColor(13);
		/// @CSharpLua.Template = "PLAYER_COLOR_TURQUOISE"
		public static readonly playercolor PLAYER_COLOR_TURQUOISE = ConvertPlayerColor(14);
		/// @CSharpLua.Template = "PLAYER_COLOR_VIOLET"
		public static readonly playercolor PLAYER_COLOR_VIOLET = ConvertPlayerColor(15);
		/// @CSharpLua.Template = "PLAYER_COLOR_WHEAT"
		public static readonly playercolor PLAYER_COLOR_WHEAT = ConvertPlayerColor(16);
		/// @CSharpLua.Template = "PLAYER_COLOR_PEACH"
		public static readonly playercolor PLAYER_COLOR_PEACH = ConvertPlayerColor(17);
		/// @CSharpLua.Template = "PLAYER_COLOR_MINT"
		public static readonly playercolor PLAYER_COLOR_MINT = ConvertPlayerColor(18);
		/// @CSharpLua.Template = "PLAYER_COLOR_LAVENDER"
		public static readonly playercolor PLAYER_COLOR_LAVENDER = ConvertPlayerColor(19);
		/// @CSharpLua.Template = "PLAYER_COLOR_COAL"
		public static readonly playercolor PLAYER_COLOR_COAL = ConvertPlayerColor(20);
		/// @CSharpLua.Template = "PLAYER_COLOR_SNOW"
		public static readonly playercolor PLAYER_COLOR_SNOW = ConvertPlayerColor(21);
		/// @CSharpLua.Template = "PLAYER_COLOR_EMERALD"
		public static readonly playercolor PLAYER_COLOR_EMERALD = ConvertPlayerColor(22);
		/// @CSharpLua.Template = "PLAYER_COLOR_PEANUT"
		public static readonly playercolor PLAYER_COLOR_PEANUT = ConvertPlayerColor(23);
		/// @CSharpLua.Template = "RACE_HUMAN"
		public static readonly race RACE_HUMAN = ConvertRace(1);
		/// @CSharpLua.Template = "RACE_ORC"
		public static readonly race RACE_ORC = ConvertRace(2);
		/// @CSharpLua.Template = "RACE_UNDEAD"
		public static readonly race RACE_UNDEAD = ConvertRace(3);
		/// @CSharpLua.Template = "RACE_NIGHTELF"
		public static readonly race RACE_NIGHTELF = ConvertRace(4);
		/// @CSharpLua.Template = "RACE_DEMON"
		public static readonly race RACE_DEMON = ConvertRace(5);
		/// @CSharpLua.Template = "RACE_OTHER"
		public static readonly race RACE_OTHER = ConvertRace(7);
		/// @CSharpLua.Template = "PLAYER_GAME_RESULT_VICTORY"
		public static readonly playergameresult PLAYER_GAME_RESULT_VICTORY = ConvertPlayerGameResult(0);
		/// @CSharpLua.Template = "PLAYER_GAME_RESULT_DEFEAT"
		public static readonly playergameresult PLAYER_GAME_RESULT_DEFEAT = ConvertPlayerGameResult(1);
		/// @CSharpLua.Template = "PLAYER_GAME_RESULT_TIE"
		public static readonly playergameresult PLAYER_GAME_RESULT_TIE = ConvertPlayerGameResult(2);
		/// @CSharpLua.Template = "PLAYER_GAME_RESULT_NEUTRAL"
		public static readonly playergameresult PLAYER_GAME_RESULT_NEUTRAL = ConvertPlayerGameResult(3);
		/// @CSharpLua.Template = "ALLIANCE_PASSIVE"
		public static readonly alliancetype ALLIANCE_PASSIVE = ConvertAllianceType(0);
		/// @CSharpLua.Template = "ALLIANCE_HELP_REQUEST"
		public static readonly alliancetype ALLIANCE_HELP_REQUEST = ConvertAllianceType(1);
		/// @CSharpLua.Template = "ALLIANCE_HELP_RESPONSE"
		public static readonly alliancetype ALLIANCE_HELP_RESPONSE = ConvertAllianceType(2);
		/// @CSharpLua.Template = "ALLIANCE_SHARED_XP"
		public static readonly alliancetype ALLIANCE_SHARED_XP = ConvertAllianceType(3);
		/// @CSharpLua.Template = "ALLIANCE_SHARED_SPELLS"
		public static readonly alliancetype ALLIANCE_SHARED_SPELLS = ConvertAllianceType(4);
		/// @CSharpLua.Template = "ALLIANCE_SHARED_VISION"
		public static readonly alliancetype ALLIANCE_SHARED_VISION = ConvertAllianceType(5);
		/// @CSharpLua.Template = "ALLIANCE_SHARED_CONTROL"
		public static readonly alliancetype ALLIANCE_SHARED_CONTROL = ConvertAllianceType(6);
		/// @CSharpLua.Template = "ALLIANCE_SHARED_ADVANCED_CONTROL"
		public static readonly alliancetype ALLIANCE_SHARED_ADVANCED_CONTROL = ConvertAllianceType(7);
		/// @CSharpLua.Template = "ALLIANCE_RESCUABLE"
		public static readonly alliancetype ALLIANCE_RESCUABLE = ConvertAllianceType(8);
		/// @CSharpLua.Template = "ALLIANCE_SHARED_VISION_FORCED"
		public static readonly alliancetype ALLIANCE_SHARED_VISION_FORCED = ConvertAllianceType(9);
		/// @CSharpLua.Template = "VERSION_REIGN_OF_CHAOS"
		public static readonly version VERSION_REIGN_OF_CHAOS = ConvertVersion(0);
		/// @CSharpLua.Template = "VERSION_FROZEN_THRONE"
		public static readonly version VERSION_FROZEN_THRONE = ConvertVersion(1);
		/// @CSharpLua.Template = "ATTACK_TYPE_NORMAL"
		public static readonly attacktype ATTACK_TYPE_NORMAL = ConvertAttackType(AttackType.Normal);
		/// @CSharpLua.Template = "ATTACK_TYPE_MELEE"
		public static readonly attacktype ATTACK_TYPE_MELEE = ConvertAttackType(AttackType.Melee);
		/// @CSharpLua.Template = "ATTACK_TYPE_PIERCE"
		public static readonly attacktype ATTACK_TYPE_PIERCE = ConvertAttackType(AttackType.Pierce);
		/// @CSharpLua.Template = "ATTACK_TYPE_SIEGE"
		public static readonly attacktype ATTACK_TYPE_SIEGE = ConvertAttackType(AttackType.Siege);
		/// @CSharpLua.Template = "ATTACK_TYPE_MAGIC"
		public static readonly attacktype ATTACK_TYPE_MAGIC = ConvertAttackType(AttackType.Magic);
		/// @CSharpLua.Template = "ATTACK_TYPE_CHAOS"
		public static readonly attacktype ATTACK_TYPE_CHAOS = ConvertAttackType(AttackType.Chaos);
		/// @CSharpLua.Template = "ATTACK_TYPE_HERO"
		public static readonly attacktype ATTACK_TYPE_HERO = ConvertAttackType(AttackType.Hero);
		/// @CSharpLua.Template = "DAMAGE_TYPE_UNKNOWN"
		public static readonly damagetype DAMAGE_TYPE_UNKNOWN = ConvertDamageType(0);
		/// @CSharpLua.Template = "DAMAGE_TYPE_NORMAL"
		public static readonly damagetype DAMAGE_TYPE_NORMAL = ConvertDamageType(4);
		/// @CSharpLua.Template = "DAMAGE_TYPE_ENHANCED"
		public static readonly damagetype DAMAGE_TYPE_ENHANCED = ConvertDamageType(5);
		/// @CSharpLua.Template = "DAMAGE_TYPE_FIRE"
		public static readonly damagetype DAMAGE_TYPE_FIRE = ConvertDamageType(8);
		/// @CSharpLua.Template = "DAMAGE_TYPE_COLD"
		public static readonly damagetype DAMAGE_TYPE_COLD = ConvertDamageType(9);
		/// @CSharpLua.Template = "DAMAGE_TYPE_LIGHTNING"
		public static readonly damagetype DAMAGE_TYPE_LIGHTNING = ConvertDamageType(10);
		/// @CSharpLua.Template = "DAMAGE_TYPE_POISON"
		public static readonly damagetype DAMAGE_TYPE_POISON = ConvertDamageType(11);
		/// @CSharpLua.Template = "DAMAGE_TYPE_DISEASE"
		public static readonly damagetype DAMAGE_TYPE_DISEASE = ConvertDamageType(12);
		/// @CSharpLua.Template = "DAMAGE_TYPE_DIVINE"
		public static readonly damagetype DAMAGE_TYPE_DIVINE = ConvertDamageType(13);
		/// @CSharpLua.Template = "DAMAGE_TYPE_MAGIC"
		public static readonly damagetype DAMAGE_TYPE_MAGIC = ConvertDamageType(14);
		/// @CSharpLua.Template = "DAMAGE_TYPE_SONIC"
		public static readonly damagetype DAMAGE_TYPE_SONIC = ConvertDamageType(15);
		/// @CSharpLua.Template = "DAMAGE_TYPE_ACID"
		public static readonly damagetype DAMAGE_TYPE_ACID = ConvertDamageType(16);
		/// @CSharpLua.Template = "DAMAGE_TYPE_FORCE"
		public static readonly damagetype DAMAGE_TYPE_FORCE = ConvertDamageType(17);
		/// @CSharpLua.Template = "DAMAGE_TYPE_DEATH"
		public static readonly damagetype DAMAGE_TYPE_DEATH = ConvertDamageType(18);
		/// @CSharpLua.Template = "DAMAGE_TYPE_MIND"
		public static readonly damagetype DAMAGE_TYPE_MIND = ConvertDamageType(19);
		/// @CSharpLua.Template = "DAMAGE_TYPE_PLANT"
		public static readonly damagetype DAMAGE_TYPE_PLANT = ConvertDamageType(20);
		/// @CSharpLua.Template = "DAMAGE_TYPE_DEFENSIVE"
		public static readonly damagetype DAMAGE_TYPE_DEFENSIVE = ConvertDamageType(21);
		/// @CSharpLua.Template = "DAMAGE_TYPE_DEMOLITION"
		public static readonly damagetype DAMAGE_TYPE_DEMOLITION = ConvertDamageType(22);
		/// @CSharpLua.Template = "DAMAGE_TYPE_SLOW_POISON"
		public static readonly damagetype DAMAGE_TYPE_SLOW_POISON = ConvertDamageType(23);
		/// @CSharpLua.Template = "DAMAGE_TYPE_SPIRIT_LINK"
		public static readonly damagetype DAMAGE_TYPE_SPIRIT_LINK = ConvertDamageType(24);
		/// @CSharpLua.Template = "DAMAGE_TYPE_SHADOW_STRIKE"
		public static readonly damagetype DAMAGE_TYPE_SHADOW_STRIKE = ConvertDamageType(25);
		/// @CSharpLua.Template = "DAMAGE_TYPE_UNIVERSAL"
		public static readonly damagetype DAMAGE_TYPE_UNIVERSAL = ConvertDamageType(26);
		/// @CSharpLua.Template = "WEAPON_TYPE_WHOKNOWS"
		public static readonly weapontype WEAPON_TYPE_WHOKNOWS = ConvertWeaponType(0);
		/// @CSharpLua.Template = "WEAPON_TYPE_METAL_LIGHT_CHOP"
		public static readonly weapontype WEAPON_TYPE_METAL_LIGHT_CHOP = ConvertWeaponType(1);
		/// @CSharpLua.Template = "WEAPON_TYPE_METAL_MEDIUM_CHOP"
		public static readonly weapontype WEAPON_TYPE_METAL_MEDIUM_CHOP = ConvertWeaponType(2);
		/// @CSharpLua.Template = "WEAPON_TYPE_METAL_HEAVY_CHOP"
		public static readonly weapontype WEAPON_TYPE_METAL_HEAVY_CHOP = ConvertWeaponType(3);
		/// @CSharpLua.Template = "WEAPON_TYPE_METAL_LIGHT_SLICE"
		public static readonly weapontype WEAPON_TYPE_METAL_LIGHT_SLICE = ConvertWeaponType(4);
		/// @CSharpLua.Template = "WEAPON_TYPE_METAL_MEDIUM_SLICE"
		public static readonly weapontype WEAPON_TYPE_METAL_MEDIUM_SLICE = ConvertWeaponType(5);
		/// @CSharpLua.Template = "WEAPON_TYPE_METAL_HEAVY_SLICE"
		public static readonly weapontype WEAPON_TYPE_METAL_HEAVY_SLICE = ConvertWeaponType(6);
		/// @CSharpLua.Template = "WEAPON_TYPE_METAL_MEDIUM_BASH"
		public static readonly weapontype WEAPON_TYPE_METAL_MEDIUM_BASH = ConvertWeaponType(7);
		/// @CSharpLua.Template = "WEAPON_TYPE_METAL_HEAVY_BASH"
		public static readonly weapontype WEAPON_TYPE_METAL_HEAVY_BASH = ConvertWeaponType(8);
		/// @CSharpLua.Template = "WEAPON_TYPE_METAL_MEDIUM_STAB"
		public static readonly weapontype WEAPON_TYPE_METAL_MEDIUM_STAB = ConvertWeaponType(9);
		/// @CSharpLua.Template = "WEAPON_TYPE_METAL_HEAVY_STAB"
		public static readonly weapontype WEAPON_TYPE_METAL_HEAVY_STAB = ConvertWeaponType(10);
		/// @CSharpLua.Template = "WEAPON_TYPE_WOOD_LIGHT_SLICE"
		public static readonly weapontype WEAPON_TYPE_WOOD_LIGHT_SLICE = ConvertWeaponType(11);
		/// @CSharpLua.Template = "WEAPON_TYPE_WOOD_MEDIUM_SLICE"
		public static readonly weapontype WEAPON_TYPE_WOOD_MEDIUM_SLICE = ConvertWeaponType(12);
		/// @CSharpLua.Template = "WEAPON_TYPE_WOOD_HEAVY_SLICE"
		public static readonly weapontype WEAPON_TYPE_WOOD_HEAVY_SLICE = ConvertWeaponType(13);
		/// @CSharpLua.Template = "WEAPON_TYPE_WOOD_LIGHT_BASH"
		public static readonly weapontype WEAPON_TYPE_WOOD_LIGHT_BASH = ConvertWeaponType(14);
		/// @CSharpLua.Template = "WEAPON_TYPE_WOOD_MEDIUM_BASH"
		public static readonly weapontype WEAPON_TYPE_WOOD_MEDIUM_BASH = ConvertWeaponType(15);
		/// @CSharpLua.Template = "WEAPON_TYPE_WOOD_HEAVY_BASH"
		public static readonly weapontype WEAPON_TYPE_WOOD_HEAVY_BASH = ConvertWeaponType(16);
		/// @CSharpLua.Template = "WEAPON_TYPE_WOOD_LIGHT_STAB"
		public static readonly weapontype WEAPON_TYPE_WOOD_LIGHT_STAB = ConvertWeaponType(17);
		/// @CSharpLua.Template = "WEAPON_TYPE_WOOD_MEDIUM_STAB"
		public static readonly weapontype WEAPON_TYPE_WOOD_MEDIUM_STAB = ConvertWeaponType(18);
		/// @CSharpLua.Template = "WEAPON_TYPE_CLAW_LIGHT_SLICE"
		public static readonly weapontype WEAPON_TYPE_CLAW_LIGHT_SLICE = ConvertWeaponType(19);
		/// @CSharpLua.Template = "WEAPON_TYPE_CLAW_MEDIUM_SLICE"
		public static readonly weapontype WEAPON_TYPE_CLAW_MEDIUM_SLICE = ConvertWeaponType(20);
		/// @CSharpLua.Template = "WEAPON_TYPE_CLAW_HEAVY_SLICE"
		public static readonly weapontype WEAPON_TYPE_CLAW_HEAVY_SLICE = ConvertWeaponType(21);
		/// @CSharpLua.Template = "WEAPON_TYPE_AXE_MEDIUM_CHOP"
		public static readonly weapontype WEAPON_TYPE_AXE_MEDIUM_CHOP = ConvertWeaponType(22);
		/// @CSharpLua.Template = "WEAPON_TYPE_ROCK_HEAVY_BASH"
		public static readonly weapontype WEAPON_TYPE_ROCK_HEAVY_BASH = ConvertWeaponType(23);
		/// @CSharpLua.Template = "PATHING_TYPE_ANY"
		public static readonly pathingtype PATHING_TYPE_ANY = ConvertPathingType(0);
		/// @CSharpLua.Template = "PATHING_TYPE_WALKABILITY"
		public static readonly pathingtype PATHING_TYPE_WALKABILITY = ConvertPathingType(1);
		/// @CSharpLua.Template = "PATHING_TYPE_FLYABILITY"
		public static readonly pathingtype PATHING_TYPE_FLYABILITY = ConvertPathingType(2);
		/// @CSharpLua.Template = "PATHING_TYPE_BUILDABILITY"
		public static readonly pathingtype PATHING_TYPE_BUILDABILITY = ConvertPathingType(3);
		/// @CSharpLua.Template = "PATHING_TYPE_PEONHARVESTPATHING"
		public static readonly pathingtype PATHING_TYPE_PEONHARVESTPATHING = ConvertPathingType(4);
		/// @CSharpLua.Template = "PATHING_TYPE_BLIGHTPATHING"
		public static readonly pathingtype PATHING_TYPE_BLIGHTPATHING = ConvertPathingType(5);
		/// @CSharpLua.Template = "PATHING_TYPE_FLOATABILITY"
		public static readonly pathingtype PATHING_TYPE_FLOATABILITY = ConvertPathingType(6);
		/// @CSharpLua.Template = "PATHING_TYPE_AMPHIBIOUSPATHING"
		public static readonly pathingtype PATHING_TYPE_AMPHIBIOUSPATHING = ConvertPathingType(7);
		/// @CSharpLua.Template = "MOUSE_BUTTON_TYPE_LEFT"
		public static readonly mousebuttontype MOUSE_BUTTON_TYPE_LEFT = ConvertMouseButtonType(1);
		/// @CSharpLua.Template = "MOUSE_BUTTON_TYPE_MIDDLE"
		public static readonly mousebuttontype MOUSE_BUTTON_TYPE_MIDDLE = ConvertMouseButtonType(2);
		/// @CSharpLua.Template = "MOUSE_BUTTON_TYPE_RIGHT"
		public static readonly mousebuttontype MOUSE_BUTTON_TYPE_RIGHT = ConvertMouseButtonType(3);
		/// @CSharpLua.Template = "ANIM_TYPE_BIRTH"
		public static readonly animtype ANIM_TYPE_BIRTH = ConvertAnimType(0);
		/// @CSharpLua.Template = "ANIM_TYPE_DEATH"
		public static readonly animtype ANIM_TYPE_DEATH = ConvertAnimType(1);
		/// @CSharpLua.Template = "ANIM_TYPE_DECAY"
		public static readonly animtype ANIM_TYPE_DECAY = ConvertAnimType(2);
		/// @CSharpLua.Template = "ANIM_TYPE_DISSIPATE"
		public static readonly animtype ANIM_TYPE_DISSIPATE = ConvertAnimType(3);
		/// @CSharpLua.Template = "ANIM_TYPE_STAND"
		public static readonly animtype ANIM_TYPE_STAND = ConvertAnimType(4);
		/// @CSharpLua.Template = "ANIM_TYPE_WALK"
		public static readonly animtype ANIM_TYPE_WALK = ConvertAnimType(5);
		/// @CSharpLua.Template = "ANIM_TYPE_ATTACK"
		public static readonly animtype ANIM_TYPE_ATTACK = ConvertAnimType(6);
		/// @CSharpLua.Template = "ANIM_TYPE_MORPH"
		public static readonly animtype ANIM_TYPE_MORPH = ConvertAnimType(7);
		/// @CSharpLua.Template = "ANIM_TYPE_SLEEP"
		public static readonly animtype ANIM_TYPE_SLEEP = ConvertAnimType(8);
		/// @CSharpLua.Template = "ANIM_TYPE_SPELL"
		public static readonly animtype ANIM_TYPE_SPELL = ConvertAnimType(9);
		/// @CSharpLua.Template = "ANIM_TYPE_PORTRAIT"
		public static readonly animtype ANIM_TYPE_PORTRAIT = ConvertAnimType(10);
		/// @CSharpLua.Template = "SUBANIM_TYPE_ROOTED"
		public static readonly subanimtype SUBANIM_TYPE_ROOTED = ConvertSubAnimType(11);
		/// @CSharpLua.Template = "SUBANIM_TYPE_ALTERNATE_EX"
		public static readonly subanimtype SUBANIM_TYPE_ALTERNATE_EX = ConvertSubAnimType(12);
		/// @CSharpLua.Template = "SUBANIM_TYPE_LOOPING"
		public static readonly subanimtype SUBANIM_TYPE_LOOPING = ConvertSubAnimType(13);
		/// @CSharpLua.Template = "SUBANIM_TYPE_SLAM"
		public static readonly subanimtype SUBANIM_TYPE_SLAM = ConvertSubAnimType(14);
		/// @CSharpLua.Template = "SUBANIM_TYPE_THROW"
		public static readonly subanimtype SUBANIM_TYPE_THROW = ConvertSubAnimType(15);
		/// @CSharpLua.Template = "SUBANIM_TYPE_SPIKED"
		public static readonly subanimtype SUBANIM_TYPE_SPIKED = ConvertSubAnimType(16);
		/// @CSharpLua.Template = "SUBANIM_TYPE_FAST"
		public static readonly subanimtype SUBANIM_TYPE_FAST = ConvertSubAnimType(17);
		/// @CSharpLua.Template = "SUBANIM_TYPE_SPIN"
		public static readonly subanimtype SUBANIM_TYPE_SPIN = ConvertSubAnimType(18);
		/// @CSharpLua.Template = "SUBANIM_TYPE_READY"
		public static readonly subanimtype SUBANIM_TYPE_READY = ConvertSubAnimType(19);
		/// @CSharpLua.Template = "SUBANIM_TYPE_CHANNEL"
		public static readonly subanimtype SUBANIM_TYPE_CHANNEL = ConvertSubAnimType(20);
		/// @CSharpLua.Template = "SUBANIM_TYPE_DEFEND"
		public static readonly subanimtype SUBANIM_TYPE_DEFEND = ConvertSubAnimType(21);
		/// @CSharpLua.Template = "SUBANIM_TYPE_VICTORY"
		public static readonly subanimtype SUBANIM_TYPE_VICTORY = ConvertSubAnimType(22);
		/// @CSharpLua.Template = "SUBANIM_TYPE_TURN"
		public static readonly subanimtype SUBANIM_TYPE_TURN = ConvertSubAnimType(23);
		/// @CSharpLua.Template = "SUBANIM_TYPE_LEFT"
		public static readonly subanimtype SUBANIM_TYPE_LEFT = ConvertSubAnimType(24);
		/// @CSharpLua.Template = "SUBANIM_TYPE_RIGHT"
		public static readonly subanimtype SUBANIM_TYPE_RIGHT = ConvertSubAnimType(25);
		/// @CSharpLua.Template = "SUBANIM_TYPE_FIRE"
		public static readonly subanimtype SUBANIM_TYPE_FIRE = ConvertSubAnimType(26);
		/// @CSharpLua.Template = "SUBANIM_TYPE_FLESH"
		public static readonly subanimtype SUBANIM_TYPE_FLESH = ConvertSubAnimType(27);
		/// @CSharpLua.Template = "SUBANIM_TYPE_HIT"
		public static readonly subanimtype SUBANIM_TYPE_HIT = ConvertSubAnimType(28);
		/// @CSharpLua.Template = "SUBANIM_TYPE_WOUNDED"
		public static readonly subanimtype SUBANIM_TYPE_WOUNDED = ConvertSubAnimType(29);
		/// @CSharpLua.Template = "SUBANIM_TYPE_LIGHT"
		public static readonly subanimtype SUBANIM_TYPE_LIGHT = ConvertSubAnimType(30);
		/// @CSharpLua.Template = "SUBANIM_TYPE_MODERATE"
		public static readonly subanimtype SUBANIM_TYPE_MODERATE = ConvertSubAnimType(31);
		/// @CSharpLua.Template = "SUBANIM_TYPE_SEVERE"
		public static readonly subanimtype SUBANIM_TYPE_SEVERE = ConvertSubAnimType(32);
		/// @CSharpLua.Template = "SUBANIM_TYPE_CRITICAL"
		public static readonly subanimtype SUBANIM_TYPE_CRITICAL = ConvertSubAnimType(33);
		/// @CSharpLua.Template = "SUBANIM_TYPE_COMPLETE"
		public static readonly subanimtype SUBANIM_TYPE_COMPLETE = ConvertSubAnimType(34);
		/// @CSharpLua.Template = "SUBANIM_TYPE_GOLD"
		public static readonly subanimtype SUBANIM_TYPE_GOLD = ConvertSubAnimType(35);
		/// @CSharpLua.Template = "SUBANIM_TYPE_LUMBER"
		public static readonly subanimtype SUBANIM_TYPE_LUMBER = ConvertSubAnimType(36);
		/// @CSharpLua.Template = "SUBANIM_TYPE_WORK"
		public static readonly subanimtype SUBANIM_TYPE_WORK = ConvertSubAnimType(37);
		/// @CSharpLua.Template = "SUBANIM_TYPE_TALK"
		public static readonly subanimtype SUBANIM_TYPE_TALK = ConvertSubAnimType(38);
		/// @CSharpLua.Template = "SUBANIM_TYPE_FIRST"
		public static readonly subanimtype SUBANIM_TYPE_FIRST = ConvertSubAnimType(39);
		/// @CSharpLua.Template = "SUBANIM_TYPE_SECOND"
		public static readonly subanimtype SUBANIM_TYPE_SECOND = ConvertSubAnimType(40);
		/// @CSharpLua.Template = "SUBANIM_TYPE_THIRD"
		public static readonly subanimtype SUBANIM_TYPE_THIRD = ConvertSubAnimType(41);
		/// @CSharpLua.Template = "SUBANIM_TYPE_FOURTH"
		public static readonly subanimtype SUBANIM_TYPE_FOURTH = ConvertSubAnimType(42);
		/// @CSharpLua.Template = "SUBANIM_TYPE_FIFTH"
		public static readonly subanimtype SUBANIM_TYPE_FIFTH = ConvertSubAnimType(43);
		/// @CSharpLua.Template = "SUBANIM_TYPE_ONE"
		public static readonly subanimtype SUBANIM_TYPE_ONE = ConvertSubAnimType(44);
		/// @CSharpLua.Template = "SUBANIM_TYPE_TWO"
		public static readonly subanimtype SUBANIM_TYPE_TWO = ConvertSubAnimType(45);
		/// @CSharpLua.Template = "SUBANIM_TYPE_THREE"
		public static readonly subanimtype SUBANIM_TYPE_THREE = ConvertSubAnimType(46);
		/// @CSharpLua.Template = "SUBANIM_TYPE_FOUR"
		public static readonly subanimtype SUBANIM_TYPE_FOUR = ConvertSubAnimType(47);
		/// @CSharpLua.Template = "SUBANIM_TYPE_FIVE"
		public static readonly subanimtype SUBANIM_TYPE_FIVE = ConvertSubAnimType(48);
		/// @CSharpLua.Template = "SUBANIM_TYPE_SMALL"
		public static readonly subanimtype SUBANIM_TYPE_SMALL = ConvertSubAnimType(49);
		/// @CSharpLua.Template = "SUBANIM_TYPE_MEDIUM"
		public static readonly subanimtype SUBANIM_TYPE_MEDIUM = ConvertSubAnimType(50);
		/// @CSharpLua.Template = "SUBANIM_TYPE_LARGE"
		public static readonly subanimtype SUBANIM_TYPE_LARGE = ConvertSubAnimType(51);
		/// @CSharpLua.Template = "SUBANIM_TYPE_UPGRADE"
		public static readonly subanimtype SUBANIM_TYPE_UPGRADE = ConvertSubAnimType(52);
		/// @CSharpLua.Template = "SUBANIM_TYPE_DRAIN"
		public static readonly subanimtype SUBANIM_TYPE_DRAIN = ConvertSubAnimType(53);
		/// @CSharpLua.Template = "SUBANIM_TYPE_FILL"
		public static readonly subanimtype SUBANIM_TYPE_FILL = ConvertSubAnimType(54);
		/// @CSharpLua.Template = "SUBANIM_TYPE_CHAINLIGHTNING"
		public static readonly subanimtype SUBANIM_TYPE_CHAINLIGHTNING = ConvertSubAnimType(55);
		/// @CSharpLua.Template = "SUBANIM_TYPE_EATTREE"
		public static readonly subanimtype SUBANIM_TYPE_EATTREE = ConvertSubAnimType(56);
		/// @CSharpLua.Template = "SUBANIM_TYPE_PUKE"
		public static readonly subanimtype SUBANIM_TYPE_PUKE = ConvertSubAnimType(57);
		/// @CSharpLua.Template = "SUBANIM_TYPE_FLAIL"
		public static readonly subanimtype SUBANIM_TYPE_FLAIL = ConvertSubAnimType(58);
		/// @CSharpLua.Template = "SUBANIM_TYPE_OFF"
		public static readonly subanimtype SUBANIM_TYPE_OFF = ConvertSubAnimType(59);
		/// @CSharpLua.Template = "SUBANIM_TYPE_SWIM"
		public static readonly subanimtype SUBANIM_TYPE_SWIM = ConvertSubAnimType(60);
		/// @CSharpLua.Template = "SUBANIM_TYPE_ENTANGLE"
		public static readonly subanimtype SUBANIM_TYPE_ENTANGLE = ConvertSubAnimType(61);
		/// @CSharpLua.Template = "SUBANIM_TYPE_BERSERK"
		public static readonly subanimtype SUBANIM_TYPE_BERSERK = ConvertSubAnimType(62);
		/// @CSharpLua.Template = "RACE_PREF_HUMAN"
		public static readonly racepreference RACE_PREF_HUMAN = ConvertRacePref(1);
		/// @CSharpLua.Template = "RACE_PREF_ORC"
		public static readonly racepreference RACE_PREF_ORC = ConvertRacePref(2);
		/// @CSharpLua.Template = "RACE_PREF_NIGHTELF"
		public static readonly racepreference RACE_PREF_NIGHTELF = ConvertRacePref(4);
		/// @CSharpLua.Template = "RACE_PREF_UNDEAD"
		public static readonly racepreference RACE_PREF_UNDEAD = ConvertRacePref(8);
		/// @CSharpLua.Template = "RACE_PREF_DEMON"
		public static readonly racepreference RACE_PREF_DEMON = ConvertRacePref(16);
		/// @CSharpLua.Template = "RACE_PREF_RANDOM"
		public static readonly racepreference RACE_PREF_RANDOM = ConvertRacePref(32);
		/// @CSharpLua.Template = "RACE_PREF_USER_SELECTABLE"
		public static readonly racepreference RACE_PREF_USER_SELECTABLE = ConvertRacePref(64);
		/// @CSharpLua.Template = "MAP_CONTROL_USER"
		public static readonly mapcontrol MAP_CONTROL_USER = ConvertMapControl(0);
		/// @CSharpLua.Template = "MAP_CONTROL_COMPUTER"
		public static readonly mapcontrol MAP_CONTROL_COMPUTER = ConvertMapControl(1);
		/// @CSharpLua.Template = "MAP_CONTROL_RESCUABLE"
		public static readonly mapcontrol MAP_CONTROL_RESCUABLE = ConvertMapControl(2);
		/// @CSharpLua.Template = "MAP_CONTROL_NEUTRAL"
		public static readonly mapcontrol MAP_CONTROL_NEUTRAL = ConvertMapControl(3);
		/// @CSharpLua.Template = "MAP_CONTROL_CREEP"
		public static readonly mapcontrol MAP_CONTROL_CREEP = ConvertMapControl(4);
		/// @CSharpLua.Template = "MAP_CONTROL_NONE"
		public static readonly mapcontrol MAP_CONTROL_NONE = ConvertMapControl(5);
		/// @CSharpLua.Template = "GAME_TYPE_MELEE"
		public static readonly gametype GAME_TYPE_MELEE = ConvertGameType(1);
		/// @CSharpLua.Template = "GAME_TYPE_FFA"
		public static readonly gametype GAME_TYPE_FFA = ConvertGameType(2);
		/// @CSharpLua.Template = "GAME_TYPE_USE_MAP_SETTINGS"
		public static readonly gametype GAME_TYPE_USE_MAP_SETTINGS = ConvertGameType(4);
		/// @CSharpLua.Template = "GAME_TYPE_BLIZ"
		public static readonly gametype GAME_TYPE_BLIZ = ConvertGameType(8);
		/// @CSharpLua.Template = "GAME_TYPE_ONE_ON_ONE"
		public static readonly gametype GAME_TYPE_ONE_ON_ONE = ConvertGameType(16);
		/// @CSharpLua.Template = "GAME_TYPE_TWO_TEAM_PLAY"
		public static readonly gametype GAME_TYPE_TWO_TEAM_PLAY = ConvertGameType(32);
		/// @CSharpLua.Template = "GAME_TYPE_THREE_TEAM_PLAY"
		public static readonly gametype GAME_TYPE_THREE_TEAM_PLAY = ConvertGameType(64);
		/// @CSharpLua.Template = "GAME_TYPE_FOUR_TEAM_PLAY"
		public static readonly gametype GAME_TYPE_FOUR_TEAM_PLAY = ConvertGameType(128);
		/// @CSharpLua.Template = "MAP_FOG_HIDE_TERRAIN"
		public static readonly mapflag MAP_FOG_HIDE_TERRAIN = ConvertMapFlag(1);
		/// @CSharpLua.Template = "MAP_FOG_MAP_EXPLORED"
		public static readonly mapflag MAP_FOG_MAP_EXPLORED = ConvertMapFlag(2);
		/// @CSharpLua.Template = "MAP_FOG_ALWAYS_VISIBLE"
		public static readonly mapflag MAP_FOG_ALWAYS_VISIBLE = ConvertMapFlag(4);
		/// @CSharpLua.Template = "MAP_USE_HANDICAPS"
		public static readonly mapflag MAP_USE_HANDICAPS = ConvertMapFlag(8);
		/// @CSharpLua.Template = "MAP_OBSERVERS"
		public static readonly mapflag MAP_OBSERVERS = ConvertMapFlag(16);
		/// @CSharpLua.Template = "MAP_OBSERVERS_ON_DEATH"
		public static readonly mapflag MAP_OBSERVERS_ON_DEATH = ConvertMapFlag(32);
		/// @CSharpLua.Template = "MAP_FIXED_COLORS"
		public static readonly mapflag MAP_FIXED_COLORS = ConvertMapFlag(128);
		/// @CSharpLua.Template = "MAP_LOCK_RESOURCE_TRADING"
		public static readonly mapflag MAP_LOCK_RESOURCE_TRADING = ConvertMapFlag(256);
		/// @CSharpLua.Template = "MAP_RESOURCE_TRADING_ALLIES_ONLY"
		public static readonly mapflag MAP_RESOURCE_TRADING_ALLIES_ONLY = ConvertMapFlag(512);
		/// @CSharpLua.Template = "MAP_LOCK_ALLIANCE_CHANGES"
		public static readonly mapflag MAP_LOCK_ALLIANCE_CHANGES = ConvertMapFlag(1024);
		/// @CSharpLua.Template = "MAP_ALLIANCE_CHANGES_HIDDEN"
		public static readonly mapflag MAP_ALLIANCE_CHANGES_HIDDEN = ConvertMapFlag(2048);
		/// @CSharpLua.Template = "MAP_CHEATS"
		public static readonly mapflag MAP_CHEATS = ConvertMapFlag(4096);
		/// @CSharpLua.Template = "MAP_CHEATS_HIDDEN"
		public static readonly mapflag MAP_CHEATS_HIDDEN = ConvertMapFlag(8192);
		/// @CSharpLua.Template = "MAP_LOCK_SPEED"
		public static readonly mapflag MAP_LOCK_SPEED = ConvertMapFlag(8192 * 2);
		/// @CSharpLua.Template = "MAP_LOCK_RANDOM_SEED"
		public static readonly mapflag MAP_LOCK_RANDOM_SEED = ConvertMapFlag(8192 * 4);
		/// @CSharpLua.Template = "MAP_SHARED_ADVANCED_CONTROL"
		public static readonly mapflag MAP_SHARED_ADVANCED_CONTROL = ConvertMapFlag(8192 * 8);
		/// @CSharpLua.Template = "MAP_RANDOM_HERO"
		public static readonly mapflag MAP_RANDOM_HERO = ConvertMapFlag(8192 * 16);
		/// @CSharpLua.Template = "MAP_RANDOM_RACES"
		public static readonly mapflag MAP_RANDOM_RACES = ConvertMapFlag(8192 * 32);
		/// @CSharpLua.Template = "MAP_RELOADED"
		public static readonly mapflag MAP_RELOADED = ConvertMapFlag(8192 * 64);
		/// @CSharpLua.Template = "MAP_PLACEMENT_RANDOM"
		public static readonly placement MAP_PLACEMENT_RANDOM = ConvertPlacement(0);
		/// @CSharpLua.Template = "MAP_PLACEMENT_FIXED"
		public static readonly placement MAP_PLACEMENT_FIXED = ConvertPlacement(1);
		/// @CSharpLua.Template = "MAP_PLACEMENT_USE_MAP_SETTINGS"
		public static readonly placement MAP_PLACEMENT_USE_MAP_SETTINGS = ConvertPlacement(2);
		/// @CSharpLua.Template = "MAP_PLACEMENT_TEAMS_TOGETHER"
		public static readonly placement MAP_PLACEMENT_TEAMS_TOGETHER = ConvertPlacement(3);
		/// @CSharpLua.Template = "MAP_LOC_PRIO_LOW"
		public static readonly startlocprio MAP_LOC_PRIO_LOW = ConvertStartLocPrio(0);
		/// @CSharpLua.Template = "MAP_LOC_PRIO_HIGH"
		public static readonly startlocprio MAP_LOC_PRIO_HIGH = ConvertStartLocPrio(1);
		/// @CSharpLua.Template = "MAP_LOC_PRIO_NOT"
		public static readonly startlocprio MAP_LOC_PRIO_NOT = ConvertStartLocPrio(2);
		/// @CSharpLua.Template = "MAP_DENSITY_NONE"
		public static readonly mapdensity MAP_DENSITY_NONE = ConvertMapDensity(0);
		/// @CSharpLua.Template = "MAP_DENSITY_LIGHT"
		public static readonly mapdensity MAP_DENSITY_LIGHT = ConvertMapDensity(1);
		/// @CSharpLua.Template = "MAP_DENSITY_MEDIUM"
		public static readonly mapdensity MAP_DENSITY_MEDIUM = ConvertMapDensity(2);
		/// @CSharpLua.Template = "MAP_DENSITY_HEAVY"
		public static readonly mapdensity MAP_DENSITY_HEAVY = ConvertMapDensity(3);
		/// @CSharpLua.Template = "MAP_DIFFICULTY_EASY"
		public static readonly gamedifficulty MAP_DIFFICULTY_EASY = ConvertGameDifficulty(0);
		/// @CSharpLua.Template = "MAP_DIFFICULTY_NORMAL"
		public static readonly gamedifficulty MAP_DIFFICULTY_NORMAL = ConvertGameDifficulty(1);
		/// @CSharpLua.Template = "MAP_DIFFICULTY_HARD"
		public static readonly gamedifficulty MAP_DIFFICULTY_HARD = ConvertGameDifficulty(2);
		/// @CSharpLua.Template = "MAP_DIFFICULTY_INSANE"
		public static readonly gamedifficulty MAP_DIFFICULTY_INSANE = ConvertGameDifficulty(3);
		/// @CSharpLua.Template = "MAP_SPEED_SLOWEST"
		public static readonly gamespeed MAP_SPEED_SLOWEST = ConvertGameSpeed(0);
		/// @CSharpLua.Template = "MAP_SPEED_SLOW"
		public static readonly gamespeed MAP_SPEED_SLOW = ConvertGameSpeed(1);
		/// @CSharpLua.Template = "MAP_SPEED_NORMAL"
		public static readonly gamespeed MAP_SPEED_NORMAL = ConvertGameSpeed(2);
		/// @CSharpLua.Template = "MAP_SPEED_FAST"
		public static readonly gamespeed MAP_SPEED_FAST = ConvertGameSpeed(3);
		/// @CSharpLua.Template = "MAP_SPEED_FASTEST"
		public static readonly gamespeed MAP_SPEED_FASTEST = ConvertGameSpeed(4);
		/// @CSharpLua.Template = "PLAYER_SLOT_STATE_EMPTY"
		public static readonly playerslotstate PLAYER_SLOT_STATE_EMPTY = ConvertPlayerSlotState(0);
		/// @CSharpLua.Template = "PLAYER_SLOT_STATE_PLAYING"
		public static readonly playerslotstate PLAYER_SLOT_STATE_PLAYING = ConvertPlayerSlotState(1);
		/// @CSharpLua.Template = "PLAYER_SLOT_STATE_LEFT"
		public static readonly playerslotstate PLAYER_SLOT_STATE_LEFT = ConvertPlayerSlotState(2);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_UNITMOVEMENT"
		public static readonly volumegroup SOUND_VOLUMEGROUP_UNITMOVEMENT = ConvertVolumeGroup(0);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_UNITSOUNDS"
		public static readonly volumegroup SOUND_VOLUMEGROUP_UNITSOUNDS = ConvertVolumeGroup(1);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_COMBAT"
		public static readonly volumegroup SOUND_VOLUMEGROUP_COMBAT = ConvertVolumeGroup(2);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_SPELLS"
		public static readonly volumegroup SOUND_VOLUMEGROUP_SPELLS = ConvertVolumeGroup(3);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_UI"
		public static readonly volumegroup SOUND_VOLUMEGROUP_UI = ConvertVolumeGroup(4);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_MUSIC"
		public static readonly volumegroup SOUND_VOLUMEGROUP_MUSIC = ConvertVolumeGroup(5);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_AMBIENTSOUNDS"
		public static readonly volumegroup SOUND_VOLUMEGROUP_AMBIENTSOUNDS = ConvertVolumeGroup(6);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_FIRE"
		public static readonly volumegroup SOUND_VOLUMEGROUP_FIRE = ConvertVolumeGroup(7);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_CINEMATIC_GENERAL"
		public static readonly volumegroup SOUND_VOLUMEGROUP_CINEMATIC_GENERAL = ConvertVolumeGroup(8);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_CINEMATIC_AMBIENT"
		public static readonly volumegroup SOUND_VOLUMEGROUP_CINEMATIC_AMBIENT = ConvertVolumeGroup(9);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_CINEMATIC_MUSIC"
		public static readonly volumegroup SOUND_VOLUMEGROUP_CINEMATIC_MUSIC = ConvertVolumeGroup(10);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_CINEMATIC_DIALOGUE"
		public static readonly volumegroup SOUND_VOLUMEGROUP_CINEMATIC_DIALOGUE = ConvertVolumeGroup(11);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_CINEMATIC_SOUND_EFFECTS_1"
		public static readonly volumegroup SOUND_VOLUMEGROUP_CINEMATIC_SOUND_EFFECTS_1 = ConvertVolumeGroup(12);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_CINEMATIC_SOUND_EFFECTS_2"
		public static readonly volumegroup SOUND_VOLUMEGROUP_CINEMATIC_SOUND_EFFECTS_2 = ConvertVolumeGroup(13);
		/// @CSharpLua.Template = "SOUND_VOLUMEGROUP_CINEMATIC_SOUND_EFFECTS_3"
		public static readonly volumegroup SOUND_VOLUMEGROUP_CINEMATIC_SOUND_EFFECTS_3 = ConvertVolumeGroup(14);
		/// @CSharpLua.Template = "GAME_STATE_DIVINE_INTERVENTION"
		public static readonly igamestate GAME_STATE_DIVINE_INTERVENTION = ConvertIGameState(0);
		/// @CSharpLua.Template = "GAME_STATE_DISCONNECTED"
		public static readonly igamestate GAME_STATE_DISCONNECTED = ConvertIGameState(1);
		/// @CSharpLua.Template = "GAME_STATE_TIME_OF_DAY"
		public static readonly fgamestate GAME_STATE_TIME_OF_DAY = ConvertFGameState(2);
		/// @CSharpLua.Template = "PLAYER_STATE_GAME_RESULT"
		public static readonly playerstate PLAYER_STATE_GAME_RESULT = ConvertPlayerState(0);
		/// @CSharpLua.Template = "PLAYER_STATE_RESOURCE_GOLD"
		public static readonly playerstate PLAYER_STATE_RESOURCE_GOLD = ConvertPlayerState(1);
		/// @CSharpLua.Template = "PLAYER_STATE_RESOURCE_LUMBER"
		public static readonly playerstate PLAYER_STATE_RESOURCE_LUMBER = ConvertPlayerState(2);
		/// @CSharpLua.Template = "PLAYER_STATE_RESOURCE_HERO_TOKENS"
		public static readonly playerstate PLAYER_STATE_RESOURCE_HERO_TOKENS = ConvertPlayerState(3);
		/// @CSharpLua.Template = "PLAYER_STATE_RESOURCE_FOOD_CAP"
		public static readonly playerstate PLAYER_STATE_RESOURCE_FOOD_CAP = ConvertPlayerState(4);
		/// @CSharpLua.Template = "PLAYER_STATE_RESOURCE_FOOD_USED"
		public static readonly playerstate PLAYER_STATE_RESOURCE_FOOD_USED = ConvertPlayerState(5);
		/// @CSharpLua.Template = "PLAYER_STATE_FOOD_CAP_CEILING"
		public static readonly playerstate PLAYER_STATE_FOOD_CAP_CEILING = ConvertPlayerState(6);
		/// @CSharpLua.Template = "PLAYER_STATE_GIVES_BOUNTY"
		public static readonly playerstate PLAYER_STATE_GIVES_BOUNTY = ConvertPlayerState(7);
		/// @CSharpLua.Template = "PLAYER_STATE_ALLIED_VICTORY"
		public static readonly playerstate PLAYER_STATE_ALLIED_VICTORY = ConvertPlayerState(8);
		/// @CSharpLua.Template = "PLAYER_STATE_PLACED"
		public static readonly playerstate PLAYER_STATE_PLACED = ConvertPlayerState(9);
		/// @CSharpLua.Template = "PLAYER_STATE_OBSERVER_ON_DEATH"
		public static readonly playerstate PLAYER_STATE_OBSERVER_ON_DEATH = ConvertPlayerState(10);
		/// @CSharpLua.Template = "PLAYER_STATE_OBSERVER"
		public static readonly playerstate PLAYER_STATE_OBSERVER = ConvertPlayerState(11);
		/// @CSharpLua.Template = "PLAYER_STATE_UNFOLLOWABLE"
		public static readonly playerstate PLAYER_STATE_UNFOLLOWABLE = ConvertPlayerState(12);
		/// @CSharpLua.Template = "PLAYER_STATE_GOLD_UPKEEP_RATE"
		public static readonly playerstate PLAYER_STATE_GOLD_UPKEEP_RATE = ConvertPlayerState(13);
		/// @CSharpLua.Template = "PLAYER_STATE_LUMBER_UPKEEP_RATE"
		public static readonly playerstate PLAYER_STATE_LUMBER_UPKEEP_RATE = ConvertPlayerState(14);
		/// @CSharpLua.Template = "PLAYER_STATE_GOLD_GATHERED"
		public static readonly playerstate PLAYER_STATE_GOLD_GATHERED = ConvertPlayerState(15);
		/// @CSharpLua.Template = "PLAYER_STATE_LUMBER_GATHERED"
		public static readonly playerstate PLAYER_STATE_LUMBER_GATHERED = ConvertPlayerState(16);
		/// @CSharpLua.Template = "PLAYER_STATE_NO_CREEP_SLEEP"
		public static readonly playerstate PLAYER_STATE_NO_CREEP_SLEEP = ConvertPlayerState(25);
		/// @CSharpLua.Template = "UNIT_STATE_LIFE"
		public static readonly unitstate UNIT_STATE_LIFE = ConvertUnitState(0);
		/// @CSharpLua.Template = "UNIT_STATE_MAX_LIFE"
		public static readonly unitstate UNIT_STATE_MAX_LIFE = ConvertUnitState(1);
		/// @CSharpLua.Template = "UNIT_STATE_MANA"
		public static readonly unitstate UNIT_STATE_MANA = ConvertUnitState(2);
		/// @CSharpLua.Template = "UNIT_STATE_MAX_MANA"
		public static readonly unitstate UNIT_STATE_MAX_MANA = ConvertUnitState(3);
		/// @CSharpLua.Template = "AI_DIFFICULTY_NEWBIE"
		public static readonly aidifficulty AI_DIFFICULTY_NEWBIE = ConvertAIDifficulty(0);
		/// @CSharpLua.Template = "AI_DIFFICULTY_NORMAL"
		public static readonly aidifficulty AI_DIFFICULTY_NORMAL = ConvertAIDifficulty(1);
		/// @CSharpLua.Template = "AI_DIFFICULTY_INSANE"
		public static readonly aidifficulty AI_DIFFICULTY_INSANE = ConvertAIDifficulty(2);
		/// @CSharpLua.Template = "PLAYER_SCORE_UNITS_TRAINED"
		public static readonly playerscore PLAYER_SCORE_UNITS_TRAINED = ConvertPlayerScore(0);
		/// @CSharpLua.Template = "PLAYER_SCORE_UNITS_KILLED"
		public static readonly playerscore PLAYER_SCORE_UNITS_KILLED = ConvertPlayerScore(1);
		/// @CSharpLua.Template = "PLAYER_SCORE_STRUCT_BUILT"
		public static readonly playerscore PLAYER_SCORE_STRUCT_BUILT = ConvertPlayerScore(2);
		/// @CSharpLua.Template = "PLAYER_SCORE_STRUCT_RAZED"
		public static readonly playerscore PLAYER_SCORE_STRUCT_RAZED = ConvertPlayerScore(3);
		/// @CSharpLua.Template = "PLAYER_SCORE_TECH_PERCENT"
		public static readonly playerscore PLAYER_SCORE_TECH_PERCENT = ConvertPlayerScore(4);
		/// @CSharpLua.Template = "PLAYER_SCORE_FOOD_MAXPROD"
		public static readonly playerscore PLAYER_SCORE_FOOD_MAXPROD = ConvertPlayerScore(5);
		/// @CSharpLua.Template = "PLAYER_SCORE_FOOD_MAXUSED"
		public static readonly playerscore PLAYER_SCORE_FOOD_MAXUSED = ConvertPlayerScore(6);
		/// @CSharpLua.Template = "PLAYER_SCORE_HEROES_KILLED"
		public static readonly playerscore PLAYER_SCORE_HEROES_KILLED = ConvertPlayerScore(7);
		/// @CSharpLua.Template = "PLAYER_SCORE_ITEMS_GAINED"
		public static readonly playerscore PLAYER_SCORE_ITEMS_GAINED = ConvertPlayerScore(8);
		/// @CSharpLua.Template = "PLAYER_SCORE_MERCS_HIRED"
		public static readonly playerscore PLAYER_SCORE_MERCS_HIRED = ConvertPlayerScore(9);
		/// @CSharpLua.Template = "PLAYER_SCORE_GOLD_MINED_TOTAL"
		public static readonly playerscore PLAYER_SCORE_GOLD_MINED_TOTAL = ConvertPlayerScore(10);
		/// @CSharpLua.Template = "PLAYER_SCORE_GOLD_MINED_UPKEEP"
		public static readonly playerscore PLAYER_SCORE_GOLD_MINED_UPKEEP = ConvertPlayerScore(11);
		/// @CSharpLua.Template = "PLAYER_SCORE_GOLD_LOST_UPKEEP"
		public static readonly playerscore PLAYER_SCORE_GOLD_LOST_UPKEEP = ConvertPlayerScore(12);
		/// @CSharpLua.Template = "PLAYER_SCORE_GOLD_LOST_TAX"
		public static readonly playerscore PLAYER_SCORE_GOLD_LOST_TAX = ConvertPlayerScore(13);
		/// @CSharpLua.Template = "PLAYER_SCORE_GOLD_GIVEN"
		public static readonly playerscore PLAYER_SCORE_GOLD_GIVEN = ConvertPlayerScore(14);
		/// @CSharpLua.Template = "PLAYER_SCORE_GOLD_RECEIVED"
		public static readonly playerscore PLAYER_SCORE_GOLD_RECEIVED = ConvertPlayerScore(15);
		/// @CSharpLua.Template = "PLAYER_SCORE_LUMBER_TOTAL"
		public static readonly playerscore PLAYER_SCORE_LUMBER_TOTAL = ConvertPlayerScore(16);
		/// @CSharpLua.Template = "PLAYER_SCORE_LUMBER_LOST_UPKEEP"
		public static readonly playerscore PLAYER_SCORE_LUMBER_LOST_UPKEEP = ConvertPlayerScore(17);
		/// @CSharpLua.Template = "PLAYER_SCORE_LUMBER_LOST_TAX"
		public static readonly playerscore PLAYER_SCORE_LUMBER_LOST_TAX = ConvertPlayerScore(18);
		/// @CSharpLua.Template = "PLAYER_SCORE_LUMBER_GIVEN"
		public static readonly playerscore PLAYER_SCORE_LUMBER_GIVEN = ConvertPlayerScore(19);
		/// @CSharpLua.Template = "PLAYER_SCORE_LUMBER_RECEIVED"
		public static readonly playerscore PLAYER_SCORE_LUMBER_RECEIVED = ConvertPlayerScore(20);
		/// @CSharpLua.Template = "PLAYER_SCORE_UNIT_TOTAL"
		public static readonly playerscore PLAYER_SCORE_UNIT_TOTAL = ConvertPlayerScore(21);
		/// @CSharpLua.Template = "PLAYER_SCORE_HERO_TOTAL"
		public static readonly playerscore PLAYER_SCORE_HERO_TOTAL = ConvertPlayerScore(22);
		/// @CSharpLua.Template = "PLAYER_SCORE_RESOURCE_TOTAL"
		public static readonly playerscore PLAYER_SCORE_RESOURCE_TOTAL = ConvertPlayerScore(23);
		/// @CSharpLua.Template = "PLAYER_SCORE_TOTAL"
		public static readonly playerscore PLAYER_SCORE_TOTAL = ConvertPlayerScore(24);
		/// @CSharpLua.Template = "EVENT_GAME_VICTORY"
		public static readonly gameevent EVENT_GAME_VICTORY = ConvertGameEvent(0);
		/// @CSharpLua.Template = "EVENT_GAME_END_LEVEL"
		public static readonly gameevent EVENT_GAME_END_LEVEL = ConvertGameEvent(1);
		/// @CSharpLua.Template = "EVENT_GAME_VARIABLE_LIMIT"
		public static readonly gameevent EVENT_GAME_VARIABLE_LIMIT = ConvertGameEvent(2);
		/// @CSharpLua.Template = "EVENT_GAME_STATE_LIMIT"
		public static readonly gameevent EVENT_GAME_STATE_LIMIT = ConvertGameEvent(3);
		/// @CSharpLua.Template = "EVENT_GAME_TIMER_EXPIRED"
		public static readonly gameevent EVENT_GAME_TIMER_EXPIRED = ConvertGameEvent(4);
		/// @CSharpLua.Template = "EVENT_GAME_ENTER_REGION"
		public static readonly gameevent EVENT_GAME_ENTER_REGION = ConvertGameEvent(5);
		/// @CSharpLua.Template = "EVENT_GAME_LEAVE_REGION"
		public static readonly gameevent EVENT_GAME_LEAVE_REGION = ConvertGameEvent(6);
		/// @CSharpLua.Template = "EVENT_GAME_TRACKABLE_HIT"
		public static readonly gameevent EVENT_GAME_TRACKABLE_HIT = ConvertGameEvent(7);
		/// @CSharpLua.Template = "EVENT_GAME_TRACKABLE_TRACK"
		public static readonly gameevent EVENT_GAME_TRACKABLE_TRACK = ConvertGameEvent(8);
		/// @CSharpLua.Template = "EVENT_GAME_SHOW_SKILL"
		public static readonly gameevent EVENT_GAME_SHOW_SKILL = ConvertGameEvent(9);
		/// @CSharpLua.Template = "EVENT_GAME_BUILD_SUBMENU"
		public static readonly gameevent EVENT_GAME_BUILD_SUBMENU = ConvertGameEvent(10);
		/// @CSharpLua.Template = "EVENT_PLAYER_STATE_LIMIT"
		public static readonly playerevent EVENT_PLAYER_STATE_LIMIT = ConvertPlayerEvent(11);
		/// @CSharpLua.Template = "EVENT_PLAYER_ALLIANCE_CHANGED"
		public static readonly playerevent EVENT_PLAYER_ALLIANCE_CHANGED = ConvertPlayerEvent(12);
		/// @CSharpLua.Template = "EVENT_PLAYER_DEFEAT"
		public static readonly playerevent EVENT_PLAYER_DEFEAT = ConvertPlayerEvent(13);
		/// @CSharpLua.Template = "EVENT_PLAYER_VICTORY"
		public static readonly playerevent EVENT_PLAYER_VICTORY = ConvertPlayerEvent(14);
		/// @CSharpLua.Template = "EVENT_PLAYER_LEAVE"
		public static readonly playerevent EVENT_PLAYER_LEAVE = ConvertPlayerEvent(15);
		/// @CSharpLua.Template = "EVENT_PLAYER_CHAT"
		public static readonly playerevent EVENT_PLAYER_CHAT = ConvertPlayerEvent(16);
		/// @CSharpLua.Template = "EVENT_PLAYER_END_CINEMATIC"
		public static readonly playerevent EVENT_PLAYER_END_CINEMATIC = ConvertPlayerEvent(17);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_ATTACKED"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_ATTACKED = ConvertPlayerUnitEvent(18);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_RESCUED"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_RESCUED = ConvertPlayerUnitEvent(19);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_DEATH"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_DEATH = ConvertPlayerUnitEvent(20);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_DECAY"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_DECAY = ConvertPlayerUnitEvent(21);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_DETECTED"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_DETECTED = ConvertPlayerUnitEvent(22);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_HIDDEN"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_HIDDEN = ConvertPlayerUnitEvent(23);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_SELECTED"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_SELECTED = ConvertPlayerUnitEvent(24);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_DESELECTED"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_DESELECTED = ConvertPlayerUnitEvent(25);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_CONSTRUCT_START"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_START = ConvertPlayerUnitEvent(26);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL = ConvertPlayerUnitEvent(27);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_CONSTRUCT_FINISH"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_FINISH = ConvertPlayerUnitEvent(28);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_UPGRADE_START"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_UPGRADE_START = ConvertPlayerUnitEvent(29);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_UPGRADE_CANCEL"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_UPGRADE_CANCEL = ConvertPlayerUnitEvent(30);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_UPGRADE_FINISH"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_UPGRADE_FINISH = ConvertPlayerUnitEvent(31);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_TRAIN_START"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_TRAIN_START = ConvertPlayerUnitEvent(32);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_TRAIN_CANCEL"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_TRAIN_CANCEL = ConvertPlayerUnitEvent(33);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_TRAIN_FINISH"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_TRAIN_FINISH = ConvertPlayerUnitEvent(34);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_RESEARCH_START"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_RESEARCH_START = ConvertPlayerUnitEvent(35);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_RESEARCH_CANCEL"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_RESEARCH_CANCEL = ConvertPlayerUnitEvent(36);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_RESEARCH_FINISH"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_RESEARCH_FINISH = ConvertPlayerUnitEvent(37);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_ISSUED_ORDER"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_ISSUED_ORDER = ConvertPlayerUnitEvent(38);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER = ConvertPlayerUnitEvent(39);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER = ConvertPlayerUnitEvent(40);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER = ConvertPlayerUnitEvent(40);
		/// @CSharpLua.Template = "EVENT_PLAYER_HERO_LEVEL"
		public static readonly playerunitevent EVENT_PLAYER_HERO_LEVEL = ConvertPlayerUnitEvent(41);
		/// @CSharpLua.Template = "EVENT_PLAYER_HERO_SKILL"
		public static readonly playerunitevent EVENT_PLAYER_HERO_SKILL = ConvertPlayerUnitEvent(42);
		/// @CSharpLua.Template = "EVENT_PLAYER_HERO_REVIVABLE"
		public static readonly playerunitevent EVENT_PLAYER_HERO_REVIVABLE = ConvertPlayerUnitEvent(43);
		/// @CSharpLua.Template = "EVENT_PLAYER_HERO_REVIVE_START"
		public static readonly playerunitevent EVENT_PLAYER_HERO_REVIVE_START = ConvertPlayerUnitEvent(44);
		/// @CSharpLua.Template = "EVENT_PLAYER_HERO_REVIVE_CANCEL"
		public static readonly playerunitevent EVENT_PLAYER_HERO_REVIVE_CANCEL = ConvertPlayerUnitEvent(45);
		/// @CSharpLua.Template = "EVENT_PLAYER_HERO_REVIVE_FINISH"
		public static readonly playerunitevent EVENT_PLAYER_HERO_REVIVE_FINISH = ConvertPlayerUnitEvent(46);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_SUMMON"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_SUMMON = ConvertPlayerUnitEvent(47);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_DROP_ITEM"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_DROP_ITEM = ConvertPlayerUnitEvent(48);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_PICKUP_ITEM"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_PICKUP_ITEM = ConvertPlayerUnitEvent(49);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_USE_ITEM"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_USE_ITEM = ConvertPlayerUnitEvent(50);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_LOADED"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_LOADED = ConvertPlayerUnitEvent(51);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_DAMAGED"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_DAMAGED = ConvertPlayerUnitEvent(308);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_DAMAGING"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_DAMAGING = ConvertPlayerUnitEvent(315);
		/// @CSharpLua.Template = "EVENT_UNIT_DAMAGED"
		public static readonly unitevent EVENT_UNIT_DAMAGED = ConvertUnitEvent(52);
		/// @CSharpLua.Template = "EVENT_UNIT_DAMAGING"
		public static readonly unitevent EVENT_UNIT_DAMAGING = ConvertUnitEvent(314);
		/// @CSharpLua.Template = "EVENT_UNIT_DEATH"
		public static readonly unitevent EVENT_UNIT_DEATH = ConvertUnitEvent(53);
		/// @CSharpLua.Template = "EVENT_UNIT_DECAY"
		public static readonly unitevent EVENT_UNIT_DECAY = ConvertUnitEvent(54);
		/// @CSharpLua.Template = "EVENT_UNIT_DETECTED"
		public static readonly unitevent EVENT_UNIT_DETECTED = ConvertUnitEvent(55);
		/// @CSharpLua.Template = "EVENT_UNIT_HIDDEN"
		public static readonly unitevent EVENT_UNIT_HIDDEN = ConvertUnitEvent(56);
		/// @CSharpLua.Template = "EVENT_UNIT_SELECTED"
		public static readonly unitevent EVENT_UNIT_SELECTED = ConvertUnitEvent(57);
		/// @CSharpLua.Template = "EVENT_UNIT_DESELECTED"
		public static readonly unitevent EVENT_UNIT_DESELECTED = ConvertUnitEvent(58);
		/// @CSharpLua.Template = "EVENT_UNIT_STATE_LIMIT"
		public static readonly unitevent EVENT_UNIT_STATE_LIMIT = ConvertUnitEvent(59);
		/// @CSharpLua.Template = "EVENT_UNIT_ACQUIRED_TARGET"
		public static readonly unitevent EVENT_UNIT_ACQUIRED_TARGET = ConvertUnitEvent(60);
		/// @CSharpLua.Template = "EVENT_UNIT_TARGET_IN_RANGE"
		public static readonly unitevent EVENT_UNIT_TARGET_IN_RANGE = ConvertUnitEvent(61);
		/// @CSharpLua.Template = "EVENT_UNIT_ATTACKED"
		public static readonly unitevent EVENT_UNIT_ATTACKED = ConvertUnitEvent(62);
		/// @CSharpLua.Template = "EVENT_UNIT_RESCUED"
		public static readonly unitevent EVENT_UNIT_RESCUED = ConvertUnitEvent(63);
		/// @CSharpLua.Template = "EVENT_UNIT_CONSTRUCT_CANCEL"
		public static readonly unitevent EVENT_UNIT_CONSTRUCT_CANCEL = ConvertUnitEvent(64);
		/// @CSharpLua.Template = "EVENT_UNIT_CONSTRUCT_FINISH"
		public static readonly unitevent EVENT_UNIT_CONSTRUCT_FINISH = ConvertUnitEvent(65);
		/// @CSharpLua.Template = "EVENT_UNIT_UPGRADE_START"
		public static readonly unitevent EVENT_UNIT_UPGRADE_START = ConvertUnitEvent(66);
		/// @CSharpLua.Template = "EVENT_UNIT_UPGRADE_CANCEL"
		public static readonly unitevent EVENT_UNIT_UPGRADE_CANCEL = ConvertUnitEvent(67);
		/// @CSharpLua.Template = "EVENT_UNIT_UPGRADE_FINISH"
		public static readonly unitevent EVENT_UNIT_UPGRADE_FINISH = ConvertUnitEvent(68);
		/// @CSharpLua.Template = "EVENT_UNIT_TRAIN_START"
		public static readonly unitevent EVENT_UNIT_TRAIN_START = ConvertUnitEvent(69);
		/// @CSharpLua.Template = "EVENT_UNIT_TRAIN_CANCEL"
		public static readonly unitevent EVENT_UNIT_TRAIN_CANCEL = ConvertUnitEvent(70);
		/// @CSharpLua.Template = "EVENT_UNIT_TRAIN_FINISH"
		public static readonly unitevent EVENT_UNIT_TRAIN_FINISH = ConvertUnitEvent(71);
		/// @CSharpLua.Template = "EVENT_UNIT_RESEARCH_START"
		public static readonly unitevent EVENT_UNIT_RESEARCH_START = ConvertUnitEvent(72);
		/// @CSharpLua.Template = "EVENT_UNIT_RESEARCH_CANCEL"
		public static readonly unitevent EVENT_UNIT_RESEARCH_CANCEL = ConvertUnitEvent(73);
		/// @CSharpLua.Template = "EVENT_UNIT_RESEARCH_FINISH"
		public static readonly unitevent EVENT_UNIT_RESEARCH_FINISH = ConvertUnitEvent(74);
		/// @CSharpLua.Template = "EVENT_UNIT_ISSUED_ORDER"
		public static readonly unitevent EVENT_UNIT_ISSUED_ORDER = ConvertUnitEvent(75);
		/// @CSharpLua.Template = "EVENT_UNIT_ISSUED_POINT_ORDER"
		public static readonly unitevent EVENT_UNIT_ISSUED_POINT_ORDER = ConvertUnitEvent(76);
		/// @CSharpLua.Template = "EVENT_UNIT_ISSUED_TARGET_ORDER"
		public static readonly unitevent EVENT_UNIT_ISSUED_TARGET_ORDER = ConvertUnitEvent(77);
		/// @CSharpLua.Template = "EVENT_UNIT_HERO_LEVEL"
		public static readonly unitevent EVENT_UNIT_HERO_LEVEL = ConvertUnitEvent(78);
		/// @CSharpLua.Template = "EVENT_UNIT_HERO_SKILL"
		public static readonly unitevent EVENT_UNIT_HERO_SKILL = ConvertUnitEvent(79);
		/// @CSharpLua.Template = "EVENT_UNIT_HERO_REVIVABLE"
		public static readonly unitevent EVENT_UNIT_HERO_REVIVABLE = ConvertUnitEvent(80);
		/// @CSharpLua.Template = "EVENT_UNIT_HERO_REVIVE_START"
		public static readonly unitevent EVENT_UNIT_HERO_REVIVE_START = ConvertUnitEvent(81);
		/// @CSharpLua.Template = "EVENT_UNIT_HERO_REVIVE_CANCEL"
		public static readonly unitevent EVENT_UNIT_HERO_REVIVE_CANCEL = ConvertUnitEvent(82);
		/// @CSharpLua.Template = "EVENT_UNIT_HERO_REVIVE_FINISH"
		public static readonly unitevent EVENT_UNIT_HERO_REVIVE_FINISH = ConvertUnitEvent(83);
		/// @CSharpLua.Template = "EVENT_UNIT_SUMMON"
		public static readonly unitevent EVENT_UNIT_SUMMON = ConvertUnitEvent(84);
		/// @CSharpLua.Template = "EVENT_UNIT_DROP_ITEM"
		public static readonly unitevent EVENT_UNIT_DROP_ITEM = ConvertUnitEvent(85);
		/// @CSharpLua.Template = "EVENT_UNIT_PICKUP_ITEM"
		public static readonly unitevent EVENT_UNIT_PICKUP_ITEM = ConvertUnitEvent(86);
		/// @CSharpLua.Template = "EVENT_UNIT_USE_ITEM"
		public static readonly unitevent EVENT_UNIT_USE_ITEM = ConvertUnitEvent(87);
		/// @CSharpLua.Template = "EVENT_UNIT_LOADED"
		public static readonly unitevent EVENT_UNIT_LOADED = ConvertUnitEvent(88);
		/// @CSharpLua.Template = "EVENT_WIDGET_DEATH"
		public static readonly widgetevent EVENT_WIDGET_DEATH = ConvertWidgetEvent(89);
		/// @CSharpLua.Template = "EVENT_DIALOG_BUTTON_CLICK"
		public static readonly dialogevent EVENT_DIALOG_BUTTON_CLICK = ConvertDialogEvent(90);
		/// @CSharpLua.Template = "EVENT_DIALOG_CLICK"
		public static readonly dialogevent EVENT_DIALOG_CLICK = ConvertDialogEvent(91);
		/// @CSharpLua.Template = "EVENT_GAME_LOADED"
		public static readonly gameevent EVENT_GAME_LOADED = ConvertGameEvent(256);
		/// @CSharpLua.Template = "EVENT_GAME_TOURNAMENT_FINISH_SOON"
		public static readonly gameevent EVENT_GAME_TOURNAMENT_FINISH_SOON = ConvertGameEvent(257);
		/// @CSharpLua.Template = "EVENT_GAME_TOURNAMENT_FINISH_NOW"
		public static readonly gameevent EVENT_GAME_TOURNAMENT_FINISH_NOW = ConvertGameEvent(258);
		/// @CSharpLua.Template = "EVENT_GAME_SAVE"
		public static readonly gameevent EVENT_GAME_SAVE = ConvertGameEvent(259);
		/// @CSharpLua.Template = "EVENT_GAME_CUSTOM_UI_FRAME"
		public static readonly gameevent EVENT_GAME_CUSTOM_UI_FRAME = ConvertGameEvent(310);
		/// @CSharpLua.Template = "EVENT_PLAYER_ARROW_LEFT_DOWN"
		public static readonly playerevent EVENT_PLAYER_ARROW_LEFT_DOWN = ConvertPlayerEvent(261);
		/// @CSharpLua.Template = "EVENT_PLAYER_ARROW_LEFT_UP"
		public static readonly playerevent EVENT_PLAYER_ARROW_LEFT_UP = ConvertPlayerEvent(262);
		/// @CSharpLua.Template = "EVENT_PLAYER_ARROW_RIGHT_DOWN"
		public static readonly playerevent EVENT_PLAYER_ARROW_RIGHT_DOWN = ConvertPlayerEvent(263);
		/// @CSharpLua.Template = "EVENT_PLAYER_ARROW_RIGHT_UP"
		public static readonly playerevent EVENT_PLAYER_ARROW_RIGHT_UP = ConvertPlayerEvent(264);
		/// @CSharpLua.Template = "EVENT_PLAYER_ARROW_DOWN_DOWN"
		public static readonly playerevent EVENT_PLAYER_ARROW_DOWN_DOWN = ConvertPlayerEvent(265);
		/// @CSharpLua.Template = "EVENT_PLAYER_ARROW_DOWN_UP"
		public static readonly playerevent EVENT_PLAYER_ARROW_DOWN_UP = ConvertPlayerEvent(266);
		/// @CSharpLua.Template = "EVENT_PLAYER_ARROW_UP_DOWN"
		public static readonly playerevent EVENT_PLAYER_ARROW_UP_DOWN = ConvertPlayerEvent(267);
		/// @CSharpLua.Template = "EVENT_PLAYER_ARROW_UP_UP"
		public static readonly playerevent EVENT_PLAYER_ARROW_UP_UP = ConvertPlayerEvent(268);
		/// @CSharpLua.Template = "EVENT_PLAYER_MOUSE_DOWN"
		public static readonly playerevent EVENT_PLAYER_MOUSE_DOWN = ConvertPlayerEvent(305);
		/// @CSharpLua.Template = "EVENT_PLAYER_MOUSE_UP"
		public static readonly playerevent EVENT_PLAYER_MOUSE_UP = ConvertPlayerEvent(306);
		/// @CSharpLua.Template = "EVENT_PLAYER_MOUSE_MOVE"
		public static readonly playerevent EVENT_PLAYER_MOUSE_MOVE = ConvertPlayerEvent(307);
		/// @CSharpLua.Template = "EVENT_PLAYER_SYNC_DATA"
		public static readonly playerevent EVENT_PLAYER_SYNC_DATA = ConvertPlayerEvent(309);
		/// @CSharpLua.Template = "EVENT_PLAYER_KEY"
		public static readonly playerevent EVENT_PLAYER_KEY = ConvertPlayerEvent(311);
		/// @CSharpLua.Template = "EVENT_PLAYER_KEY_DOWN"
		public static readonly playerevent EVENT_PLAYER_KEY_DOWN = ConvertPlayerEvent(312);
		/// @CSharpLua.Template = "EVENT_PLAYER_KEY_UP"
		public static readonly playerevent EVENT_PLAYER_KEY_UP = ConvertPlayerEvent(313);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_SELL"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_SELL = ConvertPlayerUnitEvent(269);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_CHANGE_OWNER"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_CHANGE_OWNER = ConvertPlayerUnitEvent(270);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_SELL_ITEM"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_SELL_ITEM = ConvertPlayerUnitEvent(271);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_SPELL_CHANNEL"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_SPELL_CHANNEL = ConvertPlayerUnitEvent(272);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_SPELL_CAST"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_SPELL_CAST = ConvertPlayerUnitEvent(273);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_SPELL_EFFECT"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_SPELL_EFFECT = ConvertPlayerUnitEvent(274);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_SPELL_FINISH"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_SPELL_FINISH = ConvertPlayerUnitEvent(275);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_SPELL_ENDCAST"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_SPELL_ENDCAST = ConvertPlayerUnitEvent(276);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_PAWN_ITEM"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_PAWN_ITEM = ConvertPlayerUnitEvent(277);
		/// @CSharpLua.Template = "EVENT_PLAYER_UNIT_STACK_ITEM"
		public static readonly playerunitevent EVENT_PLAYER_UNIT_STACK_ITEM = ConvertPlayerUnitEvent(319);
		/// @CSharpLua.Template = "EVENT_UNIT_SELL"
		public static readonly unitevent EVENT_UNIT_SELL = ConvertUnitEvent(286);
		/// @CSharpLua.Template = "EVENT_UNIT_CHANGE_OWNER"
		public static readonly unitevent EVENT_UNIT_CHANGE_OWNER = ConvertUnitEvent(287);
		/// @CSharpLua.Template = "EVENT_UNIT_SELL_ITEM"
		public static readonly unitevent EVENT_UNIT_SELL_ITEM = ConvertUnitEvent(288);
		/// @CSharpLua.Template = "EVENT_UNIT_SPELL_CHANNEL"
		public static readonly unitevent EVENT_UNIT_SPELL_CHANNEL = ConvertUnitEvent(289);
		/// @CSharpLua.Template = "EVENT_UNIT_SPELL_CAST"
		public static readonly unitevent EVENT_UNIT_SPELL_CAST = ConvertUnitEvent(290);
		/// @CSharpLua.Template = "EVENT_UNIT_SPELL_EFFECT"
		public static readonly unitevent EVENT_UNIT_SPELL_EFFECT = ConvertUnitEvent(291);
		/// @CSharpLua.Template = "EVENT_UNIT_SPELL_FINISH"
		public static readonly unitevent EVENT_UNIT_SPELL_FINISH = ConvertUnitEvent(292);
		/// @CSharpLua.Template = "EVENT_UNIT_SPELL_ENDCAST"
		public static readonly unitevent EVENT_UNIT_SPELL_ENDCAST = ConvertUnitEvent(293);
		/// @CSharpLua.Template = "EVENT_UNIT_PAWN_ITEM"
		public static readonly unitevent EVENT_UNIT_PAWN_ITEM = ConvertUnitEvent(294);
		/// @CSharpLua.Template = "EVENT_UNIT_STACK_ITEM"
		public static readonly unitevent EVENT_UNIT_STACK_ITEM = ConvertUnitEvent(318);
		/// @CSharpLua.Template = "LESS_THAN"
		public static readonly limitop LESS_THAN = ConvertLimitOp(0);
		/// @CSharpLua.Template = "LESS_THAN_OR_EQUAL"
		public static readonly limitop LESS_THAN_OR_EQUAL = ConvertLimitOp(1);
		/// @CSharpLua.Template = "EQUAL"
		public static readonly limitop EQUAL = ConvertLimitOp(2);
		/// @CSharpLua.Template = "GREATER_THAN_OR_EQUAL"
		public static readonly limitop GREATER_THAN_OR_EQUAL = ConvertLimitOp(3);
		/// @CSharpLua.Template = "GREATER_THAN"
		public static readonly limitop GREATER_THAN = ConvertLimitOp(4);
		/// @CSharpLua.Template = "NOT_EQUAL"
		public static readonly limitop NOT_EQUAL = ConvertLimitOp(5);
		/// @CSharpLua.Template = "UNIT_TYPE_HERO"
		public static readonly unittype UNIT_TYPE_HERO = ConvertUnitType(0);
		/// @CSharpLua.Template = "UNIT_TYPE_DEAD"
		public static readonly unittype UNIT_TYPE_DEAD = ConvertUnitType(1);
		/// @CSharpLua.Template = "UNIT_TYPE_STRUCTURE"
		public static readonly unittype UNIT_TYPE_STRUCTURE = ConvertUnitType(2);
		/// @CSharpLua.Template = "UNIT_TYPE_FLYING"
		public static readonly unittype UNIT_TYPE_FLYING = ConvertUnitType(3);
		/// @CSharpLua.Template = "UNIT_TYPE_GROUND"
		public static readonly unittype UNIT_TYPE_GROUND = ConvertUnitType(4);
		/// @CSharpLua.Template = "UNIT_TYPE_ATTACKS_FLYING"
		public static readonly unittype UNIT_TYPE_ATTACKS_FLYING = ConvertUnitType(5);
		/// @CSharpLua.Template = "UNIT_TYPE_ATTACKS_GROUND"
		public static readonly unittype UNIT_TYPE_ATTACKS_GROUND = ConvertUnitType(6);
		/// @CSharpLua.Template = "UNIT_TYPE_MELEE_ATTACKER"
		public static readonly unittype UNIT_TYPE_MELEE_ATTACKER = ConvertUnitType(7);
		/// @CSharpLua.Template = "UNIT_TYPE_RANGED_ATTACKER"
		public static readonly unittype UNIT_TYPE_RANGED_ATTACKER = ConvertUnitType(8);
		/// @CSharpLua.Template = "UNIT_TYPE_GIANT"
		public static readonly unittype UNIT_TYPE_GIANT = ConvertUnitType(9);
		/// @CSharpLua.Template = "UNIT_TYPE_SUMMONED"
		public static readonly unittype UNIT_TYPE_SUMMONED = ConvertUnitType(10);
		/// @CSharpLua.Template = "UNIT_TYPE_STUNNED"
		public static readonly unittype UNIT_TYPE_STUNNED = ConvertUnitType(11);
		/// @CSharpLua.Template = "UNIT_TYPE_PLAGUED"
		public static readonly unittype UNIT_TYPE_PLAGUED = ConvertUnitType(12);
		/// @CSharpLua.Template = "UNIT_TYPE_SNARED"
		public static readonly unittype UNIT_TYPE_SNARED = ConvertUnitType(13);
		/// @CSharpLua.Template = "UNIT_TYPE_UNDEAD"
		public static readonly unittype UNIT_TYPE_UNDEAD = ConvertUnitType(14);
		/// @CSharpLua.Template = "UNIT_TYPE_MECHANICAL"
		public static readonly unittype UNIT_TYPE_MECHANICAL = ConvertUnitType(15);
		/// @CSharpLua.Template = "UNIT_TYPE_PEON"
		public static readonly unittype UNIT_TYPE_PEON = ConvertUnitType(16);
		/// @CSharpLua.Template = "UNIT_TYPE_SAPPER"
		public static readonly unittype UNIT_TYPE_SAPPER = ConvertUnitType(17);
		/// @CSharpLua.Template = "UNIT_TYPE_TOWNHALL"
		public static readonly unittype UNIT_TYPE_TOWNHALL = ConvertUnitType(18);
		/// @CSharpLua.Template = "UNIT_TYPE_ANCIENT"
		public static readonly unittype UNIT_TYPE_ANCIENT = ConvertUnitType(19);
		/// @CSharpLua.Template = "UNIT_TYPE_TAUREN"
		public static readonly unittype UNIT_TYPE_TAUREN = ConvertUnitType(20);
		/// @CSharpLua.Template = "UNIT_TYPE_POISONED"
		public static readonly unittype UNIT_TYPE_POISONED = ConvertUnitType(21);
		/// @CSharpLua.Template = "UNIT_TYPE_POLYMORPHED"
		public static readonly unittype UNIT_TYPE_POLYMORPHED = ConvertUnitType(22);
		/// @CSharpLua.Template = "UNIT_TYPE_SLEEPING"
		public static readonly unittype UNIT_TYPE_SLEEPING = ConvertUnitType(23);
		/// @CSharpLua.Template = "UNIT_TYPE_RESISTANT"
		public static readonly unittype UNIT_TYPE_RESISTANT = ConvertUnitType(24);
		/// @CSharpLua.Template = "UNIT_TYPE_ETHEREAL"
		public static readonly unittype UNIT_TYPE_ETHEREAL = ConvertUnitType(25);
		/// @CSharpLua.Template = "UNIT_TYPE_MAGIC_IMMUNE"
		public static readonly unittype UNIT_TYPE_MAGIC_IMMUNE = ConvertUnitType(26);
		/// @CSharpLua.Template = "ITEM_TYPE_PERMANENT"
		public static readonly itemtype ITEM_TYPE_PERMANENT = ConvertItemType(0);
		/// @CSharpLua.Template = "ITEM_TYPE_CHARGED"
		public static readonly itemtype ITEM_TYPE_CHARGED = ConvertItemType(1);
		/// @CSharpLua.Template = "ITEM_TYPE_POWERUP"
		public static readonly itemtype ITEM_TYPE_POWERUP = ConvertItemType(2);
		/// @CSharpLua.Template = "ITEM_TYPE_ARTIFACT"
		public static readonly itemtype ITEM_TYPE_ARTIFACT = ConvertItemType(3);
		/// @CSharpLua.Template = "ITEM_TYPE_PURCHASABLE"
		public static readonly itemtype ITEM_TYPE_PURCHASABLE = ConvertItemType(4);
		/// @CSharpLua.Template = "ITEM_TYPE_CAMPAIGN"
		public static readonly itemtype ITEM_TYPE_CAMPAIGN = ConvertItemType(5);
		/// @CSharpLua.Template = "ITEM_TYPE_MISCELLANEOUS"
		public static readonly itemtype ITEM_TYPE_MISCELLANEOUS = ConvertItemType(6);
		/// @CSharpLua.Template = "ITEM_TYPE_UNKNOWN"
		public static readonly itemtype ITEM_TYPE_UNKNOWN = ConvertItemType(7);
		/// @CSharpLua.Template = "ITEM_TYPE_ANY"
		public static readonly itemtype ITEM_TYPE_ANY = ConvertItemType(8);
		/// @CSharpLua.Template = "ITEM_TYPE_TOME"
		public static readonly itemtype ITEM_TYPE_TOME = ConvertItemType(2);
		/// @CSharpLua.Template = "CAMERA_FIELD_TARGET_DISTANCE"
		public static readonly camerafield CAMERA_FIELD_TARGET_DISTANCE = ConvertCameraField(0);
		/// @CSharpLua.Template = "CAMERA_FIELD_FARZ"
		public static readonly camerafield CAMERA_FIELD_FARZ = ConvertCameraField(1);
		/// @CSharpLua.Template = "CAMERA_FIELD_ANGLE_OF_ATTACK"
		public static readonly camerafield CAMERA_FIELD_ANGLE_OF_ATTACK = ConvertCameraField(2);
		/// @CSharpLua.Template = "CAMERA_FIELD_FIELD_OF_VIEW"
		public static readonly camerafield CAMERA_FIELD_FIELD_OF_VIEW = ConvertCameraField(3);
		/// @CSharpLua.Template = "CAMERA_FIELD_ROLL"
		public static readonly camerafield CAMERA_FIELD_ROLL = ConvertCameraField(4);
		/// @CSharpLua.Template = "CAMERA_FIELD_ROTATION"
		public static readonly camerafield CAMERA_FIELD_ROTATION = ConvertCameraField(5);
		/// @CSharpLua.Template = "CAMERA_FIELD_ZOFFSET"
		public static readonly camerafield CAMERA_FIELD_ZOFFSET = ConvertCameraField(6);
		/// @CSharpLua.Template = "CAMERA_FIELD_NEARZ"
		public static readonly camerafield CAMERA_FIELD_NEARZ = ConvertCameraField(7);
		/// @CSharpLua.Template = "CAMERA_FIELD_LOCAL_PITCH"
		public static readonly camerafield CAMERA_FIELD_LOCAL_PITCH = ConvertCameraField(8);
		/// @CSharpLua.Template = "CAMERA_FIELD_LOCAL_YAW"
		public static readonly camerafield CAMERA_FIELD_LOCAL_YAW = ConvertCameraField(9);
		/// @CSharpLua.Template = "CAMERA_FIELD_LOCAL_ROLL"
		public static readonly camerafield CAMERA_FIELD_LOCAL_ROLL = ConvertCameraField(10);
		/// @CSharpLua.Template = "BLEND_MODE_NONE"
		public static readonly blendmode BLEND_MODE_NONE = ConvertBlendMode(0);
		/// @CSharpLua.Template = "BLEND_MODE_DONT_CARE"
		public static readonly blendmode BLEND_MODE_DONT_CARE = ConvertBlendMode(0);
		/// @CSharpLua.Template = "BLEND_MODE_KEYALPHA"
		public static readonly blendmode BLEND_MODE_KEYALPHA = ConvertBlendMode(1);
		/// @CSharpLua.Template = "BLEND_MODE_BLEND"
		public static readonly blendmode BLEND_MODE_BLEND = ConvertBlendMode(2);
		/// @CSharpLua.Template = "BLEND_MODE_ADDITIVE"
		public static readonly blendmode BLEND_MODE_ADDITIVE = ConvertBlendMode(3);
		/// @CSharpLua.Template = "BLEND_MODE_MODULATE"
		public static readonly blendmode BLEND_MODE_MODULATE = ConvertBlendMode(4);
		/// @CSharpLua.Template = "BLEND_MODE_MODULATE_2X"
		public static readonly blendmode BLEND_MODE_MODULATE_2X = ConvertBlendMode(5);
		/// @CSharpLua.Template = "RARITY_FREQUENT"
		public static readonly raritycontrol RARITY_FREQUENT = ConvertRarityControl(0);
		/// @CSharpLua.Template = "RARITY_RARE"
		public static readonly raritycontrol RARITY_RARE = ConvertRarityControl(1);
		/// @CSharpLua.Template = "TEXMAP_FLAG_NONE"
		public static readonly texmapflags TEXMAP_FLAG_NONE = ConvertTexMapFlags(0);
		/// @CSharpLua.Template = "TEXMAP_FLAG_WRAP_U"
		public static readonly texmapflags TEXMAP_FLAG_WRAP_U = ConvertTexMapFlags(1);
		/// @CSharpLua.Template = "TEXMAP_FLAG_WRAP_V"
		public static readonly texmapflags TEXMAP_FLAG_WRAP_V = ConvertTexMapFlags(2);
		/// @CSharpLua.Template = "TEXMAP_FLAG_WRAP_UV"
		public static readonly texmapflags TEXMAP_FLAG_WRAP_UV = ConvertTexMapFlags(3);
		/// @CSharpLua.Template = "FOG_OF_WAR_MASKED"
		public static readonly fogstate FOG_OF_WAR_MASKED = ConvertFogState(1);
		/// @CSharpLua.Template = "FOG_OF_WAR_FOGGED"
		public static readonly fogstate FOG_OF_WAR_FOGGED = ConvertFogState(2);
		/// @CSharpLua.Template = "FOG_OF_WAR_VISIBLE"
		public static readonly fogstate FOG_OF_WAR_VISIBLE = ConvertFogState(4);
		/// @CSharpLua.Template = "CAMERA_MARGIN_LEFT"
		public const int CAMERA_MARGIN_LEFT = 0;
		/// @CSharpLua.Template = "CAMERA_MARGIN_RIGHT"
		public const int CAMERA_MARGIN_RIGHT = 1;
		/// @CSharpLua.Template = "CAMERA_MARGIN_TOP"
		public const int CAMERA_MARGIN_TOP = 2;
		/// @CSharpLua.Template = "CAMERA_MARGIN_BOTTOM"
		public const int CAMERA_MARGIN_BOTTOM = 3;
		/// @CSharpLua.Template = "EFFECT_TYPE_EFFECT"
		public static readonly effecttype EFFECT_TYPE_EFFECT = ConvertEffectType(0);
		/// @CSharpLua.Template = "EFFECT_TYPE_TARGET"
		public static readonly effecttype EFFECT_TYPE_TARGET = ConvertEffectType(1);
		/// @CSharpLua.Template = "EFFECT_TYPE_CASTER"
		public static readonly effecttype EFFECT_TYPE_CASTER = ConvertEffectType(2);
		/// @CSharpLua.Template = "EFFECT_TYPE_SPECIAL"
		public static readonly effecttype EFFECT_TYPE_SPECIAL = ConvertEffectType(3);
		/// @CSharpLua.Template = "EFFECT_TYPE_AREA_EFFECT"
		public static readonly effecttype EFFECT_TYPE_AREA_EFFECT = ConvertEffectType(4);
		/// @CSharpLua.Template = "EFFECT_TYPE_MISSILE"
		public static readonly effecttype EFFECT_TYPE_MISSILE = ConvertEffectType(5);
		/// @CSharpLua.Template = "EFFECT_TYPE_LIGHTNING"
		public static readonly effecttype EFFECT_TYPE_LIGHTNING = ConvertEffectType(6);
		/// @CSharpLua.Template = "SOUND_TYPE_EFFECT"
		public static readonly soundtype SOUND_TYPE_EFFECT = ConvertSoundType(0);
		/// @CSharpLua.Template = "SOUND_TYPE_EFFECT_LOOPED"
		public static readonly soundtype SOUND_TYPE_EFFECT_LOOPED = ConvertSoundType(1);
		/// @CSharpLua.Template = "ORIGIN_FRAME_GAME_UI"
		public static readonly originframetype ORIGIN_FRAME_GAME_UI = ConvertOriginFrameType(0);
		/// @CSharpLua.Template = "ORIGIN_FRAME_COMMAND_BUTTON"
		public static readonly originframetype ORIGIN_FRAME_COMMAND_BUTTON = ConvertOriginFrameType(1);
		/// @CSharpLua.Template = "ORIGIN_FRAME_HERO_BAR"
		public static readonly originframetype ORIGIN_FRAME_HERO_BAR = ConvertOriginFrameType(2);
		/// @CSharpLua.Template = "ORIGIN_FRAME_HERO_BUTTON"
		public static readonly originframetype ORIGIN_FRAME_HERO_BUTTON = ConvertOriginFrameType(3);
		/// @CSharpLua.Template = "ORIGIN_FRAME_HERO_HP_BAR"
		public static readonly originframetype ORIGIN_FRAME_HERO_HP_BAR = ConvertOriginFrameType(4);
		/// @CSharpLua.Template = "ORIGIN_FRAME_HERO_MANA_BAR"
		public static readonly originframetype ORIGIN_FRAME_HERO_MANA_BAR = ConvertOriginFrameType(5);
		/// @CSharpLua.Template = "ORIGIN_FRAME_HERO_BUTTON_INDICATOR"
		public static readonly originframetype ORIGIN_FRAME_HERO_BUTTON_INDICATOR = ConvertOriginFrameType(6);
		/// @CSharpLua.Template = "ORIGIN_FRAME_ITEM_BUTTON"
		public static readonly originframetype ORIGIN_FRAME_ITEM_BUTTON = ConvertOriginFrameType(7);
		/// @CSharpLua.Template = "ORIGIN_FRAME_MINIMAP"
		public static readonly originframetype ORIGIN_FRAME_MINIMAP = ConvertOriginFrameType(8);
		/// @CSharpLua.Template = "ORIGIN_FRAME_MINIMAP_BUTTON"
		public static readonly originframetype ORIGIN_FRAME_MINIMAP_BUTTON = ConvertOriginFrameType(9);
		/// @CSharpLua.Template = "ORIGIN_FRAME_SYSTEM_BUTTON"
		public static readonly originframetype ORIGIN_FRAME_SYSTEM_BUTTON = ConvertOriginFrameType(10);
		/// @CSharpLua.Template = "ORIGIN_FRAME_TOOLTIP"
		public static readonly originframetype ORIGIN_FRAME_TOOLTIP = ConvertOriginFrameType(11);
		/// @CSharpLua.Template = "ORIGIN_FRAME_UBERTOOLTIP"
		public static readonly originframetype ORIGIN_FRAME_UBERTOOLTIP = ConvertOriginFrameType(12);
		/// @CSharpLua.Template = "ORIGIN_FRAME_CHAT_MSG"
		public static readonly originframetype ORIGIN_FRAME_CHAT_MSG = ConvertOriginFrameType(13);
		/// @CSharpLua.Template = "ORIGIN_FRAME_UNIT_MSG"
		public static readonly originframetype ORIGIN_FRAME_UNIT_MSG = ConvertOriginFrameType(14);
		/// @CSharpLua.Template = "ORIGIN_FRAME_TOP_MSG"
		public static readonly originframetype ORIGIN_FRAME_TOP_MSG = ConvertOriginFrameType(15);
		/// @CSharpLua.Template = "ORIGIN_FRAME_PORTRAIT"
		public static readonly originframetype ORIGIN_FRAME_PORTRAIT = ConvertOriginFrameType(16);
		/// @CSharpLua.Template = "ORIGIN_FRAME_WORLD_FRAME"
		public static readonly originframetype ORIGIN_FRAME_WORLD_FRAME = ConvertOriginFrameType(17);
		/// @CSharpLua.Template = "ORIGIN_FRAME_SIMPLE_UI_PARENT"
		public static readonly originframetype ORIGIN_FRAME_SIMPLE_UI_PARENT = ConvertOriginFrameType(18);
		/// @CSharpLua.Template = "ORIGIN_FRAME_PORTRAIT_HP_TEXT"
		public static readonly originframetype ORIGIN_FRAME_PORTRAIT_HP_TEXT = ConvertOriginFrameType(19);
		/// @CSharpLua.Template = "ORIGIN_FRAME_PORTRAIT_MANA_TEXT"
		public static readonly originframetype ORIGIN_FRAME_PORTRAIT_MANA_TEXT = ConvertOriginFrameType(20);
		/// @CSharpLua.Template = "ORIGIN_FRAME_UNIT_PANEL_BUFF_BAR"
		public static readonly originframetype ORIGIN_FRAME_UNIT_PANEL_BUFF_BAR = ConvertOriginFrameType(21);
		/// @CSharpLua.Template = "ORIGIN_FRAME_UNIT_PANEL_BUFF_BAR_LABEL"
		public static readonly originframetype ORIGIN_FRAME_UNIT_PANEL_BUFF_BAR_LABEL = ConvertOriginFrameType(22);
		/// @CSharpLua.Template = "FRAMEPOINT_TOPLEFT"
		public static readonly framepointtype FRAMEPOINT_TOPLEFT = ConvertFramePointType(0);
		/// @CSharpLua.Template = "FRAMEPOINT_TOP"
		public static readonly framepointtype FRAMEPOINT_TOP = ConvertFramePointType(1);
		/// @CSharpLua.Template = "FRAMEPOINT_TOPRIGHT"
		public static readonly framepointtype FRAMEPOINT_TOPRIGHT = ConvertFramePointType(2);
		/// @CSharpLua.Template = "FRAMEPOINT_LEFT"
		public static readonly framepointtype FRAMEPOINT_LEFT = ConvertFramePointType(3);
		/// @CSharpLua.Template = "FRAMEPOINT_CENTER"
		public static readonly framepointtype FRAMEPOINT_CENTER = ConvertFramePointType(4);
		/// @CSharpLua.Template = "FRAMEPOINT_RIGHT"
		public static readonly framepointtype FRAMEPOINT_RIGHT = ConvertFramePointType(5);
		/// @CSharpLua.Template = "FRAMEPOINT_BOTTOMLEFT"
		public static readonly framepointtype FRAMEPOINT_BOTTOMLEFT = ConvertFramePointType(6);
		/// @CSharpLua.Template = "FRAMEPOINT_BOTTOM"
		public static readonly framepointtype FRAMEPOINT_BOTTOM = ConvertFramePointType(7);
		/// @CSharpLua.Template = "FRAMEPOINT_BOTTOMRIGHT"
		public static readonly framepointtype FRAMEPOINT_BOTTOMRIGHT = ConvertFramePointType(8);
		/// @CSharpLua.Template = "TEXT_JUSTIFY_TOP"
		public static readonly textaligntype TEXT_JUSTIFY_TOP = ConvertTextAlignType(0);
		/// @CSharpLua.Template = "TEXT_JUSTIFY_MIDDLE"
		public static readonly textaligntype TEXT_JUSTIFY_MIDDLE = ConvertTextAlignType(1);
		/// @CSharpLua.Template = "TEXT_JUSTIFY_BOTTOM"
		public static readonly textaligntype TEXT_JUSTIFY_BOTTOM = ConvertTextAlignType(2);
		/// @CSharpLua.Template = "TEXT_JUSTIFY_LEFT"
		public static readonly textaligntype TEXT_JUSTIFY_LEFT = ConvertTextAlignType(3);
		/// @CSharpLua.Template = "TEXT_JUSTIFY_CENTER"
		public static readonly textaligntype TEXT_JUSTIFY_CENTER = ConvertTextAlignType(4);
		/// @CSharpLua.Template = "TEXT_JUSTIFY_RIGHT"
		public static readonly textaligntype TEXT_JUSTIFY_RIGHT = ConvertTextAlignType(5);
		/// @CSharpLua.Template = "FRAMEEVENT_CONTROL_CLICK"
		public static readonly frameeventtype FRAMEEVENT_CONTROL_CLICK = ConvertFrameEventType(1);
		/// @CSharpLua.Template = "FRAMEEVENT_MOUSE_ENTER"
		public static readonly frameeventtype FRAMEEVENT_MOUSE_ENTER = ConvertFrameEventType(2);
		/// @CSharpLua.Template = "FRAMEEVENT_MOUSE_LEAVE"
		public static readonly frameeventtype FRAMEEVENT_MOUSE_LEAVE = ConvertFrameEventType(3);
		/// @CSharpLua.Template = "FRAMEEVENT_MOUSE_UP"
		public static readonly frameeventtype FRAMEEVENT_MOUSE_UP = ConvertFrameEventType(4);
		/// @CSharpLua.Template = "FRAMEEVENT_MOUSE_DOWN"
		public static readonly frameeventtype FRAMEEVENT_MOUSE_DOWN = ConvertFrameEventType(5);
		/// @CSharpLua.Template = "FRAMEEVENT_MOUSE_WHEEL"
		public static readonly frameeventtype FRAMEEVENT_MOUSE_WHEEL = ConvertFrameEventType(6);
		/// @CSharpLua.Template = "FRAMEEVENT_CHECKBOX_CHECKED"
		public static readonly frameeventtype FRAMEEVENT_CHECKBOX_CHECKED = ConvertFrameEventType(7);
		/// @CSharpLua.Template = "FRAMEEVENT_CHECKBOX_UNCHECKED"
		public static readonly frameeventtype FRAMEEVENT_CHECKBOX_UNCHECKED = ConvertFrameEventType(8);
		/// @CSharpLua.Template = "FRAMEEVENT_EDITBOX_TEXT_CHANGED"
		public static readonly frameeventtype FRAMEEVENT_EDITBOX_TEXT_CHANGED = ConvertFrameEventType(9);
		/// @CSharpLua.Template = "FRAMEEVENT_POPUPMENU_ITEM_CHANGED"
		public static readonly frameeventtype FRAMEEVENT_POPUPMENU_ITEM_CHANGED = ConvertFrameEventType(10);
		/// @CSharpLua.Template = "FRAMEEVENT_MOUSE_DOUBLECLICK"
		public static readonly frameeventtype FRAMEEVENT_MOUSE_DOUBLECLICK = ConvertFrameEventType(11);
		/// @CSharpLua.Template = "FRAMEEVENT_SPRITE_ANIM_UPDATE"
		public static readonly frameeventtype FRAMEEVENT_SPRITE_ANIM_UPDATE = ConvertFrameEventType(12);
		/// @CSharpLua.Template = "FRAMEEVENT_SLIDER_VALUE_CHANGED"
		public static readonly frameeventtype FRAMEEVENT_SLIDER_VALUE_CHANGED = ConvertFrameEventType(13);
		/// @CSharpLua.Template = "FRAMEEVENT_DIALOG_CANCEL"
		public static readonly frameeventtype FRAMEEVENT_DIALOG_CANCEL = ConvertFrameEventType(14);
		/// @CSharpLua.Template = "FRAMEEVENT_DIALOG_ACCEPT"
		public static readonly frameeventtype FRAMEEVENT_DIALOG_ACCEPT = ConvertFrameEventType(15);
		/// @CSharpLua.Template = "FRAMEEVENT_EDITBOX_ENTER"
		public static readonly frameeventtype FRAMEEVENT_EDITBOX_ENTER = ConvertFrameEventType(16);
		/// @CSharpLua.Template = "OSKEY_BACKSPACE"
		public static readonly oskeytype OSKEY_BACKSPACE = ConvertOsKeyType(0x08);
		/// @CSharpLua.Template = "OSKEY_TAB"
		public static readonly oskeytype OSKEY_TAB = ConvertOsKeyType(0x09);
		/// @CSharpLua.Template = "OSKEY_CLEAR"
		public static readonly oskeytype OSKEY_CLEAR = ConvertOsKeyType(0x0C);
		/// @CSharpLua.Template = "OSKEY_RETURN"
		public static readonly oskeytype OSKEY_RETURN = ConvertOsKeyType(0x0D);
		/// @CSharpLua.Template = "OSKEY_SHIFT"
		public static readonly oskeytype OSKEY_SHIFT = ConvertOsKeyType(0x10);
		/// @CSharpLua.Template = "OSKEY_CONTROL"
		public static readonly oskeytype OSKEY_CONTROL = ConvertOsKeyType(0x11);
		/// @CSharpLua.Template = "OSKEY_ALT"
		public static readonly oskeytype OSKEY_ALT = ConvertOsKeyType(0x12);
		/// @CSharpLua.Template = "OSKEY_PAUSE"
		public static readonly oskeytype OSKEY_PAUSE = ConvertOsKeyType(0x13);
		/// @CSharpLua.Template = "OSKEY_CAPSLOCK"
		public static readonly oskeytype OSKEY_CAPSLOCK = ConvertOsKeyType(0x14);
		/// @CSharpLua.Template = "OSKEY_KANA"
		public static readonly oskeytype OSKEY_KANA = ConvertOsKeyType(0x15);
		/// @CSharpLua.Template = "OSKEY_HANGUL"
		public static readonly oskeytype OSKEY_HANGUL = ConvertOsKeyType(0x15);
		/// @CSharpLua.Template = "OSKEY_JUNJA"
		public static readonly oskeytype OSKEY_JUNJA = ConvertOsKeyType(0x17);
		/// @CSharpLua.Template = "OSKEY_FINAL"
		public static readonly oskeytype OSKEY_FINAL = ConvertOsKeyType(0x18);
		/// @CSharpLua.Template = "OSKEY_HANJA"
		public static readonly oskeytype OSKEY_HANJA = ConvertOsKeyType(0x19);
		/// @CSharpLua.Template = "OSKEY_KANJI"
		public static readonly oskeytype OSKEY_KANJI = ConvertOsKeyType(0x19);
		/// @CSharpLua.Template = "OSKEY_ESCAPE"
		public static readonly oskeytype OSKEY_ESCAPE = ConvertOsKeyType(0x1B);
		/// @CSharpLua.Template = "OSKEY_CONVERT"
		public static readonly oskeytype OSKEY_CONVERT = ConvertOsKeyType(0x1C);
		/// @CSharpLua.Template = "OSKEY_NONCONVERT"
		public static readonly oskeytype OSKEY_NONCONVERT = ConvertOsKeyType(0x1D);
		/// @CSharpLua.Template = "OSKEY_ACCEPT"
		public static readonly oskeytype OSKEY_ACCEPT = ConvertOsKeyType(0x1E);
		/// @CSharpLua.Template = "OSKEY_MODECHANGE"
		public static readonly oskeytype OSKEY_MODECHANGE = ConvertOsKeyType(0x1F);
		/// @CSharpLua.Template = "OSKEY_SPACE"
		public static readonly oskeytype OSKEY_SPACE = ConvertOsKeyType(0x20);
		/// @CSharpLua.Template = "OSKEY_PAGEUP"
		public static readonly oskeytype OSKEY_PAGEUP = ConvertOsKeyType(0x21);
		/// @CSharpLua.Template = "OSKEY_PAGEDOWN"
		public static readonly oskeytype OSKEY_PAGEDOWN = ConvertOsKeyType(0x22);
		/// @CSharpLua.Template = "OSKEY_END"
		public static readonly oskeytype OSKEY_END = ConvertOsKeyType(0x23);
		/// @CSharpLua.Template = "OSKEY_HOME"
		public static readonly oskeytype OSKEY_HOME = ConvertOsKeyType(0x24);
		/// @CSharpLua.Template = "OSKEY_LEFT"
		public static readonly oskeytype OSKEY_LEFT = ConvertOsKeyType(0x25);
		/// @CSharpLua.Template = "OSKEY_UP"
		public static readonly oskeytype OSKEY_UP = ConvertOsKeyType(0x26);
		/// @CSharpLua.Template = "OSKEY_RIGHT"
		public static readonly oskeytype OSKEY_RIGHT = ConvertOsKeyType(0x27);
		/// @CSharpLua.Template = "OSKEY_DOWN"
		public static readonly oskeytype OSKEY_DOWN = ConvertOsKeyType(0x28);
		/// @CSharpLua.Template = "OSKEY_SELECT"
		public static readonly oskeytype OSKEY_SELECT = ConvertOsKeyType(0x29);
		/// @CSharpLua.Template = "OSKEY_PRINT"
		public static readonly oskeytype OSKEY_PRINT = ConvertOsKeyType(0x2A);
		/// @CSharpLua.Template = "OSKEY_EXECUTE"
		public static readonly oskeytype OSKEY_EXECUTE = ConvertOsKeyType(0x2B);
		/// @CSharpLua.Template = "OSKEY_PRINTSCREEN"
		public static readonly oskeytype OSKEY_PRINTSCREEN = ConvertOsKeyType(0x2C);
		/// @CSharpLua.Template = "OSKEY_INSERT"
		public static readonly oskeytype OSKEY_INSERT = ConvertOsKeyType(0x2D);
		/// @CSharpLua.Template = "OSKEY_DELETE"
		public static readonly oskeytype OSKEY_DELETE = ConvertOsKeyType(0x2E);
		/// @CSharpLua.Template = "OSKEY_HELP"
		public static readonly oskeytype OSKEY_HELP = ConvertOsKeyType(0x2F);
		/// @CSharpLua.Template = "OSKEY_0"
		public static readonly oskeytype OSKEY_0 = ConvertOsKeyType(0x30);
		/// @CSharpLua.Template = "OSKEY_1"
		public static readonly oskeytype OSKEY_1 = ConvertOsKeyType(0x31);
		/// @CSharpLua.Template = "OSKEY_2"
		public static readonly oskeytype OSKEY_2 = ConvertOsKeyType(0x32);
		/// @CSharpLua.Template = "OSKEY_3"
		public static readonly oskeytype OSKEY_3 = ConvertOsKeyType(0x33);
		/// @CSharpLua.Template = "OSKEY_4"
		public static readonly oskeytype OSKEY_4 = ConvertOsKeyType(0x34);
		/// @CSharpLua.Template = "OSKEY_5"
		public static readonly oskeytype OSKEY_5 = ConvertOsKeyType(0x35);
		/// @CSharpLua.Template = "OSKEY_6"
		public static readonly oskeytype OSKEY_6 = ConvertOsKeyType(0x36);
		/// @CSharpLua.Template = "OSKEY_7"
		public static readonly oskeytype OSKEY_7 = ConvertOsKeyType(0x37);
		/// @CSharpLua.Template = "OSKEY_8"
		public static readonly oskeytype OSKEY_8 = ConvertOsKeyType(0x38);
		/// @CSharpLua.Template = "OSKEY_9"
		public static readonly oskeytype OSKEY_9 = ConvertOsKeyType(0x39);
		/// @CSharpLua.Template = "OSKEY_A"
		public static readonly oskeytype OSKEY_A = ConvertOsKeyType(0x41);
		/// @CSharpLua.Template = "OSKEY_B"
		public static readonly oskeytype OSKEY_B = ConvertOsKeyType(0x42);
		/// @CSharpLua.Template = "OSKEY_C"
		public static readonly oskeytype OSKEY_C = ConvertOsKeyType(0x43);
		/// @CSharpLua.Template = "OSKEY_D"
		public static readonly oskeytype OSKEY_D = ConvertOsKeyType(0x44);
		/// @CSharpLua.Template = "OSKEY_E"
		public static readonly oskeytype OSKEY_E = ConvertOsKeyType(0x45);
		/// @CSharpLua.Template = "OSKEY_F"
		public static readonly oskeytype OSKEY_F = ConvertOsKeyType(0x46);
		/// @CSharpLua.Template = "OSKEY_G"
		public static readonly oskeytype OSKEY_G = ConvertOsKeyType(0x47);
		/// @CSharpLua.Template = "OSKEY_H"
		public static readonly oskeytype OSKEY_H = ConvertOsKeyType(0x48);
		/// @CSharpLua.Template = "OSKEY_I"
		public static readonly oskeytype OSKEY_I = ConvertOsKeyType(0x49);
		/// @CSharpLua.Template = "OSKEY_J"
		public static readonly oskeytype OSKEY_J = ConvertOsKeyType(0x4A);
		/// @CSharpLua.Template = "OSKEY_K"
		public static readonly oskeytype OSKEY_K = ConvertOsKeyType(0x4B);
		/// @CSharpLua.Template = "OSKEY_L"
		public static readonly oskeytype OSKEY_L = ConvertOsKeyType(0x4C);
		/// @CSharpLua.Template = "OSKEY_M"
		public static readonly oskeytype OSKEY_M = ConvertOsKeyType(0x4D);
		/// @CSharpLua.Template = "OSKEY_N"
		public static readonly oskeytype OSKEY_N = ConvertOsKeyType(0x4E);
		/// @CSharpLua.Template = "OSKEY_O"
		public static readonly oskeytype OSKEY_O = ConvertOsKeyType(0x4F);
		/// @CSharpLua.Template = "OSKEY_P"
		public static readonly oskeytype OSKEY_P = ConvertOsKeyType(0x50);
		/// @CSharpLua.Template = "OSKEY_Q"
		public static readonly oskeytype OSKEY_Q = ConvertOsKeyType(0x51);
		/// @CSharpLua.Template = "OSKEY_R"
		public static readonly oskeytype OSKEY_R = ConvertOsKeyType(0x52);
		/// @CSharpLua.Template = "OSKEY_S"
		public static readonly oskeytype OSKEY_S = ConvertOsKeyType(0x53);
		/// @CSharpLua.Template = "OSKEY_T"
		public static readonly oskeytype OSKEY_T = ConvertOsKeyType(0x54);
		/// @CSharpLua.Template = "OSKEY_U"
		public static readonly oskeytype OSKEY_U = ConvertOsKeyType(0x55);
		/// @CSharpLua.Template = "OSKEY_V"
		public static readonly oskeytype OSKEY_V = ConvertOsKeyType(0x56);
		/// @CSharpLua.Template = "OSKEY_W"
		public static readonly oskeytype OSKEY_W = ConvertOsKeyType(0x57);
		/// @CSharpLua.Template = "OSKEY_X"
		public static readonly oskeytype OSKEY_X = ConvertOsKeyType(0x58);
		/// @CSharpLua.Template = "OSKEY_Y"
		public static readonly oskeytype OSKEY_Y = ConvertOsKeyType(0x59);
		/// @CSharpLua.Template = "OSKEY_Z"
		public static readonly oskeytype OSKEY_Z = ConvertOsKeyType(0x5A);
		/// @CSharpLua.Template = "OSKEY_LMETA"
		public static readonly oskeytype OSKEY_LMETA = ConvertOsKeyType(0x5B);
		/// @CSharpLua.Template = "OSKEY_RMETA"
		public static readonly oskeytype OSKEY_RMETA = ConvertOsKeyType(0x5C);
		/// @CSharpLua.Template = "OSKEY_APPS"
		public static readonly oskeytype OSKEY_APPS = ConvertOsKeyType(0x5D);
		/// @CSharpLua.Template = "OSKEY_SLEEP"
		public static readonly oskeytype OSKEY_SLEEP = ConvertOsKeyType(0x5F);
		/// @CSharpLua.Template = "OSKEY_NUMPAD0"
		public static readonly oskeytype OSKEY_NUMPAD0 = ConvertOsKeyType(0x60);
		/// @CSharpLua.Template = "OSKEY_NUMPAD1"
		public static readonly oskeytype OSKEY_NUMPAD1 = ConvertOsKeyType(0x61);
		/// @CSharpLua.Template = "OSKEY_NUMPAD2"
		public static readonly oskeytype OSKEY_NUMPAD2 = ConvertOsKeyType(0x62);
		/// @CSharpLua.Template = "OSKEY_NUMPAD3"
		public static readonly oskeytype OSKEY_NUMPAD3 = ConvertOsKeyType(0x63);
		/// @CSharpLua.Template = "OSKEY_NUMPAD4"
		public static readonly oskeytype OSKEY_NUMPAD4 = ConvertOsKeyType(0x64);
		/// @CSharpLua.Template = "OSKEY_NUMPAD5"
		public static readonly oskeytype OSKEY_NUMPAD5 = ConvertOsKeyType(0x65);
		/// @CSharpLua.Template = "OSKEY_NUMPAD6"
		public static readonly oskeytype OSKEY_NUMPAD6 = ConvertOsKeyType(0x66);
		/// @CSharpLua.Template = "OSKEY_NUMPAD7"
		public static readonly oskeytype OSKEY_NUMPAD7 = ConvertOsKeyType(0x67);
		/// @CSharpLua.Template = "OSKEY_NUMPAD8"
		public static readonly oskeytype OSKEY_NUMPAD8 = ConvertOsKeyType(0x68);
		/// @CSharpLua.Template = "OSKEY_NUMPAD9"
		public static readonly oskeytype OSKEY_NUMPAD9 = ConvertOsKeyType(0x69);
		/// @CSharpLua.Template = "OSKEY_MULTIPLY"
		public static readonly oskeytype OSKEY_MULTIPLY = ConvertOsKeyType(0x6A);
		/// @CSharpLua.Template = "OSKEY_ADD"
		public static readonly oskeytype OSKEY_ADD = ConvertOsKeyType(0x6B);
		/// @CSharpLua.Template = "OSKEY_SEPARATOR"
		public static readonly oskeytype OSKEY_SEPARATOR = ConvertOsKeyType(0x6C);
		/// @CSharpLua.Template = "OSKEY_SUBTRACT"
		public static readonly oskeytype OSKEY_SUBTRACT = ConvertOsKeyType(0x6D);
		/// @CSharpLua.Template = "OSKEY_DECIMAL"
		public static readonly oskeytype OSKEY_DECIMAL = ConvertOsKeyType(0x6E);
		/// @CSharpLua.Template = "OSKEY_DIVIDE"
		public static readonly oskeytype OSKEY_DIVIDE = ConvertOsKeyType(0x6F);
		/// @CSharpLua.Template = "OSKEY_F1"
		public static readonly oskeytype OSKEY_F1 = ConvertOsKeyType(0x70);
		/// @CSharpLua.Template = "OSKEY_F2"
		public static readonly oskeytype OSKEY_F2 = ConvertOsKeyType(0x71);
		/// @CSharpLua.Template = "OSKEY_F3"
		public static readonly oskeytype OSKEY_F3 = ConvertOsKeyType(0x72);
		/// @CSharpLua.Template = "OSKEY_F4"
		public static readonly oskeytype OSKEY_F4 = ConvertOsKeyType(0x73);
		/// @CSharpLua.Template = "OSKEY_F5"
		public static readonly oskeytype OSKEY_F5 = ConvertOsKeyType(0x74);
		/// @CSharpLua.Template = "OSKEY_F6"
		public static readonly oskeytype OSKEY_F6 = ConvertOsKeyType(0x75);
		/// @CSharpLua.Template = "OSKEY_F7"
		public static readonly oskeytype OSKEY_F7 = ConvertOsKeyType(0x76);
		/// @CSharpLua.Template = "OSKEY_F8"
		public static readonly oskeytype OSKEY_F8 = ConvertOsKeyType(0x77);
		/// @CSharpLua.Template = "OSKEY_F9"
		public static readonly oskeytype OSKEY_F9 = ConvertOsKeyType(0x78);
		/// @CSharpLua.Template = "OSKEY_F10"
		public static readonly oskeytype OSKEY_F10 = ConvertOsKeyType(0x79);
		/// @CSharpLua.Template = "OSKEY_F11"
		public static readonly oskeytype OSKEY_F11 = ConvertOsKeyType(0x7A);
		/// @CSharpLua.Template = "OSKEY_F12"
		public static readonly oskeytype OSKEY_F12 = ConvertOsKeyType(0x7B);
		/// @CSharpLua.Template = "OSKEY_F13"
		public static readonly oskeytype OSKEY_F13 = ConvertOsKeyType(0x7C);
		/// @CSharpLua.Template = "OSKEY_F14"
		public static readonly oskeytype OSKEY_F14 = ConvertOsKeyType(0x7D);
		/// @CSharpLua.Template = "OSKEY_F15"
		public static readonly oskeytype OSKEY_F15 = ConvertOsKeyType(0x7E);
		/// @CSharpLua.Template = "OSKEY_F16"
		public static readonly oskeytype OSKEY_F16 = ConvertOsKeyType(0x7F);
		/// @CSharpLua.Template = "OSKEY_F17"
		public static readonly oskeytype OSKEY_F17 = ConvertOsKeyType(0x80);
		/// @CSharpLua.Template = "OSKEY_F18"
		public static readonly oskeytype OSKEY_F18 = ConvertOsKeyType(0x81);
		/// @CSharpLua.Template = "OSKEY_F19"
		public static readonly oskeytype OSKEY_F19 = ConvertOsKeyType(0x82);
		/// @CSharpLua.Template = "OSKEY_F20"
		public static readonly oskeytype OSKEY_F20 = ConvertOsKeyType(0x83);
		/// @CSharpLua.Template = "OSKEY_F21"
		public static readonly oskeytype OSKEY_F21 = ConvertOsKeyType(0x84);
		/// @CSharpLua.Template = "OSKEY_F22"
		public static readonly oskeytype OSKEY_F22 = ConvertOsKeyType(0x85);
		/// @CSharpLua.Template = "OSKEY_F23"
		public static readonly oskeytype OSKEY_F23 = ConvertOsKeyType(0x86);
		/// @CSharpLua.Template = "OSKEY_F24"
		public static readonly oskeytype OSKEY_F24 = ConvertOsKeyType(0x87);
		/// @CSharpLua.Template = "OSKEY_NUMLOCK"
		public static readonly oskeytype OSKEY_NUMLOCK = ConvertOsKeyType(0x90);
		/// @CSharpLua.Template = "OSKEY_SCROLLLOCK"
		public static readonly oskeytype OSKEY_SCROLLLOCK = ConvertOsKeyType(0x91);
		/// @CSharpLua.Template = "OSKEY_OEM_NEC_EQUAL"
		public static readonly oskeytype OSKEY_OEM_NEC_EQUAL = ConvertOsKeyType(0x92);
		/// @CSharpLua.Template = "OSKEY_OEM_FJ_JISHO"
		public static readonly oskeytype OSKEY_OEM_FJ_JISHO = ConvertOsKeyType(0x92);
		/// @CSharpLua.Template = "OSKEY_OEM_FJ_MASSHOU"
		public static readonly oskeytype OSKEY_OEM_FJ_MASSHOU = ConvertOsKeyType(0x93);
		/// @CSharpLua.Template = "OSKEY_OEM_FJ_TOUROKU"
		public static readonly oskeytype OSKEY_OEM_FJ_TOUROKU = ConvertOsKeyType(0x94);
		/// @CSharpLua.Template = "OSKEY_OEM_FJ_LOYA"
		public static readonly oskeytype OSKEY_OEM_FJ_LOYA = ConvertOsKeyType(0x95);
		/// @CSharpLua.Template = "OSKEY_OEM_FJ_ROYA"
		public static readonly oskeytype OSKEY_OEM_FJ_ROYA = ConvertOsKeyType(0x96);
		/// @CSharpLua.Template = "OSKEY_LSHIFT"
		public static readonly oskeytype OSKEY_LSHIFT = ConvertOsKeyType(0xA0);
		/// @CSharpLua.Template = "OSKEY_RSHIFT"
		public static readonly oskeytype OSKEY_RSHIFT = ConvertOsKeyType(0xA1);
		/// @CSharpLua.Template = "OSKEY_LCONTROL"
		public static readonly oskeytype OSKEY_LCONTROL = ConvertOsKeyType(0xA2);
		/// @CSharpLua.Template = "OSKEY_RCONTROL"
		public static readonly oskeytype OSKEY_RCONTROL = ConvertOsKeyType(0xA3);
		/// @CSharpLua.Template = "OSKEY_LALT"
		public static readonly oskeytype OSKEY_LALT = ConvertOsKeyType(0xA4);
		/// @CSharpLua.Template = "OSKEY_RALT"
		public static readonly oskeytype OSKEY_RALT = ConvertOsKeyType(0xA5);
		/// @CSharpLua.Template = "OSKEY_BROWSER_BACK"
		public static readonly oskeytype OSKEY_BROWSER_BACK = ConvertOsKeyType(0xA6);
		/// @CSharpLua.Template = "OSKEY_BROWSER_FORWARD"
		public static readonly oskeytype OSKEY_BROWSER_FORWARD = ConvertOsKeyType(0xA7);
		/// @CSharpLua.Template = "OSKEY_BROWSER_REFRESH"
		public static readonly oskeytype OSKEY_BROWSER_REFRESH = ConvertOsKeyType(0xA8);
		/// @CSharpLua.Template = "OSKEY_BROWSER_STOP"
		public static readonly oskeytype OSKEY_BROWSER_STOP = ConvertOsKeyType(0xA9);
		/// @CSharpLua.Template = "OSKEY_BROWSER_SEARCH"
		public static readonly oskeytype OSKEY_BROWSER_SEARCH = ConvertOsKeyType(0xAA);
		/// @CSharpLua.Template = "OSKEY_BROWSER_FAVORITES"
		public static readonly oskeytype OSKEY_BROWSER_FAVORITES = ConvertOsKeyType(0xAB);
		/// @CSharpLua.Template = "OSKEY_BROWSER_HOME"
		public static readonly oskeytype OSKEY_BROWSER_HOME = ConvertOsKeyType(0xAC);
		/// @CSharpLua.Template = "OSKEY_VOLUME_MUTE"
		public static readonly oskeytype OSKEY_VOLUME_MUTE = ConvertOsKeyType(0xAD);
		/// @CSharpLua.Template = "OSKEY_VOLUME_DOWN"
		public static readonly oskeytype OSKEY_VOLUME_DOWN = ConvertOsKeyType(0xAE);
		/// @CSharpLua.Template = "OSKEY_VOLUME_UP"
		public static readonly oskeytype OSKEY_VOLUME_UP = ConvertOsKeyType(0xAF);
		/// @CSharpLua.Template = "OSKEY_MEDIA_NEXT_TRACK"
		public static readonly oskeytype OSKEY_MEDIA_NEXT_TRACK = ConvertOsKeyType(0xB0);
		/// @CSharpLua.Template = "OSKEY_MEDIA_PREV_TRACK"
		public static readonly oskeytype OSKEY_MEDIA_PREV_TRACK = ConvertOsKeyType(0xB1);
		/// @CSharpLua.Template = "OSKEY_MEDIA_STOP"
		public static readonly oskeytype OSKEY_MEDIA_STOP = ConvertOsKeyType(0xB2);
		/// @CSharpLua.Template = "OSKEY_MEDIA_PLAY_PAUSE"
		public static readonly oskeytype OSKEY_MEDIA_PLAY_PAUSE = ConvertOsKeyType(0xB3);
		/// @CSharpLua.Template = "OSKEY_LAUNCH_MAIL"
		public static readonly oskeytype OSKEY_LAUNCH_MAIL = ConvertOsKeyType(0xB4);
		/// @CSharpLua.Template = "OSKEY_LAUNCH_MEDIA_SELECT"
		public static readonly oskeytype OSKEY_LAUNCH_MEDIA_SELECT = ConvertOsKeyType(0xB5);
		/// @CSharpLua.Template = "OSKEY_LAUNCH_APP1"
		public static readonly oskeytype OSKEY_LAUNCH_APP1 = ConvertOsKeyType(0xB6);
		/// @CSharpLua.Template = "OSKEY_LAUNCH_APP2"
		public static readonly oskeytype OSKEY_LAUNCH_APP2 = ConvertOsKeyType(0xB7);
		/// @CSharpLua.Template = "OSKEY_OEM_1"
		public static readonly oskeytype OSKEY_OEM_1 = ConvertOsKeyType(0xBA);
		/// @CSharpLua.Template = "OSKEY_OEM_PLUS"
		public static readonly oskeytype OSKEY_OEM_PLUS = ConvertOsKeyType(0xBB);
		/// @CSharpLua.Template = "OSKEY_OEM_COMMA"
		public static readonly oskeytype OSKEY_OEM_COMMA = ConvertOsKeyType(0xBC);
		/// @CSharpLua.Template = "OSKEY_OEM_MINUS"
		public static readonly oskeytype OSKEY_OEM_MINUS = ConvertOsKeyType(0xBD);
		/// @CSharpLua.Template = "OSKEY_OEM_PERIOD"
		public static readonly oskeytype OSKEY_OEM_PERIOD = ConvertOsKeyType(0xBE);
		/// @CSharpLua.Template = "OSKEY_OEM_2"
		public static readonly oskeytype OSKEY_OEM_2 = ConvertOsKeyType(0xBF);
		/// @CSharpLua.Template = "OSKEY_OEM_3"
		public static readonly oskeytype OSKEY_OEM_3 = ConvertOsKeyType(0xC0);
		/// @CSharpLua.Template = "OSKEY_OEM_4"
		public static readonly oskeytype OSKEY_OEM_4 = ConvertOsKeyType(0xDB);
		/// @CSharpLua.Template = "OSKEY_OEM_5"
		public static readonly oskeytype OSKEY_OEM_5 = ConvertOsKeyType(0xDC);
		/// @CSharpLua.Template = "OSKEY_OEM_6"
		public static readonly oskeytype OSKEY_OEM_6 = ConvertOsKeyType(0xDD);
		/// @CSharpLua.Template = "OSKEY_OEM_7"
		public static readonly oskeytype OSKEY_OEM_7 = ConvertOsKeyType(0xDE);
		/// @CSharpLua.Template = "OSKEY_OEM_8"
		public static readonly oskeytype OSKEY_OEM_8 = ConvertOsKeyType(0xDF);
		/// @CSharpLua.Template = "OSKEY_OEM_AX"
		public static readonly oskeytype OSKEY_OEM_AX = ConvertOsKeyType(0xE1);
		/// @CSharpLua.Template = "OSKEY_OEM_102"
		public static readonly oskeytype OSKEY_OEM_102 = ConvertOsKeyType(0xE2);
		/// @CSharpLua.Template = "OSKEY_ICO_HELP"
		public static readonly oskeytype OSKEY_ICO_HELP = ConvertOsKeyType(0xE3);
		/// @CSharpLua.Template = "OSKEY_ICO_00"
		public static readonly oskeytype OSKEY_ICO_00 = ConvertOsKeyType(0xE4);
		/// @CSharpLua.Template = "OSKEY_PROCESSKEY"
		public static readonly oskeytype OSKEY_PROCESSKEY = ConvertOsKeyType(0xE5);
		/// @CSharpLua.Template = "OSKEY_ICO_CLEAR"
		public static readonly oskeytype OSKEY_ICO_CLEAR = ConvertOsKeyType(0xE6);
		/// @CSharpLua.Template = "OSKEY_PACKET"
		public static readonly oskeytype OSKEY_PACKET = ConvertOsKeyType(0xE7);
		/// @CSharpLua.Template = "OSKEY_OEM_RESET"
		public static readonly oskeytype OSKEY_OEM_RESET = ConvertOsKeyType(0xE9);
		/// @CSharpLua.Template = "OSKEY_OEM_JUMP"
		public static readonly oskeytype OSKEY_OEM_JUMP = ConvertOsKeyType(0xEA);
		/// @CSharpLua.Template = "OSKEY_OEM_PA1"
		public static readonly oskeytype OSKEY_OEM_PA1 = ConvertOsKeyType(0xEB);
		/// @CSharpLua.Template = "OSKEY_OEM_PA2"
		public static readonly oskeytype OSKEY_OEM_PA2 = ConvertOsKeyType(0xEC);
		/// @CSharpLua.Template = "OSKEY_OEM_PA3"
		public static readonly oskeytype OSKEY_OEM_PA3 = ConvertOsKeyType(0xED);
		/// @CSharpLua.Template = "OSKEY_OEM_WSCTRL"
		public static readonly oskeytype OSKEY_OEM_WSCTRL = ConvertOsKeyType(0xEE);
		/// @CSharpLua.Template = "OSKEY_OEM_CUSEL"
		public static readonly oskeytype OSKEY_OEM_CUSEL = ConvertOsKeyType(0xEF);
		/// @CSharpLua.Template = "OSKEY_OEM_ATTN"
		public static readonly oskeytype OSKEY_OEM_ATTN = ConvertOsKeyType(0xF0);
		/// @CSharpLua.Template = "OSKEY_OEM_FINISH"
		public static readonly oskeytype OSKEY_OEM_FINISH = ConvertOsKeyType(0xF1);
		/// @CSharpLua.Template = "OSKEY_OEM_COPY"
		public static readonly oskeytype OSKEY_OEM_COPY = ConvertOsKeyType(0xF2);
		/// @CSharpLua.Template = "OSKEY_OEM_AUTO"
		public static readonly oskeytype OSKEY_OEM_AUTO = ConvertOsKeyType(0xF3);
		/// @CSharpLua.Template = "OSKEY_OEM_ENLW"
		public static readonly oskeytype OSKEY_OEM_ENLW = ConvertOsKeyType(0xF4);
		/// @CSharpLua.Template = "OSKEY_OEM_BACKTAB"
		public static readonly oskeytype OSKEY_OEM_BACKTAB = ConvertOsKeyType(0xF5);
		/// @CSharpLua.Template = "OSKEY_ATTN"
		public static readonly oskeytype OSKEY_ATTN = ConvertOsKeyType(0xF6);
		/// @CSharpLua.Template = "OSKEY_CRSEL"
		public static readonly oskeytype OSKEY_CRSEL = ConvertOsKeyType(0xF7);
		/// @CSharpLua.Template = "OSKEY_EXSEL"
		public static readonly oskeytype OSKEY_EXSEL = ConvertOsKeyType(0xF8);
		/// @CSharpLua.Template = "OSKEY_EREOF"
		public static readonly oskeytype OSKEY_EREOF = ConvertOsKeyType(0xF9);
		/// @CSharpLua.Template = "OSKEY_PLAY"
		public static readonly oskeytype OSKEY_PLAY = ConvertOsKeyType(0xFA);
		/// @CSharpLua.Template = "OSKEY_ZOOM"
		public static readonly oskeytype OSKEY_ZOOM = ConvertOsKeyType(0xFB);
		/// @CSharpLua.Template = "OSKEY_NONAME"
		public static readonly oskeytype OSKEY_NONAME = ConvertOsKeyType(0xFC);
		/// @CSharpLua.Template = "OSKEY_PA1"
		public static readonly oskeytype OSKEY_PA1 = ConvertOsKeyType(0xFD);
		/// @CSharpLua.Template = "OSKEY_OEM_CLEAR"
		public static readonly oskeytype OSKEY_OEM_CLEAR = ConvertOsKeyType(0xFE);
		/// @CSharpLua.Template = "ABILITY_IF_BUTTON_POSITION_NORMAL_X"
		public static readonly abilityintegerfield ABILITY_IF_BUTTON_POSITION_NORMAL_X = ConvertAbilityIntegerField(1633841272);
		/// @CSharpLua.Template = "ABILITY_IF_BUTTON_POSITION_NORMAL_Y"
		public static readonly abilityintegerfield ABILITY_IF_BUTTON_POSITION_NORMAL_Y = ConvertAbilityIntegerField(1633841273);
		/// @CSharpLua.Template = "ABILITY_IF_BUTTON_POSITION_ACTIVATED_X"
		public static readonly abilityintegerfield ABILITY_IF_BUTTON_POSITION_ACTIVATED_X = ConvertAbilityIntegerField(1635082872);
		/// @CSharpLua.Template = "ABILITY_IF_BUTTON_POSITION_ACTIVATED_Y"
		public static readonly abilityintegerfield ABILITY_IF_BUTTON_POSITION_ACTIVATED_Y = ConvertAbilityIntegerField(1635082873);
		/// @CSharpLua.Template = "ABILITY_IF_BUTTON_POSITION_RESEARCH_X"
		public static readonly abilityintegerfield ABILITY_IF_BUTTON_POSITION_RESEARCH_X = ConvertAbilityIntegerField(1634889848);
		/// @CSharpLua.Template = "ABILITY_IF_BUTTON_POSITION_RESEARCH_Y"
		public static readonly abilityintegerfield ABILITY_IF_BUTTON_POSITION_RESEARCH_Y = ConvertAbilityIntegerField(1634889849);
		/// @CSharpLua.Template = "ABILITY_IF_MISSILE_SPEED"
		public static readonly abilityintegerfield ABILITY_IF_MISSILE_SPEED = ConvertAbilityIntegerField(1634562928);
		/// @CSharpLua.Template = "ABILITY_IF_TARGET_ATTACHMENTS"
		public static readonly abilityintegerfield ABILITY_IF_TARGET_ATTACHMENTS = ConvertAbilityIntegerField(1635017059);
		/// @CSharpLua.Template = "ABILITY_IF_CASTER_ATTACHMENTS"
		public static readonly abilityintegerfield ABILITY_IF_CASTER_ATTACHMENTS = ConvertAbilityIntegerField(1633902947);
		/// @CSharpLua.Template = "ABILITY_IF_PRIORITY"
		public static readonly abilityintegerfield ABILITY_IF_PRIORITY = ConvertAbilityIntegerField(1634759273);
		/// @CSharpLua.Template = "ABILITY_IF_LEVELS"
		public static readonly abilityintegerfield ABILITY_IF_LEVELS = ConvertAbilityIntegerField(1634493814);
		/// @CSharpLua.Template = "ABILITY_IF_REQUIRED_LEVEL"
		public static readonly abilityintegerfield ABILITY_IF_REQUIRED_LEVEL = ConvertAbilityIntegerField(1634888822);
		/// @CSharpLua.Template = "ABILITY_IF_LEVEL_SKIP_REQUIREMENT"
		public static readonly abilityintegerfield ABILITY_IF_LEVEL_SKIP_REQUIREMENT = ConvertAbilityIntegerField(1634497387);
		/// @CSharpLua.Template = "ABILITY_BF_HERO_ABILITY"
		public static readonly abilitybooleanfield ABILITY_BF_HERO_ABILITY = ConvertAbilityBooleanField(1634231666);
		/// @CSharpLua.Template = "ABILITY_BF_ITEM_ABILITY"
		public static readonly abilitybooleanfield ABILITY_BF_ITEM_ABILITY = ConvertAbilityBooleanField(1634301029);
		/// @CSharpLua.Template = "ABILITY_BF_CHECK_DEPENDENCIES"
		public static readonly abilitybooleanfield ABILITY_BF_CHECK_DEPENDENCIES = ConvertAbilityBooleanField(1633904740);
		/// @CSharpLua.Template = "ABILITY_RF_ARF_MISSILE_ARC"
		public static readonly abilityrealfield ABILITY_RF_ARF_MISSILE_ARC = ConvertAbilityRealField(1634558307);
		/// @CSharpLua.Template = "ABILITY_SF_NAME"
		public static readonly abilitystringfield ABILITY_SF_NAME = ConvertAbilityStringField(1634623853);
		/// @CSharpLua.Template = "ABILITY_SF_ICON_ACTIVATED"
		public static readonly abilitystringfield ABILITY_SF_ICON_ACTIVATED = ConvertAbilityStringField(1635082610);
		/// @CSharpLua.Template = "ABILITY_SF_ICON_RESEARCH"
		public static readonly abilitystringfield ABILITY_SF_ICON_RESEARCH = ConvertAbilityStringField(1634886002);
		/// @CSharpLua.Template = "ABILITY_SF_EFFECT_SOUND"
		public static readonly abilitystringfield ABILITY_SF_EFFECT_SOUND = ConvertAbilityStringField(1634035315);
		/// @CSharpLua.Template = "ABILITY_SF_EFFECT_SOUND_LOOPING"
		public static readonly abilitystringfield ABILITY_SF_EFFECT_SOUND_LOOPING = ConvertAbilityStringField(1634035308);
		/// @CSharpLua.Template = "ABILITY_ILF_MANA_COST"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MANA_COST = ConvertAbilityIntegerLevelField(1634558835);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_WAVES"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_WAVES = ConvertAbilityIntegerLevelField(1214413361);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_SHARDS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_SHARDS = ConvertAbilityIntegerLevelField(1214413363);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_UNITS_TELEPORTED"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_UNITS_TELEPORTED = ConvertAbilityIntegerLevelField(1215132721);
		/// @CSharpLua.Template = "ABILITY_ILF_SUMMONED_UNIT_COUNT_HWE2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SUMMONED_UNIT_COUNT_HWE2 = ConvertAbilityIntegerLevelField(1215784242);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_IMAGES"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_IMAGES = ConvertAbilityIntegerLevelField(1332570417);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_CORPSES_RAISED_UAN1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_CORPSES_RAISED_UAN1 = ConvertAbilityIntegerLevelField(1432448561);
		/// @CSharpLua.Template = "ABILITY_ILF_MORPHING_FLAGS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MORPHING_FLAGS = ConvertAbilityIntegerLevelField(1164797234);
		/// @CSharpLua.Template = "ABILITY_ILF_STRENGTH_BONUS_NRG5"
		public static readonly abilityintegerlevelfield ABILITY_ILF_STRENGTH_BONUS_NRG5 = ConvertAbilityIntegerLevelField(1316120373);
		/// @CSharpLua.Template = "ABILITY_ILF_DEFENSE_BONUS_NRG6"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DEFENSE_BONUS_NRG6 = ConvertAbilityIntegerLevelField(1316120374);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_TARGETS_HIT"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_TARGETS_HIT = ConvertAbilityIntegerLevelField(1331915826);
		/// @CSharpLua.Template = "ABILITY_ILF_DETECTION_TYPE_OFS1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DETECTION_TYPE_OFS1 = ConvertAbilityIntegerLevelField(1332114225);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_OSF2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_OSF2 = ConvertAbilityIntegerLevelField(1332962866);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_EFN1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_EFN1 = ConvertAbilityIntegerLevelField(1164340785);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_CORPSES_RAISED_HRE1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_CORPSES_RAISED_HRE1 = ConvertAbilityIntegerLevelField(1215456561);
		/// @CSharpLua.Template = "ABILITY_ILF_STACK_FLAGS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_STACK_FLAGS = ConvertAbilityIntegerLevelField(1214472500);
		/// @CSharpLua.Template = "ABILITY_ILF_MINIMUM_NUMBER_OF_UNITS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MINIMUM_NUMBER_OF_UNITS = ConvertAbilityIntegerLevelField(1315205170);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_NUMBER_OF_UNITS_NDP3"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_NUMBER_OF_UNITS_NDP3 = ConvertAbilityIntegerLevelField(1315205171);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_UNITS_CREATED_NRC2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_UNITS_CREATED_NRC2 = ConvertAbilityIntegerLevelField(1316119346);
		/// @CSharpLua.Template = "ABILITY_ILF_SHIELD_LIFE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SHIELD_LIFE = ConvertAbilityIntegerLevelField(1097691955);
		/// @CSharpLua.Template = "ABILITY_ILF_MANA_LOSS_AMS4"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MANA_LOSS_AMS4 = ConvertAbilityIntegerLevelField(1097691956);
		/// @CSharpLua.Template = "ABILITY_ILF_GOLD_PER_INTERVAL_BGM1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_GOLD_PER_INTERVAL_BGM1 = ConvertAbilityIntegerLevelField(1114074417);
		/// @CSharpLua.Template = "ABILITY_ILF_MAX_NUMBER_OF_MINERS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAX_NUMBER_OF_MINERS = ConvertAbilityIntegerLevelField(1114074419);
		/// @CSharpLua.Template = "ABILITY_ILF_CARGO_CAPACITY"
		public static readonly abilityintegerlevelfield ABILITY_ILF_CARGO_CAPACITY = ConvertAbilityIntegerLevelField(1130459697);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_CREEP_LEVEL_DEV3"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_CREEP_LEVEL_DEV3 = ConvertAbilityIntegerLevelField(1147500083);
		/// @CSharpLua.Template = "ABILITY_ILF_MAX_CREEP_LEVEL_DEV1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAX_CREEP_LEVEL_DEV1 = ConvertAbilityIntegerLevelField(1147500081);
		/// @CSharpLua.Template = "ABILITY_ILF_GOLD_PER_INTERVAL_EGM1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_GOLD_PER_INTERVAL_EGM1 = ConvertAbilityIntegerLevelField(1164406065);
		/// @CSharpLua.Template = "ABILITY_ILF_DEFENSE_REDUCTION"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DEFENSE_REDUCTION = ConvertAbilityIntegerLevelField(1180788017);
		/// @CSharpLua.Template = "ABILITY_ILF_DETECTION_TYPE_FLA1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DETECTION_TYPE_FLA1 = ConvertAbilityIntegerLevelField(1181507889);
		/// @CSharpLua.Template = "ABILITY_ILF_FLARE_COUNT"
		public static readonly abilityintegerlevelfield ABILITY_ILF_FLARE_COUNT = ConvertAbilityIntegerLevelField(1181507891);
		/// @CSharpLua.Template = "ABILITY_ILF_MAX_GOLD"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAX_GOLD = ConvertAbilityIntegerLevelField(1198285873);
		/// @CSharpLua.Template = "ABILITY_ILF_MINING_CAPACITY"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MINING_CAPACITY = ConvertAbilityIntegerLevelField(1198285875);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_NUMBER_OF_CORPSES_GYD1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_NUMBER_OF_CORPSES_GYD1 = ConvertAbilityIntegerLevelField(1199137841);
		/// @CSharpLua.Template = "ABILITY_ILF_DAMAGE_TO_TREE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DAMAGE_TO_TREE = ConvertAbilityIntegerLevelField(1214345777);
		/// @CSharpLua.Template = "ABILITY_ILF_LUMBER_CAPACITY"
		public static readonly abilityintegerlevelfield ABILITY_ILF_LUMBER_CAPACITY = ConvertAbilityIntegerLevelField(1214345778);
		/// @CSharpLua.Template = "ABILITY_ILF_GOLD_CAPACITY"
		public static readonly abilityintegerlevelfield ABILITY_ILF_GOLD_CAPACITY = ConvertAbilityIntegerLevelField(1214345779);
		/// @CSharpLua.Template = "ABILITY_ILF_DEFENSE_INCREASE_INF2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DEFENSE_INCREASE_INF2 = ConvertAbilityIntegerLevelField(1231971890);
		/// @CSharpLua.Template = "ABILITY_ILF_INTERACTION_TYPE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_INTERACTION_TYPE = ConvertAbilityIntegerLevelField(1315271986);
		/// @CSharpLua.Template = "ABILITY_ILF_GOLD_COST_NDT1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_GOLD_COST_NDT1 = ConvertAbilityIntegerLevelField(1315206193);
		/// @CSharpLua.Template = "ABILITY_ILF_LUMBER_COST_NDT2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_LUMBER_COST_NDT2 = ConvertAbilityIntegerLevelField(1315206194);
		/// @CSharpLua.Template = "ABILITY_ILF_DETECTION_TYPE_NDT3"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DETECTION_TYPE_NDT3 = ConvertAbilityIntegerLevelField(1315206195);
		/// @CSharpLua.Template = "ABILITY_ILF_STACKING_TYPE_POI4"
		public static readonly abilityintegerlevelfield ABILITY_ILF_STACKING_TYPE_POI4 = ConvertAbilityIntegerLevelField(1349478708);
		/// @CSharpLua.Template = "ABILITY_ILF_STACKING_TYPE_POA5"
		public static readonly abilityintegerlevelfield ABILITY_ILF_STACKING_TYPE_POA5 = ConvertAbilityIntegerLevelField(1349476661);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_CREEP_LEVEL_PLY1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_CREEP_LEVEL_PLY1 = ConvertAbilityIntegerLevelField(1349286193);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_CREEP_LEVEL_POS1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_CREEP_LEVEL_POS1 = ConvertAbilityIntegerLevelField(1349481265);
		/// @CSharpLua.Template = "ABILITY_ILF_MOVEMENT_UPDATE_FREQUENCY_PRG1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MOVEMENT_UPDATE_FREQUENCY_PRG1 = ConvertAbilityIntegerLevelField(1349674801);
		/// @CSharpLua.Template = "ABILITY_ILF_ATTACK_UPDATE_FREQUENCY_PRG2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ATTACK_UPDATE_FREQUENCY_PRG2 = ConvertAbilityIntegerLevelField(1349674802);
		/// @CSharpLua.Template = "ABILITY_ILF_MANA_LOSS_PRG6"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MANA_LOSS_PRG6 = ConvertAbilityIntegerLevelField(1349674806);
		/// @CSharpLua.Template = "ABILITY_ILF_UNITS_SUMMONED_TYPE_ONE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_UNITS_SUMMONED_TYPE_ONE = ConvertAbilityIntegerLevelField(1382115633);
		/// @CSharpLua.Template = "ABILITY_ILF_UNITS_SUMMONED_TYPE_TWO"
		public static readonly abilityintegerlevelfield ABILITY_ILF_UNITS_SUMMONED_TYPE_TWO = ConvertAbilityIntegerLevelField(1382115634);
		/// @CSharpLua.Template = "ABILITY_ILF_MAX_UNITS_SUMMONED"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAX_UNITS_SUMMONED = ConvertAbilityIntegerLevelField(1432576565);
		/// @CSharpLua.Template = "ABILITY_ILF_ALLOW_WHEN_FULL_REJ3"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ALLOW_WHEN_FULL_REJ3 = ConvertAbilityIntegerLevelField(1382378035);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_UNITS_CHARGED_TO_CASTER"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_UNITS_CHARGED_TO_CASTER = ConvertAbilityIntegerLevelField(1383096885);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_UNITS_AFFECTED"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_UNITS_AFFECTED = ConvertAbilityIntegerLevelField(1383096886);
		/// @CSharpLua.Template = "ABILITY_ILF_DEFENSE_INCREASE_ROA2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DEFENSE_INCREASE_ROA2 = ConvertAbilityIntegerLevelField(1383031090);
		/// @CSharpLua.Template = "ABILITY_ILF_MAX_UNITS_ROA7"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAX_UNITS_ROA7 = ConvertAbilityIntegerLevelField(1383031095);
		/// @CSharpLua.Template = "ABILITY_ILF_ROOTED_WEAPONS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ROOTED_WEAPONS = ConvertAbilityIntegerLevelField(1383034673);
		/// @CSharpLua.Template = "ABILITY_ILF_UPROOTED_WEAPONS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_UPROOTED_WEAPONS = ConvertAbilityIntegerLevelField(1383034674);
		/// @CSharpLua.Template = "ABILITY_ILF_UPROOTED_DEFENSE_TYPE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_UPROOTED_DEFENSE_TYPE = ConvertAbilityIntegerLevelField(1383034676);
		/// @CSharpLua.Template = "ABILITY_ILF_ACCUMULATION_STEP"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ACCUMULATION_STEP = ConvertAbilityIntegerLevelField(1398893618);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_OWLS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_OWLS = ConvertAbilityIntegerLevelField(1165192756);
		/// @CSharpLua.Template = "ABILITY_ILF_STACKING_TYPE_SPO4"
		public static readonly abilityintegerlevelfield ABILITY_ILF_STACKING_TYPE_SPO4 = ConvertAbilityIntegerLevelField(1399877428);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_UNITS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_UNITS = ConvertAbilityIntegerLevelField(1399809073);
		/// @CSharpLua.Template = "ABILITY_ILF_SPIDER_CAPACITY"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SPIDER_CAPACITY = ConvertAbilityIntegerLevelField(1399873841);
		/// @CSharpLua.Template = "ABILITY_ILF_INTERVALS_BEFORE_CHANGING_TREES"
		public static readonly abilityintegerlevelfield ABILITY_ILF_INTERVALS_BEFORE_CHANGING_TREES = ConvertAbilityIntegerLevelField(1466458418);
		/// @CSharpLua.Template = "ABILITY_ILF_AGILITY_BONUS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_AGILITY_BONUS = ConvertAbilityIntegerLevelField(1231120233);
		/// @CSharpLua.Template = "ABILITY_ILF_INTELLIGENCE_BONUS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_INTELLIGENCE_BONUS = ConvertAbilityIntegerLevelField(1231646324);
		/// @CSharpLua.Template = "ABILITY_ILF_STRENGTH_BONUS_ISTR"
		public static readonly abilityintegerlevelfield ABILITY_ILF_STRENGTH_BONUS_ISTR = ConvertAbilityIntegerLevelField(1232303218);
		/// @CSharpLua.Template = "ABILITY_ILF_ATTACK_BONUS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ATTACK_BONUS = ConvertAbilityIntegerLevelField(1231123572);
		/// @CSharpLua.Template = "ABILITY_ILF_DEFENSE_BONUS_IDEF"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DEFENSE_BONUS_IDEF = ConvertAbilityIntegerLevelField(1231316326);
		/// @CSharpLua.Template = "ABILITY_ILF_SUMMON_1_AMOUNT"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SUMMON_1_AMOUNT = ConvertAbilityIntegerLevelField(1232301617);
		/// @CSharpLua.Template = "ABILITY_ILF_SUMMON_2_AMOUNT"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SUMMON_2_AMOUNT = ConvertAbilityIntegerLevelField(1232301618);
		/// @CSharpLua.Template = "ABILITY_ILF_EXPERIENCE_GAINED"
		public static readonly abilityintegerlevelfield ABILITY_ILF_EXPERIENCE_GAINED = ConvertAbilityIntegerLevelField(1232629863);
		/// @CSharpLua.Template = "ABILITY_ILF_HIT_POINTS_GAINED_IHPG"
		public static readonly abilityintegerlevelfield ABILITY_ILF_HIT_POINTS_GAINED_IHPG = ConvertAbilityIntegerLevelField(1231581287);
		/// @CSharpLua.Template = "ABILITY_ILF_MANA_POINTS_GAINED_IMPG"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MANA_POINTS_GAINED_IMPG = ConvertAbilityIntegerLevelField(1231908967);
		/// @CSharpLua.Template = "ABILITY_ILF_HIT_POINTS_GAINED_IHP2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_HIT_POINTS_GAINED_IHP2 = ConvertAbilityIntegerLevelField(1231581234);
		/// @CSharpLua.Template = "ABILITY_ILF_MANA_POINTS_GAINED_IMP2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MANA_POINTS_GAINED_IMP2 = ConvertAbilityIntegerLevelField(1231908914);
		/// @CSharpLua.Template = "ABILITY_ILF_DAMAGE_BONUS_DICE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DAMAGE_BONUS_DICE = ConvertAbilityIntegerLevelField(1231317347);
		/// @CSharpLua.Template = "ABILITY_ILF_ARMOR_PENALTY_IARP"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ARMOR_PENALTY_IARP = ConvertAbilityIntegerLevelField(1231123056);
		/// @CSharpLua.Template = "ABILITY_ILF_ENABLED_ATTACK_INDEX_IOB5"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ENABLED_ATTACK_INDEX_IOB5 = ConvertAbilityIntegerLevelField(1232036405);
		/// @CSharpLua.Template = "ABILITY_ILF_LEVELS_GAINED"
		public static readonly abilityintegerlevelfield ABILITY_ILF_LEVELS_GAINED = ConvertAbilityIntegerLevelField(1231840630);
		/// @CSharpLua.Template = "ABILITY_ILF_MAX_LIFE_GAINED"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAX_LIFE_GAINED = ConvertAbilityIntegerLevelField(1231841638);
		/// @CSharpLua.Template = "ABILITY_ILF_MAX_MANA_GAINED"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAX_MANA_GAINED = ConvertAbilityIntegerLevelField(1231905134);
		/// @CSharpLua.Template = "ABILITY_ILF_GOLD_GIVEN"
		public static readonly abilityintegerlevelfield ABILITY_ILF_GOLD_GIVEN = ConvertAbilityIntegerLevelField(1231515500);
		/// @CSharpLua.Template = "ABILITY_ILF_LUMBER_GIVEN"
		public static readonly abilityintegerlevelfield ABILITY_ILF_LUMBER_GIVEN = ConvertAbilityIntegerLevelField(1231844717);
		/// @CSharpLua.Template = "ABILITY_ILF_DETECTION_TYPE_IFA1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DETECTION_TYPE_IFA1 = ConvertAbilityIntegerLevelField(1231446321);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_CREEP_LEVEL_ICRE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_CREEP_LEVEL_ICRE = ConvertAbilityIntegerLevelField(1231254117);
		/// @CSharpLua.Template = "ABILITY_ILF_MOVEMENT_SPEED_BONUS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MOVEMENT_SPEED_BONUS = ConvertAbilityIntegerLevelField(1231910498);
		/// @CSharpLua.Template = "ABILITY_ILF_HIT_POINTS_REGENERATED_PER_SECOND"
		public static readonly abilityintegerlevelfield ABILITY_ILF_HIT_POINTS_REGENERATED_PER_SECOND = ConvertAbilityIntegerLevelField(1231581298);
		/// @CSharpLua.Template = "ABILITY_ILF_SIGHT_RANGE_BONUS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SIGHT_RANGE_BONUS = ConvertAbilityIntegerLevelField(1232300386);
		/// @CSharpLua.Template = "ABILITY_ILF_DAMAGE_PER_DURATION"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DAMAGE_PER_DURATION = ConvertAbilityIntegerLevelField(1231251044);
		/// @CSharpLua.Template = "ABILITY_ILF_MANA_USED_PER_SECOND"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MANA_USED_PER_SECOND = ConvertAbilityIntegerLevelField(1231251053);
		/// @CSharpLua.Template = "ABILITY_ILF_EXTRA_MANA_REQUIRED"
		public static readonly abilityintegerlevelfield ABILITY_ILF_EXTRA_MANA_REQUIRED = ConvertAbilityIntegerLevelField(1231251064);
		/// @CSharpLua.Template = "ABILITY_ILF_DETECTION_RADIUS_IDET"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DETECTION_RADIUS_IDET = ConvertAbilityIntegerLevelField(1231316340);
		/// @CSharpLua.Template = "ABILITY_ILF_MANA_LOSS_PER_UNIT_IDIM"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MANA_LOSS_PER_UNIT_IDIM = ConvertAbilityIntegerLevelField(1231317357);
		/// @CSharpLua.Template = "ABILITY_ILF_DAMAGE_TO_SUMMONED_UNITS_IDID"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DAMAGE_TO_SUMMONED_UNITS_IDID = ConvertAbilityIntegerLevelField(1231317348);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_NUMBER_OF_UNITS_IREC"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_NUMBER_OF_UNITS_IREC = ConvertAbilityIntegerLevelField(1232233827);
		/// @CSharpLua.Template = "ABILITY_ILF_DELAY_AFTER_DEATH_SECONDS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DELAY_AFTER_DEATH_SECONDS = ConvertAbilityIntegerLevelField(1232233316);
		/// @CSharpLua.Template = "ABILITY_ILF_RESTORED_LIFE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_RESTORED_LIFE = ConvertAbilityIntegerLevelField(1769104178);
		/// @CSharpLua.Template = "ABILITY_ILF_RESTORED_MANA__1_FOR_CURRENT"
		public static readonly abilityintegerlevelfield ABILITY_ILF_RESTORED_MANA__1_FOR_CURRENT = ConvertAbilityIntegerLevelField(1769104179);
		/// @CSharpLua.Template = "ABILITY_ILF_HIT_POINTS_RESTORED"
		public static readonly abilityintegerlevelfield ABILITY_ILF_HIT_POINTS_RESTORED = ConvertAbilityIntegerLevelField(1231581299);
		/// @CSharpLua.Template = "ABILITY_ILF_MANA_POINTS_RESTORED"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MANA_POINTS_RESTORED = ConvertAbilityIntegerLevelField(1231908979);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_NUMBER_OF_UNITS_ITPM"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_NUMBER_OF_UNITS_ITPM = ConvertAbilityIntegerLevelField(1232367725);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_CORPSES_RAISED_CAD1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_CORPSES_RAISED_CAD1 = ConvertAbilityIntegerLevelField(1130456113);
		/// @CSharpLua.Template = "ABILITY_ILF_TERRAIN_DEFORMATION_DURATION_MS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_TERRAIN_DEFORMATION_DURATION_MS = ConvertAbilityIntegerLevelField(1467118387);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_UNITS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_UNITS = ConvertAbilityIntegerLevelField(1432646449);
		/// @CSharpLua.Template = "ABILITY_ILF_DETECTION_TYPE_DET1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DETECTION_TYPE_DET1 = ConvertAbilityIntegerLevelField(1147499569);
		/// @CSharpLua.Template = "ABILITY_ILF_GOLD_COST_PER_STRUCTURE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_GOLD_COST_PER_STRUCTURE = ConvertAbilityIntegerLevelField(1316188209);
		/// @CSharpLua.Template = "ABILITY_ILF_LUMBER_COST_PER_USE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_LUMBER_COST_PER_USE = ConvertAbilityIntegerLevelField(1316188210);
		/// @CSharpLua.Template = "ABILITY_ILF_DETECTION_TYPE_NSP3"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DETECTION_TYPE_NSP3 = ConvertAbilityIntegerLevelField(1316188211);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_SWARM_UNITS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_SWARM_UNITS = ConvertAbilityIntegerLevelField(1433170737);
		/// @CSharpLua.Template = "ABILITY_ILF_MAX_SWARM_UNITS_PER_TARGET"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAX_SWARM_UNITS_PER_TARGET = ConvertAbilityIntegerLevelField(1433170739);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_NBA2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_NBA2 = ConvertAbilityIntegerLevelField(1315070258);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_CREEP_LEVEL_NCH1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_CREEP_LEVEL_NCH1 = ConvertAbilityIntegerLevelField(1315137585);
		/// @CSharpLua.Template = "ABILITY_ILF_ATTACKS_PREVENTED"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ATTACKS_PREVENTED = ConvertAbilityIntegerLevelField(1316186417);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_NUMBER_OF_TARGETS_EFK3"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_NUMBER_OF_TARGETS_EFK3 = ConvertAbilityIntegerLevelField(1164340019);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_ESV1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_ESV1 = ConvertAbilityIntegerLevelField(1165194801);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_NUMBER_OF_CORPSES_EXH1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_NUMBER_OF_CORPSES_EXH1 = ConvertAbilityIntegerLevelField(1702389809);
		/// @CSharpLua.Template = "ABILITY_ILF_ITEM_CAPACITY"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ITEM_CAPACITY = ConvertAbilityIntegerLevelField(1768846897);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_NUMBER_OF_TARGETS_SPL2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_NUMBER_OF_TARGETS_SPL2 = ConvertAbilityIntegerLevelField(1936747570);
		/// @CSharpLua.Template = "ABILITY_ILF_ALLOW_WHEN_FULL_IRL3"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ALLOW_WHEN_FULL_IRL3 = ConvertAbilityIntegerLevelField(1769106483);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_DISPELLED_UNITS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_DISPELLED_UNITS = ConvertAbilityIntegerLevelField(1768186675);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_LURES"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_LURES = ConvertAbilityIntegerLevelField(1768779569);
		/// @CSharpLua.Template = "ABILITY_ILF_NEW_TIME_OF_DAY_HOUR"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NEW_TIME_OF_DAY_HOUR = ConvertAbilityIntegerLevelField(1768125489);
		/// @CSharpLua.Template = "ABILITY_ILF_NEW_TIME_OF_DAY_MINUTE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NEW_TIME_OF_DAY_MINUTE = ConvertAbilityIntegerLevelField(1768125490);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_UNITS_CREATED_MEC1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_UNITS_CREATED_MEC1 = ConvertAbilityIntegerLevelField(1835361073);
		/// @CSharpLua.Template = "ABILITY_ILF_MINIMUM_SPELLS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MINIMUM_SPELLS = ConvertAbilityIntegerLevelField(1936745011);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_SPELLS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_SPELLS = ConvertAbilityIntegerLevelField(1936745012);
		/// @CSharpLua.Template = "ABILITY_ILF_DISABLED_ATTACK_INDEX"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DISABLED_ATTACK_INDEX = ConvertAbilityIntegerLevelField(1735549235);
		/// @CSharpLua.Template = "ABILITY_ILF_ENABLED_ATTACK_INDEX_GRA4"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ENABLED_ATTACK_INDEX_GRA4 = ConvertAbilityIntegerLevelField(1735549236);
		/// @CSharpLua.Template = "ABILITY_ILF_MAXIMUM_ATTACKS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAXIMUM_ATTACKS = ConvertAbilityIntegerLevelField(1735549237);
		/// @CSharpLua.Template = "ABILITY_ILF_BUILDING_TYPES_ALLOWED_NPR1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_BUILDING_TYPES_ALLOWED_NPR1 = ConvertAbilityIntegerLevelField(1315992113);
		/// @CSharpLua.Template = "ABILITY_ILF_BUILDING_TYPES_ALLOWED_NSA1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_BUILDING_TYPES_ALLOWED_NSA1 = ConvertAbilityIntegerLevelField(1316184369);
		/// @CSharpLua.Template = "ABILITY_ILF_ATTACK_MODIFICATION"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ATTACK_MODIFICATION = ConvertAbilityIntegerLevelField(1231118641);
		/// @CSharpLua.Template = "ABILITY_ILF_SUMMONED_UNIT_COUNT_NPA5"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SUMMONED_UNIT_COUNT_NPA5 = ConvertAbilityIntegerLevelField(1315987765);
		/// @CSharpLua.Template = "ABILITY_ILF_UPGRADE_LEVELS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_UPGRADE_LEVELS = ConvertAbilityIntegerLevelField(1231514673);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_NDO2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_NDO2 = ConvertAbilityIntegerLevelField(1315204914);
		/// @CSharpLua.Template = "ABILITY_ILF_BEASTS_PER_SECOND"
		public static readonly abilityintegerlevelfield ABILITY_ILF_BEASTS_PER_SECOND = ConvertAbilityIntegerLevelField(1316189233);
		/// @CSharpLua.Template = "ABILITY_ILF_TARGET_TYPE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_TARGET_TYPE = ConvertAbilityIntegerLevelField(1315138610);
		/// @CSharpLua.Template = "ABILITY_ILF_OPTIONS"
		public static readonly abilityintegerlevelfield ABILITY_ILF_OPTIONS = ConvertAbilityIntegerLevelField(1315138611);
		/// @CSharpLua.Template = "ABILITY_ILF_ARMOR_PENALTY_NAB3"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ARMOR_PENALTY_NAB3 = ConvertAbilityIntegerLevelField(1315004979);
		/// @CSharpLua.Template = "ABILITY_ILF_WAVE_COUNT_NHS6"
		public static readonly abilityintegerlevelfield ABILITY_ILF_WAVE_COUNT_NHS6 = ConvertAbilityIntegerLevelField(1315468086);
		/// @CSharpLua.Template = "ABILITY_ILF_MAX_CREEP_LEVEL_NTM3"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAX_CREEP_LEVEL_NTM3 = ConvertAbilityIntegerLevelField(1316252979);
		/// @CSharpLua.Template = "ABILITY_ILF_MISSILE_COUNT"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MISSILE_COUNT = ConvertAbilityIntegerLevelField(1315140403);
		/// @CSharpLua.Template = "ABILITY_ILF_SPLIT_ATTACK_COUNT"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SPLIT_ATTACK_COUNT = ConvertAbilityIntegerLevelField(1315728691);
		/// @CSharpLua.Template = "ABILITY_ILF_GENERATION_COUNT"
		public static readonly abilityintegerlevelfield ABILITY_ILF_GENERATION_COUNT = ConvertAbilityIntegerLevelField(1315728694);
		/// @CSharpLua.Template = "ABILITY_ILF_ROCK_RING_COUNT"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ROCK_RING_COUNT = ConvertAbilityIntegerLevelField(1316381489);
		/// @CSharpLua.Template = "ABILITY_ILF_WAVE_COUNT_NVC2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_WAVE_COUNT_NVC2 = ConvertAbilityIntegerLevelField(1316381490);
		/// @CSharpLua.Template = "ABILITY_ILF_PREFER_HOSTILES_TAU1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_PREFER_HOSTILES_TAU1 = ConvertAbilityIntegerLevelField(1415673137);
		/// @CSharpLua.Template = "ABILITY_ILF_PREFER_FRIENDLIES_TAU2"
		public static readonly abilityintegerlevelfield ABILITY_ILF_PREFER_FRIENDLIES_TAU2 = ConvertAbilityIntegerLevelField(1415673138);
		/// @CSharpLua.Template = "ABILITY_ILF_MAX_UNITS_TAU3"
		public static readonly abilityintegerlevelfield ABILITY_ILF_MAX_UNITS_TAU3 = ConvertAbilityIntegerLevelField(1415673139);
		/// @CSharpLua.Template = "ABILITY_ILF_NUMBER_OF_PULSES"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NUMBER_OF_PULSES = ConvertAbilityIntegerLevelField(1415673140);
		/// @CSharpLua.Template = "ABILITY_ILF_SUMMONED_UNIT_TYPE_HWE1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SUMMONED_UNIT_TYPE_HWE1 = ConvertAbilityIntegerLevelField(1215784241);
		/// @CSharpLua.Template = "ABILITY_ILF_SUMMONED_UNIT_UIN4"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SUMMONED_UNIT_UIN4 = ConvertAbilityIntegerLevelField(1432972852);
		/// @CSharpLua.Template = "ABILITY_ILF_SUMMONED_UNIT_OSF1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SUMMONED_UNIT_OSF1 = ConvertAbilityIntegerLevelField(1332962865);
		/// @CSharpLua.Template = "ABILITY_ILF_SUMMONED_UNIT_TYPE_EFNU"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SUMMONED_UNIT_TYPE_EFNU = ConvertAbilityIntegerLevelField(1164340853);
		/// @CSharpLua.Template = "ABILITY_ILF_SUMMONED_UNIT_TYPE_NBAU"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SUMMONED_UNIT_TYPE_NBAU = ConvertAbilityIntegerLevelField(1315070325);
		/// @CSharpLua.Template = "ABILITY_ILF_SUMMONED_UNIT_TYPE_NTOU"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SUMMONED_UNIT_TYPE_NTOU = ConvertAbilityIntegerLevelField(1316253557);
		/// @CSharpLua.Template = "ABILITY_ILF_SUMMONED_UNIT_TYPE_ESVU"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SUMMONED_UNIT_TYPE_ESVU = ConvertAbilityIntegerLevelField(1165194869);
		/// @CSharpLua.Template = "ABILITY_ILF_SUMMONED_UNIT_TYPES"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SUMMONED_UNIT_TYPES = ConvertAbilityIntegerLevelField(1315268145);
		/// @CSharpLua.Template = "ABILITY_ILF_SUMMONED_UNIT_TYPE_NDOU"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SUMMONED_UNIT_TYPE_NDOU = ConvertAbilityIntegerLevelField(1315204981);
		/// @CSharpLua.Template = "ABILITY_ILF_ALTERNATE_FORM_UNIT_EMEU"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ALTERNATE_FORM_UNIT_EMEU = ConvertAbilityIntegerLevelField(1164797301);
		/// @CSharpLua.Template = "ABILITY_ILF_PLAGUE_WARD_UNIT_TYPE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_PLAGUE_WARD_UNIT_TYPE = ConvertAbilityIntegerLevelField(1097886837);
		/// @CSharpLua.Template = "ABILITY_ILF_ALLOWED_UNIT_TYPE_BTL1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ALLOWED_UNIT_TYPE_BTL1 = ConvertAbilityIntegerLevelField(1114926129);
		/// @CSharpLua.Template = "ABILITY_ILF_NEW_UNIT_TYPE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_NEW_UNIT_TYPE = ConvertAbilityIntegerLevelField(1130914097);
		/// @CSharpLua.Template = "ABILITY_ILF_RESULTING_UNIT_TYPE_ENT1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_RESULTING_UNIT_TYPE_ENT1 = ConvertAbilityIntegerLevelField(1701737521);
		/// @CSharpLua.Template = "ABILITY_ILF_CORPSE_UNIT_TYPE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_CORPSE_UNIT_TYPE = ConvertAbilityIntegerLevelField(1199137909);
		/// @CSharpLua.Template = "ABILITY_ILF_ALLOWED_UNIT_TYPE_LOA1"
		public static readonly abilityintegerlevelfield ABILITY_ILF_ALLOWED_UNIT_TYPE_LOA1 = ConvertAbilityIntegerLevelField(1282367793);
		/// @CSharpLua.Template = "ABILITY_ILF_UNIT_TYPE_FOR_LIMIT_CHECK"
		public static readonly abilityintegerlevelfield ABILITY_ILF_UNIT_TYPE_FOR_LIMIT_CHECK = ConvertAbilityIntegerLevelField(1382115701);
		/// @CSharpLua.Template = "ABILITY_ILF_WARD_UNIT_TYPE_STAU"
		public static readonly abilityintegerlevelfield ABILITY_ILF_WARD_UNIT_TYPE_STAU = ConvertAbilityIntegerLevelField(1400136053);
		/// @CSharpLua.Template = "ABILITY_ILF_EFFECT_ABILITY"
		public static readonly abilityintegerlevelfield ABILITY_ILF_EFFECT_ABILITY = ConvertAbilityIntegerLevelField(1232036469);
		/// @CSharpLua.Template = "ABILITY_ILF_CONVERSION_UNIT"
		public static readonly abilityintegerlevelfield ABILITY_ILF_CONVERSION_UNIT = ConvertAbilityIntegerLevelField(1315201842);
		/// @CSharpLua.Template = "ABILITY_ILF_UNIT_TO_PRESERVE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_UNIT_TO_PRESERVE = ConvertAbilityIntegerLevelField(1316187185);
		/// @CSharpLua.Template = "ABILITY_ILF_UNIT_TYPE_ALLOWED"
		public static readonly abilityintegerlevelfield ABILITY_ILF_UNIT_TYPE_ALLOWED = ConvertAbilityIntegerLevelField(1130916913);
		/// @CSharpLua.Template = "ABILITY_ILF_SWARM_UNIT_TYPE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SWARM_UNIT_TYPE = ConvertAbilityIntegerLevelField(1433170805);
		/// @CSharpLua.Template = "ABILITY_ILF_RESULTING_UNIT_TYPE_COAU"
		public static readonly abilityintegerlevelfield ABILITY_ILF_RESULTING_UNIT_TYPE_COAU = ConvertAbilityIntegerLevelField(1668243829);
		/// @CSharpLua.Template = "ABILITY_ILF_UNIT_TYPE_EXHU"
		public static readonly abilityintegerlevelfield ABILITY_ILF_UNIT_TYPE_EXHU = ConvertAbilityIntegerLevelField(1702389877);
		/// @CSharpLua.Template = "ABILITY_ILF_WARD_UNIT_TYPE_HWDU"
		public static readonly abilityintegerlevelfield ABILITY_ILF_WARD_UNIT_TYPE_HWDU = ConvertAbilityIntegerLevelField(1752654965);
		/// @CSharpLua.Template = "ABILITY_ILF_LURE_UNIT_TYPE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_LURE_UNIT_TYPE = ConvertAbilityIntegerLevelField(1768779637);
		/// @CSharpLua.Template = "ABILITY_ILF_UNIT_TYPE_IPMU"
		public static readonly abilityintegerlevelfield ABILITY_ILF_UNIT_TYPE_IPMU = ConvertAbilityIntegerLevelField(1768975733);
		/// @CSharpLua.Template = "ABILITY_ILF_FACTORY_UNIT_ID"
		public static readonly abilityintegerlevelfield ABILITY_ILF_FACTORY_UNIT_ID = ConvertAbilityIntegerLevelField(1316190581);
		/// @CSharpLua.Template = "ABILITY_ILF_SPAWN_UNIT_ID_NFYU"
		public static readonly abilityintegerlevelfield ABILITY_ILF_SPAWN_UNIT_ID_NFYU = ConvertAbilityIntegerLevelField(1315338613);
		/// @CSharpLua.Template = "ABILITY_ILF_DESTRUCTIBLE_ID"
		public static readonly abilityintegerlevelfield ABILITY_ILF_DESTRUCTIBLE_ID = ConvertAbilityIntegerLevelField(1316381557);
		/// @CSharpLua.Template = "ABILITY_ILF_UPGRADE_TYPE"
		public static readonly abilityintegerlevelfield ABILITY_ILF_UPGRADE_TYPE = ConvertAbilityIntegerLevelField(1231514741);
		/// @CSharpLua.Template = "ABILITY_RLF_CASTING_TIME"
		public static readonly abilityreallevelfield ABILITY_RLF_CASTING_TIME = ConvertAbilityRealLevelField(1633902963);
		/// @CSharpLua.Template = "ABILITY_RLF_DURATION_NORMAL"
		public static readonly abilityreallevelfield ABILITY_RLF_DURATION_NORMAL = ConvertAbilityRealLevelField(1633973618);
		/// @CSharpLua.Template = "ABILITY_RLF_DURATION_HERO"
		public static readonly abilityreallevelfield ABILITY_RLF_DURATION_HERO = ConvertAbilityRealLevelField(1634231413);
		/// @CSharpLua.Template = "ABILITY_RLF_COOLDOWN"
		public static readonly abilityreallevelfield ABILITY_RLF_COOLDOWN = ConvertAbilityRealLevelField(1633903726);
		/// @CSharpLua.Template = "ABILITY_RLF_AREA_OF_EFFECT"
		public static readonly abilityreallevelfield ABILITY_RLF_AREA_OF_EFFECT = ConvertAbilityRealLevelField(1633776229);
		/// @CSharpLua.Template = "ABILITY_RLF_CAST_RANGE"
		public static readonly abilityreallevelfield ABILITY_RLF_CAST_RANGE = ConvertAbilityRealLevelField(1634885998);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_HBZ2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_HBZ2 = ConvertAbilityRealLevelField(1214413362);
		/// @CSharpLua.Template = "ABILITY_RLF_BUILDING_REDUCTION_HBZ4"
		public static readonly abilityreallevelfield ABILITY_RLF_BUILDING_REDUCTION_HBZ4 = ConvertAbilityRealLevelField(1214413364);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_HBZ5"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_HBZ5 = ConvertAbilityRealLevelField(1214413365);
		/// @CSharpLua.Template = "ABILITY_RLF_MAXIMUM_DAMAGE_PER_WAVE"
		public static readonly abilityreallevelfield ABILITY_RLF_MAXIMUM_DAMAGE_PER_WAVE = ConvertAbilityRealLevelField(1214413366);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_REGENERATION_INCREASE"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_REGENERATION_INCREASE = ConvertAbilityRealLevelField(1214341681);
		/// @CSharpLua.Template = "ABILITY_RLF_CASTING_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_CASTING_DELAY = ConvertAbilityRealLevelField(1215132722);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_OWW1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_OWW1 = ConvertAbilityRealLevelField(1333229361);
		/// @CSharpLua.Template = "ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_OWW2"
		public static readonly abilityreallevelfield ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_OWW2 = ConvertAbilityRealLevelField(1333229362);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_CRITICAL_STRIKE"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_CRITICAL_STRIKE = ConvertAbilityRealLevelField(1331917361);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_MULTIPLIER_OCR2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_MULTIPLIER_OCR2 = ConvertAbilityRealLevelField(1331917362);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_BONUS_OCR3"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_BONUS_OCR3 = ConvertAbilityRealLevelField(1331917363);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_EVADE_OCR4"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_EVADE_OCR4 = ConvertAbilityRealLevelField(1331917364);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_DEALT_PERCENT_OMI2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_DEALT_PERCENT_OMI2 = ConvertAbilityRealLevelField(1332570418);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_TAKEN_PERCENT_OMI3"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_TAKEN_PERCENT_OMI3 = ConvertAbilityRealLevelField(1332570419);
		/// @CSharpLua.Template = "ABILITY_RLF_ANIMATION_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_ANIMATION_DELAY = ConvertAbilityRealLevelField(1332570420);
		/// @CSharpLua.Template = "ABILITY_RLF_TRANSITION_TIME"
		public static readonly abilityreallevelfield ABILITY_RLF_TRANSITION_TIME = ConvertAbilityRealLevelField(1333226289);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_OWK2"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_OWK2 = ConvertAbilityRealLevelField(1333226290);
		/// @CSharpLua.Template = "ABILITY_RLF_BACKSTAB_DAMAGE"
		public static readonly abilityreallevelfield ABILITY_RLF_BACKSTAB_DAMAGE = ConvertAbilityRealLevelField(1333226291);
		/// @CSharpLua.Template = "ABILITY_RLF_AMOUNT_HEALED_DAMAGED_UDC1"
		public static readonly abilityreallevelfield ABILITY_RLF_AMOUNT_HEALED_DAMAGED_UDC1 = ConvertAbilityRealLevelField(1432642353);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_CONVERTED_TO_MANA"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_CONVERTED_TO_MANA = ConvertAbilityRealLevelField(1432645681);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_CONVERTED_TO_LIFE"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_CONVERTED_TO_LIFE = ConvertAbilityRealLevelField(1432645682);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_UAU1"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_UAU1 = ConvertAbilityRealLevelField(1432450353);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_REGENERATION_INCREASE_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_REGENERATION_INCREASE_PERCENT = ConvertAbilityRealLevelField(1432450354);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_EVADE_EEV1"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_EVADE_EEV1 = ConvertAbilityRealLevelField(1164277297);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_INTERVAL"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_INTERVAL = ConvertAbilityRealLevelField(1164537137);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_DRAINED_PER_SECOND_EIM2"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_DRAINED_PER_SECOND_EIM2 = ConvertAbilityRealLevelField(1164537138);
		/// @CSharpLua.Template = "ABILITY_RLF_BUFFER_MANA_REQUIRED"
		public static readonly abilityreallevelfield ABILITY_RLF_BUFFER_MANA_REQUIRED = ConvertAbilityRealLevelField(1164537139);
		/// @CSharpLua.Template = "ABILITY_RLF_MAX_MANA_DRAINED"
		public static readonly abilityreallevelfield ABILITY_RLF_MAX_MANA_DRAINED = ConvertAbilityRealLevelField(1164796465);
		/// @CSharpLua.Template = "ABILITY_RLF_BOLT_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_BOLT_DELAY = ConvertAbilityRealLevelField(1164796466);
		/// @CSharpLua.Template = "ABILITY_RLF_BOLT_LIFETIME"
		public static readonly abilityreallevelfield ABILITY_RLF_BOLT_LIFETIME = ConvertAbilityRealLevelField(1164796467);
		/// @CSharpLua.Template = "ABILITY_RLF_ALTITUDE_ADJUSTMENT_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_ALTITUDE_ADJUSTMENT_DURATION = ConvertAbilityRealLevelField(1164797235);
		/// @CSharpLua.Template = "ABILITY_RLF_LANDING_DELAY_TIME"
		public static readonly abilityreallevelfield ABILITY_RLF_LANDING_DELAY_TIME = ConvertAbilityRealLevelField(1164797236);
		/// @CSharpLua.Template = "ABILITY_RLF_ALTERNATE_FORM_HIT_POINT_BONUS"
		public static readonly abilityreallevelfield ABILITY_RLF_ALTERNATE_FORM_HIT_POINT_BONUS = ConvertAbilityRealLevelField(1164797237);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVE_SPEED_BONUS_INFO_PANEL_ONLY"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVE_SPEED_BONUS_INFO_PANEL_ONLY = ConvertAbilityRealLevelField(1315140149);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_BONUS_INFO_PANEL_ONLY"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_BONUS_INFO_PANEL_ONLY = ConvertAbilityRealLevelField(1315140150);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_REGENERATION_RATE_PER_SECOND"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_REGENERATION_RATE_PER_SECOND = ConvertAbilityRealLevelField(1635149109);
		/// @CSharpLua.Template = "ABILITY_RLF_STUN_DURATION_USL1"
		public static readonly abilityreallevelfield ABILITY_RLF_STUN_DURATION_USL1 = ConvertAbilityRealLevelField(1433627697);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_DAMAGE_STOLEN_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_DAMAGE_STOLEN_PERCENT = ConvertAbilityRealLevelField(1432450609);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_UCS1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_UCS1 = ConvertAbilityRealLevelField(1432580913);
		/// @CSharpLua.Template = "ABILITY_RLF_MAX_DAMAGE_UCS2"
		public static readonly abilityreallevelfield ABILITY_RLF_MAX_DAMAGE_UCS2 = ConvertAbilityRealLevelField(1432580914);
		/// @CSharpLua.Template = "ABILITY_RLF_DISTANCE_UCS3"
		public static readonly abilityreallevelfield ABILITY_RLF_DISTANCE_UCS3 = ConvertAbilityRealLevelField(1432580915);
		/// @CSharpLua.Template = "ABILITY_RLF_FINAL_AREA_UCS4"
		public static readonly abilityreallevelfield ABILITY_RLF_FINAL_AREA_UCS4 = ConvertAbilityRealLevelField(1432580916);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_UIN1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_UIN1 = ConvertAbilityRealLevelField(1432972849);
		/// @CSharpLua.Template = "ABILITY_RLF_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_DURATION = ConvertAbilityRealLevelField(1432972850);
		/// @CSharpLua.Template = "ABILITY_RLF_IMPACT_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_IMPACT_DELAY = ConvertAbilityRealLevelField(1432972851);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_TARGET_OCL1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_TARGET_OCL1 = ConvertAbilityRealLevelField(1331915825);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_REDUCTION_PER_TARGET"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_REDUCTION_PER_TARGET = ConvertAbilityRealLevelField(1331915827);
		/// @CSharpLua.Template = "ABILITY_RLF_EFFECT_DELAY_OEQ1"
		public static readonly abilityreallevelfield ABILITY_RLF_EFFECT_DELAY_OEQ1 = ConvertAbilityRealLevelField(1332048177);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_TO_BUILDINGS"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_TO_BUILDINGS = ConvertAbilityRealLevelField(1332048178);
		/// @CSharpLua.Template = "ABILITY_RLF_UNITS_SLOWED_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_UNITS_SLOWED_PERCENT = ConvertAbilityRealLevelField(1332048179);
		/// @CSharpLua.Template = "ABILITY_RLF_FINAL_AREA_OEQ4"
		public static readonly abilityreallevelfield ABILITY_RLF_FINAL_AREA_OEQ4 = ConvertAbilityRealLevelField(1332048180);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_EER1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_EER1 = ConvertAbilityRealLevelField(1164276273);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_DEALT_TO_ATTACKERS"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_DEALT_TO_ATTACKERS = ConvertAbilityRealLevelField(1164011569);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_HEALED"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_HEALED = ConvertAbilityRealLevelField(1165259057);
		/// @CSharpLua.Template = "ABILITY_RLF_HEAL_INTERVAL"
		public static readonly abilityreallevelfield ABILITY_RLF_HEAL_INTERVAL = ConvertAbilityRealLevelField(1165259058);
		/// @CSharpLua.Template = "ABILITY_RLF_BUILDING_REDUCTION_ETQ3"
		public static readonly abilityreallevelfield ABILITY_RLF_BUILDING_REDUCTION_ETQ3 = ConvertAbilityRealLevelField(1165259059);
		/// @CSharpLua.Template = "ABILITY_RLF_INITIAL_IMMUNITY_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_INITIAL_IMMUNITY_DURATION = ConvertAbilityRealLevelField(1165259060);
		/// @CSharpLua.Template = "ABILITY_RLF_MAX_LIFE_DRAINED_PER_SECOND_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_MAX_LIFE_DRAINED_PER_SECOND_PERCENT = ConvertAbilityRealLevelField(1432642609);
		/// @CSharpLua.Template = "ABILITY_RLF_BUILDING_REDUCTION_UDD2"
		public static readonly abilityreallevelfield ABILITY_RLF_BUILDING_REDUCTION_UDD2 = ConvertAbilityRealLevelField(1432642610);
		/// @CSharpLua.Template = "ABILITY_RLF_ARMOR_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_ARMOR_DURATION = ConvertAbilityRealLevelField(1432772913);
		/// @CSharpLua.Template = "ABILITY_RLF_ARMOR_BONUS_UFA2"
		public static readonly abilityreallevelfield ABILITY_RLF_ARMOR_BONUS_UFA2 = ConvertAbilityRealLevelField(1432772914);
		/// @CSharpLua.Template = "ABILITY_RLF_AREA_OF_EFFECT_DAMAGE"
		public static readonly abilityreallevelfield ABILITY_RLF_AREA_OF_EFFECT_DAMAGE = ConvertAbilityRealLevelField(1432776241);
		/// @CSharpLua.Template = "ABILITY_RLF_SPECIFIC_TARGET_DAMAGE_UFN2"
		public static readonly abilityreallevelfield ABILITY_RLF_SPECIFIC_TARGET_DAMAGE_UFN2 = ConvertAbilityRealLevelField(1432776242);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_BONUS_HFA1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_BONUS_HFA1 = ConvertAbilityRealLevelField(1214669105);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_DEALT_ESF1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_DEALT_ESF1 = ConvertAbilityRealLevelField(1165190705);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_INTERVAL_ESF2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_INTERVAL_ESF2 = ConvertAbilityRealLevelField(1165190706);
		/// @CSharpLua.Template = "ABILITY_RLF_BUILDING_REDUCTION_ESF3"
		public static readonly abilityreallevelfield ABILITY_RLF_BUILDING_REDUCTION_ESF3 = ConvertAbilityRealLevelField(1165190707);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_BONUS_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_BONUS_PERCENT = ConvertAbilityRealLevelField(1164014129);
		/// @CSharpLua.Template = "ABILITY_RLF_DEFENSE_BONUS_HAV1"
		public static readonly abilityreallevelfield ABILITY_RLF_DEFENSE_BONUS_HAV1 = ConvertAbilityRealLevelField(1214346801);
		/// @CSharpLua.Template = "ABILITY_RLF_HIT_POINT_BONUS"
		public static readonly abilityreallevelfield ABILITY_RLF_HIT_POINT_BONUS = ConvertAbilityRealLevelField(1214346802);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_BONUS_HAV3"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_BONUS_HAV3 = ConvertAbilityRealLevelField(1214346803);
		/// @CSharpLua.Template = "ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_HAV4"
		public static readonly abilityreallevelfield ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_HAV4 = ConvertAbilityRealLevelField(1214346804);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_BASH"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_BASH = ConvertAbilityRealLevelField(1214408753);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_MULTIPLIER_HBH2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_MULTIPLIER_HBH2 = ConvertAbilityRealLevelField(1214408754);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_BONUS_HBH3"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_BONUS_HBH3 = ConvertAbilityRealLevelField(1214408755);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_MISS_HBH4"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_MISS_HBH4 = ConvertAbilityRealLevelField(1214408756);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_HTB1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_HTB1 = ConvertAbilityRealLevelField(1215586865);
		/// @CSharpLua.Template = "ABILITY_RLF_AOE_DAMAGE"
		public static readonly abilityreallevelfield ABILITY_RLF_AOE_DAMAGE = ConvertAbilityRealLevelField(1215587121);
		/// @CSharpLua.Template = "ABILITY_RLF_SPECIFIC_TARGET_DAMAGE_HTC2"
		public static readonly abilityreallevelfield ABILITY_RLF_SPECIFIC_TARGET_DAMAGE_HTC2 = ConvertAbilityRealLevelField(1215587122);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_HTC3"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_HTC3 = ConvertAbilityRealLevelField(1215587123);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_HTC4"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_HTC4 = ConvertAbilityRealLevelField(1215587124);
		/// @CSharpLua.Template = "ABILITY_RLF_ARMOR_BONUS_HAD1"
		public static readonly abilityreallevelfield ABILITY_RLF_ARMOR_BONUS_HAD1 = ConvertAbilityRealLevelField(1214342193);
		/// @CSharpLua.Template = "ABILITY_RLF_AMOUNT_HEALED_DAMAGED_HHB1"
		public static readonly abilityreallevelfield ABILITY_RLF_AMOUNT_HEALED_DAMAGED_HHB1 = ConvertAbilityRealLevelField(1214800433);
		/// @CSharpLua.Template = "ABILITY_RLF_EXTRA_DAMAGE_HCA1"
		public static readonly abilityreallevelfield ABILITY_RLF_EXTRA_DAMAGE_HCA1 = ConvertAbilityRealLevelField(1214472497);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_FACTOR_HCA2"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_FACTOR_HCA2 = ConvertAbilityRealLevelField(1214472498);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_FACTOR_HCA3"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_FACTOR_HCA3 = ConvertAbilityRealLevelField(1214472499);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_OAE1"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_OAE1 = ConvertAbilityRealLevelField(1331782961);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_INCREASE_PERCENT_OAE2"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_INCREASE_PERCENT_OAE2 = ConvertAbilityRealLevelField(1331782962);
		/// @CSharpLua.Template = "ABILITY_RLF_REINCARNATION_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_REINCARNATION_DELAY = ConvertAbilityRealLevelField(1332897073);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_OSH1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_OSH1 = ConvertAbilityRealLevelField(1332963377);
		/// @CSharpLua.Template = "ABILITY_RLF_MAXIMUM_DAMAGE_OSH2"
		public static readonly abilityreallevelfield ABILITY_RLF_MAXIMUM_DAMAGE_OSH2 = ConvertAbilityRealLevelField(1332963378);
		/// @CSharpLua.Template = "ABILITY_RLF_DISTANCE_OSH3"
		public static readonly abilityreallevelfield ABILITY_RLF_DISTANCE_OSH3 = ConvertAbilityRealLevelField(1332963379);
		/// @CSharpLua.Template = "ABILITY_RLF_FINAL_AREA_OSH4"
		public static readonly abilityreallevelfield ABILITY_RLF_FINAL_AREA_OSH4 = ConvertAbilityRealLevelField(1332963380);
		/// @CSharpLua.Template = "ABILITY_RLF_GRAPHIC_DELAY_NFD1"
		public static readonly abilityreallevelfield ABILITY_RLF_GRAPHIC_DELAY_NFD1 = ConvertAbilityRealLevelField(1315333169);
		/// @CSharpLua.Template = "ABILITY_RLF_GRAPHIC_DURATION_NFD2"
		public static readonly abilityreallevelfield ABILITY_RLF_GRAPHIC_DURATION_NFD2 = ConvertAbilityRealLevelField(1315333170);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_NFD3"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_NFD3 = ConvertAbilityRealLevelField(1315333171);
		/// @CSharpLua.Template = "ABILITY_RLF_SUMMONED_UNIT_DAMAGE_AMS1"
		public static readonly abilityreallevelfield ABILITY_RLF_SUMMONED_UNIT_DAMAGE_AMS1 = ConvertAbilityRealLevelField(1097691953);
		/// @CSharpLua.Template = "ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_AMS2"
		public static readonly abilityreallevelfield ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_AMS2 = ConvertAbilityRealLevelField(1097691954);
		/// @CSharpLua.Template = "ABILITY_RLF_AURA_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_AURA_DURATION = ConvertAbilityRealLevelField(1097886769);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_APL2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_APL2 = ConvertAbilityRealLevelField(1097886770);
		/// @CSharpLua.Template = "ABILITY_RLF_DURATION_OF_PLAGUE_WARD"
		public static readonly abilityreallevelfield ABILITY_RLF_DURATION_OF_PLAGUE_WARD = ConvertAbilityRealLevelField(1097886771);
		/// @CSharpLua.Template = "ABILITY_RLF_AMOUNT_OF_HIT_POINTS_REGENERATED"
		public static readonly abilityreallevelfield ABILITY_RLF_AMOUNT_OF_HIT_POINTS_REGENERATED = ConvertAbilityRealLevelField(1331786289);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_DAMAGE_INCREASE_AKB1"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_DAMAGE_INCREASE_AKB1 = ConvertAbilityRealLevelField(1097556529);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_LOSS_ADM1"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_LOSS_ADM1 = ConvertAbilityRealLevelField(1097100593);
		/// @CSharpLua.Template = "ABILITY_RLF_SUMMONED_UNIT_DAMAGE_ADM2"
		public static readonly abilityreallevelfield ABILITY_RLF_SUMMONED_UNIT_DAMAGE_ADM2 = ConvertAbilityRealLevelField(1097100594);
		/// @CSharpLua.Template = "ABILITY_RLF_EXPANSION_AMOUNT"
		public static readonly abilityreallevelfield ABILITY_RLF_EXPANSION_AMOUNT = ConvertAbilityRealLevelField(1114401073);
		/// @CSharpLua.Template = "ABILITY_RLF_INTERVAL_DURATION_BGM2"
		public static readonly abilityreallevelfield ABILITY_RLF_INTERVAL_DURATION_BGM2 = ConvertAbilityRealLevelField(1114074418);
		/// @CSharpLua.Template = "ABILITY_RLF_RADIUS_OF_MINING_RING"
		public static readonly abilityreallevelfield ABILITY_RLF_RADIUS_OF_MINING_RING = ConvertAbilityRealLevelField(1114074420);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_INCREASE_PERCENT_BLO1"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_INCREASE_PERCENT_BLO1 = ConvertAbilityRealLevelField(1114402609);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_BLO2"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_BLO2 = ConvertAbilityRealLevelField(1114402610);
		/// @CSharpLua.Template = "ABILITY_RLF_SCALING_FACTOR"
		public static readonly abilityreallevelfield ABILITY_RLF_SCALING_FACTOR = ConvertAbilityRealLevelField(1114402611);
		/// @CSharpLua.Template = "ABILITY_RLF_HIT_POINTS_PER_SECOND_CAN1"
		public static readonly abilityreallevelfield ABILITY_RLF_HIT_POINTS_PER_SECOND_CAN1 = ConvertAbilityRealLevelField(1130458673);
		/// @CSharpLua.Template = "ABILITY_RLF_MAX_HIT_POINTS"
		public static readonly abilityreallevelfield ABILITY_RLF_MAX_HIT_POINTS = ConvertAbilityRealLevelField(1130458674);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_DEV2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_DEV2 = ConvertAbilityRealLevelField(1147500082);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_UPDATE_FREQUENCY_CHD1"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_UPDATE_FREQUENCY_CHD1 = ConvertAbilityRealLevelField(1130914865);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_UPDATE_FREQUENCY_CHD2"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_UPDATE_FREQUENCY_CHD2 = ConvertAbilityRealLevelField(1130914866);
		/// @CSharpLua.Template = "ABILITY_RLF_SUMMONED_UNIT_DAMAGE_CHD3"
		public static readonly abilityreallevelfield ABILITY_RLF_SUMMONED_UNIT_DAMAGE_CHD3 = ConvertAbilityRealLevelField(1130914867);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_CRI1"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_CRI1 = ConvertAbilityRealLevelField(1131571505);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_CRI2"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_CRI2 = ConvertAbilityRealLevelField(1131571506);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_REDUCTION_CRI3"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_REDUCTION_CRI3 = ConvertAbilityRealLevelField(1131571507);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_MISS_CRS"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_MISS_CRS = ConvertAbilityRealLevelField(1131574065);
		/// @CSharpLua.Template = "ABILITY_RLF_FULL_DAMAGE_RADIUS_DDA1"
		public static readonly abilityreallevelfield ABILITY_RLF_FULL_DAMAGE_RADIUS_DDA1 = ConvertAbilityRealLevelField(1147429169);
		/// @CSharpLua.Template = "ABILITY_RLF_FULL_DAMAGE_AMOUNT_DDA2"
		public static readonly abilityreallevelfield ABILITY_RLF_FULL_DAMAGE_AMOUNT_DDA2 = ConvertAbilityRealLevelField(1147429170);
		/// @CSharpLua.Template = "ABILITY_RLF_PARTIAL_DAMAGE_RADIUS"
		public static readonly abilityreallevelfield ABILITY_RLF_PARTIAL_DAMAGE_RADIUS = ConvertAbilityRealLevelField(1147429171);
		/// @CSharpLua.Template = "ABILITY_RLF_PARTIAL_DAMAGE_AMOUNT"
		public static readonly abilityreallevelfield ABILITY_RLF_PARTIAL_DAMAGE_AMOUNT = ConvertAbilityRealLevelField(1147429172);
		/// @CSharpLua.Template = "ABILITY_RLF_BUILDING_DAMAGE_FACTOR_SDS1"
		public static readonly abilityreallevelfield ABILITY_RLF_BUILDING_DAMAGE_FACTOR_SDS1 = ConvertAbilityRealLevelField(1399092017);
		/// @CSharpLua.Template = "ABILITY_RLF_MAX_DAMAGE_UCO5"
		public static readonly abilityreallevelfield ABILITY_RLF_MAX_DAMAGE_UCO5 = ConvertAbilityRealLevelField(1432579893);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVE_SPEED_BONUS_UCO6"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVE_SPEED_BONUS_UCO6 = ConvertAbilityRealLevelField(1432579894);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_TAKEN_PERCENT_DEF1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_TAKEN_PERCENT_DEF1 = ConvertAbilityRealLevelField(1147495985);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_DEALT_PERCENT_DEF2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_DEALT_PERCENT_DEF2 = ConvertAbilityRealLevelField(1147495986);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_FACTOR_DEF3"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_FACTOR_DEF3 = ConvertAbilityRealLevelField(1147495987);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_FACTOR_DEF4"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_FACTOR_DEF4 = ConvertAbilityRealLevelField(1147495988);
		/// @CSharpLua.Template = "ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_DEF5"
		public static readonly abilityreallevelfield ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_DEF5 = ConvertAbilityRealLevelField(1147495989);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_DEFLECT"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_DEFLECT = ConvertAbilityRealLevelField(1147495990);
		/// @CSharpLua.Template = "ABILITY_RLF_DEFLECT_DAMAGE_TAKEN_PIERCING"
		public static readonly abilityreallevelfield ABILITY_RLF_DEFLECT_DAMAGE_TAKEN_PIERCING = ConvertAbilityRealLevelField(1147495991);
		/// @CSharpLua.Template = "ABILITY_RLF_DEFLECT_DAMAGE_TAKEN_SPELLS"
		public static readonly abilityreallevelfield ABILITY_RLF_DEFLECT_DAMAGE_TAKEN_SPELLS = ConvertAbilityRealLevelField(1147495992);
		/// @CSharpLua.Template = "ABILITY_RLF_RIP_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_RIP_DELAY = ConvertAbilityRealLevelField(1164014641);
		/// @CSharpLua.Template = "ABILITY_RLF_EAT_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_EAT_DELAY = ConvertAbilityRealLevelField(1164014642);
		/// @CSharpLua.Template = "ABILITY_RLF_HIT_POINTS_GAINED_EAT3"
		public static readonly abilityreallevelfield ABILITY_RLF_HIT_POINTS_GAINED_EAT3 = ConvertAbilityRealLevelField(1164014643);
		/// @CSharpLua.Template = "ABILITY_RLF_AIR_UNIT_LOWER_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_AIR_UNIT_LOWER_DURATION = ConvertAbilityRealLevelField(1164866353);
		/// @CSharpLua.Template = "ABILITY_RLF_AIR_UNIT_HEIGHT"
		public static readonly abilityreallevelfield ABILITY_RLF_AIR_UNIT_HEIGHT = ConvertAbilityRealLevelField(1164866354);
		/// @CSharpLua.Template = "ABILITY_RLF_MELEE_ATTACK_RANGE"
		public static readonly abilityreallevelfield ABILITY_RLF_MELEE_ATTACK_RANGE = ConvertAbilityRealLevelField(1164866355);
		/// @CSharpLua.Template = "ABILITY_RLF_INTERVAL_DURATION_EGM2"
		public static readonly abilityreallevelfield ABILITY_RLF_INTERVAL_DURATION_EGM2 = ConvertAbilityRealLevelField(1164406066);
		/// @CSharpLua.Template = "ABILITY_RLF_EFFECT_DELAY_FLA2"
		public static readonly abilityreallevelfield ABILITY_RLF_EFFECT_DELAY_FLA2 = ConvertAbilityRealLevelField(1181507890);
		/// @CSharpLua.Template = "ABILITY_RLF_MINING_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_MINING_DURATION = ConvertAbilityRealLevelField(1198285874);
		/// @CSharpLua.Template = "ABILITY_RLF_RADIUS_OF_GRAVESTONES"
		public static readonly abilityreallevelfield ABILITY_RLF_RADIUS_OF_GRAVESTONES = ConvertAbilityRealLevelField(1199137842);
		/// @CSharpLua.Template = "ABILITY_RLF_RADIUS_OF_CORPSES"
		public static readonly abilityreallevelfield ABILITY_RLF_RADIUS_OF_CORPSES = ConvertAbilityRealLevelField(1199137843);
		/// @CSharpLua.Template = "ABILITY_RLF_HIT_POINTS_GAINED_HEA1"
		public static readonly abilityreallevelfield ABILITY_RLF_HIT_POINTS_GAINED_HEA1 = ConvertAbilityRealLevelField(1214603569);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_INCREASE_PERCENT_INF1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_INCREASE_PERCENT_INF1 = ConvertAbilityRealLevelField(1231971889);
		/// @CSharpLua.Template = "ABILITY_RLF_AUTOCAST_RANGE"
		public static readonly abilityreallevelfield ABILITY_RLF_AUTOCAST_RANGE = ConvertAbilityRealLevelField(1231971891);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_REGEN_RATE"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_REGEN_RATE = ConvertAbilityRealLevelField(1231971892);
		/// @CSharpLua.Template = "ABILITY_RLF_GRAPHIC_DELAY_LIT1"
		public static readonly abilityreallevelfield ABILITY_RLF_GRAPHIC_DELAY_LIT1 = ConvertAbilityRealLevelField(1281979441);
		/// @CSharpLua.Template = "ABILITY_RLF_GRAPHIC_DURATION_LIT2"
		public static readonly abilityreallevelfield ABILITY_RLF_GRAPHIC_DURATION_LIT2 = ConvertAbilityRealLevelField(1281979442);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_LSH1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_LSH1 = ConvertAbilityRealLevelField(1282631729);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_GAINED"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_GAINED = ConvertAbilityRealLevelField(1298297905);
		/// @CSharpLua.Template = "ABILITY_RLF_HIT_POINTS_GAINED_MBT2"
		public static readonly abilityreallevelfield ABILITY_RLF_HIT_POINTS_GAINED_MBT2 = ConvertAbilityRealLevelField(1298297906);
		/// @CSharpLua.Template = "ABILITY_RLF_AUTOCAST_REQUIREMENT"
		public static readonly abilityreallevelfield ABILITY_RLF_AUTOCAST_REQUIREMENT = ConvertAbilityRealLevelField(1298297907);
		/// @CSharpLua.Template = "ABILITY_RLF_WATER_HEIGHT"
		public static readonly abilityreallevelfield ABILITY_RLF_WATER_HEIGHT = ConvertAbilityRealLevelField(1298297908);
		/// @CSharpLua.Template = "ABILITY_RLF_ACTIVATION_DELAY_MIN1"
		public static readonly abilityreallevelfield ABILITY_RLF_ACTIVATION_DELAY_MIN1 = ConvertAbilityRealLevelField(1298755121);
		/// @CSharpLua.Template = "ABILITY_RLF_INVISIBILITY_TRANSITION_TIME"
		public static readonly abilityreallevelfield ABILITY_RLF_INVISIBILITY_TRANSITION_TIME = ConvertAbilityRealLevelField(1298755122);
		/// @CSharpLua.Template = "ABILITY_RLF_ACTIVATION_RADIUS"
		public static readonly abilityreallevelfield ABILITY_RLF_ACTIVATION_RADIUS = ConvertAbilityRealLevelField(1315271985);
		/// @CSharpLua.Template = "ABILITY_RLF_AMOUNT_REGENERATED"
		public static readonly abilityreallevelfield ABILITY_RLF_AMOUNT_REGENERATED = ConvertAbilityRealLevelField(1098018097);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_POI1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_POI1 = ConvertAbilityRealLevelField(1349478705);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_FACTOR_POI2"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_FACTOR_POI2 = ConvertAbilityRealLevelField(1349478706);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_FACTOR_POI3"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_FACTOR_POI3 = ConvertAbilityRealLevelField(1349478707);
		/// @CSharpLua.Template = "ABILITY_RLF_EXTRA_DAMAGE_POA1"
		public static readonly abilityreallevelfield ABILITY_RLF_EXTRA_DAMAGE_POA1 = ConvertAbilityRealLevelField(1349476657);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_POA2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_POA2 = ConvertAbilityRealLevelField(1349476658);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_FACTOR_POA3"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_FACTOR_POA3 = ConvertAbilityRealLevelField(1349476659);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_FACTOR_POA4"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_FACTOR_POA4 = ConvertAbilityRealLevelField(1349476660);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_AMPLIFICATION"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_AMPLIFICATION = ConvertAbilityRealLevelField(1349481266);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_STOMP_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_STOMP_PERCENT = ConvertAbilityRealLevelField(1466004017);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_DEALT_WAR2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_DEALT_WAR2 = ConvertAbilityRealLevelField(1466004018);
		/// @CSharpLua.Template = "ABILITY_RLF_FULL_DAMAGE_RADIUS_WAR3"
		public static readonly abilityreallevelfield ABILITY_RLF_FULL_DAMAGE_RADIUS_WAR3 = ConvertAbilityRealLevelField(1466004019);
		/// @CSharpLua.Template = "ABILITY_RLF_HALF_DAMAGE_RADIUS_WAR4"
		public static readonly abilityreallevelfield ABILITY_RLF_HALF_DAMAGE_RADIUS_WAR4 = ConvertAbilityRealLevelField(1466004020);
		/// @CSharpLua.Template = "ABILITY_RLF_SUMMONED_UNIT_DAMAGE_PRG3"
		public static readonly abilityreallevelfield ABILITY_RLF_SUMMONED_UNIT_DAMAGE_PRG3 = ConvertAbilityRealLevelField(1349674803);
		/// @CSharpLua.Template = "ABILITY_RLF_UNIT_PAUSE_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_UNIT_PAUSE_DURATION = ConvertAbilityRealLevelField(1349674804);
		/// @CSharpLua.Template = "ABILITY_RLF_HERO_PAUSE_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_HERO_PAUSE_DURATION = ConvertAbilityRealLevelField(1349674805);
		/// @CSharpLua.Template = "ABILITY_RLF_HIT_POINTS_GAINED_REJ1"
		public static readonly abilityreallevelfield ABILITY_RLF_HIT_POINTS_GAINED_REJ1 = ConvertAbilityRealLevelField(1382378033);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_POINTS_GAINED_REJ2"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_POINTS_GAINED_REJ2 = ConvertAbilityRealLevelField(1382378034);
		/// @CSharpLua.Template = "ABILITY_RLF_MINIMUM_LIFE_REQUIRED"
		public static readonly abilityreallevelfield ABILITY_RLF_MINIMUM_LIFE_REQUIRED = ConvertAbilityRealLevelField(1383096883);
		/// @CSharpLua.Template = "ABILITY_RLF_MINIMUM_MANA_REQUIRED"
		public static readonly abilityreallevelfield ABILITY_RLF_MINIMUM_MANA_REQUIRED = ConvertAbilityRealLevelField(1383096884);
		/// @CSharpLua.Template = "ABILITY_RLF_REPAIR_COST_RATIO"
		public static readonly abilityreallevelfield ABILITY_RLF_REPAIR_COST_RATIO = ConvertAbilityRealLevelField(1382379569);
		/// @CSharpLua.Template = "ABILITY_RLF_REPAIR_TIME_RATIO"
		public static readonly abilityreallevelfield ABILITY_RLF_REPAIR_TIME_RATIO = ConvertAbilityRealLevelField(1382379570);
		/// @CSharpLua.Template = "ABILITY_RLF_POWERBUILD_COST"
		public static readonly abilityreallevelfield ABILITY_RLF_POWERBUILD_COST = ConvertAbilityRealLevelField(1382379571);
		/// @CSharpLua.Template = "ABILITY_RLF_POWERBUILD_RATE"
		public static readonly abilityreallevelfield ABILITY_RLF_POWERBUILD_RATE = ConvertAbilityRealLevelField(1382379572);
		/// @CSharpLua.Template = "ABILITY_RLF_NAVAL_RANGE_BONUS"
		public static readonly abilityreallevelfield ABILITY_RLF_NAVAL_RANGE_BONUS = ConvertAbilityRealLevelField(1382379573);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_INCREASE_PERCENT_ROA1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_INCREASE_PERCENT_ROA1 = ConvertAbilityRealLevelField(1383031089);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_REGENERATION_RATE"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_REGENERATION_RATE = ConvertAbilityRealLevelField(1383031091);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_REGEN"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_REGEN = ConvertAbilityRealLevelField(1383031092);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_INCREASE"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_INCREASE = ConvertAbilityRealLevelField(1315074609);
		/// @CSharpLua.Template = "ABILITY_RLF_SALVAGE_COST_RATIO"
		public static readonly abilityreallevelfield ABILITY_RLF_SALVAGE_COST_RATIO = ConvertAbilityRealLevelField(1398893617);
		/// @CSharpLua.Template = "ABILITY_RLF_IN_FLIGHT_SIGHT_RADIUS"
		public static readonly abilityreallevelfield ABILITY_RLF_IN_FLIGHT_SIGHT_RADIUS = ConvertAbilityRealLevelField(1165192753);
		/// @CSharpLua.Template = "ABILITY_RLF_HOVERING_SIGHT_RADIUS"
		public static readonly abilityreallevelfield ABILITY_RLF_HOVERING_SIGHT_RADIUS = ConvertAbilityRealLevelField(1165192754);
		/// @CSharpLua.Template = "ABILITY_RLF_HOVERING_HEIGHT"
		public static readonly abilityreallevelfield ABILITY_RLF_HOVERING_HEIGHT = ConvertAbilityRealLevelField(1165192755);
		/// @CSharpLua.Template = "ABILITY_RLF_DURATION_OF_OWLS"
		public static readonly abilityreallevelfield ABILITY_RLF_DURATION_OF_OWLS = ConvertAbilityRealLevelField(1165192757);
		/// @CSharpLua.Template = "ABILITY_RLF_FADE_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_FADE_DURATION = ConvertAbilityRealLevelField(1399352625);
		/// @CSharpLua.Template = "ABILITY_RLF_DAY_NIGHT_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_DAY_NIGHT_DURATION = ConvertAbilityRealLevelField(1399352626);
		/// @CSharpLua.Template = "ABILITY_RLF_ACTION_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_ACTION_DURATION = ConvertAbilityRealLevelField(1399352627);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_FACTOR_SLO1"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_FACTOR_SLO1 = ConvertAbilityRealLevelField(1399615281);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_FACTOR_SLO2"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_FACTOR_SLO2 = ConvertAbilityRealLevelField(1399615282);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_SPO1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_SPO1 = ConvertAbilityRealLevelField(1399877425);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_FACTOR_SPO2"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_FACTOR_SPO2 = ConvertAbilityRealLevelField(1399877426);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_FACTOR_SPO3"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_FACTOR_SPO3 = ConvertAbilityRealLevelField(1399877427);
		/// @CSharpLua.Template = "ABILITY_RLF_ACTIVATION_DELAY_STA1"
		public static readonly abilityreallevelfield ABILITY_RLF_ACTIVATION_DELAY_STA1 = ConvertAbilityRealLevelField(1400135985);
		/// @CSharpLua.Template = "ABILITY_RLF_DETECTION_RADIUS_STA2"
		public static readonly abilityreallevelfield ABILITY_RLF_DETECTION_RADIUS_STA2 = ConvertAbilityRealLevelField(1400135986);
		/// @CSharpLua.Template = "ABILITY_RLF_DETONATION_RADIUS"
		public static readonly abilityreallevelfield ABILITY_RLF_DETONATION_RADIUS = ConvertAbilityRealLevelField(1400135987);
		/// @CSharpLua.Template = "ABILITY_RLF_STUN_DURATION_STA4"
		public static readonly abilityreallevelfield ABILITY_RLF_STUN_DURATION_STA4 = ConvertAbilityRealLevelField(1400135988);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_BONUS_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_BONUS_PERCENT = ConvertAbilityRealLevelField(1432905265);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_UHF2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_UHF2 = ConvertAbilityRealLevelField(1432905266);
		/// @CSharpLua.Template = "ABILITY_RLF_LUMBER_PER_INTERVAL"
		public static readonly abilityreallevelfield ABILITY_RLF_LUMBER_PER_INTERVAL = ConvertAbilityRealLevelField(1466458417);
		/// @CSharpLua.Template = "ABILITY_RLF_ART_ATTACHMENT_HEIGHT"
		public static readonly abilityreallevelfield ABILITY_RLF_ART_ATTACHMENT_HEIGHT = ConvertAbilityRealLevelField(1466458419);
		/// @CSharpLua.Template = "ABILITY_RLF_TELEPORT_AREA_WIDTH"
		public static readonly abilityreallevelfield ABILITY_RLF_TELEPORT_AREA_WIDTH = ConvertAbilityRealLevelField(1467117617);
		/// @CSharpLua.Template = "ABILITY_RLF_TELEPORT_AREA_HEIGHT"
		public static readonly abilityreallevelfield ABILITY_RLF_TELEPORT_AREA_HEIGHT = ConvertAbilityRealLevelField(1467117618);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_STOLEN_PER_ATTACK"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_STOLEN_PER_ATTACK = ConvertAbilityRealLevelField(1232494957);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_BONUS_IDAM"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_BONUS_IDAM = ConvertAbilityRealLevelField(1231315309);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_HIT_UNITS_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_HIT_UNITS_PERCENT = ConvertAbilityRealLevelField(1232036402);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_HIT_HEROS_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_HIT_HEROS_PERCENT = ConvertAbilityRealLevelField(1232036403);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_HIT_SUMMONS_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_HIT_SUMMONS_PERCENT = ConvertAbilityRealLevelField(1232036404);
		/// @CSharpLua.Template = "ABILITY_RLF_DELAY_FOR_TARGET_EFFECT"
		public static readonly abilityreallevelfield ABILITY_RLF_DELAY_FOR_TARGET_EFFECT = ConvertAbilityRealLevelField(1231316332);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_DEALT_PERCENT_OF_NORMAL"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_DEALT_PERCENT_OF_NORMAL = ConvertAbilityRealLevelField(1231645796);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_RECEIVED_MULTIPLIER"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_RECEIVED_MULTIPLIER = ConvertAbilityRealLevelField(1231645815);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_REGENERATION_BONUS_AS_FRACTION_OF_NORMAL"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_REGENERATION_BONUS_AS_FRACTION_OF_NORMAL = ConvertAbilityRealLevelField(1231909488);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_INCREASE_ISPI"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_INCREASE_ISPI = ConvertAbilityRealLevelField(1232302185);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_IDPS"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_IDPS = ConvertAbilityRealLevelField(1231319155);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_DAMAGE_INCREASE_CAC1"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_DAMAGE_INCREASE_CAC1 = ConvertAbilityRealLevelField(1130455857);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_COR1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_COR1 = ConvertAbilityRealLevelField(1131377201);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_INCREASE_ISX1"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_INCREASE_ISX1 = ConvertAbilityRealLevelField(1232304177);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_WRS1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_WRS1 = ConvertAbilityRealLevelField(1467118385);
		/// @CSharpLua.Template = "ABILITY_RLF_TERRAIN_DEFORMATION_AMPLITUDE"
		public static readonly abilityreallevelfield ABILITY_RLF_TERRAIN_DEFORMATION_AMPLITUDE = ConvertAbilityRealLevelField(1467118386);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_CTC1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_CTC1 = ConvertAbilityRealLevelField(1131701041);
		/// @CSharpLua.Template = "ABILITY_RLF_EXTRA_DAMAGE_TO_TARGET"
		public static readonly abilityreallevelfield ABILITY_RLF_EXTRA_DAMAGE_TO_TARGET = ConvertAbilityRealLevelField(1131701042);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_CTC3"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_CTC3 = ConvertAbilityRealLevelField(1131701043);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_REDUCTION_CTC4"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_REDUCTION_CTC4 = ConvertAbilityRealLevelField(1131701044);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_CTB1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_CTB1 = ConvertAbilityRealLevelField(1131700785);
		/// @CSharpLua.Template = "ABILITY_RLF_CASTING_DELAY_SECONDS"
		public static readonly abilityreallevelfield ABILITY_RLF_CASTING_DELAY_SECONDS = ConvertAbilityRealLevelField(1432646450);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_LOSS_PER_UNIT_DTN1"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_LOSS_PER_UNIT_DTN1 = ConvertAbilityRealLevelField(1148481073);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_TO_SUMMONED_UNITS_DTN2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_TO_SUMMONED_UNITS_DTN2 = ConvertAbilityRealLevelField(1148481074);
		/// @CSharpLua.Template = "ABILITY_RLF_TRANSITION_TIME_SECONDS"
		public static readonly abilityreallevelfield ABILITY_RLF_TRANSITION_TIME_SECONDS = ConvertAbilityRealLevelField(1232499505);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_DRAINED_PER_SECOND_NMR1"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_DRAINED_PER_SECOND_NMR1 = ConvertAbilityRealLevelField(1315795505);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_REDUCE_DAMAGE_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_REDUCE_DAMAGE_PERCENT = ConvertAbilityRealLevelField(1400073009);
		/// @CSharpLua.Template = "ABILITY_RLF_MINIMUM_DAMAGE"
		public static readonly abilityreallevelfield ABILITY_RLF_MINIMUM_DAMAGE = ConvertAbilityRealLevelField(1400073010);
		/// @CSharpLua.Template = "ABILITY_RLF_IGNORED_DAMAGE"
		public static readonly abilityreallevelfield ABILITY_RLF_IGNORED_DAMAGE = ConvertAbilityRealLevelField(1400073011);
		/// @CSharpLua.Template = "ABILITY_RLF_FULL_DAMAGE_DEALT"
		public static readonly abilityreallevelfield ABILITY_RLF_FULL_DAMAGE_DEALT = ConvertAbilityRealLevelField(1214673713);
		/// @CSharpLua.Template = "ABILITY_RLF_FULL_DAMAGE_INTERVAL"
		public static readonly abilityreallevelfield ABILITY_RLF_FULL_DAMAGE_INTERVAL = ConvertAbilityRealLevelField(1214673714);
		/// @CSharpLua.Template = "ABILITY_RLF_HALF_DAMAGE_DEALT"
		public static readonly abilityreallevelfield ABILITY_RLF_HALF_DAMAGE_DEALT = ConvertAbilityRealLevelField(1214673715);
		/// @CSharpLua.Template = "ABILITY_RLF_HALF_DAMAGE_INTERVAL"
		public static readonly abilityreallevelfield ABILITY_RLF_HALF_DAMAGE_INTERVAL = ConvertAbilityRealLevelField(1214673716);
		/// @CSharpLua.Template = "ABILITY_RLF_BUILDING_REDUCTION_HFS5"
		public static readonly abilityreallevelfield ABILITY_RLF_BUILDING_REDUCTION_HFS5 = ConvertAbilityRealLevelField(1214673717);
		/// @CSharpLua.Template = "ABILITY_RLF_MAXIMUM_DAMAGE_HFS6"
		public static readonly abilityreallevelfield ABILITY_RLF_MAXIMUM_DAMAGE_HFS6 = ConvertAbilityRealLevelField(1214673718);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_PER_HIT_POINT"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_PER_HIT_POINT = ConvertAbilityRealLevelField(1315795761);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_ABSORBED_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_ABSORBED_PERCENT = ConvertAbilityRealLevelField(1315795762);
		/// @CSharpLua.Template = "ABILITY_RLF_WAVE_DISTANCE"
		public static readonly abilityreallevelfield ABILITY_RLF_WAVE_DISTANCE = ConvertAbilityRealLevelField(1432972593);
		/// @CSharpLua.Template = "ABILITY_RLF_WAVE_TIME_SECONDS"
		public static readonly abilityreallevelfield ABILITY_RLF_WAVE_TIME_SECONDS = ConvertAbilityRealLevelField(1432972594);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_DEALT_UIM3"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_DEALT_UIM3 = ConvertAbilityRealLevelField(1432972595);
		/// @CSharpLua.Template = "ABILITY_RLF_AIR_TIME_SECONDS_UIM4"
		public static readonly abilityreallevelfield ABILITY_RLF_AIR_TIME_SECONDS_UIM4 = ConvertAbilityRealLevelField(1432972596);
		/// @CSharpLua.Template = "ABILITY_RLF_UNIT_RELEASE_INTERVAL_SECONDS"
		public static readonly abilityreallevelfield ABILITY_RLF_UNIT_RELEASE_INTERVAL_SECONDS = ConvertAbilityRealLevelField(1433170738);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_RETURN_FACTOR"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_RETURN_FACTOR = ConvertAbilityRealLevelField(1433170740);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_RETURN_THRESHOLD"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_RETURN_THRESHOLD = ConvertAbilityRealLevelField(1433170741);
		/// @CSharpLua.Template = "ABILITY_RLF_RETURNED_DAMAGE_FACTOR"
		public static readonly abilityreallevelfield ABILITY_RLF_RETURNED_DAMAGE_FACTOR = ConvertAbilityRealLevelField(1433695025);
		/// @CSharpLua.Template = "ABILITY_RLF_RECEIVED_DAMAGE_FACTOR"
		public static readonly abilityreallevelfield ABILITY_RLF_RECEIVED_DAMAGE_FACTOR = ConvertAbilityRealLevelField(1433695026);
		/// @CSharpLua.Template = "ABILITY_RLF_DEFENSE_BONUS_UTS3"
		public static readonly abilityreallevelfield ABILITY_RLF_DEFENSE_BONUS_UTS3 = ConvertAbilityRealLevelField(1433695027);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_BONUS_NBA1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_BONUS_NBA1 = ConvertAbilityRealLevelField(1315070257);
		/// @CSharpLua.Template = "ABILITY_RLF_SUMMONED_UNIT_DURATION_SECONDS_NBA3"
		public static readonly abilityreallevelfield ABILITY_RLF_SUMMONED_UNIT_DURATION_SECONDS_NBA3 = ConvertAbilityRealLevelField(1315070259);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_PER_SUMMONED_HITPOINT"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_PER_SUMMONED_HITPOINT = ConvertAbilityRealLevelField(1131243314);
		/// @CSharpLua.Template = "ABILITY_RLF_CHARGE_FOR_CURRENT_LIFE"
		public static readonly abilityreallevelfield ABILITY_RLF_CHARGE_FOR_CURRENT_LIFE = ConvertAbilityRealLevelField(1131243315);
		/// @CSharpLua.Template = "ABILITY_RLF_HIT_POINTS_DRAINED"
		public static readonly abilityreallevelfield ABILITY_RLF_HIT_POINTS_DRAINED = ConvertAbilityRealLevelField(1315205681);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_POINTS_DRAINED"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_POINTS_DRAINED = ConvertAbilityRealLevelField(1315205682);
		/// @CSharpLua.Template = "ABILITY_RLF_DRAIN_INTERVAL_SECONDS"
		public static readonly abilityreallevelfield ABILITY_RLF_DRAIN_INTERVAL_SECONDS = ConvertAbilityRealLevelField(1315205683);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_TRANSFERRED_PER_SECOND"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_TRANSFERRED_PER_SECOND = ConvertAbilityRealLevelField(1315205684);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_TRANSFERRED_PER_SECOND"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_TRANSFERRED_PER_SECOND = ConvertAbilityRealLevelField(1315205685);
		/// @CSharpLua.Template = "ABILITY_RLF_BONUS_LIFE_FACTOR"
		public static readonly abilityreallevelfield ABILITY_RLF_BONUS_LIFE_FACTOR = ConvertAbilityRealLevelField(1315205686);
		/// @CSharpLua.Template = "ABILITY_RLF_BONUS_LIFE_DECAY"
		public static readonly abilityreallevelfield ABILITY_RLF_BONUS_LIFE_DECAY = ConvertAbilityRealLevelField(1315205687);
		/// @CSharpLua.Template = "ABILITY_RLF_BONUS_MANA_FACTOR"
		public static readonly abilityreallevelfield ABILITY_RLF_BONUS_MANA_FACTOR = ConvertAbilityRealLevelField(1315205688);
		/// @CSharpLua.Template = "ABILITY_RLF_BONUS_MANA_DECAY"
		public static readonly abilityreallevelfield ABILITY_RLF_BONUS_MANA_DECAY = ConvertAbilityRealLevelField(1315205689);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_MISS_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_MISS_PERCENT = ConvertAbilityRealLevelField(1316186418);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_MODIFIER"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_MODIFIER = ConvertAbilityRealLevelField(1316186419);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_MODIFIER"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_MODIFIER = ConvertAbilityRealLevelField(1316186420);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_TDG1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_TDG1 = ConvertAbilityRealLevelField(1415866161);
		/// @CSharpLua.Template = "ABILITY_RLF_MEDIUM_DAMAGE_RADIUS_TDG2"
		public static readonly abilityreallevelfield ABILITY_RLF_MEDIUM_DAMAGE_RADIUS_TDG2 = ConvertAbilityRealLevelField(1415866162);
		/// @CSharpLua.Template = "ABILITY_RLF_MEDIUM_DAMAGE_PER_SECOND"
		public static readonly abilityreallevelfield ABILITY_RLF_MEDIUM_DAMAGE_PER_SECOND = ConvertAbilityRealLevelField(1415866163);
		/// @CSharpLua.Template = "ABILITY_RLF_SMALL_DAMAGE_RADIUS_TDG4"
		public static readonly abilityreallevelfield ABILITY_RLF_SMALL_DAMAGE_RADIUS_TDG4 = ConvertAbilityRealLevelField(1415866164);
		/// @CSharpLua.Template = "ABILITY_RLF_SMALL_DAMAGE_PER_SECOND"
		public static readonly abilityreallevelfield ABILITY_RLF_SMALL_DAMAGE_PER_SECOND = ConvertAbilityRealLevelField(1415866165);
		/// @CSharpLua.Template = "ABILITY_RLF_AIR_TIME_SECONDS_TSP1"
		public static readonly abilityreallevelfield ABILITY_RLF_AIR_TIME_SECONDS_TSP1 = ConvertAbilityRealLevelField(1416851505);
		/// @CSharpLua.Template = "ABILITY_RLF_MINIMUM_HIT_INTERVAL_SECONDS"
		public static readonly abilityreallevelfield ABILITY_RLF_MINIMUM_HIT_INTERVAL_SECONDS = ConvertAbilityRealLevelField(1416851506);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_NBF5"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_NBF5 = ConvertAbilityRealLevelField(1315071541);
		/// @CSharpLua.Template = "ABILITY_RLF_MAXIMUM_RANGE"
		public static readonly abilityreallevelfield ABILITY_RLF_MAXIMUM_RANGE = ConvertAbilityRealLevelField(1164078129);
		/// @CSharpLua.Template = "ABILITY_RLF_MINIMUM_RANGE"
		public static readonly abilityreallevelfield ABILITY_RLF_MINIMUM_RANGE = ConvertAbilityRealLevelField(1164078130);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_TARGET_EFK1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_TARGET_EFK1 = ConvertAbilityRealLevelField(1164340017);
		/// @CSharpLua.Template = "ABILITY_RLF_MAXIMUM_TOTAL_DAMAGE"
		public static readonly abilityreallevelfield ABILITY_RLF_MAXIMUM_TOTAL_DAMAGE = ConvertAbilityRealLevelField(1164340018);
		/// @CSharpLua.Template = "ABILITY_RLF_MAXIMUM_SPEED_ADJUSTMENT"
		public static readonly abilityreallevelfield ABILITY_RLF_MAXIMUM_SPEED_ADJUSTMENT = ConvertAbilityRealLevelField(1164340020);
		/// @CSharpLua.Template = "ABILITY_RLF_DECAYING_DAMAGE"
		public static readonly abilityreallevelfield ABILITY_RLF_DECAYING_DAMAGE = ConvertAbilityRealLevelField(1165191217);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_FACTOR_ESH2"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_FACTOR_ESH2 = ConvertAbilityRealLevelField(1165191218);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_FACTOR_ESH3"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_FACTOR_ESH3 = ConvertAbilityRealLevelField(1165191219);
		/// @CSharpLua.Template = "ABILITY_RLF_DECAY_POWER"
		public static readonly abilityreallevelfield ABILITY_RLF_DECAY_POWER = ConvertAbilityRealLevelField(1165191220);
		/// @CSharpLua.Template = "ABILITY_RLF_INITIAL_DAMAGE_ESH5"
		public static readonly abilityreallevelfield ABILITY_RLF_INITIAL_DAMAGE_ESH5 = ConvertAbilityRealLevelField(1165191221);
		/// @CSharpLua.Template = "ABILITY_RLF_MAXIMUM_LIFE_ABSORBED"
		public static readonly abilityreallevelfield ABILITY_RLF_MAXIMUM_LIFE_ABSORBED = ConvertAbilityRealLevelField(1633841969);
		/// @CSharpLua.Template = "ABILITY_RLF_MAXIMUM_MANA_ABSORBED"
		public static readonly abilityreallevelfield ABILITY_RLF_MAXIMUM_MANA_ABSORBED = ConvertAbilityRealLevelField(1633841970);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_INCREASE_BSK1"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_INCREASE_BSK1 = ConvertAbilityRealLevelField(1651731249);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_INCREASE_BSK2"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_INCREASE_BSK2 = ConvertAbilityRealLevelField(1651731250);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_TAKEN_INCREASE"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_TAKEN_INCREASE = ConvertAbilityRealLevelField(1651731251);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_PER_UNIT"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_PER_UNIT = ConvertAbilityRealLevelField(1685482801);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_PER_UNIT"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_PER_UNIT = ConvertAbilityRealLevelField(1685482802);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_PER_BUFF"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_PER_BUFF = ConvertAbilityRealLevelField(1685482803);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_PER_BUFF"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_PER_BUFF = ConvertAbilityRealLevelField(1685482804);
		/// @CSharpLua.Template = "ABILITY_RLF_SUMMONED_UNIT_DAMAGE_DVM5"
		public static readonly abilityreallevelfield ABILITY_RLF_SUMMONED_UNIT_DAMAGE_DVM5 = ConvertAbilityRealLevelField(1685482805);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_BONUS_FAK1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_BONUS_FAK1 = ConvertAbilityRealLevelField(1717660465);
		/// @CSharpLua.Template = "ABILITY_RLF_MEDIUM_DAMAGE_FACTOR_FAK2"
		public static readonly abilityreallevelfield ABILITY_RLF_MEDIUM_DAMAGE_FACTOR_FAK2 = ConvertAbilityRealLevelField(1717660466);
		/// @CSharpLua.Template = "ABILITY_RLF_SMALL_DAMAGE_FACTOR_FAK3"
		public static readonly abilityreallevelfield ABILITY_RLF_SMALL_DAMAGE_FACTOR_FAK3 = ConvertAbilityRealLevelField(1717660467);
		/// @CSharpLua.Template = "ABILITY_RLF_FULL_DAMAGE_RADIUS_FAK4"
		public static readonly abilityreallevelfield ABILITY_RLF_FULL_DAMAGE_RADIUS_FAK4 = ConvertAbilityRealLevelField(1717660468);
		/// @CSharpLua.Template = "ABILITY_RLF_HALF_DAMAGE_RADIUS_FAK5"
		public static readonly abilityreallevelfield ABILITY_RLF_HALF_DAMAGE_RADIUS_FAK5 = ConvertAbilityRealLevelField(1717660469);
		/// @CSharpLua.Template = "ABILITY_RLF_EXTRA_DAMAGE_PER_SECOND"
		public static readonly abilityreallevelfield ABILITY_RLF_EXTRA_DAMAGE_PER_SECOND = ConvertAbilityRealLevelField(1818849585);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_LIQ2"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_LIQ2 = ConvertAbilityRealLevelField(1818849586);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_REDUCTION_LIQ3"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_REDUCTION_LIQ3 = ConvertAbilityRealLevelField(1818849587);
		/// @CSharpLua.Template = "ABILITY_RLF_MAGIC_DAMAGE_FACTOR"
		public static readonly abilityreallevelfield ABILITY_RLF_MAGIC_DAMAGE_FACTOR = ConvertAbilityRealLevelField(1835625777);
		/// @CSharpLua.Template = "ABILITY_RLF_UNIT_DAMAGE_PER_MANA_POINT"
		public static readonly abilityreallevelfield ABILITY_RLF_UNIT_DAMAGE_PER_MANA_POINT = ConvertAbilityRealLevelField(1835428913);
		/// @CSharpLua.Template = "ABILITY_RLF_HERO_DAMAGE_PER_MANA_POINT"
		public static readonly abilityreallevelfield ABILITY_RLF_HERO_DAMAGE_PER_MANA_POINT = ConvertAbilityRealLevelField(1835428914);
		/// @CSharpLua.Template = "ABILITY_RLF_UNIT_MAXIMUM_DAMAGE"
		public static readonly abilityreallevelfield ABILITY_RLF_UNIT_MAXIMUM_DAMAGE = ConvertAbilityRealLevelField(1835428915);
		/// @CSharpLua.Template = "ABILITY_RLF_HERO_MAXIMUM_DAMAGE"
		public static readonly abilityreallevelfield ABILITY_RLF_HERO_MAXIMUM_DAMAGE = ConvertAbilityRealLevelField(1835428916);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_COOLDOWN"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_COOLDOWN = ConvertAbilityRealLevelField(1835428917);
		/// @CSharpLua.Template = "ABILITY_RLF_DISTRIBUTED_DAMAGE_FACTOR_SPL1"
		public static readonly abilityreallevelfield ABILITY_RLF_DISTRIBUTED_DAMAGE_FACTOR_SPL1 = ConvertAbilityRealLevelField(1936747569);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_REGENERATED"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_REGENERATED = ConvertAbilityRealLevelField(1769106481);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_REGENERATED"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_REGENERATED = ConvertAbilityRealLevelField(1769106482);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_LOSS_PER_UNIT_IDC1"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_LOSS_PER_UNIT_IDC1 = ConvertAbilityRealLevelField(1768186673);
		/// @CSharpLua.Template = "ABILITY_RLF_SUMMONED_UNIT_DAMAGE_IDC2"
		public static readonly abilityreallevelfield ABILITY_RLF_SUMMONED_UNIT_DAMAGE_IDC2 = ConvertAbilityRealLevelField(1768186674);
		/// @CSharpLua.Template = "ABILITY_RLF_ACTIVATION_DELAY_IMO2"
		public static readonly abilityreallevelfield ABILITY_RLF_ACTIVATION_DELAY_IMO2 = ConvertAbilityRealLevelField(1768779570);
		/// @CSharpLua.Template = "ABILITY_RLF_LURE_INTERVAL_SECONDS"
		public static readonly abilityreallevelfield ABILITY_RLF_LURE_INTERVAL_SECONDS = ConvertAbilityRealLevelField(1768779571);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_BONUS_ISR1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_BONUS_ISR1 = ConvertAbilityRealLevelField(1769173553);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_REDUCTION_ISR2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_REDUCTION_ISR2 = ConvertAbilityRealLevelField(1769173554);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_BONUS_IPV1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_BONUS_IPV1 = ConvertAbilityRealLevelField(1768977969);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_STEAL_AMOUNT"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_STEAL_AMOUNT = ConvertAbilityRealLevelField(1768977970);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_RESTORED_FACTOR"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_RESTORED_FACTOR = ConvertAbilityRealLevelField(1634956337);
		/// @CSharpLua.Template = "ABILITY_RLF_MANA_RESTORED_FACTOR"
		public static readonly abilityreallevelfield ABILITY_RLF_MANA_RESTORED_FACTOR = ConvertAbilityRealLevelField(1634956338);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACH_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACH_DELAY = ConvertAbilityRealLevelField(1735549233);
		/// @CSharpLua.Template = "ABILITY_RLF_REMOVE_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_REMOVE_DELAY = ConvertAbilityRealLevelField(1735549234);
		/// @CSharpLua.Template = "ABILITY_RLF_HERO_REGENERATION_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_HERO_REGENERATION_DELAY = ConvertAbilityRealLevelField(1316184370);
		/// @CSharpLua.Template = "ABILITY_RLF_UNIT_REGENERATION_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_UNIT_REGENERATION_DELAY = ConvertAbilityRealLevelField(1316184371);
		/// @CSharpLua.Template = "ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_NSA4"
		public static readonly abilityreallevelfield ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_NSA4 = ConvertAbilityRealLevelField(1316184372);
		/// @CSharpLua.Template = "ABILITY_RLF_HIT_POINTS_PER_SECOND_NSA5"
		public static readonly abilityreallevelfield ABILITY_RLF_HIT_POINTS_PER_SECOND_NSA5 = ConvertAbilityRealLevelField(1316184373);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_TO_SUMMONED_UNITS_IXS1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_TO_SUMMONED_UNITS_IXS1 = ConvertAbilityRealLevelField(1232630577);
		/// @CSharpLua.Template = "ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_IXS2"
		public static readonly abilityreallevelfield ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_IXS2 = ConvertAbilityRealLevelField(1232630578);
		/// @CSharpLua.Template = "ABILITY_RLF_SUMMONED_UNIT_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_SUMMONED_UNIT_DURATION = ConvertAbilityRealLevelField(1315987766);
		/// @CSharpLua.Template = "ABILITY_RLF_SHIELD_COOLDOWN_TIME"
		public static readonly abilityreallevelfield ABILITY_RLF_SHIELD_COOLDOWN_TIME = ConvertAbilityRealLevelField(1316185393);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_NDO1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_NDO1 = ConvertAbilityRealLevelField(1315204913);
		/// @CSharpLua.Template = "ABILITY_RLF_SUMMONED_UNIT_DURATION_SECONDS_NDO3"
		public static readonly abilityreallevelfield ABILITY_RLF_SUMMONED_UNIT_DURATION_SECONDS_NDO3 = ConvertAbilityRealLevelField(1315204915);
		/// @CSharpLua.Template = "ABILITY_RLF_MEDIUM_DAMAGE_RADIUS_FLK1"
		public static readonly abilityreallevelfield ABILITY_RLF_MEDIUM_DAMAGE_RADIUS_FLK1 = ConvertAbilityRealLevelField(1718381361);
		/// @CSharpLua.Template = "ABILITY_RLF_SMALL_DAMAGE_RADIUS_FLK2"
		public static readonly abilityreallevelfield ABILITY_RLF_SMALL_DAMAGE_RADIUS_FLK2 = ConvertAbilityRealLevelField(1718381362);
		/// @CSharpLua.Template = "ABILITY_RLF_FULL_DAMAGE_AMOUNT_FLK3"
		public static readonly abilityreallevelfield ABILITY_RLF_FULL_DAMAGE_AMOUNT_FLK3 = ConvertAbilityRealLevelField(1718381363);
		/// @CSharpLua.Template = "ABILITY_RLF_MEDIUM_DAMAGE_AMOUNT"
		public static readonly abilityreallevelfield ABILITY_RLF_MEDIUM_DAMAGE_AMOUNT = ConvertAbilityRealLevelField(1718381364);
		/// @CSharpLua.Template = "ABILITY_RLF_SMALL_DAMAGE_AMOUNT"
		public static readonly abilityreallevelfield ABILITY_RLF_SMALL_DAMAGE_AMOUNT = ConvertAbilityRealLevelField(1718381365);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_HBN1"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_HBN1 = ConvertAbilityRealLevelField(1214410289);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_HBN2"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_HBN2 = ConvertAbilityRealLevelField(1214410290);
		/// @CSharpLua.Template = "ABILITY_RLF_MAX_MANA_DRAINED_UNITS"
		public static readonly abilityreallevelfield ABILITY_RLF_MAX_MANA_DRAINED_UNITS = ConvertAbilityRealLevelField(1717726001);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_RATIO_UNITS_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_RATIO_UNITS_PERCENT = ConvertAbilityRealLevelField(1717726002);
		/// @CSharpLua.Template = "ABILITY_RLF_MAX_MANA_DRAINED_HEROS"
		public static readonly abilityreallevelfield ABILITY_RLF_MAX_MANA_DRAINED_HEROS = ConvertAbilityRealLevelField(1717726003);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_RATIO_HEROS_PERCENT"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_RATIO_HEROS_PERCENT = ConvertAbilityRealLevelField(1717726004);
		/// @CSharpLua.Template = "ABILITY_RLF_SUMMONED_DAMAGE"
		public static readonly abilityreallevelfield ABILITY_RLF_SUMMONED_DAMAGE = ConvertAbilityRealLevelField(1717726005);
		/// @CSharpLua.Template = "ABILITY_RLF_DISTRIBUTED_DAMAGE_FACTOR_NCA1"
		public static readonly abilityreallevelfield ABILITY_RLF_DISTRIBUTED_DAMAGE_FACTOR_NCA1 = ConvertAbilityRealLevelField(1852006705);
		/// @CSharpLua.Template = "ABILITY_RLF_INITIAL_DAMAGE_PXF1"
		public static readonly abilityreallevelfield ABILITY_RLF_INITIAL_DAMAGE_PXF1 = ConvertAbilityRealLevelField(1886938673);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_PXF2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_PXF2 = ConvertAbilityRealLevelField(1886938674);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PER_SECOND_MLS1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PER_SECOND_MLS1 = ConvertAbilityRealLevelField(1835823921);
		/// @CSharpLua.Template = "ABILITY_RLF_BEAST_COLLISION_RADIUS"
		public static readonly abilityreallevelfield ABILITY_RLF_BEAST_COLLISION_RADIUS = ConvertAbilityRealLevelField(1316189234);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_AMOUNT_NST3"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_AMOUNT_NST3 = ConvertAbilityRealLevelField(1316189235);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_RADIUS"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_RADIUS = ConvertAbilityRealLevelField(1316189236);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_DELAY = ConvertAbilityRealLevelField(1316189237);
		/// @CSharpLua.Template = "ABILITY_RLF_FOLLOW_THROUGH_TIME"
		public static readonly abilityreallevelfield ABILITY_RLF_FOLLOW_THROUGH_TIME = ConvertAbilityRealLevelField(1315138609);
		/// @CSharpLua.Template = "ABILITY_RLF_ART_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_ART_DURATION = ConvertAbilityRealLevelField(1315138612);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_NAB1"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_NAB1 = ConvertAbilityRealLevelField(1315004977);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_NAB2"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_NAB2 = ConvertAbilityRealLevelField(1315004978);
		/// @CSharpLua.Template = "ABILITY_RLF_PRIMARY_DAMAGE"
		public static readonly abilityreallevelfield ABILITY_RLF_PRIMARY_DAMAGE = ConvertAbilityRealLevelField(1315004980);
		/// @CSharpLua.Template = "ABILITY_RLF_SECONDARY_DAMAGE"
		public static readonly abilityreallevelfield ABILITY_RLF_SECONDARY_DAMAGE = ConvertAbilityRealLevelField(1315004981);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_INTERVAL_NAB6"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_INTERVAL_NAB6 = ConvertAbilityRealLevelField(1315004982);
		/// @CSharpLua.Template = "ABILITY_RLF_GOLD_COST_FACTOR"
		public static readonly abilityreallevelfield ABILITY_RLF_GOLD_COST_FACTOR = ConvertAbilityRealLevelField(1316252977);
		/// @CSharpLua.Template = "ABILITY_RLF_LUMBER_COST_FACTOR"
		public static readonly abilityreallevelfield ABILITY_RLF_LUMBER_COST_FACTOR = ConvertAbilityRealLevelField(1316252978);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVE_SPEED_BONUS_NEG1"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVE_SPEED_BONUS_NEG1 = ConvertAbilityRealLevelField(1315268401);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_BONUS_NEG2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_BONUS_NEG2 = ConvertAbilityRealLevelField(1315268402);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_AMOUNT_NCS1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_AMOUNT_NCS1 = ConvertAbilityRealLevelField(1315140401);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_INTERVAL_NCS2"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_INTERVAL_NCS2 = ConvertAbilityRealLevelField(1315140402);
		/// @CSharpLua.Template = "ABILITY_RLF_MAX_DAMAGE_NCS4"
		public static readonly abilityreallevelfield ABILITY_RLF_MAX_DAMAGE_NCS4 = ConvertAbilityRealLevelField(1315140404);
		/// @CSharpLua.Template = "ABILITY_RLF_BUILDING_DAMAGE_FACTOR_NCS5"
		public static readonly abilityreallevelfield ABILITY_RLF_BUILDING_DAMAGE_FACTOR_NCS5 = ConvertAbilityRealLevelField(1315140405);
		/// @CSharpLua.Template = "ABILITY_RLF_EFFECT_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_EFFECT_DURATION = ConvertAbilityRealLevelField(1315140406);
		/// @CSharpLua.Template = "ABILITY_RLF_SPAWN_INTERVAL_NSY1"
		public static readonly abilityreallevelfield ABILITY_RLF_SPAWN_INTERVAL_NSY1 = ConvertAbilityRealLevelField(1316190513);
		/// @CSharpLua.Template = "ABILITY_RLF_SPAWN_UNIT_DURATION"
		public static readonly abilityreallevelfield ABILITY_RLF_SPAWN_UNIT_DURATION = ConvertAbilityRealLevelField(1316190515);
		/// @CSharpLua.Template = "ABILITY_RLF_SPAWN_UNIT_OFFSET"
		public static readonly abilityreallevelfield ABILITY_RLF_SPAWN_UNIT_OFFSET = ConvertAbilityRealLevelField(1316190516);
		/// @CSharpLua.Template = "ABILITY_RLF_LEASH_RANGE_NSY5"
		public static readonly abilityreallevelfield ABILITY_RLF_LEASH_RANGE_NSY5 = ConvertAbilityRealLevelField(1316190517);
		/// @CSharpLua.Template = "ABILITY_RLF_SPAWN_INTERVAL_NFY1"
		public static readonly abilityreallevelfield ABILITY_RLF_SPAWN_INTERVAL_NFY1 = ConvertAbilityRealLevelField(1315338545);
		/// @CSharpLua.Template = "ABILITY_RLF_LEASH_RANGE_NFY2"
		public static readonly abilityreallevelfield ABILITY_RLF_LEASH_RANGE_NFY2 = ConvertAbilityRealLevelField(1315338546);
		/// @CSharpLua.Template = "ABILITY_RLF_CHANCE_TO_DEMOLISH"
		public static readonly abilityreallevelfield ABILITY_RLF_CHANCE_TO_DEMOLISH = ConvertAbilityRealLevelField(1315202353);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_MULTIPLIER_BUILDINGS"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_MULTIPLIER_BUILDINGS = ConvertAbilityRealLevelField(1315202354);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_MULTIPLIER_UNITS"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_MULTIPLIER_UNITS = ConvertAbilityRealLevelField(1315202355);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_MULTIPLIER_HEROES"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_MULTIPLIER_HEROES = ConvertAbilityRealLevelField(1315202356);
		/// @CSharpLua.Template = "ABILITY_RLF_BONUS_DAMAGE_MULTIPLIER"
		public static readonly abilityreallevelfield ABILITY_RLF_BONUS_DAMAGE_MULTIPLIER = ConvertAbilityRealLevelField(1315529521);
		/// @CSharpLua.Template = "ABILITY_RLF_DEATH_DAMAGE_FULL_AMOUNT"
		public static readonly abilityreallevelfield ABILITY_RLF_DEATH_DAMAGE_FULL_AMOUNT = ConvertAbilityRealLevelField(1315529522);
		/// @CSharpLua.Template = "ABILITY_RLF_DEATH_DAMAGE_FULL_AREA"
		public static readonly abilityreallevelfield ABILITY_RLF_DEATH_DAMAGE_FULL_AREA = ConvertAbilityRealLevelField(1315529523);
		/// @CSharpLua.Template = "ABILITY_RLF_DEATH_DAMAGE_HALF_AMOUNT"
		public static readonly abilityreallevelfield ABILITY_RLF_DEATH_DAMAGE_HALF_AMOUNT = ConvertAbilityRealLevelField(1315529524);
		/// @CSharpLua.Template = "ABILITY_RLF_DEATH_DAMAGE_HALF_AREA"
		public static readonly abilityreallevelfield ABILITY_RLF_DEATH_DAMAGE_HALF_AREA = ConvertAbilityRealLevelField(1315529525);
		/// @CSharpLua.Template = "ABILITY_RLF_DEATH_DAMAGE_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_DEATH_DAMAGE_DELAY = ConvertAbilityRealLevelField(1315529526);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_AMOUNT_NSO1"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_AMOUNT_NSO1 = ConvertAbilityRealLevelField(1316187953);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PERIOD"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PERIOD = ConvertAbilityRealLevelField(1316187954);
		/// @CSharpLua.Template = "ABILITY_RLF_DAMAGE_PENALTY"
		public static readonly abilityreallevelfield ABILITY_RLF_DAMAGE_PENALTY = ConvertAbilityRealLevelField(1316187955);
		/// @CSharpLua.Template = "ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_NSO4"
		public static readonly abilityreallevelfield ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_NSO4 = ConvertAbilityRealLevelField(1316187956);
		/// @CSharpLua.Template = "ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_NSO5"
		public static readonly abilityreallevelfield ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_NSO5 = ConvertAbilityRealLevelField(1316187957);
		/// @CSharpLua.Template = "ABILITY_RLF_SPLIT_DELAY"
		public static readonly abilityreallevelfield ABILITY_RLF_SPLIT_DELAY = ConvertAbilityRealLevelField(1315728690);
		/// @CSharpLua.Template = "ABILITY_RLF_MAX_HITPOINT_FACTOR"
		public static readonly abilityreallevelfield ABILITY_RLF_MAX_HITPOINT_FACTOR = ConvertAbilityRealLevelField(1315728692);
		/// @CSharpLua.Template = "ABILITY_RLF_LIFE_DURATION_SPLIT_BONUS"
		public static readonly abilityreallevelfield ABILITY_RLF_LIFE_DURATION_SPLIT_BONUS = ConvertAbilityRealLevelField(1315728693);
		/// @CSharpLua.Template = "ABILITY_RLF_WAVE_INTERVAL"
		public static readonly abilityreallevelfield ABILITY_RLF_WAVE_INTERVAL = ConvertAbilityRealLevelField(1316381491);
		/// @CSharpLua.Template = "ABILITY_RLF_BUILDING_DAMAGE_FACTOR_NVC4"
		public static readonly abilityreallevelfield ABILITY_RLF_BUILDING_DAMAGE_FACTOR_NVC4 = ConvertAbilityRealLevelField(1316381492);
		/// @CSharpLua.Template = "ABILITY_RLF_FULL_DAMAGE_AMOUNT_NVC5"
		public static readonly abilityreallevelfield ABILITY_RLF_FULL_DAMAGE_AMOUNT_NVC5 = ConvertAbilityRealLevelField(1316381493);
		/// @CSharpLua.Template = "ABILITY_RLF_HALF_DAMAGE_FACTOR"
		public static readonly abilityreallevelfield ABILITY_RLF_HALF_DAMAGE_FACTOR = ConvertAbilityRealLevelField(1316381494);
		/// @CSharpLua.Template = "ABILITY_RLF_INTERVAL_BETWEEN_PULSES"
		public static readonly abilityreallevelfield ABILITY_RLF_INTERVAL_BETWEEN_PULSES = ConvertAbilityRealLevelField(1415673141);
		/// @CSharpLua.Template = "ABILITY_BLF_PERCENT_BONUS_HAB2"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_PERCENT_BONUS_HAB2 = ConvertAbilityBooleanLevelField(1214341682);
		/// @CSharpLua.Template = "ABILITY_BLF_USE_TELEPORT_CLUSTERING_HMT3"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_USE_TELEPORT_CLUSTERING_HMT3 = ConvertAbilityBooleanLevelField(1215132723);
		/// @CSharpLua.Template = "ABILITY_BLF_NEVER_MISS_OCR5"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_NEVER_MISS_OCR5 = ConvertAbilityBooleanLevelField(1331917365);
		/// @CSharpLua.Template = "ABILITY_BLF_EXCLUDE_ITEM_DAMAGE"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_EXCLUDE_ITEM_DAMAGE = ConvertAbilityBooleanLevelField(1331917366);
		/// @CSharpLua.Template = "ABILITY_BLF_BACKSTAB_DAMAGE"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_BACKSTAB_DAMAGE = ConvertAbilityBooleanLevelField(1333226292);
		/// @CSharpLua.Template = "ABILITY_BLF_INHERIT_UPGRADES_UAN3"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_INHERIT_UPGRADES_UAN3 = ConvertAbilityBooleanLevelField(1432448563);
		/// @CSharpLua.Template = "ABILITY_BLF_MANA_CONVERSION_AS_PERCENT"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_MANA_CONVERSION_AS_PERCENT = ConvertAbilityBooleanLevelField(1432645683);
		/// @CSharpLua.Template = "ABILITY_BLF_LIFE_CONVERSION_AS_PERCENT"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_LIFE_CONVERSION_AS_PERCENT = ConvertAbilityBooleanLevelField(1432645684);
		/// @CSharpLua.Template = "ABILITY_BLF_LEAVE_TARGET_ALIVE"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_LEAVE_TARGET_ALIVE = ConvertAbilityBooleanLevelField(1432645685);
		/// @CSharpLua.Template = "ABILITY_BLF_PERCENT_BONUS_UAU3"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_PERCENT_BONUS_UAU3 = ConvertAbilityBooleanLevelField(1432450355);
		/// @CSharpLua.Template = "ABILITY_BLF_DAMAGE_IS_PERCENT_RECEIVED"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_DAMAGE_IS_PERCENT_RECEIVED = ConvertAbilityBooleanLevelField(1164011570);
		/// @CSharpLua.Template = "ABILITY_BLF_MELEE_BONUS"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_MELEE_BONUS = ConvertAbilityBooleanLevelField(1164014130);
		/// @CSharpLua.Template = "ABILITY_BLF_RANGED_BONUS"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_RANGED_BONUS = ConvertAbilityBooleanLevelField(1164014131);
		/// @CSharpLua.Template = "ABILITY_BLF_FLAT_BONUS"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_FLAT_BONUS = ConvertAbilityBooleanLevelField(1164014132);
		/// @CSharpLua.Template = "ABILITY_BLF_NEVER_MISS_HBH5"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_NEVER_MISS_HBH5 = ConvertAbilityBooleanLevelField(1214408757);
		/// @CSharpLua.Template = "ABILITY_BLF_PERCENT_BONUS_HAD2"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_PERCENT_BONUS_HAD2 = ConvertAbilityBooleanLevelField(1214342194);
		/// @CSharpLua.Template = "ABILITY_BLF_CAN_DEACTIVATE"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_CAN_DEACTIVATE = ConvertAbilityBooleanLevelField(1214542641);
		/// @CSharpLua.Template = "ABILITY_BLF_RAISED_UNITS_ARE_INVULNERABLE"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_RAISED_UNITS_ARE_INVULNERABLE = ConvertAbilityBooleanLevelField(1215456562);
		/// @CSharpLua.Template = "ABILITY_BLF_PERCENTAGE_OAR2"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_PERCENTAGE_OAR2 = ConvertAbilityBooleanLevelField(1331786290);
		/// @CSharpLua.Template = "ABILITY_BLF_SUMMON_BUSY_UNITS"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_SUMMON_BUSY_UNITS = ConvertAbilityBooleanLevelField(1114926130);
		/// @CSharpLua.Template = "ABILITY_BLF_CREATES_BLIGHT"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_CREATES_BLIGHT = ConvertAbilityBooleanLevelField(1114401074);
		/// @CSharpLua.Template = "ABILITY_BLF_EXPLODES_ON_DEATH"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_EXPLODES_ON_DEATH = ConvertAbilityBooleanLevelField(1399092022);
		/// @CSharpLua.Template = "ABILITY_BLF_ALWAYS_AUTOCAST_FAE2"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_ALWAYS_AUTOCAST_FAE2 = ConvertAbilityBooleanLevelField(1180788018);
		/// @CSharpLua.Template = "ABILITY_BLF_REGENERATE_ONLY_AT_NIGHT"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_REGENERATE_ONLY_AT_NIGHT = ConvertAbilityBooleanLevelField(1298297909);
		/// @CSharpLua.Template = "ABILITY_BLF_SHOW_SELECT_UNIT_BUTTON"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_SHOW_SELECT_UNIT_BUTTON = ConvertAbilityBooleanLevelField(1315271987);
		/// @CSharpLua.Template = "ABILITY_BLF_SHOW_UNIT_INDICATOR"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_SHOW_UNIT_INDICATOR = ConvertAbilityBooleanLevelField(1315271988);
		/// @CSharpLua.Template = "ABILITY_BLF_CHARGE_OWNING_PLAYER"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_CHARGE_OWNING_PLAYER = ConvertAbilityBooleanLevelField(1097757494);
		/// @CSharpLua.Template = "ABILITY_BLF_PERCENTAGE_ARM2"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_PERCENTAGE_ARM2 = ConvertAbilityBooleanLevelField(1098018098);
		/// @CSharpLua.Template = "ABILITY_BLF_TARGET_IS_INVULNERABLE"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_TARGET_IS_INVULNERABLE = ConvertAbilityBooleanLevelField(1349481267);
		/// @CSharpLua.Template = "ABILITY_BLF_TARGET_IS_MAGIC_IMMUNE"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_TARGET_IS_MAGIC_IMMUNE = ConvertAbilityBooleanLevelField(1349481268);
		/// @CSharpLua.Template = "ABILITY_BLF_KILL_ON_CASTER_DEATH"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_KILL_ON_CASTER_DEATH = ConvertAbilityBooleanLevelField(1432576566);
		/// @CSharpLua.Template = "ABILITY_BLF_NO_TARGET_REQUIRED_REJ4"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_NO_TARGET_REQUIRED_REJ4 = ConvertAbilityBooleanLevelField(1382378036);
		/// @CSharpLua.Template = "ABILITY_BLF_ACCEPTS_GOLD"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_ACCEPTS_GOLD = ConvertAbilityBooleanLevelField(1383362097);
		/// @CSharpLua.Template = "ABILITY_BLF_ACCEPTS_LUMBER"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_ACCEPTS_LUMBER = ConvertAbilityBooleanLevelField(1383362098);
		/// @CSharpLua.Template = "ABILITY_BLF_PREFER_HOSTILES_ROA5"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_PREFER_HOSTILES_ROA5 = ConvertAbilityBooleanLevelField(1383031093);
		/// @CSharpLua.Template = "ABILITY_BLF_PREFER_FRIENDLIES_ROA6"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_PREFER_FRIENDLIES_ROA6 = ConvertAbilityBooleanLevelField(1383031094);
		/// @CSharpLua.Template = "ABILITY_BLF_ROOTED_TURNING"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_ROOTED_TURNING = ConvertAbilityBooleanLevelField(1383034675);
		/// @CSharpLua.Template = "ABILITY_BLF_ALWAYS_AUTOCAST_SLO3"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_ALWAYS_AUTOCAST_SLO3 = ConvertAbilityBooleanLevelField(1399615283);
		/// @CSharpLua.Template = "ABILITY_BLF_HIDE_BUTTON"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_HIDE_BUTTON = ConvertAbilityBooleanLevelField(1231579492);
		/// @CSharpLua.Template = "ABILITY_BLF_USE_TELEPORT_CLUSTERING_ITP2"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_USE_TELEPORT_CLUSTERING_ITP2 = ConvertAbilityBooleanLevelField(1232367666);
		/// @CSharpLua.Template = "ABILITY_BLF_IMMUNE_TO_MORPH_EFFECTS"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_IMMUNE_TO_MORPH_EFFECTS = ConvertAbilityBooleanLevelField(1165256753);
		/// @CSharpLua.Template = "ABILITY_BLF_DOES_NOT_BLOCK_BUILDINGS"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_DOES_NOT_BLOCK_BUILDINGS = ConvertAbilityBooleanLevelField(1165256754);
		/// @CSharpLua.Template = "ABILITY_BLF_AUTO_ACQUIRE_ATTACK_TARGETS"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_AUTO_ACQUIRE_ATTACK_TARGETS = ConvertAbilityBooleanLevelField(1198026545);
		/// @CSharpLua.Template = "ABILITY_BLF_IMMUNE_TO_MORPH_EFFECTS_GHO2"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_IMMUNE_TO_MORPH_EFFECTS_GHO2 = ConvertAbilityBooleanLevelField(1198026546);
		/// @CSharpLua.Template = "ABILITY_BLF_DO_NOT_BLOCK_BUILDINGS"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_DO_NOT_BLOCK_BUILDINGS = ConvertAbilityBooleanLevelField(1198026547);
		/// @CSharpLua.Template = "ABILITY_BLF_INCLUDE_RANGED_DAMAGE"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_INCLUDE_RANGED_DAMAGE = ConvertAbilityBooleanLevelField(1400073012);
		/// @CSharpLua.Template = "ABILITY_BLF_INCLUDE_MELEE_DAMAGE"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_INCLUDE_MELEE_DAMAGE = ConvertAbilityBooleanLevelField(1400073013);
		/// @CSharpLua.Template = "ABILITY_BLF_MOVE_TO_PARTNER"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_MOVE_TO_PARTNER = ConvertAbilityBooleanLevelField(1668243762);
		/// @CSharpLua.Template = "ABILITY_BLF_CAN_BE_DISPELLED"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_CAN_BE_DISPELLED = ConvertAbilityBooleanLevelField(1668899633);
		/// @CSharpLua.Template = "ABILITY_BLF_IGNORE_FRIENDLY_BUFFS"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_IGNORE_FRIENDLY_BUFFS = ConvertAbilityBooleanLevelField(1685482806);
		/// @CSharpLua.Template = "ABILITY_BLF_DROP_ITEMS_ON_DEATH"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_DROP_ITEMS_ON_DEATH = ConvertAbilityBooleanLevelField(1768846898);
		/// @CSharpLua.Template = "ABILITY_BLF_CAN_USE_ITEMS"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_CAN_USE_ITEMS = ConvertAbilityBooleanLevelField(1768846899);
		/// @CSharpLua.Template = "ABILITY_BLF_CAN_GET_ITEMS"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_CAN_GET_ITEMS = ConvertAbilityBooleanLevelField(1768846900);
		/// @CSharpLua.Template = "ABILITY_BLF_CAN_DROP_ITEMS"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_CAN_DROP_ITEMS = ConvertAbilityBooleanLevelField(1768846901);
		/// @CSharpLua.Template = "ABILITY_BLF_REPAIRS_ALLOWED"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_REPAIRS_ALLOWED = ConvertAbilityBooleanLevelField(1818849588);
		/// @CSharpLua.Template = "ABILITY_BLF_CASTER_ONLY_SPLASH"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_CASTER_ONLY_SPLASH = ConvertAbilityBooleanLevelField(1835428918);
		/// @CSharpLua.Template = "ABILITY_BLF_NO_TARGET_REQUIRED_IRL4"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_NO_TARGET_REQUIRED_IRL4 = ConvertAbilityBooleanLevelField(1769106484);
		/// @CSharpLua.Template = "ABILITY_BLF_DISPEL_ON_ATTACK"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_DISPEL_ON_ATTACK = ConvertAbilityBooleanLevelField(1769106485);
		/// @CSharpLua.Template = "ABILITY_BLF_AMOUNT_IS_RAW_VALUE"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_AMOUNT_IS_RAW_VALUE = ConvertAbilityBooleanLevelField(1768977971);
		/// @CSharpLua.Template = "ABILITY_BLF_SHARED_SPELL_COOLDOWN"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_SHARED_SPELL_COOLDOWN = ConvertAbilityBooleanLevelField(1936745010);
		/// @CSharpLua.Template = "ABILITY_BLF_SLEEP_ONCE"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_SLEEP_ONCE = ConvertAbilityBooleanLevelField(1936482609);
		/// @CSharpLua.Template = "ABILITY_BLF_ALLOW_ON_ANY_PLAYER_SLOT"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_ALLOW_ON_ANY_PLAYER_SLOT = ConvertAbilityBooleanLevelField(1936482610);
		/// @CSharpLua.Template = "ABILITY_BLF_DISABLE_OTHER_ABILITIES"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_DISABLE_OTHER_ABILITIES = ConvertAbilityBooleanLevelField(1315138613);
		/// @CSharpLua.Template = "ABILITY_BLF_ALLOW_BOUNTY"
		public static readonly abilitybooleanlevelfield ABILITY_BLF_ALLOW_BOUNTY = ConvertAbilityBooleanLevelField(1316252980);
		/// @CSharpLua.Template = "ABILITY_SLF_ICON_NORMAL"
		public static readonly abilitystringlevelfield ABILITY_SLF_ICON_NORMAL = ConvertAbilityStringLevelField(1633776244);
		/// @CSharpLua.Template = "ABILITY_SLF_CASTER"
		public static readonly abilitystringlevelfield ABILITY_SLF_CASTER = ConvertAbilityStringLevelField(1633902964);
		/// @CSharpLua.Template = "ABILITY_SLF_TARGET"
		public static readonly abilitystringlevelfield ABILITY_SLF_TARGET = ConvertAbilityStringLevelField(1635017076);
		/// @CSharpLua.Template = "ABILITY_SLF_SPECIAL"
		public static readonly abilitystringlevelfield ABILITY_SLF_SPECIAL = ConvertAbilityStringLevelField(1634951540);
		/// @CSharpLua.Template = "ABILITY_SLF_EFFECT"
		public static readonly abilitystringlevelfield ABILITY_SLF_EFFECT = ConvertAbilityStringLevelField(1634034036);
		/// @CSharpLua.Template = "ABILITY_SLF_AREA_EFFECT"
		public static readonly abilitystringlevelfield ABILITY_SLF_AREA_EFFECT = ConvertAbilityStringLevelField(1633772897);
		/// @CSharpLua.Template = "ABILITY_SLF_LIGHTNING_EFFECTS"
		public static readonly abilitystringlevelfield ABILITY_SLF_LIGHTNING_EFFECTS = ConvertAbilityStringLevelField(1634494823);
		/// @CSharpLua.Template = "ABILITY_SLF_MISSILE_ART"
		public static readonly abilitystringlevelfield ABILITY_SLF_MISSILE_ART = ConvertAbilityStringLevelField(1634558324);
		/// @CSharpLua.Template = "ABILITY_SLF_TOOLTIP_LEARN"
		public static readonly abilitystringlevelfield ABILITY_SLF_TOOLTIP_LEARN = ConvertAbilityStringLevelField(1634887028);
		/// @CSharpLua.Template = "ABILITY_SLF_TOOLTIP_LEARN_EXTENDED"
		public static readonly abilitystringlevelfield ABILITY_SLF_TOOLTIP_LEARN_EXTENDED = ConvertAbilityStringLevelField(1634891124);
		/// @CSharpLua.Template = "ABILITY_SLF_TOOLTIP_NORMAL"
		public static readonly abilitystringlevelfield ABILITY_SLF_TOOLTIP_NORMAL = ConvertAbilityStringLevelField(1635020849);
		/// @CSharpLua.Template = "ABILITY_SLF_TOOLTIP_TURN_OFF"
		public static readonly abilitystringlevelfield ABILITY_SLF_TOOLTIP_TURN_OFF = ConvertAbilityStringLevelField(1635087409);
		/// @CSharpLua.Template = "ABILITY_SLF_TOOLTIP_NORMAL_EXTENDED"
		public static readonly abilitystringlevelfield ABILITY_SLF_TOOLTIP_NORMAL_EXTENDED = ConvertAbilityStringLevelField(1635082801);
		/// @CSharpLua.Template = "ABILITY_SLF_TOOLTIP_TURN_OFF_EXTENDED"
		public static readonly abilitystringlevelfield ABILITY_SLF_TOOLTIP_TURN_OFF_EXTENDED = ConvertAbilityStringLevelField(1635087665);
		/// @CSharpLua.Template = "ABILITY_SLF_NORMAL_FORM_UNIT_EME1"
		public static readonly abilitystringlevelfield ABILITY_SLF_NORMAL_FORM_UNIT_EME1 = ConvertAbilityStringLevelField(1164797233);
		/// @CSharpLua.Template = "ABILITY_SLF_SPAWNED_UNITS"
		public static readonly abilitystringlevelfield ABILITY_SLF_SPAWNED_UNITS = ConvertAbilityStringLevelField(1315205169);
		/// @CSharpLua.Template = "ABILITY_SLF_ABILITY_FOR_UNIT_CREATION"
		public static readonly abilitystringlevelfield ABILITY_SLF_ABILITY_FOR_UNIT_CREATION = ConvertAbilityStringLevelField(1316119345);
		/// @CSharpLua.Template = "ABILITY_SLF_NORMAL_FORM_UNIT_MIL1"
		public static readonly abilitystringlevelfield ABILITY_SLF_NORMAL_FORM_UNIT_MIL1 = ConvertAbilityStringLevelField(1298754609);
		/// @CSharpLua.Template = "ABILITY_SLF_ALTERNATE_FORM_UNIT_MIL2"
		public static readonly abilitystringlevelfield ABILITY_SLF_ALTERNATE_FORM_UNIT_MIL2 = ConvertAbilityStringLevelField(1298754610);
		/// @CSharpLua.Template = "ABILITY_SLF_BASE_ORDER_ID_ANS5"
		public static readonly abilitystringlevelfield ABILITY_SLF_BASE_ORDER_ID_ANS5 = ConvertAbilityStringLevelField(1097757493);
		/// @CSharpLua.Template = "ABILITY_SLF_MORPH_UNITS_GROUND"
		public static readonly abilitystringlevelfield ABILITY_SLF_MORPH_UNITS_GROUND = ConvertAbilityStringLevelField(1349286194);
		/// @CSharpLua.Template = "ABILITY_SLF_MORPH_UNITS_AIR"
		public static readonly abilitystringlevelfield ABILITY_SLF_MORPH_UNITS_AIR = ConvertAbilityStringLevelField(1349286195);
		/// @CSharpLua.Template = "ABILITY_SLF_MORPH_UNITS_AMPHIBIOUS"
		public static readonly abilitystringlevelfield ABILITY_SLF_MORPH_UNITS_AMPHIBIOUS = ConvertAbilityStringLevelField(1349286196);
		/// @CSharpLua.Template = "ABILITY_SLF_MORPH_UNITS_WATER"
		public static readonly abilitystringlevelfield ABILITY_SLF_MORPH_UNITS_WATER = ConvertAbilityStringLevelField(1349286197);
		/// @CSharpLua.Template = "ABILITY_SLF_UNIT_TYPE_ONE"
		public static readonly abilitystringlevelfield ABILITY_SLF_UNIT_TYPE_ONE = ConvertAbilityStringLevelField(1382115635);
		/// @CSharpLua.Template = "ABILITY_SLF_UNIT_TYPE_TWO"
		public static readonly abilitystringlevelfield ABILITY_SLF_UNIT_TYPE_TWO = ConvertAbilityStringLevelField(1382115636);
		/// @CSharpLua.Template = "ABILITY_SLF_UNIT_TYPE_SOD2"
		public static readonly abilitystringlevelfield ABILITY_SLF_UNIT_TYPE_SOD2 = ConvertAbilityStringLevelField(1399809074);
		/// @CSharpLua.Template = "ABILITY_SLF_SUMMON_1_UNIT_TYPE"
		public static readonly abilitystringlevelfield ABILITY_SLF_SUMMON_1_UNIT_TYPE = ConvertAbilityStringLevelField(1232303153);
		/// @CSharpLua.Template = "ABILITY_SLF_SUMMON_2_UNIT_TYPE"
		public static readonly abilitystringlevelfield ABILITY_SLF_SUMMON_2_UNIT_TYPE = ConvertAbilityStringLevelField(1232303154);
		/// @CSharpLua.Template = "ABILITY_SLF_RACE_TO_CONVERT"
		public static readonly abilitystringlevelfield ABILITY_SLF_RACE_TO_CONVERT = ConvertAbilityStringLevelField(1315201841);
		/// @CSharpLua.Template = "ABILITY_SLF_PARTNER_UNIT_TYPE"
		public static readonly abilitystringlevelfield ABILITY_SLF_PARTNER_UNIT_TYPE = ConvertAbilityStringLevelField(1668243761);
		/// @CSharpLua.Template = "ABILITY_SLF_PARTNER_UNIT_TYPE_ONE"
		public static readonly abilitystringlevelfield ABILITY_SLF_PARTNER_UNIT_TYPE_ONE = ConvertAbilityStringLevelField(1684238385);
		/// @CSharpLua.Template = "ABILITY_SLF_PARTNER_UNIT_TYPE_TWO"
		public static readonly abilitystringlevelfield ABILITY_SLF_PARTNER_UNIT_TYPE_TWO = ConvertAbilityStringLevelField(1684238386);
		/// @CSharpLua.Template = "ABILITY_SLF_REQUIRED_UNIT_TYPE"
		public static readonly abilitystringlevelfield ABILITY_SLF_REQUIRED_UNIT_TYPE = ConvertAbilityStringLevelField(1953524017);
		/// @CSharpLua.Template = "ABILITY_SLF_CONVERTED_UNIT_TYPE"
		public static readonly abilitystringlevelfield ABILITY_SLF_CONVERTED_UNIT_TYPE = ConvertAbilityStringLevelField(1953524018);
		/// @CSharpLua.Template = "ABILITY_SLF_SPELL_LIST"
		public static readonly abilitystringlevelfield ABILITY_SLF_SPELL_LIST = ConvertAbilityStringLevelField(1936745009);
		/// @CSharpLua.Template = "ABILITY_SLF_BASE_ORDER_ID_SPB5"
		public static readonly abilitystringlevelfield ABILITY_SLF_BASE_ORDER_ID_SPB5 = ConvertAbilityStringLevelField(1936745013);
		/// @CSharpLua.Template = "ABILITY_SLF_BASE_ORDER_ID_NCL6"
		public static readonly abilitystringlevelfield ABILITY_SLF_BASE_ORDER_ID_NCL6 = ConvertAbilityStringLevelField(1315138614);
		/// @CSharpLua.Template = "ABILITY_SLF_ABILITY_UPGRADE_1"
		public static readonly abilitystringlevelfield ABILITY_SLF_ABILITY_UPGRADE_1 = ConvertAbilityStringLevelField(1315268403);
		/// @CSharpLua.Template = "ABILITY_SLF_ABILITY_UPGRADE_2"
		public static readonly abilitystringlevelfield ABILITY_SLF_ABILITY_UPGRADE_2 = ConvertAbilityStringLevelField(1315268404);
		/// @CSharpLua.Template = "ABILITY_SLF_ABILITY_UPGRADE_3"
		public static readonly abilitystringlevelfield ABILITY_SLF_ABILITY_UPGRADE_3 = ConvertAbilityStringLevelField(1315268405);
		/// @CSharpLua.Template = "ABILITY_SLF_ABILITY_UPGRADE_4"
		public static readonly abilitystringlevelfield ABILITY_SLF_ABILITY_UPGRADE_4 = ConvertAbilityStringLevelField(1315268406);
		/// @CSharpLua.Template = "ABILITY_SLF_SPAWN_UNIT_ID_NSY2"
		public static readonly abilitystringlevelfield ABILITY_SLF_SPAWN_UNIT_ID_NSY2 = ConvertAbilityStringLevelField(1316190514);
		/// @CSharpLua.Template = "ITEM_IF_LEVEL"
		public static readonly itemintegerfield ITEM_IF_LEVEL = ConvertItemIntegerField(1768711542);
		/// @CSharpLua.Template = "ITEM_IF_NUMBER_OF_CHARGES"
		public static readonly itemintegerfield ITEM_IF_NUMBER_OF_CHARGES = ConvertItemIntegerField(1769304933);
		/// @CSharpLua.Template = "ITEM_IF_COOLDOWN_GROUP"
		public static readonly itemintegerfield ITEM_IF_COOLDOWN_GROUP = ConvertItemIntegerField(1768122724);
		/// @CSharpLua.Template = "ITEM_IF_MAX_HIT_POINTS"
		public static readonly itemintegerfield ITEM_IF_MAX_HIT_POINTS = ConvertItemIntegerField(1768453232);
		/// @CSharpLua.Template = "ITEM_IF_HIT_POINTS"
		public static readonly itemintegerfield ITEM_IF_HIT_POINTS = ConvertItemIntegerField(1768452195);
		/// @CSharpLua.Template = "ITEM_IF_PRIORITY"
		public static readonly itemintegerfield ITEM_IF_PRIORITY = ConvertItemIntegerField(1768977001);
		/// @CSharpLua.Template = "ITEM_IF_ARMOR_TYPE"
		public static readonly itemintegerfield ITEM_IF_ARMOR_TYPE = ConvertItemIntegerField(1767993965);
		/// @CSharpLua.Template = "ITEM_IF_TINTING_COLOR_RED"
		public static readonly itemintegerfield ITEM_IF_TINTING_COLOR_RED = ConvertItemIntegerField(1768123506);
		/// @CSharpLua.Template = "ITEM_IF_TINTING_COLOR_GREEN"
		public static readonly itemintegerfield ITEM_IF_TINTING_COLOR_GREEN = ConvertItemIntegerField(1768123495);
		/// @CSharpLua.Template = "ITEM_IF_TINTING_COLOR_BLUE"
		public static readonly itemintegerfield ITEM_IF_TINTING_COLOR_BLUE = ConvertItemIntegerField(1768123490);
		/// @CSharpLua.Template = "ITEM_IF_TINTING_COLOR_ALPHA"
		public static readonly itemintegerfield ITEM_IF_TINTING_COLOR_ALPHA = ConvertItemIntegerField(1768120684);
		/// @CSharpLua.Template = "ITEM_RF_SCALING_VALUE"
		public static readonly itemrealfield ITEM_RF_SCALING_VALUE = ConvertItemRealField(1769169761);
		/// @CSharpLua.Template = "ITEM_BF_DROPPED_WHEN_CARRIER_DIES"
		public static readonly itembooleanfield ITEM_BF_DROPPED_WHEN_CARRIER_DIES = ConvertItemBooleanField(1768190576);
		/// @CSharpLua.Template = "ITEM_BF_CAN_BE_DROPPED"
		public static readonly itembooleanfield ITEM_BF_CAN_BE_DROPPED = ConvertItemBooleanField(1768190575);
		/// @CSharpLua.Template = "ITEM_BF_PERISHABLE"
		public static readonly itembooleanfield ITEM_BF_PERISHABLE = ConvertItemBooleanField(1768973682);
		/// @CSharpLua.Template = "ITEM_BF_INCLUDE_AS_RANDOM_CHOICE"
		public static readonly itembooleanfield ITEM_BF_INCLUDE_AS_RANDOM_CHOICE = ConvertItemBooleanField(1768977006);
		/// @CSharpLua.Template = "ITEM_BF_USE_AUTOMATICALLY_WHEN_ACQUIRED"
		public static readonly itembooleanfield ITEM_BF_USE_AUTOMATICALLY_WHEN_ACQUIRED = ConvertItemBooleanField(1768976247);
		/// @CSharpLua.Template = "ITEM_BF_CAN_BE_SOLD_TO_MERCHANTS"
		public static readonly itembooleanfield ITEM_BF_CAN_BE_SOLD_TO_MERCHANTS = ConvertItemBooleanField(1768972663);
		/// @CSharpLua.Template = "ITEM_BF_ACTIVELY_USED"
		public static readonly itembooleanfield ITEM_BF_ACTIVELY_USED = ConvertItemBooleanField(1769304929);
		/// @CSharpLua.Template = "ITEM_SF_MODEL_USED"
		public static readonly itemstringfield ITEM_SF_MODEL_USED = ConvertItemStringField(1768319340);
		/// @CSharpLua.Template = "UNIT_IF_DEFENSE_TYPE"
		public static readonly unitintegerfield UNIT_IF_DEFENSE_TYPE = ConvertUnitIntegerField(1969517689);
		/// @CSharpLua.Template = "UNIT_IF_ARMOR_TYPE"
		public static readonly unitintegerfield UNIT_IF_ARMOR_TYPE = ConvertUnitIntegerField(1969320557);
		/// @CSharpLua.Template = "UNIT_IF_LOOPING_FADE_IN_RATE"
		public static readonly unitintegerfield UNIT_IF_LOOPING_FADE_IN_RATE = ConvertUnitIntegerField(1970038377);
		/// @CSharpLua.Template = "UNIT_IF_LOOPING_FADE_OUT_RATE"
		public static readonly unitintegerfield UNIT_IF_LOOPING_FADE_OUT_RATE = ConvertUnitIntegerField(1970038383);
		/// @CSharpLua.Template = "UNIT_IF_AGILITY"
		public static readonly unitintegerfield UNIT_IF_AGILITY = ConvertUnitIntegerField(1969317731);
		/// @CSharpLua.Template = "UNIT_IF_INTELLIGENCE"
		public static readonly unitintegerfield UNIT_IF_INTELLIGENCE = ConvertUnitIntegerField(1969843811);
		/// @CSharpLua.Template = "UNIT_IF_STRENGTH"
		public static readonly unitintegerfield UNIT_IF_STRENGTH = ConvertUnitIntegerField(1970500707);
		/// @CSharpLua.Template = "UNIT_IF_AGILITY_PERMANENT"
		public static readonly unitintegerfield UNIT_IF_AGILITY_PERMANENT = ConvertUnitIntegerField(1969317741);
		/// @CSharpLua.Template = "UNIT_IF_INTELLIGENCE_PERMANENT"
		public static readonly unitintegerfield UNIT_IF_INTELLIGENCE_PERMANENT = ConvertUnitIntegerField(1969843821);
		/// @CSharpLua.Template = "UNIT_IF_STRENGTH_PERMANENT"
		public static readonly unitintegerfield UNIT_IF_STRENGTH_PERMANENT = ConvertUnitIntegerField(1970500717);
		/// @CSharpLua.Template = "UNIT_IF_AGILITY_WITH_BONUS"
		public static readonly unitintegerfield UNIT_IF_AGILITY_WITH_BONUS = ConvertUnitIntegerField(1969317730);
		/// @CSharpLua.Template = "UNIT_IF_INTELLIGENCE_WITH_BONUS"
		public static readonly unitintegerfield UNIT_IF_INTELLIGENCE_WITH_BONUS = ConvertUnitIntegerField(1969843810);
		/// @CSharpLua.Template = "UNIT_IF_STRENGTH_WITH_BONUS"
		public static readonly unitintegerfield UNIT_IF_STRENGTH_WITH_BONUS = ConvertUnitIntegerField(1970500706);
		/// @CSharpLua.Template = "UNIT_IF_GOLD_BOUNTY_AWARDED_NUMBER_OF_DICE"
		public static readonly unitintegerfield UNIT_IF_GOLD_BOUNTY_AWARDED_NUMBER_OF_DICE = ConvertUnitIntegerField(1969382505);
		/// @CSharpLua.Template = "UNIT_IF_GOLD_BOUNTY_AWARDED_BASE"
		public static readonly unitintegerfield UNIT_IF_GOLD_BOUNTY_AWARDED_BASE = ConvertUnitIntegerField(1969381985);
		/// @CSharpLua.Template = "UNIT_IF_GOLD_BOUNTY_AWARDED_SIDES_PER_DIE"
		public static readonly unitintegerfield UNIT_IF_GOLD_BOUNTY_AWARDED_SIDES_PER_DIE = ConvertUnitIntegerField(1969386345);
		/// @CSharpLua.Template = "UNIT_IF_LUMBER_BOUNTY_AWARDED_NUMBER_OF_DICE"
		public static readonly unitintegerfield UNIT_IF_LUMBER_BOUNTY_AWARDED_NUMBER_OF_DICE = ConvertUnitIntegerField(1970037348);
		/// @CSharpLua.Template = "UNIT_IF_LUMBER_BOUNTY_AWARDED_BASE"
		public static readonly unitintegerfield UNIT_IF_LUMBER_BOUNTY_AWARDED_BASE = ConvertUnitIntegerField(1970037345);
		/// @CSharpLua.Template = "UNIT_IF_LUMBER_BOUNTY_AWARDED_SIDES_PER_DIE"
		public static readonly unitintegerfield UNIT_IF_LUMBER_BOUNTY_AWARDED_SIDES_PER_DIE = ConvertUnitIntegerField(1970037363);
		/// @CSharpLua.Template = "UNIT_IF_LEVEL"
		public static readonly unitintegerfield UNIT_IF_LEVEL = ConvertUnitIntegerField(1970038134);
		/// @CSharpLua.Template = "UNIT_IF_FORMATION_RANK"
		public static readonly unitintegerfield UNIT_IF_FORMATION_RANK = ConvertUnitIntegerField(1969647474);
		/// @CSharpLua.Template = "UNIT_IF_ORIENTATION_INTERPOLATION"
		public static readonly unitintegerfield UNIT_IF_ORIENTATION_INTERPOLATION = ConvertUnitIntegerField(1970238057);
		/// @CSharpLua.Template = "UNIT_IF_ELEVATION_SAMPLE_POINTS"
		public static readonly unitintegerfield UNIT_IF_ELEVATION_SAMPLE_POINTS = ConvertUnitIntegerField(1969582196);
		/// @CSharpLua.Template = "UNIT_IF_TINTING_COLOR_RED"
		public static readonly unitintegerfield UNIT_IF_TINTING_COLOR_RED = ConvertUnitIntegerField(1969450098);
		/// @CSharpLua.Template = "UNIT_IF_TINTING_COLOR_GREEN"
		public static readonly unitintegerfield UNIT_IF_TINTING_COLOR_GREEN = ConvertUnitIntegerField(1969450087);
		/// @CSharpLua.Template = "UNIT_IF_TINTING_COLOR_BLUE"
		public static readonly unitintegerfield UNIT_IF_TINTING_COLOR_BLUE = ConvertUnitIntegerField(1969450082);
		/// @CSharpLua.Template = "UNIT_IF_TINTING_COLOR_ALPHA"
		public static readonly unitintegerfield UNIT_IF_TINTING_COLOR_ALPHA = ConvertUnitIntegerField(1969447276);
		/// @CSharpLua.Template = "UNIT_IF_MOVE_TYPE"
		public static readonly unitintegerfield UNIT_IF_MOVE_TYPE = ConvertUnitIntegerField(1970108020);
		/// @CSharpLua.Template = "UNIT_IF_TARGETED_AS"
		public static readonly unitintegerfield UNIT_IF_TARGETED_AS = ConvertUnitIntegerField(1970561394);
		/// @CSharpLua.Template = "UNIT_IF_UNIT_CLASSIFICATION"
		public static readonly unitintegerfield UNIT_IF_UNIT_CLASSIFICATION = ConvertUnitIntegerField(1970567536);
		/// @CSharpLua.Template = "UNIT_IF_HIT_POINTS_REGENERATION_TYPE"
		public static readonly unitintegerfield UNIT_IF_HIT_POINTS_REGENERATION_TYPE = ConvertUnitIntegerField(1969779316);
		/// @CSharpLua.Template = "UNIT_IF_PLACEMENT_PREVENTED_BY"
		public static readonly unitintegerfield UNIT_IF_PLACEMENT_PREVENTED_BY = ConvertUnitIntegerField(1970299250);
		/// @CSharpLua.Template = "UNIT_IF_PRIMARY_ATTRIBUTE"
		public static readonly unitintegerfield UNIT_IF_PRIMARY_ATTRIBUTE = ConvertUnitIntegerField(1970303585);
		/// @CSharpLua.Template = "UNIT_RF_STRENGTH_PER_LEVEL"
		public static readonly unitrealfield UNIT_RF_STRENGTH_PER_LEVEL = ConvertUnitRealField(1970500720);
		/// @CSharpLua.Template = "UNIT_RF_AGILITY_PER_LEVEL"
		public static readonly unitrealfield UNIT_RF_AGILITY_PER_LEVEL = ConvertUnitRealField(1969317744);
		/// @CSharpLua.Template = "UNIT_RF_INTELLIGENCE_PER_LEVEL"
		public static readonly unitrealfield UNIT_RF_INTELLIGENCE_PER_LEVEL = ConvertUnitRealField(1969843824);
		/// @CSharpLua.Template = "UNIT_RF_HIT_POINTS_REGENERATION_RATE"
		public static readonly unitrealfield UNIT_RF_HIT_POINTS_REGENERATION_RATE = ConvertUnitRealField(1969778802);
		/// @CSharpLua.Template = "UNIT_RF_MANA_REGENERATION"
		public static readonly unitrealfield UNIT_RF_MANA_REGENERATION = ConvertUnitRealField(1970106482);
		/// @CSharpLua.Template = "UNIT_RF_DEATH_TIME"
		public static readonly unitrealfield UNIT_RF_DEATH_TIME = ConvertUnitRealField(1969517677);
		/// @CSharpLua.Template = "UNIT_RF_FLY_HEIGHT"
		public static readonly unitrealfield UNIT_RF_FLY_HEIGHT = ConvertUnitRealField(1969650024);
		/// @CSharpLua.Template = "UNIT_RF_FLY_MAX_HEIGHT"
		public static readonly unitrealfield UNIT_RF_FLY_MAX_HEIGHT = ConvertUnitRealField(1969646952);
		/// @CSharpLua.Template = "UNIT_RF_TURN_RATE"
		public static readonly unitrealfield UNIT_RF_TURN_RATE = ConvertUnitRealField(1970108018);
		/// @CSharpLua.Template = "UNIT_RF_ELEVATION_SAMPLE_RADIUS"
		public static readonly unitrealfield UNIT_RF_ELEVATION_SAMPLE_RADIUS = ConvertUnitRealField(1969582692);
		/// @CSharpLua.Template = "UNIT_RF_FOG_OF_WAR_SAMPLE_RADIUS"
		public static readonly unitrealfield UNIT_RF_FOG_OF_WAR_SAMPLE_RADIUS = ConvertUnitRealField(1969648228);
		/// @CSharpLua.Template = "UNIT_RF_MAXIMUM_PITCH_ANGLE_DEGREES"
		public static readonly unitrealfield UNIT_RF_MAXIMUM_PITCH_ANGLE_DEGREES = ConvertUnitRealField(1970108528);
		/// @CSharpLua.Template = "UNIT_RF_MAXIMUM_ROLL_ANGLE_DEGREES"
		public static readonly unitrealfield UNIT_RF_MAXIMUM_ROLL_ANGLE_DEGREES = ConvertUnitRealField(1970108530);
		/// @CSharpLua.Template = "UNIT_RF_SCALING_VALUE"
		public static readonly unitrealfield UNIT_RF_SCALING_VALUE = ConvertUnitRealField(1970496353);
		/// @CSharpLua.Template = "UNIT_RF_ANIMATION_RUN_SPEED"
		public static readonly unitrealfield UNIT_RF_ANIMATION_RUN_SPEED = ConvertUnitRealField(1970435438);
		/// @CSharpLua.Template = "UNIT_RF_SELECTION_SCALE"
		public static readonly unitrealfield UNIT_RF_SELECTION_SCALE = ConvertUnitRealField(1970500451);
		/// @CSharpLua.Template = "UNIT_RF_SELECTION_CIRCLE_HEIGHT"
		public static readonly unitrealfield UNIT_RF_SELECTION_CIRCLE_HEIGHT = ConvertUnitRealField(1970498682);
		/// @CSharpLua.Template = "UNIT_RF_SHADOW_IMAGE_HEIGHT"
		public static readonly unitrealfield UNIT_RF_SHADOW_IMAGE_HEIGHT = ConvertUnitRealField(1970497640);
		/// @CSharpLua.Template = "UNIT_RF_SHADOW_IMAGE_WIDTH"
		public static readonly unitrealfield UNIT_RF_SHADOW_IMAGE_WIDTH = ConvertUnitRealField(1970497655);
		/// @CSharpLua.Template = "UNIT_RF_SHADOW_IMAGE_CENTER_X"
		public static readonly unitrealfield UNIT_RF_SHADOW_IMAGE_CENTER_X = ConvertUnitRealField(1970497656);
		/// @CSharpLua.Template = "UNIT_RF_SHADOW_IMAGE_CENTER_Y"
		public static readonly unitrealfield UNIT_RF_SHADOW_IMAGE_CENTER_Y = ConvertUnitRealField(1970497657);
		/// @CSharpLua.Template = "UNIT_RF_ANIMATION_WALK_SPEED"
		public static readonly unitrealfield UNIT_RF_ANIMATION_WALK_SPEED = ConvertUnitRealField(1970757996);
		/// @CSharpLua.Template = "UNIT_RF_DEFENSE"
		public static readonly unitrealfield UNIT_RF_DEFENSE = ConvertUnitRealField(1969514083);
		/// @CSharpLua.Template = "UNIT_RF_SIGHT_RADIUS"
		public static readonly unitrealfield UNIT_RF_SIGHT_RADIUS = ConvertUnitRealField(1970497906);
		/// @CSharpLua.Template = "UNIT_RF_PRIORITY"
		public static readonly unitrealfield UNIT_RF_PRIORITY = ConvertUnitRealField(1970303593);
		/// @CSharpLua.Template = "UNIT_RF_SPEED"
		public static readonly unitrealfield UNIT_RF_SPEED = ConvertUnitRealField(1970108003);
		/// @CSharpLua.Template = "UNIT_RF_OCCLUDER_HEIGHT"
		public static readonly unitrealfield UNIT_RF_OCCLUDER_HEIGHT = ConvertUnitRealField(1970234211);
		/// @CSharpLua.Template = "UNIT_RF_HP"
		public static readonly unitrealfield UNIT_RF_HP = ConvertUnitRealField(1969778787);
		/// @CSharpLua.Template = "UNIT_RF_MANA"
		public static readonly unitrealfield UNIT_RF_MANA = ConvertUnitRealField(1970106467);
		/// @CSharpLua.Template = "UNIT_RF_ACQUISITION_RANGE"
		public static readonly unitrealfield UNIT_RF_ACQUISITION_RANGE = ConvertUnitRealField(1969316721);
		/// @CSharpLua.Template = "UNIT_RF_CAST_BACK_SWING"
		public static readonly unitrealfield UNIT_RF_CAST_BACK_SWING = ConvertUnitRealField(1969447539);
		/// @CSharpLua.Template = "UNIT_RF_CAST_POINT"
		public static readonly unitrealfield UNIT_RF_CAST_POINT = ConvertUnitRealField(1969451124);
		/// @CSharpLua.Template = "UNIT_RF_MINIMUM_ATTACK_RANGE"
		public static readonly unitrealfield UNIT_RF_MINIMUM_ATTACK_RANGE = ConvertUnitRealField(1969319278);
		/// @CSharpLua.Template = "UNIT_BF_RAISABLE"
		public static readonly unitbooleanfield UNIT_BF_RAISABLE = ConvertUnitBooleanField(1970430313);
		/// @CSharpLua.Template = "UNIT_BF_DECAYABLE"
		public static readonly unitbooleanfield UNIT_BF_DECAYABLE = ConvertUnitBooleanField(1969513827);
		/// @CSharpLua.Template = "UNIT_BF_IS_A_BUILDING"
		public static readonly unitbooleanfield UNIT_BF_IS_A_BUILDING = ConvertUnitBooleanField(1969382503);
		/// @CSharpLua.Template = "UNIT_BF_USE_EXTENDED_LINE_OF_SIGHT"
		public static readonly unitbooleanfield UNIT_BF_USE_EXTENDED_LINE_OF_SIGHT = ConvertUnitBooleanField(1970040691);
		/// @CSharpLua.Template = "UNIT_BF_NEUTRAL_BUILDING_SHOWS_MINIMAP_ICON"
		public static readonly unitbooleanfield UNIT_BF_NEUTRAL_BUILDING_SHOWS_MINIMAP_ICON = ConvertUnitBooleanField(1970168429);
		/// @CSharpLua.Template = "UNIT_BF_HERO_HIDE_HERO_INTERFACE_ICON"
		public static readonly unitbooleanfield UNIT_BF_HERO_HIDE_HERO_INTERFACE_ICON = ConvertUnitBooleanField(1969776738);
		/// @CSharpLua.Template = "UNIT_BF_HERO_HIDE_HERO_MINIMAP_DISPLAY"
		public static readonly unitbooleanfield UNIT_BF_HERO_HIDE_HERO_MINIMAP_DISPLAY = ConvertUnitBooleanField(1969776749);
		/// @CSharpLua.Template = "UNIT_BF_HERO_HIDE_HERO_DEATH_MESSAGE"
		public static readonly unitbooleanfield UNIT_BF_HERO_HIDE_HERO_DEATH_MESSAGE = ConvertUnitBooleanField(1969776740);
		/// @CSharpLua.Template = "UNIT_BF_HIDE_MINIMAP_DISPLAY"
		public static readonly unitbooleanfield UNIT_BF_HIDE_MINIMAP_DISPLAY = ConvertUnitBooleanField(1969778541);
		/// @CSharpLua.Template = "UNIT_BF_SCALE_PROJECTILES"
		public static readonly unitbooleanfield UNIT_BF_SCALE_PROJECTILES = ConvertUnitBooleanField(1970496354);
		/// @CSharpLua.Template = "UNIT_BF_SELECTION_CIRCLE_ON_WATER"
		public static readonly unitbooleanfield UNIT_BF_SELECTION_CIRCLE_ON_WATER = ConvertUnitBooleanField(1970496887);
		/// @CSharpLua.Template = "UNIT_BF_HAS_WATER_SHADOW"
		public static readonly unitbooleanfield UNIT_BF_HAS_WATER_SHADOW = ConvertUnitBooleanField(1970497650);
		/// @CSharpLua.Template = "UNIT_SF_NAME"
		public static readonly unitstringfield UNIT_SF_NAME = ConvertUnitStringField(1970168173);
		/// @CSharpLua.Template = "UNIT_SF_PROPER_NAMES"
		public static readonly unitstringfield UNIT_SF_PROPER_NAMES = ConvertUnitStringField(1970303599);
		/// @CSharpLua.Template = "UNIT_SF_GROUND_TEXTURE"
		public static readonly unitstringfield UNIT_SF_GROUND_TEXTURE = ConvertUnitStringField(1970627187);
		/// @CSharpLua.Template = "UNIT_SF_SHADOW_IMAGE_UNIT"
		public static readonly unitstringfield UNIT_SF_SHADOW_IMAGE_UNIT = ConvertUnitStringField(1970497653);
		/// @CSharpLua.Template = "UNIT_WEAPON_IF_ATTACK_DAMAGE_NUMBER_OF_DICE"
		public static readonly unitweaponintegerfield UNIT_WEAPON_IF_ATTACK_DAMAGE_NUMBER_OF_DICE = ConvertUnitWeaponIntegerField(1969303908);
		/// @CSharpLua.Template = "UNIT_WEAPON_IF_ATTACK_DAMAGE_BASE"
		public static readonly unitweaponintegerfield UNIT_WEAPON_IF_ATTACK_DAMAGE_BASE = ConvertUnitWeaponIntegerField(1969303906);
		/// @CSharpLua.Template = "UNIT_WEAPON_IF_ATTACK_DAMAGE_SIDES_PER_DIE"
		public static readonly unitweaponintegerfield UNIT_WEAPON_IF_ATTACK_DAMAGE_SIDES_PER_DIE = ConvertUnitWeaponIntegerField(1969303923);
		/// @CSharpLua.Template = "UNIT_WEAPON_IF_ATTACK_MAXIMUM_NUMBER_OF_TARGETS"
		public static readonly unitweaponintegerfield UNIT_WEAPON_IF_ATTACK_MAXIMUM_NUMBER_OF_TARGETS = ConvertUnitWeaponIntegerField(1970561841);
		/// @CSharpLua.Template = "UNIT_WEAPON_IF_ATTACK_ATTACK_TYPE"
		public static readonly unitweaponintegerfield UNIT_WEAPON_IF_ATTACK_ATTACK_TYPE = ConvertUnitWeaponIntegerField(1969303924);
		/// @CSharpLua.Template = "UNIT_WEAPON_IF_ATTACK_WEAPON_SOUND"
		public static readonly unitweaponintegerfield UNIT_WEAPON_IF_ATTACK_WEAPON_SOUND = ConvertUnitWeaponIntegerField(1969451825);
		/// @CSharpLua.Template = "UNIT_WEAPON_IF_ATTACK_AREA_OF_EFFECT_TARGETS"
		public static readonly unitweaponintegerfield UNIT_WEAPON_IF_ATTACK_AREA_OF_EFFECT_TARGETS = ConvertUnitWeaponIntegerField(1969303920);
		/// @CSharpLua.Template = "UNIT_WEAPON_IF_ATTACK_TARGETS_ALLOWED"
		public static readonly unitweaponintegerfield UNIT_WEAPON_IF_ATTACK_TARGETS_ALLOWED = ConvertUnitWeaponIntegerField(1969303911);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_BACKSWING_POINT"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_BACKSWING_POINT = ConvertUnitWeaponRealField(1969386289);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_DAMAGE_POINT"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_DAMAGE_POINT = ConvertUnitWeaponRealField(1969516593);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_BASE_COOLDOWN"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_BASE_COOLDOWN = ConvertUnitWeaponRealField(1969303907);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_DAMAGE_LOSS_FACTOR"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_DAMAGE_LOSS_FACTOR = ConvertUnitWeaponRealField(1969515569);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_MEDIUM"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_MEDIUM = ConvertUnitWeaponRealField(1969775665);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_SMALL"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_SMALL = ConvertUnitWeaponRealField(1970365489);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_DISTANCE"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_DISTANCE = ConvertUnitWeaponRealField(1970496561);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_RADIUS"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_RADIUS = ConvertUnitWeaponRealField(1970500145);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_PROJECTILE_SPEED"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_PROJECTILE_SPEED = ConvertUnitWeaponRealField(1969303930);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_PROJECTILE_ARC"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_PROJECTILE_ARC = ConvertUnitWeaponRealField(1970102577);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_FULL_DAMAGE"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_FULL_DAMAGE = ConvertUnitWeaponRealField(1969303910);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_MEDIUM_DAMAGE"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_MEDIUM_DAMAGE = ConvertUnitWeaponRealField(1969303912);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_SMALL_DAMAGE"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_SMALL_DAMAGE = ConvertUnitWeaponRealField(1969303921);
		/// @CSharpLua.Template = "UNIT_WEAPON_RF_ATTACK_RANGE"
		public static readonly unitweaponrealfield UNIT_WEAPON_RF_ATTACK_RANGE = ConvertUnitWeaponRealField(1969303922);
		/// @CSharpLua.Template = "UNIT_WEAPON_BF_ATTACK_SHOW_UI"
		public static readonly unitweaponbooleanfield UNIT_WEAPON_BF_ATTACK_SHOW_UI = ConvertUnitWeaponBooleanField(1970763057);
		/// @CSharpLua.Template = "UNIT_WEAPON_BF_ATTACKS_ENABLED"
		public static readonly unitweaponbooleanfield UNIT_WEAPON_BF_ATTACKS_ENABLED = ConvertUnitWeaponBooleanField(1969317230);
		/// @CSharpLua.Template = "UNIT_WEAPON_BF_ATTACK_PROJECTILE_HOMING_ENABLED"
		public static readonly unitweaponbooleanfield UNIT_WEAPON_BF_ATTACK_PROJECTILE_HOMING_ENABLED = ConvertUnitWeaponBooleanField(1970104369);
		/// @CSharpLua.Template = "UNIT_WEAPON_SF_ATTACK_PROJECTILE_ART"
		public static readonly unitweaponstringfield UNIT_WEAPON_SF_ATTACK_PROJECTILE_ART = ConvertUnitWeaponStringField(1969303917);
		/// @CSharpLua.Template = "MOVE_TYPE_UNKNOWN"
		public static readonly movetype MOVE_TYPE_UNKNOWN = ConvertMoveType(0);
		/// @CSharpLua.Template = "MOVE_TYPE_FOOT"
		public static readonly movetype MOVE_TYPE_FOOT = ConvertMoveType(1);
		/// @CSharpLua.Template = "MOVE_TYPE_FLY"
		public static readonly movetype MOVE_TYPE_FLY = ConvertMoveType(2);
		/// @CSharpLua.Template = "MOVE_TYPE_HORSE"
		public static readonly movetype MOVE_TYPE_HORSE = ConvertMoveType(4);
		/// @CSharpLua.Template = "MOVE_TYPE_HOVER"
		public static readonly movetype MOVE_TYPE_HOVER = ConvertMoveType(8);
		/// @CSharpLua.Template = "MOVE_TYPE_FLOAT"
		public static readonly movetype MOVE_TYPE_FLOAT = ConvertMoveType(16);
		/// @CSharpLua.Template = "MOVE_TYPE_AMPHIBIOUS"
		public static readonly movetype MOVE_TYPE_AMPHIBIOUS = ConvertMoveType(32);
		/// @CSharpLua.Template = "MOVE_TYPE_UNBUILDABLE"
		public static readonly movetype MOVE_TYPE_UNBUILDABLE = ConvertMoveType(64);
		/// @CSharpLua.Template = "TARGET_FLAG_NONE"
		public static readonly targetflag TARGET_FLAG_NONE = ConvertTargetFlag(1);
		/// @CSharpLua.Template = "TARGET_FLAG_GROUND"
		public static readonly targetflag TARGET_FLAG_GROUND = ConvertTargetFlag(2);
		/// @CSharpLua.Template = "TARGET_FLAG_AIR"
		public static readonly targetflag TARGET_FLAG_AIR = ConvertTargetFlag(4);
		/// @CSharpLua.Template = "TARGET_FLAG_STRUCTURE"
		public static readonly targetflag TARGET_FLAG_STRUCTURE = ConvertTargetFlag(8);
		/// @CSharpLua.Template = "TARGET_FLAG_WARD"
		public static readonly targetflag TARGET_FLAG_WARD = ConvertTargetFlag(16);
		/// @CSharpLua.Template = "TARGET_FLAG_ITEM"
		public static readonly targetflag TARGET_FLAG_ITEM = ConvertTargetFlag(32);
		/// @CSharpLua.Template = "TARGET_FLAG_TREE"
		public static readonly targetflag TARGET_FLAG_TREE = ConvertTargetFlag(64);
		/// @CSharpLua.Template = "TARGET_FLAG_WALL"
		public static readonly targetflag TARGET_FLAG_WALL = ConvertTargetFlag(128);
		/// @CSharpLua.Template = "TARGET_FLAG_DEBRIS"
		public static readonly targetflag TARGET_FLAG_DEBRIS = ConvertTargetFlag(256);
		/// @CSharpLua.Template = "TARGET_FLAG_DECORATION"
		public static readonly targetflag TARGET_FLAG_DECORATION = ConvertTargetFlag(512);
		/// @CSharpLua.Template = "TARGET_FLAG_BRIDGE"
		public static readonly targetflag TARGET_FLAG_BRIDGE = ConvertTargetFlag(1024);
		/// @CSharpLua.Template = "DEFENSE_TYPE_LIGHT"
		public static readonly defensetype DEFENSE_TYPE_LIGHT = ConvertDefenseType(0);
		/// @CSharpLua.Template = "DEFENSE_TYPE_MEDIUM"
		public static readonly defensetype DEFENSE_TYPE_MEDIUM = ConvertDefenseType(1);
		/// @CSharpLua.Template = "DEFENSE_TYPE_LARGE"
		public static readonly defensetype DEFENSE_TYPE_LARGE = ConvertDefenseType(2);
		/// @CSharpLua.Template = "DEFENSE_TYPE_FORT"
		public static readonly defensetype DEFENSE_TYPE_FORT = ConvertDefenseType(3);
		/// @CSharpLua.Template = "DEFENSE_TYPE_NORMAL"
		public static readonly defensetype DEFENSE_TYPE_NORMAL = ConvertDefenseType(4);
		/// @CSharpLua.Template = "DEFENSE_TYPE_HERO"
		public static readonly defensetype DEFENSE_TYPE_HERO = ConvertDefenseType(5);
		/// @CSharpLua.Template = "DEFENSE_TYPE_DIVINE"
		public static readonly defensetype DEFENSE_TYPE_DIVINE = ConvertDefenseType(6);
		/// @CSharpLua.Template = "DEFENSE_TYPE_NONE"
		public static readonly defensetype DEFENSE_TYPE_NONE = ConvertDefenseType(7);
		/// @CSharpLua.Template = "HERO_ATTRIBUTE_STR"
		public static readonly heroattribute HERO_ATTRIBUTE_STR = ConvertHeroAttribute(1);
		/// @CSharpLua.Template = "HERO_ATTRIBUTE_INT"
		public static readonly heroattribute HERO_ATTRIBUTE_INT = ConvertHeroAttribute(2);
		/// @CSharpLua.Template = "HERO_ATTRIBUTE_AGI"
		public static readonly heroattribute HERO_ATTRIBUTE_AGI = ConvertHeroAttribute(3);
		/// @CSharpLua.Template = "ARMOR_TYPE_WHOKNOWS"
		public static readonly armortype ARMOR_TYPE_WHOKNOWS = ConvertArmorType(0);
		/// @CSharpLua.Template = "ARMOR_TYPE_FLESH"
		public static readonly armortype ARMOR_TYPE_FLESH = ConvertArmorType(1);
		/// @CSharpLua.Template = "ARMOR_TYPE_METAL"
		public static readonly armortype ARMOR_TYPE_METAL = ConvertArmorType(2);
		/// @CSharpLua.Template = "ARMOR_TYPE_WOOD"
		public static readonly armortype ARMOR_TYPE_WOOD = ConvertArmorType(3);
		/// @CSharpLua.Template = "ARMOR_TYPE_ETHREAL"
		public static readonly armortype ARMOR_TYPE_ETHREAL = ConvertArmorType(4);
		/// @CSharpLua.Template = "ARMOR_TYPE_STONE"
		public static readonly armortype ARMOR_TYPE_STONE = ConvertArmorType(5);
		/// @CSharpLua.Template = "REGENERATION_TYPE_NONE"
		public static readonly regentype REGENERATION_TYPE_NONE = ConvertRegenType(0);
		/// @CSharpLua.Template = "REGENERATION_TYPE_ALWAYS"
		public static readonly regentype REGENERATION_TYPE_ALWAYS = ConvertRegenType(1);
		/// @CSharpLua.Template = "REGENERATION_TYPE_BLIGHT"
		public static readonly regentype REGENERATION_TYPE_BLIGHT = ConvertRegenType(2);
		/// @CSharpLua.Template = "REGENERATION_TYPE_DAY"
		public static readonly regentype REGENERATION_TYPE_DAY = ConvertRegenType(3);
		/// @CSharpLua.Template = "REGENERATION_TYPE_NIGHT"
		public static readonly regentype REGENERATION_TYPE_NIGHT = ConvertRegenType(4);
		/// @CSharpLua.Template = "UNIT_CATEGORY_GIANT"
		public static readonly unitcategory UNIT_CATEGORY_GIANT = ConvertUnitCategory(1);
		/// @CSharpLua.Template = "UNIT_CATEGORY_UNDEAD"
		public static readonly unitcategory UNIT_CATEGORY_UNDEAD = ConvertUnitCategory(2);
		/// @CSharpLua.Template = "UNIT_CATEGORY_SUMMONED"
		public static readonly unitcategory UNIT_CATEGORY_SUMMONED = ConvertUnitCategory(4);
		/// @CSharpLua.Template = "UNIT_CATEGORY_MECHANICAL"
		public static readonly unitcategory UNIT_CATEGORY_MECHANICAL = ConvertUnitCategory(8);
		/// @CSharpLua.Template = "UNIT_CATEGORY_PEON"
		public static readonly unitcategory UNIT_CATEGORY_PEON = ConvertUnitCategory(16);
		/// @CSharpLua.Template = "UNIT_CATEGORY_SAPPER"
		public static readonly unitcategory UNIT_CATEGORY_SAPPER = ConvertUnitCategory(32);
		/// @CSharpLua.Template = "UNIT_CATEGORY_TOWNHALL"
		public static readonly unitcategory UNIT_CATEGORY_TOWNHALL = ConvertUnitCategory(64);
		/// @CSharpLua.Template = "UNIT_CATEGORY_ANCIENT"
		public static readonly unitcategory UNIT_CATEGORY_ANCIENT = ConvertUnitCategory(128);
		/// @CSharpLua.Template = "UNIT_CATEGORY_NEUTRAL"
		public static readonly unitcategory UNIT_CATEGORY_NEUTRAL = ConvertUnitCategory(256);
		/// @CSharpLua.Template = "UNIT_CATEGORY_WARD"
		public static readonly unitcategory UNIT_CATEGORY_WARD = ConvertUnitCategory(512);
		/// @CSharpLua.Template = "UNIT_CATEGORY_STANDON"
		public static readonly unitcategory UNIT_CATEGORY_STANDON = ConvertUnitCategory(1024);
		/// @CSharpLua.Template = "UNIT_CATEGORY_TAUREN"
		public static readonly unitcategory UNIT_CATEGORY_TAUREN = ConvertUnitCategory(2048);
		/// @CSharpLua.Template = "PATHING_FLAG_UNWALKABLE"
		public static readonly pathingflag PATHING_FLAG_UNWALKABLE = ConvertPathingFlag(2);
		/// @CSharpLua.Template = "PATHING_FLAG_UNFLYABLE"
		public static readonly pathingflag PATHING_FLAG_UNFLYABLE = ConvertPathingFlag(4);
		/// @CSharpLua.Template = "PATHING_FLAG_UNBUILDABLE"
		public static readonly pathingflag PATHING_FLAG_UNBUILDABLE = ConvertPathingFlag(8);
		/// @CSharpLua.Template = "PATHING_FLAG_UNPEONHARVEST"
		public static readonly pathingflag PATHING_FLAG_UNPEONHARVEST = ConvertPathingFlag(16);
		/// @CSharpLua.Template = "PATHING_FLAG_BLIGHTED"
		public static readonly pathingflag PATHING_FLAG_BLIGHTED = ConvertPathingFlag(32);
		/// @CSharpLua.Template = "PATHING_FLAG_UNFLOATABLE"
		public static readonly pathingflag PATHING_FLAG_UNFLOATABLE = ConvertPathingFlag(64);
		/// @CSharpLua.Template = "PATHING_FLAG_UNAMPHIBIOUS"
		public static readonly pathingflag PATHING_FLAG_UNAMPHIBIOUS = ConvertPathingFlag(128);
		/// @CSharpLua.Template = "PATHING_FLAG_UNITEMPLACABLE"
		public static readonly pathingflag PATHING_FLAG_UNITEMPLACABLE = ConvertPathingFlag(256);
		/// @CSharpLua.Template = "Deg2Rad({0})"
		public static extern float Deg2Rad(float degrees);
		/// @CSharpLua.Template = "Rad2Deg({0})"
		public static extern float Rad2Deg(float radians);
		/// @CSharpLua.Template = "Sin({0})"
		public static extern float Sin(float radians);
		/// @CSharpLua.Template = "Cos({0})"
		public static extern float Cos(float radians);
		/// @CSharpLua.Template = "Tan({0})"
		public static extern float Tan(float radians);
		/// @CSharpLua.Template = "Asin({0})"
		public static extern float Asin(float y);
		/// @CSharpLua.Template = "Acos({0})"
		public static extern float Acos(float x);
		/// @CSharpLua.Template = "Atan({0})"
		public static extern float Atan(float x);
		/// @CSharpLua.Template = "Atan2({0}, {1})"
		public static extern float Atan2(float y, float x);
		/// @CSharpLua.Template = "SquareRoot({0})"
		public static extern float SquareRoot(float x);
		/// @CSharpLua.Template = "Pow({0}, {1})"
		public static extern float Pow(float x, float power);
		/// @CSharpLua.Template = "MathRound({0})"
		public static extern int MathRound(float r);
		/// @CSharpLua.Template = "I2R({0})"
		public static extern float I2R(int i);
		/// @CSharpLua.Template = "R2I({0})"
		public static extern int R2I(float r);
		/// @CSharpLua.Template = "I2S({0})"
		public static extern string I2S(int i);
		/// @CSharpLua.Template = "R2S({0})"
		public static extern string R2S(float r);
		/// @CSharpLua.Template = "R2SW({0}, {1}, {2})"
		public static extern string R2SW(float r, int width, int precision);
		/// @CSharpLua.Template = "S2I({0})"
		public static extern int S2I(string s);
		/// @CSharpLua.Template = "S2R({0})"
		public static extern float S2R(string s);
		/// @CSharpLua.Template = "GetHandleId({0})"
		[Obsolete("HandleId does not serve a purpose in lua/C#. It is prone to desyncs. Use the object itself as a key instead.")]
		public static extern int GetHandleId(handle h);
		/// @CSharpLua.Template = "SubString({0}, {1}, {2})"
		public static extern string SubString(string source, int start, int end);
		/// @CSharpLua.Template = "StringLength({0})"
		public static extern int StringLength(string s);
		/// @CSharpLua.Template = "StringCase({0}, {1})"
		public static extern string StringCase(string source, bool upper);
		/// @CSharpLua.Template = "StringHash({0})"
		public static extern int StringHash(string s);
		/// @CSharpLua.Template = "GetLocalizedString({0})"
		public static extern string GetLocalizedString(string source);
		/// @CSharpLua.Template = "GetLocalizedHotkey({0})"
		public static extern int GetLocalizedHotkey(string source);
		/// @CSharpLua.Template = "SetMapName({0})"
		public static extern void SetMapName(string name);
		/// @CSharpLua.Template = "SetMapDescription({0})"
		public static extern void SetMapDescription(string description);
		/// @CSharpLua.Template = "SetTeams({0})"
		public static extern void SetTeams(int teamcount);
		/// @CSharpLua.Template = "SetPlayers({0})"
		public static extern void SetPlayers(int playercount);
		/// @CSharpLua.Template = "DefineStartLocation({0}, {1}, {2})"
		public static extern void DefineStartLocation(int whichStartLoc, float x, float y);
		/// @CSharpLua.Template = "DefineStartLocationLoc({0}, {1})"
		public static extern void DefineStartLocationLoc(int whichStartLoc, location whichLocation);
		/// @CSharpLua.Template = "SetStartLocPrioCount({0}, {1})"
		public static extern void SetStartLocPrioCount(int whichStartLoc, int prioSlotCount);
		/// @CSharpLua.Template = "SetStartLocPrio({0}, {1}, {2}, {3})"
		public static extern void SetStartLocPrio(int whichStartLoc, int prioSlotIndex, int otherStartLocIndex, startlocprio priority);
		/// @CSharpLua.Template = "GetStartLocPrioSlot({0}, {1})"
		public static extern int GetStartLocPrioSlot(int whichStartLoc, int prioSlotIndex);
		/// @CSharpLua.Template = "GetStartLocPrio({0}, {1})"
		public static extern startlocprio GetStartLocPrio(int whichStartLoc, int prioSlotIndex);
		/// @CSharpLua.Template = "SetEnemyStartLocPrioCount({0}, {1})"
		public static extern void SetEnemyStartLocPrioCount(int whichStartLoc, int prioSlotCount);
		/// @CSharpLua.Template = "SetEnemyStartLocPrio({0}, {1}, {2}, {3})"
		public static extern void SetEnemyStartLocPrio(int whichStartLoc, int prioSlotIndex, int otherStartLocIndex, startlocprio priority);
		/// @CSharpLua.Template = "SetGameTypeSupported({0}, {1})"
		public static extern void SetGameTypeSupported(gametype whichGameType, bool value);
		/// @CSharpLua.Template = "SetMapFlag({0}, {1})"
		public static extern void SetMapFlag(mapflag whichMapFlag, bool value);
		/// @CSharpLua.Template = "SetGamePlacement({0})"
		public static extern void SetGamePlacement(placement whichPlacementType);
		/// @CSharpLua.Template = "SetGameSpeed({0})"
		public static extern void SetGameSpeed(gamespeed whichspeed);
		/// @CSharpLua.Template = "SetGameDifficulty({0})"
		public static extern void SetGameDifficulty(gamedifficulty whichdifficulty);
		/// @CSharpLua.Template = "SetResourceDensity({0})"
		public static extern void SetResourceDensity(mapdensity whichdensity);
		/// @CSharpLua.Template = "SetCreatureDensity({0})"
		public static extern void SetCreatureDensity(mapdensity whichdensity);
		/// @CSharpLua.Template = "GetTeams()"
		public static extern int GetTeams();
		/// @CSharpLua.Template = "GetPlayers()"
		public static extern int GetPlayers();
		/// @CSharpLua.Template = "IsGameTypeSupported({0})"
		public static extern bool IsGameTypeSupported(gametype whichGameType);
		/// @CSharpLua.Template = "GetGameTypeSelected()"
		public static extern gametype GetGameTypeSelected();
		/// @CSharpLua.Template = "IsMapFlagSet({0})"
		public static extern bool IsMapFlagSet(mapflag whichMapFlag);
		/// @CSharpLua.Template = "GetGamePlacement()"
		public static extern placement GetGamePlacement();
		/// @CSharpLua.Template = "GetGameSpeed()"
		public static extern gamespeed GetGameSpeed();
		/// @CSharpLua.Template = "GetGameDifficulty()"
		public static extern gamedifficulty GetGameDifficulty();
		/// @CSharpLua.Template = "GetResourceDensity()"
		public static extern mapdensity GetResourceDensity();
		/// @CSharpLua.Template = "GetCreatureDensity()"
		public static extern mapdensity GetCreatureDensity();
		/// @CSharpLua.Template = "GetStartLocationX({0})"
		public static extern float GetStartLocationX(int whichStartLocation);
		/// @CSharpLua.Template = "GetStartLocationY({0})"
		public static extern float GetStartLocationY(int whichStartLocation);
		/// @CSharpLua.Template = "GetStartLocationLoc({0})"
		public static extern location GetStartLocationLoc(int whichStartLocation);
		/// @CSharpLua.Template = "SetPlayerTeam({0}, {1})"
		public static extern void SetPlayerTeam(player whichPlayer, int whichTeam);
		/// @CSharpLua.Template = "SetPlayerStartLocation({0}, {1})"
		public static extern void SetPlayerStartLocation(player whichPlayer, int startLocIndex);
		/// @CSharpLua.Template = "ForcePlayerStartLocation({0}, {1})"
		public static extern void ForcePlayerStartLocation(player whichPlayer, int startLocIndex);
		/// @CSharpLua.Template = "SetPlayerColor({0}, {1})"
		public static extern void SetPlayerColor(player whichPlayer, playercolor color);
		/// @CSharpLua.Template = "SetPlayerAlliance({0}, {1}, {2}, {3})"
		public static extern void SetPlayerAlliance(player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting, bool value);
		/// @CSharpLua.Template = "SetPlayerTaxRate({0}, {1}, {2}, {3})"
		public static extern void SetPlayerTaxRate(player sourcePlayer, player otherPlayer, playerstate whichResource, int rate);
		/// @CSharpLua.Template = "SetPlayerRacePreference({0}, {1})"
		public static extern void SetPlayerRacePreference(player whichPlayer, racepreference whichRacePreference);
		/// @CSharpLua.Template = "SetPlayerRaceSelectable({0}, {1})"
		public static extern void SetPlayerRaceSelectable(player whichPlayer, bool value);
		/// @CSharpLua.Template = "SetPlayerController({0}, {1})"
		public static extern void SetPlayerController(player whichPlayer, mapcontrol controlType);
		/// @CSharpLua.Template = "SetPlayerName({0}, {1})"
		public static extern void SetPlayerName(player whichPlayer, string name);
		/// @CSharpLua.Template = "SetPlayerOnScoreScreen({0}, {1})"
		public static extern void SetPlayerOnScoreScreen(player whichPlayer, bool flag);
		/// @CSharpLua.Template = "GetPlayerTeam({0})"
		public static extern int GetPlayerTeam(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerStartLocation({0})"
		public static extern int GetPlayerStartLocation(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerColor({0})"
		public static extern playercolor GetPlayerColor(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerSelectable({0})"
		public static extern bool GetPlayerSelectable(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerController({0})"
		public static extern mapcontrol GetPlayerController(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerSlotState({0})"
		public static extern playerslotstate GetPlayerSlotState(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerTaxRate({0}, {1}, {2})"
		public static extern int GetPlayerTaxRate(player sourcePlayer, player otherPlayer, playerstate whichResource);
		/// @CSharpLua.Template = "IsPlayerRacePrefSet({0}, {1})"
		public static extern bool IsPlayerRacePrefSet(player whichPlayer, racepreference pref);
		/// @CSharpLua.Template = "GetPlayerName({0})"
		public static extern string GetPlayerName(player whichPlayer);
		/// @CSharpLua.Template = "CreateTimer()"
		public static extern timer CreateTimer();
		/// @CSharpLua.Template = "DestroyTimer({0})"
		public static extern void DestroyTimer(timer whichTimer);
		/// @CSharpLua.Template = "TimerStart({0}, {1}, {2}, {3})"
		public static extern void TimerStart(timer whichTimer, float timeout, bool periodic, Action handlerFunc);
		/// @CSharpLua.Template = "TimerGetElapsed({0})"
		public static extern float TimerGetElapsed(timer whichTimer);
		/// @CSharpLua.Template = "TimerGetRemaining({0})"
		public static extern float TimerGetRemaining(timer whichTimer);
		/// @CSharpLua.Template = "TimerGetTimeout({0})"
		public static extern float TimerGetTimeout(timer whichTimer);
		/// @CSharpLua.Template = "PauseTimer({0})"
		public static extern void PauseTimer(timer whichTimer);
		/// @CSharpLua.Template = "ResumeTimer({0})"
		public static extern void ResumeTimer(timer whichTimer);
		/// @CSharpLua.Template = "GetExpiredTimer()"
		public static extern timer GetExpiredTimer();
		/// @CSharpLua.Template = "CreateGroup()"
		public static extern group CreateGroup();
		/// @CSharpLua.Template = "DestroyGroup({0})"
		public static extern void DestroyGroup(group whichGroup);
		/// @CSharpLua.Template = "GroupAddUnit({0}, {1})"
		public static extern bool GroupAddUnit(group whichGroup, unit whichUnit);
		/// @CSharpLua.Template = "GroupRemoveUnit({0}, {1})"
		public static extern bool GroupRemoveUnit(group whichGroup, unit whichUnit);
		/// @CSharpLua.Template = "BlzGroupAddGroupFast({0}, {1})"
		public static extern int BlzGroupAddGroupFast(group whichGroup, group addGroup);
		/// @CSharpLua.Template = "BlzGroupRemoveGroupFast({0}, {1})"
		public static extern int BlzGroupRemoveGroupFast(group whichGroup, group removeGroup);
		/// @CSharpLua.Template = "GroupClear({0})"
		public static extern void GroupClear(group whichGroup);
		/// @CSharpLua.Template = "BlzGroupGetSize({0})"
		public static extern int BlzGroupGetSize(group whichGroup);
		/// @CSharpLua.Template = "BlzGroupUnitAt({0}, {1})"
		public static extern unit BlzGroupUnitAt(group whichGroup, int index);
		/// @CSharpLua.Template = "GroupEnumUnitsOfType({0}, {1}, {2})"
		public static extern void GroupEnumUnitsOfType(group whichGroup, string unitname, boolexpr filter);
		/// @CSharpLua.Template = "GroupEnumUnitsOfPlayer({0}, {1}, {2})"
		public static extern void GroupEnumUnitsOfPlayer(group whichGroup, player whichPlayer, boolexpr filter);
		/// @CSharpLua.Template = "GroupEnumUnitsOfTypeCounted({0}, {1}, {2}, {3})"
		public static extern void GroupEnumUnitsOfTypeCounted(group whichGroup, string unitname, boolexpr filter, int countLimit);
		/// @CSharpLua.Template = "GroupEnumUnitsInRect({0}, {1}, {2})"
		public static extern void GroupEnumUnitsInRect(group whichGroup, rect r, boolexpr filter);
		/// @CSharpLua.Template = "GroupEnumUnitsInRectCounted({0}, {1}, {2}, {3})"
		public static extern void GroupEnumUnitsInRectCounted(group whichGroup, rect r, boolexpr filter, int countLimit);
		/// @CSharpLua.Template = "GroupEnumUnitsInRange({0}, {1}, {2}, {3}, {4})"
		public static extern void GroupEnumUnitsInRange(group whichGroup, float x, float y, float radius, boolexpr filter);
		/// @CSharpLua.Template = "GroupEnumUnitsInRangeOfLoc({0}, {1}, {2}, {3})"
		public static extern void GroupEnumUnitsInRangeOfLoc(group whichGroup, location whichLocation, float radius, boolexpr filter);
		/// @CSharpLua.Template = "GroupEnumUnitsInRangeCounted({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern void GroupEnumUnitsInRangeCounted(group whichGroup, float x, float y, float radius, boolexpr filter, int countLimit);
		/// @CSharpLua.Template = "GroupEnumUnitsInRangeOfLocCounted({0}, {1}, {2}, {3}, {4})"
		public static extern void GroupEnumUnitsInRangeOfLocCounted(group whichGroup, location whichLocation, float radius, boolexpr filter, int countLimit);
		/// @CSharpLua.Template = "GroupEnumUnitsSelected({0}, {1}, {2})"
		public static extern void GroupEnumUnitsSelected(group whichGroup, player whichPlayer, boolexpr filter);
		/// @CSharpLua.Template = "GroupImmediateOrder({0}, {1})"
		public static extern bool GroupImmediateOrder(group whichGroup, string order);
		/// @CSharpLua.Template = "GroupImmediateOrderById({0}, {1})"
		public static extern bool GroupImmediateOrderById(group whichGroup, int order);
		/// @CSharpLua.Template = "GroupPointOrder({0}, {1}, {2}, {3})"
		public static extern bool GroupPointOrder(group whichGroup, string order, float x, float y);
		/// @CSharpLua.Template = "GroupPointOrderLoc({0}, {1}, {2})"
		public static extern bool GroupPointOrderLoc(group whichGroup, string order, location whichLocation);
		/// @CSharpLua.Template = "GroupPointOrderById({0}, {1}, {2}, {3})"
		public static extern bool GroupPointOrderById(group whichGroup, int order, float x, float y);
		/// @CSharpLua.Template = "GroupPointOrderByIdLoc({0}, {1}, {2})"
		public static extern bool GroupPointOrderByIdLoc(group whichGroup, int order, location whichLocation);
		/// @CSharpLua.Template = "GroupTargetOrder({0}, {1}, {2})"
		public static extern bool GroupTargetOrder(group whichGroup, string order, widget targetWidget);
		/// @CSharpLua.Template = "GroupTargetOrderById({0}, {1}, {2})"
		public static extern bool GroupTargetOrderById(group whichGroup, int order, widget targetWidget);
		/// @CSharpLua.Template = "ForGroup({0}, {1})"
		public static extern void ForGroup(group whichGroup, Action callback);
		/// @CSharpLua.Template = "FirstOfGroup({0})"
		public static extern unit FirstOfGroup(group whichGroup);
		/// @CSharpLua.Template = "CreateForce()"
		public static extern force CreateForce();
		/// @CSharpLua.Template = "DestroyForce({0})"
		public static extern void DestroyForce(force whichForce);
		/// @CSharpLua.Template = "ForceAddPlayer({0}, {1})"
		public static extern void ForceAddPlayer(force whichForce, player whichPlayer);
		/// @CSharpLua.Template = "ForceRemovePlayer({0}, {1})"
		public static extern void ForceRemovePlayer(force whichForce, player whichPlayer);
		/// @CSharpLua.Template = "BlzForceHasPlayer({0}, {1})"
		public static extern bool BlzForceHasPlayer(force whichForce, player whichPlayer);
		/// @CSharpLua.Template = "ForceClear({0})"
		public static extern void ForceClear(force whichForce);
		/// @CSharpLua.Template = "ForceEnumPlayers({0}, {1})"
		public static extern void ForceEnumPlayers(force whichForce, boolexpr filter);
		/// @CSharpLua.Template = "ForceEnumPlayersCounted({0}, {1}, {2})"
		public static extern void ForceEnumPlayersCounted(force whichForce, boolexpr filter, int countLimit);
		/// @CSharpLua.Template = "ForceEnumAllies({0}, {1}, {2})"
		public static extern void ForceEnumAllies(force whichForce, player whichPlayer, boolexpr filter);
		/// @CSharpLua.Template = "ForceEnumEnemies({0}, {1}, {2})"
		public static extern void ForceEnumEnemies(force whichForce, player whichPlayer, boolexpr filter);
		/// @CSharpLua.Template = "ForForce({0}, {1})"
		public static extern void ForForce(force whichForce, Action callback);
		/// @CSharpLua.Template = "Rect({0}, {1}, {2}, {3})"
		public static extern rect Rect(float minx, float miny, float maxx, float maxy);
		/// @CSharpLua.Template = "RectFromLoc({0}, {1})"
		public static extern rect RectFromLoc(location min, location max);
		/// @CSharpLua.Template = "RemoveRect({0})"
		public static extern void RemoveRect(rect whichRect);
		/// @CSharpLua.Template = "SetRect({0}, {1}, {2}, {3}, {4})"
		public static extern void SetRect(rect whichRect, float minx, float miny, float maxx, float maxy);
		/// @CSharpLua.Template = "SetRectFromLoc({0}, {1}, {2})"
		public static extern void SetRectFromLoc(rect whichRect, location min, location max);
		/// @CSharpLua.Template = "MoveRectTo({0}, {1}, {2})"
		public static extern void MoveRectTo(rect whichRect, float newCenterX, float newCenterY);
		/// @CSharpLua.Template = "MoveRectToLoc({0}, {1})"
		public static extern void MoveRectToLoc(rect whichRect, location newCenterLoc);
		/// @CSharpLua.Template = "GetRectCenterX({0})"
		public static extern float GetRectCenterX(rect whichRect);
		/// @CSharpLua.Template = "GetRectCenterY({0})"
		public static extern float GetRectCenterY(rect whichRect);
		/// @CSharpLua.Template = "GetRectMinX({0})"
		public static extern float GetRectMinX(rect whichRect);
		/// @CSharpLua.Template = "GetRectMinY({0})"
		public static extern float GetRectMinY(rect whichRect);
		/// @CSharpLua.Template = "GetRectMaxX({0})"
		public static extern float GetRectMaxX(rect whichRect);
		/// @CSharpLua.Template = "GetRectMaxY({0})"
		public static extern float GetRectMaxY(rect whichRect);
		/// @CSharpLua.Template = "CreateRegion()"
		public static extern region CreateRegion();
		/// @CSharpLua.Template = "RemoveRegion({0})"
		public static extern void RemoveRegion(region whichRegion);
		/// @CSharpLua.Template = "RegionAddRect({0}, {1})"
		public static extern void RegionAddRect(region whichRegion, rect r);
		/// @CSharpLua.Template = "RegionClearRect({0}, {1})"
		public static extern void RegionClearRect(region whichRegion, rect r);
		/// @CSharpLua.Template = "RegionAddCell({0}, {1}, {2})"
		public static extern void RegionAddCell(region whichRegion, float x, float y);
		/// @CSharpLua.Template = "RegionAddCellAtLoc({0}, {1})"
		public static extern void RegionAddCellAtLoc(region whichRegion, location whichLocation);
		/// @CSharpLua.Template = "RegionClearCell({0}, {1}, {2})"
		public static extern void RegionClearCell(region whichRegion, float x, float y);
		/// @CSharpLua.Template = "RegionClearCellAtLoc({0}, {1})"
		public static extern void RegionClearCellAtLoc(region whichRegion, location whichLocation);
		/// @CSharpLua.Template = "Location({0}, {1})"
		public static extern location Location(float x, float y);
		/// @CSharpLua.Template = "RemoveLocation({0})"
		public static extern void RemoveLocation(location whichLocation);
		/// @CSharpLua.Template = "MoveLocation({0}, {1}, {2})"
		public static extern void MoveLocation(location whichLocation, float newX, float newY);
		/// @CSharpLua.Template = "GetLocationX({0})"
		public static extern float GetLocationX(location whichLocation);
		/// @CSharpLua.Template = "GetLocationY({0})"
		public static extern float GetLocationY(location whichLocation);
		/// @CSharpLua.Template = "GetLocationZ({0})"
		public static extern float GetLocationZ(location whichLocation);
		/// @CSharpLua.Template = "IsUnitInRegion({0}, {1})"
		public static extern bool IsUnitInRegion(region whichRegion, unit whichUnit);
		/// @CSharpLua.Template = "IsPointInRegion({0}, {1}, {2})"
		public static extern bool IsPointInRegion(region whichRegion, float x, float y);
		/// @CSharpLua.Template = "IsLocationInRegion({0}, {1})"
		public static extern bool IsLocationInRegion(region whichRegion, location whichLocation);
		/// @CSharpLua.Template = "GetWorldBounds()"
		public static extern rect GetWorldBounds();
		/// @CSharpLua.Template = "CreateTrigger()"
		public static extern trigger CreateTrigger();
		/// @CSharpLua.Template = "DestroyTrigger({0})"
		public static extern void DestroyTrigger(trigger whichTrigger);
		/// @CSharpLua.Template = "ResetTrigger({0})"
		public static extern void ResetTrigger(trigger whichTrigger);
		/// @CSharpLua.Template = "EnableTrigger({0})"
		public static extern void EnableTrigger(trigger whichTrigger);
		/// @CSharpLua.Template = "DisableTrigger({0})"
		public static extern void DisableTrigger(trigger whichTrigger);
		/// @CSharpLua.Template = "IsTriggerEnabled({0})"
		public static extern bool IsTriggerEnabled(trigger whichTrigger);
		/// @CSharpLua.Template = "TriggerWaitOnSleeps({0}, {1})"
		public static extern void TriggerWaitOnSleeps(trigger whichTrigger, bool flag);
		/// @CSharpLua.Template = "IsTriggerWaitOnSleeps({0})"
		public static extern bool IsTriggerWaitOnSleeps(trigger whichTrigger);
		/// @CSharpLua.Template = "GetFilterUnit()"
		public static extern unit GetFilterUnit();
		/// @CSharpLua.Template = "GetEnumUnit()"
		public static extern unit GetEnumUnit();
		/// @CSharpLua.Template = "GetFilterDestructable()"
		public static extern destructable GetFilterDestructable();
		/// @CSharpLua.Template = "GetEnumDestructable()"
		public static extern destructable GetEnumDestructable();
		/// @CSharpLua.Template = "GetFilterItem()"
		public static extern item GetFilterItem();
		/// @CSharpLua.Template = "GetEnumItem()"
		public static extern item GetEnumItem();
		/// @CSharpLua.Template = "ParseTags({0})"
		public static extern string ParseTags(string taggedString);
		/// @CSharpLua.Template = "GetFilterPlayer()"
		public static extern player GetFilterPlayer();
		/// @CSharpLua.Template = "GetEnumPlayer()"
		public static extern player GetEnumPlayer();
		/// @CSharpLua.Template = "GetTriggeringTrigger()"
		public static extern trigger GetTriggeringTrigger();
		/// @CSharpLua.Template = "GetTriggerEventId()"
		public static extern eventid GetTriggerEventId();
		/// @CSharpLua.Template = "GetTriggerEvalCount({0})"
		public static extern int GetTriggerEvalCount(trigger whichTrigger);
		/// @CSharpLua.Template = "GetTriggerExecCount({0})"
		public static extern int GetTriggerExecCount(trigger whichTrigger);
		/// @CSharpLua.Template = "ExecuteFunc({0})"
		public static extern void ExecuteFunc(string funcName);
		/// @CSharpLua.Template = "And({0}, {1})"
		public static extern boolexpr And(boolexpr operandA, boolexpr operandB);
		/// @CSharpLua.Template = "Or({0}, {1})"
		public static extern boolexpr Or(boolexpr operandA, boolexpr operandB);
		/// @CSharpLua.Template = "Not({0})"
		public static extern boolexpr Not(boolexpr operand);
		/// @CSharpLua.Template = "Condition({0})"
		public static extern conditionfunc Condition(Func<bool> func);
		/// @CSharpLua.Template = "DestroyCondition({0})"
		public static extern void DestroyCondition(conditionfunc c);
		/// @CSharpLua.Template = "Filter({0})"
		public static extern filterfunc Filter(Func<bool> func);
		/// @CSharpLua.Template = "DestroyFilter({0})"
		public static extern void DestroyFilter(filterfunc f);
		/// @CSharpLua.Template = "DestroyBoolExpr({0})"
		public static extern void DestroyBoolExpr(boolexpr e);
		/// @CSharpLua.Template = "TriggerRegisterVariableEvent({0}, {1}, {2}, {3})"
		public static extern @event TriggerRegisterVariableEvent(trigger whichTrigger, string varName, limitop opcode, float limitval);
		/// @CSharpLua.Template = "TriggerRegisterTimerEvent({0}, {1}, {2})"
		public static extern @event TriggerRegisterTimerEvent(trigger whichTrigger, float timeout, bool periodic);
		/// @CSharpLua.Template = "TriggerRegisterTimerExpireEvent({0}, {1})"
		public static extern @event TriggerRegisterTimerExpireEvent(trigger whichTrigger, timer t);
		/// @CSharpLua.Template = "TriggerRegisterGameStateEvent({0}, {1}, {2}, {3})"
		public static extern @event TriggerRegisterGameStateEvent(trigger whichTrigger, gamestate whichState, limitop opcode, float limitval);
		/// @CSharpLua.Template = "TriggerRegisterDialogEvent({0}, {1})"
		public static extern @event TriggerRegisterDialogEvent(trigger whichTrigger, dialog whichDialog);
		/// @CSharpLua.Template = "TriggerRegisterDialogButtonEvent({0}, {1})"
		public static extern @event TriggerRegisterDialogButtonEvent(trigger whichTrigger, button whichButton);
		/// @CSharpLua.Template = "GetEventGameState()"
		public static extern gamestate GetEventGameState();
		/// @CSharpLua.Template = "TriggerRegisterGameEvent({0}, {1})"
		public static extern @event TriggerRegisterGameEvent(trigger whichTrigger, gameevent whichGameEvent);
		/// @CSharpLua.Template = "GetWinningPlayer()"
		public static extern player GetWinningPlayer();
		/// @CSharpLua.Template = "TriggerRegisterEnterRegion({0}, {1}, {2})"
		public static extern @event TriggerRegisterEnterRegion(trigger whichTrigger, region whichRegion, boolexpr filter);
		/// @CSharpLua.Template = "GetTriggeringRegion()"
		public static extern region GetTriggeringRegion();
		/// @CSharpLua.Template = "GetEnteringUnit()"
		public static extern unit GetEnteringUnit();
		/// @CSharpLua.Template = "TriggerRegisterLeaveRegion({0}, {1}, {2})"
		public static extern @event TriggerRegisterLeaveRegion(trigger whichTrigger, region whichRegion, boolexpr filter);
		/// @CSharpLua.Template = "GetLeavingUnit()"
		public static extern unit GetLeavingUnit();
		/// @CSharpLua.Template = "TriggerRegisterTrackableHitEvent({0}, {1})"
		public static extern @event TriggerRegisterTrackableHitEvent(trigger whichTrigger, trackable t);
		/// @CSharpLua.Template = "TriggerRegisterTrackableTrackEvent({0}, {1})"
		public static extern @event TriggerRegisterTrackableTrackEvent(trigger whichTrigger, trackable t);
		/// @CSharpLua.Template = "TriggerRegisterCommandEvent({0}, {1}, {2})"
		public static extern @event TriggerRegisterCommandEvent(trigger whichTrigger, int whichAbility, string order);
		/// @CSharpLua.Template = "TriggerRegisterUpgradeCommandEvent({0}, {1})"
		public static extern @event TriggerRegisterUpgradeCommandEvent(trigger whichTrigger, int whichUpgrade);
		/// @CSharpLua.Template = "GetTriggeringTrackable()"
		public static extern trackable GetTriggeringTrackable();
		/// @CSharpLua.Template = "GetClickedButton()"
		public static extern button GetClickedButton();
		/// @CSharpLua.Template = "GetClickedDialog()"
		public static extern dialog GetClickedDialog();
		/// @CSharpLua.Template = "GetTournamentFinishSoonTimeRemaining()"
		public static extern float GetTournamentFinishSoonTimeRemaining();
		/// @CSharpLua.Template = "GetTournamentFinishNowRule()"
		public static extern int GetTournamentFinishNowRule();
		/// @CSharpLua.Template = "GetTournamentFinishNowPlayer()"
		public static extern player GetTournamentFinishNowPlayer();
		/// @CSharpLua.Template = "GetTournamentScore({0})"
		public static extern int GetTournamentScore(player whichPlayer);
		/// @CSharpLua.Template = "GetSaveBasicFilename()"
		public static extern string GetSaveBasicFilename();
		/// @CSharpLua.Template = "TriggerRegisterPlayerEvent({0}, {1}, {2})"
		public static extern @event TriggerRegisterPlayerEvent(trigger whichTrigger, player whichPlayer, playerevent whichPlayerEvent);
		/// @CSharpLua.Template = "GetTriggerPlayer()"
		public static extern player GetTriggerPlayer();
		/// @CSharpLua.Template = "TriggerRegisterPlayerUnitEvent({0}, {1}, {2}, {3})"
		public static extern @event TriggerRegisterPlayerUnitEvent(trigger whichTrigger, player whichPlayer, playerunitevent whichPlayerUnitEvent, boolexpr filter);
		/// @CSharpLua.Template = "GetLevelingUnit()"
		public static extern unit GetLevelingUnit();
		/// @CSharpLua.Template = "GetLearningUnit()"
		public static extern unit GetLearningUnit();
		/// @CSharpLua.Template = "GetLearnedSkill()"
		public static extern int GetLearnedSkill();
		/// @CSharpLua.Template = "GetLearnedSkillLevel()"
		public static extern int GetLearnedSkillLevel();
		/// @CSharpLua.Template = "GetRevivableUnit()"
		public static extern unit GetRevivableUnit();
		/// @CSharpLua.Template = "GetRevivingUnit()"
		public static extern unit GetRevivingUnit();
		/// @CSharpLua.Template = "GetAttacker()"
		public static extern unit GetAttacker();
		/// @CSharpLua.Template = "GetRescuer()"
		public static extern unit GetRescuer();
		/// @CSharpLua.Template = "GetDyingUnit()"
		public static extern unit GetDyingUnit();
		/// @CSharpLua.Template = "GetKillingUnit()"
		public static extern unit GetKillingUnit();
		/// @CSharpLua.Template = "GetDecayingUnit()"
		public static extern unit GetDecayingUnit();
		/// @CSharpLua.Template = "GetConstructingStructure()"
		public static extern unit GetConstructingStructure();
		/// @CSharpLua.Template = "GetCancelledStructure()"
		public static extern unit GetCancelledStructure();
		/// @CSharpLua.Template = "GetConstructedStructure()"
		public static extern unit GetConstructedStructure();
		/// @CSharpLua.Template = "GetResearchingUnit()"
		public static extern unit GetResearchingUnit();
		/// @CSharpLua.Template = "GetResearched()"
		public static extern int GetResearched();
		/// @CSharpLua.Template = "GetTrainedUnitType()"
		public static extern int GetTrainedUnitType();
		/// @CSharpLua.Template = "GetTrainedUnit()"
		public static extern unit GetTrainedUnit();
		/// @CSharpLua.Template = "GetDetectedUnit()"
		public static extern unit GetDetectedUnit();
		/// @CSharpLua.Template = "GetSummoningUnit()"
		public static extern unit GetSummoningUnit();
		/// @CSharpLua.Template = "GetSummonedUnit()"
		public static extern unit GetSummonedUnit();
		/// @CSharpLua.Template = "GetTransportUnit()"
		public static extern unit GetTransportUnit();
		/// @CSharpLua.Template = "GetLoadedUnit()"
		public static extern unit GetLoadedUnit();
		/// @CSharpLua.Template = "GetSellingUnit()"
		public static extern unit GetSellingUnit();
		/// @CSharpLua.Template = "GetSoldUnit()"
		public static extern unit GetSoldUnit();
		/// @CSharpLua.Template = "GetBuyingUnit()"
		public static extern unit GetBuyingUnit();
		/// @CSharpLua.Template = "GetSoldItem()"
		public static extern item GetSoldItem();
		/// @CSharpLua.Template = "GetChangingUnit()"
		public static extern unit GetChangingUnit();
		/// @CSharpLua.Template = "GetChangingUnitPrevOwner()"
		public static extern player GetChangingUnitPrevOwner();
		/// @CSharpLua.Template = "GetManipulatingUnit()"
		public static extern unit GetManipulatingUnit();
		/// @CSharpLua.Template = "GetManipulatedItem()"
		public static extern item GetManipulatedItem();
		/// @CSharpLua.Template = "BlzGetAbsorbingItem()"
		public static extern item BlzGetAbsorbingItem();
		/// @CSharpLua.Template = "BlzGetManipulatedItemWasAbsorbed()"
		public static extern bool BlzGetManipulatedItemWasAbsorbed();
		/// @CSharpLua.Template = "BlzGetStackingItemSource()"
		public static extern item BlzGetStackingItemSource();
		/// @CSharpLua.Template = "BlzGetStackingItemTarget()"
		public static extern item BlzGetStackingItemTarget();
		/// @CSharpLua.Template = "BlzGetStackingItemTargetPreviousCharges()"
		public static extern int BlzGetStackingItemTargetPreviousCharges();
		/// @CSharpLua.Template = "GetOrderedUnit()"
		public static extern unit GetOrderedUnit();
		/// @CSharpLua.Template = "GetIssuedOrderId()"
		public static extern int GetIssuedOrderId();
		/// @CSharpLua.Template = "GetOrderPointX()"
		public static extern float GetOrderPointX();
		/// @CSharpLua.Template = "GetOrderPointY()"
		public static extern float GetOrderPointY();
		/// @CSharpLua.Template = "GetOrderPointLoc()"
		public static extern location GetOrderPointLoc();
		/// @CSharpLua.Template = "GetOrderTarget()"
		public static extern widget GetOrderTarget();
		/// @CSharpLua.Template = "GetOrderTargetDestructable()"
		public static extern destructable GetOrderTargetDestructable();
		/// @CSharpLua.Template = "GetOrderTargetItem()"
		public static extern item GetOrderTargetItem();
		/// @CSharpLua.Template = "GetOrderTargetUnit()"
		public static extern unit GetOrderTargetUnit();
		/// @CSharpLua.Template = "GetSpellAbilityUnit()"
		public static extern unit GetSpellAbilityUnit();
		/// @CSharpLua.Template = "GetSpellAbilityId()"
		public static extern int GetSpellAbilityId();
		/// @CSharpLua.Template = "GetSpellAbility()"
		public static extern ability GetSpellAbility();
		/// @CSharpLua.Template = "GetSpellTargetLoc()"
		public static extern location GetSpellTargetLoc();
		/// @CSharpLua.Template = "GetSpellTargetX()"
		public static extern float GetSpellTargetX();
		/// @CSharpLua.Template = "GetSpellTargetY()"
		public static extern float GetSpellTargetY();
		/// @CSharpLua.Template = "GetSpellTargetDestructable()"
		public static extern destructable GetSpellTargetDestructable();
		/// @CSharpLua.Template = "GetSpellTargetItem()"
		public static extern item GetSpellTargetItem();
		/// @CSharpLua.Template = "GetSpellTargetUnit()"
		public static extern unit GetSpellTargetUnit();
		/// @CSharpLua.Template = "TriggerRegisterPlayerAllianceChange({0}, {1}, {2})"
		public static extern @event TriggerRegisterPlayerAllianceChange(trigger whichTrigger, player whichPlayer, alliancetype whichAlliance);
		/// @CSharpLua.Template = "TriggerRegisterPlayerStateEvent({0}, {1}, {2}, {3}, {4})"
		public static extern @event TriggerRegisterPlayerStateEvent(trigger whichTrigger, player whichPlayer, playerstate whichState, limitop opcode, float limitval);
		/// @CSharpLua.Template = "GetEventPlayerState()"
		public static extern playerstate GetEventPlayerState();
		/// @CSharpLua.Template = "TriggerRegisterPlayerChatEvent({0}, {1}, {2}, {3})"
		public static extern @event TriggerRegisterPlayerChatEvent(trigger whichTrigger, player whichPlayer, string chatMessageToDetect, bool exactMatchOnly);
		/// @CSharpLua.Template = "GetEventPlayerChatString()"
		public static extern string GetEventPlayerChatString();
		/// @CSharpLua.Template = "GetEventPlayerChatStringMatched()"
		public static extern string GetEventPlayerChatStringMatched();
		/// @CSharpLua.Template = "TriggerRegisterDeathEvent({0}, {1})"
		public static extern @event TriggerRegisterDeathEvent(trigger whichTrigger, widget whichWidget);
		/// @CSharpLua.Template = "GetTriggerUnit()"
		public static extern unit GetTriggerUnit();
		/// @CSharpLua.Template = "TriggerRegisterUnitStateEvent({0}, {1}, {2}, {3}, {4})"
		public static extern @event TriggerRegisterUnitStateEvent(trigger whichTrigger, unit whichUnit, unitstate whichState, limitop opcode, float limitval);
		/// @CSharpLua.Template = "GetEventUnitState()"
		public static extern unitstate GetEventUnitState();
		/// @CSharpLua.Template = "TriggerRegisterUnitEvent({0}, {1}, {2})"
		public static extern @event TriggerRegisterUnitEvent(trigger whichTrigger, unit whichUnit, unitevent whichEvent);
		/// @CSharpLua.Template = "GetEventDamage()"
		public static extern float GetEventDamage();
		/// @CSharpLua.Template = "GetEventDamageSource()"
		public static extern unit GetEventDamageSource();
		/// @CSharpLua.Template = "GetEventDetectingPlayer()"
		public static extern player GetEventDetectingPlayer();
		/// @CSharpLua.Template = "TriggerRegisterFilterUnitEvent({0}, {1}, {2}, {3})"
		public static extern @event TriggerRegisterFilterUnitEvent(trigger whichTrigger, unit whichUnit, unitevent whichEvent, boolexpr filter);
		/// @CSharpLua.Template = "GetEventTargetUnit()"
		public static extern unit GetEventTargetUnit();
		/// @CSharpLua.Template = "TriggerRegisterUnitInRange({0}, {1}, {2}, {3})"
		public static extern @event TriggerRegisterUnitInRange(trigger whichTrigger, unit whichUnit, float range, boolexpr filter);
		/// @CSharpLua.Template = "TriggerAddCondition({0}, {1})"
		public static extern triggercondition TriggerAddCondition(trigger whichTrigger, boolexpr condition);
		/// @CSharpLua.Template = "TriggerRemoveCondition({0}, {1})"
		public static extern void TriggerRemoveCondition(trigger whichTrigger, triggercondition whichCondition);
		/// @CSharpLua.Template = "TriggerClearConditions({0})"
		public static extern void TriggerClearConditions(trigger whichTrigger);
		/// @CSharpLua.Template = "TriggerAddAction({0}, {1})"
		public static extern triggeraction TriggerAddAction(trigger whichTrigger, Action actionFunc);
		/// @CSharpLua.Template = "TriggerRemoveAction({0}, {1})"
		public static extern void TriggerRemoveAction(trigger whichTrigger, triggeraction whichAction);
		/// @CSharpLua.Template = "TriggerClearActions({0})"
		public static extern void TriggerClearActions(trigger whichTrigger);
		/// @CSharpLua.Template = "TriggerSleepAction({0})"
		public static extern void TriggerSleepAction(float timeout);
		/// @CSharpLua.Template = "TriggerWaitForSound({0}, {1})"
		public static extern void TriggerWaitForSound(sound s, float offset);
		/// @CSharpLua.Template = "TriggerEvaluate({0})"
		public static extern bool TriggerEvaluate(trigger whichTrigger);
		/// @CSharpLua.Template = "TriggerExecute({0})"
		public static extern void TriggerExecute(trigger whichTrigger);
		/// @CSharpLua.Template = "TriggerExecuteWait({0})"
		public static extern void TriggerExecuteWait(trigger whichTrigger);
		/// @CSharpLua.Template = "TriggerSyncStart()"
		public static extern void TriggerSyncStart();
		/// @CSharpLua.Template = "TriggerSyncReady()"
		public static extern void TriggerSyncReady();
		/// @CSharpLua.Template = "GetWidgetLife({0})"
		public static extern float GetWidgetLife(widget whichWidget);
		/// @CSharpLua.Template = "SetWidgetLife({0}, {1})"
		public static extern void SetWidgetLife(widget whichWidget, float newLife);
		/// @CSharpLua.Template = "GetWidgetX({0})"
		public static extern float GetWidgetX(widget whichWidget);
		/// @CSharpLua.Template = "GetWidgetY({0})"
		public static extern float GetWidgetY(widget whichWidget);
		/// @CSharpLua.Template = "GetTriggerWidget()"
		public static extern widget GetTriggerWidget();
		/// @CSharpLua.Template = "CreateDestructable({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern destructable CreateDestructable(int objectid, float x, float y, float face, float scale, int variation);
		/// @CSharpLua.Template = "CreateDestructableZ({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern destructable CreateDestructableZ(int objectid, float x, float y, float z, float face, float scale, int variation);
		/// @CSharpLua.Template = "CreateDeadDestructable({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern destructable CreateDeadDestructable(int objectid, float x, float y, float face, float scale, int variation);
		/// @CSharpLua.Template = "CreateDeadDestructableZ({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern destructable CreateDeadDestructableZ(int objectid, float x, float y, float z, float face, float scale, int variation);
		/// @CSharpLua.Template = "RemoveDestructable({0})"
		public static extern void RemoveDestructable(destructable d);
		/// @CSharpLua.Template = "KillDestructable({0})"
		public static extern void KillDestructable(destructable d);
		/// @CSharpLua.Template = "SetDestructableInvulnerable({0}, {1})"
		public static extern void SetDestructableInvulnerable(destructable d, bool flag);
		/// @CSharpLua.Template = "IsDestructableInvulnerable({0})"
		public static extern bool IsDestructableInvulnerable(destructable d);
		/// @CSharpLua.Template = "EnumDestructablesInRect({0}, {1}, {2})"
		public static extern void EnumDestructablesInRect(rect r, boolexpr filter, Action actionFunc);
		/// @CSharpLua.Template = "GetDestructableTypeId({0})"
		public static extern int GetDestructableTypeId(destructable d);
		/// @CSharpLua.Template = "GetDestructableX({0})"
		public static extern float GetDestructableX(destructable d);
		/// @CSharpLua.Template = "GetDestructableY({0})"
		public static extern float GetDestructableY(destructable d);
		/// @CSharpLua.Template = "SetDestructableLife({0}, {1})"
		public static extern void SetDestructableLife(destructable d, float life);
		/// @CSharpLua.Template = "GetDestructableLife({0})"
		public static extern float GetDestructableLife(destructable d);
		/// @CSharpLua.Template = "SetDestructableMaxLife({0}, {1})"
		public static extern void SetDestructableMaxLife(destructable d, float max);
		/// @CSharpLua.Template = "GetDestructableMaxLife({0})"
		public static extern float GetDestructableMaxLife(destructable d);
		/// @CSharpLua.Template = "DestructableRestoreLife({0}, {1}, {2})"
		public static extern void DestructableRestoreLife(destructable d, float life, bool birth);
		/// @CSharpLua.Template = "QueueDestructableAnimation({0}, {1})"
		public static extern void QueueDestructableAnimation(destructable d, string whichAnimation);
		/// @CSharpLua.Template = "SetDestructableAnimation({0}, {1})"
		public static extern void SetDestructableAnimation(destructable d, string whichAnimation);
		/// @CSharpLua.Template = "SetDestructableAnimationSpeed({0}, {1})"
		public static extern void SetDestructableAnimationSpeed(destructable d, float speedFactor);
		/// @CSharpLua.Template = "ShowDestructable({0}, {1})"
		public static extern void ShowDestructable(destructable d, bool flag);
		/// @CSharpLua.Template = "GetDestructableOccluderHeight({0})"
		public static extern float GetDestructableOccluderHeight(destructable d);
		/// @CSharpLua.Template = "SetDestructableOccluderHeight({0}, {1})"
		public static extern void SetDestructableOccluderHeight(destructable d, float height);
		/// @CSharpLua.Template = "GetDestructableName({0})"
		public static extern string GetDestructableName(destructable d);
		/// @CSharpLua.Template = "GetTriggerDestructable()"
		public static extern destructable GetTriggerDestructable();
		/// @CSharpLua.Template = "CreateItem({0}, {1}, {2})"
		public static extern item CreateItem(int itemid, float x, float y);
		/// @CSharpLua.Template = "RemoveItem({0})"
		public static extern void RemoveItem(item whichItem);
		/// @CSharpLua.Template = "GetItemPlayer({0})"
		public static extern player GetItemPlayer(item whichItem);
		/// @CSharpLua.Template = "GetItemTypeId({0})"
		public static extern int GetItemTypeId(item i);
		/// @CSharpLua.Template = "GetItemX({0})"
		public static extern float GetItemX(item i);
		/// @CSharpLua.Template = "GetItemY({0})"
		public static extern float GetItemY(item i);
		/// @CSharpLua.Template = "SetItemPosition({0}, {1}, {2})"
		public static extern void SetItemPosition(item i, float x, float y);
		/// @CSharpLua.Template = "SetItemDropOnDeath({0}, {1})"
		public static extern void SetItemDropOnDeath(item whichItem, bool flag);
		/// @CSharpLua.Template = "SetItemDroppable({0}, {1})"
		public static extern void SetItemDroppable(item i, bool flag);
		/// @CSharpLua.Template = "SetItemPawnable({0}, {1})"
		public static extern void SetItemPawnable(item i, bool flag);
		/// @CSharpLua.Template = "SetItemPlayer({0}, {1}, {2})"
		public static extern void SetItemPlayer(item whichItem, player whichPlayer, bool changeColor);
		/// @CSharpLua.Template = "SetItemInvulnerable({0}, {1})"
		public static extern void SetItemInvulnerable(item whichItem, bool flag);
		/// @CSharpLua.Template = "IsItemInvulnerable({0})"
		public static extern bool IsItemInvulnerable(item whichItem);
		/// @CSharpLua.Template = "SetItemVisible({0}, {1})"
		public static extern void SetItemVisible(item whichItem, bool show);
		/// @CSharpLua.Template = "IsItemVisible({0})"
		public static extern bool IsItemVisible(item whichItem);
		/// @CSharpLua.Template = "IsItemOwned({0})"
		public static extern bool IsItemOwned(item whichItem);
		/// @CSharpLua.Template = "IsItemPowerup({0})"
		public static extern bool IsItemPowerup(item whichItem);
		/// @CSharpLua.Template = "IsItemSellable({0})"
		public static extern bool IsItemSellable(item whichItem);
		/// @CSharpLua.Template = "IsItemPawnable({0})"
		public static extern bool IsItemPawnable(item whichItem);
		/// @CSharpLua.Template = "IsItemIdPowerup({0})"
		public static extern bool IsItemIdPowerup(int itemId);
		/// @CSharpLua.Template = "IsItemIdSellable({0})"
		public static extern bool IsItemIdSellable(int itemId);
		/// @CSharpLua.Template = "IsItemIdPawnable({0})"
		public static extern bool IsItemIdPawnable(int itemId);
		/// @CSharpLua.Template = "EnumItemsInRect({0}, {1}, {2})"
		public static extern void EnumItemsInRect(rect r, boolexpr filter, Action actionFunc);
		/// @CSharpLua.Template = "GetItemLevel({0})"
		public static extern int GetItemLevel(item whichItem);
		/// @CSharpLua.Template = "GetItemType({0})"
		public static extern itemtype GetItemType(item whichItem);
		/// @CSharpLua.Template = "SetItemDropID({0}, {1})"
		public static extern void SetItemDropID(item whichItem, int unitId);
		/// @CSharpLua.Template = "GetItemName({0})"
		public static extern string GetItemName(item whichItem);
		/// @CSharpLua.Template = "GetItemCharges({0})"
		public static extern int GetItemCharges(item whichItem);
		/// @CSharpLua.Template = "SetItemCharges({0}, {1})"
		public static extern void SetItemCharges(item whichItem, int charges);
		/// @CSharpLua.Template = "GetItemUserData({0})"
		public static extern int GetItemUserData(item whichItem);
		/// @CSharpLua.Template = "SetItemUserData({0}, {1})"
		public static extern void SetItemUserData(item whichItem, int data);
		/// @CSharpLua.Template = "CreateUnit({0}, {1}, {2}, {3}, {4})"
		public static extern unit CreateUnit(player id, int unitid, float x, float y, float face);
		/// @CSharpLua.Template = "CreateUnitByName({0}, {1}, {2}, {3}, {4})"
		public static extern unit CreateUnitByName(player whichPlayer, string unitname, float x, float y, float face);
		/// @CSharpLua.Template = "CreateUnitAtLoc({0}, {1}, {2}, {3})"
		public static extern unit CreateUnitAtLoc(player id, int unitid, location whichLocation, float face);
		/// @CSharpLua.Template = "CreateUnitAtLocByName({0}, {1}, {2}, {3})"
		public static extern unit CreateUnitAtLocByName(player id, string unitname, location whichLocation, float face);
		/// @CSharpLua.Template = "CreateCorpse({0}, {1}, {2}, {3}, {4})"
		public static extern unit CreateCorpse(player whichPlayer, int unitid, float x, float y, float face);
		/// @CSharpLua.Template = "KillUnit({0})"
		public static extern void KillUnit(unit whichUnit);
		/// @CSharpLua.Template = "RemoveUnit({0})"
		public static extern void RemoveUnit(unit whichUnit);
		/// @CSharpLua.Template = "ShowUnit({0}, {1})"
		public static extern void ShowUnit(unit whichUnit, bool show);
		/// @CSharpLua.Template = "SetUnitState({0}, {1}, {2})"
		public static extern void SetUnitState(unit whichUnit, unitstate whichUnitState, float newVal);
		/// @CSharpLua.Template = "SetUnitX({0}, {1})"
		public static extern void SetUnitX(unit whichUnit, float newX);
		/// @CSharpLua.Template = "SetUnitY({0}, {1})"
		public static extern void SetUnitY(unit whichUnit, float newY);
		/// @CSharpLua.Template = "SetUnitPosition({0}, {1}, {2})"
		public static extern void SetUnitPosition(unit whichUnit, float newX, float newY);
		/// @CSharpLua.Template = "SetUnitPositionLoc({0}, {1})"
		public static extern void SetUnitPositionLoc(unit whichUnit, location whichLocation);
		/// @CSharpLua.Template = "SetUnitFacing({0}, {1})"
		public static extern void SetUnitFacing(unit whichUnit, float facingAngle);
		/// @CSharpLua.Template = "SetUnitFacingTimed({0}, {1}, {2})"
		public static extern void SetUnitFacingTimed(unit whichUnit, float facingAngle, float duration);
		/// @CSharpLua.Template = "SetUnitMoveSpeed({0}, {1})"
		public static extern void SetUnitMoveSpeed(unit whichUnit, float newSpeed);
		/// @CSharpLua.Template = "SetUnitFlyHeight({0}, {1}, {2})"
		public static extern void SetUnitFlyHeight(unit whichUnit, float newHeight, float rate);
		/// @CSharpLua.Template = "SetUnitTurnSpeed({0}, {1})"
		public static extern void SetUnitTurnSpeed(unit whichUnit, float newTurnSpeed);
		/// @CSharpLua.Template = "SetUnitPropWindow({0}, {1})"
		public static extern void SetUnitPropWindow(unit whichUnit, float newPropWindowAngle);
		/// @CSharpLua.Template = "SetUnitAcquireRange({0}, {1})"
		public static extern void SetUnitAcquireRange(unit whichUnit, float newAcquireRange);
		/// @CSharpLua.Template = "SetUnitCreepGuard({0}, {1})"
		public static extern void SetUnitCreepGuard(unit whichUnit, bool creepGuard);
		/// @CSharpLua.Template = "GetUnitAcquireRange({0})"
		public static extern float GetUnitAcquireRange(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitTurnSpeed({0})"
		public static extern float GetUnitTurnSpeed(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitPropWindow({0})"
		public static extern float GetUnitPropWindow(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitFlyHeight({0})"
		public static extern float GetUnitFlyHeight(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitDefaultAcquireRange({0})"
		public static extern float GetUnitDefaultAcquireRange(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitDefaultTurnSpeed({0})"
		public static extern float GetUnitDefaultTurnSpeed(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitDefaultPropWindow({0})"
		public static extern float GetUnitDefaultPropWindow(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitDefaultFlyHeight({0})"
		public static extern float GetUnitDefaultFlyHeight(unit whichUnit);
		/// @CSharpLua.Template = "SetUnitOwner({0}, {1}, {2})"
		public static extern void SetUnitOwner(unit whichUnit, player whichPlayer, bool changeColor);
		/// @CSharpLua.Template = "SetUnitColor({0}, {1})"
		public static extern void SetUnitColor(unit whichUnit, playercolor whichColor);
		/// @CSharpLua.Template = "SetUnitScale({0}, {1}, {2}, {3})"
		public static extern void SetUnitScale(unit whichUnit, float scaleX, float scaleY, float scaleZ);
		/// @CSharpLua.Template = "SetUnitTimeScale({0}, {1})"
		public static extern void SetUnitTimeScale(unit whichUnit, float timeScale);
		/// @CSharpLua.Template = "SetUnitBlendTime({0}, {1})"
		public static extern void SetUnitBlendTime(unit whichUnit, float blendTime);
		/// @CSharpLua.Template = "SetUnitVertexColor({0}, {1}, {2}, {3}, {4})"
		public static extern void SetUnitVertexColor(unit whichUnit, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "QueueUnitAnimation({0}, {1})"
		public static extern void QueueUnitAnimation(unit whichUnit, string whichAnimation);
		/// @CSharpLua.Template = "SetUnitAnimation({0}, {1})"
		public static extern void SetUnitAnimation(unit whichUnit, string whichAnimation);
		/// @CSharpLua.Template = "SetUnitAnimationByIndex({0}, {1})"
		public static extern void SetUnitAnimationByIndex(unit whichUnit, int whichAnimation);
		/// @CSharpLua.Template = "SetUnitAnimationWithRarity({0}, {1}, {2})"
		public static extern void SetUnitAnimationWithRarity(unit whichUnit, string whichAnimation, raritycontrol rarity);
		/// @CSharpLua.Template = "AddUnitAnimationProperties({0}, {1}, {2})"
		public static extern void AddUnitAnimationProperties(unit whichUnit, string animProperties, bool add);
		/// @CSharpLua.Template = "SetUnitLookAt({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern void SetUnitLookAt(unit whichUnit, string whichBone, unit lookAtTarget, float offsetX, float offsetY, float offsetZ);
		/// @CSharpLua.Template = "ResetUnitLookAt({0})"
		public static extern void ResetUnitLookAt(unit whichUnit);
		/// @CSharpLua.Template = "SetUnitRescuable({0}, {1}, {2})"
		public static extern void SetUnitRescuable(unit whichUnit, player byWhichPlayer, bool flag);
		/// @CSharpLua.Template = "SetUnitRescueRange({0}, {1})"
		public static extern void SetUnitRescueRange(unit whichUnit, float range);
		/// @CSharpLua.Template = "SetHeroStr({0}, {1}, {2})"
		public static extern void SetHeroStr(unit whichHero, int newStr, bool permanent);
		/// @CSharpLua.Template = "SetHeroAgi({0}, {1}, {2})"
		public static extern void SetHeroAgi(unit whichHero, int newAgi, bool permanent);
		/// @CSharpLua.Template = "SetHeroInt({0}, {1}, {2})"
		public static extern void SetHeroInt(unit whichHero, int newInt, bool permanent);
		/// @CSharpLua.Template = "GetHeroStr({0}, {1})"
		public static extern int GetHeroStr(unit whichHero, bool includeBonuses);
		/// @CSharpLua.Template = "GetHeroAgi({0}, {1})"
		public static extern int GetHeroAgi(unit whichHero, bool includeBonuses);
		/// @CSharpLua.Template = "GetHeroInt({0}, {1})"
		public static extern int GetHeroInt(unit whichHero, bool includeBonuses);
		/// @CSharpLua.Template = "UnitStripHeroLevel({0}, {1})"
		public static extern bool UnitStripHeroLevel(unit whichHero, int howManyLevels);
		/// @CSharpLua.Template = "GetHeroXP({0})"
		public static extern int GetHeroXP(unit whichHero);
		/// @CSharpLua.Template = "SetHeroXP({0}, {1}, {2})"
		public static extern void SetHeroXP(unit whichHero, int newXpVal, bool showEyeCandy);
		/// @CSharpLua.Template = "GetHeroSkillPoints({0})"
		public static extern int GetHeroSkillPoints(unit whichHero);
		/// @CSharpLua.Template = "UnitModifySkillPoints({0}, {1})"
		public static extern bool UnitModifySkillPoints(unit whichHero, int skillPointDelta);
		/// @CSharpLua.Template = "AddHeroXP({0}, {1}, {2})"
		public static extern void AddHeroXP(unit whichHero, int xpToAdd, bool showEyeCandy);
		/// @CSharpLua.Template = "SetHeroLevel({0}, {1}, {2})"
		public static extern void SetHeroLevel(unit whichHero, int level, bool showEyeCandy);
		/// @CSharpLua.Template = "GetHeroLevel({0})"
		public static extern int GetHeroLevel(unit whichHero);
		/// @CSharpLua.Template = "GetUnitLevel({0})"
		public static extern int GetUnitLevel(unit whichUnit);
		/// @CSharpLua.Template = "GetHeroProperName({0})"
		public static extern string GetHeroProperName(unit whichHero);
		/// @CSharpLua.Template = "SuspendHeroXP({0}, {1})"
		public static extern void SuspendHeroXP(unit whichHero, bool flag);
		/// @CSharpLua.Template = "IsSuspendedXP({0})"
		public static extern bool IsSuspendedXP(unit whichHero);
		/// @CSharpLua.Template = "SelectHeroSkill({0}, {1})"
		public static extern void SelectHeroSkill(unit whichHero, int abilcode);
		/// @CSharpLua.Template = "GetUnitAbilityLevel({0}, {1})"
		public static extern int GetUnitAbilityLevel(unit whichUnit, int abilcode);
		/// @CSharpLua.Template = "DecUnitAbilityLevel({0}, {1})"
		public static extern int DecUnitAbilityLevel(unit whichUnit, int abilcode);
		/// @CSharpLua.Template = "IncUnitAbilityLevel({0}, {1})"
		public static extern int IncUnitAbilityLevel(unit whichUnit, int abilcode);
		/// @CSharpLua.Template = "SetUnitAbilityLevel({0}, {1}, {2})"
		public static extern int SetUnitAbilityLevel(unit whichUnit, int abilcode, int level);
		/// @CSharpLua.Template = "ReviveHero({0}, {1}, {2}, {3})"
		public static extern bool ReviveHero(unit whichHero, float x, float y, bool doEyecandy);
		/// @CSharpLua.Template = "ReviveHeroLoc({0}, {1}, {2})"
		public static extern bool ReviveHeroLoc(unit whichHero, location loc, bool doEyecandy);
		/// @CSharpLua.Template = "SetUnitExploded({0}, {1})"
		public static extern void SetUnitExploded(unit whichUnit, bool exploded);
		/// @CSharpLua.Template = "SetUnitInvulnerable({0}, {1})"
		public static extern void SetUnitInvulnerable(unit whichUnit, bool flag);
		/// @CSharpLua.Template = "PauseUnit({0}, {1})"
		public static extern void PauseUnit(unit whichUnit, bool flag);
		/// @CSharpLua.Template = "IsUnitPaused({0})"
		public static extern bool IsUnitPaused(unit whichHero);
		/// @CSharpLua.Template = "SetUnitPathing({0}, {1})"
		public static extern void SetUnitPathing(unit whichUnit, bool flag);
		/// @CSharpLua.Template = "ClearSelection()"
		public static extern void ClearSelection();
		/// @CSharpLua.Template = "SelectUnit({0}, {1})"
		public static extern void SelectUnit(unit whichUnit, bool flag);
		/// @CSharpLua.Template = "GetUnitPointValue({0})"
		public static extern int GetUnitPointValue(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitPointValueByType({0})"
		public static extern int GetUnitPointValueByType(int unitType);
		/// @CSharpLua.Template = "UnitAddItem({0}, {1})"
		public static extern bool UnitAddItem(unit whichUnit, item whichItem);
		/// @CSharpLua.Template = "UnitAddItemById({0}, {1})"
		public static extern item UnitAddItemById(unit whichUnit, int itemId);
		/// @CSharpLua.Template = "UnitAddItemToSlotById({0}, {1}, {2})"
		public static extern bool UnitAddItemToSlotById(unit whichUnit, int itemId, int itemSlot);
		/// @CSharpLua.Template = "UnitRemoveItem({0}, {1})"
		public static extern void UnitRemoveItem(unit whichUnit, item whichItem);
		/// @CSharpLua.Template = "UnitRemoveItemFromSlot({0}, {1})"
		public static extern item UnitRemoveItemFromSlot(unit whichUnit, int itemSlot);
		/// @CSharpLua.Template = "UnitHasItem({0}, {1})"
		public static extern bool UnitHasItem(unit whichUnit, item whichItem);
		/// @CSharpLua.Template = "UnitItemInSlot({0}, {1})"
		public static extern item UnitItemInSlot(unit whichUnit, int itemSlot);
		/// @CSharpLua.Template = "UnitInventorySize({0})"
		public static extern int UnitInventorySize(unit whichUnit);
		/// @CSharpLua.Template = "UnitDropItemPoint({0}, {1}, {2}, {3})"
		public static extern bool UnitDropItemPoint(unit whichUnit, item whichItem, float x, float y);
		/// @CSharpLua.Template = "UnitDropItemSlot({0}, {1}, {2})"
		public static extern bool UnitDropItemSlot(unit whichUnit, item whichItem, int slot);
		/// @CSharpLua.Template = "UnitDropItemTarget({0}, {1}, {2})"
		public static extern bool UnitDropItemTarget(unit whichUnit, item whichItem, widget target);
		/// @CSharpLua.Template = "UnitUseItem({0}, {1})"
		public static extern bool UnitUseItem(unit whichUnit, item whichItem);
		/// @CSharpLua.Template = "UnitUseItemPoint({0}, {1}, {2}, {3})"
		public static extern bool UnitUseItemPoint(unit whichUnit, item whichItem, float x, float y);
		/// @CSharpLua.Template = "UnitUseItemTarget({0}, {1}, {2})"
		public static extern bool UnitUseItemTarget(unit whichUnit, item whichItem, widget target);
		/// @CSharpLua.Template = "GetUnitX({0})"
		public static extern float GetUnitX(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitY({0})"
		public static extern float GetUnitY(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitLoc({0})"
		public static extern location GetUnitLoc(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitFacing({0})"
		public static extern float GetUnitFacing(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitMoveSpeed({0})"
		public static extern float GetUnitMoveSpeed(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitDefaultMoveSpeed({0})"
		public static extern float GetUnitDefaultMoveSpeed(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitState({0}, {1})"
		public static extern float GetUnitState(unit whichUnit, unitstate whichUnitState);
		/// @CSharpLua.Template = "GetOwningPlayer({0})"
		public static extern player GetOwningPlayer(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitTypeId({0})"
		public static extern int GetUnitTypeId(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitRace({0})"
		public static extern race GetUnitRace(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitName({0})"
		public static extern string GetUnitName(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitFoodUsed({0})"
		public static extern int GetUnitFoodUsed(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitFoodMade({0})"
		public static extern int GetUnitFoodMade(unit whichUnit);
		/// @CSharpLua.Template = "GetFoodMade({0})"
		public static extern int GetFoodMade(int unitId);
		/// @CSharpLua.Template = "GetFoodUsed({0})"
		public static extern int GetFoodUsed(int unitId);
		/// @CSharpLua.Template = "SetUnitUseFood({0}, {1})"
		public static extern void SetUnitUseFood(unit whichUnit, bool useFood);
		/// @CSharpLua.Template = "GetUnitRallyPoint({0})"
		public static extern location GetUnitRallyPoint(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitRallyUnit({0})"
		public static extern unit GetUnitRallyUnit(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitRallyDestructable({0})"
		public static extern destructable GetUnitRallyDestructable(unit whichUnit);
		/// @CSharpLua.Template = "IsUnitInGroup({0}, {1})"
		public static extern bool IsUnitInGroup(unit whichUnit, group whichGroup);
		/// @CSharpLua.Template = "IsUnitInForce({0}, {1})"
		public static extern bool IsUnitInForce(unit whichUnit, force whichForce);
		/// @CSharpLua.Template = "IsUnitOwnedByPlayer({0}, {1})"
		public static extern bool IsUnitOwnedByPlayer(unit whichUnit, player whichPlayer);
		/// @CSharpLua.Template = "IsUnitAlly({0}, {1})"
		public static extern bool IsUnitAlly(unit whichUnit, player whichPlayer);
		/// @CSharpLua.Template = "IsUnitEnemy({0}, {1})"
		public static extern bool IsUnitEnemy(unit whichUnit, player whichPlayer);
		/// @CSharpLua.Template = "IsUnitVisible({0}, {1})"
		public static extern bool IsUnitVisible(unit whichUnit, player whichPlayer);
		/// @CSharpLua.Template = "IsUnitDetected({0}, {1})"
		public static extern bool IsUnitDetected(unit whichUnit, player whichPlayer);
		/// @CSharpLua.Template = "IsUnitInvisible({0}, {1})"
		public static extern bool IsUnitInvisible(unit whichUnit, player whichPlayer);
		/// @CSharpLua.Template = "IsUnitFogged({0}, {1})"
		public static extern bool IsUnitFogged(unit whichUnit, player whichPlayer);
		/// @CSharpLua.Template = "IsUnitMasked({0}, {1})"
		public static extern bool IsUnitMasked(unit whichUnit, player whichPlayer);
		/// @CSharpLua.Template = "IsUnitSelected({0}, {1})"
		public static extern bool IsUnitSelected(unit whichUnit, player whichPlayer);
		/// @CSharpLua.Template = "IsUnitRace({0}, {1})"
		public static extern bool IsUnitRace(unit whichUnit, race whichRace);
		/// @CSharpLua.Template = "IsUnitType({0}, {1})"
		public static extern bool IsUnitType(unit whichUnit, unittype whichUnitType);
		/// @CSharpLua.Template = "IsUnit({0}, {1})"
		public static extern bool IsUnit(unit whichUnit, unit whichSpecifiedUnit);
		/// @CSharpLua.Template = "IsUnitInRange({0}, {1}, {2})"
		public static extern bool IsUnitInRange(unit whichUnit, unit otherUnit, float distance);
		/// @CSharpLua.Template = "IsUnitInRangeXY({0}, {1}, {2}, {3})"
		public static extern bool IsUnitInRangeXY(unit whichUnit, float x, float y, float distance);
		/// @CSharpLua.Template = "IsUnitInRangeLoc({0}, {1}, {2})"
		public static extern bool IsUnitInRangeLoc(unit whichUnit, location whichLocation, float distance);
		/// @CSharpLua.Template = "IsUnitHidden({0})"
		public static extern bool IsUnitHidden(unit whichUnit);
		/// @CSharpLua.Template = "IsUnitIllusion({0})"
		public static extern bool IsUnitIllusion(unit whichUnit);
		/// @CSharpLua.Template = "IsUnitInTransport({0}, {1})"
		public static extern bool IsUnitInTransport(unit whichUnit, unit whichTransport);
		/// @CSharpLua.Template = "IsUnitLoaded({0})"
		public static extern bool IsUnitLoaded(unit whichUnit);
		/// @CSharpLua.Template = "IsHeroUnitId({0})"
		public static extern bool IsHeroUnitId(int unitId);
		/// @CSharpLua.Template = "IsUnitIdType({0}, {1})"
		public static extern bool IsUnitIdType(int unitId, unittype whichUnitType);
		/// @CSharpLua.Template = "UnitShareVision({0}, {1}, {2})"
		public static extern void UnitShareVision(unit whichUnit, player whichPlayer, bool share);
		/// @CSharpLua.Template = "UnitSuspendDecay({0}, {1})"
		public static extern void UnitSuspendDecay(unit whichUnit, bool suspend);
		/// @CSharpLua.Template = "UnitAddType({0}, {1})"
		public static extern bool UnitAddType(unit whichUnit, unittype whichUnitType);
		/// @CSharpLua.Template = "UnitRemoveType({0}, {1})"
		public static extern bool UnitRemoveType(unit whichUnit, unittype whichUnitType);
		/// @CSharpLua.Template = "UnitAddAbility({0}, {1})"
		public static extern bool UnitAddAbility(unit whichUnit, int abilityId);
		/// @CSharpLua.Template = "UnitRemoveAbility({0}, {1})"
		public static extern bool UnitRemoveAbility(unit whichUnit, int abilityId);
		/// @CSharpLua.Template = "UnitMakeAbilityPermanent({0}, {1}, {2})"
		public static extern bool UnitMakeAbilityPermanent(unit whichUnit, bool permanent, int abilityId);
		/// @CSharpLua.Template = "UnitRemoveBuffs({0}, {1}, {2})"
		public static extern void UnitRemoveBuffs(unit whichUnit, bool removePositive, bool removeNegative);
		/// @CSharpLua.Template = "UnitRemoveBuffsEx({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern void UnitRemoveBuffsEx(unit whichUnit, bool removePositive, bool removeNegative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel);
		/// @CSharpLua.Template = "UnitHasBuffsEx({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern bool UnitHasBuffsEx(unit whichUnit, bool removePositive, bool removeNegative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel);
		/// @CSharpLua.Template = "UnitCountBuffsEx({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern int UnitCountBuffsEx(unit whichUnit, bool removePositive, bool removeNegative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel);
		/// @CSharpLua.Template = "UnitAddSleep({0}, {1})"
		public static extern void UnitAddSleep(unit whichUnit, bool add);
		/// @CSharpLua.Template = "UnitCanSleep({0})"
		public static extern bool UnitCanSleep(unit whichUnit);
		/// @CSharpLua.Template = "UnitAddSleepPerm({0}, {1})"
		public static extern void UnitAddSleepPerm(unit whichUnit, bool add);
		/// @CSharpLua.Template = "UnitCanSleepPerm({0})"
		public static extern bool UnitCanSleepPerm(unit whichUnit);
		/// @CSharpLua.Template = "UnitIsSleeping({0})"
		public static extern bool UnitIsSleeping(unit whichUnit);
		/// @CSharpLua.Template = "UnitWakeUp({0})"
		public static extern void UnitWakeUp(unit whichUnit);
		/// @CSharpLua.Template = "UnitApplyTimedLife({0}, {1}, {2})"
		public static extern void UnitApplyTimedLife(unit whichUnit, int buffId, float duration);
		/// @CSharpLua.Template = "UnitIgnoreAlarm({0}, {1})"
		public static extern bool UnitIgnoreAlarm(unit whichUnit, bool flag);
		/// @CSharpLua.Template = "UnitIgnoreAlarmToggled({0})"
		public static extern bool UnitIgnoreAlarmToggled(unit whichUnit);
		/// @CSharpLua.Template = "UnitResetCooldown({0})"
		public static extern void UnitResetCooldown(unit whichUnit);
		/// @CSharpLua.Template = "UnitSetConstructionProgress({0}, {1})"
		public static extern void UnitSetConstructionProgress(unit whichUnit, int constructionPercentage);
		/// @CSharpLua.Template = "UnitSetUpgradeProgress({0}, {1})"
		public static extern void UnitSetUpgradeProgress(unit whichUnit, int upgradePercentage);
		/// @CSharpLua.Template = "UnitPauseTimedLife({0}, {1})"
		public static extern void UnitPauseTimedLife(unit whichUnit, bool flag);
		/// @CSharpLua.Template = "UnitSetUsesAltIcon({0}, {1})"
		public static extern void UnitSetUsesAltIcon(unit whichUnit, bool flag);
		/// @CSharpLua.Template = "UnitDamagePoint({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})"
		public static extern bool UnitDamagePoint(unit whichUnit, float delay, float radius, float x, float y, float amount, bool attack, bool ranged, attacktype attackType, damagetype damageType, weapontype weaponType);
		/// @CSharpLua.Template = "UnitDamageTarget({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern bool UnitDamageTarget(unit whichUnit, widget target, float amount, bool attack, bool ranged, attacktype attackType, damagetype damageType, weapontype weaponType);
		/// @CSharpLua.Template = "IssueImmediateOrder({0}, {1})"
		public static extern bool IssueImmediateOrder(unit whichUnit, string order);
		/// @CSharpLua.Template = "IssueImmediateOrderById({0}, {1})"
		public static extern bool IssueImmediateOrderById(unit whichUnit, int order);
		/// @CSharpLua.Template = "IssuePointOrder({0}, {1}, {2}, {3})"
		public static extern bool IssuePointOrder(unit whichUnit, string order, float x, float y);
		/// @CSharpLua.Template = "IssuePointOrderLoc({0}, {1}, {2})"
		public static extern bool IssuePointOrderLoc(unit whichUnit, string order, location whichLocation);
		/// @CSharpLua.Template = "IssuePointOrderById({0}, {1}, {2}, {3})"
		public static extern bool IssuePointOrderById(unit whichUnit, int order, float x, float y);
		/// @CSharpLua.Template = "IssuePointOrderByIdLoc({0}, {1}, {2})"
		public static extern bool IssuePointOrderByIdLoc(unit whichUnit, int order, location whichLocation);
		/// @CSharpLua.Template = "IssueTargetOrder({0}, {1}, {2})"
		public static extern bool IssueTargetOrder(unit whichUnit, string order, widget targetWidget);
		/// @CSharpLua.Template = "IssueTargetOrderById({0}, {1}, {2})"
		public static extern bool IssueTargetOrderById(unit whichUnit, int order, widget targetWidget);
		/// @CSharpLua.Template = "IssueInstantPointOrder({0}, {1}, {2}, {3}, {4})"
		public static extern bool IssueInstantPointOrder(unit whichUnit, string order, float x, float y, widget instantTargetWidget);
		/// @CSharpLua.Template = "IssueInstantPointOrderById({0}, {1}, {2}, {3}, {4})"
		public static extern bool IssueInstantPointOrderById(unit whichUnit, int order, float x, float y, widget instantTargetWidget);
		/// @CSharpLua.Template = "IssueInstantTargetOrder({0}, {1}, {2}, {3})"
		public static extern bool IssueInstantTargetOrder(unit whichUnit, string order, widget targetWidget, widget instantTargetWidget);
		/// @CSharpLua.Template = "IssueInstantTargetOrderById({0}, {1}, {2}, {3})"
		public static extern bool IssueInstantTargetOrderById(unit whichUnit, int order, widget targetWidget, widget instantTargetWidget);
		/// @CSharpLua.Template = "IssueBuildOrder({0}, {1}, {2}, {3})"
		public static extern bool IssueBuildOrder(unit whichPeon, string unitToBuild, float x, float y);
		/// @CSharpLua.Template = "IssueBuildOrderById({0}, {1}, {2}, {3})"
		public static extern bool IssueBuildOrderById(unit whichPeon, int unitId, float x, float y);
		/// @CSharpLua.Template = "IssueNeutralImmediateOrder({0}, {1}, {2})"
		public static extern bool IssueNeutralImmediateOrder(player forWhichPlayer, unit neutralStructure, string unitToBuild);
		/// @CSharpLua.Template = "IssueNeutralImmediateOrderById({0}, {1}, {2})"
		public static extern bool IssueNeutralImmediateOrderById(player forWhichPlayer, unit neutralStructure, int unitId);
		/// @CSharpLua.Template = "IssueNeutralPointOrder({0}, {1}, {2}, {3}, {4})"
		public static extern bool IssueNeutralPointOrder(player forWhichPlayer, unit neutralStructure, string unitToBuild, float x, float y);
		/// @CSharpLua.Template = "IssueNeutralPointOrderById({0}, {1}, {2}, {3}, {4})"
		public static extern bool IssueNeutralPointOrderById(player forWhichPlayer, unit neutralStructure, int unitId, float x, float y);
		/// @CSharpLua.Template = "IssueNeutralTargetOrder({0}, {1}, {2}, {3})"
		public static extern bool IssueNeutralTargetOrder(player forWhichPlayer, unit neutralStructure, string unitToBuild, widget target);
		/// @CSharpLua.Template = "IssueNeutralTargetOrderById({0}, {1}, {2}, {3})"
		public static extern bool IssueNeutralTargetOrderById(player forWhichPlayer, unit neutralStructure, int unitId, widget target);
		/// @CSharpLua.Template = "GetUnitCurrentOrder({0})"
		public static extern int GetUnitCurrentOrder(unit whichUnit);
		/// @CSharpLua.Template = "SetResourceAmount({0}, {1})"
		public static extern void SetResourceAmount(unit whichUnit, int amount);
		/// @CSharpLua.Template = "AddResourceAmount({0}, {1})"
		public static extern void AddResourceAmount(unit whichUnit, int amount);
		/// @CSharpLua.Template = "GetResourceAmount({0})"
		public static extern int GetResourceAmount(unit whichUnit);
		/// @CSharpLua.Template = "WaygateGetDestinationX({0})"
		public static extern float WaygateGetDestinationX(unit waygate);
		/// @CSharpLua.Template = "WaygateGetDestinationY({0})"
		public static extern float WaygateGetDestinationY(unit waygate);
		/// @CSharpLua.Template = "WaygateSetDestination({0}, {1}, {2})"
		public static extern void WaygateSetDestination(unit waygate, float x, float y);
		/// @CSharpLua.Template = "WaygateActivate({0}, {1})"
		public static extern void WaygateActivate(unit waygate, bool activate);
		/// @CSharpLua.Template = "WaygateIsActive({0})"
		public static extern bool WaygateIsActive(unit waygate);
		/// @CSharpLua.Template = "AddItemToAllStock({0}, {1}, {2})"
		public static extern void AddItemToAllStock(int itemId, int currentStock, int stockMax);
		/// @CSharpLua.Template = "AddItemToStock({0}, {1}, {2}, {3})"
		public static extern void AddItemToStock(unit whichUnit, int itemId, int currentStock, int stockMax);
		/// @CSharpLua.Template = "AddUnitToAllStock({0}, {1}, {2})"
		public static extern void AddUnitToAllStock(int unitId, int currentStock, int stockMax);
		/// @CSharpLua.Template = "AddUnitToStock({0}, {1}, {2}, {3})"
		public static extern void AddUnitToStock(unit whichUnit, int unitId, int currentStock, int stockMax);
		/// @CSharpLua.Template = "RemoveItemFromAllStock({0})"
		public static extern void RemoveItemFromAllStock(int itemId);
		/// @CSharpLua.Template = "RemoveItemFromStock({0}, {1})"
		public static extern void RemoveItemFromStock(unit whichUnit, int itemId);
		/// @CSharpLua.Template = "RemoveUnitFromAllStock({0})"
		public static extern void RemoveUnitFromAllStock(int unitId);
		/// @CSharpLua.Template = "RemoveUnitFromStock({0}, {1})"
		public static extern void RemoveUnitFromStock(unit whichUnit, int unitId);
		/// @CSharpLua.Template = "SetAllItemTypeSlots({0})"
		public static extern void SetAllItemTypeSlots(int slots);
		/// @CSharpLua.Template = "SetAllUnitTypeSlots({0})"
		public static extern void SetAllUnitTypeSlots(int slots);
		/// @CSharpLua.Template = "SetItemTypeSlots({0}, {1})"
		public static extern void SetItemTypeSlots(unit whichUnit, int slots);
		/// @CSharpLua.Template = "SetUnitTypeSlots({0}, {1})"
		public static extern void SetUnitTypeSlots(unit whichUnit, int slots);
		/// @CSharpLua.Template = "GetUnitUserData({0})"
		public static extern int GetUnitUserData(unit whichUnit);
		/// @CSharpLua.Template = "SetUnitUserData({0}, {1})"
		public static extern void SetUnitUserData(unit whichUnit, int data);
		/// @CSharpLua.Template = "Player({0})"
		public static extern player Player(int number);
		/// @CSharpLua.Template = "GetLocalPlayer()"
		public static extern player GetLocalPlayer();
		/// @CSharpLua.Template = "IsPlayerAlly({0}, {1})"
		public static extern bool IsPlayerAlly(player whichPlayer, player otherPlayer);
		/// @CSharpLua.Template = "IsPlayerEnemy({0}, {1})"
		public static extern bool IsPlayerEnemy(player whichPlayer, player otherPlayer);
		/// @CSharpLua.Template = "IsPlayerInForce({0}, {1})"
		public static extern bool IsPlayerInForce(player whichPlayer, force whichForce);
		/// @CSharpLua.Template = "IsPlayerObserver({0})"
		public static extern bool IsPlayerObserver(player whichPlayer);
		/// @CSharpLua.Template = "IsVisibleToPlayer({0}, {1}, {2})"
		public static extern bool IsVisibleToPlayer(float x, float y, player whichPlayer);
		/// @CSharpLua.Template = "IsLocationVisibleToPlayer({0}, {1})"
		public static extern bool IsLocationVisibleToPlayer(location whichLocation, player whichPlayer);
		/// @CSharpLua.Template = "IsFoggedToPlayer({0}, {1}, {2})"
		public static extern bool IsFoggedToPlayer(float x, float y, player whichPlayer);
		/// @CSharpLua.Template = "IsLocationFoggedToPlayer({0}, {1})"
		public static extern bool IsLocationFoggedToPlayer(location whichLocation, player whichPlayer);
		/// @CSharpLua.Template = "IsMaskedToPlayer({0}, {1}, {2})"
		public static extern bool IsMaskedToPlayer(float x, float y, player whichPlayer);
		/// @CSharpLua.Template = "IsLocationMaskedToPlayer({0}, {1})"
		public static extern bool IsLocationMaskedToPlayer(location whichLocation, player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerRace({0})"
		public static extern race GetPlayerRace(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerId({0})"
		public static extern int GetPlayerId(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerUnitCount({0}, {1})"
		public static extern int GetPlayerUnitCount(player whichPlayer, bool includeIncomplete);
		/// @CSharpLua.Template = "GetPlayerTypedUnitCount({0}, {1}, {2}, {3})"
		public static extern int GetPlayerTypedUnitCount(player whichPlayer, string unitName, bool includeIncomplete, bool includeUpgrades);
		/// @CSharpLua.Template = "GetPlayerStructureCount({0}, {1})"
		public static extern int GetPlayerStructureCount(player whichPlayer, bool includeIncomplete);
		/// @CSharpLua.Template = "GetPlayerState({0}, {1})"
		public static extern int GetPlayerState(player whichPlayer, playerstate whichPlayerState);
		/// @CSharpLua.Template = "GetPlayerScore({0}, {1})"
		public static extern int GetPlayerScore(player whichPlayer, playerscore whichPlayerScore);
		/// @CSharpLua.Template = "GetPlayerAlliance({0}, {1}, {2})"
		public static extern bool GetPlayerAlliance(player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting);
		/// @CSharpLua.Template = "GetPlayerHandicap({0})"
		public static extern float GetPlayerHandicap(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerHandicapXP({0})"
		public static extern float GetPlayerHandicapXP(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerHandicapReviveTime({0})"
		public static extern float GetPlayerHandicapReviveTime(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerHandicapDamage({0})"
		public static extern float GetPlayerHandicapDamage(player whichPlayer);
		/// @CSharpLua.Template = "SetPlayerHandicap({0}, {1})"
		public static extern void SetPlayerHandicap(player whichPlayer, float handicap);
		/// @CSharpLua.Template = "SetPlayerHandicapXP({0}, {1})"
		public static extern void SetPlayerHandicapXP(player whichPlayer, float handicap);
		/// @CSharpLua.Template = "SetPlayerHandicapReviveTime({0}, {1})"
		public static extern void SetPlayerHandicapReviveTime(player whichPlayer, float handicap);
		/// @CSharpLua.Template = "SetPlayerHandicapDamage({0}, {1})"
		public static extern void SetPlayerHandicapDamage(player whichPlayer, float handicap);
		/// @CSharpLua.Template = "SetPlayerTechMaxAllowed({0}, {1}, {2})"
		public static extern void SetPlayerTechMaxAllowed(player whichPlayer, int techid, int maximum);
		/// @CSharpLua.Template = "GetPlayerTechMaxAllowed({0}, {1})"
		public static extern int GetPlayerTechMaxAllowed(player whichPlayer, int techid);
		/// @CSharpLua.Template = "AddPlayerTechResearched({0}, {1}, {2})"
		public static extern void AddPlayerTechResearched(player whichPlayer, int techid, int levels);
		/// @CSharpLua.Template = "SetPlayerTechResearched({0}, {1}, {2})"
		public static extern void SetPlayerTechResearched(player whichPlayer, int techid, int setToLevel);
		/// @CSharpLua.Template = "GetPlayerTechResearched({0}, {1}, {2})"
		public static extern bool GetPlayerTechResearched(player whichPlayer, int techid, bool specificonly);
		/// @CSharpLua.Template = "GetPlayerTechCount({0}, {1}, {2})"
		public static extern int GetPlayerTechCount(player whichPlayer, int techid, bool specificonly);
		/// @CSharpLua.Template = "SetPlayerUnitsOwner({0}, {1})"
		public static extern void SetPlayerUnitsOwner(player whichPlayer, int newOwner);
		/// @CSharpLua.Template = "CripplePlayer({0}, {1}, {2})"
		public static extern void CripplePlayer(player whichPlayer, force toWhichPlayers, bool flag);
		/// @CSharpLua.Template = "SetPlayerAbilityAvailable({0}, {1}, {2})"
		public static extern void SetPlayerAbilityAvailable(player whichPlayer, int abilid, bool avail);
		/// @CSharpLua.Template = "SetPlayerState({0}, {1}, {2})"
		public static extern void SetPlayerState(player whichPlayer, playerstate whichPlayerState, int value);
		/// @CSharpLua.Template = "RemovePlayer({0}, {1})"
		public static extern void RemovePlayer(player whichPlayer, playergameresult gameResult);
		/// @CSharpLua.Template = "CachePlayerHeroData({0})"
		public static extern void CachePlayerHeroData(player whichPlayer);
		/// @CSharpLua.Template = "SetFogStateRect({0}, {1}, {2}, {3})"
		public static extern void SetFogStateRect(player forWhichPlayer, fogstate whichState, rect where, bool useSharedVision);
		/// @CSharpLua.Template = "SetFogStateRadius({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern void SetFogStateRadius(player forWhichPlayer, fogstate whichState, float centerx, float centerY, float radius, bool useSharedVision);
		/// @CSharpLua.Template = "SetFogStateRadiusLoc({0}, {1}, {2}, {3}, {4})"
		public static extern void SetFogStateRadiusLoc(player forWhichPlayer, fogstate whichState, location center, float radius, bool useSharedVision);
		/// @CSharpLua.Template = "FogMaskEnable({0})"
		public static extern void FogMaskEnable(bool enable);
		/// @CSharpLua.Template = "IsFogMaskEnabled()"
		public static extern bool IsFogMaskEnabled();
		/// @CSharpLua.Template = "FogEnable({0})"
		public static extern void FogEnable(bool enable);
		/// @CSharpLua.Template = "IsFogEnabled()"
		public static extern bool IsFogEnabled();
		/// @CSharpLua.Template = "CreateFogModifierRect({0}, {1}, {2}, {3}, {4})"
		public static extern fogmodifier CreateFogModifierRect(player forWhichPlayer, fogstate whichState, rect where, bool useSharedVision, bool afterUnits);
		/// @CSharpLua.Template = "CreateFogModifierRadius({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern fogmodifier CreateFogModifierRadius(player forWhichPlayer, fogstate whichState, float centerx, float centerY, float radius, bool useSharedVision, bool afterUnits);
		/// @CSharpLua.Template = "CreateFogModifierRadiusLoc({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern fogmodifier CreateFogModifierRadiusLoc(player forWhichPlayer, fogstate whichState, location center, float radius, bool useSharedVision, bool afterUnits);
		/// @CSharpLua.Template = "DestroyFogModifier({0})"
		public static extern void DestroyFogModifier(fogmodifier whichFogModifier);
		/// @CSharpLua.Template = "FogModifierStart({0})"
		public static extern void FogModifierStart(fogmodifier whichFogModifier);
		/// @CSharpLua.Template = "FogModifierStop({0})"
		public static extern void FogModifierStop(fogmodifier whichFogModifier);
		/// @CSharpLua.Template = "VersionGet()"
		public static extern version VersionGet();
		/// @CSharpLua.Template = "VersionCompatible({0})"
		public static extern bool VersionCompatible(version whichVersion);
		/// @CSharpLua.Template = "VersionSupported({0})"
		public static extern bool VersionSupported(version whichVersion);
		/// @CSharpLua.Template = "EndGame({0})"
		public static extern void EndGame(bool doScoreScreen);
		/// @CSharpLua.Template = "ChangeLevel({0}, {1})"
		public static extern void ChangeLevel(string newLevel, bool doScoreScreen);
		/// @CSharpLua.Template = "RestartGame({0})"
		public static extern void RestartGame(bool doScoreScreen);
		/// @CSharpLua.Template = "ReloadGame()"
		public static extern void ReloadGame();
		/// @CSharpLua.Template = "SetCampaignMenuRace({0})"
		public static extern void SetCampaignMenuRace(race r);
		/// @CSharpLua.Template = "SetCampaignMenuRaceEx({0})"
		public static extern void SetCampaignMenuRaceEx(int campaignIndex);
		/// @CSharpLua.Template = "ForceCampaignSelectScreen()"
		public static extern void ForceCampaignSelectScreen();
		/// @CSharpLua.Template = "LoadGame({0}, {1})"
		public static extern void LoadGame(string saveFileName, bool doScoreScreen);
		/// @CSharpLua.Template = "SaveGame({0})"
		public static extern void SaveGame(string saveFileName);
		/// @CSharpLua.Template = "RenameSaveDirectory({0}, {1})"
		public static extern bool RenameSaveDirectory(string sourceDirName, string destDirName);
		/// @CSharpLua.Template = "RemoveSaveDirectory({0})"
		public static extern bool RemoveSaveDirectory(string sourceDirName);
		/// @CSharpLua.Template = "CopySaveGame({0}, {1})"
		public static extern bool CopySaveGame(string sourceSaveName, string destSaveName);
		/// @CSharpLua.Template = "SaveGameExists({0})"
		public static extern bool SaveGameExists(string saveName);
		/// @CSharpLua.Template = "SetMaxCheckpointSaves({0})"
		public static extern void SetMaxCheckpointSaves(int maxCheckpointSaves);
		/// @CSharpLua.Template = "SaveGameCheckpoint({0}, {1})"
		public static extern void SaveGameCheckpoint(string saveFileName, bool showWindow);
		/// @CSharpLua.Template = "SyncSelections()"
		public static extern void SyncSelections();
		/// @CSharpLua.Template = "SetFloatGameState({0}, {1})"
		public static extern void SetFloatGameState(fgamestate whichFloatGameState, float value);
		/// @CSharpLua.Template = "GetFloatGameState({0})"
		public static extern float GetFloatGameState(fgamestate whichFloatGameState);
		/// @CSharpLua.Template = "SetIntegerGameState({0}, {1})"
		public static extern void SetIntegerGameState(igamestate whichIntegerGameState, int value);
		/// @CSharpLua.Template = "GetIntegerGameState({0})"
		public static extern int GetIntegerGameState(igamestate whichIntegerGameState);
		/// @CSharpLua.Template = "SetTutorialCleared({0})"
		public static extern void SetTutorialCleared(bool cleared);
		/// @CSharpLua.Template = "SetMissionAvailable({0}, {1}, {2})"
		public static extern void SetMissionAvailable(int campaignNumber, int missionNumber, bool available);
		/// @CSharpLua.Template = "SetCampaignAvailable({0}, {1})"
		public static extern void SetCampaignAvailable(int campaignNumber, bool available);
		/// @CSharpLua.Template = "SetOpCinematicAvailable({0}, {1})"
		public static extern void SetOpCinematicAvailable(int campaignNumber, bool available);
		/// @CSharpLua.Template = "SetEdCinematicAvailable({0}, {1})"
		public static extern void SetEdCinematicAvailable(int campaignNumber, bool available);
		/// @CSharpLua.Template = "GetDefaultDifficulty()"
		public static extern gamedifficulty GetDefaultDifficulty();
		/// @CSharpLua.Template = "SetDefaultDifficulty({0})"
		public static extern void SetDefaultDifficulty(gamedifficulty g);
		/// @CSharpLua.Template = "SetCustomCampaignButtonVisible({0}, {1})"
		public static extern void SetCustomCampaignButtonVisible(int whichButton, bool visible);
		/// @CSharpLua.Template = "GetCustomCampaignButtonVisible({0})"
		public static extern bool GetCustomCampaignButtonVisible(int whichButton);
		/// @CSharpLua.Template = "DoNotSaveReplay()"
		public static extern void DoNotSaveReplay();
		/// @CSharpLua.Template = "DialogCreate()"
		public static extern dialog DialogCreate();
		/// @CSharpLua.Template = "DialogDestroy({0})"
		public static extern void DialogDestroy(dialog whichDialog);
		/// @CSharpLua.Template = "DialogClear({0})"
		public static extern void DialogClear(dialog whichDialog);
		/// @CSharpLua.Template = "DialogSetMessage({0}, {1})"
		public static extern void DialogSetMessage(dialog whichDialog, string messageText);
		/// @CSharpLua.Template = "DialogAddButton({0}, {1}, {2})"
		public static extern button DialogAddButton(dialog whichDialog, string buttonText, int hotkey);
		/// @CSharpLua.Template = "DialogAddQuitButton({0}, {1}, {2}, {3})"
		public static extern button DialogAddQuitButton(dialog whichDialog, bool doScoreScreen, string buttonText, int hotkey);
		/// @CSharpLua.Template = "DialogDisplay({0}, {1}, {2})"
		public static extern void DialogDisplay(player whichPlayer, dialog whichDialog, bool flag);
		/// @CSharpLua.Template = "ReloadGameCachesFromDisk()"
		public static extern bool ReloadGameCachesFromDisk();
		/// @CSharpLua.Template = "InitGameCache({0})"
		public static extern gamecache InitGameCache(string campaignFile);
		/// @CSharpLua.Template = "SaveGameCache({0})"
		public static extern bool SaveGameCache(gamecache whichCache);
		/// @CSharpLua.Template = "StoreInteger({0}, {1}, {2}, {3})"
		public static extern void StoreInteger(gamecache cache, string missionKey, string key, int value);
		/// @CSharpLua.Template = "StoreReal({0}, {1}, {2}, {3})"
		public static extern void StoreReal(gamecache cache, string missionKey, string key, float value);
		/// @CSharpLua.Template = "StoreBoolean({0}, {1}, {2}, {3})"
		public static extern void StoreBoolean(gamecache cache, string missionKey, string key, bool value);
		/// @CSharpLua.Template = "StoreUnit({0}, {1}, {2}, {3})"
		public static extern bool StoreUnit(gamecache cache, string missionKey, string key, unit whichUnit);
		/// @CSharpLua.Template = "StoreString({0}, {1}, {2}, {3})"
		public static extern bool StoreString(gamecache cache, string missionKey, string key, string value);
		/// @CSharpLua.Template = "SyncStoredInteger({0}, {1}, {2})"
		public static extern void SyncStoredInteger(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "SyncStoredReal({0}, {1}, {2})"
		public static extern void SyncStoredReal(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "SyncStoredBoolean({0}, {1}, {2})"
		public static extern void SyncStoredBoolean(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "SyncStoredUnit({0}, {1}, {2})"
		public static extern void SyncStoredUnit(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "SyncStoredString({0}, {1}, {2})"
		public static extern void SyncStoredString(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredInteger({0}, {1}, {2})"
		public static extern bool HaveStoredInteger(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredReal({0}, {1}, {2})"
		public static extern bool HaveStoredReal(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredBoolean({0}, {1}, {2})"
		public static extern bool HaveStoredBoolean(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredUnit({0}, {1}, {2})"
		public static extern bool HaveStoredUnit(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredString({0}, {1}, {2})"
		public static extern bool HaveStoredString(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "FlushGameCache({0})"
		public static extern void FlushGameCache(gamecache cache);
		/// @CSharpLua.Template = "FlushStoredMission({0}, {1})"
		public static extern void FlushStoredMission(gamecache cache, string missionKey);
		/// @CSharpLua.Template = "FlushStoredInteger({0}, {1}, {2})"
		public static extern void FlushStoredInteger(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredReal({0}, {1}, {2})"
		public static extern void FlushStoredReal(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredBoolean({0}, {1}, {2})"
		public static extern void FlushStoredBoolean(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredUnit({0}, {1}, {2})"
		public static extern void FlushStoredUnit(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredString({0}, {1}, {2})"
		public static extern void FlushStoredString(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "GetStoredInteger({0}, {1}, {2})"
		public static extern int GetStoredInteger(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "GetStoredReal({0}, {1}, {2})"
		public static extern float GetStoredReal(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "GetStoredBoolean({0}, {1}, {2})"
		public static extern bool GetStoredBoolean(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "GetStoredString({0}, {1}, {2})"
		public static extern string GetStoredString(gamecache cache, string missionKey, string key);
		/// @CSharpLua.Template = "RestoreUnit({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern unit RestoreUnit(gamecache cache, string missionKey, string key, player forWhichPlayer, float x, float y, float facing);
		/// @CSharpLua.Template = "InitHashtable()"
		public static extern hashtable InitHashtable();
		/// @CSharpLua.Template = "SaveInteger({0}, {1}, {2}, {3})"
		public static extern void SaveInteger(hashtable table, int parentKey, int childKey, int value);
		/// @CSharpLua.Template = "SaveReal({0}, {1}, {2}, {3})"
		public static extern void SaveReal(hashtable table, int parentKey, int childKey, float value);
		/// @CSharpLua.Template = "SaveBoolean({0}, {1}, {2}, {3})"
		public static extern void SaveBoolean(hashtable table, int parentKey, int childKey, bool value);
		/// @CSharpLua.Template = "SaveStr({0}, {1}, {2}, {3})"
		public static extern bool SaveStr(hashtable table, int parentKey, int childKey, string value);
		/// @CSharpLua.Template = "SavePlayerHandle({0}, {1}, {2}, {3})"
		public static extern bool SavePlayerHandle(hashtable table, int parentKey, int childKey, player whichPlayer);
		/// @CSharpLua.Template = "SaveWidgetHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveWidgetHandle(hashtable table, int parentKey, int childKey, widget whichWidget);
		/// @CSharpLua.Template = "SaveDestructableHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveDestructableHandle(hashtable table, int parentKey, int childKey, destructable whichDestructable);
		/// @CSharpLua.Template = "SaveItemHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveItemHandle(hashtable table, int parentKey, int childKey, item whichItem);
		/// @CSharpLua.Template = "SaveUnitHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveUnitHandle(hashtable table, int parentKey, int childKey, unit whichUnit);
		/// @CSharpLua.Template = "SaveAbilityHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveAbilityHandle(hashtable table, int parentKey, int childKey, ability whichAbility);
		/// @CSharpLua.Template = "SaveTimerHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveTimerHandle(hashtable table, int parentKey, int childKey, timer whichTimer);
		/// @CSharpLua.Template = "SaveTriggerHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveTriggerHandle(hashtable table, int parentKey, int childKey, trigger whichTrigger);
		/// @CSharpLua.Template = "SaveTriggerConditionHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveTriggerConditionHandle(hashtable table, int parentKey, int childKey, triggercondition whichTriggercondition);
		/// @CSharpLua.Template = "SaveTriggerActionHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveTriggerActionHandle(hashtable table, int parentKey, int childKey, triggeraction whichTriggeraction);
		/// @CSharpLua.Template = "SaveTriggerEventHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveTriggerEventHandle(hashtable table, int parentKey, int childKey, @event whichEvent);
		/// @CSharpLua.Template = "SaveForceHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveForceHandle(hashtable table, int parentKey, int childKey, force whichForce);
		/// @CSharpLua.Template = "SaveGroupHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveGroupHandle(hashtable table, int parentKey, int childKey, group whichGroup);
		/// @CSharpLua.Template = "SaveLocationHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveLocationHandle(hashtable table, int parentKey, int childKey, location whichLocation);
		/// @CSharpLua.Template = "SaveRectHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveRectHandle(hashtable table, int parentKey, int childKey, rect whichRect);
		/// @CSharpLua.Template = "SaveBooleanExprHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveBooleanExprHandle(hashtable table, int parentKey, int childKey, boolexpr whichBoolexpr);
		/// @CSharpLua.Template = "SaveSoundHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveSoundHandle(hashtable table, int parentKey, int childKey, sound whichSound);
		/// @CSharpLua.Template = "SaveEffectHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveEffectHandle(hashtable table, int parentKey, int childKey, effect whichEffect);
		/// @CSharpLua.Template = "SaveUnitPoolHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveUnitPoolHandle(hashtable table, int parentKey, int childKey, unitpool whichUnitpool);
		/// @CSharpLua.Template = "SaveItemPoolHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveItemPoolHandle(hashtable table, int parentKey, int childKey, itempool whichItempool);
		/// @CSharpLua.Template = "SaveQuestHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveQuestHandle(hashtable table, int parentKey, int childKey, quest whichQuest);
		/// @CSharpLua.Template = "SaveQuestItemHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveQuestItemHandle(hashtable table, int parentKey, int childKey, questitem whichQuestitem);
		/// @CSharpLua.Template = "SaveDefeatConditionHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveDefeatConditionHandle(hashtable table, int parentKey, int childKey, defeatcondition whichDefeatcondition);
		/// @CSharpLua.Template = "SaveTimerDialogHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveTimerDialogHandle(hashtable table, int parentKey, int childKey, timerdialog whichTimerdialog);
		/// @CSharpLua.Template = "SaveLeaderboardHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveLeaderboardHandle(hashtable table, int parentKey, int childKey, leaderboard whichLeaderboard);
		/// @CSharpLua.Template = "SaveMultiboardHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveMultiboardHandle(hashtable table, int parentKey, int childKey, multiboard whichMultiboard);
		/// @CSharpLua.Template = "SaveMultiboardItemHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveMultiboardItemHandle(hashtable table, int parentKey, int childKey, multiboarditem whichMultiboarditem);
		/// @CSharpLua.Template = "SaveTrackableHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveTrackableHandle(hashtable table, int parentKey, int childKey, trackable whichTrackable);
		/// @CSharpLua.Template = "SaveDialogHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveDialogHandle(hashtable table, int parentKey, int childKey, dialog whichDialog);
		/// @CSharpLua.Template = "SaveButtonHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveButtonHandle(hashtable table, int parentKey, int childKey, button whichButton);
		/// @CSharpLua.Template = "SaveTextTagHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveTextTagHandle(hashtable table, int parentKey, int childKey, texttag whichTexttag);
		/// @CSharpLua.Template = "SaveLightningHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveLightningHandle(hashtable table, int parentKey, int childKey, lightning whichLightning);
		/// @CSharpLua.Template = "SaveImageHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveImageHandle(hashtable table, int parentKey, int childKey, image whichImage);
		/// @CSharpLua.Template = "SaveUbersplatHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveUbersplatHandle(hashtable table, int parentKey, int childKey, ubersplat whichUbersplat);
		/// @CSharpLua.Template = "SaveRegionHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveRegionHandle(hashtable table, int parentKey, int childKey, region whichRegion);
		/// @CSharpLua.Template = "SaveFogStateHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveFogStateHandle(hashtable table, int parentKey, int childKey, fogstate whichFogState);
		/// @CSharpLua.Template = "SaveFogModifierHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveFogModifierHandle(hashtable table, int parentKey, int childKey, fogmodifier whichFogModifier);
		/// @CSharpLua.Template = "SaveAgentHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveAgentHandle(hashtable table, int parentKey, int childKey, agent whichAgent);
		/// @CSharpLua.Template = "SaveHashtableHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveHashtableHandle(hashtable table, int parentKey, int childKey, hashtable whichHashtable);
		/// @CSharpLua.Template = "SaveFrameHandle({0}, {1}, {2}, {3})"
		public static extern bool SaveFrameHandle(hashtable table, int parentKey, int childKey, framehandle whichFrameHandle);
		/// @CSharpLua.Template = "LoadInteger({0}, {1}, {2})"
		public static extern int LoadInteger(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadReal({0}, {1}, {2})"
		public static extern float LoadReal(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadBoolean({0}, {1}, {2})"
		public static extern bool LoadBoolean(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadStr({0}, {1}, {2})"
		public static extern string LoadStr(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadPlayerHandle({0}, {1}, {2})"
		public static extern player LoadPlayerHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadWidgetHandle({0}, {1}, {2})"
		public static extern widget LoadWidgetHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadDestructableHandle({0}, {1}, {2})"
		public static extern destructable LoadDestructableHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadItemHandle({0}, {1}, {2})"
		public static extern item LoadItemHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadUnitHandle({0}, {1}, {2})"
		public static extern unit LoadUnitHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadAbilityHandle({0}, {1}, {2})"
		public static extern ability LoadAbilityHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadTimerHandle({0}, {1}, {2})"
		public static extern timer LoadTimerHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadTriggerHandle({0}, {1}, {2})"
		public static extern trigger LoadTriggerHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadTriggerConditionHandle({0}, {1}, {2})"
		public static extern triggercondition LoadTriggerConditionHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadTriggerActionHandle({0}, {1}, {2})"
		public static extern triggeraction LoadTriggerActionHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadTriggerEventHandle({0}, {1}, {2})"
		public static extern @event LoadTriggerEventHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadForceHandle({0}, {1}, {2})"
		public static extern force LoadForceHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadGroupHandle({0}, {1}, {2})"
		public static extern group LoadGroupHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadLocationHandle({0}, {1}, {2})"
		public static extern location LoadLocationHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadRectHandle({0}, {1}, {2})"
		public static extern rect LoadRectHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadBooleanExprHandle({0}, {1}, {2})"
		public static extern boolexpr LoadBooleanExprHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadSoundHandle({0}, {1}, {2})"
		public static extern sound LoadSoundHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadEffectHandle({0}, {1}, {2})"
		public static extern effect LoadEffectHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadUnitPoolHandle({0}, {1}, {2})"
		public static extern unitpool LoadUnitPoolHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadItemPoolHandle({0}, {1}, {2})"
		public static extern itempool LoadItemPoolHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadQuestHandle({0}, {1}, {2})"
		public static extern quest LoadQuestHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadQuestItemHandle({0}, {1}, {2})"
		public static extern questitem LoadQuestItemHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadDefeatConditionHandle({0}, {1}, {2})"
		public static extern defeatcondition LoadDefeatConditionHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadTimerDialogHandle({0}, {1}, {2})"
		public static extern timerdialog LoadTimerDialogHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadLeaderboardHandle({0}, {1}, {2})"
		public static extern leaderboard LoadLeaderboardHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadMultiboardHandle({0}, {1}, {2})"
		public static extern multiboard LoadMultiboardHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadMultiboardItemHandle({0}, {1}, {2})"
		public static extern multiboarditem LoadMultiboardItemHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadTrackableHandle({0}, {1}, {2})"
		public static extern trackable LoadTrackableHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadDialogHandle({0}, {1}, {2})"
		public static extern dialog LoadDialogHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadButtonHandle({0}, {1}, {2})"
		public static extern button LoadButtonHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadTextTagHandle({0}, {1}, {2})"
		public static extern texttag LoadTextTagHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadLightningHandle({0}, {1}, {2})"
		public static extern lightning LoadLightningHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadImageHandle({0}, {1}, {2})"
		public static extern image LoadImageHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadUbersplatHandle({0}, {1}, {2})"
		public static extern ubersplat LoadUbersplatHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadRegionHandle({0}, {1}, {2})"
		public static extern region LoadRegionHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadFogStateHandle({0}, {1}, {2})"
		public static extern fogstate LoadFogStateHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadFogModifierHandle({0}, {1}, {2})"
		public static extern fogmodifier LoadFogModifierHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadHashtableHandle({0}, {1}, {2})"
		public static extern hashtable LoadHashtableHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "LoadFrameHandle({0}, {1}, {2})"
		public static extern framehandle LoadFrameHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "HaveSavedInteger({0}, {1}, {2})"
		public static extern bool HaveSavedInteger(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "HaveSavedReal({0}, {1}, {2})"
		public static extern bool HaveSavedReal(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "HaveSavedBoolean({0}, {1}, {2})"
		public static extern bool HaveSavedBoolean(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "HaveSavedString({0}, {1}, {2})"
		public static extern bool HaveSavedString(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "HaveSavedHandle({0}, {1}, {2})"
		public static extern bool HaveSavedHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "RemoveSavedInteger({0}, {1}, {2})"
		public static extern void RemoveSavedInteger(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "RemoveSavedReal({0}, {1}, {2})"
		public static extern void RemoveSavedReal(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "RemoveSavedBoolean({0}, {1}, {2})"
		public static extern void RemoveSavedBoolean(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "RemoveSavedString({0}, {1}, {2})"
		public static extern void RemoveSavedString(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "RemoveSavedHandle({0}, {1}, {2})"
		public static extern void RemoveSavedHandle(hashtable table, int parentKey, int childKey);
		/// @CSharpLua.Template = "FlushParentHashtable({0})"
		public static extern void FlushParentHashtable(hashtable table);
		/// @CSharpLua.Template = "FlushChildHashtable({0}, {1})"
		public static extern void FlushChildHashtable(hashtable table, int parentKey);
		/// @CSharpLua.Template = "GetRandomInt({0}, {1})"
		public static extern int GetRandomInt(int lowBound, int highBound);
		/// @CSharpLua.Template = "GetRandomReal({0}, {1})"
		public static extern float GetRandomReal(float lowBound, float highBound);
		/// @CSharpLua.Template = "CreateUnitPool()"
		public static extern unitpool CreateUnitPool();
		/// @CSharpLua.Template = "DestroyUnitPool({0})"
		public static extern void DestroyUnitPool(unitpool whichPool);
		/// @CSharpLua.Template = "UnitPoolAddUnitType({0}, {1}, {2})"
		public static extern void UnitPoolAddUnitType(unitpool whichPool, int unitId, float weight);
		/// @CSharpLua.Template = "UnitPoolRemoveUnitType({0}, {1})"
		public static extern void UnitPoolRemoveUnitType(unitpool whichPool, int unitId);
		/// @CSharpLua.Template = "PlaceRandomUnit({0}, {1}, {2}, {3}, {4})"
		public static extern unit PlaceRandomUnit(unitpool whichPool, player forWhichPlayer, float x, float y, float facing);
		/// @CSharpLua.Template = "CreateItemPool()"
		public static extern itempool CreateItemPool();
		/// @CSharpLua.Template = "DestroyItemPool({0})"
		public static extern void DestroyItemPool(itempool whichItemPool);
		/// @CSharpLua.Template = "ItemPoolAddItemType({0}, {1}, {2})"
		public static extern void ItemPoolAddItemType(itempool whichItemPool, int itemId, float weight);
		/// @CSharpLua.Template = "ItemPoolRemoveItemType({0}, {1})"
		public static extern void ItemPoolRemoveItemType(itempool whichItemPool, int itemId);
		/// @CSharpLua.Template = "PlaceRandomItem({0}, {1}, {2})"
		public static extern item PlaceRandomItem(itempool whichItemPool, float x, float y);
		/// @CSharpLua.Template = "ChooseRandomCreep({0})"
		public static extern int ChooseRandomCreep(int level);
		/// @CSharpLua.Template = "ChooseRandomNPBuilding()"
		public static extern int ChooseRandomNPBuilding();
		/// @CSharpLua.Template = "ChooseRandomItem({0})"
		public static extern int ChooseRandomItem(int level);
		/// @CSharpLua.Template = "ChooseRandomItemEx({0}, {1})"
		public static extern int ChooseRandomItemEx(itemtype whichType, int level);
		/// @CSharpLua.Template = "SetRandomSeed({0})"
		public static extern void SetRandomSeed(int seed);
		/// @CSharpLua.Template = "SetTerrainFog({0}, {1}, {2}, {3}, {4})"
		public static extern void SetTerrainFog(float a, float b, float c, float d, float e);
		/// @CSharpLua.Template = "ResetTerrainFog()"
		public static extern void ResetTerrainFog();
		/// @CSharpLua.Template = "SetUnitFog({0}, {1}, {2}, {3}, {4})"
		public static extern void SetUnitFog(float a, float b, float c, float d, float e);
		/// @CSharpLua.Template = "SetTerrainFogEx({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern void SetTerrainFogEx(int style, float zstart, float zend, float density, float red, float green, float blue);
		/// @CSharpLua.Template = "DisplayTextToPlayer({0}, {1}, {2}, {3})"
		public static extern void DisplayTextToPlayer(player toPlayer, float x, float y, string message);
		/// @CSharpLua.Template = "DisplayTimedTextToPlayer({0}, {1}, {2}, {3}, {4})"
		public static extern void DisplayTimedTextToPlayer(player toPlayer, float x, float y, float duration, string message);
		/// @CSharpLua.Template = "DisplayTimedTextFromPlayer({0}, {1}, {2}, {3}, {4})"
		public static extern void DisplayTimedTextFromPlayer(player toPlayer, float x, float y, float duration, string message);
		/// @CSharpLua.Template = "ClearTextMessages()"
		public static extern void ClearTextMessages();
		/// @CSharpLua.Template = "SetDayNightModels({0}, {1})"
		public static extern void SetDayNightModels(string terrainDNCFile, string unitDNCFile);
		/// @CSharpLua.Template = "SetPortraitLight({0})"
		public static extern void SetPortraitLight(string portraitDNCFile);
		/// @CSharpLua.Template = "SetSkyModel({0})"
		public static extern void SetSkyModel(string skyModelFile);
		/// @CSharpLua.Template = "EnableUserControl({0})"
		public static extern void EnableUserControl(bool b);
		/// @CSharpLua.Template = "EnableUserUI({0})"
		public static extern void EnableUserUI(bool b);
		/// @CSharpLua.Template = "SuspendTimeOfDay({0})"
		public static extern void SuspendTimeOfDay(bool b);
		/// @CSharpLua.Template = "SetTimeOfDayScale({0})"
		public static extern void SetTimeOfDayScale(float r);
		/// @CSharpLua.Template = "GetTimeOfDayScale()"
		public static extern float GetTimeOfDayScale();
		/// @CSharpLua.Template = "ShowInterface({0}, {1})"
		public static extern void ShowInterface(bool flag, float fadeDuration);
		/// @CSharpLua.Template = "PauseGame({0})"
		public static extern void PauseGame(bool flag);
		/// @CSharpLua.Template = "UnitAddIndicator({0}, {1}, {2}, {3}, {4})"
		public static extern void UnitAddIndicator(unit whichUnit, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "AddIndicator({0}, {1}, {2}, {3}, {4})"
		public static extern void AddIndicator(widget whichWidget, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "PingMinimap({0}, {1}, {2})"
		public static extern void PingMinimap(float x, float y, float duration);
		/// @CSharpLua.Template = "PingMinimapEx({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern void PingMinimapEx(float x, float y, float duration, int red, int green, int blue, bool extraEffects);
		/// @CSharpLua.Template = "CreateMinimapIconOnUnit({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern minimapicon CreateMinimapIconOnUnit(unit whichUnit, int red, int green, int blue, string pingPath, fogstate fogVisibility);
		/// @CSharpLua.Template = "CreateMinimapIconAtLoc({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern minimapicon CreateMinimapIconAtLoc(location where, int red, int green, int blue, string pingPath, fogstate fogVisibility);
		/// @CSharpLua.Template = "CreateMinimapIcon({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern minimapicon CreateMinimapIcon(float x, float y, int red, int green, int blue, string pingPath, fogstate fogVisibility);
		/// @CSharpLua.Template = "SkinManagerGetLocalPath({0})"
		public static extern string SkinManagerGetLocalPath(string key);
		/// @CSharpLua.Template = "DestroyMinimapIcon({0})"
		public static extern void DestroyMinimapIcon(minimapicon pingId);
		/// @CSharpLua.Template = "SetMinimapIconVisible({0}, {1})"
		public static extern void SetMinimapIconVisible(minimapicon whichMinimapIcon, bool visible);
		/// @CSharpLua.Template = "SetMinimapIconOrphanDestroy({0}, {1})"
		public static extern void SetMinimapIconOrphanDestroy(minimapicon whichMinimapIcon, bool doDestroy);
		/// @CSharpLua.Template = "EnableOcclusion({0})"
		public static extern void EnableOcclusion(bool flag);
		/// @CSharpLua.Template = "SetIntroShotText({0})"
		public static extern void SetIntroShotText(string introText);
		/// @CSharpLua.Template = "SetIntroShotModel({0})"
		public static extern void SetIntroShotModel(string introModelPath);
		/// @CSharpLua.Template = "EnableWorldFogBoundary({0})"
		public static extern void EnableWorldFogBoundary(bool b);
		/// @CSharpLua.Template = "PlayModelCinematic({0})"
		public static extern void PlayModelCinematic(string modelName);
		/// @CSharpLua.Template = "PlayCinematic({0})"
		public static extern void PlayCinematic(string movieName);
		/// @CSharpLua.Template = "ForceUIKey({0})"
		public static extern void ForceUIKey(string key);
		/// @CSharpLua.Template = "ForceUICancel()"
		public static extern void ForceUICancel();
		/// @CSharpLua.Template = "DisplayLoadDialog()"
		public static extern void DisplayLoadDialog();
		/// @CSharpLua.Template = "SetAltMinimapIcon({0})"
		public static extern void SetAltMinimapIcon(string iconPath);
		/// @CSharpLua.Template = "DisableRestartMission({0})"
		public static extern void DisableRestartMission(bool flag);
		/// @CSharpLua.Template = "CreateTextTag()"
		public static extern texttag CreateTextTag();
		/// @CSharpLua.Template = "DestroyTextTag({0})"
		public static extern void DestroyTextTag(texttag t);
		/// @CSharpLua.Template = "SetTextTagText({0}, {1}, {2})"
		public static extern void SetTextTagText(texttag t, string s, float height);
		/// @CSharpLua.Template = "SetTextTagPos({0}, {1}, {2}, {3})"
		public static extern void SetTextTagPos(texttag t, float x, float y, float heightOffset);
		/// @CSharpLua.Template = "SetTextTagPosUnit({0}, {1}, {2})"
		public static extern void SetTextTagPosUnit(texttag t, unit whichUnit, float heightOffset);
		/// @CSharpLua.Template = "SetTextTagColor({0}, {1}, {2}, {3}, {4})"
		public static extern void SetTextTagColor(texttag t, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "SetTextTagVelocity({0}, {1}, {2})"
		public static extern void SetTextTagVelocity(texttag t, float xvel, float yvel);
		/// @CSharpLua.Template = "SetTextTagVisibility({0}, {1})"
		public static extern void SetTextTagVisibility(texttag t, bool flag);
		/// @CSharpLua.Template = "SetTextTagSuspended({0}, {1})"
		public static extern void SetTextTagSuspended(texttag t, bool flag);
		/// @CSharpLua.Template = "SetTextTagPermanent({0}, {1})"
		public static extern void SetTextTagPermanent(texttag t, bool flag);
		/// @CSharpLua.Template = "SetTextTagAge({0}, {1})"
		public static extern void SetTextTagAge(texttag t, float age);
		/// @CSharpLua.Template = "SetTextTagLifespan({0}, {1})"
		public static extern void SetTextTagLifespan(texttag t, float lifespan);
		/// @CSharpLua.Template = "SetTextTagFadepoint({0}, {1})"
		public static extern void SetTextTagFadepoint(texttag t, float fadepoint);
		/// @CSharpLua.Template = "SetReservedLocalHeroButtons({0})"
		public static extern void SetReservedLocalHeroButtons(int reserved);
		/// @CSharpLua.Template = "GetAllyColorFilterState()"
		public static extern int GetAllyColorFilterState();
		/// @CSharpLua.Template = "SetAllyColorFilterState({0})"
		public static extern void SetAllyColorFilterState(int state);
		/// @CSharpLua.Template = "GetCreepCampFilterState()"
		public static extern bool GetCreepCampFilterState();
		/// @CSharpLua.Template = "SetCreepCampFilterState({0})"
		public static extern void SetCreepCampFilterState(bool state);
		/// @CSharpLua.Template = "EnableMinimapFilterButtons({0}, {1})"
		public static extern void EnableMinimapFilterButtons(bool enableAlly, bool enableCreep);
		/// @CSharpLua.Template = "EnableDragSelect({0}, {1})"
		public static extern void EnableDragSelect(bool state, bool ui);
		/// @CSharpLua.Template = "EnablePreSelect({0}, {1})"
		public static extern void EnablePreSelect(bool state, bool ui);
		/// @CSharpLua.Template = "EnableSelect({0}, {1})"
		public static extern void EnableSelect(bool state, bool ui);
		/// @CSharpLua.Template = "CreateTrackable({0}, {1}, {2}, {3})"
		public static extern trackable CreateTrackable(string trackableModelPath, float x, float y, float facing);
		/// @CSharpLua.Template = "CreateQuest()"
		public static extern quest CreateQuest();
		/// @CSharpLua.Template = "DestroyQuest({0})"
		public static extern void DestroyQuest(quest whichQuest);
		/// @CSharpLua.Template = "QuestSetTitle({0}, {1})"
		public static extern void QuestSetTitle(quest whichQuest, string title);
		/// @CSharpLua.Template = "QuestSetDescription({0}, {1})"
		public static extern void QuestSetDescription(quest whichQuest, string description);
		/// @CSharpLua.Template = "QuestSetIconPath({0}, {1})"
		public static extern void QuestSetIconPath(quest whichQuest, string iconPath);
		/// @CSharpLua.Template = "QuestSetRequired({0}, {1})"
		public static extern void QuestSetRequired(quest whichQuest, bool required);
		/// @CSharpLua.Template = "QuestSetCompleted({0}, {1})"
		public static extern void QuestSetCompleted(quest whichQuest, bool completed);
		/// @CSharpLua.Template = "QuestSetDiscovered({0}, {1})"
		public static extern void QuestSetDiscovered(quest whichQuest, bool discovered);
		/// @CSharpLua.Template = "QuestSetFailed({0}, {1})"
		public static extern void QuestSetFailed(quest whichQuest, bool failed);
		/// @CSharpLua.Template = "QuestSetEnabled({0}, {1})"
		public static extern void QuestSetEnabled(quest whichQuest, bool enabled);
		/// @CSharpLua.Template = "IsQuestRequired({0})"
		public static extern bool IsQuestRequired(quest whichQuest);
		/// @CSharpLua.Template = "IsQuestCompleted({0})"
		public static extern bool IsQuestCompleted(quest whichQuest);
		/// @CSharpLua.Template = "IsQuestDiscovered({0})"
		public static extern bool IsQuestDiscovered(quest whichQuest);
		/// @CSharpLua.Template = "IsQuestFailed({0})"
		public static extern bool IsQuestFailed(quest whichQuest);
		/// @CSharpLua.Template = "IsQuestEnabled({0})"
		public static extern bool IsQuestEnabled(quest whichQuest);
		/// @CSharpLua.Template = "QuestCreateItem({0})"
		public static extern questitem QuestCreateItem(quest whichQuest);
		/// @CSharpLua.Template = "QuestItemSetDescription({0}, {1})"
		public static extern void QuestItemSetDescription(questitem whichQuestItem, string description);
		/// @CSharpLua.Template = "QuestItemSetCompleted({0}, {1})"
		public static extern void QuestItemSetCompleted(questitem whichQuestItem, bool completed);
		/// @CSharpLua.Template = "IsQuestItemCompleted({0})"
		public static extern bool IsQuestItemCompleted(questitem whichQuestItem);
		/// @CSharpLua.Template = "CreateDefeatCondition()"
		public static extern defeatcondition CreateDefeatCondition();
		/// @CSharpLua.Template = "DestroyDefeatCondition({0})"
		public static extern void DestroyDefeatCondition(defeatcondition whichCondition);
		/// @CSharpLua.Template = "DefeatConditionSetDescription({0}, {1})"
		public static extern void DefeatConditionSetDescription(defeatcondition whichCondition, string description);
		/// @CSharpLua.Template = "FlashQuestDialogButton()"
		public static extern void FlashQuestDialogButton();
		/// @CSharpLua.Template = "ForceQuestDialogUpdate()"
		public static extern void ForceQuestDialogUpdate();
		/// @CSharpLua.Template = "CreateTimerDialog({0})"
		public static extern timerdialog CreateTimerDialog(timer t);
		/// @CSharpLua.Template = "DestroyTimerDialog({0})"
		public static extern void DestroyTimerDialog(timerdialog whichDialog);
		/// @CSharpLua.Template = "TimerDialogSetTitle({0}, {1})"
		public static extern void TimerDialogSetTitle(timerdialog whichDialog, string title);
		/// @CSharpLua.Template = "TimerDialogSetTitleColor({0}, {1}, {2}, {3}, {4})"
		public static extern void TimerDialogSetTitleColor(timerdialog whichDialog, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "TimerDialogSetTimeColor({0}, {1}, {2}, {3}, {4})"
		public static extern void TimerDialogSetTimeColor(timerdialog whichDialog, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "TimerDialogSetSpeed({0}, {1})"
		public static extern void TimerDialogSetSpeed(timerdialog whichDialog, float speedMultFactor);
		/// @CSharpLua.Template = "TimerDialogDisplay({0}, {1})"
		public static extern void TimerDialogDisplay(timerdialog whichDialog, bool display);
		/// @CSharpLua.Template = "IsTimerDialogDisplayed({0})"
		public static extern bool IsTimerDialogDisplayed(timerdialog whichDialog);
		/// @CSharpLua.Template = "TimerDialogSetRealTimeRemaining({0}, {1})"
		public static extern void TimerDialogSetRealTimeRemaining(timerdialog whichDialog, float timeRemaining);
		/// @CSharpLua.Template = "CreateLeaderboard()"
		public static extern leaderboard CreateLeaderboard();
		/// @CSharpLua.Template = "DestroyLeaderboard({0})"
		public static extern void DestroyLeaderboard(leaderboard lb);
		/// @CSharpLua.Template = "LeaderboardDisplay({0}, {1})"
		public static extern void LeaderboardDisplay(leaderboard lb, bool show);
		/// @CSharpLua.Template = "IsLeaderboardDisplayed({0})"
		public static extern bool IsLeaderboardDisplayed(leaderboard lb);
		/// @CSharpLua.Template = "LeaderboardGetItemCount({0})"
		public static extern int LeaderboardGetItemCount(leaderboard lb);
		/// @CSharpLua.Template = "LeaderboardSetSizeByItemCount({0}, {1})"
		public static extern void LeaderboardSetSizeByItemCount(leaderboard lb, int count);
		/// @CSharpLua.Template = "LeaderboardAddItem({0}, {1}, {2}, {3})"
		public static extern void LeaderboardAddItem(leaderboard lb, string label, int value, player p);
		/// @CSharpLua.Template = "LeaderboardRemoveItem({0}, {1})"
		public static extern void LeaderboardRemoveItem(leaderboard lb, int index);
		/// @CSharpLua.Template = "LeaderboardRemovePlayerItem({0}, {1})"
		public static extern void LeaderboardRemovePlayerItem(leaderboard lb, player p);
		/// @CSharpLua.Template = "LeaderboardClear({0})"
		public static extern void LeaderboardClear(leaderboard lb);
		/// @CSharpLua.Template = "LeaderboardSortItemsByValue({0}, {1})"
		public static extern void LeaderboardSortItemsByValue(leaderboard lb, bool ascending);
		/// @CSharpLua.Template = "LeaderboardSortItemsByPlayer({0}, {1})"
		public static extern void LeaderboardSortItemsByPlayer(leaderboard lb, bool ascending);
		/// @CSharpLua.Template = "LeaderboardSortItemsByLabel({0}, {1})"
		public static extern void LeaderboardSortItemsByLabel(leaderboard lb, bool ascending);
		/// @CSharpLua.Template = "LeaderboardHasPlayerItem({0}, {1})"
		public static extern bool LeaderboardHasPlayerItem(leaderboard lb, player p);
		/// @CSharpLua.Template = "LeaderboardGetPlayerIndex({0}, {1})"
		public static extern int LeaderboardGetPlayerIndex(leaderboard lb, player p);
		/// @CSharpLua.Template = "LeaderboardSetLabel({0}, {1})"
		public static extern void LeaderboardSetLabel(leaderboard lb, string label);
		/// @CSharpLua.Template = "LeaderboardGetLabelText({0})"
		public static extern string LeaderboardGetLabelText(leaderboard lb);
		/// @CSharpLua.Template = "PlayerSetLeaderboard({0}, {1})"
		public static extern void PlayerSetLeaderboard(player toPlayer, leaderboard lb);
		/// @CSharpLua.Template = "PlayerGetLeaderboard({0})"
		public static extern leaderboard PlayerGetLeaderboard(player toPlayer);
		/// @CSharpLua.Template = "LeaderboardSetLabelColor({0}, {1}, {2}, {3}, {4})"
		public static extern void LeaderboardSetLabelColor(leaderboard lb, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "LeaderboardSetValueColor({0}, {1}, {2}, {3}, {4})"
		public static extern void LeaderboardSetValueColor(leaderboard lb, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "LeaderboardSetStyle({0}, {1}, {2}, {3}, {4})"
		public static extern void LeaderboardSetStyle(leaderboard lb, bool showLabel, bool showNames, bool showValues, bool showIcons);
		/// @CSharpLua.Template = "LeaderboardSetItemValue({0}, {1}, {2})"
		public static extern void LeaderboardSetItemValue(leaderboard lb, int whichItem, int val);
		/// @CSharpLua.Template = "LeaderboardSetItemLabel({0}, {1}, {2})"
		public static extern void LeaderboardSetItemLabel(leaderboard lb, int whichItem, string val);
		/// @CSharpLua.Template = "LeaderboardSetItemStyle({0}, {1}, {2}, {3}, {4})"
		public static extern void LeaderboardSetItemStyle(leaderboard lb, int whichItem, bool showLabel, bool showValue, bool showIcon);
		/// @CSharpLua.Template = "LeaderboardSetItemLabelColor({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern void LeaderboardSetItemLabelColor(leaderboard lb, int whichItem, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "LeaderboardSetItemValueColor({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern void LeaderboardSetItemValueColor(leaderboard lb, int whichItem, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "CreateMultiboard()"
		public static extern multiboard CreateMultiboard();
		/// @CSharpLua.Template = "DestroyMultiboard({0})"
		public static extern void DestroyMultiboard(multiboard lb);
		/// @CSharpLua.Template = "MultiboardDisplay({0}, {1})"
		public static extern void MultiboardDisplay(multiboard lb, bool show);
		/// @CSharpLua.Template = "IsMultiboardDisplayed({0})"
		public static extern bool IsMultiboardDisplayed(multiboard lb);
		/// @CSharpLua.Template = "MultiboardMinimize({0}, {1})"
		public static extern void MultiboardMinimize(multiboard lb, bool minimize);
		/// @CSharpLua.Template = "IsMultiboardMinimized({0})"
		public static extern bool IsMultiboardMinimized(multiboard lb);
		/// @CSharpLua.Template = "MultiboardClear({0})"
		public static extern void MultiboardClear(multiboard lb);
		/// @CSharpLua.Template = "MultiboardSetTitleText({0}, {1})"
		public static extern void MultiboardSetTitleText(multiboard lb, string label);
		/// @CSharpLua.Template = "MultiboardGetTitleText({0})"
		public static extern string MultiboardGetTitleText(multiboard lb);
		/// @CSharpLua.Template = "MultiboardSetTitleTextColor({0}, {1}, {2}, {3}, {4})"
		public static extern void MultiboardSetTitleTextColor(multiboard lb, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "MultiboardGetRowCount({0})"
		public static extern int MultiboardGetRowCount(multiboard lb);
		/// @CSharpLua.Template = "MultiboardGetColumnCount({0})"
		public static extern int MultiboardGetColumnCount(multiboard lb);
		/// @CSharpLua.Template = "MultiboardSetColumnCount({0}, {1})"
		public static extern void MultiboardSetColumnCount(multiboard lb, int count);
		/// @CSharpLua.Template = "MultiboardSetRowCount({0}, {1})"
		public static extern void MultiboardSetRowCount(multiboard lb, int count);
		/// @CSharpLua.Template = "MultiboardSetItemsStyle({0}, {1}, {2})"
		public static extern void MultiboardSetItemsStyle(multiboard lb, bool showValues, bool showIcons);
		/// @CSharpLua.Template = "MultiboardSetItemsValue({0}, {1})"
		public static extern void MultiboardSetItemsValue(multiboard lb, string value);
		/// @CSharpLua.Template = "MultiboardSetItemsValueColor({0}, {1}, {2}, {3}, {4})"
		public static extern void MultiboardSetItemsValueColor(multiboard lb, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "MultiboardSetItemsWidth({0}, {1})"
		public static extern void MultiboardSetItemsWidth(multiboard lb, float width);
		/// @CSharpLua.Template = "MultiboardSetItemsIcon({0}, {1})"
		public static extern void MultiboardSetItemsIcon(multiboard lb, string iconPath);
		/// @CSharpLua.Template = "MultiboardGetItem({0}, {1}, {2})"
		public static extern multiboarditem MultiboardGetItem(multiboard lb, int row, int column);
		/// @CSharpLua.Template = "MultiboardReleaseItem({0})"
		public static extern void MultiboardReleaseItem(multiboarditem mbi);
		/// @CSharpLua.Template = "MultiboardSetItemStyle({0}, {1}, {2})"
		public static extern void MultiboardSetItemStyle(multiboarditem mbi, bool showValue, bool showIcon);
		/// @CSharpLua.Template = "MultiboardSetItemValue({0}, {1})"
		public static extern void MultiboardSetItemValue(multiboarditem mbi, string val);
		/// @CSharpLua.Template = "MultiboardSetItemValueColor({0}, {1}, {2}, {3}, {4})"
		public static extern void MultiboardSetItemValueColor(multiboarditem mbi, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "MultiboardSetItemWidth({0}, {1})"
		public static extern void MultiboardSetItemWidth(multiboarditem mbi, float width);
		/// @CSharpLua.Template = "MultiboardSetItemIcon({0}, {1})"
		public static extern void MultiboardSetItemIcon(multiboarditem mbi, string iconFileName);
		/// @CSharpLua.Template = "MultiboardSuppressDisplay({0})"
		public static extern void MultiboardSuppressDisplay(bool flag);
		/// @CSharpLua.Template = "SetCameraPosition({0}, {1})"
		public static extern void SetCameraPosition(float x, float y);
		/// @CSharpLua.Template = "SetCameraQuickPosition({0}, {1})"
		public static extern void SetCameraQuickPosition(float x, float y);
		/// @CSharpLua.Template = "SetCameraBounds({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern void SetCameraBounds(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4);
		/// @CSharpLua.Template = "StopCamera()"
		public static extern void StopCamera();
		/// @CSharpLua.Template = "ResetToGameCamera({0})"
		public static extern void ResetToGameCamera(float duration);
		/// @CSharpLua.Template = "PanCameraTo({0}, {1})"
		public static extern void PanCameraTo(float x, float y);
		/// @CSharpLua.Template = "PanCameraToTimed({0}, {1}, {2})"
		public static extern void PanCameraToTimed(float x, float y, float duration);
		/// @CSharpLua.Template = "PanCameraToWithZ({0}, {1}, {2})"
		public static extern void PanCameraToWithZ(float x, float y, float zOffsetDest);
		/// @CSharpLua.Template = "PanCameraToTimedWithZ({0}, {1}, {2}, {3})"
		public static extern void PanCameraToTimedWithZ(float x, float y, float zOffsetDest, float duration);
		/// @CSharpLua.Template = "SetCinematicCamera({0})"
		public static extern void SetCinematicCamera(string cameraModelFile);
		/// @CSharpLua.Template = "SetCameraRotateMode({0}, {1}, {2}, {3})"
		public static extern void SetCameraRotateMode(float x, float y, float radiansToSweep, float duration);
		/// @CSharpLua.Template = "SetCameraField({0}, {1}, {2})"
		public static extern void SetCameraField(camerafield whichField, float value, float duration);
		/// @CSharpLua.Template = "AdjustCameraField({0}, {1}, {2})"
		public static extern void AdjustCameraField(camerafield whichField, float offset, float duration);
		/// @CSharpLua.Template = "SetCameraTargetController({0}, {1}, {2}, {3})"
		public static extern void SetCameraTargetController(unit whichUnit, float xoffset, float yoffset, bool inheritOrientation);
		/// @CSharpLua.Template = "SetCameraOrientController({0}, {1}, {2})"
		public static extern void SetCameraOrientController(unit whichUnit, float xoffset, float yoffset);
		/// @CSharpLua.Template = "CreateCameraSetup()"
		public static extern camerasetup CreateCameraSetup();
		/// @CSharpLua.Template = "CameraSetupSetField({0}, {1}, {2}, {3})"
		public static extern void CameraSetupSetField(camerasetup whichSetup, camerafield whichField, float value, float duration);
		/// @CSharpLua.Template = "CameraSetupGetField({0}, {1})"
		public static extern float CameraSetupGetField(camerasetup whichSetup, camerafield whichField);
		/// @CSharpLua.Template = "CameraSetupSetDestPosition({0}, {1}, {2}, {3})"
		public static extern void CameraSetupSetDestPosition(camerasetup whichSetup, float x, float y, float duration);
		/// @CSharpLua.Template = "CameraSetupGetDestPositionLoc({0})"
		public static extern location CameraSetupGetDestPositionLoc(camerasetup whichSetup);
		/// @CSharpLua.Template = "CameraSetupGetDestPositionX({0})"
		public static extern float CameraSetupGetDestPositionX(camerasetup whichSetup);
		/// @CSharpLua.Template = "CameraSetupGetDestPositionY({0})"
		public static extern float CameraSetupGetDestPositionY(camerasetup whichSetup);
		/// @CSharpLua.Template = "CameraSetupApply({0}, {1}, {2})"
		public static extern void CameraSetupApply(camerasetup whichSetup, bool doPan, bool panTimed);
		/// @CSharpLua.Template = "CameraSetupApplyWithZ({0}, {1})"
		public static extern void CameraSetupApplyWithZ(camerasetup whichSetup, float zDestOffset);
		/// @CSharpLua.Template = "CameraSetupApplyForceDuration({0}, {1}, {2})"
		public static extern void CameraSetupApplyForceDuration(camerasetup whichSetup, bool doPan, float forceDuration);
		/// @CSharpLua.Template = "CameraSetupApplyForceDurationWithZ({0}, {1}, {2})"
		public static extern void CameraSetupApplyForceDurationWithZ(camerasetup whichSetup, float zDestOffset, float forceDuration);
		/// @CSharpLua.Template = "BlzCameraSetupSetLabel({0}, {1})"
		public static extern void BlzCameraSetupSetLabel(camerasetup whichSetup, string label);
		/// @CSharpLua.Template = "BlzCameraSetupGetLabel({0})"
		public static extern string BlzCameraSetupGetLabel(camerasetup whichSetup);
		/// @CSharpLua.Template = "CameraSetTargetNoise({0}, {1})"
		public static extern void CameraSetTargetNoise(float mag, float velocity);
		/// @CSharpLua.Template = "CameraSetSourceNoise({0}, {1})"
		public static extern void CameraSetSourceNoise(float mag, float velocity);
		/// @CSharpLua.Template = "CameraSetTargetNoiseEx({0}, {1}, {2})"
		public static extern void CameraSetTargetNoiseEx(float mag, float velocity, bool vertOnly);
		/// @CSharpLua.Template = "CameraSetSourceNoiseEx({0}, {1}, {2})"
		public static extern void CameraSetSourceNoiseEx(float mag, float velocity, bool vertOnly);
		/// @CSharpLua.Template = "CameraSetSmoothingFactor({0})"
		public static extern void CameraSetSmoothingFactor(float factor);
		/// @CSharpLua.Template = "CameraSetFocalDistance({0})"
		public static extern void CameraSetFocalDistance(float distance);
		/// @CSharpLua.Template = "CameraSetDepthOfFieldScale({0})"
		public static extern void CameraSetDepthOfFieldScale(float scale);
		/// @CSharpLua.Template = "SetCineFilterTexture({0})"
		public static extern void SetCineFilterTexture(string filename);
		/// @CSharpLua.Template = "SetCineFilterBlendMode({0})"
		public static extern void SetCineFilterBlendMode(blendmode whichMode);
		/// @CSharpLua.Template = "SetCineFilterTexMapFlags({0})"
		public static extern void SetCineFilterTexMapFlags(texmapflags whichFlags);
		/// @CSharpLua.Template = "SetCineFilterStartUV({0}, {1}, {2}, {3})"
		public static extern void SetCineFilterStartUV(float minu, float minv, float maxu, float maxv);
		/// @CSharpLua.Template = "SetCineFilterEndUV({0}, {1}, {2}, {3})"
		public static extern void SetCineFilterEndUV(float minu, float minv, float maxu, float maxv);
		/// @CSharpLua.Template = "SetCineFilterStartColor({0}, {1}, {2}, {3})"
		public static extern void SetCineFilterStartColor(int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "SetCineFilterEndColor({0}, {1}, {2}, {3})"
		public static extern void SetCineFilterEndColor(int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "SetCineFilterDuration({0})"
		public static extern void SetCineFilterDuration(float duration);
		/// @CSharpLua.Template = "DisplayCineFilter({0})"
		public static extern void DisplayCineFilter(bool flag);
		/// @CSharpLua.Template = "IsCineFilterDisplayed()"
		public static extern bool IsCineFilterDisplayed();
		/// @CSharpLua.Template = "SetCinematicScene({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern void SetCinematicScene(int portraitUnitId, playercolor color, string speakerTitle, string text, float sceneDuration, float voiceoverDuration);
		/// @CSharpLua.Template = "EndCinematicScene()"
		public static extern void EndCinematicScene();
		/// @CSharpLua.Template = "ForceCinematicSubtitles({0})"
		public static extern void ForceCinematicSubtitles(bool flag);
		/// @CSharpLua.Template = "SetCinematicAudio({0})"
		public static extern void SetCinematicAudio(bool cinematicAudio);
		/// @CSharpLua.Template = "GetCameraMargin({0})"
		public static extern float GetCameraMargin(int whichMargin);
		/// @CSharpLua.Template = "GetCameraBoundMinX()"
		public static extern float GetCameraBoundMinX();
		/// @CSharpLua.Template = "GetCameraBoundMinY()"
		public static extern float GetCameraBoundMinY();
		/// @CSharpLua.Template = "GetCameraBoundMaxX()"
		public static extern float GetCameraBoundMaxX();
		/// @CSharpLua.Template = "GetCameraBoundMaxY()"
		public static extern float GetCameraBoundMaxY();
		/// @CSharpLua.Template = "GetCameraField({0})"
		public static extern float GetCameraField(camerafield whichField);
		/// @CSharpLua.Template = "GetCameraTargetPositionX()"
		public static extern float GetCameraTargetPositionX();
		/// @CSharpLua.Template = "GetCameraTargetPositionY()"
		public static extern float GetCameraTargetPositionY();
		/// @CSharpLua.Template = "GetCameraTargetPositionZ()"
		public static extern float GetCameraTargetPositionZ();
		/// @CSharpLua.Template = "GetCameraTargetPositionLoc()"
		public static extern location GetCameraTargetPositionLoc();
		/// @CSharpLua.Template = "GetCameraEyePositionX()"
		public static extern float GetCameraEyePositionX();
		/// @CSharpLua.Template = "GetCameraEyePositionY()"
		public static extern float GetCameraEyePositionY();
		/// @CSharpLua.Template = "GetCameraEyePositionZ()"
		public static extern float GetCameraEyePositionZ();
		/// @CSharpLua.Template = "GetCameraEyePositionLoc()"
		public static extern location GetCameraEyePositionLoc();
		/// @CSharpLua.Template = "NewSoundEnvironment({0})"
		public static extern void NewSoundEnvironment(string environmentName);
		/// @CSharpLua.Template = "CreateSound({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern sound CreateSound(string fileName, bool looping, bool is3D, bool stopwhenoutofrange, int fadeInRate, int fadeOutRate, string eaxSetting);
		/// @CSharpLua.Template = "CreateSoundFilenameWithLabel({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern sound CreateSoundFilenameWithLabel(string fileName, bool looping, bool is3D, bool stopwhenoutofrange, int fadeInRate, int fadeOutRate, string SLKEntryName);
		/// @CSharpLua.Template = "CreateSoundFromLabel({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern sound CreateSoundFromLabel(string soundLabel, bool looping, bool is3D, bool stopwhenoutofrange, int fadeInRate, int fadeOutRate);
		/// @CSharpLua.Template = "CreateMIDISound({0}, {1}, {2})"
		public static extern sound CreateMIDISound(string soundLabel, int fadeInRate, int fadeOutRate);
		/// @CSharpLua.Template = "SetSoundParamsFromLabel({0}, {1})"
		public static extern void SetSoundParamsFromLabel(sound soundHandle, string soundLabel);
		/// @CSharpLua.Template = "SetSoundDistanceCutoff({0}, {1})"
		public static extern void SetSoundDistanceCutoff(sound soundHandle, float cutoff);
		/// @CSharpLua.Template = "SetSoundChannel({0}, {1})"
		public static extern void SetSoundChannel(sound soundHandle, int channel);
		/// @CSharpLua.Template = "SetSoundVolume({0}, {1})"
		public static extern void SetSoundVolume(sound soundHandle, int volume);
		/// @CSharpLua.Template = "SetSoundPitch({0}, {1})"
		public static extern void SetSoundPitch(sound soundHandle, float pitch);
		/// @CSharpLua.Template = "SetSoundPlayPosition({0}, {1})"
		public static extern void SetSoundPlayPosition(sound soundHandle, int millisecs);
		/// @CSharpLua.Template = "SetSoundDistances({0}, {1}, {2})"
		public static extern void SetSoundDistances(sound soundHandle, float minDist, float maxDist);
		/// @CSharpLua.Template = "SetSoundConeAngles({0}, {1}, {2}, {3})"
		public static extern void SetSoundConeAngles(sound soundHandle, float inside, float outside, int outsideVolume);
		/// @CSharpLua.Template = "SetSoundConeOrientation({0}, {1}, {2}, {3})"
		public static extern void SetSoundConeOrientation(sound soundHandle, float x, float y, float z);
		/// @CSharpLua.Template = "SetSoundPosition({0}, {1}, {2}, {3})"
		public static extern void SetSoundPosition(sound soundHandle, float x, float y, float z);
		/// @CSharpLua.Template = "SetSoundVelocity({0}, {1}, {2}, {3})"
		public static extern void SetSoundVelocity(sound soundHandle, float x, float y, float z);
		/// @CSharpLua.Template = "AttachSoundToUnit({0}, {1})"
		public static extern void AttachSoundToUnit(sound soundHandle, unit whichUnit);
		/// @CSharpLua.Template = "StartSound({0})"
		public static extern void StartSound(sound soundHandle);
		/// @CSharpLua.Template = "StartSoundEx({0}, {1})"
		public static extern void StartSoundEx(sound soundHandle, bool fadeIn);
		/// @CSharpLua.Template = "StopSound({0}, {1}, {2})"
		public static extern void StopSound(sound soundHandle, bool killWhenDone, bool fadeOut);
		/// @CSharpLua.Template = "KillSoundWhenDone({0})"
		public static extern void KillSoundWhenDone(sound soundHandle);
		/// @CSharpLua.Template = "SetMapMusic({0}, {1}, {2})"
		public static extern void SetMapMusic(string musicName, bool random, int index);
		/// @CSharpLua.Template = "ClearMapMusic()"
		public static extern void ClearMapMusic();
		/// @CSharpLua.Template = "PlayMusic({0})"
		public static extern void PlayMusic(string musicName);
		/// @CSharpLua.Template = "PlayMusicEx({0}, {1}, {2})"
		public static extern void PlayMusicEx(string musicName, int frommsecs, int fadeinmsecs);
		/// @CSharpLua.Template = "StopMusic({0})"
		public static extern void StopMusic(bool fadeOut);
		/// @CSharpLua.Template = "ResumeMusic()"
		public static extern void ResumeMusic();
		/// @CSharpLua.Template = "PlayThematicMusic({0})"
		public static extern void PlayThematicMusic(string musicFileName);
		/// @CSharpLua.Template = "PlayThematicMusicEx({0}, {1})"
		public static extern void PlayThematicMusicEx(string musicFileName, int frommsecs);
		/// @CSharpLua.Template = "EndThematicMusic()"
		public static extern void EndThematicMusic();
		/// @CSharpLua.Template = "SetMusicVolume({0})"
		public static extern void SetMusicVolume(int volume);
		/// @CSharpLua.Template = "SetMusicPlayPosition({0})"
		public static extern void SetMusicPlayPosition(int millisecs);
		/// @CSharpLua.Template = "SetThematicMusicVolume({0})"
		public static extern void SetThematicMusicVolume(int volume);
		/// @CSharpLua.Template = "SetThematicMusicPlayPosition({0})"
		public static extern void SetThematicMusicPlayPosition(int millisecs);
		/// @CSharpLua.Template = "SetSoundDuration({0}, {1})"
		public static extern void SetSoundDuration(sound soundHandle, int duration);
		/// @CSharpLua.Template = "GetSoundDuration({0})"
		public static extern int GetSoundDuration(sound soundHandle);
		/// @CSharpLua.Template = "GetSoundFileDuration({0})"
		public static extern int GetSoundFileDuration(string musicFileName);
		/// @CSharpLua.Template = "VolumeGroupSetVolume({0}, {1})"
		public static extern void VolumeGroupSetVolume(volumegroup vgroup, float scale);
		/// @CSharpLua.Template = "VolumeGroupReset()"
		public static extern void VolumeGroupReset();
		/// @CSharpLua.Template = "GetSoundIsPlaying({0})"
		public static extern bool GetSoundIsPlaying(sound soundHandle);
		/// @CSharpLua.Template = "GetSoundIsLoading({0})"
		public static extern bool GetSoundIsLoading(sound soundHandle);
		/// @CSharpLua.Template = "RegisterStackedSound({0}, {1}, {2}, {3})"
		public static extern void RegisterStackedSound(sound soundHandle, bool byPosition, float rectwidth, float rectheight);
		/// @CSharpLua.Template = "UnregisterStackedSound({0}, {1}, {2}, {3})"
		public static extern void UnregisterStackedSound(sound soundHandle, bool byPosition, float rectwidth, float rectheight);
		/// @CSharpLua.Template = "SetSoundFacialAnimationLabel({0}, {1})"
		public static extern bool SetSoundFacialAnimationLabel(sound soundHandle, string animationLabel);
		/// @CSharpLua.Template = "SetSoundFacialAnimationGroupLabel({0}, {1})"
		public static extern bool SetSoundFacialAnimationGroupLabel(sound soundHandle, string groupLabel);
		/// @CSharpLua.Template = "SetSoundFacialAnimationSetFilepath({0}, {1})"
		public static extern bool SetSoundFacialAnimationSetFilepath(sound soundHandle, string animationSetFilepath);
		/// @CSharpLua.Template = "SetDialogueSpeakerNameKey({0}, {1})"
		public static extern bool SetDialogueSpeakerNameKey(sound soundHandle, string speakerName);
		/// @CSharpLua.Template = "GetDialogueSpeakerNameKey({0})"
		public static extern string GetDialogueSpeakerNameKey(sound soundHandle);
		/// @CSharpLua.Template = "SetDialogueTextKey({0}, {1})"
		public static extern bool SetDialogueTextKey(sound soundHandle, string dialogueText);
		/// @CSharpLua.Template = "GetDialogueTextKey({0})"
		public static extern string GetDialogueTextKey(sound soundHandle);
		/// @CSharpLua.Template = "AddWeatherEffect({0}, {1})"
		public static extern weathereffect AddWeatherEffect(rect where, int effectID);
		/// @CSharpLua.Template = "RemoveWeatherEffect({0})"
		public static extern void RemoveWeatherEffect(weathereffect whichEffect);
		/// @CSharpLua.Template = "EnableWeatherEffect({0}, {1})"
		public static extern void EnableWeatherEffect(weathereffect whichEffect, bool enable);
		/// @CSharpLua.Template = "TerrainDeformCrater({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern terraindeformation TerrainDeformCrater(float x, float y, float radius, float depth, int duration, bool permanent);
		/// @CSharpLua.Template = "TerrainDeformRipple({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})"
		public static extern terraindeformation TerrainDeformRipple(float x, float y, float radius, float depth, int duration, int count, float spaceWaves, float timeWaves, float radiusStartPct, bool limitNeg);
		/// @CSharpLua.Template = "TerrainDeformWave({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})"
		public static extern terraindeformation TerrainDeformWave(float x, float y, float dirX, float dirY, float distance, float speed, float radius, float depth, int trailTime, int count);
		/// @CSharpLua.Template = "TerrainDeformRandom({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern terraindeformation TerrainDeformRandom(float x, float y, float radius, float minDelta, float maxDelta, int duration, int updateInterval);
		/// @CSharpLua.Template = "TerrainDeformStop({0}, {1})"
		public static extern void TerrainDeformStop(terraindeformation deformation, int duration);
		/// @CSharpLua.Template = "TerrainDeformStopAll()"
		public static extern void TerrainDeformStopAll();
		/// @CSharpLua.Template = "AddSpecialEffect({0}, {1}, {2})"
		public static extern effect AddSpecialEffect(string modelName, float x, float y);
		/// @CSharpLua.Template = "AddSpecialEffectLoc({0}, {1})"
		public static extern effect AddSpecialEffectLoc(string modelName, location where);
		/// @CSharpLua.Template = "AddSpecialEffectTarget({0}, {1}, {2})"
		public static extern effect AddSpecialEffectTarget(string modelName, widget targetWidget, string attachPointName);
		/// @CSharpLua.Template = "DestroyEffect({0})"
		public static extern void DestroyEffect(effect whichEffect);
		/// @CSharpLua.Template = "AddSpellEffect({0}, {1}, {2}, {3})"
		public static extern effect AddSpellEffect(string abilityString, effecttype t, float x, float y);
		/// @CSharpLua.Template = "AddSpellEffectLoc({0}, {1}, {2})"
		public static extern effect AddSpellEffectLoc(string abilityString, effecttype t, location where);
		/// @CSharpLua.Template = "AddSpellEffectById({0}, {1}, {2}, {3})"
		public static extern effect AddSpellEffectById(int abilityId, effecttype t, float x, float y);
		/// @CSharpLua.Template = "AddSpellEffectByIdLoc({0}, {1}, {2})"
		public static extern effect AddSpellEffectByIdLoc(int abilityId, effecttype t, location where);
		/// @CSharpLua.Template = "AddSpellEffectTarget({0}, {1}, {2}, {3})"
		public static extern effect AddSpellEffectTarget(string modelName, effecttype t, widget targetWidget, string attachPoint);
		/// @CSharpLua.Template = "AddSpellEffectTargetById({0}, {1}, {2}, {3})"
		public static extern effect AddSpellEffectTargetById(int abilityId, effecttype t, widget targetWidget, string attachPoint);
		/// @CSharpLua.Template = "AddLightning({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern lightning AddLightning(string codeName, bool checkVisibility, float x1, float y1, float x2, float y2);
		/// @CSharpLua.Template = "AddLightningEx({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern lightning AddLightningEx(string codeName, bool checkVisibility, float x1, float y1, float z1, float x2, float y2, float z2);
		/// @CSharpLua.Template = "DestroyLightning({0})"
		public static extern bool DestroyLightning(lightning whichBolt);
		/// @CSharpLua.Template = "MoveLightning({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern bool MoveLightning(lightning whichBolt, bool checkVisibility, float x1, float y1, float x2, float y2);
		/// @CSharpLua.Template = "MoveLightningEx({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern bool MoveLightningEx(lightning whichBolt, bool checkVisibility, float x1, float y1, float z1, float x2, float y2, float z2);
		/// @CSharpLua.Template = "GetLightningColorA({0})"
		public static extern float GetLightningColorA(lightning whichBolt);
		/// @CSharpLua.Template = "GetLightningColorR({0})"
		public static extern float GetLightningColorR(lightning whichBolt);
		/// @CSharpLua.Template = "GetLightningColorG({0})"
		public static extern float GetLightningColorG(lightning whichBolt);
		/// @CSharpLua.Template = "GetLightningColorB({0})"
		public static extern float GetLightningColorB(lightning whichBolt);
		/// @CSharpLua.Template = "SetLightningColor({0}, {1}, {2}, {3}, {4})"
		public static extern bool SetLightningColor(lightning whichBolt, float r, float g, float b, float a);
		/// @CSharpLua.Template = "GetAbilityEffect({0}, {1}, {2})"
		public static extern string GetAbilityEffect(string abilityString, effecttype t, int index);
		/// @CSharpLua.Template = "GetAbilityEffectById({0}, {1}, {2})"
		public static extern string GetAbilityEffectById(int abilityId, effecttype t, int index);
		/// @CSharpLua.Template = "GetAbilitySound({0}, {1})"
		public static extern string GetAbilitySound(string abilityString, soundtype t);
		/// @CSharpLua.Template = "GetAbilitySoundById({0}, {1})"
		public static extern string GetAbilitySoundById(int abilityId, soundtype t);
		/// @CSharpLua.Template = "GetTerrainCliffLevel({0}, {1})"
		public static extern int GetTerrainCliffLevel(float x, float y);
		/// @CSharpLua.Template = "SetWaterBaseColor({0}, {1}, {2}, {3})"
		public static extern void SetWaterBaseColor(int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "SetWaterDeforms({0})"
		public static extern void SetWaterDeforms(bool val);
		/// @CSharpLua.Template = "GetTerrainType({0}, {1})"
		public static extern int GetTerrainType(float x, float y);
		/// @CSharpLua.Template = "GetTerrainVariance({0}, {1})"
		public static extern int GetTerrainVariance(float x, float y);
		/// @CSharpLua.Template = "SetTerrainType({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern void SetTerrainType(float x, float y, int terrainType, int variation, int area, int shape);
		/// @CSharpLua.Template = "IsTerrainPathable({0}, {1}, {2})"
		public static extern bool IsTerrainPathable(float x, float y, pathingtype t);
		/// @CSharpLua.Template = "SetTerrainPathable({0}, {1}, {2}, {3})"
		public static extern void SetTerrainPathable(float x, float y, pathingtype t, bool flag);
		/// @CSharpLua.Template = "CreateImage({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})"
		public static extern image CreateImage(string file, float sizeX, float sizeY, float sizeZ, float posX, float posY, float posZ, float originX, float originY, float originZ, ImageType imageType);
		/// @CSharpLua.Template = "DestroyImage({0})"
		public static extern void DestroyImage(image whichImage);
		/// @CSharpLua.Template = "ShowImage({0}, {1})"
		public static extern void ShowImage(image whichImage, bool flag);
		/// @CSharpLua.Template = "SetImageConstantHeight({0}, {1}, {2})"
		public static extern void SetImageConstantHeight(image whichImage, bool flag, float height);
		/// @CSharpLua.Template = "SetImagePosition({0}, {1}, {2}, {3})"
		public static extern void SetImagePosition(image whichImage, float x, float y, float z);
		/// @CSharpLua.Template = "SetImageColor({0}, {1}, {2}, {3}, {4})"
		public static extern void SetImageColor(image whichImage, int red, int green, int blue, int alpha);
		/// @CSharpLua.Template = "SetImageRender({0}, {1})"
		public static extern void SetImageRender(image whichImage, bool flag);
		/// @CSharpLua.Template = "SetImageRenderAlways({0}, {1})"
		public static extern void SetImageRenderAlways(image whichImage, bool flag);
		/// @CSharpLua.Template = "SetImageAboveWater({0}, {1}, {2})"
		public static extern void SetImageAboveWater(image whichImage, bool flag, bool useWaterAlpha);
		/// @CSharpLua.Template = "SetImageType({0}, {1})"
		public static extern void SetImageType(image whichImage, ImageType imageType);
		/// @CSharpLua.Template = "CreateUbersplat({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})"
		public static extern ubersplat CreateUbersplat(float x, float y, string name, int red, int green, int blue, int alpha, bool forcePaused, bool noBirthTime);
		/// @CSharpLua.Template = "DestroyUbersplat({0})"
		public static extern void DestroyUbersplat(ubersplat whichSplat);
		/// @CSharpLua.Template = "ResetUbersplat({0})"
		public static extern void ResetUbersplat(ubersplat whichSplat);
		/// @CSharpLua.Template = "FinishUbersplat({0})"
		public static extern void FinishUbersplat(ubersplat whichSplat);
		/// @CSharpLua.Template = "ShowUbersplat({0}, {1})"
		public static extern void ShowUbersplat(ubersplat whichSplat, bool flag);
		/// @CSharpLua.Template = "SetUbersplatRender({0}, {1})"
		public static extern void SetUbersplatRender(ubersplat whichSplat, bool flag);
		/// @CSharpLua.Template = "SetUbersplatRenderAlways({0}, {1})"
		public static extern void SetUbersplatRenderAlways(ubersplat whichSplat, bool flag);
		/// @CSharpLua.Template = "SetBlight({0}, {1}, {2}, {3}, {4})"
		public static extern void SetBlight(player whichPlayer, float x, float y, float radius, bool addBlight);
		/// @CSharpLua.Template = "SetBlightRect({0}, {1}, {2})"
		public static extern void SetBlightRect(player whichPlayer, rect r, bool addBlight);
		/// @CSharpLua.Template = "SetBlightPoint({0}, {1}, {2}, {3})"
		public static extern void SetBlightPoint(player whichPlayer, float x, float y, bool addBlight);
		/// @CSharpLua.Template = "SetBlightLoc({0}, {1}, {2}, {3})"
		public static extern void SetBlightLoc(player whichPlayer, location whichLocation, float radius, bool addBlight);
		/// @CSharpLua.Template = "CreateBlightedGoldmine({0}, {1}, {2}, {3})"
		public static extern unit CreateBlightedGoldmine(player id, float x, float y, float face);
		/// @CSharpLua.Template = "IsPointBlighted({0}, {1})"
		public static extern bool IsPointBlighted(float x, float y);
		/// @CSharpLua.Template = "SetDoodadAnimation({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern void SetDoodadAnimation(float x, float y, float radius, int doodadID, bool nearestOnly, string animName, bool animRandom);
		/// @CSharpLua.Template = "SetDoodadAnimationRect({0}, {1}, {2}, {3})"
		public static extern void SetDoodadAnimationRect(rect r, int doodadID, string animName, bool animRandom);
		/// @CSharpLua.Template = "StartMeleeAI({0}, {1})"
		public static extern void StartMeleeAI(player num, string script);
		/// @CSharpLua.Template = "StartCampaignAI({0}, {1})"
		public static extern void StartCampaignAI(player num, string script);
		/// @CSharpLua.Template = "CommandAI({0}, {1}, {2})"
		public static extern void CommandAI(player num, int command, int data);
		/// @CSharpLua.Template = "PauseCompAI({0}, {1})"
		public static extern void PauseCompAI(player p, bool pause);
		/// @CSharpLua.Template = "GetAIDifficulty({0})"
		public static extern aidifficulty GetAIDifficulty(player num);
		/// @CSharpLua.Template = "RemoveGuardPosition({0})"
		public static extern void RemoveGuardPosition(unit hUnit);
		/// @CSharpLua.Template = "RecycleGuardPosition({0})"
		public static extern void RecycleGuardPosition(unit hUnit);
		/// @CSharpLua.Template = "RemoveAllGuardPositions({0})"
		public static extern void RemoveAllGuardPositions(player num);
		/// @CSharpLua.Template = "Cheat({0})"
		public static extern void Cheat(string cheatStr);
		/// @CSharpLua.Template = "IsNoVictoryCheat()"
		public static extern bool IsNoVictoryCheat();
		/// @CSharpLua.Template = "IsNoDefeatCheat()"
		public static extern bool IsNoDefeatCheat();
		/// @CSharpLua.Template = "Preload({0})"
		public static extern void Preload(string filename);
		/// @CSharpLua.Template = "PreloadEnd({0})"
		public static extern void PreloadEnd(float timeout);
		/// @CSharpLua.Template = "PreloadStart()"
		public static extern void PreloadStart();
		/// @CSharpLua.Template = "PreloadRefresh()"
		public static extern void PreloadRefresh();
		/// @CSharpLua.Template = "PreloadEndEx()"
		public static extern void PreloadEndEx();
		/// @CSharpLua.Template = "PreloadGenClear()"
		public static extern void PreloadGenClear();
		/// @CSharpLua.Template = "PreloadGenStart()"
		public static extern void PreloadGenStart();
		/// @CSharpLua.Template = "PreloadGenEnd({0})"
		public static extern void PreloadGenEnd(string filename);
		/// @CSharpLua.Template = "Preloader({0})"
		public static extern void Preloader(string filename);
		/// @CSharpLua.Template = "BlzHideCinematicPanels({0})"
		public static extern void BlzHideCinematicPanels(bool enable);
		/// @CSharpLua.Template = "AutomationSetTestType({0})"
		public static extern void AutomationSetTestType(string testType);
		/// @CSharpLua.Template = "AutomationTestStart({0})"
		public static extern void AutomationTestStart(string testName);
		/// @CSharpLua.Template = "AutomationTestEnd()"
		public static extern void AutomationTestEnd();
		/// @CSharpLua.Template = "AutomationTestingFinished()"
		public static extern void AutomationTestingFinished();
		/// @CSharpLua.Template = "BlzGetTriggerPlayerMouseX()"
		public static extern float BlzGetTriggerPlayerMouseX();
		/// @CSharpLua.Template = "BlzGetTriggerPlayerMouseY()"
		public static extern float BlzGetTriggerPlayerMouseY();
		/// @CSharpLua.Template = "BlzGetTriggerPlayerMousePosition()"
		public static extern location BlzGetTriggerPlayerMousePosition();
		/// @CSharpLua.Template = "BlzGetTriggerPlayerMouseButton()"
		public static extern mousebuttontype BlzGetTriggerPlayerMouseButton();
		/// @CSharpLua.Template = "BlzSetAbilityTooltip({0}, {1}, {2})"
		public static extern void BlzSetAbilityTooltip(int abilCode, string tooltip, int level);
		/// @CSharpLua.Template = "BlzSetAbilityActivatedTooltip({0}, {1}, {2})"
		public static extern void BlzSetAbilityActivatedTooltip(int abilCode, string tooltip, int level);
		/// @CSharpLua.Template = "BlzSetAbilityExtendedTooltip({0}, {1}, {2})"
		public static extern void BlzSetAbilityExtendedTooltip(int abilCode, string extendedTooltip, int level);
		/// @CSharpLua.Template = "BlzSetAbilityActivatedExtendedTooltip({0}, {1}, {2})"
		public static extern void BlzSetAbilityActivatedExtendedTooltip(int abilCode, string extendedTooltip, int level);
		/// @CSharpLua.Template = "BlzSetAbilityResearchTooltip({0}, {1}, {2})"
		public static extern void BlzSetAbilityResearchTooltip(int abilCode, string researchTooltip, int level);
		/// @CSharpLua.Template = "BlzSetAbilityResearchExtendedTooltip({0}, {1}, {2})"
		public static extern void BlzSetAbilityResearchExtendedTooltip(int abilCode, string researchExtendedTooltip, int level);
		/// @CSharpLua.Template = "BlzGetAbilityTooltip({0}, {1})"
		public static extern string BlzGetAbilityTooltip(int abilCode, int level);
		/// @CSharpLua.Template = "BlzGetAbilityActivatedTooltip({0}, {1})"
		public static extern string BlzGetAbilityActivatedTooltip(int abilCode, int level);
		/// @CSharpLua.Template = "BlzGetAbilityExtendedTooltip({0}, {1})"
		public static extern string BlzGetAbilityExtendedTooltip(int abilCode, int level);
		/// @CSharpLua.Template = "BlzGetAbilityActivatedExtendedTooltip({0}, {1})"
		public static extern string BlzGetAbilityActivatedExtendedTooltip(int abilCode, int level);
		/// @CSharpLua.Template = "BlzGetAbilityResearchTooltip({0}, {1})"
		public static extern string BlzGetAbilityResearchTooltip(int abilCode, int level);
		/// @CSharpLua.Template = "BlzGetAbilityResearchExtendedTooltip({0}, {1})"
		public static extern string BlzGetAbilityResearchExtendedTooltip(int abilCode, int level);
		/// @CSharpLua.Template = "BlzSetAbilityIcon({0}, {1})"
		public static extern void BlzSetAbilityIcon(int abilCode, string iconPath);
		/// @CSharpLua.Template = "BlzGetAbilityIcon({0})"
		public static extern string BlzGetAbilityIcon(int abilCode);
		/// @CSharpLua.Template = "BlzSetAbilityActivatedIcon({0}, {1})"
		public static extern void BlzSetAbilityActivatedIcon(int abilCode, string iconPath);
		/// @CSharpLua.Template = "BlzGetAbilityActivatedIcon({0})"
		public static extern string BlzGetAbilityActivatedIcon(int abilCode);
		/// @CSharpLua.Template = "BlzGetAbilityPosX({0})"
		public static extern int BlzGetAbilityPosX(int abilCode);
		/// @CSharpLua.Template = "BlzGetAbilityPosY({0})"
		public static extern int BlzGetAbilityPosY(int abilCode);
		/// @CSharpLua.Template = "BlzSetAbilityPosX({0}, {1})"
		public static extern void BlzSetAbilityPosX(int abilCode, int x);
		/// @CSharpLua.Template = "BlzSetAbilityPosY({0}, {1})"
		public static extern void BlzSetAbilityPosY(int abilCode, int y);
		/// @CSharpLua.Template = "BlzGetAbilityActivatedPosX({0})"
		public static extern int BlzGetAbilityActivatedPosX(int abilCode);
		/// @CSharpLua.Template = "BlzGetAbilityActivatedPosY({0})"
		public static extern int BlzGetAbilityActivatedPosY(int abilCode);
		/// @CSharpLua.Template = "BlzSetAbilityActivatedPosX({0}, {1})"
		public static extern void BlzSetAbilityActivatedPosX(int abilCode, int x);
		/// @CSharpLua.Template = "BlzSetAbilityActivatedPosY({0}, {1})"
		public static extern void BlzSetAbilityActivatedPosY(int abilCode, int y);
		/// @CSharpLua.Template = "BlzGetUnitMaxHP({0})"
		public static extern int BlzGetUnitMaxHP(unit whichUnit);
		/// @CSharpLua.Template = "BlzSetUnitMaxHP({0}, {1})"
		public static extern void BlzSetUnitMaxHP(unit whichUnit, int hp);
		/// @CSharpLua.Template = "BlzGetUnitMaxMana({0})"
		public static extern int BlzGetUnitMaxMana(unit whichUnit);
		/// @CSharpLua.Template = "BlzSetUnitMaxMana({0}, {1})"
		public static extern void BlzSetUnitMaxMana(unit whichUnit, int mana);
		/// @CSharpLua.Template = "BlzSetItemName({0}, {1})"
		public static extern void BlzSetItemName(item whichItem, string name);
		/// @CSharpLua.Template = "BlzSetItemDescription({0}, {1})"
		public static extern void BlzSetItemDescription(item whichItem, string description);
		/// @CSharpLua.Template = "BlzGetItemDescription({0})"
		public static extern string BlzGetItemDescription(item whichItem);
		/// @CSharpLua.Template = "BlzSetItemTooltip({0}, {1})"
		public static extern void BlzSetItemTooltip(item whichItem, string tooltip);
		/// @CSharpLua.Template = "BlzGetItemTooltip({0})"
		public static extern string BlzGetItemTooltip(item whichItem);
		/// @CSharpLua.Template = "BlzSetItemExtendedTooltip({0}, {1})"
		public static extern void BlzSetItemExtendedTooltip(item whichItem, string extendedTooltip);
		/// @CSharpLua.Template = "BlzGetItemExtendedTooltip({0})"
		public static extern string BlzGetItemExtendedTooltip(item whichItem);
		/// @CSharpLua.Template = "BlzSetItemIconPath({0}, {1})"
		public static extern void BlzSetItemIconPath(item whichItem, string iconPath);
		/// @CSharpLua.Template = "BlzGetItemIconPath({0})"
		public static extern string BlzGetItemIconPath(item whichItem);
		/// @CSharpLua.Template = "BlzSetUnitName({0}, {1})"
		public static extern void BlzSetUnitName(unit whichUnit, string name);
		/// @CSharpLua.Template = "BlzSetHeroProperName({0}, {1})"
		public static extern void BlzSetHeroProperName(unit whichUnit, string heroProperName);
		/// @CSharpLua.Template = "BlzGetUnitBaseDamage({0}, {1})"
		public static extern int BlzGetUnitBaseDamage(unit whichUnit, int weaponIndex);
		/// @CSharpLua.Template = "BlzSetUnitBaseDamage({0}, {1}, {2})"
		public static extern void BlzSetUnitBaseDamage(unit whichUnit, int baseDamage, int weaponIndex);
		/// @CSharpLua.Template = "BlzGetUnitDiceNumber({0}, {1})"
		public static extern int BlzGetUnitDiceNumber(unit whichUnit, int weaponIndex);
		/// @CSharpLua.Template = "BlzSetUnitDiceNumber({0}, {1}, {2})"
		public static extern void BlzSetUnitDiceNumber(unit whichUnit, int diceNumber, int weaponIndex);
		/// @CSharpLua.Template = "BlzGetUnitDiceSides({0}, {1})"
		public static extern int BlzGetUnitDiceSides(unit whichUnit, int weaponIndex);
		/// @CSharpLua.Template = "BlzSetUnitDiceSides({0}, {1}, {2})"
		public static extern void BlzSetUnitDiceSides(unit whichUnit, int diceSides, int weaponIndex);
		/// @CSharpLua.Template = "BlzGetUnitAttackCooldown({0}, {1})"
		public static extern float BlzGetUnitAttackCooldown(unit whichUnit, int weaponIndex);
		/// @CSharpLua.Template = "BlzSetUnitAttackCooldown({0}, {1}, {2})"
		public static extern void BlzSetUnitAttackCooldown(unit whichUnit, float cooldown, int weaponIndex);
		/// @CSharpLua.Template = "BlzSetSpecialEffectColorByPlayer({0}, {1})"
		public static extern void BlzSetSpecialEffectColorByPlayer(effect whichEffect, player whichPlayer);
		/// @CSharpLua.Template = "BlzSetSpecialEffectColor({0}, {1}, {2}, {3})"
		public static extern void BlzSetSpecialEffectColor(effect whichEffect, int r, int g, int b);
		/// @CSharpLua.Template = "BlzSetSpecialEffectAlpha({0}, {1})"
		public static extern void BlzSetSpecialEffectAlpha(effect whichEffect, int alpha);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({0}, {1})"
		public static extern void BlzSetSpecialEffectScale(effect whichEffect, float scale);
		/// @CSharpLua.Template = "BlzSetSpecialEffectPosition({0}, {1}, {2}, {3})"
		public static extern void BlzSetSpecialEffectPosition(effect whichEffect, float x, float y, float z);
		/// @CSharpLua.Template = "BlzSetSpecialEffectHeight({0}, {1})"
		public static extern void BlzSetSpecialEffectHeight(effect whichEffect, float height);
		/// @CSharpLua.Template = "BlzSetSpecialEffectTimeScale({0}, {1})"
		public static extern void BlzSetSpecialEffectTimeScale(effect whichEffect, float timeScale);
		/// @CSharpLua.Template = "BlzSetSpecialEffectTime({0}, {1})"
		public static extern void BlzSetSpecialEffectTime(effect whichEffect, float time);
		/// @CSharpLua.Template = "BlzSetSpecialEffectOrientation({0}, {1}, {2}, {3})"
		public static extern void BlzSetSpecialEffectOrientation(effect whichEffect, float yaw, float pitch, float roll);
		/// @CSharpLua.Template = "BlzSetSpecialEffectYaw({0}, {1})"
		public static extern void BlzSetSpecialEffectYaw(effect whichEffect, float yaw);
		/// @CSharpLua.Template = "BlzSetSpecialEffectPitch({0}, {1})"
		public static extern void BlzSetSpecialEffectPitch(effect whichEffect, float pitch);
		/// @CSharpLua.Template = "BlzSetSpecialEffectRoll({0}, {1})"
		public static extern void BlzSetSpecialEffectRoll(effect whichEffect, float roll);
		/// @CSharpLua.Template = "BlzSetSpecialEffectX({0}, {1})"
		public static extern void BlzSetSpecialEffectX(effect whichEffect, float x);
		/// @CSharpLua.Template = "BlzSetSpecialEffectY({0}, {1})"
		public static extern void BlzSetSpecialEffectY(effect whichEffect, float y);
		/// @CSharpLua.Template = "BlzSetSpecialEffectZ({0}, {1})"
		public static extern void BlzSetSpecialEffectZ(effect whichEffect, float z);
		/// @CSharpLua.Template = "BlzSetSpecialEffectPositionLoc({0}, {1})"
		public static extern void BlzSetSpecialEffectPositionLoc(effect whichEffect, location loc);
		/// @CSharpLua.Template = "BlzGetLocalSpecialEffectX({0})"
		public static extern float BlzGetLocalSpecialEffectX(effect whichEffect);
		/// @CSharpLua.Template = "BlzGetLocalSpecialEffectY({0})"
		public static extern float BlzGetLocalSpecialEffectY(effect whichEffect);
		/// @CSharpLua.Template = "BlzGetLocalSpecialEffectZ({0})"
		public static extern float BlzGetLocalSpecialEffectZ(effect whichEffect);
		/// @CSharpLua.Template = "BlzSpecialEffectClearSubAnimations({0})"
		public static extern void BlzSpecialEffectClearSubAnimations(effect whichEffect);
		/// @CSharpLua.Template = "BlzSpecialEffectRemoveSubAnimation({0}, {1})"
		public static extern void BlzSpecialEffectRemoveSubAnimation(effect whichEffect, subanimtype whichSubAnim);
		/// @CSharpLua.Template = "BlzSpecialEffectAddSubAnimation({0}, {1})"
		public static extern void BlzSpecialEffectAddSubAnimation(effect whichEffect, subanimtype whichSubAnim);
		/// @CSharpLua.Template = "BlzPlaySpecialEffect({0}, {1})"
		public static extern void BlzPlaySpecialEffect(effect whichEffect, animtype whichAnim);
		/// @CSharpLua.Template = "BlzPlaySpecialEffectWithTimeScale({0}, {1}, {2})"
		public static extern void BlzPlaySpecialEffectWithTimeScale(effect whichEffect, animtype whichAnim, float timeScale);
		/// @CSharpLua.Template = "BlzGetAnimName({0})"
		public static extern string BlzGetAnimName(animtype whichAnim);
		/// @CSharpLua.Template = "BlzGetUnitArmor({0})"
		public static extern float BlzGetUnitArmor(unit whichUnit);
		/// @CSharpLua.Template = "BlzSetUnitArmor({0}, {1})"
		public static extern void BlzSetUnitArmor(unit whichUnit, float armorAmount);
		/// @CSharpLua.Template = "BlzUnitHideAbility({0}, {1}, {2})"
		public static extern void BlzUnitHideAbility(unit whichUnit, int abilId, bool flag);
		/// @CSharpLua.Template = "BlzUnitDisableAbility({0}, {1}, {2}, {3})"
		public static extern void BlzUnitDisableAbility(unit whichUnit, int abilId, bool flag, bool hideUI);
		/// @CSharpLua.Template = "BlzUnitCancelTimedLife({0})"
		public static extern void BlzUnitCancelTimedLife(unit whichUnit);
		/// @CSharpLua.Template = "BlzIsUnitSelectable({0})"
		public static extern bool BlzIsUnitSelectable(unit whichUnit);
		/// @CSharpLua.Template = "BlzIsUnitInvulnerable({0})"
		public static extern bool BlzIsUnitInvulnerable(unit whichUnit);
		/// @CSharpLua.Template = "BlzUnitInterruptAttack({0})"
		public static extern void BlzUnitInterruptAttack(unit whichUnit);
		/// @CSharpLua.Template = "BlzGetUnitCollisionSize({0})"
		public static extern float BlzGetUnitCollisionSize(unit whichUnit);
		/// @CSharpLua.Template = "BlzGetAbilityManaCost({0}, {1})"
		public static extern int BlzGetAbilityManaCost(int abilId, int level);
		/// @CSharpLua.Template = "BlzGetAbilityCooldown({0}, {1})"
		public static extern float BlzGetAbilityCooldown(int abilId, int level);
		/// @CSharpLua.Template = "BlzSetUnitAbilityCooldown({0}, {1}, {2}, {3})"
		public static extern void BlzSetUnitAbilityCooldown(unit whichUnit, int abilId, int level, float cooldown);
		/// @CSharpLua.Template = "BlzGetUnitAbilityCooldown({0}, {1}, {2})"
		public static extern float BlzGetUnitAbilityCooldown(unit whichUnit, int abilId, int level);
		/// @CSharpLua.Template = "BlzGetUnitAbilityCooldownRemaining({0}, {1})"
		public static extern float BlzGetUnitAbilityCooldownRemaining(unit whichUnit, int abilId);
		/// @CSharpLua.Template = "BlzEndUnitAbilityCooldown({0}, {1})"
		public static extern void BlzEndUnitAbilityCooldown(unit whichUnit, int abilCode);
		/// @CSharpLua.Template = "BlzStartUnitAbilityCooldown({0}, {1}, {2})"
		public static extern void BlzStartUnitAbilityCooldown(unit whichUnit, int abilCode, float cooldown);
		/// @CSharpLua.Template = "BlzGetUnitAbilityManaCost({0}, {1}, {2})"
		public static extern int BlzGetUnitAbilityManaCost(unit whichUnit, int abilId, int level);
		/// @CSharpLua.Template = "BlzSetUnitAbilityManaCost({0}, {1}, {2}, {3})"
		public static extern void BlzSetUnitAbilityManaCost(unit whichUnit, int abilId, int level, int manaCost);
		/// @CSharpLua.Template = "BlzGetLocalUnitZ({0})"
		public static extern float BlzGetLocalUnitZ(unit whichUnit);
		/// @CSharpLua.Template = "BlzDecPlayerTechResearched({0}, {1}, {2})"
		public static extern void BlzDecPlayerTechResearched(player whichPlayer, int techid, int levels);
		/// @CSharpLua.Template = "BlzSetEventDamage({0})"
		public static extern void BlzSetEventDamage(float damage);
		/// @CSharpLua.Template = "BlzGetEventDamageTarget()"
		public static extern unit BlzGetEventDamageTarget();
		/// @CSharpLua.Template = "BlzGetEventAttackType()"
		public static extern attacktype BlzGetEventAttackType();
		/// @CSharpLua.Template = "BlzGetEventDamageType()"
		public static extern damagetype BlzGetEventDamageType();
		/// @CSharpLua.Template = "BlzGetEventWeaponType()"
		public static extern weapontype BlzGetEventWeaponType();
		/// @CSharpLua.Template = "BlzSetEventAttackType({0})"
		public static extern bool BlzSetEventAttackType(attacktype attackType);
		/// @CSharpLua.Template = "BlzSetEventDamageType({0})"
		public static extern bool BlzSetEventDamageType(damagetype damageType);
		/// @CSharpLua.Template = "BlzSetEventWeaponType({0})"
		public static extern bool BlzSetEventWeaponType(weapontype weaponType);
		/// @CSharpLua.Template = "BlzGetEventIsAttack()"
		public static extern bool BlzGetEventIsAttack();
		/// @CSharpLua.Template = "RequestExtraIntegerData({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern int RequestExtraIntegerData(int dataType, player whichPlayer, string param1, string param2, bool param3, int param4, int param5, int param6);
		/// @CSharpLua.Template = "RequestExtraBooleanData({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern bool RequestExtraBooleanData(int dataType, player whichPlayer, string param1, string param2, bool param3, int param4, int param5, int param6);
		/// @CSharpLua.Template = "RequestExtraStringData({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern string RequestExtraStringData(int dataType, player whichPlayer, string param1, string param2, bool param3, int param4, int param5, int param6);
		/// @CSharpLua.Template = "RequestExtraRealData({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern float RequestExtraRealData(int dataType, player whichPlayer, string param1, string param2, bool param3, int param4, int param5, int param6);
		/// @CSharpLua.Template = "BlzGetUnitZ({0})"
		public static extern float BlzGetUnitZ(unit whichUnit);
		/// @CSharpLua.Template = "BlzEnableSelections({0}, {1})"
		public static extern void BlzEnableSelections(bool enableSelection, bool enableSelectionCircle);
		/// @CSharpLua.Template = "BlzIsSelectionEnabled()"
		public static extern bool BlzIsSelectionEnabled();
		/// @CSharpLua.Template = "BlzIsSelectionCircleEnabled()"
		public static extern bool BlzIsSelectionCircleEnabled();
		/// @CSharpLua.Template = "BlzCameraSetupApplyForceDurationSmooth({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern void BlzCameraSetupApplyForceDurationSmooth(camerasetup whichSetup, bool doPan, float forcedDuration, float easeInDuration, float easeOutDuration, float smoothFactor);
		/// @CSharpLua.Template = "BlzEnableTargetIndicator({0})"
		public static extern void BlzEnableTargetIndicator(bool enable);
		/// @CSharpLua.Template = "BlzIsTargetIndicatorEnabled()"
		public static extern bool BlzIsTargetIndicatorEnabled();
		/// @CSharpLua.Template = "BlzShowTerrain({0})"
		public static extern void BlzShowTerrain(bool show);
		/// @CSharpLua.Template = "BlzShowSkyBox({0})"
		public static extern void BlzShowSkyBox(bool show);
		/// @CSharpLua.Template = "BlzStartRecording({0})"
		public static extern void BlzStartRecording(int fps);
		/// @CSharpLua.Template = "BlzEndRecording()"
		public static extern void BlzEndRecording();
		/// @CSharpLua.Template = "BlzShowUnitTeamGlow({0}, {1})"
		public static extern void BlzShowUnitTeamGlow(unit whichUnit, bool show);
		/// @CSharpLua.Template = "BlzGetOriginFrame({0}, {1})"
		public static extern framehandle BlzGetOriginFrame(originframetype frameType, int index);
		/// @CSharpLua.Template = "BlzEnableUIAutoPosition({0})"
		public static extern void BlzEnableUIAutoPosition(bool enable);
		/// @CSharpLua.Template = "BlzHideOriginFrames({0})"
		public static extern void BlzHideOriginFrames(bool enable);
		/// @CSharpLua.Template = "BlzConvertColor({0}, {1}, {2}, {3})"
		public static extern int BlzConvertColor(int a, int r, int g, int b);
		/// @CSharpLua.Template = "BlzLoadTOCFile({0})"
		public static extern bool BlzLoadTOCFile(string TOCFile);
		/// @CSharpLua.Template = "BlzCreateFrame({0}, {1}, {2}, {3})"
		public static extern framehandle BlzCreateFrame(string name, framehandle owner, int priority, int createContext);
		/// @CSharpLua.Template = "BlzCreateSimpleFrame({0}, {1}, {2})"
		public static extern framehandle BlzCreateSimpleFrame(string name, framehandle owner, int createContext);
		/// @CSharpLua.Template = "BlzCreateFrameByType({0}, {1}, {2}, {3}, {4})"
		public static extern framehandle BlzCreateFrameByType(string typeName, string name, framehandle owner, string inherits, int createContext);
		/// @CSharpLua.Template = "BlzDestroyFrame({0})"
		public static extern void BlzDestroyFrame(framehandle frame);
		/// @CSharpLua.Template = "BlzFrameSetPoint({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern void BlzFrameSetPoint(framehandle frame, framepointtype point, framehandle relative, framepointtype relativePoint, float x, float y);
		/// @CSharpLua.Template = "BlzFrameSetAbsPoint({0}, {1}, {2}, {3})"
		public static extern void BlzFrameSetAbsPoint(framehandle frame, framepointtype point, float x, float y);
		/// @CSharpLua.Template = "BlzFrameClearAllPoints({0})"
		public static extern void BlzFrameClearAllPoints(framehandle frame);
		/// @CSharpLua.Template = "BlzFrameSetAllPoints({0}, {1})"
		public static extern void BlzFrameSetAllPoints(framehandle frame, framehandle relative);
		/// @CSharpLua.Template = "BlzFrameSetVisible({0}, {1})"
		public static extern void BlzFrameSetVisible(framehandle frame, bool visible);
		/// @CSharpLua.Template = "BlzFrameIsVisible({0})"
		public static extern bool BlzFrameIsVisible(framehandle frame);
		/// @CSharpLua.Template = "BlzGetFrameByName({0}, {1})"
		public static extern framehandle BlzGetFrameByName(string name, int createContext);
		/// @CSharpLua.Template = "BlzFrameGetName({0})"
		public static extern string BlzFrameGetName(framehandle frame);
		/// @CSharpLua.Template = "BlzFrameClick({0})"
		public static extern void BlzFrameClick(framehandle frame);
		/// @CSharpLua.Template = "BlzFrameSetText({0}, {1})"
		public static extern void BlzFrameSetText(framehandle frame, string text);
		/// @CSharpLua.Template = "BlzFrameGetText({0})"
		public static extern string BlzFrameGetText(framehandle frame);
		/// @CSharpLua.Template = "BlzFrameAddText({0}, {1})"
		public static extern void BlzFrameAddText(framehandle frame, string text);
		/// @CSharpLua.Template = "BlzFrameSetTextSizeLimit({0}, {1})"
		public static extern void BlzFrameSetTextSizeLimit(framehandle frame, int size);
		/// @CSharpLua.Template = "BlzFrameGetTextSizeLimit({0})"
		public static extern int BlzFrameGetTextSizeLimit(framehandle frame);
		/// @CSharpLua.Template = "BlzFrameSetTextColor({0}, {1})"
		public static extern void BlzFrameSetTextColor(framehandle frame, int color);
		/// @CSharpLua.Template = "BlzFrameSetFocus({0}, {1})"
		public static extern void BlzFrameSetFocus(framehandle frame, bool flag);
		/// @CSharpLua.Template = "BlzFrameSetModel({0}, {1}, {2})"
		public static extern void BlzFrameSetModel(framehandle frame, string modelFile, int cameraIndex);
		/// @CSharpLua.Template = "BlzFrameSetEnable({0}, {1})"
		public static extern void BlzFrameSetEnable(framehandle frame, bool enabled);
		/// @CSharpLua.Template = "BlzFrameGetEnable({0})"
		public static extern bool BlzFrameGetEnable(framehandle frame);
		/// @CSharpLua.Template = "BlzFrameSetAlpha({0}, {1})"
		public static extern void BlzFrameSetAlpha(framehandle frame, int alpha);
		/// @CSharpLua.Template = "BlzFrameGetAlpha({0})"
		public static extern int BlzFrameGetAlpha(framehandle frame);
		/// @CSharpLua.Template = "BlzFrameSetSpriteAnimate({0}, {1}, {2})"
		public static extern void BlzFrameSetSpriteAnimate(framehandle frame, int primaryProp, int flags);
		/// @CSharpLua.Template = "BlzFrameSetTexture({0}, {1}, {2}, {3})"
		public static extern void BlzFrameSetTexture(framehandle frame, string texFile, int flag, bool blend);
		/// @CSharpLua.Template = "BlzFrameSetScale({0}, {1})"
		public static extern void BlzFrameSetScale(framehandle frame, float scale);
		/// @CSharpLua.Template = "BlzFrameSetTooltip({0}, {1})"
		public static extern void BlzFrameSetTooltip(framehandle frame, framehandle tooltip);
		/// @CSharpLua.Template = "BlzFrameCageMouse({0}, {1})"
		public static extern void BlzFrameCageMouse(framehandle frame, bool enable);
		/// @CSharpLua.Template = "BlzFrameSetValue({0}, {1})"
		public static extern void BlzFrameSetValue(framehandle frame, float value);
		/// @CSharpLua.Template = "BlzFrameGetValue({0})"
		public static extern float BlzFrameGetValue(framehandle frame);
		/// @CSharpLua.Template = "BlzFrameSetMinMaxValue({0}, {1}, {2})"
		public static extern void BlzFrameSetMinMaxValue(framehandle frame, float minValue, float maxValue);
		/// @CSharpLua.Template = "BlzFrameSetStepSize({0}, {1})"
		public static extern void BlzFrameSetStepSize(framehandle frame, float stepSize);
		/// @CSharpLua.Template = "BlzFrameSetSize({0}, {1}, {2})"
		public static extern void BlzFrameSetSize(framehandle frame, float width, float height);
		/// @CSharpLua.Template = "BlzFrameSetVertexColor({0}, {1})"
		public static extern void BlzFrameSetVertexColor(framehandle frame, int color);
		/// @CSharpLua.Template = "BlzFrameSetLevel({0}, {1})"
		public static extern void BlzFrameSetLevel(framehandle frame, int level);
		/// @CSharpLua.Template = "BlzFrameSetParent({0}, {1})"
		public static extern void BlzFrameSetParent(framehandle frame, framehandle parent);
		/// @CSharpLua.Template = "BlzFrameGetParent({0})"
		public static extern framehandle BlzFrameGetParent(framehandle frame);
		/// @CSharpLua.Template = "BlzFrameGetHeight({0})"
		public static extern float BlzFrameGetHeight(framehandle frame);
		/// @CSharpLua.Template = "BlzFrameGetWidth({0})"
		public static extern float BlzFrameGetWidth(framehandle frame);
		/// @CSharpLua.Template = "BlzFrameSetFont({0}, {1}, {2}, {3})"
		public static extern void BlzFrameSetFont(framehandle frame, string fileName, float height, int flags);
		/// @CSharpLua.Template = "BlzFrameSetTextAlignment({0}, {1}, {2})"
		public static extern void BlzFrameSetTextAlignment(framehandle frame, textaligntype vert, textaligntype horz);
		/// @CSharpLua.Template = "BlzFrameGetChildrenCount({0})"
		public static extern int BlzFrameGetChildrenCount(framehandle frame);
		/// @CSharpLua.Template = "BlzFrameGetChild({0}, {1})"
		public static extern framehandle BlzFrameGetChild(framehandle frame, int index);
		/// @CSharpLua.Template = "BlzTriggerRegisterFrameEvent({0}, {1}, {2})"
		public static extern @event BlzTriggerRegisterFrameEvent(trigger whichTrigger, framehandle frame, frameeventtype eventId);
		/// @CSharpLua.Template = "BlzGetTriggerFrame()"
		public static extern framehandle BlzGetTriggerFrame();
		/// @CSharpLua.Template = "BlzGetTriggerFrameEvent()"
		public static extern frameeventtype BlzGetTriggerFrameEvent();
		/// @CSharpLua.Template = "BlzGetTriggerFrameValue()"
		public static extern float BlzGetTriggerFrameValue();
		/// @CSharpLua.Template = "BlzGetTriggerFrameText()"
		public static extern string BlzGetTriggerFrameText();
		/// @CSharpLua.Template = "BlzTriggerRegisterPlayerSyncEvent({0}, {1}, {2}, {3})"
		public static extern @event BlzTriggerRegisterPlayerSyncEvent(trigger whichTrigger, player whichPlayer, string prefix, bool fromServer);
		/// @CSharpLua.Template = "BlzSendSyncData({0}, {1})"
		public static extern bool BlzSendSyncData(string prefix, string data);
		/// @CSharpLua.Template = "BlzGetTriggerSyncPrefix()"
		public static extern string BlzGetTriggerSyncPrefix();
		/// @CSharpLua.Template = "BlzGetTriggerSyncData()"
		public static extern string BlzGetTriggerSyncData();
		/// @CSharpLua.Template = "BlzTriggerRegisterPlayerKeyEvent({0}, {1}, {2}, {3}, {4})"
		public static extern @event BlzTriggerRegisterPlayerKeyEvent(trigger whichTrigger, player whichPlayer, oskeytype key, MetaKey metaKey, bool keyDown);
		/// @CSharpLua.Template = "BlzGetTriggerPlayerKey()"
		public static extern oskeytype BlzGetTriggerPlayerKey();
		/// @CSharpLua.Template = "BlzGetTriggerPlayerMetaKey()"
		public static extern MetaKey BlzGetTriggerPlayerMetaKey();
		/// @CSharpLua.Template = "BlzGetTriggerPlayerIsKeyDown()"
		public static extern bool BlzGetTriggerPlayerIsKeyDown();
		/// @CSharpLua.Template = "BlzEnableCursor({0})"
		public static extern void BlzEnableCursor(bool enable);
		/// @CSharpLua.Template = "BlzSetMousePos({0}, {1})"
		public static extern void BlzSetMousePos(int x, int y);
		/// @CSharpLua.Template = "BlzGetLocalClientWidth()"
		public static extern int BlzGetLocalClientWidth();
		/// @CSharpLua.Template = "BlzGetLocalClientHeight()"
		public static extern int BlzGetLocalClientHeight();
		/// @CSharpLua.Template = "BlzIsLocalClientActive()"
		public static extern bool BlzIsLocalClientActive();
		/// @CSharpLua.Template = "BlzGetMouseFocusUnit()"
		public static extern unit BlzGetMouseFocusUnit();
		/// @CSharpLua.Template = "BlzChangeMinimapTerrainTex({0})"
		public static extern bool BlzChangeMinimapTerrainTex(string texFile);
		/// @CSharpLua.Template = "BlzGetLocale()"
		public static extern string BlzGetLocale();
		/// @CSharpLua.Template = "BlzGetSpecialEffectScale({0})"
		public static extern float BlzGetSpecialEffectScale(effect whichEffect);
		/// @CSharpLua.Template = "BlzSetSpecialEffectMatrixScale({0}, {1}, {2}, {3})"
		public static extern void BlzSetSpecialEffectMatrixScale(effect whichEffect, float x, float y, float z);
		/// @CSharpLua.Template = "BlzResetSpecialEffectMatrix({0})"
		public static extern void BlzResetSpecialEffectMatrix(effect whichEffect);
		/// @CSharpLua.Template = "BlzGetUnitAbility({0}, {1})"
		public static extern ability BlzGetUnitAbility(unit whichUnit, int abilId);
		/// @CSharpLua.Template = "BlzGetUnitAbilityByIndex({0}, {1})"
		public static extern ability BlzGetUnitAbilityByIndex(unit whichUnit, int index);
		/// @CSharpLua.Template = "BlzGetAbilityId({0})"
		public static extern int BlzGetAbilityId(ability whichAbility);
		/// @CSharpLua.Template = "BlzDisplayChatMessage({0}, {1}, {2})"
		public static extern void BlzDisplayChatMessage(player whichPlayer, ChatRecipient recipient, string message);
		/// @CSharpLua.Template = "BlzPauseUnitEx({0}, {1})"
		public static extern void BlzPauseUnitEx(unit whichUnit, bool flag);
		/// @CSharpLua.Template = "BlzSetUnitFacingEx({0}, {1})"
		public static extern void BlzSetUnitFacingEx(unit whichUnit, float facingAngle);
		/// @CSharpLua.Template = "CreateCommandButtonEffect({0}, {1})"
		public static extern commandbuttoneffect CreateCommandButtonEffect(int abilityId, string order);
		/// @CSharpLua.Template = "CreateUpgradeCommandButtonEffect({0})"
		public static extern commandbuttoneffect CreateUpgradeCommandButtonEffect(int whichUprgade);
		/// @CSharpLua.Template = "CreateLearnCommandButtonEffect({0})"
		public static extern commandbuttoneffect CreateLearnCommandButtonEffect(int abilityId);
		/// @CSharpLua.Template = "DestroyCommandButtonEffect({0})"
		public static extern void DestroyCommandButtonEffect(commandbuttoneffect whichEffect);
		/// @CSharpLua.Template = "BlzBitOr({0}, {1})"
		public static extern int BlzBitOr(int x, int y);
		/// @CSharpLua.Template = "BlzBitAnd({0}, {1})"
		public static extern int BlzBitAnd(int x, int y);
		/// @CSharpLua.Template = "BlzBitXor({0}, {1})"
		public static extern int BlzBitXor(int x, int y);
		/// @CSharpLua.Template = "BlzGetAbilityBooleanField({0}, {1})"
		public static extern bool BlzGetAbilityBooleanField(ability whichAbility, abilitybooleanfield whichField);
		/// @CSharpLua.Template = "BlzGetAbilityIntegerField({0}, {1})"
		public static extern int BlzGetAbilityIntegerField(ability whichAbility, abilityintegerfield whichField);
		/// @CSharpLua.Template = "BlzGetAbilityRealField({0}, {1})"
		public static extern float BlzGetAbilityRealField(ability whichAbility, abilityrealfield whichField);
		/// @CSharpLua.Template = "BlzGetAbilityStringField({0}, {1})"
		public static extern string BlzGetAbilityStringField(ability whichAbility, abilitystringfield whichField);
		/// @CSharpLua.Template = "BlzGetAbilityBooleanLevelField({0}, {1}, {2})"
		public static extern bool BlzGetAbilityBooleanLevelField(ability whichAbility, abilitybooleanlevelfield whichField, int level);
		/// @CSharpLua.Template = "BlzGetAbilityIntegerLevelField({0}, {1}, {2})"
		public static extern int BlzGetAbilityIntegerLevelField(ability whichAbility, abilityintegerlevelfield whichField, int level);
		/// @CSharpLua.Template = "BlzGetAbilityRealLevelField({0}, {1}, {2})"
		public static extern float BlzGetAbilityRealLevelField(ability whichAbility, abilityreallevelfield whichField, int level);
		/// @CSharpLua.Template = "BlzGetAbilityStringLevelField({0}, {1}, {2})"
		public static extern string BlzGetAbilityStringLevelField(ability whichAbility, abilitystringlevelfield whichField, int level);
		/// @CSharpLua.Template = "BlzGetAbilityBooleanLevelArrayField({0}, {1}, {2}, {3})"
		public static extern bool BlzGetAbilityBooleanLevelArrayField(ability whichAbility, abilitybooleanlevelarrayfield whichField, int level, int index);
		/// @CSharpLua.Template = "BlzGetAbilityIntegerLevelArrayField({0}, {1}, {2}, {3})"
		public static extern int BlzGetAbilityIntegerLevelArrayField(ability whichAbility, abilityintegerlevelarrayfield whichField, int level, int index);
		/// @CSharpLua.Template = "BlzGetAbilityRealLevelArrayField({0}, {1}, {2}, {3})"
		public static extern float BlzGetAbilityRealLevelArrayField(ability whichAbility, abilityreallevelarrayfield whichField, int level, int index);
		/// @CSharpLua.Template = "BlzGetAbilityStringLevelArrayField({0}, {1}, {2}, {3})"
		public static extern string BlzGetAbilityStringLevelArrayField(ability whichAbility, abilitystringlevelarrayfield whichField, int level, int index);
		/// @CSharpLua.Template = "BlzSetAbilityBooleanField({0}, {1}, {2})"
		public static extern bool BlzSetAbilityBooleanField(ability whichAbility, abilitybooleanfield whichField, bool value);
		/// @CSharpLua.Template = "BlzSetAbilityIntegerField({0}, {1}, {2})"
		public static extern bool BlzSetAbilityIntegerField(ability whichAbility, abilityintegerfield whichField, int value);
		/// @CSharpLua.Template = "BlzSetAbilityRealField({0}, {1}, {2})"
		public static extern bool BlzSetAbilityRealField(ability whichAbility, abilityrealfield whichField, float value);
		/// @CSharpLua.Template = "BlzSetAbilityStringField({0}, {1}, {2})"
		public static extern bool BlzSetAbilityStringField(ability whichAbility, abilitystringfield whichField, string value);
		/// @CSharpLua.Template = "BlzSetAbilityBooleanLevelField({0}, {1}, {2}, {3})"
		public static extern bool BlzSetAbilityBooleanLevelField(ability whichAbility, abilitybooleanlevelfield whichField, int level, bool value);
		/// @CSharpLua.Template = "BlzSetAbilityIntegerLevelField({0}, {1}, {2}, {3})"
		public static extern bool BlzSetAbilityIntegerLevelField(ability whichAbility, abilityintegerlevelfield whichField, int level, int value);
		/// @CSharpLua.Template = "BlzSetAbilityRealLevelField({0}, {1}, {2}, {3})"
		public static extern bool BlzSetAbilityRealLevelField(ability whichAbility, abilityreallevelfield whichField, int level, float value);
		/// @CSharpLua.Template = "BlzSetAbilityStringLevelField({0}, {1}, {2}, {3})"
		public static extern bool BlzSetAbilityStringLevelField(ability whichAbility, abilitystringlevelfield whichField, int level, string value);
		/// @CSharpLua.Template = "BlzSetAbilityBooleanLevelArrayField({0}, {1}, {2}, {3}, {4})"
		public static extern bool BlzSetAbilityBooleanLevelArrayField(ability whichAbility, abilitybooleanlevelarrayfield whichField, int level, int index, bool value);
		/// @CSharpLua.Template = "BlzSetAbilityIntegerLevelArrayField({0}, {1}, {2}, {3}, {4})"
		public static extern bool BlzSetAbilityIntegerLevelArrayField(ability whichAbility, abilityintegerlevelarrayfield whichField, int level, int index, int value);
		/// @CSharpLua.Template = "BlzSetAbilityRealLevelArrayField({0}, {1}, {2}, {3}, {4})"
		public static extern bool BlzSetAbilityRealLevelArrayField(ability whichAbility, abilityreallevelarrayfield whichField, int level, int index, float value);
		/// @CSharpLua.Template = "BlzSetAbilityStringLevelArrayField({0}, {1}, {2}, {3}, {4})"
		public static extern bool BlzSetAbilityStringLevelArrayField(ability whichAbility, abilitystringlevelarrayfield whichField, int level, int index, string value);
		/// @CSharpLua.Template = "BlzAddAbilityBooleanLevelArrayField({0}, {1}, {2}, {3})"
		public static extern bool BlzAddAbilityBooleanLevelArrayField(ability whichAbility, abilitybooleanlevelarrayfield whichField, int level, bool value);
		/// @CSharpLua.Template = "BlzAddAbilityIntegerLevelArrayField({0}, {1}, {2}, {3})"
		public static extern bool BlzAddAbilityIntegerLevelArrayField(ability whichAbility, abilityintegerlevelarrayfield whichField, int level, int value);
		/// @CSharpLua.Template = "BlzAddAbilityRealLevelArrayField({0}, {1}, {2}, {3})"
		public static extern bool BlzAddAbilityRealLevelArrayField(ability whichAbility, abilityreallevelarrayfield whichField, int level, float value);
		/// @CSharpLua.Template = "BlzAddAbilityStringLevelArrayField({0}, {1}, {2}, {3})"
		public static extern bool BlzAddAbilityStringLevelArrayField(ability whichAbility, abilitystringlevelarrayfield whichField, int level, string value);
		/// @CSharpLua.Template = "BlzRemoveAbilityBooleanLevelArrayField({0}, {1}, {2}, {3})"
		public static extern bool BlzRemoveAbilityBooleanLevelArrayField(ability whichAbility, abilitybooleanlevelarrayfield whichField, int level, bool value);
		/// @CSharpLua.Template = "BlzRemoveAbilityIntegerLevelArrayField({0}, {1}, {2}, {3})"
		public static extern bool BlzRemoveAbilityIntegerLevelArrayField(ability whichAbility, abilityintegerlevelarrayfield whichField, int level, int value);
		/// @CSharpLua.Template = "BlzRemoveAbilityRealLevelArrayField({0}, {1}, {2}, {3})"
		public static extern bool BlzRemoveAbilityRealLevelArrayField(ability whichAbility, abilityreallevelarrayfield whichField, int level, float value);
		/// @CSharpLua.Template = "BlzRemoveAbilityStringLevelArrayField({0}, {1}, {2}, {3})"
		public static extern bool BlzRemoveAbilityStringLevelArrayField(ability whichAbility, abilitystringlevelarrayfield whichField, int level, string value);
		/// @CSharpLua.Template = "BlzGetItemAbilityByIndex({0}, {1})"
		public static extern ability BlzGetItemAbilityByIndex(item whichItem, int index);
		/// @CSharpLua.Template = "BlzGetItemAbility({0}, {1})"
		public static extern ability BlzGetItemAbility(item whichItem, int abilCode);
		/// @CSharpLua.Template = "BlzItemAddAbility({0}, {1})"
		public static extern bool BlzItemAddAbility(item whichItem, int abilCode);
		/// @CSharpLua.Template = "BlzGetItemBooleanField({0}, {1})"
		public static extern bool BlzGetItemBooleanField(item whichItem, itembooleanfield whichField);
		/// @CSharpLua.Template = "BlzGetItemIntegerField({0}, {1})"
		public static extern int BlzGetItemIntegerField(item whichItem, itemintegerfield whichField);
		/// @CSharpLua.Template = "BlzGetItemRealField({0}, {1})"
		public static extern float BlzGetItemRealField(item whichItem, itemrealfield whichField);
		/// @CSharpLua.Template = "BlzGetItemStringField({0}, {1})"
		public static extern string BlzGetItemStringField(item whichItem, itemstringfield whichField);
		/// @CSharpLua.Template = "BlzSetItemBooleanField({0}, {1}, {2})"
		public static extern bool BlzSetItemBooleanField(item whichItem, itembooleanfield whichField, bool value);
		/// @CSharpLua.Template = "BlzSetItemIntegerField({0}, {1}, {2})"
		public static extern bool BlzSetItemIntegerField(item whichItem, itemintegerfield whichField, int value);
		/// @CSharpLua.Template = "BlzSetItemRealField({0}, {1}, {2})"
		public static extern bool BlzSetItemRealField(item whichItem, itemrealfield whichField, float value);
		/// @CSharpLua.Template = "BlzSetItemStringField({0}, {1}, {2})"
		public static extern bool BlzSetItemStringField(item whichItem, itemstringfield whichField, string value);
		/// @CSharpLua.Template = "BlzItemRemoveAbility({0}, {1})"
		public static extern bool BlzItemRemoveAbility(item whichItem, int abilCode);
		/// @CSharpLua.Template = "BlzGetUnitBooleanField({0}, {1})"
		public static extern bool BlzGetUnitBooleanField(unit whichUnit, unitbooleanfield whichField);
		/// @CSharpLua.Template = "BlzGetUnitIntegerField({0}, {1})"
		public static extern int BlzGetUnitIntegerField(unit whichUnit, unitintegerfield whichField);
		/// @CSharpLua.Template = "BlzGetUnitRealField({0}, {1})"
		public static extern float BlzGetUnitRealField(unit whichUnit, unitrealfield whichField);
		/// @CSharpLua.Template = "BlzGetUnitStringField({0}, {1})"
		public static extern string BlzGetUnitStringField(unit whichUnit, unitstringfield whichField);
		/// @CSharpLua.Template = "BlzSetUnitBooleanField({0}, {1}, {2})"
		public static extern bool BlzSetUnitBooleanField(unit whichUnit, unitbooleanfield whichField, bool value);
		/// @CSharpLua.Template = "BlzSetUnitIntegerField({0}, {1}, {2})"
		public static extern bool BlzSetUnitIntegerField(unit whichUnit, unitintegerfield whichField, int value);
		/// @CSharpLua.Template = "BlzSetUnitRealField({0}, {1}, {2})"
		public static extern bool BlzSetUnitRealField(unit whichUnit, unitrealfield whichField, float value);
		/// @CSharpLua.Template = "BlzSetUnitStringField({0}, {1}, {2})"
		public static extern bool BlzSetUnitStringField(unit whichUnit, unitstringfield whichField, string value);
		/// @CSharpLua.Template = "BlzGetUnitWeaponBooleanField({0}, {1}, {2})"
		public static extern bool BlzGetUnitWeaponBooleanField(unit whichUnit, unitweaponbooleanfield whichField, int index);
		/// @CSharpLua.Template = "BlzGetUnitWeaponIntegerField({0}, {1}, {2})"
		public static extern int BlzGetUnitWeaponIntegerField(unit whichUnit, unitweaponintegerfield whichField, int index);
		/// @CSharpLua.Template = "BlzGetUnitWeaponRealField({0}, {1}, {2})"
		public static extern float BlzGetUnitWeaponRealField(unit whichUnit, unitweaponrealfield whichField, int index);
		/// @CSharpLua.Template = "BlzGetUnitWeaponStringField({0}, {1}, {2})"
		public static extern string BlzGetUnitWeaponStringField(unit whichUnit, unitweaponstringfield whichField, int index);
		/// @CSharpLua.Template = "BlzSetUnitWeaponBooleanField({0}, {1}, {2}, {3})"
		public static extern bool BlzSetUnitWeaponBooleanField(unit whichUnit, unitweaponbooleanfield whichField, int index, bool value);
		/// @CSharpLua.Template = "BlzSetUnitWeaponIntegerField({0}, {1}, {2}, {3})"
		public static extern bool BlzSetUnitWeaponIntegerField(unit whichUnit, unitweaponintegerfield whichField, int index, int value);
		/// @CSharpLua.Template = "BlzSetUnitWeaponRealField({0}, {1}, {2}, {3})"
		public static extern bool BlzSetUnitWeaponRealField(unit whichUnit, unitweaponrealfield whichField, int index, float value);
		/// @CSharpLua.Template = "BlzSetUnitWeaponStringField({0}, {1}, {2}, {3})"
		public static extern bool BlzSetUnitWeaponStringField(unit whichUnit, unitweaponstringfield whichField, int index, string value);
		/// @CSharpLua.Template = "BlzGetUnitSkin({0})"
		public static extern int BlzGetUnitSkin(unit whichUnit);
		/// @CSharpLua.Template = "BlzGetItemSkin({0})"
		public static extern int BlzGetItemSkin(item whichItem);
		/// @CSharpLua.Template = "BlzSetUnitSkin({0}, {1})"
		public static extern void BlzSetUnitSkin(unit whichUnit, int skinId);
		/// @CSharpLua.Template = "BlzSetItemSkin({0}, {1})"
		public static extern void BlzSetItemSkin(item whichItem, int skinId);
		/// @CSharpLua.Template = "BlzCreateItemWithSkin({0}, {1}, {2}, {3})"
		public static extern item BlzCreateItemWithSkin(int itemid, float x, float y, int skinId);
		/// @CSharpLua.Template = "BlzCreateUnitWithSkin({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern unit BlzCreateUnitWithSkin(player id, int unitid, float x, float y, float face, int skinId);
		/// @CSharpLua.Template = "BlzCreateDestructableWithSkin({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern destructable BlzCreateDestructableWithSkin(int objectid, float x, float y, float face, float scale, int variation, int skinId);
		/// @CSharpLua.Template = "BlzCreateDestructableZWithSkin({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern destructable BlzCreateDestructableZWithSkin(int objectid, float x, float y, float z, float face, float scale, int variation, int skinId);
		/// @CSharpLua.Template = "BlzCreateDeadDestructableWithSkin({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern destructable BlzCreateDeadDestructableWithSkin(int objectid, float x, float y, float face, float scale, int variation, int skinId);
		/// @CSharpLua.Template = "BlzCreateDeadDestructableZWithSkin({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern destructable BlzCreateDeadDestructableZWithSkin(int objectid, float x, float y, float z, float face, float scale, int variation, int skinId);
		/// @CSharpLua.Template = "BlzGetPlayerTownHallCount({0})"
		public static extern int BlzGetPlayerTownHallCount(player whichPlayer);
		/// @CSharpLua.Template = "BlzQueueImmediateOrderById({0}, {1})"
		public static extern bool BlzQueueImmediateOrderById(unit whichUnit, int order);
		/// @CSharpLua.Template = "BlzQueuePointOrderById({0}, {1}, {2}, {3})"
		public static extern bool BlzQueuePointOrderById(unit whichUnit, int order, float x, float y);
		/// @CSharpLua.Template = "BlzQueueTargetOrderById({0}, {1}, {2})"
		public static extern bool BlzQueueTargetOrderById(unit whichUnit, int order, widget targetWidget);
		/// @CSharpLua.Template = "BlzQueueInstantPointOrderById({0}, {1}, {2}, {3}, {4})"
		public static extern bool BlzQueueInstantPointOrderById(unit whichUnit, int order, float x, float y, widget instantTargetWidget);
		/// @CSharpLua.Template = "BlzQueueInstantTargetOrderById({0}, {1}, {2}, {3})"
		public static extern bool BlzQueueInstantTargetOrderById(unit whichUnit, int order, widget targetWidget, widget instantTargetWidget);
		/// @CSharpLua.Template = "BlzQueueBuildOrderById({0}, {1}, {2}, {3})"
		public static extern bool BlzQueueBuildOrderById(unit whichPeon, int unitId, float x, float y);
		/// @CSharpLua.Template = "BlzQueueNeutralImmediateOrderById({0}, {1}, {2})"
		public static extern bool BlzQueueNeutralImmediateOrderById(player forWhichPlayer, unit neutralStructure, int unitId);
		/// @CSharpLua.Template = "BlzQueueNeutralPointOrderById({0}, {1}, {2}, {3}, {4})"
		public static extern bool BlzQueueNeutralPointOrderById(player forWhichPlayer, unit neutralStructure, int unitId, float x, float y);
		/// @CSharpLua.Template = "BlzQueueNeutralTargetOrderById({0}, {1}, {2}, {3})"
		public static extern bool BlzQueueNeutralTargetOrderById(player forWhichPlayer, unit neutralStructure, int unitId, widget target);
		/// @CSharpLua.Template = "BlzGetUnitOrderCount({0})"
		public static extern int BlzGetUnitOrderCount(unit whichUnit);
		/// @CSharpLua.Template = "BlzUnitClearOrders({0}, {1})"
		public static extern void BlzUnitClearOrders(unit whichUnit, bool onlyQueued);
		/// @CSharpLua.Template = "BlzUnitForceStopOrder({0}, {1})"
		public static extern void BlzUnitForceStopOrder(unit whichUnit, bool clearQueue);
	}
}
