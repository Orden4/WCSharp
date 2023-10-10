namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class fogstate : handle
	{
		internal fogstate()
		{
		}

		/// @CSharpLua.Get = "FOG_OF_WAR_MASKED"
		public static extern fogstate Masked { get; }
		/// @CSharpLua.Get = "FOG_OF_WAR_FOGGED"
		public static extern fogstate Fogged { get; }
		/// @CSharpLua.Get = "FOG_OF_WAR_VISIBLE"
		public static extern fogstate Visible { get; }

		/// @CSharpLua.Template = "ConvertFogState({0})"
		public static extern fogstate Convert(int fogStateId);
	}
}
