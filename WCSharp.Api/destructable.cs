using System;

namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class destructable : widget, IDisposable
	{
		internal destructable()
		{
		}

		/// @CSharpLua.Template = "CreateDestructable({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern destructable Create(int typeId, float x, float y, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);
		/// @CSharpLua.Template = "CreateDestructableZ({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern destructable CreateZ(int typeId, float x, float y, float z, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);
		/// @CSharpLua.Template = "BlzCreateDestructableWithSkin({0}, {1}, {2}, {4}, {5}, {6}, {3})"
		public static extern destructable CreateWithSkin(int typeId, float x, float y, int skin, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);
		/// @CSharpLua.Template = "BlzCreateDestructableZWithSkin({0}, {1}, {2}, {3}, {5}, {6}, {7}, {4})"
		public static extern destructable CreateZWithSkin(int typeId, float x, float y, float z, int skin, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);
		/// @CSharpLua.Template = "CreateDeadDestructable({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern destructable CreateDead(int typeId, float x, float y, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);
		/// @CSharpLua.Template = "CreateDeadDestructableZ({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern destructable CreateDeadZ(int typeId, float x, float y, float z, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);
		/// @CSharpLua.Template = "BlzCreateDeadDestructableWithSkin({0}, {1}, {2}, {4}, {5}, {6}, {3})"
		public static extern destructable CreateDeadWithSkin(int typeId, float x, float y, int skin, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);
		/// @CSharpLua.Template = "BlzCreateDeadDestructableZWithSkin({0}, {1}, {2}, {3}, {5}, {6}, {7}, {4})"
		public static extern destructable CreateDeadZWithSkin(int typeId, float x, float y, float z, int skin, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);

		/// @CSharpLua.Get = "GetWidgetX({this})"
		public extern float X { get; }

		/// @CSharpLua.Get = "GetWidgetY({this})"
		public extern float Y { get; }

		/// @CSharpLua.Get = "GetDestructableMaxLife({this})"
		/// @CSharpLua.Set = "SetDestructableMaxLife({this}, {0})"
		public extern float MaxLife { get; set; }

		/// @CSharpLua.Get = "IsDestructableInvulnerable({this})"
		/// @CSharpLua.Set = "SetDestructableInvulnerable({this}, {0})"
		public extern bool IsInvulnerable { get; set; }

		/// @CSharpLua.Get = "GetDestructableTypeId({this})"
		public extern int Type { get; }

		/// @CSharpLua.Get = "GetDestructableName({this})"
		public extern string Name { get; }

		/// @CSharpLua.Get = "GetDestructableOccluderHeight({this})"
		/// @CSharpLua.Set = "SetDestructableOccluderHeight({this}, {0})"
		public extern float OccluderHeight { get; }

		/// @CSharpLua.Get = "BlzGetDestructableSkin({this})"
		/// @CSharpLua.Set = "BlzSetDestructableSkin({this}, {0})"
		public extern int Skin { get; set; }

		/// @CSharpLua.Template = "DestructableRestoreLife({this}, {0}, {1})"
		public extern void RestoreLife(float life, bool birth);
		/// @CSharpLua.Template = "QueueDestructableAnimation({this}, {0})"
		public extern void QueueAnimation(string animation);
		/// @CSharpLua.Template = "SetDestructableAnimation({this}, {0})"
		public extern void SetAnimation(string animation);
		/// @CSharpLua.Template = "SetDestructableAnimationSpeed({this}, {0})"
		public extern void SetAnimationSpeed(float speedFactor);
		/// @CSharpLua.Template = "ShowDestructable({this}, {0})"
		public extern void SetVisibility(bool visibility);
		/// @CSharpLua.Template = "KillDestructable({this})"
		public extern void Kill();
		/// @CSharpLua.Template = "RemoveDestructable({this})"
		public extern void Dispose();
	}
}
