using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class FogState
	{
		internal FogState()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator fogstate(FogState x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator FogState(fogstate x);

		/// @CSharpLua.Get = "FOG_OF_WAR_MASKED"
		public static extern FogState Masked { get; }
		/// @CSharpLua.Get = "FOG_OF_WAR_FOGGED"
		public static extern FogState Fogged { get; }
		/// @CSharpLua.Get = "FOG_OF_WAR_VISIBLE"
		public static extern FogState Visible { get; }

		/// @CSharpLua.Template = "ConvertFogState({0})"
		public static extern FogState Convert(int fogStateId);
	}
}
