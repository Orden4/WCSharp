namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class startlocprio : handle
	{
		internal startlocprio()
		{
		}

		/// @CSharpLua.Get = "MAP_LOC_PRIO_LOW"
		public static extern startlocprio Low { get; }
		/// @CSharpLua.Get = "MAP_LOC_PRIO_HIGH"
		public static extern startlocprio High { get; }
		/// @CSharpLua.Get = "MAP_LOC_PRIO_NOT"
		public static extern startlocprio Not { get; }

		/// @CSharpLua.Template = "ConvertStartLocPrio({0})"
		public static extern startlocprio Convert(int startLocPrioId);
	}
}
