using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class fogmodifier : agent, IDisposable
	{
		internal fogmodifier()
		{
		}

		/// @CSharpLua.Template = "CreateFogModifierRect({1}, {2}, {0}, {3}, {4})"
		public static extern fogmodifier Create(rect target, player player, fogstate state, bool useSharedVision, bool afterUnits);
		/// @CSharpLua.Template = "CreateFogModifierRadius({3}, {4}, {0}, {1}, {2}, {5}, {6})"
		public static extern fogmodifier Create(float x, float y, float radius, player player, fogstate state, bool useSharedVision, bool afterUnits);

		/// @CSharpLua.Template = "FogModifierStart({0})"
		public extern void Start();
		/// @CSharpLua.Template = "FogModifierStop({0})"
		public extern void Stop();
		/// @CSharpLua.Template = "DestroyFogModifier({0})"
		public extern void Dispose();
	}
}
