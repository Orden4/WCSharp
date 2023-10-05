namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class alliancetype
	{
		internal alliancetype()
		{
		}

		/// @CSharpLua.Get = "ALLIANCE_PASSIVE"
		public static extern alliancetype Passive { get; }
		/// @CSharpLua.Get = "ALLIANCE_HELP_REQUEST"
		public static extern alliancetype HelpRequest { get; }
		/// @CSharpLua.Get = "ALLIANCE_HELP_RESPONSE"
		public static extern alliancetype HelpResponse { get; }
		/// @CSharpLua.Get = "ALLIANCE_SHARED_XP"
		public static extern alliancetype SharedExperience { get; }
		/// @CSharpLua.Get = "ALLIANCE_SHARED_SPELLS"
		public static extern alliancetype SharedSpells { get; }
		/// @CSharpLua.Get = "ALLIANCE_SHARED_VISION"
		public static extern alliancetype SharedVision { get; }
		/// @CSharpLua.Get = "ALLIANCE_SHARED_CONTROL"
		public static extern alliancetype SharedControl { get; }
		/// @CSharpLua.Get = "ALLIANCE_SHARED_ADVANCED_CONTROL"
		public static extern alliancetype SharedControlAdvanced { get; }
		/// @CSharpLua.Get = "ALLIANCE_RESCUABLE"
		public static extern alliancetype Rescuable { get; }
		/// @CSharpLua.Get = "ALLIANCE_SHARED_VISION_FORCED"
		public static extern alliancetype SharedVisionForced { get; }

		/// @CSharpLua.Template = "ConvertAllianceType({0})"
		public static extern alliancetype Convert(int allianceTypeId);
	}
}
