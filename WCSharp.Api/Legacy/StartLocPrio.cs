using static War3Api.Common;

namespace WCSharp.Api.Legacy
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class StartLocPrio
	{
		internal StartLocPrio()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator startlocprio(StartLocPrio x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator StartLocPrio(startlocprio x);

		/// @CSharpLua.Get = "MAP_LOC_PRIO_LOW"
		public static extern TextAlignType Low { get; }
		/// @CSharpLua.Get = "MAP_LOC_PRIO_HIGH"
		public static extern TextAlignType High { get; }
		/// @CSharpLua.Get = "MAP_LOC_PRIO_NOT"
		public static extern TextAlignType Not { get; }

		/// @CSharpLua.Template = "ConvertStartLocPrio({0})"
		public static extern StartLocPrio Convert(int startLocPrioId);
	}
}
