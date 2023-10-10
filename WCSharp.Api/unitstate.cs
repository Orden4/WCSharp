namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class unitstate : handle
	{
		internal unitstate()
		{
		}

		/// @CSharpLua.Get = "UNIT_STATE_LIFE"
		public static extern unitstate Life { get; }
		/// @CSharpLua.Get = "UNIT_STATE_MAX_LIFE"
		public static extern unitstate MaxLife { get; }
		/// @CSharpLua.Get = "UNIT_STATE_MANA"
		public static extern unitstate Mana { get; }
		/// @CSharpLua.Get = "UNIT_STATE_MAX_MANA"
		public static extern unitstate MaxMana { get; }

		/// @CSharpLua.Template = "ConvertUnitState({0})"
		public static extern unitstate Convert(int unitStateId);
	}
}
