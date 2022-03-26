using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class PlayerScore
	{
		internal PlayerScore()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator playerscore(PlayerScore x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator PlayerScore(playerscore x);
	}
}
