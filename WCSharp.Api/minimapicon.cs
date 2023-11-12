using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class minimapicon : handle, IDisposable
	{
		internal minimapicon()
		{
		}

		/// @CSharpLua.Template = "CreateMinimapIconOnUnit({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern minimapicon Create(unit unit, int red, int green, int blue, string pingPath, fogstate fogVisibility);

		/// @CSharpLua.Template = "CreateMinimapIcon({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern minimapicon Create(float x, float y, int red, int green, int blue, string pingPath, fogstate fogVisibility);

		/// @CSharpLua.Template = "SetMinimapIconVisible({this}, {0})"
		public extern void SetVisible(bool visible);

		/// @CSharpLua.Template = "SetMinimapIconOrphanDestroy({this}, {0})"
		public extern void SetOrphanDestroy(bool doDestroy);

		/// @CSharpLua.Template = "DestroyMinimapIcon({this})"
		public extern void Dispose();
	}
}
