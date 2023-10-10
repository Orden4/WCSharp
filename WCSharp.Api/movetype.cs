namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class movetype : handle
	{
		internal movetype()
		{
		}

		/// @CSharpLua.Get = "MOVE_TYPE_UNKNOWN"
		public static extern movetype Unknown { get; }
		/// @CSharpLua.Get = "MOVE_TYPE_FOOT"
		public static extern movetype Foot { get; }
		/// @CSharpLua.Get = "MOVE_TYPE_FLY"
		public static extern movetype Fly { get; }
		/// @CSharpLua.Get = "MOVE_TYPE_HORSE"
		public static extern movetype Horse { get; }
		/// @CSharpLua.Get = "MOVE_TYPE_HOVER"
		public static extern movetype Hover { get; }
		/// @CSharpLua.Get = "MOVE_TYPE_FLOAT"
		public static extern movetype Float { get; }
		/// @CSharpLua.Get = "MOVE_TYPE_AMPHIBIOUS"
		public static extern movetype Amphibious { get; }
		/// @CSharpLua.Get = "MOVE_TYPE_UNBUILDABLE"
		public static extern movetype Unbuildable { get; }

		/// @CSharpLua.Template = "ConvertMoveType({0})"
		public static extern movetype Convert(int moveTypeId);
	}
}
