using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class UnitState
	{
		internal UnitState()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator unitstate(UnitState x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator UnitState(unitstate x);

		/// @CSharpLua.Get = "UNIT_STATE_LIFE"
		public static extern UnitState Life { get; }
		/// @CSharpLua.Get = "UNIT_STATE_MAX_LIFE"
		public static extern UnitState MaxLife { get; }
		/// @CSharpLua.Get = "UNIT_STATE_MANA"
		public static extern UnitState Mana { get; }
		/// @CSharpLua.Get = "UNIT_STATE_MAX_MANA"
		public static extern UnitState MaxMana { get; }

		/// @CSharpLua.Template = "ConvertUnitState({0})"
		public static extern UnitState Convert(int unitStateId);
	}
}
