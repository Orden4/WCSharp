using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class RacePreference
	{
		internal RacePreference()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator racepreference(RacePreference x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator RacePreference(racepreference x);
	}
}
