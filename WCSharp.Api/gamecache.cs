namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class gamecache : agent
	{
		internal gamecache()
		{
		}

		/// @CSharpLua.Template = "InitGameCache({0})"
		public static extern gamecache Create(string file);

		/// @CSharpLua.Template = "StoreInteger({this}, {0}, {1}, {2})"
		public extern void AddInt(string missionKey, string key, int value);
		/// @CSharpLua.Template = "SyncStoredInteger({this}, {0}, {1})"
		public extern void SyncInt(string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredInteger({this}, {0}, {1})"
		public extern void FlushInt(string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredInteger({this}, {0}, {1})"
		public extern bool ContainsInt(string missionKey, string key);
		/// @CSharpLua.Template = "GetStoredInteger({this}, {0}, {1})"
		public extern int GetInt(string missionKey, string key);

		/// @CSharpLua.Template = "StoreReal({this}, {0}, {1}, {2})"
		public extern void AddFloat(string missionKey, string key, float value);
		/// @CSharpLua.Template = "SyncStoredReal({this}, {0}, {1})"
		public extern void SyncFloat(string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredReal({this}, {0}, {1})"
		public extern void FlushFloat(string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredReal({this}, {0}, {1})"
		public extern bool ContainsFloat(string missionKey, string key);
		/// @CSharpLua.Template = "GetStoredReal({this}, {0}, {1})"
		public extern float GetFloat(string missionKey, string key);

		/// @CSharpLua.Template = "StoreBoolean({this}, {0}, {1}, {2})"
		public extern void AddBool(string missionKey, string key, bool value);
		/// @CSharpLua.Template = "SyncStoredBoolean({this}, {0}, {1})"
		public extern void SyncBool(string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredBoolean({this}, {0}, {1})"
		public extern void FlushBool(string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredBoolean({this}, {0}, {1})"
		public extern bool ContainsBool(string missionKey, string key);
		/// @CSharpLua.Template = "GetStoredBoolean({this}, {0}, {1})"
		public extern bool GetBool(string missionKey, string key);

		/// @CSharpLua.Template = "StoreString({this}, {0}, {1}, {2})"
		public extern bool AddString(string missionKey, string key, string value);
		/// @CSharpLua.Template = "SyncStoredString({this}, {0}, {1})"
		public extern void SyncString(string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredString({this}, {0}, {1})"
		public extern void FlushString(string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredString({this}, {0}, {1})"
		public extern bool ContainsString(string missionKey, string key);
		/// @CSharpLua.Template = "GetStoredString({this}, {0}, {1})"
		public extern string GetString(string missionKey, string key);

		/// @CSharpLua.Template = "StoreUnit({this}, {0}, {1}, {2})"
		public extern bool AddUnit(string missionKey, string key, unit value);
		/// @CSharpLua.Template = "SyncStoredUnit({this}, {0}, {1})"
		public extern void SyncUnit(string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredUnit({this}, {0}, {1})"
		public extern void FlushUnit(string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredUnit({this}, {0}, {1})"
		public extern bool ContainsUnit(string missionKey, string key);
		/// @CSharpLua.Template = "RestoreUnit({this}, {0}, {1}, {2}, {3}, {4}, {5})"
		public extern unit GetUnit(string missionKey, string key, player player, float x, float y, float facing = Blizzard.bj_UNIT_FACING);

		/// @CSharpLua.Template = "FlushGameCache({this})"
		public extern void Flush();
		/// @CSharpLua.Template = "FlushStoredMission({this}, {0})"
		public extern void FlushMission(string missionKey);
		/// @CSharpLua.Template = "SaveGameCache({this})"
		public extern bool Save();
	}
}
