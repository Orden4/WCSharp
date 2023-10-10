namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class regentype : handle
	{
		internal regentype()
		{
		}

		/// @CSharpLua.Get = "REGENERATION_TYPE_NONE"
		public static extern regentype None { get; }
		/// @CSharpLua.Get = "REGENERATION_TYPE_ALWAYS"
		public static extern regentype Always { get; }
		/// @CSharpLua.Get = "REGENERATION_TYPE_BLIGHT"
		public static extern regentype Blight { get; }
		/// @CSharpLua.Get = "REGENERATION_TYPE_DAY"
		public static extern regentype Day { get; }
		/// @CSharpLua.Get = "REGENERATION_TYPE_NIGHT"
		public static extern regentype Night { get; }

		/// @CSharpLua.Template = "ConvertRegenType({0})"
		public static extern regentype Convert(int regenTypeId);
	}
}
