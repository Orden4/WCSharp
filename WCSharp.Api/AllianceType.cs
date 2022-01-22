using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class AllianceType
	{
		internal AllianceType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator alliancetype(AllianceType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator AllianceType(alliancetype x);

		/// @CSharpLua.Get = "ALLIANCE_PASSIVE"
		public static extern AllianceType Passive { get; }
		/// @CSharpLua.Get = "ALLIANCE_HELP_REQUEST"
		public static extern AllianceType HelpRequest { get; }
		/// @CSharpLua.Get = "ALLIANCE_HELP_RESPONSE"
		public static extern AllianceType HelpResponse { get; }
		/// @CSharpLua.Get = "ALLIANCE_SHARED_XP"
		public static extern AllianceType SharedExperience { get; }
		/// @CSharpLua.Get = "ALLIANCE_SHARED_SPELLS"
		public static extern AllianceType SharedSpells { get; }
		/// @CSharpLua.Get = "ALLIANCE_SHARED_VISION"
		public static extern AllianceType SharedVision { get; }
		/// @CSharpLua.Get = "ALLIANCE_SHARED_CONTROL"
		public static extern AllianceType SharedControl { get; }
		/// @CSharpLua.Get = "ALLIANCE_SHARED_ADVANCED_CONTROL"
		public static extern AllianceType SharedControlAdvanced { get; }
		/// @CSharpLua.Get = "ALLIANCE_RESCUABLE"
		public static extern AllianceType Rescuable { get; }
		/// @CSharpLua.Get = "ALLIANCE_SHARED_VISION_FORCED"
		public static extern AllianceType SharedVisionForced { get; }

		/// @CSharpLua.Template = "ConvertAllianceType({0})"
		public static extern AllianceType Convert(int allianceType);
	}
}
