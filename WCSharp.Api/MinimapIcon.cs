using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class MinimapIcon : IDisposable
	{
		internal MinimapIcon()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator minimapicon(MinimapIcon x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator MinimapIcon(minimapicon x);

		/// @CSharpLua.Template = "CreateMinimapIconOnUnit({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern MinimapIcon Create(Unit unit, int red, int green, int blue, string pingPath, FogState fogVisibility);

		/// @CSharpLua.Template = "CreateMinimapIcon({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern MinimapIcon Create(float x, float y, int red, int green, int blue, string pingPath, FogState fogVisibility);

		/// @CSharpLua.Template = "SetMinimapIconVisible({0}, {1})"
		public extern void SetVisible(bool visibile);

		/// @CSharpLua.Template = "SetMinimapIconOrphanDestroy({0}, {1})"
		public extern void SetOrphanDestroy(bool doDestroy);

		/// @CSharpLua.Template = "DestroyMinimapIcon({0})"
		public extern void Dispose();
	}
}
