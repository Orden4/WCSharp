using static WCSharp.Api.Common;

namespace WCSharp.Api
{
#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CA2211 // Non-constant fields should not be visible
	/// @CSharpLua.Ignore
	public static class Blizzard
	{        /// @CSharpLua.Template = "bj_PI"
		public const float bj_PI = 3.14159f;
		/// @CSharpLua.Template = "bj_E"
		public const float bj_E = 2.71828f;
		/// @CSharpLua.Template = "bj_CELLWIDTH"
		public const float bj_CELLWIDTH = 128.0f;
		/// @CSharpLua.Template = "bj_CLIFFHEIGHT"
		public const float bj_CLIFFHEIGHT = 128.0f;
		/// @CSharpLua.Template = "bj_UNIT_FACING"
		public const float bj_UNIT_FACING = 270.0f;
		/// @CSharpLua.Template = "bj_RADTODEG"
		public static readonly float bj_RADTODEG = 180.0f / bj_PI;
		/// @CSharpLua.Template = "bj_DEGTORAD"
		public static readonly float bj_DEGTORAD = bj_PI / 180.0f;
		/// @CSharpLua.Template = "bj_TEXT_DELAY_QUEST"
		public const float bj_TEXT_DELAY_QUEST = 20.00f;
		/// @CSharpLua.Template = "bj_TEXT_DELAY_QUESTUPDATE"
		public const float bj_TEXT_DELAY_QUESTUPDATE = 20.00f;
		/// @CSharpLua.Template = "bj_TEXT_DELAY_QUESTDONE"
		public const float bj_TEXT_DELAY_QUESTDONE = 20.00f;
		/// @CSharpLua.Template = "bj_TEXT_DELAY_QUESTFAILED"
		public const float bj_TEXT_DELAY_QUESTFAILED = 20.00f;
		/// @CSharpLua.Template = "bj_TEXT_DELAY_QUESTREQUIREMENT"
		public const float bj_TEXT_DELAY_QUESTREQUIREMENT = 20.00f;
		/// @CSharpLua.Template = "bj_TEXT_DELAY_MISSIONFAILED"
		public const float bj_TEXT_DELAY_MISSIONFAILED = 20.00f;
		/// @CSharpLua.Template = "bj_TEXT_DELAY_ALWAYSHINT"
		public const float bj_TEXT_DELAY_ALWAYSHINT = 12.00f;
		/// @CSharpLua.Template = "bj_TEXT_DELAY_HINT"
		public const float bj_TEXT_DELAY_HINT = 12.00f;
		/// @CSharpLua.Template = "bj_TEXT_DELAY_SECRET"
		public const float bj_TEXT_DELAY_SECRET = 10.00f;
		/// @CSharpLua.Template = "bj_TEXT_DELAY_UNITACQUIRED"
		public const float bj_TEXT_DELAY_UNITACQUIRED = 15.00f;
		/// @CSharpLua.Template = "bj_TEXT_DELAY_UNITAVAILABLE"
		public const float bj_TEXT_DELAY_UNITAVAILABLE = 10.00f;
		/// @CSharpLua.Template = "bj_TEXT_DELAY_ITEMACQUIRED"
		public const float bj_TEXT_DELAY_ITEMACQUIRED = 10.00f;
		/// @CSharpLua.Template = "bj_TEXT_DELAY_WARNING"
		public const float bj_TEXT_DELAY_WARNING = 12.00f;
		/// @CSharpLua.Template = "bj_QUEUE_DELAY_QUEST"
		public const float bj_QUEUE_DELAY_QUEST = 5.00f;
		/// @CSharpLua.Template = "bj_QUEUE_DELAY_HINT"
		public const float bj_QUEUE_DELAY_HINT = 5.00f;
		/// @CSharpLua.Template = "bj_QUEUE_DELAY_SECRET"
		public const float bj_QUEUE_DELAY_SECRET = 3.00f;
		/// @CSharpLua.Template = "bj_HANDICAP_EASY"
		public const float bj_HANDICAP_EASY = 60.00f;
		/// @CSharpLua.Template = "bj_HANDICAP_NORMAL"
		public const float bj_HANDICAP_NORMAL = 90.00f;
		/// @CSharpLua.Template = "bj_HANDICAPDAMAGE_EASY"
		public const float bj_HANDICAPDAMAGE_EASY = 50.00f;
		/// @CSharpLua.Template = "bj_HANDICAPDAMAGE_NORMAL"
		public const float bj_HANDICAPDAMAGE_NORMAL = 90.00f;
		/// @CSharpLua.Template = "bj_HANDICAPREVIVE_NOTHARD"
		public const float bj_HANDICAPREVIVE_NOTHARD = 50.00f;
		/// @CSharpLua.Template = "bj_GAME_STARTED_THRESHOLD"
		public const float bj_GAME_STARTED_THRESHOLD = 0.01f;
		/// @CSharpLua.Template = "bj_WAIT_FOR_COND_MIN_INTERVAL"
		public const float bj_WAIT_FOR_COND_MIN_INTERVAL = 0.10f;
		/// @CSharpLua.Template = "bj_POLLED_WAIT_INTERVAL"
		public const float bj_POLLED_WAIT_INTERVAL = 0.10f;
		/// @CSharpLua.Template = "bj_POLLED_WAIT_SKIP_THRESHOLD"
		public const float bj_POLLED_WAIT_SKIP_THRESHOLD = 2.00f;
		/// @CSharpLua.Template = "bj_MAX_INVENTORY"
		public const int bj_MAX_INVENTORY = 6;
		/// @CSharpLua.Template = "bj_MAX_PLAYERS"
		public static readonly int bj_MAX_PLAYERS = GetBJMaxPlayers();
		/// @CSharpLua.Template = "bj_PLAYER_NEUTRAL_VICTIM"
		public static readonly int bj_PLAYER_NEUTRAL_VICTIM = GetBJPlayerNeutralVictim();
		/// @CSharpLua.Template = "bj_PLAYER_NEUTRAL_EXTRA"
		public static readonly int bj_PLAYER_NEUTRAL_EXTRA = GetBJPlayerNeutralExtra();
		/// @CSharpLua.Template = "bj_MAX_PLAYER_SLOTS"
		public static readonly int bj_MAX_PLAYER_SLOTS = GetBJMaxPlayerSlots();
		/// @CSharpLua.Template = "bj_MAX_SKELETONS"
		public const int bj_MAX_SKELETONS = 25;
		/// @CSharpLua.Template = "bj_MAX_STOCK_ITEM_SLOTS"
		public const int bj_MAX_STOCK_ITEM_SLOTS = 11;
		/// @CSharpLua.Template = "bj_MAX_STOCK_UNIT_SLOTS"
		public const int bj_MAX_STOCK_UNIT_SLOTS = 11;
		/// @CSharpLua.Template = "bj_MAX_ITEM_LEVEL"
		public const int bj_MAX_ITEM_LEVEL = 10;
		/// @CSharpLua.Template = "bj_MAX_CHECKPOINTS"
		public const int bj_MAX_CHECKPOINTS = 5;
		/// @CSharpLua.Template = "bj_TOD_DAWN"
		public const float bj_TOD_DAWN = 6.00f;
		/// @CSharpLua.Template = "bj_TOD_DUSK"
		public const float bj_TOD_DUSK = 18.00f;
		/// @CSharpLua.Template = "bj_MELEE_STARTING_TOD"
		public const float bj_MELEE_STARTING_TOD = 8.00f;
		/// @CSharpLua.Template = "bj_MELEE_STARTING_GOLD_V0"
		public const int bj_MELEE_STARTING_GOLD_V0 = 750;
		/// @CSharpLua.Template = "bj_MELEE_STARTING_GOLD_V1"
		public const int bj_MELEE_STARTING_GOLD_V1 = 500;
		/// @CSharpLua.Template = "bj_MELEE_STARTING_LUMBER_V0"
		public const int bj_MELEE_STARTING_LUMBER_V0 = 200;
		/// @CSharpLua.Template = "bj_MELEE_STARTING_LUMBER_V1"
		public const int bj_MELEE_STARTING_LUMBER_V1 = 150;
		/// @CSharpLua.Template = "bj_MELEE_STARTING_HERO_TOKENS"
		public const int bj_MELEE_STARTING_HERO_TOKENS = 1;
		/// @CSharpLua.Template = "bj_MELEE_HERO_LIMIT"
		public const int bj_MELEE_HERO_LIMIT = 3;
		/// @CSharpLua.Template = "bj_MELEE_HERO_TYPE_LIMIT"
		public const int bj_MELEE_HERO_TYPE_LIMIT = 1;
		/// @CSharpLua.Template = "bj_MELEE_MINE_SEARCH_RADIUS"
		public const float bj_MELEE_MINE_SEARCH_RADIUS = 2000;
		/// @CSharpLua.Template = "bj_MELEE_CLEAR_UNITS_RADIUS"
		public const float bj_MELEE_CLEAR_UNITS_RADIUS = 1500;
		/// @CSharpLua.Template = "bj_MELEE_CRIPPLE_TIMEOUT"
		public const float bj_MELEE_CRIPPLE_TIMEOUT = 120.00f;
		/// @CSharpLua.Template = "bj_MELEE_CRIPPLE_MSG_DURATION"
		public const float bj_MELEE_CRIPPLE_MSG_DURATION = 20.00f;
		/// @CSharpLua.Template = "bj_MELEE_MAX_TWINKED_HEROES_V0"
		public const int bj_MELEE_MAX_TWINKED_HEROES_V0 = 3;
		/// @CSharpLua.Template = "bj_MELEE_MAX_TWINKED_HEROES_V1"
		public const int bj_MELEE_MAX_TWINKED_HEROES_V1 = 1;
		/// @CSharpLua.Template = "bj_CREEP_ITEM_DELAY"
		public const float bj_CREEP_ITEM_DELAY = 0.50f;
		/// @CSharpLua.Template = "bj_STOCK_RESTOCK_INITIAL_DELAY"
		public const float bj_STOCK_RESTOCK_INITIAL_DELAY = 120;
		/// @CSharpLua.Template = "bj_STOCK_RESTOCK_INTERVAL"
		public const float bj_STOCK_RESTOCK_INTERVAL = 30;
		/// @CSharpLua.Template = "bj_STOCK_MAX_ITERATIONS"
		public const int bj_STOCK_MAX_ITERATIONS = 20;
		/// @CSharpLua.Template = "bj_MAX_DEST_IN_REGION_EVENTS"
		public const int bj_MAX_DEST_IN_REGION_EVENTS = 64;
		/// @CSharpLua.Template = "bj_CAMERA_MIN_FARZ"
		public const int bj_CAMERA_MIN_FARZ = 100;
		/// @CSharpLua.Template = "bj_CAMERA_DEFAULT_DISTANCE"
		public const int bj_CAMERA_DEFAULT_DISTANCE = 1650;
		/// @CSharpLua.Template = "bj_CAMERA_DEFAULT_FARZ"
		public const int bj_CAMERA_DEFAULT_FARZ = 5000;
		/// @CSharpLua.Template = "bj_CAMERA_DEFAULT_AOA"
		public const int bj_CAMERA_DEFAULT_AOA = 304;
		/// @CSharpLua.Template = "bj_CAMERA_DEFAULT_FOV"
		public const int bj_CAMERA_DEFAULT_FOV = 70;
		/// @CSharpLua.Template = "bj_CAMERA_DEFAULT_ROLL"
		public const int bj_CAMERA_DEFAULT_ROLL = 0;
		/// @CSharpLua.Template = "bj_CAMERA_DEFAULT_ROTATION"
		public const int bj_CAMERA_DEFAULT_ROTATION = 90;
		/// @CSharpLua.Template = "bj_RESCUE_PING_TIME"
		public const float bj_RESCUE_PING_TIME = 2.00f;
		/// @CSharpLua.Template = "bj_NOTHING_SOUND_DURATION"
		public const float bj_NOTHING_SOUND_DURATION = 5.00f;
		/// @CSharpLua.Template = "bj_TRANSMISSION_PING_TIME"
		public const float bj_TRANSMISSION_PING_TIME = 1.00f;
		/// @CSharpLua.Template = "bj_TRANSMISSION_IND_RED"
		public const int bj_TRANSMISSION_IND_RED = 255;
		/// @CSharpLua.Template = "bj_TRANSMISSION_IND_BLUE"
		public const int bj_TRANSMISSION_IND_BLUE = 255;
		/// @CSharpLua.Template = "bj_TRANSMISSION_IND_GREEN"
		public const int bj_TRANSMISSION_IND_GREEN = 255;
		/// @CSharpLua.Template = "bj_TRANSMISSION_IND_ALPHA"
		public const int bj_TRANSMISSION_IND_ALPHA = 255;
		/// @CSharpLua.Template = "bj_TRANSMISSION_PORT_HANGTIME"
		public const float bj_TRANSMISSION_PORT_HANGTIME = 1.50f;
		/// @CSharpLua.Template = "bj_CINEMODE_INTERFACEFADE"
		public const float bj_CINEMODE_INTERFACEFADE = 0.50f;
		/// @CSharpLua.Template = "bj_CINEMODE_GAMESPEED"
		public static readonly gamespeed bj_CINEMODE_GAMESPEED = MAP_SPEED_NORMAL;
		/// @CSharpLua.Template = "bj_CINEMODE_VOLUME_UNITMOVEMENT"
		public const float bj_CINEMODE_VOLUME_UNITMOVEMENT = 0.40f;
		/// @CSharpLua.Template = "bj_CINEMODE_VOLUME_UNITSOUNDS"
		public const float bj_CINEMODE_VOLUME_UNITSOUNDS = 0.00f;
		/// @CSharpLua.Template = "bj_CINEMODE_VOLUME_COMBAT"
		public const float bj_CINEMODE_VOLUME_COMBAT = 0.40f;
		/// @CSharpLua.Template = "bj_CINEMODE_VOLUME_SPELLS"
		public const float bj_CINEMODE_VOLUME_SPELLS = 0.40f;
		/// @CSharpLua.Template = "bj_CINEMODE_VOLUME_UI"
		public const float bj_CINEMODE_VOLUME_UI = 0.00f;
		/// @CSharpLua.Template = "bj_CINEMODE_VOLUME_MUSIC"
		public const float bj_CINEMODE_VOLUME_MUSIC = 0.55f;
		/// @CSharpLua.Template = "bj_CINEMODE_VOLUME_AMBIENTSOUNDS"
		public const float bj_CINEMODE_VOLUME_AMBIENTSOUNDS = 1.00f;
		/// @CSharpLua.Template = "bj_CINEMODE_VOLUME_FIRE"
		public const float bj_CINEMODE_VOLUME_FIRE = 0.60f;
		/// @CSharpLua.Template = "bj_SPEECH_VOLUME_UNITMOVEMENT"
		public const float bj_SPEECH_VOLUME_UNITMOVEMENT = 0.25f;
		/// @CSharpLua.Template = "bj_SPEECH_VOLUME_UNITSOUNDS"
		public const float bj_SPEECH_VOLUME_UNITSOUNDS = 0.00f;
		/// @CSharpLua.Template = "bj_SPEECH_VOLUME_COMBAT"
		public const float bj_SPEECH_VOLUME_COMBAT = 0.25f;
		/// @CSharpLua.Template = "bj_SPEECH_VOLUME_SPELLS"
		public const float bj_SPEECH_VOLUME_SPELLS = 0.25f;
		/// @CSharpLua.Template = "bj_SPEECH_VOLUME_UI"
		public const float bj_SPEECH_VOLUME_UI = 0.00f;
		/// @CSharpLua.Template = "bj_SPEECH_VOLUME_MUSIC"
		public const float bj_SPEECH_VOLUME_MUSIC = 0.55f;
		/// @CSharpLua.Template = "bj_SPEECH_VOLUME_AMBIENTSOUNDS"
		public const float bj_SPEECH_VOLUME_AMBIENTSOUNDS = 1.00f;
		/// @CSharpLua.Template = "bj_SPEECH_VOLUME_FIRE"
		public const float bj_SPEECH_VOLUME_FIRE = 0.60f;
		/// @CSharpLua.Template = "bj_SMARTPAN_TRESHOLD_PAN"
		public const float bj_SMARTPAN_TRESHOLD_PAN = 500;
		/// @CSharpLua.Template = "bj_SMARTPAN_TRESHOLD_SNAP"
		public const float bj_SMARTPAN_TRESHOLD_SNAP = 3500;
		/// @CSharpLua.Template = "bj_MAX_QUEUED_TRIGGERS"
		public const int bj_MAX_QUEUED_TRIGGERS = 100;
		/// @CSharpLua.Template = "bj_QUEUED_TRIGGER_TIMEOUT"
		public const float bj_QUEUED_TRIGGER_TIMEOUT = 180.00f;
		/// @CSharpLua.Template = "bj_CAMPAIGN_INDEX_T"
		public const int bj_CAMPAIGN_INDEX_T = 0;
		/// @CSharpLua.Template = "bj_CAMPAIGN_INDEX_H"
		public const int bj_CAMPAIGN_INDEX_H = 1;
		/// @CSharpLua.Template = "bj_CAMPAIGN_INDEX_U"
		public const int bj_CAMPAIGN_INDEX_U = 2;
		/// @CSharpLua.Template = "bj_CAMPAIGN_INDEX_O"
		public const int bj_CAMPAIGN_INDEX_O = 3;
		/// @CSharpLua.Template = "bj_CAMPAIGN_INDEX_N"
		public const int bj_CAMPAIGN_INDEX_N = 4;
		/// @CSharpLua.Template = "bj_CAMPAIGN_INDEX_XN"
		public const int bj_CAMPAIGN_INDEX_XN = 5;
		/// @CSharpLua.Template = "bj_CAMPAIGN_INDEX_XH"
		public const int bj_CAMPAIGN_INDEX_XH = 6;
		/// @CSharpLua.Template = "bj_CAMPAIGN_INDEX_XU"
		public const int bj_CAMPAIGN_INDEX_XU = 7;
		/// @CSharpLua.Template = "bj_CAMPAIGN_INDEX_XO"
		public const int bj_CAMPAIGN_INDEX_XO = 8;
		/// @CSharpLua.Template = "bj_CAMPAIGN_OFFSET_T"
		public const int bj_CAMPAIGN_OFFSET_T = 0;
		/// @CSharpLua.Template = "bj_CAMPAIGN_OFFSET_H"
		public const int bj_CAMPAIGN_OFFSET_H = 1;
		/// @CSharpLua.Template = "bj_CAMPAIGN_OFFSET_U"
		public const int bj_CAMPAIGN_OFFSET_U = 2;
		/// @CSharpLua.Template = "bj_CAMPAIGN_OFFSET_O"
		public const int bj_CAMPAIGN_OFFSET_O = 3;
		/// @CSharpLua.Template = "bj_CAMPAIGN_OFFSET_N"
		public const int bj_CAMPAIGN_OFFSET_N = 4;
		/// @CSharpLua.Template = "bj_CAMPAIGN_OFFSET_XN"
		public const int bj_CAMPAIGN_OFFSET_XN = 5;
		/// @CSharpLua.Template = "bj_CAMPAIGN_OFFSET_XH"
		public const int bj_CAMPAIGN_OFFSET_XH = 6;
		/// @CSharpLua.Template = "bj_CAMPAIGN_OFFSET_XU"
		public const int bj_CAMPAIGN_OFFSET_XU = 7;
		/// @CSharpLua.Template = "bj_CAMPAIGN_OFFSET_XO"
		public const int bj_CAMPAIGN_OFFSET_XO = 8;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_T00"
		public static readonly int bj_MISSION_INDEX_T00 = (bj_CAMPAIGN_OFFSET_T * 1000) + 0;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_T01"
		public static readonly int bj_MISSION_INDEX_T01 = (bj_CAMPAIGN_OFFSET_T * 1000) + 1;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_T02"
		public static readonly int bj_MISSION_INDEX_T02 = (bj_CAMPAIGN_OFFSET_T * 1000) + 2;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_T03"
		public static readonly int bj_MISSION_INDEX_T03 = (bj_CAMPAIGN_OFFSET_T * 1000) + 3;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_T04"
		public static readonly int bj_MISSION_INDEX_T04 = (bj_CAMPAIGN_OFFSET_T * 1000) + 4;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_H00"
		public static readonly int bj_MISSION_INDEX_H00 = (bj_CAMPAIGN_OFFSET_H * 1000) + 0;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_H01"
		public static readonly int bj_MISSION_INDEX_H01 = (bj_CAMPAIGN_OFFSET_H * 1000) + 1;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_H02"
		public static readonly int bj_MISSION_INDEX_H02 = (bj_CAMPAIGN_OFFSET_H * 1000) + 2;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_H03"
		public static readonly int bj_MISSION_INDEX_H03 = (bj_CAMPAIGN_OFFSET_H * 1000) + 3;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_H04"
		public static readonly int bj_MISSION_INDEX_H04 = (bj_CAMPAIGN_OFFSET_H * 1000) + 4;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_H05"
		public static readonly int bj_MISSION_INDEX_H05 = (bj_CAMPAIGN_OFFSET_H * 1000) + 5;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_H06"
		public static readonly int bj_MISSION_INDEX_H06 = (bj_CAMPAIGN_OFFSET_H * 1000) + 6;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_H07"
		public static readonly int bj_MISSION_INDEX_H07 = (bj_CAMPAIGN_OFFSET_H * 1000) + 7;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_H08"
		public static readonly int bj_MISSION_INDEX_H08 = (bj_CAMPAIGN_OFFSET_H * 1000) + 8;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_H09"
		public static readonly int bj_MISSION_INDEX_H09 = (bj_CAMPAIGN_OFFSET_H * 1000) + 9;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_H10"
		public static readonly int bj_MISSION_INDEX_H10 = (bj_CAMPAIGN_OFFSET_H * 1000) + 10;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_H11"
		public static readonly int bj_MISSION_INDEX_H11 = (bj_CAMPAIGN_OFFSET_H * 1000) + 11;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_U00"
		public static readonly int bj_MISSION_INDEX_U00 = (bj_CAMPAIGN_OFFSET_U * 1000) + 0;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_U01"
		public static readonly int bj_MISSION_INDEX_U01 = (bj_CAMPAIGN_OFFSET_U * 1000) + 1;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_U02"
		public static readonly int bj_MISSION_INDEX_U02 = (bj_CAMPAIGN_OFFSET_U * 1000) + 2;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_U03"
		public static readonly int bj_MISSION_INDEX_U03 = (bj_CAMPAIGN_OFFSET_U * 1000) + 3;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_U05"
		public static readonly int bj_MISSION_INDEX_U05 = (bj_CAMPAIGN_OFFSET_U * 1000) + 4;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_U07"
		public static readonly int bj_MISSION_INDEX_U07 = (bj_CAMPAIGN_OFFSET_U * 1000) + 5;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_U08"
		public static readonly int bj_MISSION_INDEX_U08 = (bj_CAMPAIGN_OFFSET_U * 1000) + 6;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_U09"
		public static readonly int bj_MISSION_INDEX_U09 = (bj_CAMPAIGN_OFFSET_U * 1000) + 7;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_U10"
		public static readonly int bj_MISSION_INDEX_U10 = (bj_CAMPAIGN_OFFSET_U * 1000) + 8;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_U11"
		public static readonly int bj_MISSION_INDEX_U11 = (bj_CAMPAIGN_OFFSET_U * 1000) + 9;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_O00"
		public static readonly int bj_MISSION_INDEX_O00 = (bj_CAMPAIGN_OFFSET_O * 1000) + 0;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_O01"
		public static readonly int bj_MISSION_INDEX_O01 = (bj_CAMPAIGN_OFFSET_O * 1000) + 1;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_O02"
		public static readonly int bj_MISSION_INDEX_O02 = (bj_CAMPAIGN_OFFSET_O * 1000) + 2;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_O03"
		public static readonly int bj_MISSION_INDEX_O03 = (bj_CAMPAIGN_OFFSET_O * 1000) + 3;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_O04"
		public static readonly int bj_MISSION_INDEX_O04 = (bj_CAMPAIGN_OFFSET_O * 1000) + 4;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_O05"
		public static readonly int bj_MISSION_INDEX_O05 = (bj_CAMPAIGN_OFFSET_O * 1000) + 5;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_O06"
		public static readonly int bj_MISSION_INDEX_O06 = (bj_CAMPAIGN_OFFSET_O * 1000) + 6;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_O07"
		public static readonly int bj_MISSION_INDEX_O07 = (bj_CAMPAIGN_OFFSET_O * 1000) + 7;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_O08"
		public static readonly int bj_MISSION_INDEX_O08 = (bj_CAMPAIGN_OFFSET_O * 1000) + 8;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_O09"
		public static readonly int bj_MISSION_INDEX_O09 = (bj_CAMPAIGN_OFFSET_O * 1000) + 9;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_O10"
		public static readonly int bj_MISSION_INDEX_O10 = (bj_CAMPAIGN_OFFSET_O * 1000) + 10;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_N00"
		public static readonly int bj_MISSION_INDEX_N00 = (bj_CAMPAIGN_OFFSET_N * 1000) + 0;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_N01"
		public static readonly int bj_MISSION_INDEX_N01 = (bj_CAMPAIGN_OFFSET_N * 1000) + 1;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_N02"
		public static readonly int bj_MISSION_INDEX_N02 = (bj_CAMPAIGN_OFFSET_N * 1000) + 2;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_N03"
		public static readonly int bj_MISSION_INDEX_N03 = (bj_CAMPAIGN_OFFSET_N * 1000) + 3;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_N04"
		public static readonly int bj_MISSION_INDEX_N04 = (bj_CAMPAIGN_OFFSET_N * 1000) + 4;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_N05"
		public static readonly int bj_MISSION_INDEX_N05 = (bj_CAMPAIGN_OFFSET_N * 1000) + 5;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_N06"
		public static readonly int bj_MISSION_INDEX_N06 = (bj_CAMPAIGN_OFFSET_N * 1000) + 6;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_N07"
		public static readonly int bj_MISSION_INDEX_N07 = (bj_CAMPAIGN_OFFSET_N * 1000) + 7;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_N08"
		public static readonly int bj_MISSION_INDEX_N08 = (bj_CAMPAIGN_OFFSET_N * 1000) + 8;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_N09"
		public static readonly int bj_MISSION_INDEX_N09 = (bj_CAMPAIGN_OFFSET_N * 1000) + 9;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XN00"
		public static readonly int bj_MISSION_INDEX_XN00 = (bj_CAMPAIGN_OFFSET_XN * 1000) + 0;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XN01"
		public static readonly int bj_MISSION_INDEX_XN01 = (bj_CAMPAIGN_OFFSET_XN * 1000) + 1;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XN02"
		public static readonly int bj_MISSION_INDEX_XN02 = (bj_CAMPAIGN_OFFSET_XN * 1000) + 2;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XN03"
		public static readonly int bj_MISSION_INDEX_XN03 = (bj_CAMPAIGN_OFFSET_XN * 1000) + 3;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XN04"
		public static readonly int bj_MISSION_INDEX_XN04 = (bj_CAMPAIGN_OFFSET_XN * 1000) + 4;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XN05"
		public static readonly int bj_MISSION_INDEX_XN05 = (bj_CAMPAIGN_OFFSET_XN * 1000) + 5;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XN06"
		public static readonly int bj_MISSION_INDEX_XN06 = (bj_CAMPAIGN_OFFSET_XN * 1000) + 6;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XN07"
		public static readonly int bj_MISSION_INDEX_XN07 = (bj_CAMPAIGN_OFFSET_XN * 1000) + 7;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XN08"
		public static readonly int bj_MISSION_INDEX_XN08 = (bj_CAMPAIGN_OFFSET_XN * 1000) + 8;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XN09"
		public static readonly int bj_MISSION_INDEX_XN09 = (bj_CAMPAIGN_OFFSET_XN * 1000) + 9;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XN10"
		public static readonly int bj_MISSION_INDEX_XN10 = (bj_CAMPAIGN_OFFSET_XN * 1000) + 10;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XH00"
		public static readonly int bj_MISSION_INDEX_XH00 = (bj_CAMPAIGN_OFFSET_XH * 1000) + 0;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XH01"
		public static readonly int bj_MISSION_INDEX_XH01 = (bj_CAMPAIGN_OFFSET_XH * 1000) + 1;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XH02"
		public static readonly int bj_MISSION_INDEX_XH02 = (bj_CAMPAIGN_OFFSET_XH * 1000) + 2;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XH03"
		public static readonly int bj_MISSION_INDEX_XH03 = (bj_CAMPAIGN_OFFSET_XH * 1000) + 3;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XH04"
		public static readonly int bj_MISSION_INDEX_XH04 = (bj_CAMPAIGN_OFFSET_XH * 1000) + 4;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XH05"
		public static readonly int bj_MISSION_INDEX_XH05 = (bj_CAMPAIGN_OFFSET_XH * 1000) + 5;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XH06"
		public static readonly int bj_MISSION_INDEX_XH06 = (bj_CAMPAIGN_OFFSET_XH * 1000) + 6;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XH07"
		public static readonly int bj_MISSION_INDEX_XH07 = (bj_CAMPAIGN_OFFSET_XH * 1000) + 7;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XH08"
		public static readonly int bj_MISSION_INDEX_XH08 = (bj_CAMPAIGN_OFFSET_XH * 1000) + 8;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XH09"
		public static readonly int bj_MISSION_INDEX_XH09 = (bj_CAMPAIGN_OFFSET_XH * 1000) + 9;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU00"
		public static readonly int bj_MISSION_INDEX_XU00 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 0;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU01"
		public static readonly int bj_MISSION_INDEX_XU01 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 1;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU02"
		public static readonly int bj_MISSION_INDEX_XU02 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 2;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU03"
		public static readonly int bj_MISSION_INDEX_XU03 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 3;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU04"
		public static readonly int bj_MISSION_INDEX_XU04 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 4;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU05"
		public static readonly int bj_MISSION_INDEX_XU05 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 5;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU06"
		public static readonly int bj_MISSION_INDEX_XU06 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 6;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU07"
		public static readonly int bj_MISSION_INDEX_XU07 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 7;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU08"
		public static readonly int bj_MISSION_INDEX_XU08 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 8;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU09"
		public static readonly int bj_MISSION_INDEX_XU09 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 9;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU10"
		public static readonly int bj_MISSION_INDEX_XU10 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 10;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU11"
		public static readonly int bj_MISSION_INDEX_XU11 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 11;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU12"
		public static readonly int bj_MISSION_INDEX_XU12 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 12;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XU13"
		public static readonly int bj_MISSION_INDEX_XU13 = (bj_CAMPAIGN_OFFSET_XU * 1000) + 13;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XO00"
		public static readonly int bj_MISSION_INDEX_XO00 = (bj_CAMPAIGN_OFFSET_XO * 1000) + 0;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XO01"
		public static readonly int bj_MISSION_INDEX_XO01 = (bj_CAMPAIGN_OFFSET_XO * 1000) + 1;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XO02"
		public static readonly int bj_MISSION_INDEX_XO02 = (bj_CAMPAIGN_OFFSET_XO * 1000) + 2;
		/// @CSharpLua.Template = "bj_MISSION_INDEX_XO03"
		public static readonly int bj_MISSION_INDEX_XO03 = (bj_CAMPAIGN_OFFSET_XO * 1000) + 3;
		/// @CSharpLua.Template = "bj_CINEMATICINDEX_TOP"
		public const int bj_CINEMATICINDEX_TOP = 0;
		/// @CSharpLua.Template = "bj_CINEMATICINDEX_HOP"
		public const int bj_CINEMATICINDEX_HOP = 1;
		/// @CSharpLua.Template = "bj_CINEMATICINDEX_HED"
		public const int bj_CINEMATICINDEX_HED = 2;
		/// @CSharpLua.Template = "bj_CINEMATICINDEX_OOP"
		public const int bj_CINEMATICINDEX_OOP = 3;
		/// @CSharpLua.Template = "bj_CINEMATICINDEX_OED"
		public const int bj_CINEMATICINDEX_OED = 4;
		/// @CSharpLua.Template = "bj_CINEMATICINDEX_UOP"
		public const int bj_CINEMATICINDEX_UOP = 5;
		/// @CSharpLua.Template = "bj_CINEMATICINDEX_UED"
		public const int bj_CINEMATICINDEX_UED = 6;
		/// @CSharpLua.Template = "bj_CINEMATICINDEX_NOP"
		public const int bj_CINEMATICINDEX_NOP = 7;
		/// @CSharpLua.Template = "bj_CINEMATICINDEX_NED"
		public const int bj_CINEMATICINDEX_NED = 8;
		/// @CSharpLua.Template = "bj_CINEMATICINDEX_XOP"
		public const int bj_CINEMATICINDEX_XOP = 9;
		/// @CSharpLua.Template = "bj_CINEMATICINDEX_XED"
		public const int bj_CINEMATICINDEX_XED = 10;
		/// @CSharpLua.Template = "bj_ALLIANCE_UNALLIED"
		public const int bj_ALLIANCE_UNALLIED = 0;
		/// @CSharpLua.Template = "bj_ALLIANCE_UNALLIED_VISION"
		public const int bj_ALLIANCE_UNALLIED_VISION = 1;
		/// @CSharpLua.Template = "bj_ALLIANCE_ALLIED"
		public const int bj_ALLIANCE_ALLIED = 2;
		/// @CSharpLua.Template = "bj_ALLIANCE_ALLIED_VISION"
		public const int bj_ALLIANCE_ALLIED_VISION = 3;
		/// @CSharpLua.Template = "bj_ALLIANCE_ALLIED_UNITS"
		public const int bj_ALLIANCE_ALLIED_UNITS = 4;
		/// @CSharpLua.Template = "bj_ALLIANCE_ALLIED_ADVUNITS"
		public const int bj_ALLIANCE_ALLIED_ADVUNITS = 5;
		/// @CSharpLua.Template = "bj_ALLIANCE_NEUTRAL"
		public const int bj_ALLIANCE_NEUTRAL = 6;
		/// @CSharpLua.Template = "bj_ALLIANCE_NEUTRAL_VISION"
		public const int bj_ALLIANCE_NEUTRAL_VISION = 7;
		/// @CSharpLua.Template = "bj_KEYEVENTTYPE_DEPRESS"
		public const int bj_KEYEVENTTYPE_DEPRESS = 0;
		/// @CSharpLua.Template = "bj_KEYEVENTTYPE_RELEASE"
		public const int bj_KEYEVENTTYPE_RELEASE = 1;
		/// @CSharpLua.Template = "bj_KEYEVENTKEY_LEFT"
		public const int bj_KEYEVENTKEY_LEFT = 0;
		/// @CSharpLua.Template = "bj_KEYEVENTKEY_RIGHT"
		public const int bj_KEYEVENTKEY_RIGHT = 1;
		/// @CSharpLua.Template = "bj_KEYEVENTKEY_DOWN"
		public const int bj_KEYEVENTKEY_DOWN = 2;
		/// @CSharpLua.Template = "bj_KEYEVENTKEY_UP"
		public const int bj_KEYEVENTKEY_UP = 3;
		/// @CSharpLua.Template = "bj_MOUSEEVENTTYPE_DOWN"
		public const int bj_MOUSEEVENTTYPE_DOWN = 0;
		/// @CSharpLua.Template = "bj_MOUSEEVENTTYPE_UP"
		public const int bj_MOUSEEVENTTYPE_UP = 1;
		/// @CSharpLua.Template = "bj_MOUSEEVENTTYPE_MOVE"
		public const int bj_MOUSEEVENTTYPE_MOVE = 2;
		/// @CSharpLua.Template = "bj_TIMETYPE_ADD"
		public const int bj_TIMETYPE_ADD = 0;
		/// @CSharpLua.Template = "bj_TIMETYPE_SET"
		public const int bj_TIMETYPE_SET = 1;
		/// @CSharpLua.Template = "bj_TIMETYPE_SUB"
		public const int bj_TIMETYPE_SUB = 2;
		/// @CSharpLua.Template = "bj_CAMERABOUNDS_ADJUST_ADD"
		public const int bj_CAMERABOUNDS_ADJUST_ADD = 0;
		/// @CSharpLua.Template = "bj_CAMERABOUNDS_ADJUST_SUB"
		public const int bj_CAMERABOUNDS_ADJUST_SUB = 1;
		/// @CSharpLua.Template = "bj_QUESTTYPE_REQ_DISCOVERED"
		public const int bj_QUESTTYPE_REQ_DISCOVERED = 0;
		/// @CSharpLua.Template = "bj_QUESTTYPE_REQ_UNDISCOVERED"
		public const int bj_QUESTTYPE_REQ_UNDISCOVERED = 1;
		/// @CSharpLua.Template = "bj_QUESTTYPE_OPT_DISCOVERED"
		public const int bj_QUESTTYPE_OPT_DISCOVERED = 2;
		/// @CSharpLua.Template = "bj_QUESTTYPE_OPT_UNDISCOVERED"
		public const int bj_QUESTTYPE_OPT_UNDISCOVERED = 3;
		/// @CSharpLua.Template = "bj_QUESTMESSAGE_DISCOVERED"
		public const int bj_QUESTMESSAGE_DISCOVERED = 0;
		/// @CSharpLua.Template = "bj_QUESTMESSAGE_UPDATED"
		public const int bj_QUESTMESSAGE_UPDATED = 1;
		/// @CSharpLua.Template = "bj_QUESTMESSAGE_COMPLETED"
		public const int bj_QUESTMESSAGE_COMPLETED = 2;
		/// @CSharpLua.Template = "bj_QUESTMESSAGE_FAILED"
		public const int bj_QUESTMESSAGE_FAILED = 3;
		/// @CSharpLua.Template = "bj_QUESTMESSAGE_REQUIREMENT"
		public const int bj_QUESTMESSAGE_REQUIREMENT = 4;
		/// @CSharpLua.Template = "bj_QUESTMESSAGE_MISSIONFAILED"
		public const int bj_QUESTMESSAGE_MISSIONFAILED = 5;
		/// @CSharpLua.Template = "bj_QUESTMESSAGE_ALWAYSHINT"
		public const int bj_QUESTMESSAGE_ALWAYSHINT = 6;
		/// @CSharpLua.Template = "bj_QUESTMESSAGE_HINT"
		public const int bj_QUESTMESSAGE_HINT = 7;
		/// @CSharpLua.Template = "bj_QUESTMESSAGE_SECRET"
		public const int bj_QUESTMESSAGE_SECRET = 8;
		/// @CSharpLua.Template = "bj_QUESTMESSAGE_UNITACQUIRED"
		public const int bj_QUESTMESSAGE_UNITACQUIRED = 9;
		/// @CSharpLua.Template = "bj_QUESTMESSAGE_UNITAVAILABLE"
		public const int bj_QUESTMESSAGE_UNITAVAILABLE = 10;
		/// @CSharpLua.Template = "bj_QUESTMESSAGE_ITEMACQUIRED"
		public const int bj_QUESTMESSAGE_ITEMACQUIRED = 11;
		/// @CSharpLua.Template = "bj_QUESTMESSAGE_WARNING"
		public const int bj_QUESTMESSAGE_WARNING = 12;
		/// @CSharpLua.Template = "bj_SORTTYPE_SORTBYVALUE"
		public const int bj_SORTTYPE_SORTBYVALUE = 0;
		/// @CSharpLua.Template = "bj_SORTTYPE_SORTBYPLAYER"
		public const int bj_SORTTYPE_SORTBYPLAYER = 1;
		/// @CSharpLua.Template = "bj_SORTTYPE_SORTBYLABEL"
		public const int bj_SORTTYPE_SORTBYLABEL = 2;
		/// @CSharpLua.Template = "bj_CINEFADETYPE_FADEIN"
		public const int bj_CINEFADETYPE_FADEIN = 0;
		/// @CSharpLua.Template = "bj_CINEFADETYPE_FADEOUT"
		public const int bj_CINEFADETYPE_FADEOUT = 1;
		/// @CSharpLua.Template = "bj_CINEFADETYPE_FADEOUTIN"
		public const int bj_CINEFADETYPE_FADEOUTIN = 2;
		/// @CSharpLua.Template = "bj_REMOVEBUFFS_POSITIVE"
		public const int bj_REMOVEBUFFS_POSITIVE = 0;
		/// @CSharpLua.Template = "bj_REMOVEBUFFS_NEGATIVE"
		public const int bj_REMOVEBUFFS_NEGATIVE = 1;
		/// @CSharpLua.Template = "bj_REMOVEBUFFS_ALL"
		public const int bj_REMOVEBUFFS_ALL = 2;
		/// @CSharpLua.Template = "bj_REMOVEBUFFS_NONTLIFE"
		public const int bj_REMOVEBUFFS_NONTLIFE = 3;
		/// @CSharpLua.Template = "bj_BUFF_POLARITY_POSITIVE"
		public const int bj_BUFF_POLARITY_POSITIVE = 0;
		/// @CSharpLua.Template = "bj_BUFF_POLARITY_NEGATIVE"
		public const int bj_BUFF_POLARITY_NEGATIVE = 1;
		/// @CSharpLua.Template = "bj_BUFF_POLARITY_EITHER"
		public const int bj_BUFF_POLARITY_EITHER = 2;
		/// @CSharpLua.Template = "bj_BUFF_RESIST_MAGIC"
		public const int bj_BUFF_RESIST_MAGIC = 0;
		/// @CSharpLua.Template = "bj_BUFF_RESIST_PHYSICAL"
		public const int bj_BUFF_RESIST_PHYSICAL = 1;
		/// @CSharpLua.Template = "bj_BUFF_RESIST_EITHER"
		public const int bj_BUFF_RESIST_EITHER = 2;
		/// @CSharpLua.Template = "bj_BUFF_RESIST_BOTH"
		public const int bj_BUFF_RESIST_BOTH = 3;
		/// @CSharpLua.Template = "bj_HEROSTAT_STR"
		public const int bj_HEROSTAT_STR = 0;
		/// @CSharpLua.Template = "bj_HEROSTAT_AGI"
		public const int bj_HEROSTAT_AGI = 1;
		/// @CSharpLua.Template = "bj_HEROSTAT_INT"
		public const int bj_HEROSTAT_INT = 2;
		/// @CSharpLua.Template = "bj_MODIFYMETHOD_ADD"
		public const int bj_MODIFYMETHOD_ADD = 0;
		/// @CSharpLua.Template = "bj_MODIFYMETHOD_SUB"
		public const int bj_MODIFYMETHOD_SUB = 1;
		/// @CSharpLua.Template = "bj_MODIFYMETHOD_SET"
		public const int bj_MODIFYMETHOD_SET = 2;
		/// @CSharpLua.Template = "bj_UNIT_STATE_METHOD_ABSOLUTE"
		public const int bj_UNIT_STATE_METHOD_ABSOLUTE = 0;
		/// @CSharpLua.Template = "bj_UNIT_STATE_METHOD_RELATIVE"
		public const int bj_UNIT_STATE_METHOD_RELATIVE = 1;
		/// @CSharpLua.Template = "bj_UNIT_STATE_METHOD_DEFAULTS"
		public const int bj_UNIT_STATE_METHOD_DEFAULTS = 2;
		/// @CSharpLua.Template = "bj_UNIT_STATE_METHOD_MAXIMUM"
		public const int bj_UNIT_STATE_METHOD_MAXIMUM = 3;
		/// @CSharpLua.Template = "bj_GATEOPERATION_CLOSE"
		public const int bj_GATEOPERATION_CLOSE = 0;
		/// @CSharpLua.Template = "bj_GATEOPERATION_OPEN"
		public const int bj_GATEOPERATION_OPEN = 1;
		/// @CSharpLua.Template = "bj_GATEOPERATION_DESTROY"
		public const int bj_GATEOPERATION_DESTROY = 2;
		/// @CSharpLua.Template = "bj_GAMECACHE_BOOLEAN"
		public const int bj_GAMECACHE_BOOLEAN = 0;
		/// @CSharpLua.Template = "bj_GAMECACHE_INTEGER"
		public const int bj_GAMECACHE_INTEGER = 1;
		/// @CSharpLua.Template = "bj_GAMECACHE_REAL"
		public const int bj_GAMECACHE_REAL = 2;
		/// @CSharpLua.Template = "bj_GAMECACHE_UNIT"
		public const int bj_GAMECACHE_UNIT = 3;
		/// @CSharpLua.Template = "bj_GAMECACHE_STRING"
		public const int bj_GAMECACHE_STRING = 4;
		/// @CSharpLua.Template = "bj_HASHTABLE_BOOLEAN"
		public const int bj_HASHTABLE_BOOLEAN = 0;
		/// @CSharpLua.Template = "bj_HASHTABLE_INTEGER"
		public const int bj_HASHTABLE_INTEGER = 1;
		/// @CSharpLua.Template = "bj_HASHTABLE_REAL"
		public const int bj_HASHTABLE_REAL = 2;
		/// @CSharpLua.Template = "bj_HASHTABLE_STRING"
		public const int bj_HASHTABLE_STRING = 3;
		/// @CSharpLua.Template = "bj_HASHTABLE_HANDLE"
		public const int bj_HASHTABLE_HANDLE = 4;
		/// @CSharpLua.Template = "bj_ITEM_STATUS_HIDDEN"
		public const int bj_ITEM_STATUS_HIDDEN = 0;
		/// @CSharpLua.Template = "bj_ITEM_STATUS_OWNED"
		public const int bj_ITEM_STATUS_OWNED = 1;
		/// @CSharpLua.Template = "bj_ITEM_STATUS_INVULNERABLE"
		public const int bj_ITEM_STATUS_INVULNERABLE = 2;
		/// @CSharpLua.Template = "bj_ITEM_STATUS_POWERUP"
		public const int bj_ITEM_STATUS_POWERUP = 3;
		/// @CSharpLua.Template = "bj_ITEM_STATUS_SELLABLE"
		public const int bj_ITEM_STATUS_SELLABLE = 4;
		/// @CSharpLua.Template = "bj_ITEM_STATUS_PAWNABLE"
		public const int bj_ITEM_STATUS_PAWNABLE = 5;
		/// @CSharpLua.Template = "bj_ITEMCODE_STATUS_POWERUP"
		public const int bj_ITEMCODE_STATUS_POWERUP = 0;
		/// @CSharpLua.Template = "bj_ITEMCODE_STATUS_SELLABLE"
		public const int bj_ITEMCODE_STATUS_SELLABLE = 1;
		/// @CSharpLua.Template = "bj_ITEMCODE_STATUS_PAWNABLE"
		public const int bj_ITEMCODE_STATUS_PAWNABLE = 2;
		/// @CSharpLua.Template = "bj_MINIMAPPINGSTYLE_SIMPLE"
		public const int bj_MINIMAPPINGSTYLE_SIMPLE = 0;
		/// @CSharpLua.Template = "bj_MINIMAPPINGSTYLE_FLASHY"
		public const int bj_MINIMAPPINGSTYLE_FLASHY = 1;
		/// @CSharpLua.Template = "bj_MINIMAPPINGSTYLE_ATTACK"
		public const int bj_MINIMAPPINGSTYLE_ATTACK = 2;
		/// @CSharpLua.Template = "bj_CAMPPINGSTYLE_PRIMARY"
		public const int bj_CAMPPINGSTYLE_PRIMARY = 0;
		/// @CSharpLua.Template = "bj_CAMPPINGSTYLE_PRIMARY_GREEN"
		public const int bj_CAMPPINGSTYLE_PRIMARY_GREEN = 1;
		/// @CSharpLua.Template = "bj_CAMPPINGSTYLE_PRIMARY_RED"
		public const int bj_CAMPPINGSTYLE_PRIMARY_RED = 2;
		/// @CSharpLua.Template = "bj_CAMPPINGSTYLE_BONUS"
		public const int bj_CAMPPINGSTYLE_BONUS = 3;
		/// @CSharpLua.Template = "bj_CAMPPINGSTYLE_TURNIN"
		public const int bj_CAMPPINGSTYLE_TURNIN = 4;
		/// @CSharpLua.Template = "bj_CAMPPINGSTYLE_BOSS"
		public const int bj_CAMPPINGSTYLE_BOSS = 5;
		/// @CSharpLua.Template = "bj_CAMPPINGSTYLE_CONTROL_ALLY"
		public const int bj_CAMPPINGSTYLE_CONTROL_ALLY = 6;
		/// @CSharpLua.Template = "bj_CAMPPINGSTYLE_CONTROL_NEUTRAL"
		public const int bj_CAMPPINGSTYLE_CONTROL_NEUTRAL = 7;
		/// @CSharpLua.Template = "bj_CAMPPINGSTYLE_CONTROL_ENEMY"
		public const int bj_CAMPPINGSTYLE_CONTROL_ENEMY = 8;
		/// @CSharpLua.Template = "bj_CORPSE_MAX_DEATH_TIME"
		public const float bj_CORPSE_MAX_DEATH_TIME = 8.00f;
		/// @CSharpLua.Template = "bj_CORPSETYPE_FLESH"
		public const int bj_CORPSETYPE_FLESH = 0;
		/// @CSharpLua.Template = "bj_CORPSETYPE_BONE"
		public const int bj_CORPSETYPE_BONE = 1;
		/// @CSharpLua.Template = "bj_ELEVATOR_BLOCKER_CODE"
		public const int bj_ELEVATOR_BLOCKER_CODE = 1146381680;
		/// @CSharpLua.Template = "bj_ELEVATOR_CODE01"
		public const int bj_ELEVATOR_CODE01 = 1146384998;
		/// @CSharpLua.Template = "bj_ELEVATOR_CODE02"
		public const int bj_ELEVATOR_CODE02 = 1146385016;
		/// @CSharpLua.Template = "bj_ELEVATOR_WALL_TYPE_ALL"
		public const int bj_ELEVATOR_WALL_TYPE_ALL = 0;
		/// @CSharpLua.Template = "bj_ELEVATOR_WALL_TYPE_EAST"
		public const int bj_ELEVATOR_WALL_TYPE_EAST = 1;
		/// @CSharpLua.Template = "bj_ELEVATOR_WALL_TYPE_NORTH"
		public const int bj_ELEVATOR_WALL_TYPE_NORTH = 2;
		/// @CSharpLua.Template = "bj_ELEVATOR_WALL_TYPE_SOUTH"
		public const int bj_ELEVATOR_WALL_TYPE_SOUTH = 3;
		/// @CSharpLua.Template = "bj_ELEVATOR_WALL_TYPE_WEST"
		public const int bj_ELEVATOR_WALL_TYPE_WEST = 4;
		/// @CSharpLua.Template = "bj_FORCE_ALL_PLAYERS"
		public static force bj_FORCE_ALL_PLAYERS = null;
		/// @CSharpLua.Template = "bj_FORCE_PLAYER"
		public static force[] bj_FORCE_PLAYER = new force[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_MELEE_MAX_TWINKED_HEROES"
		public static int bj_MELEE_MAX_TWINKED_HEROES = 0;
		/// @CSharpLua.Template = "bj_mapInitialPlayableArea"
		public static rect bj_mapInitialPlayableArea = null;
		/// @CSharpLua.Template = "bj_mapInitialCameraBounds"
		public static rect bj_mapInitialCameraBounds = null;
		/// @CSharpLua.Template = "bj_forLoopAIndex"
		public static int bj_forLoopAIndex = 0;
		/// @CSharpLua.Template = "bj_forLoopBIndex"
		public static int bj_forLoopBIndex = 0;
		/// @CSharpLua.Template = "bj_forLoopAIndexEnd"
		public static int bj_forLoopAIndexEnd = 0;
		/// @CSharpLua.Template = "bj_forLoopBIndexEnd"
		public static int bj_forLoopBIndexEnd = 0;
		/// @CSharpLua.Template = "bj_slotControlReady"
		public static bool bj_slotControlReady = false;
		/// @CSharpLua.Template = "bj_slotControlUsed"
		public static bool[] bj_slotControlUsed = new bool[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_slotControl"
		public static mapcontrol[] bj_slotControl = new mapcontrol[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_gameStartedTimer"
		public static timer bj_gameStartedTimer = null;
		/// @CSharpLua.Template = "bj_gameStarted"
		public static bool bj_gameStarted = false;
		/// @CSharpLua.Template = "bj_volumeGroupsTimer"
		public static timer bj_volumeGroupsTimer = CreateTimer();
		/// @CSharpLua.Template = "bj_isSinglePlayer"
		public static bool bj_isSinglePlayer = false;
		/// @CSharpLua.Template = "bj_dncSoundsDay"
		public static trigger bj_dncSoundsDay = null;
		/// @CSharpLua.Template = "bj_dncSoundsNight"
		public static trigger bj_dncSoundsNight = null;
		/// @CSharpLua.Template = "bj_dayAmbientSound"
		public static sound bj_dayAmbientSound = null;
		/// @CSharpLua.Template = "bj_nightAmbientSound"
		public static sound bj_nightAmbientSound = null;
		/// @CSharpLua.Template = "bj_dncSoundsDawn"
		public static trigger bj_dncSoundsDawn = null;
		/// @CSharpLua.Template = "bj_dncSoundsDusk"
		public static trigger bj_dncSoundsDusk = null;
		/// @CSharpLua.Template = "bj_dawnSound"
		public static sound bj_dawnSound = null;
		/// @CSharpLua.Template = "bj_duskSound"
		public static sound bj_duskSound = null;
		/// @CSharpLua.Template = "bj_useDawnDuskSounds"
		public static bool bj_useDawnDuskSounds = true;
		/// @CSharpLua.Template = "bj_dncIsDaytime"
		public static bool bj_dncIsDaytime = false;
		/// @CSharpLua.Template = "bj_rescueSound"
		public static sound bj_rescueSound = null;
		/// @CSharpLua.Template = "bj_questDiscoveredSound"
		public static sound bj_questDiscoveredSound = null;
		/// @CSharpLua.Template = "bj_questUpdatedSound"
		public static sound bj_questUpdatedSound = null;
		/// @CSharpLua.Template = "bj_questCompletedSound"
		public static sound bj_questCompletedSound = null;
		/// @CSharpLua.Template = "bj_questFailedSound"
		public static sound bj_questFailedSound = null;
		/// @CSharpLua.Template = "bj_questHintSound"
		public static sound bj_questHintSound = null;
		/// @CSharpLua.Template = "bj_questSecretSound"
		public static sound bj_questSecretSound = null;
		/// @CSharpLua.Template = "bj_questItemAcquiredSound"
		public static sound bj_questItemAcquiredSound = null;
		/// @CSharpLua.Template = "bj_questWarningSound"
		public static sound bj_questWarningSound = null;
		/// @CSharpLua.Template = "bj_victoryDialogSound"
		public static sound bj_victoryDialogSound = null;
		/// @CSharpLua.Template = "bj_defeatDialogSound"
		public static sound bj_defeatDialogSound = null;
		/// @CSharpLua.Template = "bj_stockItemPurchased"
		public static trigger bj_stockItemPurchased = null;
		/// @CSharpLua.Template = "bj_stockUpdateTimer"
		public static timer bj_stockUpdateTimer = null;
		/// @CSharpLua.Template = "bj_stockAllowedPermanent"
		public static bool[] bj_stockAllowedPermanent = new bool[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_stockAllowedCharged"
		public static bool[] bj_stockAllowedCharged = new bool[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_stockAllowedArtifact"
		public static bool[] bj_stockAllowedArtifact = new bool[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_stockPickedItemLevel"
		public static int bj_stockPickedItemLevel = 0;
		/// @CSharpLua.Template = "bj_stockPickedItemType"
		public static itemtype bj_stockPickedItemType = default;
		/// @CSharpLua.Template = "bj_meleeVisibilityTrained"
		public static trigger bj_meleeVisibilityTrained = null;
		/// @CSharpLua.Template = "bj_meleeVisibilityIsDay"
		public static bool bj_meleeVisibilityIsDay = true;
		/// @CSharpLua.Template = "bj_meleeGrantHeroItems"
		public static bool bj_meleeGrantHeroItems = false;
		/// @CSharpLua.Template = "bj_meleeNearestMineToLoc"
		public static location bj_meleeNearestMineToLoc = null;
		/// @CSharpLua.Template = "bj_meleeNearestMine"
		public static unit bj_meleeNearestMine = null;
		/// @CSharpLua.Template = "bj_meleeNearestMineDist"
		public static float bj_meleeNearestMineDist = 0.00f;
		/// @CSharpLua.Template = "bj_meleeGameOver"
		public static bool bj_meleeGameOver = false;
		/// @CSharpLua.Template = "bj_meleeDefeated"
		public static bool[] bj_meleeDefeated = new bool[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_meleeVictoried"
		public static bool[] bj_meleeVictoried = new bool[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_ghoul"
		public static unit[] bj_ghoul = new unit[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_crippledTimer"
		public static timer[] bj_crippledTimer = new timer[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_crippledTimerWindows"
		public static timerdialog[] bj_crippledTimerWindows = new timerdialog[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_playerIsCrippled"
		public static bool[] bj_playerIsCrippled = new bool[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_playerIsExposed"
		public static bool[] bj_playerIsExposed = new bool[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_finishSoonAllExposed"
		public static bool bj_finishSoonAllExposed = false;
		/// @CSharpLua.Template = "bj_finishSoonTimerDialog"
		public static timerdialog bj_finishSoonTimerDialog = null;
		/// @CSharpLua.Template = "bj_meleeTwinkedHeroes"
		public static int[] bj_meleeTwinkedHeroes = new int[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_rescueUnitBehavior"
		public static trigger bj_rescueUnitBehavior = null;
		/// @CSharpLua.Template = "bj_rescueChangeColorUnit"
		public static bool bj_rescueChangeColorUnit = true;
		/// @CSharpLua.Template = "bj_rescueChangeColorBldg"
		public static bool bj_rescueChangeColorBldg = true;
		/// @CSharpLua.Template = "bj_cineSceneEndingTimer"
		public static timer bj_cineSceneEndingTimer = null;
		/// @CSharpLua.Template = "bj_cineSceneLastSound"
		public static sound bj_cineSceneLastSound = null;
		/// @CSharpLua.Template = "bj_cineSceneBeingSkipped"
		public static trigger bj_cineSceneBeingSkipped = null;
		/// @CSharpLua.Template = "bj_cineModePriorSpeed"
		public static gamespeed bj_cineModePriorSpeed = MAP_SPEED_NORMAL;
		/// @CSharpLua.Template = "bj_cineModePriorFogSetting"
		public static bool bj_cineModePriorFogSetting = false;
		/// @CSharpLua.Template = "bj_cineModePriorMaskSetting"
		public static bool bj_cineModePriorMaskSetting = false;
		/// @CSharpLua.Template = "bj_cineModeAlreadyIn"
		public static bool bj_cineModeAlreadyIn = false;
		/// @CSharpLua.Template = "bj_cineModePriorDawnDusk"
		public static bool bj_cineModePriorDawnDusk = false;
		/// @CSharpLua.Template = "bj_cineModeSavedSeed"
		public static int bj_cineModeSavedSeed = 0;
		/// @CSharpLua.Template = "bj_cineFadeFinishTimer"
		public static timer bj_cineFadeFinishTimer = null;
		/// @CSharpLua.Template = "bj_cineFadeContinueTimer"
		public static timer bj_cineFadeContinueTimer = null;
		/// @CSharpLua.Template = "bj_cineFadeContinueRed"
		public static float bj_cineFadeContinueRed = 0;
		/// @CSharpLua.Template = "bj_cineFadeContinueGreen"
		public static float bj_cineFadeContinueGreen = 0;
		/// @CSharpLua.Template = "bj_cineFadeContinueBlue"
		public static float bj_cineFadeContinueBlue = 0;
		/// @CSharpLua.Template = "bj_cineFadeContinueTrans"
		public static float bj_cineFadeContinueTrans = 0;
		/// @CSharpLua.Template = "bj_cineFadeContinueDuration"
		public static float bj_cineFadeContinueDuration = 0;
		/// @CSharpLua.Template = "bj_cineFadeContinueTex"
		public static string bj_cineFadeContinueTex = string.Empty;
		/// @CSharpLua.Template = "bj_queuedExecTotal"
		public static int bj_queuedExecTotal = 0;
		/// @CSharpLua.Template = "bj_queuedExecTriggers"
		public static trigger[] bj_queuedExecTriggers = new trigger[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_queuedExecUseConds"
		public static bool[] bj_queuedExecUseConds = new bool[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_queuedExecTimeoutTimer"
		public static timer bj_queuedExecTimeoutTimer = CreateTimer();
		/// @CSharpLua.Template = "bj_queuedExecTimeout"
		public static trigger bj_queuedExecTimeout = null;
		/// @CSharpLua.Template = "bj_destInRegionDiesCount"
		public static int bj_destInRegionDiesCount = 0;
		/// @CSharpLua.Template = "bj_destInRegionDiesTrig"
		public static trigger bj_destInRegionDiesTrig = null;
		/// @CSharpLua.Template = "bj_groupCountUnits"
		public static int bj_groupCountUnits = 0;
		/// @CSharpLua.Template = "bj_forceCountPlayers"
		public static int bj_forceCountPlayers = 0;
		/// @CSharpLua.Template = "bj_groupEnumTypeId"
		public static int bj_groupEnumTypeId = 0;
		/// @CSharpLua.Template = "bj_groupEnumOwningPlayer"
		public static player bj_groupEnumOwningPlayer = null;
		/// @CSharpLua.Template = "bj_groupAddGroupDest"
		public static group bj_groupAddGroupDest = null;
		/// @CSharpLua.Template = "bj_groupRemoveGroupDest"
		public static group bj_groupRemoveGroupDest = null;
		/// @CSharpLua.Template = "bj_groupRandomConsidered"
		public static int bj_groupRandomConsidered = 0;
		/// @CSharpLua.Template = "bj_groupRandomCurrentPick"
		public static unit bj_groupRandomCurrentPick = null;
		/// @CSharpLua.Template = "bj_groupLastCreatedDest"
		public static group bj_groupLastCreatedDest = null;
		/// @CSharpLua.Template = "bj_randomSubGroupGroup"
		public static group bj_randomSubGroupGroup = null;
		/// @CSharpLua.Template = "bj_randomSubGroupWant"
		public static int bj_randomSubGroupWant = 0;
		/// @CSharpLua.Template = "bj_randomSubGroupTotal"
		public static int bj_randomSubGroupTotal = 0;
		/// @CSharpLua.Template = "bj_randomSubGroupChance"
		public static float bj_randomSubGroupChance = 0;
		/// @CSharpLua.Template = "bj_destRandomConsidered"
		public static int bj_destRandomConsidered = 0;
		/// @CSharpLua.Template = "bj_destRandomCurrentPick"
		public static destructable bj_destRandomCurrentPick = null;
		/// @CSharpLua.Template = "bj_elevatorWallBlocker"
		public static destructable bj_elevatorWallBlocker = null;
		/// @CSharpLua.Template = "bj_elevatorNeighbor"
		public static destructable bj_elevatorNeighbor = null;
		/// @CSharpLua.Template = "bj_itemRandomConsidered"
		public static int bj_itemRandomConsidered = 0;
		/// @CSharpLua.Template = "bj_itemRandomCurrentPick"
		public static item bj_itemRandomCurrentPick = null;
		/// @CSharpLua.Template = "bj_forceRandomConsidered"
		public static int bj_forceRandomConsidered = 0;
		/// @CSharpLua.Template = "bj_forceRandomCurrentPick"
		public static player bj_forceRandomCurrentPick = null;
		/// @CSharpLua.Template = "bj_makeUnitRescuableUnit"
		public static unit bj_makeUnitRescuableUnit = null;
		/// @CSharpLua.Template = "bj_makeUnitRescuableFlag"
		public static bool bj_makeUnitRescuableFlag = true;
		/// @CSharpLua.Template = "bj_pauseAllUnitsFlag"
		public static bool bj_pauseAllUnitsFlag = true;
		/// @CSharpLua.Template = "bj_enumDestructableCenter"
		public static location bj_enumDestructableCenter = null;
		/// @CSharpLua.Template = "bj_enumDestructableRadius"
		public static float bj_enumDestructableRadius = 0;
		/// @CSharpLua.Template = "bj_setPlayerTargetColor"
		public static playercolor bj_setPlayerTargetColor = null;
		/// @CSharpLua.Template = "bj_isUnitGroupDeadResult"
		public static bool bj_isUnitGroupDeadResult = true;
		/// @CSharpLua.Template = "bj_isUnitGroupEmptyResult"
		public static bool bj_isUnitGroupEmptyResult = true;
		/// @CSharpLua.Template = "bj_isUnitGroupInRectResult"
		public static bool bj_isUnitGroupInRectResult = true;
		/// @CSharpLua.Template = "bj_isUnitGroupInRectRect"
		public static rect bj_isUnitGroupInRectRect = null;
		/// @CSharpLua.Template = "bj_changeLevelShowScores"
		public static bool bj_changeLevelShowScores = false;
		/// @CSharpLua.Template = "bj_changeLevelMapName"
		public static string bj_changeLevelMapName = null;
		/// @CSharpLua.Template = "bj_suspendDecayFleshGroup"
		public static group bj_suspendDecayFleshGroup = CreateGroup();
		/// @CSharpLua.Template = "bj_suspendDecayBoneGroup"
		public static group bj_suspendDecayBoneGroup = CreateGroup();
		/// @CSharpLua.Template = "bj_delayedSuspendDecayTimer"
		public static timer bj_delayedSuspendDecayTimer = CreateTimer();
		/// @CSharpLua.Template = "bj_delayedSuspendDecayTrig"
		public static trigger bj_delayedSuspendDecayTrig = null;
		/// @CSharpLua.Template = "bj_livingPlayerUnitsTypeId"
		public static int bj_livingPlayerUnitsTypeId = 0;
		/// @CSharpLua.Template = "bj_lastDyingWidget"
		public static widget bj_lastDyingWidget = null;
		/// @CSharpLua.Template = "bj_randDistCount"
		public static int bj_randDistCount = 0;
		/// @CSharpLua.Template = "bj_randDistID"
		public static int[] bj_randDistID = new int[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_randDistChance"
		public static int[] bj_randDistChance = new int[JASS_MAX_ARRAY_SIZE];
		/// @CSharpLua.Template = "bj_lastCreatedUnit"
		public static unit bj_lastCreatedUnit = null;
		/// @CSharpLua.Template = "bj_lastCreatedItem"
		public static item bj_lastCreatedItem = null;
		/// @CSharpLua.Template = "bj_lastRemovedItem"
		public static item bj_lastRemovedItem = null;
		/// @CSharpLua.Template = "bj_lastHauntedGoldMine"
		public static unit bj_lastHauntedGoldMine = null;
		/// @CSharpLua.Template = "bj_lastCreatedDestructable"
		public static destructable bj_lastCreatedDestructable = null;
		/// @CSharpLua.Template = "bj_lastCreatedGroup"
		public static group bj_lastCreatedGroup = CreateGroup();
		/// @CSharpLua.Template = "bj_lastCreatedFogModifier"
		public static fogmodifier bj_lastCreatedFogModifier = null;
		/// @CSharpLua.Template = "bj_lastCreatedEffect"
		public static effect bj_lastCreatedEffect = null;
		/// @CSharpLua.Template = "bj_lastCreatedWeatherEffect"
		public static weathereffect bj_lastCreatedWeatherEffect = null;
		/// @CSharpLua.Template = "bj_lastCreatedTerrainDeformation"
		public static terraindeformation bj_lastCreatedTerrainDeformation = null;
		/// @CSharpLua.Template = "bj_lastCreatedQuest"
		public static quest bj_lastCreatedQuest = null;
		/// @CSharpLua.Template = "bj_lastCreatedQuestItem"
		public static questitem bj_lastCreatedQuestItem = null;
		/// @CSharpLua.Template = "bj_lastCreatedDefeatCondition"
		public static defeatcondition bj_lastCreatedDefeatCondition = null;
		/// @CSharpLua.Template = "bj_lastStartedTimer"
		public static timer bj_lastStartedTimer = CreateTimer();
		/// @CSharpLua.Template = "bj_lastCreatedTimerDialog"
		public static timerdialog bj_lastCreatedTimerDialog = null;
		/// @CSharpLua.Template = "bj_lastCreatedLeaderboard"
		public static leaderboard bj_lastCreatedLeaderboard = null;
		/// @CSharpLua.Template = "bj_lastCreatedMultiboard"
		public static multiboard bj_lastCreatedMultiboard = null;
		/// @CSharpLua.Template = "bj_lastPlayedSound"
		public static sound bj_lastPlayedSound = null;
		/// @CSharpLua.Template = "bj_lastPlayedMusic"
		public static string bj_lastPlayedMusic = string.Empty;
		/// @CSharpLua.Template = "bj_lastTransmissionDuration"
		public static float bj_lastTransmissionDuration = 0;
		/// @CSharpLua.Template = "bj_lastCreatedGameCache"
		public static gamecache bj_lastCreatedGameCache = null;
		/// @CSharpLua.Template = "bj_lastCreatedHashtable"
		public static hashtable bj_lastCreatedHashtable = null;
		/// @CSharpLua.Template = "bj_lastLoadedUnit"
		public static unit bj_lastLoadedUnit = null;
		/// @CSharpLua.Template = "bj_lastCreatedButton"
		public static button bj_lastCreatedButton = null;
		/// @CSharpLua.Template = "bj_lastReplacedUnit"
		public static unit bj_lastReplacedUnit = null;
		/// @CSharpLua.Template = "bj_lastCreatedTextTag"
		public static texttag bj_lastCreatedTextTag = null;
		/// @CSharpLua.Template = "bj_lastCreatedLightning"
		public static lightning bj_lastCreatedLightning = null;
		/// @CSharpLua.Template = "bj_lastCreatedImage"
		public static image bj_lastCreatedImage = null;
		/// @CSharpLua.Template = "bj_lastCreatedUbersplat"
		public static ubersplat bj_lastCreatedUbersplat = null;
		/// @CSharpLua.Template = "bj_lastCreatedMinimapIcon"
		public static minimapicon bj_lastCreatedMinimapIcon = null;
		/// @CSharpLua.Template = "bj_lastCreatedCommandButtonEffect"
		public static commandbuttoneffect bj_lastCreatedCommandButtonEffect = null;
		/// @CSharpLua.Template = "filterIssueHauntOrderAtLocBJ"
		public static boolexpr filterIssueHauntOrderAtLocBJ = null;
		/// @CSharpLua.Template = "filterEnumDestructablesInCircleBJ"
		public static boolexpr filterEnumDestructablesInCircleBJ = null;
		/// @CSharpLua.Template = "filterGetUnitsInRectOfPlayer"
		public static boolexpr filterGetUnitsInRectOfPlayer = null;
		/// @CSharpLua.Template = "filterGetUnitsOfTypeIdAll"
		public static boolexpr filterGetUnitsOfTypeIdAll = null;
		/// @CSharpLua.Template = "filterGetUnitsOfPlayerAndTypeId"
		public static boolexpr filterGetUnitsOfPlayerAndTypeId = null;
		/// @CSharpLua.Template = "filterMeleeTrainedUnitIsHeroBJ"
		public static boolexpr filterMeleeTrainedUnitIsHeroBJ = null;
		/// @CSharpLua.Template = "filterLivingPlayerUnitsOfTypeId"
		public static boolexpr filterLivingPlayerUnitsOfTypeId = null;
		/// @CSharpLua.Template = "bj_wantDestroyGroup"
		public static bool bj_wantDestroyGroup = false;
		/// @CSharpLua.Template = "bj_lastInstObjFuncSuccessful"
		public static bool bj_lastInstObjFuncSuccessful = true;
		/// @CSharpLua.Template = "BJDebugMsg({0})"
		public static extern void BJDebugMsg(string msg);
		/// @CSharpLua.Template = "RMinBJ({0}, {1})"
		public static extern float RMinBJ(float a, float b);
		/// @CSharpLua.Template = "RMaxBJ({0}, {1})"
		public static extern float RMaxBJ(float a, float b);
		/// @CSharpLua.Template = "RAbsBJ({0})"
		public static extern float RAbsBJ(float a);
		/// @CSharpLua.Template = "RSignBJ({0})"
		public static extern float RSignBJ(float a);
		/// @CSharpLua.Template = "IMinBJ({0}, {1})"
		public static extern int IMinBJ(int a, int b);
		/// @CSharpLua.Template = "IMaxBJ({0}, {1})"
		public static extern int IMaxBJ(int a, int b);
		/// @CSharpLua.Template = "IAbsBJ({0})"
		public static extern int IAbsBJ(int a);
		/// @CSharpLua.Template = "ISignBJ({0})"
		public static extern int ISignBJ(int a);
		/// @CSharpLua.Template = "SinBJ({0})"
		public static extern float SinBJ(float degrees);
		/// @CSharpLua.Template = "CosBJ({0})"
		public static extern float CosBJ(float degrees);
		/// @CSharpLua.Template = "TanBJ({0})"
		public static extern float TanBJ(float degrees);
		/// @CSharpLua.Template = "AsinBJ({0})"
		public static extern float AsinBJ(float degrees);
		/// @CSharpLua.Template = "AcosBJ({0})"
		public static extern float AcosBJ(float degrees);
		/// @CSharpLua.Template = "AtanBJ({0})"
		public static extern float AtanBJ(float degrees);
		/// @CSharpLua.Template = "Atan2BJ({0}, {1})"
		public static extern float Atan2BJ(float y, float x);
		/// @CSharpLua.Template = "AngleBetweenPoints({0}, {1})"
		public static extern float AngleBetweenPoints(location locA, location locB);
		/// @CSharpLua.Template = "DistanceBetweenPoints({0}, {1})"
		public static extern float DistanceBetweenPoints(location locA, location locB);
		/// @CSharpLua.Template = "PolarProjectionBJ({0}, {1}, {2})"
		public static extern location PolarProjectionBJ(location source, float dist, float angle);
		/// @CSharpLua.Template = "GetRandomDirectionDeg()"
		public static extern float GetRandomDirectionDeg();
		/// @CSharpLua.Template = "GetRandomPercentageBJ()"
		public static extern float GetRandomPercentageBJ();
		/// @CSharpLua.Template = "GetRandomLocInRect({0})"
		public static extern location GetRandomLocInRect(rect whichRect);
		/// @CSharpLua.Template = "ModuloInteger({0}, {1})"
		public static extern int ModuloInteger(int dividend, int divisor);
		/// @CSharpLua.Template = "ModuloReal({0}, {1})"
		public static extern float ModuloReal(float dividend, float divisor);
		/// @CSharpLua.Template = "OffsetLocation({0}, {1}, {2})"
		public static extern location OffsetLocation(location loc, float dx, float dy);
		/// @CSharpLua.Template = "OffsetRectBJ({0}, {1}, {2})"
		public static extern rect OffsetRectBJ(rect r, float dx, float dy);
		/// @CSharpLua.Template = "RectFromCenterSizeBJ({0}, {1}, {2})"
		public static extern rect RectFromCenterSizeBJ(location center, float width, float height);
		/// @CSharpLua.Template = "RectContainsCoords({0}, {1}, {2})"
		public static extern bool RectContainsCoords(rect r, float x, float y);
		/// @CSharpLua.Template = "RectContainsLoc({0}, {1})"
		public static extern bool RectContainsLoc(rect r, location loc);
		/// @CSharpLua.Template = "RectContainsUnit({0}, {1})"
		public static extern bool RectContainsUnit(rect r, unit whichUnit);
		/// @CSharpLua.Template = "RectContainsItem({0}, {1})"
		public static extern bool RectContainsItem(item whichItem, rect r);
		/// @CSharpLua.Template = "ConditionalTriggerExecute({0})"
		public static extern void ConditionalTriggerExecute(trigger trig);
		/// @CSharpLua.Template = "TriggerExecuteBJ({0}, {1})"
		public static extern bool TriggerExecuteBJ(trigger trig, bool checkConditions);
		/// @CSharpLua.Template = "PostTriggerExecuteBJ({0}, {1})"
		public static extern bool PostTriggerExecuteBJ(trigger trig, bool checkConditions);
		/// @CSharpLua.Template = "QueuedTriggerCheck()"
		public static extern void QueuedTriggerCheck();
		/// @CSharpLua.Template = "QueuedTriggerGetIndex({0})"
		public static extern int QueuedTriggerGetIndex(trigger trig);
		/// @CSharpLua.Template = "QueuedTriggerRemoveByIndex({0})"
		public static extern bool QueuedTriggerRemoveByIndex(int trigIndex);
		/// @CSharpLua.Template = "QueuedTriggerAttemptExec()"
		public static extern bool QueuedTriggerAttemptExec();
		/// @CSharpLua.Template = "QueuedTriggerAddBJ({0}, {1})"
		public static extern bool QueuedTriggerAddBJ(trigger trig, bool checkConditions);
		/// @CSharpLua.Template = "QueuedTriggerRemoveBJ({0})"
		public static extern void QueuedTriggerRemoveBJ(trigger trig);
		/// @CSharpLua.Template = "QueuedTriggerDoneBJ()"
		public static extern void QueuedTriggerDoneBJ();
		/// @CSharpLua.Template = "QueuedTriggerClearBJ()"
		public static extern void QueuedTriggerClearBJ();
		/// @CSharpLua.Template = "QueuedTriggerClearInactiveBJ()"
		public static extern void QueuedTriggerClearInactiveBJ();
		/// @CSharpLua.Template = "QueuedTriggerCountBJ()"
		public static extern int QueuedTriggerCountBJ();
		/// @CSharpLua.Template = "IsTriggerQueueEmptyBJ()"
		public static extern bool IsTriggerQueueEmptyBJ();
		/// @CSharpLua.Template = "IsTriggerQueuedBJ({0})"
		public static extern bool IsTriggerQueuedBJ(trigger trig);
		/// @CSharpLua.Template = "GetForLoopIndexA()"
		public static extern int GetForLoopIndexA();
		/// @CSharpLua.Template = "SetForLoopIndexA({0})"
		public static extern void SetForLoopIndexA(int newIndex);
		/// @CSharpLua.Template = "GetForLoopIndexB()"
		public static extern int GetForLoopIndexB();
		/// @CSharpLua.Template = "SetForLoopIndexB({0})"
		public static extern void SetForLoopIndexB(int newIndex);
		/// @CSharpLua.Template = "PolledWait({0})"
		public static extern void PolledWait(float duration);
		/// @CSharpLua.Template = "IntegerTertiaryOp({0}, {1}, {2})"
		public static extern int IntegerTertiaryOp(bool flag, int valueA, int valueB);
		/// @CSharpLua.Template = "DoNothing()"
		public static extern void DoNothing();
		/// @CSharpLua.Template = "CommentString({0})"
		public static extern void CommentString(string commentString);
		/// @CSharpLua.Template = "StringIdentity({0})"
		public static extern string StringIdentity(string theString);
		/// @CSharpLua.Template = "GetBooleanAnd({0}, {1})"
		public static extern bool GetBooleanAnd(bool valueA, bool valueB);
		/// @CSharpLua.Template = "GetBooleanOr({0}, {1})"
		public static extern bool GetBooleanOr(bool valueA, bool valueB);
		/// @CSharpLua.Template = "PercentToInt({0}, {1})"
		public static extern int PercentToInt(float percentage, int max);
		/// @CSharpLua.Template = "PercentTo255({0})"
		public static extern int PercentTo255(float percentage);
		/// @CSharpLua.Template = "GetTimeOfDay()"
		public static extern float GetTimeOfDay();
		/// @CSharpLua.Template = "SetTimeOfDay({0})"
		public static extern void SetTimeOfDay(float whatTime);
		/// @CSharpLua.Template = "SetTimeOfDayScalePercentBJ({0})"
		public static extern void SetTimeOfDayScalePercentBJ(float scalePercent);
		/// @CSharpLua.Template = "GetTimeOfDayScalePercentBJ()"
		public static extern float GetTimeOfDayScalePercentBJ();
		/// @CSharpLua.Template = "PlaySound({0})"
		public static extern void PlaySound(string soundName);
		/// @CSharpLua.Template = "CompareLocationsBJ({0}, {1})"
		public static extern bool CompareLocationsBJ(location A, location B);
		/// @CSharpLua.Template = "CompareRectsBJ({0}, {1})"
		public static extern bool CompareRectsBJ(rect A, rect B);
		/// @CSharpLua.Template = "GetRectFromCircleBJ({0}, {1})"
		public static extern rect GetRectFromCircleBJ(location center, float radius);
		/// @CSharpLua.Template = "GetCurrentCameraSetup()"
		public static extern camerasetup GetCurrentCameraSetup();
		/// @CSharpLua.Template = "CameraSetupApplyForPlayer({0}, {1}, {2}, {3})"
		public static extern void CameraSetupApplyForPlayer(bool doPan, camerasetup whichSetup, player whichPlayer, float duration);
		/// @CSharpLua.Template = "CameraSetupApplyForPlayerSmooth({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern void CameraSetupApplyForPlayerSmooth(bool doPan, camerasetup whichSetup, player whichPlayer, float forcedDuration, float easeInDuration, float easeOutDuration, float smoothFactor);
		/// @CSharpLua.Template = "CameraSetupGetFieldSwap({0}, {1})"
		public static extern float CameraSetupGetFieldSwap(camerafield whichField, camerasetup whichSetup);
		/// @CSharpLua.Template = "SetCameraFieldForPlayer({0}, {1}, {2}, {3})"
		public static extern void SetCameraFieldForPlayer(player whichPlayer, camerafield whichField, float value, float duration);
		/// @CSharpLua.Template = "SetCameraTargetControllerNoZForPlayer({0}, {1}, {2}, {3}, {4})"
		public static extern void SetCameraTargetControllerNoZForPlayer(player whichPlayer, unit whichUnit, float xoffset, float yoffset, bool inheritOrientation);
		/// @CSharpLua.Template = "SetCameraPositionForPlayer({0}, {1}, {2})"
		public static extern void SetCameraPositionForPlayer(player whichPlayer, float x, float y);
		/// @CSharpLua.Template = "SetCameraPositionLocForPlayer({0}, {1})"
		public static extern void SetCameraPositionLocForPlayer(player whichPlayer, location loc);
		/// @CSharpLua.Template = "RotateCameraAroundLocBJ({0}, {1}, {2}, {3})"
		public static extern void RotateCameraAroundLocBJ(float degrees, location loc, player whichPlayer, float duration);
		/// @CSharpLua.Template = "PanCameraToForPlayer({0}, {1}, {2})"
		public static extern void PanCameraToForPlayer(player whichPlayer, float x, float y);
		/// @CSharpLua.Template = "PanCameraToLocForPlayer({0}, {1})"
		public static extern void PanCameraToLocForPlayer(player whichPlayer, location loc);
		/// @CSharpLua.Template = "PanCameraToTimedForPlayer({0}, {1}, {2}, {3})"
		public static extern void PanCameraToTimedForPlayer(player whichPlayer, float x, float y, float duration);
		/// @CSharpLua.Template = "PanCameraToTimedLocForPlayer({0}, {1}, {2})"
		public static extern void PanCameraToTimedLocForPlayer(player whichPlayer, location loc, float duration);
		/// @CSharpLua.Template = "PanCameraToTimedLocWithZForPlayer({0}, {1}, {2}, {3})"
		public static extern void PanCameraToTimedLocWithZForPlayer(player whichPlayer, location loc, float zOffset, float duration);
		/// @CSharpLua.Template = "SmartCameraPanBJ({0}, {1}, {2})"
		public static extern void SmartCameraPanBJ(player whichPlayer, location loc, float duration);
		/// @CSharpLua.Template = "SetCinematicCameraForPlayer({0}, {1})"
		public static extern void SetCinematicCameraForPlayer(player whichPlayer, string cameraModelFile);
		/// @CSharpLua.Template = "ResetToGameCameraForPlayer({0}, {1})"
		public static extern void ResetToGameCameraForPlayer(player whichPlayer, float duration);
		/// @CSharpLua.Template = "CameraSetSourceNoiseForPlayer({0}, {1}, {2})"
		public static extern void CameraSetSourceNoiseForPlayer(player whichPlayer, float magnitude, float velocity);
		/// @CSharpLua.Template = "CameraSetTargetNoiseForPlayer({0}, {1}, {2})"
		public static extern void CameraSetTargetNoiseForPlayer(player whichPlayer, float magnitude, float velocity);
		/// @CSharpLua.Template = "CameraSetEQNoiseForPlayer({0}, {1})"
		public static extern void CameraSetEQNoiseForPlayer(player whichPlayer, float magnitude);
		/// @CSharpLua.Template = "CameraClearNoiseForPlayer({0})"
		public static extern void CameraClearNoiseForPlayer(player whichPlayer);
		/// @CSharpLua.Template = "GetCurrentCameraBoundsMapRectBJ()"
		public static extern rect GetCurrentCameraBoundsMapRectBJ();
		/// @CSharpLua.Template = "GetCameraBoundsMapRect()"
		public static extern rect GetCameraBoundsMapRect();
		/// @CSharpLua.Template = "GetPlayableMapRect()"
		public static extern rect GetPlayableMapRect();
		/// @CSharpLua.Template = "GetEntireMapRect()"
		public static extern rect GetEntireMapRect();
		/// @CSharpLua.Template = "SetCameraBoundsToRect({0})"
		public static extern void SetCameraBoundsToRect(rect r);
		/// @CSharpLua.Template = "SetCameraBoundsToRectForPlayerBJ({0}, {1})"
		public static extern void SetCameraBoundsToRectForPlayerBJ(player whichPlayer, rect r);
		/// @CSharpLua.Template = "AdjustCameraBoundsBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void AdjustCameraBoundsBJ(int adjustMethod, float dxWest, float dxEast, float dyNorth, float dySouth);
		/// @CSharpLua.Template = "AdjustCameraBoundsForPlayerBJ({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern void AdjustCameraBoundsForPlayerBJ(int adjustMethod, player whichPlayer, float dxWest, float dxEast, float dyNorth, float dySouth);
		/// @CSharpLua.Template = "SetCameraQuickPositionForPlayer({0}, {1}, {2})"
		public static extern void SetCameraQuickPositionForPlayer(player whichPlayer, float x, float y);
		/// @CSharpLua.Template = "SetCameraQuickPositionLocForPlayer({0}, {1})"
		public static extern void SetCameraQuickPositionLocForPlayer(player whichPlayer, location loc);
		/// @CSharpLua.Template = "SetCameraQuickPositionLoc({0})"
		public static extern void SetCameraQuickPositionLoc(location loc);
		/// @CSharpLua.Template = "StopCameraForPlayerBJ({0})"
		public static extern void StopCameraForPlayerBJ(player whichPlayer);
		/// @CSharpLua.Template = "SetCameraOrientControllerForPlayerBJ({0}, {1}, {2}, {3})"
		public static extern void SetCameraOrientControllerForPlayerBJ(player whichPlayer, unit whichUnit, float xoffset, float yoffset);
		/// @CSharpLua.Template = "CameraSetSmoothingFactorBJ({0})"
		public static extern void CameraSetSmoothingFactorBJ(float factor);
		/// @CSharpLua.Template = "CameraResetSmoothingFactorBJ()"
		public static extern void CameraResetSmoothingFactorBJ();
		/// @CSharpLua.Template = "DisplayTextToForce({0}, {1})"
		public static extern void DisplayTextToForce(force toForce, string message);
		/// @CSharpLua.Template = "DisplayTimedTextToForce({0}, {1}, {2})"
		public static extern void DisplayTimedTextToForce(force toForce, float duration, string message);
		/// @CSharpLua.Template = "ClearTextMessagesBJ({0})"
		public static extern void ClearTextMessagesBJ(force toForce);
		/// @CSharpLua.Template = "SubStringBJ({0}, {1}, {2})"
		public static extern string SubStringBJ(string source, int start, int end);
		/// @CSharpLua.Template = "GetHandleIdBJ({0})"
		public static extern int GetHandleIdBJ(object h);
		/// @CSharpLua.Template = "StringHashBJ({0})"
		public static extern int StringHashBJ(string s);
		/// @CSharpLua.Template = "TriggerRegisterTimerEventPeriodic({0}, {1})"
		public static extern @event TriggerRegisterTimerEventPeriodic(trigger trig, float timeout);
		/// @CSharpLua.Template = "TriggerRegisterTimerEventSingle({0}, {1})"
		public static extern @event TriggerRegisterTimerEventSingle(trigger trig, float timeout);
		/// @CSharpLua.Template = "TriggerRegisterTimerExpireEventBJ({0}, {1})"
		public static extern @event TriggerRegisterTimerExpireEventBJ(trigger trig, timer t);
		/// @CSharpLua.Template = "TriggerRegisterPlayerUnitEventSimple({0}, {1}, {2})"
		public static extern @event TriggerRegisterPlayerUnitEventSimple(trigger trig, player whichPlayer, playerunitevent whichEvent);
		/// @CSharpLua.Template = "TriggerRegisterAnyUnitEventBJ({0}, {1})"
		public static extern void TriggerRegisterAnyUnitEventBJ(trigger trig, playerunitevent whichEvent);
		/// @CSharpLua.Template = "TriggerRegisterPlayerSelectionEventBJ({0}, {1}, {2})"
		public static extern @event TriggerRegisterPlayerSelectionEventBJ(trigger trig, player whichPlayer, bool selected);
		/// @CSharpLua.Template = "TriggerRegisterPlayerKeyEventBJ({0}, {1}, {2}, {3})"
		public static extern @event TriggerRegisterPlayerKeyEventBJ(trigger trig, player whichPlayer, int keType, int keKey);
		/// @CSharpLua.Template = "TriggerRegisterPlayerMouseEventBJ({0}, {1}, {2})"
		public static extern @event TriggerRegisterPlayerMouseEventBJ(trigger trig, player whichPlayer, int meType);
		/// @CSharpLua.Template = "TriggerRegisterPlayerEventVictory({0}, {1})"
		public static extern @event TriggerRegisterPlayerEventVictory(trigger trig, player whichPlayer);
		/// @CSharpLua.Template = "TriggerRegisterPlayerEventDefeat({0}, {1})"
		public static extern @event TriggerRegisterPlayerEventDefeat(trigger trig, player whichPlayer);
		/// @CSharpLua.Template = "TriggerRegisterPlayerEventLeave({0}, {1})"
		public static extern @event TriggerRegisterPlayerEventLeave(trigger trig, player whichPlayer);
		/// @CSharpLua.Template = "TriggerRegisterPlayerEventAllianceChanged({0}, {1})"
		public static extern @event TriggerRegisterPlayerEventAllianceChanged(trigger trig, player whichPlayer);
		/// @CSharpLua.Template = "TriggerRegisterPlayerEventEndCinematic({0}, {1})"
		public static extern @event TriggerRegisterPlayerEventEndCinematic(trigger trig, player whichPlayer);
		/// @CSharpLua.Template = "TriggerRegisterGameStateEventTimeOfDay({0}, {1}, {2})"
		public static extern @event TriggerRegisterGameStateEventTimeOfDay(trigger trig, limitop opcode, float limitval);
		/// @CSharpLua.Template = "TriggerRegisterEnterRegionSimple({0}, {1})"
		public static extern @event TriggerRegisterEnterRegionSimple(trigger trig, region whichRegion);
		/// @CSharpLua.Template = "TriggerRegisterLeaveRegionSimple({0}, {1})"
		public static extern @event TriggerRegisterLeaveRegionSimple(trigger trig, region whichRegion);
		/// @CSharpLua.Template = "TriggerRegisterEnterRectSimple({0}, {1})"
		public static extern @event TriggerRegisterEnterRectSimple(trigger trig, rect r);
		/// @CSharpLua.Template = "TriggerRegisterLeaveRectSimple({0}, {1})"
		public static extern @event TriggerRegisterLeaveRectSimple(trigger trig, rect r);
		/// @CSharpLua.Template = "TriggerRegisterDistanceBetweenUnits({0}, {1}, {2}, {3})"
		public static extern @event TriggerRegisterDistanceBetweenUnits(trigger trig, unit whichUnit, boolexpr condition, float range);
		/// @CSharpLua.Template = "TriggerRegisterUnitInRangeSimple({0}, {1}, {2})"
		public static extern @event TriggerRegisterUnitInRangeSimple(trigger trig, float range, unit whichUnit);
		/// @CSharpLua.Template = "TriggerRegisterUnitLifeEvent({0}, {1}, {2}, {3})"
		public static extern @event TriggerRegisterUnitLifeEvent(trigger trig, unit whichUnit, limitop opcode, float limitval);
		/// @CSharpLua.Template = "TriggerRegisterUnitManaEvent({0}, {1}, {2}, {3})"
		public static extern @event TriggerRegisterUnitManaEvent(trigger trig, unit whichUnit, limitop opcode, float limitval);
		/// @CSharpLua.Template = "TriggerRegisterDialogEventBJ({0}, {1})"
		public static extern @event TriggerRegisterDialogEventBJ(trigger trig, dialog whichDialog);
		/// @CSharpLua.Template = "TriggerRegisterShowSkillEventBJ({0})"
		public static extern @event TriggerRegisterShowSkillEventBJ(trigger trig);
		/// @CSharpLua.Template = "TriggerRegisterBuildSubmenuEventBJ({0})"
		public static extern @event TriggerRegisterBuildSubmenuEventBJ(trigger trig);
		/// @CSharpLua.Template = "TriggerRegisterBuildCommandEventBJ({0}, {1})"
		public static extern @event TriggerRegisterBuildCommandEventBJ(trigger trig, int unitId);
		/// @CSharpLua.Template = "TriggerRegisterTrainCommandEventBJ({0}, {1})"
		public static extern @event TriggerRegisterTrainCommandEventBJ(trigger trig, int unitId);
		/// @CSharpLua.Template = "TriggerRegisterUpgradeCommandEventBJ({0}, {1})"
		public static extern @event TriggerRegisterUpgradeCommandEventBJ(trigger trig, int techId);
		/// @CSharpLua.Template = "TriggerRegisterCommonCommandEventBJ({0}, {1})"
		public static extern @event TriggerRegisterCommonCommandEventBJ(trigger trig, string order);
		/// @CSharpLua.Template = "TriggerRegisterGameLoadedEventBJ({0})"
		public static extern @event TriggerRegisterGameLoadedEventBJ(trigger trig);
		/// @CSharpLua.Template = "TriggerRegisterGameSavedEventBJ({0})"
		public static extern @event TriggerRegisterGameSavedEventBJ(trigger trig);
		/// @CSharpLua.Template = "RegisterDestDeathInRegionEnum()"
		public static extern void RegisterDestDeathInRegionEnum();
		/// @CSharpLua.Template = "TriggerRegisterDestDeathInRegionEvent({0}, {1})"
		public static extern void TriggerRegisterDestDeathInRegionEvent(trigger trig, rect r);
		/// @CSharpLua.Template = "AddWeatherEffectSaveLast({0}, {1})"
		public static extern weathereffect AddWeatherEffectSaveLast(rect where, int effectID);
		/// @CSharpLua.Template = "GetLastCreatedWeatherEffect()"
		public static extern weathereffect GetLastCreatedWeatherEffect();
		/// @CSharpLua.Template = "RemoveWeatherEffectBJ({0})"
		public static extern void RemoveWeatherEffectBJ(weathereffect whichWeatherEffect);
		/// @CSharpLua.Template = "TerrainDeformationCraterBJ({0}, {1}, {2}, {3}, {4})"
		public static extern terraindeformation TerrainDeformationCraterBJ(float duration, bool permanent, location where, float radius, float depth);
		/// @CSharpLua.Template = "TerrainDeformationRippleBJ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern terraindeformation TerrainDeformationRippleBJ(float duration, bool limitNeg, location where, float startRadius, float endRadius, float depth, float wavePeriod, float waveWidth);
		/// @CSharpLua.Template = "TerrainDeformationWaveBJ({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern terraindeformation TerrainDeformationWaveBJ(float duration, location source, location target, float radius, float depth, float trailDelay);
		/// @CSharpLua.Template = "TerrainDeformationRandomBJ({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern terraindeformation TerrainDeformationRandomBJ(float duration, location where, float radius, float minDelta, float maxDelta, float updateInterval);
		/// @CSharpLua.Template = "TerrainDeformationStopBJ({0}, {1})"
		public static extern void TerrainDeformationStopBJ(terraindeformation deformation, float duration);
		/// @CSharpLua.Template = "GetLastCreatedTerrainDeformation()"
		public static extern terraindeformation GetLastCreatedTerrainDeformation();
		/// @CSharpLua.Template = "AddLightningLoc({0}, {1}, {2})"
		public static extern lightning AddLightningLoc(string codeName, location where1, location where2);
		/// @CSharpLua.Template = "DestroyLightningBJ({0})"
		public static extern bool DestroyLightningBJ(lightning whichBolt);
		/// @CSharpLua.Template = "MoveLightningLoc({0}, {1}, {2})"
		public static extern bool MoveLightningLoc(lightning whichBolt, location where1, location where2);
		/// @CSharpLua.Template = "GetLightningColorABJ({0})"
		public static extern float GetLightningColorABJ(lightning whichBolt);
		/// @CSharpLua.Template = "GetLightningColorRBJ({0})"
		public static extern float GetLightningColorRBJ(lightning whichBolt);
		/// @CSharpLua.Template = "GetLightningColorGBJ({0})"
		public static extern float GetLightningColorGBJ(lightning whichBolt);
		/// @CSharpLua.Template = "GetLightningColorBBJ({0})"
		public static extern float GetLightningColorBBJ(lightning whichBolt);
		/// @CSharpLua.Template = "SetLightningColorBJ({0}, {1}, {2}, {3}, {4})"
		public static extern bool SetLightningColorBJ(lightning whichBolt, float r, float g, float b, float a);
		/// @CSharpLua.Template = "GetLastCreatedLightningBJ()"
		public static extern lightning GetLastCreatedLightningBJ();
		/// @CSharpLua.Template = "GetAbilityEffectBJ({0}, {1}, {2})"
		public static extern string GetAbilityEffectBJ(int abilcode, effecttype t, int index);
		/// @CSharpLua.Template = "GetAbilitySoundBJ({0}, {1})"
		public static extern string GetAbilitySoundBJ(int abilcode, soundtype t);
		/// @CSharpLua.Template = "GetTerrainCliffLevelBJ({0})"
		public static extern int GetTerrainCliffLevelBJ(location where);
		/// @CSharpLua.Template = "GetTerrainTypeBJ({0})"
		public static extern int GetTerrainTypeBJ(location where);
		/// @CSharpLua.Template = "GetTerrainVarianceBJ({0})"
		public static extern int GetTerrainVarianceBJ(location where);
		/// @CSharpLua.Template = "SetTerrainTypeBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void SetTerrainTypeBJ(location where, int terrainType, int variation, int area, int shape);
		/// @CSharpLua.Template = "IsTerrainPathableBJ({0}, {1})"
		public static extern bool IsTerrainPathableBJ(location where, pathingtype t);
		/// @CSharpLua.Template = "SetTerrainPathableBJ({0}, {1}, {2})"
		public static extern void SetTerrainPathableBJ(location where, pathingtype t, bool flag);
		/// @CSharpLua.Template = "SetWaterBaseColorBJ({0}, {1}, {2}, {3})"
		public static extern void SetWaterBaseColorBJ(float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "CreateFogModifierRectSimple({0}, {1}, {2}, {3})"
		public static extern fogmodifier CreateFogModifierRectSimple(player whichPlayer, fogstate whichFogState, rect r, bool afterUnits);
		/// @CSharpLua.Template = "CreateFogModifierRadiusLocSimple({0}, {1}, {2}, {3}, {4})"
		public static extern fogmodifier CreateFogModifierRadiusLocSimple(player whichPlayer, fogstate whichFogState, location center, float radius, bool afterUnits);
		/// @CSharpLua.Template = "CreateFogModifierRectBJ({0}, {1}, {2}, {3})"
		public static extern fogmodifier CreateFogModifierRectBJ(bool enabled, player whichPlayer, fogstate whichFogState, rect r);
		/// @CSharpLua.Template = "CreateFogModifierRadiusLocBJ({0}, {1}, {2}, {3}, {4})"
		public static extern fogmodifier CreateFogModifierRadiusLocBJ(bool enabled, player whichPlayer, fogstate whichFogState, location center, float radius);
		/// @CSharpLua.Template = "GetLastCreatedFogModifier()"
		public static extern fogmodifier GetLastCreatedFogModifier();
		/// @CSharpLua.Template = "FogEnableOn()"
		public static extern void FogEnableOn();
		/// @CSharpLua.Template = "FogEnableOff()"
		public static extern void FogEnableOff();
		/// @CSharpLua.Template = "FogMaskEnableOn()"
		public static extern void FogMaskEnableOn();
		/// @CSharpLua.Template = "FogMaskEnableOff()"
		public static extern void FogMaskEnableOff();
		/// @CSharpLua.Template = "UseTimeOfDayBJ({0})"
		public static extern void UseTimeOfDayBJ(bool flag);
		/// @CSharpLua.Template = "SetTerrainFogExBJ({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern void SetTerrainFogExBJ(int style, float zstart, float zend, float density, float red, float green, float blue);
		/// @CSharpLua.Template = "ResetTerrainFogBJ()"
		public static extern void ResetTerrainFogBJ();
		/// @CSharpLua.Template = "SetDoodadAnimationBJ({0}, {1}, {2}, {3})"
		public static extern void SetDoodadAnimationBJ(string animName, int doodadID, float radius, location center);
		/// @CSharpLua.Template = "SetDoodadAnimationRectBJ({0}, {1}, {2})"
		public static extern void SetDoodadAnimationRectBJ(string animName, int doodadID, rect r);
		/// @CSharpLua.Template = "AddUnitAnimationPropertiesBJ({0}, {1}, {2})"
		public static extern void AddUnitAnimationPropertiesBJ(bool add, string animProperties, unit whichUnit);
		/// @CSharpLua.Template = "CreateImageBJ({0}, {1}, {2}, {3}, {4})"
		public static extern image CreateImageBJ(string file, float size, location where, float zOffset, int imageType);
		/// @CSharpLua.Template = "ShowImageBJ({0}, {1})"
		public static extern void ShowImageBJ(bool flag, image whichImage);
		/// @CSharpLua.Template = "SetImagePositionBJ({0}, {1}, {2})"
		public static extern void SetImagePositionBJ(image whichImage, location where, float zOffset);
		/// @CSharpLua.Template = "SetImageColorBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void SetImageColorBJ(image whichImage, float red, float green, float blue, float alpha);
		/// @CSharpLua.Template = "GetLastCreatedImage()"
		public static extern image GetLastCreatedImage();
		/// @CSharpLua.Template = "CreateUbersplatBJ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern ubersplat CreateUbersplatBJ(location where, string name, float red, float green, float blue, float alpha, bool forcePaused, bool noBirthTime);
		/// @CSharpLua.Template = "ShowUbersplatBJ({0}, {1})"
		public static extern void ShowUbersplatBJ(bool flag, ubersplat whichSplat);
		/// @CSharpLua.Template = "GetLastCreatedUbersplat()"
		public static extern ubersplat GetLastCreatedUbersplat();
		/// @CSharpLua.Template = "GetLastCreatedMinimapIcon()"
		public static extern minimapicon GetLastCreatedMinimapIcon();
		/// @CSharpLua.Template = "CreateMinimapIconOnUnitBJ({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern minimapicon CreateMinimapIconOnUnitBJ(unit whichUnit, int red, int green, int blue, string pingPath, fogstate fogVisibility);
		/// @CSharpLua.Template = "CreateMinimapIconAtLocBJ({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern minimapicon CreateMinimapIconAtLocBJ(location where, int red, int green, int blue, string pingPath, fogstate fogVisibility);
		/// @CSharpLua.Template = "CreateMinimapIconBJ({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern minimapicon CreateMinimapIconBJ(float x, float y, int red, int green, int blue, string pingPath, fogstate fogVisibility);
		/// @CSharpLua.Template = "CampaignMinimapIconUnitBJ({0}, {1})"
		public static extern void CampaignMinimapIconUnitBJ(unit whichUnit, int style);
		/// @CSharpLua.Template = "CampaignMinimapIconLocBJ({0}, {1})"
		public static extern void CampaignMinimapIconLocBJ(location where, int style);
		/// @CSharpLua.Template = "PlaySoundBJ({0})"
		public static extern void PlaySoundBJ(sound soundHandle);
		/// @CSharpLua.Template = "StopSoundBJ({0}, {1})"
		public static extern void StopSoundBJ(sound soundHandle, bool fadeOut);
		/// @CSharpLua.Template = "SetSoundVolumeBJ({0}, {1})"
		public static extern void SetSoundVolumeBJ(sound soundHandle, float volumePercent);
		/// @CSharpLua.Template = "SetSoundOffsetBJ({0}, {1})"
		public static extern void SetSoundOffsetBJ(float newOffset, sound soundHandle);
		/// @CSharpLua.Template = "SetSoundDistanceCutoffBJ({0}, {1})"
		public static extern void SetSoundDistanceCutoffBJ(sound soundHandle, float cutoff);
		/// @CSharpLua.Template = "SetSoundPitchBJ({0}, {1})"
		public static extern void SetSoundPitchBJ(sound soundHandle, float pitch);
		/// @CSharpLua.Template = "SetSoundPositionLocBJ({0}, {1}, {2})"
		public static extern void SetSoundPositionLocBJ(sound soundHandle, location loc, float z);
		/// @CSharpLua.Template = "AttachSoundToUnitBJ({0}, {1})"
		public static extern void AttachSoundToUnitBJ(sound soundHandle, unit whichUnit);
		/// @CSharpLua.Template = "SetSoundConeAnglesBJ({0}, {1}, {2}, {3})"
		public static extern void SetSoundConeAnglesBJ(sound soundHandle, float inside, float outside, float outsideVolumePercent);
		/// @CSharpLua.Template = "KillSoundWhenDoneBJ({0})"
		public static extern void KillSoundWhenDoneBJ(sound soundHandle);
		/// @CSharpLua.Template = "PlaySoundAtPointBJ({0}, {1}, {2}, {3})"
		public static extern void PlaySoundAtPointBJ(sound soundHandle, float volumePercent, location loc, float z);
		/// @CSharpLua.Template = "PlaySoundOnUnitBJ({0}, {1}, {2})"
		public static extern void PlaySoundOnUnitBJ(sound soundHandle, float volumePercent, unit whichUnit);
		/// @CSharpLua.Template = "PlaySoundFromOffsetBJ({0}, {1}, {2})"
		public static extern void PlaySoundFromOffsetBJ(sound soundHandle, float volumePercent, float startingOffset);
		/// @CSharpLua.Template = "PlayMusicBJ({0})"
		public static extern void PlayMusicBJ(string musicFileName);
		/// @CSharpLua.Template = "PlayMusicExBJ({0}, {1}, {2})"
		public static extern void PlayMusicExBJ(string musicFileName, float startingOffset, float fadeInTime);
		/// @CSharpLua.Template = "SetMusicOffsetBJ({0})"
		public static extern void SetMusicOffsetBJ(float newOffset);
		/// @CSharpLua.Template = "PlayThematicMusicBJ({0})"
		public static extern void PlayThematicMusicBJ(string musicName);
		/// @CSharpLua.Template = "PlayThematicMusicExBJ({0}, {1})"
		public static extern void PlayThematicMusicExBJ(string musicName, float startingOffset);
		/// @CSharpLua.Template = "SetThematicMusicOffsetBJ({0})"
		public static extern void SetThematicMusicOffsetBJ(float newOffset);
		/// @CSharpLua.Template = "EndThematicMusicBJ()"
		public static extern void EndThematicMusicBJ();
		/// @CSharpLua.Template = "StopMusicBJ({0})"
		public static extern void StopMusicBJ(bool fadeOut);
		/// @CSharpLua.Template = "ResumeMusicBJ()"
		public static extern void ResumeMusicBJ();
		/// @CSharpLua.Template = "SetMusicVolumeBJ({0})"
		public static extern void SetMusicVolumeBJ(float volumePercent);
		/// @CSharpLua.Template = "SetThematicMusicVolumeBJ({0})"
		public static extern void SetThematicMusicVolumeBJ(float volumePercent);
		/// @CSharpLua.Template = "GetSoundDurationBJ({0})"
		public static extern float GetSoundDurationBJ(sound soundHandle);
		/// @CSharpLua.Template = "GetSoundFileDurationBJ({0})"
		public static extern float GetSoundFileDurationBJ(string musicFileName);
		/// @CSharpLua.Template = "GetLastPlayedSound()"
		public static extern sound GetLastPlayedSound();
		/// @CSharpLua.Template = "GetLastPlayedMusic()"
		public static extern string GetLastPlayedMusic();
		/// @CSharpLua.Template = "VolumeGroupSetVolumeBJ({0}, {1})"
		public static extern void VolumeGroupSetVolumeBJ(volumegroup vgroup, float percent);
		/// @CSharpLua.Template = "SetCineModeVolumeGroupsImmediateBJ()"
		public static extern void SetCineModeVolumeGroupsImmediateBJ();
		/// @CSharpLua.Template = "SetCineModeVolumeGroupsBJ()"
		public static extern void SetCineModeVolumeGroupsBJ();
		/// @CSharpLua.Template = "SetSpeechVolumeGroupsImmediateBJ()"
		public static extern void SetSpeechVolumeGroupsImmediateBJ();
		/// @CSharpLua.Template = "SetSpeechVolumeGroupsBJ()"
		public static extern void SetSpeechVolumeGroupsBJ();
		/// @CSharpLua.Template = "VolumeGroupResetImmediateBJ()"
		public static extern void VolumeGroupResetImmediateBJ();
		/// @CSharpLua.Template = "VolumeGroupResetBJ()"
		public static extern void VolumeGroupResetBJ();
		/// @CSharpLua.Template = "GetSoundIsPlayingBJ({0})"
		public static extern bool GetSoundIsPlayingBJ(sound soundHandle);
		/// @CSharpLua.Template = "WaitForSoundBJ({0}, {1})"
		public static extern void WaitForSoundBJ(sound soundHandle, float offset);
		/// @CSharpLua.Template = "SetMapMusicIndexedBJ({0}, {1})"
		public static extern void SetMapMusicIndexedBJ(string musicName, int index);
		/// @CSharpLua.Template = "SetMapMusicRandomBJ({0})"
		public static extern void SetMapMusicRandomBJ(string musicName);
		/// @CSharpLua.Template = "ClearMapMusicBJ()"
		public static extern void ClearMapMusicBJ();
		/// @CSharpLua.Template = "SetStackedSoundBJ({0}, {1}, {2})"
		public static extern void SetStackedSoundBJ(bool add, sound soundHandle, rect r);
		/// @CSharpLua.Template = "StartSoundForPlayerBJ({0}, {1})"
		public static extern void StartSoundForPlayerBJ(player whichPlayer, sound soundHandle);
		/// @CSharpLua.Template = "VolumeGroupSetVolumeForPlayerBJ({0}, {1}, {2})"
		public static extern void VolumeGroupSetVolumeForPlayerBJ(player whichPlayer, volumegroup vgroup, float scale);
		/// @CSharpLua.Template = "EnableDawnDusk({0})"
		public static extern void EnableDawnDusk(bool flag);
		/// @CSharpLua.Template = "IsDawnDuskEnabled()"
		public static extern bool IsDawnDuskEnabled();
		/// @CSharpLua.Template = "SetAmbientDaySound({0})"
		public static extern void SetAmbientDaySound(string inLabel);
		/// @CSharpLua.Template = "SetAmbientNightSound({0})"
		public static extern void SetAmbientNightSound(string inLabel);
		/// @CSharpLua.Template = "AddSpecialEffectLocBJ({0}, {1})"
		public static extern effect AddSpecialEffectLocBJ(location where, string modelName);
		/// @CSharpLua.Template = "AddSpecialEffectTargetUnitBJ({0}, {1}, {2})"
		public static extern effect AddSpecialEffectTargetUnitBJ(string attachPointName, widget targetWidget, string modelName);
		/// @CSharpLua.Template = "DestroyEffectBJ({0})"
		public static extern void DestroyEffectBJ(effect whichEffect);
		/// @CSharpLua.Template = "GetLastCreatedEffectBJ()"
		public static extern effect GetLastCreatedEffectBJ();
		/// @CSharpLua.Template = "CreateCommandButtonEffectBJ({0}, {1})"
		public static extern commandbuttoneffect CreateCommandButtonEffectBJ(int abilityId, string order);
		/// @CSharpLua.Template = "CreateTrainCommandButtonEffectBJ({0})"
		public static extern commandbuttoneffect CreateTrainCommandButtonEffectBJ(int unitId);
		/// @CSharpLua.Template = "CreateUpgradeCommandButtonEffectBJ({0})"
		public static extern commandbuttoneffect CreateUpgradeCommandButtonEffectBJ(int techId);
		/// @CSharpLua.Template = "CreateCommonCommandButtonEffectBJ({0})"
		public static extern commandbuttoneffect CreateCommonCommandButtonEffectBJ(string order);
		/// @CSharpLua.Template = "CreateLearnCommandButtonEffectBJ({0})"
		public static extern commandbuttoneffect CreateLearnCommandButtonEffectBJ(int abilityId);
		/// @CSharpLua.Template = "CreateBuildCommandButtonEffectBJ({0})"
		public static extern commandbuttoneffect CreateBuildCommandButtonEffectBJ(int unitId);
		/// @CSharpLua.Template = "GetLastCreatedCommandButtonEffectBJ()"
		public static extern commandbuttoneffect GetLastCreatedCommandButtonEffectBJ();
		/// @CSharpLua.Template = "GetItemLoc({0})"
		public static extern location GetItemLoc(item whichItem);
		/// @CSharpLua.Template = "GetItemLifeBJ({0})"
		public static extern float GetItemLifeBJ(widget whichWidget);
		/// @CSharpLua.Template = "SetItemLifeBJ({0}, {1})"
		public static extern void SetItemLifeBJ(widget whichWidget, float life);
		/// @CSharpLua.Template = "AddHeroXPSwapped({0}, {1}, {2})"
		public static extern void AddHeroXPSwapped(int xpToAdd, unit whichHero, bool showEyeCandy);
		/// @CSharpLua.Template = "SetHeroLevelBJ({0}, {1}, {2})"
		public static extern void SetHeroLevelBJ(unit whichHero, int newLevel, bool showEyeCandy);
		/// @CSharpLua.Template = "DecUnitAbilityLevelSwapped({0}, {1})"
		public static extern int DecUnitAbilityLevelSwapped(int abilcode, unit whichUnit);
		/// @CSharpLua.Template = "IncUnitAbilityLevelSwapped({0}, {1})"
		public static extern int IncUnitAbilityLevelSwapped(int abilcode, unit whichUnit);
		/// @CSharpLua.Template = "SetUnitAbilityLevelSwapped({0}, {1}, {2})"
		public static extern int SetUnitAbilityLevelSwapped(int abilcode, unit whichUnit, int level);
		/// @CSharpLua.Template = "GetUnitAbilityLevelSwapped({0}, {1})"
		public static extern int GetUnitAbilityLevelSwapped(int abilcode, unit whichUnit);
		/// @CSharpLua.Template = "UnitHasBuffBJ({0}, {1})"
		public static extern bool UnitHasBuffBJ(unit whichUnit, int buffcode);
		/// @CSharpLua.Template = "UnitRemoveBuffBJ({0}, {1})"
		public static extern bool UnitRemoveBuffBJ(int buffcode, unit whichUnit);
		/// @CSharpLua.Template = "UnitAddItemSwapped({0}, {1})"
		public static extern bool UnitAddItemSwapped(item whichItem, unit whichHero);
		/// @CSharpLua.Template = "UnitAddItemByIdSwapped({0}, {1})"
		public static extern item UnitAddItemByIdSwapped(int itemId, unit whichHero);
		/// @CSharpLua.Template = "UnitRemoveItemSwapped({0}, {1})"
		public static extern void UnitRemoveItemSwapped(item whichItem, unit whichHero);
		/// @CSharpLua.Template = "UnitRemoveItemFromSlotSwapped({0}, {1})"
		public static extern item UnitRemoveItemFromSlotSwapped(int itemSlot, unit whichHero);
		/// @CSharpLua.Template = "CreateItemLoc({0}, {1})"
		public static extern item CreateItemLoc(int itemId, location loc);
		/// @CSharpLua.Template = "GetLastCreatedItem()"
		public static extern item GetLastCreatedItem();
		/// @CSharpLua.Template = "GetLastRemovedItem()"
		public static extern item GetLastRemovedItem();
		/// @CSharpLua.Template = "SetItemPositionLoc({0}, {1})"
		public static extern void SetItemPositionLoc(item whichItem, location loc);
		/// @CSharpLua.Template = "GetLearnedSkillBJ()"
		public static extern int GetLearnedSkillBJ();
		/// @CSharpLua.Template = "SuspendHeroXPBJ({0}, {1})"
		public static extern void SuspendHeroXPBJ(bool flag, unit whichHero);
		/// @CSharpLua.Template = "SetPlayerHandicapDamageBJ({0}, {1})"
		public static extern void SetPlayerHandicapDamageBJ(player whichPlayer, float handicapPercent);
		/// @CSharpLua.Template = "GetPlayerHandicapDamageBJ({0})"
		public static extern float GetPlayerHandicapDamageBJ(player whichPlayer);
		/// @CSharpLua.Template = "SetPlayerHandicapReviveTimeBJ({0}, {1})"
		public static extern void SetPlayerHandicapReviveTimeBJ(player whichPlayer, float handicapPercent);
		/// @CSharpLua.Template = "GetPlayerHandicapReviveTimeBJ({0})"
		public static extern float GetPlayerHandicapReviveTimeBJ(player whichPlayer);
		/// @CSharpLua.Template = "SetPlayerHandicapXPBJ({0}, {1})"
		public static extern void SetPlayerHandicapXPBJ(player whichPlayer, float handicapPercent);
		/// @CSharpLua.Template = "GetPlayerHandicapXPBJ({0})"
		public static extern float GetPlayerHandicapXPBJ(player whichPlayer);
		/// @CSharpLua.Template = "SetPlayerHandicapBJ({0}, {1})"
		public static extern void SetPlayerHandicapBJ(player whichPlayer, float handicapPercent);
		/// @CSharpLua.Template = "GetPlayerHandicapBJ({0})"
		public static extern float GetPlayerHandicapBJ(player whichPlayer);
		/// @CSharpLua.Template = "GetHeroStatBJ({0}, {1}, {2})"
		public static extern int GetHeroStatBJ(int whichStat, unit whichHero, bool includeBonuses);
		/// @CSharpLua.Template = "SetHeroStat({0}, {1}, {2})"
		public static extern void SetHeroStat(unit whichHero, int whichStat, int value);
		/// @CSharpLua.Template = "ModifyHeroStat({0}, {1}, {2}, {3})"
		public static extern void ModifyHeroStat(int whichStat, unit whichHero, int modifyMethod, int value);
		/// @CSharpLua.Template = "ModifyHeroSkillPoints({0}, {1}, {2})"
		public static extern bool ModifyHeroSkillPoints(unit whichHero, int modifyMethod, int value);
		/// @CSharpLua.Template = "UnitDropItemPointBJ({0}, {1}, {2}, {3})"
		public static extern bool UnitDropItemPointBJ(unit whichUnit, item whichItem, float x, float y);
		/// @CSharpLua.Template = "UnitDropItemPointLoc({0}, {1}, {2})"
		public static extern bool UnitDropItemPointLoc(unit whichUnit, item whichItem, location loc);
		/// @CSharpLua.Template = "UnitDropItemSlotBJ({0}, {1}, {2})"
		public static extern bool UnitDropItemSlotBJ(unit whichUnit, item whichItem, int slot);
		/// @CSharpLua.Template = "UnitDropItemTargetBJ({0}, {1}, {2})"
		public static extern bool UnitDropItemTargetBJ(unit whichUnit, item whichItem, widget target);
		/// @CSharpLua.Template = "UnitUseItemDestructable({0}, {1}, {2})"
		public static extern bool UnitUseItemDestructable(unit whichUnit, item whichItem, widget target);
		/// @CSharpLua.Template = "UnitUseItemPointLoc({0}, {1}, {2})"
		public static extern bool UnitUseItemPointLoc(unit whichUnit, item whichItem, location loc);
		/// @CSharpLua.Template = "UnitItemInSlotBJ({0}, {1})"
		public static extern item UnitItemInSlotBJ(unit whichUnit, int itemSlot);
		/// @CSharpLua.Template = "GetInventoryIndexOfItemTypeBJ({0}, {1})"
		public static extern int GetInventoryIndexOfItemTypeBJ(unit whichUnit, int itemId);
		/// @CSharpLua.Template = "GetItemOfTypeFromUnitBJ({0}, {1})"
		public static extern item GetItemOfTypeFromUnitBJ(unit whichUnit, int itemId);
		/// @CSharpLua.Template = "UnitHasItemOfTypeBJ({0}, {1})"
		public static extern bool UnitHasItemOfTypeBJ(unit whichUnit, int itemId);
		/// @CSharpLua.Template = "UnitInventoryCount({0})"
		public static extern int UnitInventoryCount(unit whichUnit);
		/// @CSharpLua.Template = "UnitInventorySizeBJ({0})"
		public static extern int UnitInventorySizeBJ(unit whichUnit);
		/// @CSharpLua.Template = "SetItemInvulnerableBJ({0}, {1})"
		public static extern void SetItemInvulnerableBJ(item whichItem, bool flag);
		/// @CSharpLua.Template = "SetItemDropOnDeathBJ({0}, {1})"
		public static extern void SetItemDropOnDeathBJ(item whichItem, bool flag);
		/// @CSharpLua.Template = "SetItemDroppableBJ({0}, {1})"
		public static extern void SetItemDroppableBJ(item whichItem, bool flag);
		/// @CSharpLua.Template = "SetItemPlayerBJ({0}, {1}, {2})"
		public static extern void SetItemPlayerBJ(item whichItem, player whichPlayer, bool changeColor);
		/// @CSharpLua.Template = "SetItemVisibleBJ({0}, {1})"
		public static extern void SetItemVisibleBJ(bool show, item whichItem);
		/// @CSharpLua.Template = "IsItemHiddenBJ({0})"
		public static extern bool IsItemHiddenBJ(item whichItem);
		/// @CSharpLua.Template = "ChooseRandomItemBJ({0})"
		public static extern int ChooseRandomItemBJ(int level);
		/// @CSharpLua.Template = "ChooseRandomItemExBJ({0}, {1})"
		public static extern int ChooseRandomItemExBJ(int level, itemtype whichType);
		/// @CSharpLua.Template = "ChooseRandomNPBuildingBJ()"
		public static extern int ChooseRandomNPBuildingBJ();
		/// @CSharpLua.Template = "ChooseRandomCreepBJ({0})"
		public static extern int ChooseRandomCreepBJ(int level);
		/// @CSharpLua.Template = "EnumItemsInRectBJ({0}, {1})"
		public static extern void EnumItemsInRectBJ(rect r, System.Action actionFunc);
		/// @CSharpLua.Template = "RandomItemInRectBJEnum()"
		public static extern void RandomItemInRectBJEnum();
		/// @CSharpLua.Template = "RandomItemInRectBJ({0}, {1})"
		public static extern item RandomItemInRectBJ(rect r, boolexpr filter);
		/// @CSharpLua.Template = "RandomItemInRectSimpleBJ({0})"
		public static extern item RandomItemInRectSimpleBJ(rect r);
		/// @CSharpLua.Template = "CheckItemStatus({0}, {1})"
		public static extern bool CheckItemStatus(item whichItem, int status);
		/// @CSharpLua.Template = "CheckItemcodeStatus({0}, {1})"
		public static extern bool CheckItemcodeStatus(int itemId, int status);
		/// @CSharpLua.Template = "UnitId2OrderIdBJ({0})"
		public static extern int UnitId2OrderIdBJ(int unitId);
		/// @CSharpLua.Template = "String2UnitIdBJ({0})"
		public static extern int String2UnitIdBJ(string unitIdString);
		/// @CSharpLua.Template = "UnitId2StringBJ({0})"
		public static extern string UnitId2StringBJ(int unitId);
		/// @CSharpLua.Template = "String2OrderIdBJ({0})"
		public static extern int String2OrderIdBJ(string orderIdString);
		/// @CSharpLua.Template = "OrderId2StringBJ({0})"
		public static extern string OrderId2StringBJ(int orderId);
		/// @CSharpLua.Template = "GetIssuedOrderIdBJ()"
		public static extern int GetIssuedOrderIdBJ();
		/// @CSharpLua.Template = "GetKillingUnitBJ()"
		public static extern unit GetKillingUnitBJ();
		/// @CSharpLua.Template = "CreateUnitAtLocSaveLast({0}, {1}, {2}, {3})"
		public static extern unit CreateUnitAtLocSaveLast(player id, int unitid, location loc, float face);
		/// @CSharpLua.Template = "GetLastCreatedUnit()"
		public static extern unit GetLastCreatedUnit();
		/// @CSharpLua.Template = "CreateNUnitsAtLoc({0}, {1}, {2}, {3}, {4})"
		public static extern group CreateNUnitsAtLoc(int count, int unitId, player whichPlayer, location loc, float face);
		/// @CSharpLua.Template = "CreateNUnitsAtLocFacingLocBJ({0}, {1}, {2}, {3}, {4})"
		public static extern group CreateNUnitsAtLocFacingLocBJ(int count, int unitId, player whichPlayer, location loc, location lookAt);
		/// @CSharpLua.Template = "GetLastCreatedGroupEnum()"
		public static extern void GetLastCreatedGroupEnum();
		/// @CSharpLua.Template = "GetLastCreatedGroup()"
		public static extern group GetLastCreatedGroup();
		/// @CSharpLua.Template = "CreateCorpseLocBJ({0}, {1}, {2})"
		public static extern unit CreateCorpseLocBJ(int unitid, player whichPlayer, location loc);
		/// @CSharpLua.Template = "UnitSuspendDecayBJ({0}, {1})"
		public static extern void UnitSuspendDecayBJ(bool suspend, unit whichUnit);
		/// @CSharpLua.Template = "DelayedSuspendDecayStopAnimEnum()"
		public static extern void DelayedSuspendDecayStopAnimEnum();
		/// @CSharpLua.Template = "DelayedSuspendDecayBoneEnum()"
		public static extern void DelayedSuspendDecayBoneEnum();
		/// @CSharpLua.Template = "DelayedSuspendDecayFleshEnum()"
		public static extern void DelayedSuspendDecayFleshEnum();
		/// @CSharpLua.Template = "DelayedSuspendDecay()"
		public static extern void DelayedSuspendDecay();
		/// @CSharpLua.Template = "DelayedSuspendDecayCreate()"
		public static extern void DelayedSuspendDecayCreate();
		/// @CSharpLua.Template = "CreatePermanentCorpseLocBJ({0}, {1}, {2}, {3}, {4})"
		public static extern unit CreatePermanentCorpseLocBJ(int style, int unitid, player whichPlayer, location loc, float facing);
		/// @CSharpLua.Template = "GetUnitStateSwap({0}, {1})"
		public static extern float GetUnitStateSwap(unitstate whichState, unit whichUnit);
		/// @CSharpLua.Template = "GetUnitStatePercent({0}, {1}, {2})"
		public static extern float GetUnitStatePercent(unit whichUnit, unitstate whichState, unitstate whichMaxState);
		/// @CSharpLua.Template = "GetUnitLifePercent({0})"
		public static extern float GetUnitLifePercent(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitManaPercent({0})"
		public static extern float GetUnitManaPercent(unit whichUnit);
		/// @CSharpLua.Template = "SelectUnitSingle({0})"
		public static extern void SelectUnitSingle(unit whichUnit);
		/// @CSharpLua.Template = "SelectGroupBJEnum()"
		public static extern void SelectGroupBJEnum();
		/// @CSharpLua.Template = "SelectGroupBJ({0})"
		public static extern void SelectGroupBJ(group g);
		/// @CSharpLua.Template = "SelectUnitAdd({0})"
		public static extern void SelectUnitAdd(unit whichUnit);
		/// @CSharpLua.Template = "SelectUnitRemove({0})"
		public static extern void SelectUnitRemove(unit whichUnit);
		/// @CSharpLua.Template = "ClearSelectionForPlayer({0})"
		public static extern void ClearSelectionForPlayer(player whichPlayer);
		/// @CSharpLua.Template = "SelectUnitForPlayerSingle({0}, {1})"
		public static extern void SelectUnitForPlayerSingle(unit whichUnit, player whichPlayer);
		/// @CSharpLua.Template = "SelectGroupForPlayerBJ({0}, {1})"
		public static extern void SelectGroupForPlayerBJ(group g, player whichPlayer);
		/// @CSharpLua.Template = "SelectUnitAddForPlayer({0}, {1})"
		public static extern void SelectUnitAddForPlayer(unit whichUnit, player whichPlayer);
		/// @CSharpLua.Template = "SelectUnitRemoveForPlayer({0}, {1})"
		public static extern void SelectUnitRemoveForPlayer(unit whichUnit, player whichPlayer);
		/// @CSharpLua.Template = "SetUnitLifeBJ({0}, {1})"
		public static extern void SetUnitLifeBJ(unit whichUnit, float newValue);
		/// @CSharpLua.Template = "SetUnitManaBJ({0}, {1})"
		public static extern void SetUnitManaBJ(unit whichUnit, float newValue);
		/// @CSharpLua.Template = "SetUnitLifePercentBJ({0}, {1})"
		public static extern void SetUnitLifePercentBJ(unit whichUnit, float percent);
		/// @CSharpLua.Template = "SetUnitManaPercentBJ({0}, {1})"
		public static extern void SetUnitManaPercentBJ(unit whichUnit, float percent);
		/// @CSharpLua.Template = "IsUnitDeadBJ({0})"
		public static extern bool IsUnitDeadBJ(unit whichUnit);
		/// @CSharpLua.Template = "IsUnitAliveBJ({0})"
		public static extern bool IsUnitAliveBJ(unit whichUnit);
		/// @CSharpLua.Template = "IsUnitGroupDeadBJEnum()"
		public static extern void IsUnitGroupDeadBJEnum();
		/// @CSharpLua.Template = "IsUnitGroupDeadBJ({0})"
		public static extern bool IsUnitGroupDeadBJ(group g);
		/// @CSharpLua.Template = "IsUnitGroupEmptyBJEnum()"
		public static extern void IsUnitGroupEmptyBJEnum();
		/// @CSharpLua.Template = "IsUnitGroupEmptyBJ({0})"
		public static extern bool IsUnitGroupEmptyBJ(group g);
		/// @CSharpLua.Template = "IsUnitGroupInRectBJEnum()"
		public static extern void IsUnitGroupInRectBJEnum();
		/// @CSharpLua.Template = "IsUnitGroupInRectBJ({0}, {1})"
		public static extern bool IsUnitGroupInRectBJ(group g, rect r);
		/// @CSharpLua.Template = "IsUnitHiddenBJ({0})"
		public static extern bool IsUnitHiddenBJ(unit whichUnit);
		/// @CSharpLua.Template = "ShowUnitHide({0})"
		public static extern void ShowUnitHide(unit whichUnit);
		/// @CSharpLua.Template = "ShowUnitShow({0})"
		public static extern void ShowUnitShow(unit whichUnit);
		/// @CSharpLua.Template = "IssueHauntOrderAtLocBJFilter()"
		public static extern bool IssueHauntOrderAtLocBJFilter();
		/// @CSharpLua.Template = "IssueHauntOrderAtLocBJ({0}, {1})"
		public static extern bool IssueHauntOrderAtLocBJ(unit whichPeon, location loc);
		/// @CSharpLua.Template = "IssueBuildOrderByIdLocBJ({0}, {1}, {2})"
		public static extern bool IssueBuildOrderByIdLocBJ(unit whichPeon, int unitId, location loc);
		/// @CSharpLua.Template = "IssueTrainOrderByIdBJ({0}, {1})"
		public static extern bool IssueTrainOrderByIdBJ(unit whichUnit, int unitId);
		/// @CSharpLua.Template = "GroupTrainOrderByIdBJ({0}, {1})"
		public static extern bool GroupTrainOrderByIdBJ(group g, int unitId);
		/// @CSharpLua.Template = "IssueUpgradeOrderByIdBJ({0}, {1})"
		public static extern bool IssueUpgradeOrderByIdBJ(unit whichUnit, int techId);
		/// @CSharpLua.Template = "GetAttackedUnitBJ()"
		public static extern unit GetAttackedUnitBJ();
		/// @CSharpLua.Template = "SetUnitFlyHeightBJ({0}, {1}, {2})"
		public static extern void SetUnitFlyHeightBJ(unit whichUnit, float newHeight, float rate);
		/// @CSharpLua.Template = "SetUnitTurnSpeedBJ({0}, {1})"
		public static extern void SetUnitTurnSpeedBJ(unit whichUnit, float turnSpeed);
		/// @CSharpLua.Template = "SetUnitPropWindowBJ({0}, {1})"
		public static extern void SetUnitPropWindowBJ(unit whichUnit, float propWindow);
		/// @CSharpLua.Template = "GetUnitPropWindowBJ({0})"
		public static extern float GetUnitPropWindowBJ(unit whichUnit);
		/// @CSharpLua.Template = "GetUnitDefaultPropWindowBJ({0})"
		public static extern float GetUnitDefaultPropWindowBJ(unit whichUnit);
		/// @CSharpLua.Template = "SetUnitBlendTimeBJ({0}, {1})"
		public static extern void SetUnitBlendTimeBJ(unit whichUnit, float blendTime);
		/// @CSharpLua.Template = "SetUnitAcquireRangeBJ({0}, {1})"
		public static extern void SetUnitAcquireRangeBJ(unit whichUnit, float acquireRange);
		/// @CSharpLua.Template = "UnitSetCanSleepBJ({0}, {1})"
		public static extern void UnitSetCanSleepBJ(unit whichUnit, bool canSleep);
		/// @CSharpLua.Template = "UnitCanSleepBJ({0})"
		public static extern bool UnitCanSleepBJ(unit whichUnit);
		/// @CSharpLua.Template = "UnitWakeUpBJ({0})"
		public static extern void UnitWakeUpBJ(unit whichUnit);
		/// @CSharpLua.Template = "UnitIsSleepingBJ({0})"
		public static extern bool UnitIsSleepingBJ(unit whichUnit);
		/// @CSharpLua.Template = "WakePlayerUnitsEnum()"
		public static extern void WakePlayerUnitsEnum();
		/// @CSharpLua.Template = "WakePlayerUnits({0})"
		public static extern void WakePlayerUnits(player whichPlayer);
		/// @CSharpLua.Template = "EnableCreepSleepBJ({0})"
		public static extern void EnableCreepSleepBJ(bool enable);
		/// @CSharpLua.Template = "UnitGenerateAlarms({0}, {1})"
		public static extern bool UnitGenerateAlarms(unit whichUnit, bool generate);
		/// @CSharpLua.Template = "DoesUnitGenerateAlarms({0})"
		public static extern bool DoesUnitGenerateAlarms(unit whichUnit);
		/// @CSharpLua.Template = "PauseAllUnitsBJEnum()"
		public static extern void PauseAllUnitsBJEnum();
		/// @CSharpLua.Template = "PauseAllUnitsBJ({0})"
		public static extern void PauseAllUnitsBJ(bool pause);
		/// @CSharpLua.Template = "PauseUnitBJ({0}, {1})"
		public static extern void PauseUnitBJ(bool pause, unit whichUnit);
		/// @CSharpLua.Template = "IsUnitPausedBJ({0})"
		public static extern bool IsUnitPausedBJ(unit whichUnit);
		/// @CSharpLua.Template = "UnitPauseTimedLifeBJ({0}, {1})"
		public static extern void UnitPauseTimedLifeBJ(bool flag, unit whichUnit);
		/// @CSharpLua.Template = "UnitApplyTimedLifeBJ({0}, {1}, {2})"
		public static extern void UnitApplyTimedLifeBJ(float duration, int buffId, unit whichUnit);
		/// @CSharpLua.Template = "UnitShareVisionBJ({0}, {1}, {2})"
		public static extern void UnitShareVisionBJ(bool share, unit whichUnit, player whichPlayer);
		/// @CSharpLua.Template = "UnitRemoveBuffsBJ({0}, {1})"
		public static extern void UnitRemoveBuffsBJ(int buffType, unit whichUnit);
		/// @CSharpLua.Template = "UnitRemoveBuffsExBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void UnitRemoveBuffsExBJ(int polarity, int resist, unit whichUnit, bool bTLife, bool bAura);
		/// @CSharpLua.Template = "UnitCountBuffsExBJ({0}, {1}, {2}, {3}, {4})"
		public static extern int UnitCountBuffsExBJ(int polarity, int resist, unit whichUnit, bool bTLife, bool bAura);
		/// @CSharpLua.Template = "UnitRemoveAbilityBJ({0}, {1})"
		public static extern bool UnitRemoveAbilityBJ(int abilityId, unit whichUnit);
		/// @CSharpLua.Template = "UnitAddAbilityBJ({0}, {1})"
		public static extern bool UnitAddAbilityBJ(int abilityId, unit whichUnit);
		/// @CSharpLua.Template = "UnitRemoveTypeBJ({0}, {1})"
		public static extern bool UnitRemoveTypeBJ(unittype whichType, unit whichUnit);
		/// @CSharpLua.Template = "UnitAddTypeBJ({0}, {1})"
		public static extern bool UnitAddTypeBJ(unittype whichType, unit whichUnit);
		/// @CSharpLua.Template = "UnitMakeAbilityPermanentBJ({0}, {1}, {2})"
		public static extern bool UnitMakeAbilityPermanentBJ(bool permanent, int abilityId, unit whichUnit);
		/// @CSharpLua.Template = "SetUnitExplodedBJ({0}, {1})"
		public static extern void SetUnitExplodedBJ(unit whichUnit, bool exploded);
		/// @CSharpLua.Template = "ExplodeUnitBJ({0})"
		public static extern void ExplodeUnitBJ(unit whichUnit);
		/// @CSharpLua.Template = "GetTransportUnitBJ()"
		public static extern unit GetTransportUnitBJ();
		/// @CSharpLua.Template = "GetLoadedUnitBJ()"
		public static extern unit GetLoadedUnitBJ();
		/// @CSharpLua.Template = "IsUnitInTransportBJ({0}, {1})"
		public static extern bool IsUnitInTransportBJ(unit whichUnit, unit whichTransport);
		/// @CSharpLua.Template = "IsUnitLoadedBJ({0})"
		public static extern bool IsUnitLoadedBJ(unit whichUnit);
		/// @CSharpLua.Template = "IsUnitIllusionBJ({0})"
		public static extern bool IsUnitIllusionBJ(unit whichUnit);
		/// @CSharpLua.Template = "ReplaceUnitBJ({0}, {1}, {2})"
		public static extern unit ReplaceUnitBJ(unit whichUnit, int newUnitId, int unitStateMethod);
		/// @CSharpLua.Template = "GetLastReplacedUnitBJ()"
		public static extern unit GetLastReplacedUnitBJ();
		/// @CSharpLua.Template = "SetUnitPositionLocFacingBJ({0}, {1}, {2})"
		public static extern void SetUnitPositionLocFacingBJ(unit whichUnit, location loc, float facing);
		/// @CSharpLua.Template = "SetUnitPositionLocFacingLocBJ({0}, {1}, {2})"
		public static extern void SetUnitPositionLocFacingLocBJ(unit whichUnit, location loc, location lookAt);
		/// @CSharpLua.Template = "AddItemToStockBJ({0}, {1}, {2}, {3})"
		public static extern void AddItemToStockBJ(int itemId, unit whichUnit, int currentStock, int stockMax);
		/// @CSharpLua.Template = "AddUnitToStockBJ({0}, {1}, {2}, {3})"
		public static extern void AddUnitToStockBJ(int unitId, unit whichUnit, int currentStock, int stockMax);
		/// @CSharpLua.Template = "RemoveItemFromStockBJ({0}, {1})"
		public static extern void RemoveItemFromStockBJ(int itemId, unit whichUnit);
		/// @CSharpLua.Template = "RemoveUnitFromStockBJ({0}, {1})"
		public static extern void RemoveUnitFromStockBJ(int unitId, unit whichUnit);
		/// @CSharpLua.Template = "SetUnitUseFoodBJ({0}, {1})"
		public static extern void SetUnitUseFoodBJ(bool enable, unit whichUnit);
		/// @CSharpLua.Template = "UnitDamagePointLoc({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern bool UnitDamagePointLoc(unit whichUnit, float delay, float radius, location loc, float amount, attacktype whichAttack, damagetype whichDamage);
		/// @CSharpLua.Template = "UnitDamageTargetBJ({0}, {1}, {2}, {3}, {4})"
		public static extern bool UnitDamageTargetBJ(unit whichUnit, unit target, float amount, attacktype whichAttack, damagetype whichDamage);
		/// @CSharpLua.Template = "CreateDestructableLoc({0}, {1}, {2}, {3}, {4})"
		public static extern destructable CreateDestructableLoc(int objectid, location loc, float facing, float scale, int variation);
		/// @CSharpLua.Template = "CreateDeadDestructableLocBJ({0}, {1}, {2}, {3}, {4})"
		public static extern destructable CreateDeadDestructableLocBJ(int objectid, location loc, float facing, float scale, int variation);
		/// @CSharpLua.Template = "GetLastCreatedDestructable()"
		public static extern destructable GetLastCreatedDestructable();
		/// @CSharpLua.Template = "ShowDestructableBJ({0}, {1})"
		public static extern void ShowDestructableBJ(bool flag, destructable d);
		/// @CSharpLua.Template = "SetDestructableInvulnerableBJ({0}, {1})"
		public static extern void SetDestructableInvulnerableBJ(destructable d, bool flag);
		/// @CSharpLua.Template = "IsDestructableInvulnerableBJ({0})"
		public static extern bool IsDestructableInvulnerableBJ(destructable d);
		/// @CSharpLua.Template = "GetDestructableLoc({0})"
		public static extern location GetDestructableLoc(destructable whichDestructable);
		/// @CSharpLua.Template = "EnumDestructablesInRectAll({0}, {1})"
		public static extern void EnumDestructablesInRectAll(rect r, System.Action actionFunc);
		/// @CSharpLua.Template = "EnumDestructablesInCircleBJFilter()"
		public static extern bool EnumDestructablesInCircleBJFilter();
		/// @CSharpLua.Template = "IsDestructableDeadBJ({0})"
		public static extern bool IsDestructableDeadBJ(destructable d);
		/// @CSharpLua.Template = "IsDestructableAliveBJ({0})"
		public static extern bool IsDestructableAliveBJ(destructable d);
		/// @CSharpLua.Template = "RandomDestructableInRectBJEnum()"
		public static extern void RandomDestructableInRectBJEnum();
		/// @CSharpLua.Template = "RandomDestructableInRectBJ({0}, {1})"
		public static extern destructable RandomDestructableInRectBJ(rect r, boolexpr filter);
		/// @CSharpLua.Template = "RandomDestructableInRectSimpleBJ({0})"
		public static extern destructable RandomDestructableInRectSimpleBJ(rect r);
		/// @CSharpLua.Template = "EnumDestructablesInCircleBJ({0}, {1}, {2})"
		public static extern void EnumDestructablesInCircleBJ(float radius, location loc, System.Action actionFunc);
		/// @CSharpLua.Template = "SetDestructableLifePercentBJ({0}, {1})"
		public static extern void SetDestructableLifePercentBJ(destructable d, float percent);
		/// @CSharpLua.Template = "SetDestructableMaxLifeBJ({0}, {1})"
		public static extern void SetDestructableMaxLifeBJ(destructable d, float max);
		/// @CSharpLua.Template = "ModifyGateBJ({0}, {1})"
		public static extern void ModifyGateBJ(int gateOperation, destructable d);
		/// @CSharpLua.Template = "GetElevatorHeight({0})"
		public static extern int GetElevatorHeight(destructable d);
		/// @CSharpLua.Template = "ChangeElevatorHeight({0}, {1})"
		public static extern void ChangeElevatorHeight(destructable d, int newHeight);
		/// @CSharpLua.Template = "NudgeUnitsInRectEnum()"
		public static extern void NudgeUnitsInRectEnum();
		/// @CSharpLua.Template = "NudgeItemsInRectEnum()"
		public static extern void NudgeItemsInRectEnum();
		/// @CSharpLua.Template = "NudgeObjectsInRect({0})"
		public static extern void NudgeObjectsInRect(rect nudgeArea);
		/// @CSharpLua.Template = "NearbyElevatorExistsEnum()"
		public static extern void NearbyElevatorExistsEnum();
		/// @CSharpLua.Template = "NearbyElevatorExists({0}, {1})"
		public static extern bool NearbyElevatorExists(float x, float y);
		/// @CSharpLua.Template = "FindElevatorWallBlockerEnum()"
		public static extern void FindElevatorWallBlockerEnum();
		/// @CSharpLua.Template = "ChangeElevatorWallBlocker({0}, {1}, {2}, {3})"
		public static extern void ChangeElevatorWallBlocker(float x, float y, float facing, bool open);
		/// @CSharpLua.Template = "ChangeElevatorWalls({0}, {1}, {2})"
		public static extern void ChangeElevatorWalls(bool open, int walls, destructable d);
		/// @CSharpLua.Template = "WaygateActivateBJ({0}, {1})"
		public static extern void WaygateActivateBJ(bool activate, unit waygate);
		/// @CSharpLua.Template = "WaygateIsActiveBJ({0})"
		public static extern bool WaygateIsActiveBJ(unit waygate);
		/// @CSharpLua.Template = "WaygateSetDestinationLocBJ({0}, {1})"
		public static extern void WaygateSetDestinationLocBJ(unit waygate, location loc);
		/// @CSharpLua.Template = "WaygateGetDestinationLocBJ({0})"
		public static extern location WaygateGetDestinationLocBJ(unit waygate);
		/// @CSharpLua.Template = "UnitSetUsesAltIconBJ({0}, {1})"
		public static extern void UnitSetUsesAltIconBJ(bool flag, unit whichUnit);
		/// @CSharpLua.Template = "ForceUIKeyBJ({0}, {1})"
		public static extern void ForceUIKeyBJ(player whichPlayer, string key);
		/// @CSharpLua.Template = "ForceUICancelBJ({0})"
		public static extern void ForceUICancelBJ(player whichPlayer);
		/// @CSharpLua.Template = "ForGroupBJ({0}, {1})"
		public static extern void ForGroupBJ(group whichGroup, System.Action callback);
		/// @CSharpLua.Template = "GroupAddUnitSimple({0}, {1})"
		public static extern void GroupAddUnitSimple(unit whichUnit, group whichGroup);
		/// @CSharpLua.Template = "GroupRemoveUnitSimple({0}, {1})"
		public static extern void GroupRemoveUnitSimple(unit whichUnit, group whichGroup);
		/// @CSharpLua.Template = "GroupAddGroupEnum()"
		public static extern void GroupAddGroupEnum();
		/// @CSharpLua.Template = "GroupAddGroup({0}, {1})"
		public static extern void GroupAddGroup(group sourceGroup, group destGroup);
		/// @CSharpLua.Template = "GroupRemoveGroupEnum()"
		public static extern void GroupRemoveGroupEnum();
		/// @CSharpLua.Template = "GroupRemoveGroup({0}, {1})"
		public static extern void GroupRemoveGroup(group sourceGroup, group destGroup);
		/// @CSharpLua.Template = "ForceAddPlayerSimple({0}, {1})"
		public static extern void ForceAddPlayerSimple(player whichPlayer, force whichForce);
		/// @CSharpLua.Template = "ForceRemovePlayerSimple({0}, {1})"
		public static extern void ForceRemovePlayerSimple(player whichPlayer, force whichForce);
		/// @CSharpLua.Template = "GroupPickRandomUnitEnum()"
		public static extern void GroupPickRandomUnitEnum();
		/// @CSharpLua.Template = "GroupPickRandomUnit({0})"
		public static extern unit GroupPickRandomUnit(group whichGroup);
		/// @CSharpLua.Template = "ForcePickRandomPlayerEnum()"
		public static extern void ForcePickRandomPlayerEnum();
		/// @CSharpLua.Template = "ForcePickRandomPlayer({0})"
		public static extern player ForcePickRandomPlayer(force whichForce);
		/// @CSharpLua.Template = "EnumUnitsSelected({0}, {1}, {2})"
		public static extern void EnumUnitsSelected(player whichPlayer, boolexpr enumFilter, System.Action enumAction);
		/// @CSharpLua.Template = "GetUnitsInRectMatching({0}, {1})"
		public static extern group GetUnitsInRectMatching(rect r, boolexpr filter);
		/// @CSharpLua.Template = "GetUnitsInRectAll({0})"
		public static extern group GetUnitsInRectAll(rect r);
		/// @CSharpLua.Template = "GetUnitsInRectOfPlayerFilter()"
		public static extern bool GetUnitsInRectOfPlayerFilter();
		/// @CSharpLua.Template = "GetUnitsInRectOfPlayer({0}, {1})"
		public static extern group GetUnitsInRectOfPlayer(rect r, player whichPlayer);
		/// @CSharpLua.Template = "GetUnitsInRangeOfLocMatching({0}, {1}, {2})"
		public static extern group GetUnitsInRangeOfLocMatching(float radius, location whichLocation, boolexpr filter);
		/// @CSharpLua.Template = "GetUnitsInRangeOfLocAll({0}, {1})"
		public static extern group GetUnitsInRangeOfLocAll(float radius, location whichLocation);
		/// @CSharpLua.Template = "GetUnitsOfTypeIdAllFilter()"
		public static extern bool GetUnitsOfTypeIdAllFilter();
		/// @CSharpLua.Template = "GetUnitsOfTypeIdAll({0})"
		public static extern group GetUnitsOfTypeIdAll(int unitid);
		/// @CSharpLua.Template = "GetUnitsOfPlayerMatching({0}, {1})"
		public static extern group GetUnitsOfPlayerMatching(player whichPlayer, boolexpr filter);
		/// @CSharpLua.Template = "GetUnitsOfPlayerAll({0})"
		public static extern group GetUnitsOfPlayerAll(player whichPlayer);
		/// @CSharpLua.Template = "GetUnitsOfPlayerAndTypeIdFilter()"
		public static extern bool GetUnitsOfPlayerAndTypeIdFilter();
		/// @CSharpLua.Template = "GetUnitsOfPlayerAndTypeId({0}, {1})"
		public static extern group GetUnitsOfPlayerAndTypeId(player whichPlayer, int unitid);
		/// @CSharpLua.Template = "GetUnitsSelectedAll({0})"
		public static extern group GetUnitsSelectedAll(player whichPlayer);
		/// @CSharpLua.Template = "GetForceOfPlayer({0})"
		public static extern force GetForceOfPlayer(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayersAll()"
		public static extern force GetPlayersAll();
		/// @CSharpLua.Template = "GetPlayersByMapControl({0})"
		public static extern force GetPlayersByMapControl(mapcontrol whichControl);
		/// @CSharpLua.Template = "GetPlayersAllies({0})"
		public static extern force GetPlayersAllies(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayersEnemies({0})"
		public static extern force GetPlayersEnemies(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayersMatching({0})"
		public static extern force GetPlayersMatching(boolexpr filter);
		/// @CSharpLua.Template = "CountUnitsInGroupEnum()"
		public static extern void CountUnitsInGroupEnum();
		/// @CSharpLua.Template = "CountUnitsInGroup({0})"
		public static extern int CountUnitsInGroup(group g);
		/// @CSharpLua.Template = "CountPlayersInForceEnum()"
		public static extern void CountPlayersInForceEnum();
		/// @CSharpLua.Template = "CountPlayersInForceBJ({0})"
		public static extern int CountPlayersInForceBJ(force f);
		/// @CSharpLua.Template = "GetRandomSubGroupEnum()"
		public static extern void GetRandomSubGroupEnum();
		/// @CSharpLua.Template = "GetRandomSubGroup({0}, {1})"
		public static extern group GetRandomSubGroup(int count, group sourceGroup);
		/// @CSharpLua.Template = "LivingPlayerUnitsOfTypeIdFilter()"
		public static extern bool LivingPlayerUnitsOfTypeIdFilter();
		/// @CSharpLua.Template = "CountLivingPlayerUnitsOfTypeId({0}, {1})"
		public static extern int CountLivingPlayerUnitsOfTypeId(int unitId, player whichPlayer);
		/// @CSharpLua.Template = "ResetUnitAnimation({0})"
		public static extern void ResetUnitAnimation(unit whichUnit);
		/// @CSharpLua.Template = "SetUnitTimeScalePercent({0}, {1})"
		public static extern void SetUnitTimeScalePercent(unit whichUnit, float percentScale);
		/// @CSharpLua.Template = "SetUnitScalePercent({0}, {1}, {2}, {3})"
		public static extern void SetUnitScalePercent(unit whichUnit, float percentScaleX, float percentScaleY, float percentScaleZ);
		/// @CSharpLua.Template = "SetUnitVertexColorBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void SetUnitVertexColorBJ(unit whichUnit, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "UnitAddIndicatorBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void UnitAddIndicatorBJ(unit whichUnit, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "DestructableAddIndicatorBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void DestructableAddIndicatorBJ(destructable whichDestructable, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "ItemAddIndicatorBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void ItemAddIndicatorBJ(item whichItem, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "SetUnitFacingToFaceLocTimed({0}, {1}, {2})"
		public static extern void SetUnitFacingToFaceLocTimed(unit whichUnit, location target, float duration);
		/// @CSharpLua.Template = "SetUnitFacingToFaceUnitTimed({0}, {1}, {2})"
		public static extern void SetUnitFacingToFaceUnitTimed(unit whichUnit, unit target, float duration);
		/// @CSharpLua.Template = "QueueUnitAnimationBJ({0}, {1})"
		public static extern void QueueUnitAnimationBJ(unit whichUnit, string whichAnimation);
		/// @CSharpLua.Template = "SetDestructableAnimationBJ({0}, {1})"
		public static extern void SetDestructableAnimationBJ(destructable d, string whichAnimation);
		/// @CSharpLua.Template = "QueueDestructableAnimationBJ({0}, {1})"
		public static extern void QueueDestructableAnimationBJ(destructable d, string whichAnimation);
		/// @CSharpLua.Template = "SetDestAnimationSpeedPercent({0}, {1})"
		public static extern void SetDestAnimationSpeedPercent(destructable d, float percentScale);
		/// @CSharpLua.Template = "DialogDisplayBJ({0}, {1}, {2})"
		public static extern void DialogDisplayBJ(bool flag, dialog whichDialog, player whichPlayer);
		/// @CSharpLua.Template = "DialogSetMessageBJ({0}, {1})"
		public static extern void DialogSetMessageBJ(dialog whichDialog, string message);
		/// @CSharpLua.Template = "DialogAddButtonBJ({0}, {1})"
		public static extern button DialogAddButtonBJ(dialog whichDialog, string buttonText);
		/// @CSharpLua.Template = "DialogAddButtonWithHotkeyBJ({0}, {1}, {2})"
		public static extern button DialogAddButtonWithHotkeyBJ(dialog whichDialog, string buttonText, int hotkey);
		/// @CSharpLua.Template = "DialogClearBJ({0})"
		public static extern void DialogClearBJ(dialog whichDialog);
		/// @CSharpLua.Template = "GetLastCreatedButtonBJ()"
		public static extern button GetLastCreatedButtonBJ();
		/// @CSharpLua.Template = "GetClickedButtonBJ()"
		public static extern button GetClickedButtonBJ();
		/// @CSharpLua.Template = "GetClickedDialogBJ()"
		public static extern dialog GetClickedDialogBJ();
		/// @CSharpLua.Template = "SetPlayerAllianceBJ({0}, {1}, {2}, {3})"
		public static extern void SetPlayerAllianceBJ(player sourcePlayer, alliancetype whichAllianceSetting, bool value, player otherPlayer);
		/// @CSharpLua.Template = "SetPlayerAllianceStateAllyBJ({0}, {1}, {2})"
		public static extern void SetPlayerAllianceStateAllyBJ(player sourcePlayer, player otherPlayer, bool flag);
		/// @CSharpLua.Template = "SetPlayerAllianceStateVisionBJ({0}, {1}, {2})"
		public static extern void SetPlayerAllianceStateVisionBJ(player sourcePlayer, player otherPlayer, bool flag);
		/// @CSharpLua.Template = "SetPlayerAllianceStateControlBJ({0}, {1}, {2})"
		public static extern void SetPlayerAllianceStateControlBJ(player sourcePlayer, player otherPlayer, bool flag);
		/// @CSharpLua.Template = "SetPlayerAllianceStateFullControlBJ({0}, {1}, {2})"
		public static extern void SetPlayerAllianceStateFullControlBJ(player sourcePlayer, player otherPlayer, bool flag);
		/// @CSharpLua.Template = "SetPlayerAllianceStateBJ({0}, {1}, {2})"
		public static extern void SetPlayerAllianceStateBJ(player sourcePlayer, player otherPlayer, int allianceState);
		/// @CSharpLua.Template = "SetForceAllianceStateBJ({0}, {1}, {2})"
		public static extern void SetForceAllianceStateBJ(force sourceForce, force targetForce, int allianceState);
		/// @CSharpLua.Template = "PlayersAreCoAllied({0}, {1})"
		public static extern bool PlayersAreCoAllied(player playerA, player playerB);
		/// @CSharpLua.Template = "ShareEverythingWithTeamAI({0})"
		public static extern void ShareEverythingWithTeamAI(player whichPlayer);
		/// @CSharpLua.Template = "ShareEverythingWithTeam({0})"
		public static extern void ShareEverythingWithTeam(player whichPlayer);
		/// @CSharpLua.Template = "ConfigureNeutralVictim()"
		public static extern void ConfigureNeutralVictim();
		/// @CSharpLua.Template = "MakeUnitsPassiveForPlayerEnum()"
		public static extern void MakeUnitsPassiveForPlayerEnum();
		/// @CSharpLua.Template = "MakeUnitsPassiveForPlayer({0})"
		public static extern void MakeUnitsPassiveForPlayer(player whichPlayer);
		/// @CSharpLua.Template = "MakeUnitsPassiveForTeam({0})"
		public static extern void MakeUnitsPassiveForTeam(player whichPlayer);
		/// @CSharpLua.Template = "AllowVictoryDefeat({0})"
		public static extern bool AllowVictoryDefeat(playergameresult gameResult);
		/// @CSharpLua.Template = "EndGameBJ()"
		public static extern void EndGameBJ();
		/// @CSharpLua.Template = "MeleeVictoryDialogBJ({0}, {1})"
		public static extern void MeleeVictoryDialogBJ(player whichPlayer, bool leftGame);
		/// @CSharpLua.Template = "MeleeDefeatDialogBJ({0}, {1})"
		public static extern void MeleeDefeatDialogBJ(player whichPlayer, bool leftGame);
		/// @CSharpLua.Template = "GameOverDialogBJ({0}, {1})"
		public static extern void GameOverDialogBJ(player whichPlayer, bool leftGame);
		/// @CSharpLua.Template = "RemovePlayerPreserveUnitsBJ({0}, {1}, {2})"
		public static extern void RemovePlayerPreserveUnitsBJ(player whichPlayer, playergameresult gameResult, bool leftGame);
		/// @CSharpLua.Template = "CustomVictoryOkBJ()"
		public static extern void CustomVictoryOkBJ();
		/// @CSharpLua.Template = "CustomVictoryQuitBJ()"
		public static extern void CustomVictoryQuitBJ();
		/// @CSharpLua.Template = "CustomVictoryDialogBJ({0})"
		public static extern void CustomVictoryDialogBJ(player whichPlayer);
		/// @CSharpLua.Template = "CustomVictorySkipBJ({0})"
		public static extern void CustomVictorySkipBJ(player whichPlayer);
		/// @CSharpLua.Template = "CustomVictoryBJ({0}, {1}, {2})"
		public static extern void CustomVictoryBJ(player whichPlayer, bool showDialog, bool showScores);
		/// @CSharpLua.Template = "CustomDefeatRestartBJ()"
		public static extern void CustomDefeatRestartBJ();
		/// @CSharpLua.Template = "CustomDefeatReduceDifficultyBJ()"
		public static extern void CustomDefeatReduceDifficultyBJ();
		/// @CSharpLua.Template = "CustomDefeatLoadBJ()"
		public static extern void CustomDefeatLoadBJ();
		/// @CSharpLua.Template = "CustomDefeatQuitBJ()"
		public static extern void CustomDefeatQuitBJ();
		/// @CSharpLua.Template = "CustomDefeatDialogBJ({0}, {1})"
		public static extern void CustomDefeatDialogBJ(player whichPlayer, string message);
		/// @CSharpLua.Template = "CustomDefeatBJ({0}, {1})"
		public static extern void CustomDefeatBJ(player whichPlayer, string message);
		/// @CSharpLua.Template = "SetNextLevelBJ({0})"
		public static extern void SetNextLevelBJ(string nextLevel);
		/// @CSharpLua.Template = "SetPlayerOnScoreScreenBJ({0}, {1})"
		public static extern void SetPlayerOnScoreScreenBJ(bool flag, player whichPlayer);
		/// @CSharpLua.Template = "CreateQuestBJ({0}, {1}, {2}, {3})"
		public static extern quest CreateQuestBJ(int questType, string title, string description, string iconPath);
		/// @CSharpLua.Template = "DestroyQuestBJ({0})"
		public static extern void DestroyQuestBJ(quest whichQuest);
		/// @CSharpLua.Template = "QuestSetEnabledBJ({0}, {1})"
		public static extern void QuestSetEnabledBJ(bool enabled, quest whichQuest);
		/// @CSharpLua.Template = "QuestSetTitleBJ({0}, {1})"
		public static extern void QuestSetTitleBJ(quest whichQuest, string title);
		/// @CSharpLua.Template = "QuestSetDescriptionBJ({0}, {1})"
		public static extern void QuestSetDescriptionBJ(quest whichQuest, string description);
		/// @CSharpLua.Template = "QuestSetCompletedBJ({0}, {1})"
		public static extern void QuestSetCompletedBJ(quest whichQuest, bool completed);
		/// @CSharpLua.Template = "QuestSetFailedBJ({0}, {1})"
		public static extern void QuestSetFailedBJ(quest whichQuest, bool failed);
		/// @CSharpLua.Template = "QuestSetDiscoveredBJ({0}, {1})"
		public static extern void QuestSetDiscoveredBJ(quest whichQuest, bool discovered);
		/// @CSharpLua.Template = "GetLastCreatedQuestBJ()"
		public static extern quest GetLastCreatedQuestBJ();
		/// @CSharpLua.Template = "CreateQuestItemBJ({0}, {1})"
		public static extern questitem CreateQuestItemBJ(quest whichQuest, string description);
		/// @CSharpLua.Template = "QuestItemSetDescriptionBJ({0}, {1})"
		public static extern void QuestItemSetDescriptionBJ(questitem whichQuestItem, string description);
		/// @CSharpLua.Template = "QuestItemSetCompletedBJ({0}, {1})"
		public static extern void QuestItemSetCompletedBJ(questitem whichQuestItem, bool completed);
		/// @CSharpLua.Template = "GetLastCreatedQuestItemBJ()"
		public static extern questitem GetLastCreatedQuestItemBJ();
		/// @CSharpLua.Template = "CreateDefeatConditionBJ({0})"
		public static extern defeatcondition CreateDefeatConditionBJ(string description);
		/// @CSharpLua.Template = "DestroyDefeatConditionBJ({0})"
		public static extern void DestroyDefeatConditionBJ(defeatcondition whichCondition);
		/// @CSharpLua.Template = "DefeatConditionSetDescriptionBJ({0}, {1})"
		public static extern void DefeatConditionSetDescriptionBJ(defeatcondition whichCondition, string description);
		/// @CSharpLua.Template = "GetLastCreatedDefeatConditionBJ()"
		public static extern defeatcondition GetLastCreatedDefeatConditionBJ();
		/// @CSharpLua.Template = "FlashQuestDialogButtonBJ()"
		public static extern void FlashQuestDialogButtonBJ();
		/// @CSharpLua.Template = "QuestMessageBJ({0}, {1}, {2})"
		public static extern void QuestMessageBJ(force f, int messageType, string message);
		/// @CSharpLua.Template = "StartTimerBJ({0}, {1}, {2})"
		public static extern timer StartTimerBJ(timer t, bool periodic, float timeout);
		/// @CSharpLua.Template = "CreateTimerBJ({0}, {1})"
		public static extern timer CreateTimerBJ(bool periodic, float timeout);
		/// @CSharpLua.Template = "DestroyTimerBJ({0})"
		public static extern void DestroyTimerBJ(timer whichTimer);
		/// @CSharpLua.Template = "PauseTimerBJ({0}, {1})"
		public static extern void PauseTimerBJ(bool pause, timer whichTimer);
		/// @CSharpLua.Template = "GetLastCreatedTimerBJ()"
		public static extern timer GetLastCreatedTimerBJ();
		/// @CSharpLua.Template = "CreateTimerDialogBJ({0}, {1})"
		public static extern timerdialog CreateTimerDialogBJ(timer t, string title);
		/// @CSharpLua.Template = "DestroyTimerDialogBJ({0})"
		public static extern void DestroyTimerDialogBJ(timerdialog td);
		/// @CSharpLua.Template = "TimerDialogSetTitleBJ({0}, {1})"
		public static extern void TimerDialogSetTitleBJ(timerdialog td, string title);
		/// @CSharpLua.Template = "TimerDialogSetTitleColorBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void TimerDialogSetTitleColorBJ(timerdialog td, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "TimerDialogSetTimeColorBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void TimerDialogSetTimeColorBJ(timerdialog td, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "TimerDialogSetSpeedBJ({0}, {1})"
		public static extern void TimerDialogSetSpeedBJ(timerdialog td, float speedMultFactor);
		/// @CSharpLua.Template = "TimerDialogDisplayForPlayerBJ({0}, {1}, {2})"
		public static extern void TimerDialogDisplayForPlayerBJ(bool show, timerdialog td, player whichPlayer);
		/// @CSharpLua.Template = "TimerDialogDisplayBJ({0}, {1})"
		public static extern void TimerDialogDisplayBJ(bool show, timerdialog td);
		/// @CSharpLua.Template = "GetLastCreatedTimerDialogBJ()"
		public static extern timerdialog GetLastCreatedTimerDialogBJ();
		/// @CSharpLua.Template = "LeaderboardResizeBJ({0})"
		public static extern void LeaderboardResizeBJ(leaderboard lb);
		/// @CSharpLua.Template = "LeaderboardSetPlayerItemValueBJ({0}, {1}, {2})"
		public static extern void LeaderboardSetPlayerItemValueBJ(player whichPlayer, leaderboard lb, int val);
		/// @CSharpLua.Template = "LeaderboardSetPlayerItemLabelBJ({0}, {1}, {2})"
		public static extern void LeaderboardSetPlayerItemLabelBJ(player whichPlayer, leaderboard lb, string val);
		/// @CSharpLua.Template = "LeaderboardSetPlayerItemStyleBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void LeaderboardSetPlayerItemStyleBJ(player whichPlayer, leaderboard lb, bool showLabel, bool showValue, bool showIcon);
		/// @CSharpLua.Template = "LeaderboardSetPlayerItemLabelColorBJ({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern void LeaderboardSetPlayerItemLabelColorBJ(player whichPlayer, leaderboard lb, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "LeaderboardSetPlayerItemValueColorBJ({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern void LeaderboardSetPlayerItemValueColorBJ(player whichPlayer, leaderboard lb, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "LeaderboardSetLabelColorBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void LeaderboardSetLabelColorBJ(leaderboard lb, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "LeaderboardSetValueColorBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void LeaderboardSetValueColorBJ(leaderboard lb, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "LeaderboardSetLabelBJ({0}, {1})"
		public static extern void LeaderboardSetLabelBJ(leaderboard lb, string label);
		/// @CSharpLua.Template = "LeaderboardSetStyleBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void LeaderboardSetStyleBJ(leaderboard lb, bool showLabel, bool showNames, bool showValues, bool showIcons);
		/// @CSharpLua.Template = "LeaderboardGetItemCountBJ({0})"
		public static extern int LeaderboardGetItemCountBJ(leaderboard lb);
		/// @CSharpLua.Template = "LeaderboardHasPlayerItemBJ({0}, {1})"
		public static extern bool LeaderboardHasPlayerItemBJ(leaderboard lb, player whichPlayer);
		/// @CSharpLua.Template = "ForceSetLeaderboardBJ({0}, {1})"
		public static extern void ForceSetLeaderboardBJ(leaderboard lb, force toForce);
		/// @CSharpLua.Template = "CreateLeaderboardBJ({0}, {1})"
		public static extern leaderboard CreateLeaderboardBJ(force toForce, string label);
		/// @CSharpLua.Template = "DestroyLeaderboardBJ({0})"
		public static extern void DestroyLeaderboardBJ(leaderboard lb);
		/// @CSharpLua.Template = "LeaderboardDisplayBJ({0}, {1})"
		public static extern void LeaderboardDisplayBJ(bool show, leaderboard lb);
		/// @CSharpLua.Template = "LeaderboardAddItemBJ({0}, {1}, {2}, {3})"
		public static extern void LeaderboardAddItemBJ(player whichPlayer, leaderboard lb, string label, int value);
		/// @CSharpLua.Template = "LeaderboardRemovePlayerItemBJ({0}, {1})"
		public static extern void LeaderboardRemovePlayerItemBJ(player whichPlayer, leaderboard lb);
		/// @CSharpLua.Template = "LeaderboardSortItemsBJ({0}, {1}, {2})"
		public static extern void LeaderboardSortItemsBJ(leaderboard lb, int sortType, bool ascending);
		/// @CSharpLua.Template = "LeaderboardSortItemsByPlayerBJ({0}, {1})"
		public static extern void LeaderboardSortItemsByPlayerBJ(leaderboard lb, bool ascending);
		/// @CSharpLua.Template = "LeaderboardSortItemsByLabelBJ({0}, {1})"
		public static extern void LeaderboardSortItemsByLabelBJ(leaderboard lb, bool ascending);
		/// @CSharpLua.Template = "LeaderboardGetPlayerIndexBJ({0}, {1})"
		public static extern int LeaderboardGetPlayerIndexBJ(player whichPlayer, leaderboard lb);
		/// @CSharpLua.Template = "LeaderboardGetIndexedPlayerBJ({0}, {1})"
		public static extern player LeaderboardGetIndexedPlayerBJ(int position, leaderboard lb);
		/// @CSharpLua.Template = "PlayerGetLeaderboardBJ({0})"
		public static extern leaderboard PlayerGetLeaderboardBJ(player whichPlayer);
		/// @CSharpLua.Template = "GetLastCreatedLeaderboard()"
		public static extern leaderboard GetLastCreatedLeaderboard();
		/// @CSharpLua.Template = "CreateMultiboardBJ({0}, {1}, {2})"
		public static extern multiboard CreateMultiboardBJ(int cols, int rows, string title);
		/// @CSharpLua.Template = "DestroyMultiboardBJ({0})"
		public static extern void DestroyMultiboardBJ(multiboard mb);
		/// @CSharpLua.Template = "GetLastCreatedMultiboard()"
		public static extern multiboard GetLastCreatedMultiboard();
		/// @CSharpLua.Template = "MultiboardDisplayBJ({0}, {1})"
		public static extern void MultiboardDisplayBJ(bool show, multiboard mb);
		/// @CSharpLua.Template = "MultiboardMinimizeBJ({0}, {1})"
		public static extern void MultiboardMinimizeBJ(bool minimize, multiboard mb);
		/// @CSharpLua.Template = "MultiboardSetTitleTextColorBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void MultiboardSetTitleTextColorBJ(multiboard mb, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "MultiboardAllowDisplayBJ({0})"
		public static extern void MultiboardAllowDisplayBJ(bool flag);
		/// @CSharpLua.Template = "MultiboardSetItemStyleBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void MultiboardSetItemStyleBJ(multiboard mb, int col, int row, bool showValue, bool showIcon);
		/// @CSharpLua.Template = "MultiboardSetItemValueBJ({0}, {1}, {2}, {3})"
		public static extern void MultiboardSetItemValueBJ(multiboard mb, int col, int row, string val);
		/// @CSharpLua.Template = "MultiboardSetItemColorBJ({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern void MultiboardSetItemColorBJ(multiboard mb, int col, int row, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "MultiboardSetItemWidthBJ({0}, {1}, {2}, {3})"
		public static extern void MultiboardSetItemWidthBJ(multiboard mb, int col, int row, float width);
		/// @CSharpLua.Template = "MultiboardSetItemIconBJ({0}, {1}, {2}, {3})"
		public static extern void MultiboardSetItemIconBJ(multiboard mb, int col, int row, string iconFileName);
		/// @CSharpLua.Template = "TextTagSize2Height({0})"
		public static extern float TextTagSize2Height(float size);
		/// @CSharpLua.Template = "TextTagSpeed2Velocity({0})"
		public static extern float TextTagSpeed2Velocity(float speed);
		/// @CSharpLua.Template = "SetTextTagColorBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void SetTextTagColorBJ(texttag tt, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "SetTextTagVelocityBJ({0}, {1}, {2})"
		public static extern void SetTextTagVelocityBJ(texttag tt, float speed, float angle);
		/// @CSharpLua.Template = "SetTextTagTextBJ({0}, {1}, {2})"
		public static extern void SetTextTagTextBJ(texttag tt, string s, float size);
		/// @CSharpLua.Template = "SetTextTagPosBJ({0}, {1}, {2})"
		public static extern void SetTextTagPosBJ(texttag tt, location loc, float zOffset);
		/// @CSharpLua.Template = "SetTextTagPosUnitBJ({0}, {1}, {2})"
		public static extern void SetTextTagPosUnitBJ(texttag tt, unit whichUnit, float zOffset);
		/// @CSharpLua.Template = "SetTextTagSuspendedBJ({0}, {1})"
		public static extern void SetTextTagSuspendedBJ(texttag tt, bool flag);
		/// @CSharpLua.Template = "SetTextTagPermanentBJ({0}, {1})"
		public static extern void SetTextTagPermanentBJ(texttag tt, bool flag);
		/// @CSharpLua.Template = "SetTextTagAgeBJ({0}, {1})"
		public static extern void SetTextTagAgeBJ(texttag tt, float age);
		/// @CSharpLua.Template = "SetTextTagLifespanBJ({0}, {1})"
		public static extern void SetTextTagLifespanBJ(texttag tt, float lifespan);
		/// @CSharpLua.Template = "SetTextTagFadepointBJ({0}, {1})"
		public static extern void SetTextTagFadepointBJ(texttag tt, float fadepoint);
		/// @CSharpLua.Template = "CreateTextTagLocBJ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern texttag CreateTextTagLocBJ(string s, location loc, float zOffset, float size, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "CreateTextTagUnitBJ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern texttag CreateTextTagUnitBJ(string s, unit whichUnit, float zOffset, float size, float red, float green, float blue, float transparency);
		/// @CSharpLua.Template = "DestroyTextTagBJ({0})"
		public static extern void DestroyTextTagBJ(texttag tt);
		/// @CSharpLua.Template = "ShowTextTagForceBJ({0}, {1}, {2})"
		public static extern void ShowTextTagForceBJ(bool show, texttag tt, force whichForce);
		/// @CSharpLua.Template = "GetLastCreatedTextTag()"
		public static extern texttag GetLastCreatedTextTag();
		/// @CSharpLua.Template = "PauseGameOn()"
		public static extern void PauseGameOn();
		/// @CSharpLua.Template = "PauseGameOff()"
		public static extern void PauseGameOff();
		/// @CSharpLua.Template = "SetUserControlForceOn({0})"
		public static extern void SetUserControlForceOn(force whichForce);
		/// @CSharpLua.Template = "SetUserControlForceOff({0})"
		public static extern void SetUserControlForceOff(force whichForce);
		/// @CSharpLua.Template = "ShowInterfaceForceOn({0}, {1})"
		public static extern void ShowInterfaceForceOn(force whichForce, float fadeDuration);
		/// @CSharpLua.Template = "ShowInterfaceForceOff({0}, {1})"
		public static extern void ShowInterfaceForceOff(force whichForce, float fadeDuration);
		/// @CSharpLua.Template = "PingMinimapForForce({0}, {1}, {2}, {3})"
		public static extern void PingMinimapForForce(force whichForce, float x, float y, float duration);
		/// @CSharpLua.Template = "PingMinimapLocForForce({0}, {1}, {2})"
		public static extern void PingMinimapLocForForce(force whichForce, location loc, float duration);
		/// @CSharpLua.Template = "PingMinimapForPlayer({0}, {1}, {2}, {3})"
		public static extern void PingMinimapForPlayer(player whichPlayer, float x, float y, float duration);
		/// @CSharpLua.Template = "PingMinimapLocForPlayer({0}, {1}, {2})"
		public static extern void PingMinimapLocForPlayer(player whichPlayer, location loc, float duration);
		/// @CSharpLua.Template = "PingMinimapForForceEx({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern void PingMinimapForForceEx(force whichForce, float x, float y, float duration, int style, float red, float green, float blue);
		/// @CSharpLua.Template = "PingMinimapLocForForceEx({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern void PingMinimapLocForForceEx(force whichForce, location loc, float duration, int style, float red, float green, float blue);
		/// @CSharpLua.Template = "EnableWorldFogBoundaryBJ({0}, {1})"
		public static extern void EnableWorldFogBoundaryBJ(bool enable, force f);
		/// @CSharpLua.Template = "EnableOcclusionBJ({0}, {1})"
		public static extern void EnableOcclusionBJ(bool enable, force f);
		/// @CSharpLua.Template = "CancelCineSceneBJ()"
		public static extern void CancelCineSceneBJ();
		/// @CSharpLua.Template = "TryInitCinematicBehaviorBJ()"
		public static extern void TryInitCinematicBehaviorBJ();
		/// @CSharpLua.Template = "SetCinematicSceneBJ({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern void SetCinematicSceneBJ(sound soundHandle, int portraitUnitId, playercolor color, string speakerTitle, string text, float sceneDuration, float voiceoverDuration);
		/// @CSharpLua.Template = "GetTransmissionDuration({0}, {1}, {2})"
		public static extern float GetTransmissionDuration(sound soundHandle, int timeType, float timeVal);
		/// @CSharpLua.Template = "WaitTransmissionDuration({0}, {1}, {2})"
		public static extern void WaitTransmissionDuration(sound soundHandle, int timeType, float timeVal);
		/// @CSharpLua.Template = "DoTransmissionBasicsXYBJ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern void DoTransmissionBasicsXYBJ(int unitId, playercolor color, float x, float y, sound soundHandle, string unitName, string message, float duration);
		/// @CSharpLua.Template = "TransmissionFromUnitWithNameBJ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern void TransmissionFromUnitWithNameBJ(force toForce, unit whichUnit, string unitName, sound soundHandle, string message, int timeType, float timeVal, bool wait);
		/// @CSharpLua.Template = "PlayDialogueFromSpeakerEx({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern bool PlayDialogueFromSpeakerEx(force toForce, unit speaker, int speakerType, sound soundHandle, int timeType, float timeVal, bool wait);
		/// @CSharpLua.Template = "PlayDialogueFromSpeakerTypeEx({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public static extern bool PlayDialogueFromSpeakerTypeEx(force toForce, player fromPlayer, int speakerType, location loc, sound soundHandle, int timeType, float timeVal, bool wait);
		/// @CSharpLua.Template = "TransmissionFromUnitTypeWithNameBJ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})"
		public static extern void TransmissionFromUnitTypeWithNameBJ(force toForce, player fromPlayer, int unitId, string unitName, location loc, sound soundHandle, string message, int timeType, float timeVal, bool wait);
		/// @CSharpLua.Template = "GetLastTransmissionDurationBJ()"
		public static extern float GetLastTransmissionDurationBJ();
		/// @CSharpLua.Template = "ForceCinematicSubtitlesBJ({0})"
		public static extern void ForceCinematicSubtitlesBJ(bool flag);
		/// @CSharpLua.Template = "CinematicModeExBJ({0}, {1}, {2})"
		public static extern void CinematicModeExBJ(bool cineMode, force forForce, float interfaceFadeTime);
		/// @CSharpLua.Template = "CinematicModeBJ({0}, {1})"
		public static extern void CinematicModeBJ(bool cineMode, force forForce);
		/// @CSharpLua.Template = "DisplayCineFilterBJ({0})"
		public static extern void DisplayCineFilterBJ(bool flag);
		/// @CSharpLua.Template = "CinematicFadeCommonBJ({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern void CinematicFadeCommonBJ(float red, float green, float blue, float duration, string tex, float startTrans, float endTrans);
		/// @CSharpLua.Template = "FinishCinematicFadeBJ()"
		public static extern void FinishCinematicFadeBJ();
		/// @CSharpLua.Template = "FinishCinematicFadeAfterBJ({0})"
		public static extern void FinishCinematicFadeAfterBJ(float duration);
		/// @CSharpLua.Template = "ContinueCinematicFadeBJ()"
		public static extern void ContinueCinematicFadeBJ();
		/// @CSharpLua.Template = "ContinueCinematicFadeAfterBJ({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern void ContinueCinematicFadeAfterBJ(float duration, float red, float green, float blue, float trans, string tex);
		/// @CSharpLua.Template = "AbortCinematicFadeBJ()"
		public static extern void AbortCinematicFadeBJ();
		/// @CSharpLua.Template = "CinematicFadeBJ({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern void CinematicFadeBJ(int fadetype, float duration, string tex, float red, float green, float blue, float trans);
		/// @CSharpLua.Template = "CinematicFilterGenericBJ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})"
		public static extern void CinematicFilterGenericBJ(float duration, blendmode bmode, string tex, float red0, float green0, float blue0, float trans0, float red1, float green1, float blue1, float trans1);
		/// @CSharpLua.Template = "RescueUnitBJ({0}, {1}, {2})"
		public static extern void RescueUnitBJ(unit whichUnit, player rescuer, bool changeColor);
		/// @CSharpLua.Template = "TriggerActionUnitRescuedBJ()"
		public static extern void TriggerActionUnitRescuedBJ();
		/// @CSharpLua.Template = "TryInitRescuableTriggersBJ()"
		public static extern void TryInitRescuableTriggersBJ();
		/// @CSharpLua.Template = "SetRescueUnitColorChangeBJ({0})"
		public static extern void SetRescueUnitColorChangeBJ(bool changeColor);
		/// @CSharpLua.Template = "SetRescueBuildingColorChangeBJ({0})"
		public static extern void SetRescueBuildingColorChangeBJ(bool changeColor);
		/// @CSharpLua.Template = "MakeUnitRescuableToForceBJEnum()"
		public static extern void MakeUnitRescuableToForceBJEnum();
		/// @CSharpLua.Template = "MakeUnitRescuableToForceBJ({0}, {1}, {2})"
		public static extern void MakeUnitRescuableToForceBJ(unit whichUnit, bool isRescuable, force whichForce);
		/// @CSharpLua.Template = "InitRescuableBehaviorBJ()"
		public static extern void InitRescuableBehaviorBJ();
		/// @CSharpLua.Template = "SetPlayerTechResearchedSwap({0}, {1}, {2})"
		public static extern void SetPlayerTechResearchedSwap(int techid, int levels, player whichPlayer);
		/// @CSharpLua.Template = "SetPlayerTechMaxAllowedSwap({0}, {1}, {2})"
		public static extern void SetPlayerTechMaxAllowedSwap(int techid, int maximum, player whichPlayer);
		/// @CSharpLua.Template = "SetPlayerMaxHeroesAllowed({0}, {1})"
		public static extern void SetPlayerMaxHeroesAllowed(int maximum, player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerTechCountSimple({0}, {1})"
		public static extern int GetPlayerTechCountSimple(int techid, player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerTechMaxAllowedSwap({0}, {1})"
		public static extern int GetPlayerTechMaxAllowedSwap(int techid, player whichPlayer);
		/// @CSharpLua.Template = "SetPlayerAbilityAvailableBJ({0}, {1}, {2})"
		public static extern void SetPlayerAbilityAvailableBJ(bool avail, int abilid, player whichPlayer);
		/// @CSharpLua.Template = "SetCampaignMenuRaceBJ({0})"
		public static extern void SetCampaignMenuRaceBJ(int campaignNumber);
		/// @CSharpLua.Template = "SetMissionAvailableBJ({0}, {1})"
		public static extern void SetMissionAvailableBJ(bool available, int missionIndex);
		/// @CSharpLua.Template = "SetCampaignAvailableBJ({0}, {1})"
		public static extern void SetCampaignAvailableBJ(bool available, int campaignNumber);
		/// @CSharpLua.Template = "SetCinematicAvailableBJ({0}, {1})"
		public static extern void SetCinematicAvailableBJ(bool available, int cinematicIndex);
		/// @CSharpLua.Template = "InitGameCacheBJ({0})"
		public static extern gamecache InitGameCacheBJ(string campaignFile);
		/// @CSharpLua.Template = "SaveGameCacheBJ({0})"
		public static extern bool SaveGameCacheBJ(gamecache cache);
		/// @CSharpLua.Template = "GetLastCreatedGameCacheBJ()"
		public static extern gamecache GetLastCreatedGameCacheBJ();
		/// @CSharpLua.Template = "InitHashtableBJ()"
		public static extern hashtable InitHashtableBJ();
		/// @CSharpLua.Template = "GetLastCreatedHashtableBJ()"
		public static extern hashtable GetLastCreatedHashtableBJ();
		/// @CSharpLua.Template = "StoreRealBJ({0}, {1}, {2}, {3})"
		public static extern void StoreRealBJ(float value, string key, string missionKey, gamecache cache);
		/// @CSharpLua.Template = "StoreIntegerBJ({0}, {1}, {2}, {3})"
		public static extern void StoreIntegerBJ(int value, string key, string missionKey, gamecache cache);
		/// @CSharpLua.Template = "StoreBooleanBJ({0}, {1}, {2}, {3})"
		public static extern void StoreBooleanBJ(bool value, string key, string missionKey, gamecache cache);
		/// @CSharpLua.Template = "StoreStringBJ({0}, {1}, {2}, {3})"
		public static extern bool StoreStringBJ(string value, string key, string missionKey, gamecache cache);
		/// @CSharpLua.Template = "StoreUnitBJ({0}, {1}, {2}, {3})"
		public static extern bool StoreUnitBJ(unit whichUnit, string key, string missionKey, gamecache cache);
		/// @CSharpLua.Template = "SaveRealBJ({0}, {1}, {2}, {3})"
		public static extern void SaveRealBJ(float value, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveIntegerBJ({0}, {1}, {2}, {3})"
		public static extern void SaveIntegerBJ(int value, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveBooleanBJ({0}, {1}, {2}, {3})"
		public static extern void SaveBooleanBJ(bool value, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveStringBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveStringBJ(string value, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SavePlayerHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SavePlayerHandleBJ(player whichPlayer, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveWidgetHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveWidgetHandleBJ(widget whichWidget, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveDestructableHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveDestructableHandleBJ(destructable whichDestructable, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveItemHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveItemHandleBJ(item whichItem, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveUnitHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveUnitHandleBJ(unit whichUnit, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveAbilityHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveAbilityHandleBJ(ability whichAbility, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveTimerHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveTimerHandleBJ(timer whichTimer, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveTriggerHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveTriggerHandleBJ(trigger whichTrigger, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveTriggerConditionHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveTriggerConditionHandleBJ(triggercondition whichTriggercondition, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveTriggerActionHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveTriggerActionHandleBJ(triggeraction whichTriggeraction, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveTriggerEventHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveTriggerEventHandleBJ(@event whichEvent, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveForceHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveForceHandleBJ(force whichForce, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveGroupHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveGroupHandleBJ(group whichGroup, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveLocationHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveLocationHandleBJ(location whichLocation, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveRectHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveRectHandleBJ(rect whichRect, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveBooleanExprHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveBooleanExprHandleBJ(boolexpr whichBoolexpr, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveSoundHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveSoundHandleBJ(sound whichSound, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveEffectHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveEffectHandleBJ(effect whichEffect, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveUnitPoolHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveUnitPoolHandleBJ(unitpool whichUnitpool, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveItemPoolHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveItemPoolHandleBJ(itempool whichItempool, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveQuestHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveQuestHandleBJ(quest whichQuest, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveQuestItemHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveQuestItemHandleBJ(questitem whichQuestitem, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveDefeatConditionHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveDefeatConditionHandleBJ(defeatcondition whichDefeatcondition, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveTimerDialogHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveTimerDialogHandleBJ(timerdialog whichTimerdialog, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveLeaderboardHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveLeaderboardHandleBJ(leaderboard whichLeaderboard, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveMultiboardHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveMultiboardHandleBJ(multiboard whichMultiboard, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveMultiboardItemHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveMultiboardItemHandleBJ(multiboarditem whichMultiboarditem, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveTrackableHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveTrackableHandleBJ(trackable whichTrackable, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveDialogHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveDialogHandleBJ(dialog whichDialog, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveButtonHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveButtonHandleBJ(button whichButton, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveTextTagHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveTextTagHandleBJ(texttag whichTexttag, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveLightningHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveLightningHandleBJ(lightning whichLightning, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveImageHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveImageHandleBJ(image whichImage, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveUbersplatHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveUbersplatHandleBJ(ubersplat whichUbersplat, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveRegionHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveRegionHandleBJ(region whichRegion, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveFogStateHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveFogStateHandleBJ(fogstate whichFogState, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveFogModifierHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveFogModifierHandleBJ(fogmodifier whichFogModifier, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveAgentHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveAgentHandleBJ(agent whichAgent, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "SaveHashtableHandleBJ({0}, {1}, {2}, {3})"
		public static extern bool SaveHashtableHandleBJ(hashtable whichHashtable, int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "GetStoredRealBJ({0}, {1}, {2})"
		public static extern float GetStoredRealBJ(string key, string missionKey, gamecache cache);
		/// @CSharpLua.Template = "GetStoredIntegerBJ({0}, {1}, {2})"
		public static extern int GetStoredIntegerBJ(string key, string missionKey, gamecache cache);
		/// @CSharpLua.Template = "GetStoredBooleanBJ({0}, {1}, {2})"
		public static extern bool GetStoredBooleanBJ(string key, string missionKey, gamecache cache);
		/// @CSharpLua.Template = "GetStoredStringBJ({0}, {1}, {2})"
		public static extern string GetStoredStringBJ(string key, string missionKey, gamecache cache);
		/// @CSharpLua.Template = "LoadRealBJ({0}, {1}, {2})"
		public static extern float LoadRealBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadIntegerBJ({0}, {1}, {2})"
		public static extern int LoadIntegerBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadBooleanBJ({0}, {1}, {2})"
		public static extern bool LoadBooleanBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadStringBJ({0}, {1}, {2})"
		public static extern string LoadStringBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadPlayerHandleBJ({0}, {1}, {2})"
		public static extern player LoadPlayerHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadWidgetHandleBJ({0}, {1}, {2})"
		public static extern widget LoadWidgetHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadDestructableHandleBJ({0}, {1}, {2})"
		public static extern destructable LoadDestructableHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadItemHandleBJ({0}, {1}, {2})"
		public static extern item LoadItemHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadUnitHandleBJ({0}, {1}, {2})"
		public static extern unit LoadUnitHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadAbilityHandleBJ({0}, {1}, {2})"
		public static extern ability LoadAbilityHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadTimerHandleBJ({0}, {1}, {2})"
		public static extern timer LoadTimerHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadTriggerHandleBJ({0}, {1}, {2})"
		public static extern trigger LoadTriggerHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadTriggerConditionHandleBJ({0}, {1}, {2})"
		public static extern triggercondition LoadTriggerConditionHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadTriggerActionHandleBJ({0}, {1}, {2})"
		public static extern triggeraction LoadTriggerActionHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadTriggerEventHandleBJ({0}, {1}, {2})"
		public static extern @event LoadTriggerEventHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadForceHandleBJ({0}, {1}, {2})"
		public static extern force LoadForceHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadGroupHandleBJ({0}, {1}, {2})"
		public static extern group LoadGroupHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadLocationHandleBJ({0}, {1}, {2})"
		public static extern location LoadLocationHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadRectHandleBJ({0}, {1}, {2})"
		public static extern rect LoadRectHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadBooleanExprHandleBJ({0}, {1}, {2})"
		public static extern boolexpr LoadBooleanExprHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadSoundHandleBJ({0}, {1}, {2})"
		public static extern sound LoadSoundHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadEffectHandleBJ({0}, {1}, {2})"
		public static extern effect LoadEffectHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadUnitPoolHandleBJ({0}, {1}, {2})"
		public static extern unitpool LoadUnitPoolHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadItemPoolHandleBJ({0}, {1}, {2})"
		public static extern itempool LoadItemPoolHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadQuestHandleBJ({0}, {1}, {2})"
		public static extern quest LoadQuestHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadQuestItemHandleBJ({0}, {1}, {2})"
		public static extern questitem LoadQuestItemHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadDefeatConditionHandleBJ({0}, {1}, {2})"
		public static extern defeatcondition LoadDefeatConditionHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadTimerDialogHandleBJ({0}, {1}, {2})"
		public static extern timerdialog LoadTimerDialogHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadLeaderboardHandleBJ({0}, {1}, {2})"
		public static extern leaderboard LoadLeaderboardHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadMultiboardHandleBJ({0}, {1}, {2})"
		public static extern multiboard LoadMultiboardHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadMultiboardItemHandleBJ({0}, {1}, {2})"
		public static extern multiboarditem LoadMultiboardItemHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadTrackableHandleBJ({0}, {1}, {2})"
		public static extern trackable LoadTrackableHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadDialogHandleBJ({0}, {1}, {2})"
		public static extern dialog LoadDialogHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadButtonHandleBJ({0}, {1}, {2})"
		public static extern button LoadButtonHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadTextTagHandleBJ({0}, {1}, {2})"
		public static extern texttag LoadTextTagHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadLightningHandleBJ({0}, {1}, {2})"
		public static extern lightning LoadLightningHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadImageHandleBJ({0}, {1}, {2})"
		public static extern image LoadImageHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadUbersplatHandleBJ({0}, {1}, {2})"
		public static extern ubersplat LoadUbersplatHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadRegionHandleBJ({0}, {1}, {2})"
		public static extern region LoadRegionHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadFogStateHandleBJ({0}, {1}, {2})"
		public static extern fogstate LoadFogStateHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadFogModifierHandleBJ({0}, {1}, {2})"
		public static extern fogmodifier LoadFogModifierHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "LoadHashtableHandleBJ({0}, {1}, {2})"
		public static extern hashtable LoadHashtableHandleBJ(int key, int missionKey, hashtable table);
		/// @CSharpLua.Template = "RestoreUnitLocFacingAngleBJ({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern unit RestoreUnitLocFacingAngleBJ(string key, string missionKey, gamecache cache, player forWhichPlayer, location loc, float facing);
		/// @CSharpLua.Template = "RestoreUnitLocFacingPointBJ({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern unit RestoreUnitLocFacingPointBJ(string key, string missionKey, gamecache cache, player forWhichPlayer, location loc, location lookAt);
		/// @CSharpLua.Template = "GetLastRestoredUnitBJ()"
		public static extern unit GetLastRestoredUnitBJ();
		/// @CSharpLua.Template = "FlushGameCacheBJ({0})"
		public static extern void FlushGameCacheBJ(gamecache cache);
		/// @CSharpLua.Template = "FlushStoredMissionBJ({0}, {1})"
		public static extern void FlushStoredMissionBJ(string missionKey, gamecache cache);
		/// @CSharpLua.Template = "FlushParentHashtableBJ({0})"
		public static extern void FlushParentHashtableBJ(hashtable table);
		/// @CSharpLua.Template = "FlushChildHashtableBJ({0}, {1})"
		public static extern void FlushChildHashtableBJ(int missionKey, hashtable table);
		/// @CSharpLua.Template = "HaveStoredValue({0}, {1}, {2}, {3})"
		public static extern bool HaveStoredValue(string key, int valueType, string missionKey, gamecache cache);
		/// @CSharpLua.Template = "HaveSavedValue({0}, {1}, {2}, {3})"
		public static extern bool HaveSavedValue(int key, int valueType, int missionKey, hashtable table);
		/// @CSharpLua.Template = "ShowCustomCampaignButton({0}, {1})"
		public static extern void ShowCustomCampaignButton(bool show, int whichButton);
		/// @CSharpLua.Template = "IsCustomCampaignButtonVisibile({0})"
		public static extern bool IsCustomCampaignButtonVisibile(int whichButton);
		/// @CSharpLua.Template = "SaveGameCheckPointBJ({0}, {1})"
		public static extern void SaveGameCheckPointBJ(string mapSaveName, bool doCheckpointHint);
		/// @CSharpLua.Template = "LoadGameBJ({0}, {1})"
		public static extern void LoadGameBJ(string loadFileName, bool doScoreScreen);
		/// @CSharpLua.Template = "SaveAndChangeLevelBJ({0}, {1}, {2})"
		public static extern void SaveAndChangeLevelBJ(string saveFileName, string newLevel, bool doScoreScreen);
		/// @CSharpLua.Template = "SaveAndLoadGameBJ({0}, {1}, {2})"
		public static extern void SaveAndLoadGameBJ(string saveFileName, string loadFileName, bool doScoreScreen);
		/// @CSharpLua.Template = "RenameSaveDirectoryBJ({0}, {1})"
		public static extern bool RenameSaveDirectoryBJ(string sourceDirName, string destDirName);
		/// @CSharpLua.Template = "RemoveSaveDirectoryBJ({0})"
		public static extern bool RemoveSaveDirectoryBJ(string sourceDirName);
		/// @CSharpLua.Template = "CopySaveGameBJ({0}, {1})"
		public static extern bool CopySaveGameBJ(string sourceSaveName, string destSaveName);
		/// @CSharpLua.Template = "GetPlayerStartLocationX({0})"
		public static extern float GetPlayerStartLocationX(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerStartLocationY({0})"
		public static extern float GetPlayerStartLocationY(player whichPlayer);
		/// @CSharpLua.Template = "GetPlayerStartLocationLoc({0})"
		public static extern location GetPlayerStartLocationLoc(player whichPlayer);
		/// @CSharpLua.Template = "GetRectCenter({0})"
		public static extern location GetRectCenter(rect whichRect);
		/// @CSharpLua.Template = "IsPlayerSlotState({0}, {1})"
		public static extern bool IsPlayerSlotState(player whichPlayer, playerslotstate whichState);
		/// @CSharpLua.Template = "GetFadeFromSeconds({0})"
		public static extern int GetFadeFromSeconds(float seconds);
		/// @CSharpLua.Template = "GetFadeFromSecondsAsReal({0})"
		public static extern float GetFadeFromSecondsAsReal(float seconds);
		/// @CSharpLua.Template = "AdjustPlayerStateSimpleBJ({0}, {1}, {2})"
		public static extern void AdjustPlayerStateSimpleBJ(player whichPlayer, playerstate whichPlayerState, int delta);
		/// @CSharpLua.Template = "AdjustPlayerStateBJ({0}, {1}, {2})"
		public static extern void AdjustPlayerStateBJ(int delta, player whichPlayer, playerstate whichPlayerState);
		/// @CSharpLua.Template = "SetPlayerStateBJ({0}, {1}, {2})"
		public static extern void SetPlayerStateBJ(player whichPlayer, playerstate whichPlayerState, int value);
		/// @CSharpLua.Template = "SetPlayerFlagBJ({0}, {1}, {2})"
		public static extern void SetPlayerFlagBJ(playerstate whichPlayerFlag, bool flag, player whichPlayer);
		/// @CSharpLua.Template = "SetPlayerTaxRateBJ({0}, {1}, {2}, {3})"
		public static extern void SetPlayerTaxRateBJ(int rate, playerstate whichResource, player sourcePlayer, player otherPlayer);
		/// @CSharpLua.Template = "GetPlayerTaxRateBJ({0}, {1}, {2})"
		public static extern int GetPlayerTaxRateBJ(playerstate whichResource, player sourcePlayer, player otherPlayer);
		/// @CSharpLua.Template = "IsPlayerFlagSetBJ({0}, {1})"
		public static extern bool IsPlayerFlagSetBJ(playerstate whichPlayerFlag, player whichPlayer);
		/// @CSharpLua.Template = "AddResourceAmountBJ({0}, {1})"
		public static extern void AddResourceAmountBJ(int delta, unit whichUnit);
		/// @CSharpLua.Template = "GetConvertedPlayerId({0})"
		public static extern int GetConvertedPlayerId(player whichPlayer);
		/// @CSharpLua.Template = "ConvertedPlayer({0})"
		public static extern player ConvertedPlayer(int convertedPlayerId);
		/// @CSharpLua.Template = "GetRectWidthBJ({0})"
		public static extern float GetRectWidthBJ(rect r);
		/// @CSharpLua.Template = "GetRectHeightBJ({0})"
		public static extern float GetRectHeightBJ(rect r);
		/// @CSharpLua.Template = "BlightGoldMineForPlayerBJ({0}, {1})"
		public static extern unit BlightGoldMineForPlayerBJ(unit goldMine, player whichPlayer);
		/// @CSharpLua.Template = "BlightGoldMineForPlayer({0}, {1})"
		public static extern unit BlightGoldMineForPlayer(unit goldMine, player whichPlayer);
		/// @CSharpLua.Template = "GetLastHauntedGoldMine()"
		public static extern unit GetLastHauntedGoldMine();
		/// @CSharpLua.Template = "IsPointBlightedBJ({0})"
		public static extern bool IsPointBlightedBJ(location where);
		/// @CSharpLua.Template = "SetPlayerColorBJEnum()"
		public static extern void SetPlayerColorBJEnum();
		/// @CSharpLua.Template = "SetPlayerColorBJ({0}, {1}, {2})"
		public static extern void SetPlayerColorBJ(player whichPlayer, playercolor color, bool changeExisting);
		/// @CSharpLua.Template = "SetPlayerUnitAvailableBJ({0}, {1}, {2})"
		public static extern void SetPlayerUnitAvailableBJ(int unitId, bool allowed, player whichPlayer);
		/// @CSharpLua.Template = "LockGameSpeedBJ()"
		public static extern void LockGameSpeedBJ();
		/// @CSharpLua.Template = "UnlockGameSpeedBJ()"
		public static extern void UnlockGameSpeedBJ();
		/// @CSharpLua.Template = "IssueTargetOrderBJ({0}, {1}, {2})"
		public static extern bool IssueTargetOrderBJ(unit whichUnit, string order, widget targetWidget);
		/// @CSharpLua.Template = "IssuePointOrderLocBJ({0}, {1}, {2})"
		public static extern bool IssuePointOrderLocBJ(unit whichUnit, string order, location whichLocation);
		/// @CSharpLua.Template = "IssueTargetDestructableOrder({0}, {1}, {2})"
		public static extern bool IssueTargetDestructableOrder(unit whichUnit, string order, widget targetWidget);
		/// @CSharpLua.Template = "IssueTargetItemOrder({0}, {1}, {2})"
		public static extern bool IssueTargetItemOrder(unit whichUnit, string order, widget targetWidget);
		/// @CSharpLua.Template = "IssueImmediateOrderBJ({0}, {1})"
		public static extern bool IssueImmediateOrderBJ(unit whichUnit, string order);
		/// @CSharpLua.Template = "GroupTargetOrderBJ({0}, {1}, {2})"
		public static extern bool GroupTargetOrderBJ(group whichGroup, string order, widget targetWidget);
		/// @CSharpLua.Template = "GroupPointOrderLocBJ({0}, {1}, {2})"
		public static extern bool GroupPointOrderLocBJ(group whichGroup, string order, location whichLocation);
		/// @CSharpLua.Template = "GroupImmediateOrderBJ({0}, {1})"
		public static extern bool GroupImmediateOrderBJ(group whichGroup, string order);
		/// @CSharpLua.Template = "GroupTargetDestructableOrder({0}, {1}, {2})"
		public static extern bool GroupTargetDestructableOrder(group whichGroup, string order, widget targetWidget);
		/// @CSharpLua.Template = "GroupTargetItemOrder({0}, {1}, {2})"
		public static extern bool GroupTargetItemOrder(group whichGroup, string order, widget targetWidget);
		/// @CSharpLua.Template = "GetDyingDestructable()"
		public static extern destructable GetDyingDestructable();
		/// @CSharpLua.Template = "SetUnitRallyPoint({0}, {1})"
		public static extern void SetUnitRallyPoint(unit whichUnit, location targPos);
		/// @CSharpLua.Template = "SetUnitRallyUnit({0}, {1})"
		public static extern void SetUnitRallyUnit(unit whichUnit, unit targUnit);
		/// @CSharpLua.Template = "SetUnitRallyDestructable({0}, {1})"
		public static extern void SetUnitRallyDestructable(unit whichUnit, destructable targDest);
		/// @CSharpLua.Template = "SaveDyingWidget()"
		public static extern void SaveDyingWidget();
		/// @CSharpLua.Template = "SetBlightRectBJ({0}, {1}, {2})"
		public static extern void SetBlightRectBJ(bool addBlight, player whichPlayer, rect r);
		/// @CSharpLua.Template = "SetBlightRadiusLocBJ({0}, {1}, {2}, {3})"
		public static extern void SetBlightRadiusLocBJ(bool addBlight, player whichPlayer, location loc, float radius);
		/// @CSharpLua.Template = "GetAbilityName({0})"
		public static extern string GetAbilityName(int abilcode);
		/// @CSharpLua.Template = "MeleeStartingVisibility()"
		public static extern void MeleeStartingVisibility();
		/// @CSharpLua.Template = "MeleeStartingResources()"
		public static extern void MeleeStartingResources();
		/// @CSharpLua.Template = "ReducePlayerTechMaxAllowed({0}, {1}, {2})"
		public static extern void ReducePlayerTechMaxAllowed(player whichPlayer, int techId, int limit);
		/// @CSharpLua.Template = "MeleeStartingHeroLimit()"
		public static extern void MeleeStartingHeroLimit();
		/// @CSharpLua.Template = "MeleeTrainedUnitIsHeroBJFilter()"
		public static extern bool MeleeTrainedUnitIsHeroBJFilter();
		/// @CSharpLua.Template = "MeleeGrantItemsToHero({0})"
		public static extern void MeleeGrantItemsToHero(unit whichUnit);
		/// @CSharpLua.Template = "MeleeGrantItemsToTrainedHero()"
		public static extern void MeleeGrantItemsToTrainedHero();
		/// @CSharpLua.Template = "MeleeGrantItemsToHiredHero()"
		public static extern void MeleeGrantItemsToHiredHero();
		/// @CSharpLua.Template = "MeleeGrantHeroItems()"
		public static extern void MeleeGrantHeroItems();
		/// @CSharpLua.Template = "MeleeClearExcessUnit()"
		public static extern void MeleeClearExcessUnit();
		/// @CSharpLua.Template = "MeleeClearNearbyUnits({0}, {1}, {2})"
		public static extern void MeleeClearNearbyUnits(float x, float y, float range);
		/// @CSharpLua.Template = "MeleeClearExcessUnits()"
		public static extern void MeleeClearExcessUnits();
		/// @CSharpLua.Template = "MeleeEnumFindNearestMine()"
		public static extern void MeleeEnumFindNearestMine();
		/// @CSharpLua.Template = "MeleeFindNearestMine({0}, {1})"
		public static extern unit MeleeFindNearestMine(location src, float range);
		/// @CSharpLua.Template = "MeleeRandomHeroLoc({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern unit MeleeRandomHeroLoc(player p, int id1, int id2, int id3, int id4, location loc);
		/// @CSharpLua.Template = "MeleeGetProjectedLoc({0}, {1}, {2}, {3})"
		public static extern location MeleeGetProjectedLoc(location src, location targ, float distance, float deltaAngle);
		/// @CSharpLua.Template = "MeleeGetNearestValueWithin({0}, {1}, {2})"
		public static extern float MeleeGetNearestValueWithin(float val, float minVal, float maxVal);
		/// @CSharpLua.Template = "MeleeGetLocWithinRect({0}, {1})"
		public static extern location MeleeGetLocWithinRect(location src, rect r);
		/// @CSharpLua.Template = "MeleeStartingUnitsHuman({0}, {1}, {2}, {3}, {4})"
		public static extern void MeleeStartingUnitsHuman(player whichPlayer, location startLoc, bool doHeroes, bool doCamera, bool doPreload);
		/// @CSharpLua.Template = "MeleeStartingUnitsOrc({0}, {1}, {2}, {3}, {4})"
		public static extern void MeleeStartingUnitsOrc(player whichPlayer, location startLoc, bool doHeroes, bool doCamera, bool doPreload);
		/// @CSharpLua.Template = "MeleeStartingUnitsUndead({0}, {1}, {2}, {3}, {4})"
		public static extern void MeleeStartingUnitsUndead(player whichPlayer, location startLoc, bool doHeroes, bool doCamera, bool doPreload);
		/// @CSharpLua.Template = "MeleeStartingUnitsNightElf({0}, {1}, {2}, {3}, {4})"
		public static extern void MeleeStartingUnitsNightElf(player whichPlayer, location startLoc, bool doHeroes, bool doCamera, bool doPreload);
		/// @CSharpLua.Template = "MeleeStartingUnitsUnknownRace({0}, {1}, {2}, {3}, {4})"
		public static extern void MeleeStartingUnitsUnknownRace(player whichPlayer, location startLoc, bool doHeroes, bool doCamera, bool doPreload);
		/// @CSharpLua.Template = "MeleeStartingUnits()"
		public static extern void MeleeStartingUnits();
		/// @CSharpLua.Template = "MeleeStartingUnitsForPlayer({0}, {1}, {2}, {3})"
		public static extern void MeleeStartingUnitsForPlayer(race whichRace, player whichPlayer, location loc, bool doHeroes);
		/// @CSharpLua.Template = "PickMeleeAI({0}, {1}, {2}, {3})"
		public static extern void PickMeleeAI(player num, string s1, string s2, string s3);
		/// @CSharpLua.Template = "MeleeStartingAI()"
		public static extern void MeleeStartingAI();
		/// @CSharpLua.Template = "LockGuardPosition({0})"
		public static extern void LockGuardPosition(unit targ);
		/// @CSharpLua.Template = "MeleePlayerIsOpponent({0}, {1})"
		public static extern bool MeleePlayerIsOpponent(int playerIndex, int opponentIndex);
		/// @CSharpLua.Template = "MeleeGetAllyStructureCount({0})"
		public static extern int MeleeGetAllyStructureCount(player whichPlayer);
		/// @CSharpLua.Template = "MeleeGetAllyCount({0})"
		public static extern int MeleeGetAllyCount(player whichPlayer);
		/// @CSharpLua.Template = "MeleeGetAllyKeyStructureCount({0})"
		public static extern int MeleeGetAllyKeyStructureCount(player whichPlayer);
		/// @CSharpLua.Template = "MeleeDoDrawEnum()"
		public static extern void MeleeDoDrawEnum();
		/// @CSharpLua.Template = "MeleeDoVictoryEnum()"
		public static extern void MeleeDoVictoryEnum();
		/// @CSharpLua.Template = "MeleeDoDefeat({0})"
		public static extern void MeleeDoDefeat(player whichPlayer);
		/// @CSharpLua.Template = "MeleeDoDefeatEnum()"
		public static extern void MeleeDoDefeatEnum();
		/// @CSharpLua.Template = "MeleeDoLeave({0})"
		public static extern void MeleeDoLeave(player whichPlayer);
		/// @CSharpLua.Template = "MeleeRemoveObservers()"
		public static extern void MeleeRemoveObservers();
		/// @CSharpLua.Template = "MeleeCheckForVictors()"
		public static extern force MeleeCheckForVictors();
		/// @CSharpLua.Template = "MeleeCheckForLosersAndVictors()"
		public static extern void MeleeCheckForLosersAndVictors();
		/// @CSharpLua.Template = "MeleeGetCrippledWarningMessage({0})"
		public static extern string MeleeGetCrippledWarningMessage(player whichPlayer);
		/// @CSharpLua.Template = "MeleeGetCrippledTimerMessage({0})"
		public static extern string MeleeGetCrippledTimerMessage(player whichPlayer);
		/// @CSharpLua.Template = "MeleeGetCrippledRevealedMessage({0})"
		public static extern string MeleeGetCrippledRevealedMessage(player whichPlayer);
		/// @CSharpLua.Template = "MeleeExposePlayer({0}, {1})"
		public static extern void MeleeExposePlayer(player whichPlayer, bool expose);
		/// @CSharpLua.Template = "MeleeExposeAllPlayers()"
		public static extern void MeleeExposeAllPlayers();
		/// @CSharpLua.Template = "MeleeCrippledPlayerTimeout()"
		public static extern void MeleeCrippledPlayerTimeout();
		/// @CSharpLua.Template = "MeleePlayerIsCrippled({0})"
		public static extern bool MeleePlayerIsCrippled(player whichPlayer);
		/// @CSharpLua.Template = "MeleeCheckForCrippledPlayers()"
		public static extern void MeleeCheckForCrippledPlayers();
		/// @CSharpLua.Template = "MeleeCheckLostUnit({0})"
		public static extern void MeleeCheckLostUnit(unit lostUnit);
		/// @CSharpLua.Template = "MeleeCheckAddedUnit({0})"
		public static extern void MeleeCheckAddedUnit(unit addedUnit);
		/// @CSharpLua.Template = "MeleeTriggerActionConstructCancel()"
		public static extern void MeleeTriggerActionConstructCancel();
		/// @CSharpLua.Template = "MeleeTriggerActionUnitDeath()"
		public static extern void MeleeTriggerActionUnitDeath();
		/// @CSharpLua.Template = "MeleeTriggerActionUnitConstructionStart()"
		public static extern void MeleeTriggerActionUnitConstructionStart();
		/// @CSharpLua.Template = "MeleeTriggerActionPlayerDefeated()"
		public static extern void MeleeTriggerActionPlayerDefeated();
		/// @CSharpLua.Template = "MeleeTriggerActionPlayerLeft()"
		public static extern void MeleeTriggerActionPlayerLeft();
		/// @CSharpLua.Template = "MeleeTriggerActionAllianceChange()"
		public static extern void MeleeTriggerActionAllianceChange();
		/// @CSharpLua.Template = "MeleeTriggerTournamentFinishSoon()"
		public static extern void MeleeTriggerTournamentFinishSoon();
		/// @CSharpLua.Template = "MeleeWasUserPlayer({0})"
		public static extern bool MeleeWasUserPlayer(player whichPlayer);
		/// @CSharpLua.Template = "MeleeTournamentFinishNowRuleA({0})"
		public static extern void MeleeTournamentFinishNowRuleA(int multiplier);
		/// @CSharpLua.Template = "MeleeTriggerTournamentFinishNow()"
		public static extern void MeleeTriggerTournamentFinishNow();
		/// @CSharpLua.Template = "MeleeInitVictoryDefeat()"
		public static extern void MeleeInitVictoryDefeat();
		/// @CSharpLua.Template = "CheckInitPlayerSlotAvailability()"
		public static extern void CheckInitPlayerSlotAvailability();
		/// @CSharpLua.Template = "SetPlayerSlotAvailable({0}, {1})"
		public static extern void SetPlayerSlotAvailable(player whichPlayer, mapcontrol control);
		/// @CSharpLua.Template = "TeamInitPlayerSlots({0})"
		public static extern void TeamInitPlayerSlots(int teamCount);
		/// @CSharpLua.Template = "MeleeInitPlayerSlots()"
		public static extern void MeleeInitPlayerSlots();
		/// @CSharpLua.Template = "FFAInitPlayerSlots()"
		public static extern void FFAInitPlayerSlots();
		/// @CSharpLua.Template = "OneOnOneInitPlayerSlots()"
		public static extern void OneOnOneInitPlayerSlots();
		/// @CSharpLua.Template = "InitGenericPlayerSlots()"
		public static extern void InitGenericPlayerSlots();
		/// @CSharpLua.Template = "SetDNCSoundsDawn()"
		public static extern void SetDNCSoundsDawn();
		/// @CSharpLua.Template = "SetDNCSoundsDusk()"
		public static extern void SetDNCSoundsDusk();
		/// @CSharpLua.Template = "SetDNCSoundsDay()"
		public static extern void SetDNCSoundsDay();
		/// @CSharpLua.Template = "SetDNCSoundsNight()"
		public static extern void SetDNCSoundsNight();
		/// @CSharpLua.Template = "InitDNCSounds()"
		public static extern void InitDNCSounds();
		/// @CSharpLua.Template = "InitBlizzardGlobals()"
		public static extern void InitBlizzardGlobals();
		/// @CSharpLua.Template = "InitQueuedTriggers()"
		public static extern void InitQueuedTriggers();
		/// @CSharpLua.Template = "InitMapRects()"
		public static extern void InitMapRects();
		/// @CSharpLua.Template = "InitSummonableCaps()"
		public static extern void InitSummonableCaps();
		/// @CSharpLua.Template = "UpdateStockAvailability({0})"
		public static extern void UpdateStockAvailability(item whichItem);
		/// @CSharpLua.Template = "UpdateEachStockBuildingEnum()"
		public static extern void UpdateEachStockBuildingEnum();
		/// @CSharpLua.Template = "UpdateEachStockBuilding({0}, {1})"
		public static extern void UpdateEachStockBuilding(itemtype iType, int iLevel);
		/// @CSharpLua.Template = "PerformStockUpdates()"
		public static extern void PerformStockUpdates();
		/// @CSharpLua.Template = "StartStockUpdates()"
		public static extern void StartStockUpdates();
		/// @CSharpLua.Template = "RemovePurchasedItem()"
		public static extern void RemovePurchasedItem();
		/// @CSharpLua.Template = "InitNeutralBuildings()"
		public static extern void InitNeutralBuildings();
		/// @CSharpLua.Template = "MarkGameStarted()"
		public static extern void MarkGameStarted();
		/// @CSharpLua.Template = "DetectGameStarted()"
		public static extern void DetectGameStarted();
		/// @CSharpLua.Template = "InitBlizzard()"
		public static extern void InitBlizzard();
		/// @CSharpLua.Template = "RandomDistReset()"
		public static extern void RandomDistReset();
		/// @CSharpLua.Template = "RandomDistAddItem({0}, {1})"
		public static extern void RandomDistAddItem(int inID, int inChance);
		/// @CSharpLua.Template = "RandomDistChoose()"
		public static extern int RandomDistChoose();
		/// @CSharpLua.Template = "UnitDropItem({0}, {1})"
		public static extern item UnitDropItem(unit inUnit, int inItemID);
		/// @CSharpLua.Template = "WidgetDropItem({0}, {1})"
		public static extern item WidgetDropItem(widget inWidget, int inItemID);
		/// @CSharpLua.Template = "BlzIsLastInstanceObjectFunctionSuccessful()"
		public static extern bool BlzIsLastInstanceObjectFunctionSuccessful();
		/// @CSharpLua.Template = "BlzSetAbilityBooleanFieldBJ({0}, {1}, {2})"
		public static extern void BlzSetAbilityBooleanFieldBJ(ability whichAbility, abilitybooleanfield whichField, bool value);
		/// @CSharpLua.Template = "BlzSetAbilityIntegerFieldBJ({0}, {1}, {2})"
		public static extern void BlzSetAbilityIntegerFieldBJ(ability whichAbility, abilityintegerfield whichField, int value);
		/// @CSharpLua.Template = "BlzSetAbilityRealFieldBJ({0}, {1}, {2})"
		public static extern void BlzSetAbilityRealFieldBJ(ability whichAbility, abilityrealfield whichField, float value);
		/// @CSharpLua.Template = "BlzSetAbilityStringFieldBJ({0}, {1}, {2})"
		public static extern void BlzSetAbilityStringFieldBJ(ability whichAbility, abilitystringfield whichField, string value);
		/// @CSharpLua.Template = "BlzSetAbilityBooleanLevelFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzSetAbilityBooleanLevelFieldBJ(ability whichAbility, abilitybooleanlevelfield whichField, int level, bool value);
		/// @CSharpLua.Template = "BlzSetAbilityIntegerLevelFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzSetAbilityIntegerLevelFieldBJ(ability whichAbility, abilityintegerlevelfield whichField, int level, int value);
		/// @CSharpLua.Template = "BlzSetAbilityRealLevelFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzSetAbilityRealLevelFieldBJ(ability whichAbility, abilityreallevelfield whichField, int level, float value);
		/// @CSharpLua.Template = "BlzSetAbilityStringLevelFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzSetAbilityStringLevelFieldBJ(ability whichAbility, abilitystringlevelfield whichField, int level, string value);
		/// @CSharpLua.Template = "BlzSetAbilityBooleanLevelArrayFieldBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void BlzSetAbilityBooleanLevelArrayFieldBJ(ability whichAbility, abilitybooleanlevelarrayfield whichField, int level, int index, bool value);
		/// @CSharpLua.Template = "BlzSetAbilityIntegerLevelArrayFieldBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void BlzSetAbilityIntegerLevelArrayFieldBJ(ability whichAbility, abilityintegerlevelarrayfield whichField, int level, int index, int value);
		/// @CSharpLua.Template = "BlzSetAbilityRealLevelArrayFieldBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void BlzSetAbilityRealLevelArrayFieldBJ(ability whichAbility, abilityreallevelarrayfield whichField, int level, int index, float value);
		/// @CSharpLua.Template = "BlzSetAbilityStringLevelArrayFieldBJ({0}, {1}, {2}, {3}, {4})"
		public static extern void BlzSetAbilityStringLevelArrayFieldBJ(ability whichAbility, abilitystringlevelarrayfield whichField, int level, int index, string value);
		/// @CSharpLua.Template = "BlzAddAbilityBooleanLevelArrayFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzAddAbilityBooleanLevelArrayFieldBJ(ability whichAbility, abilitybooleanlevelarrayfield whichField, int level, bool value);
		/// @CSharpLua.Template = "BlzAddAbilityIntegerLevelArrayFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzAddAbilityIntegerLevelArrayFieldBJ(ability whichAbility, abilityintegerlevelarrayfield whichField, int level, int value);
		/// @CSharpLua.Template = "BlzAddAbilityRealLevelArrayFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzAddAbilityRealLevelArrayFieldBJ(ability whichAbility, abilityreallevelarrayfield whichField, int level, float value);
		/// @CSharpLua.Template = "BlzAddAbilityStringLevelArrayFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzAddAbilityStringLevelArrayFieldBJ(ability whichAbility, abilitystringlevelarrayfield whichField, int level, string value);
		/// @CSharpLua.Template = "BlzRemoveAbilityBooleanLevelArrayFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzRemoveAbilityBooleanLevelArrayFieldBJ(ability whichAbility, abilitybooleanlevelarrayfield whichField, int level, bool value);
		/// @CSharpLua.Template = "BlzRemoveAbilityIntegerLevelArrayFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzRemoveAbilityIntegerLevelArrayFieldBJ(ability whichAbility, abilityintegerlevelarrayfield whichField, int level, int value);
		/// @CSharpLua.Template = "BlzRemoveAbilityRealLevelArrayFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzRemoveAbilityRealLevelArrayFieldBJ(ability whichAbility, abilityreallevelarrayfield whichField, int level, float value);
		/// @CSharpLua.Template = "BlzRemoveAbilityStringLevelArrayFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzRemoveAbilityStringLevelArrayFieldBJ(ability whichAbility, abilitystringlevelarrayfield whichField, int level, string value);
		/// @CSharpLua.Template = "BlzItemAddAbilityBJ({0}, {1})"
		public static extern void BlzItemAddAbilityBJ(item whichItem, int abilCode);
		/// @CSharpLua.Template = "BlzItemRemoveAbilityBJ({0}, {1})"
		public static extern void BlzItemRemoveAbilityBJ(item whichItem, int abilCode);
		/// @CSharpLua.Template = "BlzSetItemBooleanFieldBJ({0}, {1}, {2})"
		public static extern void BlzSetItemBooleanFieldBJ(item whichItem, itembooleanfield whichField, bool value);
		/// @CSharpLua.Template = "BlzSetItemIntegerFieldBJ({0}, {1}, {2})"
		public static extern void BlzSetItemIntegerFieldBJ(item whichItem, itemintegerfield whichField, int value);
		/// @CSharpLua.Template = "BlzSetItemRealFieldBJ({0}, {1}, {2})"
		public static extern void BlzSetItemRealFieldBJ(item whichItem, itemrealfield whichField, float value);
		/// @CSharpLua.Template = "BlzSetItemStringFieldBJ({0}, {1}, {2})"
		public static extern void BlzSetItemStringFieldBJ(item whichItem, itemstringfield whichField, string value);
		/// @CSharpLua.Template = "BlzSetUnitBooleanFieldBJ({0}, {1}, {2})"
		public static extern void BlzSetUnitBooleanFieldBJ(unit whichUnit, unitbooleanfield whichField, bool value);
		/// @CSharpLua.Template = "BlzSetUnitIntegerFieldBJ({0}, {1}, {2})"
		public static extern void BlzSetUnitIntegerFieldBJ(unit whichUnit, unitintegerfield whichField, int value);
		/// @CSharpLua.Template = "BlzSetUnitRealFieldBJ({0}, {1}, {2})"
		public static extern void BlzSetUnitRealFieldBJ(unit whichUnit, unitrealfield whichField, float value);
		/// @CSharpLua.Template = "BlzSetUnitStringFieldBJ({0}, {1}, {2})"
		public static extern void BlzSetUnitStringFieldBJ(unit whichUnit, unitstringfield whichField, string value);
		/// @CSharpLua.Template = "BlzSetUnitWeaponBooleanFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzSetUnitWeaponBooleanFieldBJ(unit whichUnit, unitweaponbooleanfield whichField, int index, bool value);
		/// @CSharpLua.Template = "BlzSetUnitWeaponIntegerFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzSetUnitWeaponIntegerFieldBJ(unit whichUnit, unitweaponintegerfield whichField, int index, int value);
		/// @CSharpLua.Template = "BlzSetUnitWeaponRealFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzSetUnitWeaponRealFieldBJ(unit whichUnit, unitweaponrealfield whichField, int index, float value);
		/// @CSharpLua.Template = "BlzSetUnitWeaponStringFieldBJ({0}, {1}, {2}, {3})"
		public static extern void BlzSetUnitWeaponStringFieldBJ(unit whichUnit, unitweaponstringfield whichField, int index, string value);
	}
}
