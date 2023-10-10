namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class version : handle
	{
		internal version()
		{
		}

		/// @CSharpLua.Get = "VERSION_REIGN_OF_CHAOS"
		public static extern version ReignOfChaos { get; }
		/// @CSharpLua.Get = "VERSION_FROZEN_THRONE"
		public static extern version FrozenThrone { get; }

		/// @CSharpLua.Template = "ConvertVersion({0})"
		public static extern version Convert(int versionId);

		/// @CSharpLua.Get = "VersionGet()"
		public static extern version Current { get; }

		/// @CSharpLua.Get = "VersionCompatible({this})"
		public extern bool Compatible { get; }

		/// @CSharpLua.Get = "VersionSupported({this})"
		public extern bool Supported { get; }
	}
}
