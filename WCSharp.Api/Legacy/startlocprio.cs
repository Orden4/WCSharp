namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class startlocprio
	{
		internal startlocprio()
		{
		}

		/// @CSharpLua.Get = "MAP_LOC_PRIO_LOW"
		public static extern textaligntype Low { get; }
		/// @CSharpLua.Get = "MAP_LOC_PRIO_HIGH"
		public static extern textaligntype High { get; }
		/// @CSharpLua.Get = "MAP_LOC_PRIO_NOT"
		public static extern textaligntype Not { get; }

		/// @CSharpLua.Template = "ConvertStartLocPrio({0})"
		public static extern startlocprio Convert(int startLocPrioId);
	}
}
