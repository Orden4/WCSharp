using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class destructable : widget, IDisposable
	{
		internal destructable()
		{
		}

		/// @CSharpLua.Get = "GetWidgetX({0})"
		public extern float X { get; }

		/// @CSharpLua.Get = "GetWidgetY({0})"
		public extern float Y { get; }

		/// @CSharpLua.Get = "GetDestructableMaxLife({0})"
		/// @CSharpLua.Set = "SetDestructableMaxLife({0}, {1})"
		public extern float MaxLife { get; set; }

		/// @CSharpLua.Get = "IsDestructableInvulnerable({0})"
		/// @CSharpLua.Set = "SetDestructableInvulnerable({0}, {1})"
		public extern bool IsInvulnerable { get; set; }

		/// @CSharpLua.Get = "GetDestructableTypeId({0})"
		public extern int Type { get; }

		/// @CSharpLua.Get = "GetDestructableName({0})"
		public extern string Name { get; }

		/// @CSharpLua.Get = "GetDestructableOccluderHeight({0})"
		/// @CSharpLua.Set = "SetDestructableOccluderHeight({0}, {1})"
		public extern float OccluderHeight { get; }

		/// @CSharpLua.Get = "BlzGetDestructableSkin({0})"
		/// @CSharpLua.Set = "BlzSetDestructableSkin({0}, {1})"
		public extern int Skin { get; set; }

		/// @CSharpLua.Template = "RemoveDestructable({0})"
		public extern void Dispose();
	}
}
