using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Version
	{
		internal Version()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator version(Version x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Version(version x);

		/// @CSharpLua.Get = "VERSION_REIGN_OF_CHAOS"
		public static extern Version ReignOfChaos { get; }
		/// @CSharpLua.Get = "VERSION_FROZEN_THRONE"
		public static extern Version FrozenThrone { get; }

		/// @CSharpLua.Template = "ConvertVersion({0})"
		public static extern Version Convert(int versionId);

		/// @CSharpLua.Get = "VersionGet()"
		public static extern Version Current { get; }

		/// @CSharpLua.Get = "VersionCompatible({0})"
		public extern bool Compatible { get; }

		/// @CSharpLua.Get = "VersionSupported({0})"
		public extern bool Supported { get; }
	}
}
