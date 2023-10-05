using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class minimapicon : IDisposable
	{
		internal minimapicon()
		{
		}

		/// @CSharpLua.Template = "CreateMinimapIconOnUnit({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern minimapicon Create(unit unit, int red, int green, int blue, string pingPath, fogstate fogVisibility);

		/// @CSharpLua.Template = "CreateMinimapIcon({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern minimapicon Create(float x, float y, int red, int green, int blue, string pingPath, fogstate fogVisibility);

		/// @CSharpLua.Template = "SetMinimapIconVisible({0}, {1})"
		public extern void SetVisible(bool visibile);

		/// @CSharpLua.Template = "SetMinimapIconOrphanDestroy({0}, {1})"
		public extern void SetOrphanDestroy(bool doDestroy);

		/// @CSharpLua.Template = "DestroyMinimapIcon({0})"
		public extern void Dispose();
	}
}
