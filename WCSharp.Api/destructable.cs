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
		public static extern destructable Create(int typeId, float x, float y, float z, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);
		/// @CSharpLua.Template = "BlzCreateDestructableWithSkin({0}, {1}, {2}, {4}, {5}, {6}, {3})"
		public static extern destructable Create(int typeId, float x, float y, int skin, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);
		/// @CSharpLua.Template = "BlzCreateDestructableZWithSkin({0}, {1}, {2}, {3}, {5}, {6}, {7}, {4})"
		public static extern destructable Create(int typeId, float x, float y, float z, int skin, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);
		/// @CSharpLua.Template = "CreateDeadDestructable({0}, {1}, {2}, {3}, {4}, {5})"
		public static extern destructable CreateDead(int typeId, float x, float y, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);
		/// @CSharpLua.Template = "CreateDeadDestructableZ({0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern destructable CreateDead(int typeId, float x, float y, float z, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);
		/// @CSharpLua.Template = "BlzCreateDeadDestructableWithSkin({0}, {1}, {2}, {4}, {5}, {6}, {3})"
		public static extern destructable CreateDead(int typeId, float x, float y, int skin, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);
		/// @CSharpLua.Template = "BlzCreateDeadDestructableZWithSkin({0}, {1}, {2}, {3}, {5}, {6}, {7}, {4})"
		public static extern destructable CreateDead(int typeId, float x, float y, float z, int skin, float facing = Blizzard.bj_UNIT_FACING, float scale = 1.0f, int variation = 0);

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

		/// @CSharpLua.Template = "DestructableRestoreLife({0}, {1}, {2})"
		public extern void RestoreLife(float life, bool birth);
		/// @CSharpLua.Template = "QueueDestructableAnimation({0}, {1})"
		public extern void QueueAnimation(string animation);
		/// @CSharpLua.Template = "SetDestructableAnimation({0}, {1})"
		public extern void SetAnimation(string animation);
		/// @CSharpLua.Template = "SetDestructableAnimationSpeed({0}, {1})"
		public extern void SetAnimationSpeed(float speedFactor);
		/// @CSharpLua.Template = "ShowDestructable({0}, {1})"
		public extern void SetVisibility(bool visibility);
		/// @CSharpLua.Template = "KillDestructable({0})"
		public extern void Kill();
		/// @CSharpLua.Template = "RemoveDestructable({0})"
		public extern void Dispose();
	}
}
