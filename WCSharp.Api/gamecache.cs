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

		/// @CSharpLua.Template = "StoreInteger({0}, {1}, {2}, {3})"
		public extern void AddInt(string missionKey, string key, int value);
		/// @CSharpLua.Template = "SyncStoredInteger({0}, {1}, {2})"
		public extern void SyncInt(string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredInteger({0}, {1}, {2})"
		public extern void FlushInt(string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredInteger({0}, {1}, {2})"
		public extern bool ContainsInt(string missionKey, string key);
		/// @CSharpLua.Template = "GetStoredInteger({0}, {1}, {2})"
		public extern int GetInt(string missionKey, string key);

		/// @CSharpLua.Template = "StoreFloat({0}, {1}, {2}, {3})"
		public extern void AddFloat(string missionKey, string key, float value);
		/// @CSharpLua.Template = "SyncStoredFloat({0}, {1}, {2})"
		public extern void SyncFloat(string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredFloat({0}, {1}, {2})"
		public extern void FlushFloat(string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredFloat({0}, {1}, {2})"
		public extern bool ContainsFloat(string missionKey, string key);
		/// @CSharpLua.Template = "GetStoredFloat({0}, {1}, {2})"
		public extern float GetFloat(string missionKey, string key);

		/// @CSharpLua.Template = "StoreBoolean({0}, {1}, {2}, {3})"
		public extern bool AddBool(string missionKey, string key, bool value);
		/// @CSharpLua.Template = "SyncStoredBoolean({0}, {1}, {2})"
		public extern void SyncBool(string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredBoolean({0}, {1}, {2})"
		public extern void FlushBool(string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredBoolean({0}, {1}, {2})"
		public extern bool ContainsBool(string missionKey, string key);
		/// @CSharpLua.Template = "GetStoredBoolean({0}, {1}, {2})"
		public extern bool GetBool(string missionKey, string key);

		/// @CSharpLua.Template = "StoreString({0}, {1}, {2}, {3})"
		public extern bool AddString(string missionKey, string key, string value);
		/// @CSharpLua.Template = "SyncStoredString({0}, {1}, {2})"
		public extern void SyncString(string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredString({0}, {1}, {2})"
		public extern void FlushString(string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredString({0}, {1}, {2})"
		public extern bool ContainsString(string missionKey, string key);
		/// @CSharpLua.Template = "GetStoredString({0}, {1}, {2})"
		public extern string GetString(string missionKey, string key);

		/// @CSharpLua.Template = "StoreUnit({0}, {1}, {2}, {3})"
		public extern bool AddUnit(string missionKey, string key, unit value);
		/// @CSharpLua.Template = "SyncStoredUnit({0}, {1}, {2})"
		public extern void SyncUnit(string missionKey, string key);
		/// @CSharpLua.Template = "FlushStoredUnit({0}, {1}, {2})"
		public extern void FlushUnit(string missionKey, string key);
		/// @CSharpLua.Template = "HaveStoredUnit({0}, {1}, {2})"
		public extern bool ContainsUnit(string missionKey, string key);
		/// @CSharpLua.Template = "RestoreUnit({0}, {1}, {2}, {3}, {4}, {5})"
		public extern unit GetUnit(string missionKey, string key, player player, float x, float y, float facing = Blizzard.bj_UNIT_FACING);

		/// @CSharpLua.Template = "FlushGameCache({0})"
		public extern bool Flush();
		/// @CSharpLua.Template = "FlushStoredMission({0}, {1})"
		public extern bool FlushMission();
		/// @CSharpLua.Template = "SaveGameCache({0})"
		public extern bool Save();
	}
}
