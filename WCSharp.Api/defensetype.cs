namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class defensetype : handle
	{
		internal defensetype()
		{
		}

		/// @CSharpLua.Get = "DEFENSE_TYPE_LIGHT"
		public static extern defensetype Light { get; }
		/// @CSharpLua.Get = "DEFENSE_TYPE_MEDIUM"
		public static extern defensetype Medium { get; }
		/// @CSharpLua.Get = "DEFENSE_TYPE_LARGE"
		public static extern defensetype Large { get; }
		/// @CSharpLua.Get = "DEFENSE_TYPE_FORT"
		public static extern defensetype Fort { get; }
		/// @CSharpLua.Get = "DEFENSE_TYPE_NORMAL"
		public static extern defensetype Normal { get; }
		/// @CSharpLua.Get = "DEFENSE_TYPE_HERO"
		public static extern defensetype Hero { get; }
		/// @CSharpLua.Get = "DEFENSE_TYPE_DIVINE"
		public static extern defensetype Divine { get; }
		/// @CSharpLua.Get = "DEFENSE_TYPE_NONE"
		public static extern defensetype None { get; }

		/// @CSharpLua.Template = "ConvertDefenseType({0})"
		public static extern defensetype Convert(int defenseTypeId);
	}
}
