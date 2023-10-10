using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class effect : agent, IDisposable
	{
		internal effect()
		{
		}

		/// @CSharpLua.Template = "AddSpecialEffect({0}, {1}, {2})"
		public static extern effect Create(float x, float y);
		/// @CSharpLua.Template = "AddSpellEffectById({2}, {3}, {0}, {1})"
		public static extern effect Create(float x, float y, int abilityId, effecttype effectType);
		/// @CSharpLua.Template = "AddSpellEffect({2}, {3}, {0}, {1})"
		public static extern effect Create(float x, float y, string abilityString, effecttype effectType);
		/// @CSharpLua.Template = "AddSpecialEffectTarget({0}, {1}, {2})"
		public static extern effect Create(widget target, string attachmentPoint);
		/// @CSharpLua.Template = "AddSpellEffectTargetById({2}, {3}, {0}, {1})"
		public static extern effect Create(widget target, string attachmentPoint, int abilityId, effecttype effectType);
		/// @CSharpLua.Template = "AddSpellEffectTarget({2}, {3}, {0}, {1})"
		public static extern effect Create(widget target, string attachmentPoint, string abilityString, effecttype effectType);

		/// @CSharpLua.Get = "BlzGetSpecialEffectScale({this})"
		/// @CSharpLua.Set = "BlzSetSpecialEffectScale({this}, {0})"
		public extern float Scale { get; set; }

		/// @CSharpLua.Get = "BlzGetLocalSpecialEffectX({this})"
		public extern float LocalX { get; }

		/// @CSharpLua.Get = "BlzGetLocalSpecialEffectY({this})"
		public extern float LocalY { get; }

		/// @CSharpLua.Get = "BlzGetLocalSpecialEffectZ({this})"
		public extern float LocalZ { get; }

		/// @CSharpLua.Template = "BlzSetSpecialEffectColorByPlayer({this}, {0})"
		public extern void SetColor(player player);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({this}, {0}, {1}, {2})"
		public extern void SetColor(int red, int green, int blue);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({this}, {0})"
		public extern void SetAlpha(int alpha);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({this}, {0}, {1}, {2})"
		public extern void SetPosition(float x, float y, float z);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({this}, {0})"
		public extern void SetHeight(float height);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({this}, {0})"
		public extern void SetTimeScale(float timeScale);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({this}, {0})"
		public extern void SetTime(float time);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({this}, {0}, {1}, {2})"
		public extern void SetOrientation(float yaw, float pitch, float roll);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({this}, {0})"
		public extern void SetYaw(float yaw);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({this}, {0})"
		public extern void SetPitch(float pitch);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({this}, {0})"
		public extern void SetRoll(float roll);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({this}, {0})"
		public extern void SetX(float x);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({this}, {0})"
		public extern void SetY(float y);
		/// @CSharpLua.Template = "BlzSetSpecialEffectScale({this}, {0})"
		public extern void SetZ(float z);
		/// @CSharpLua.Template = "BlzSpecialEffectClearSubAnimations({this})"
		public extern void ClearSubAnimations();
		/// @CSharpLua.Template = "BlzSpecialEffectRemoveSubAnimation({this}, {0})"
		public extern void RemoveSubAnimation(subanimtype subAnimType);
		/// @CSharpLua.Template = "BlzSpecialEffectAddSubAnimation({this}, {0})"
		public extern void AddSubAnimation(subanimtype subAnimType);
		/// @CSharpLua.Template = "BlzPlaySpecialEffect({this}, {0})"
		public extern void PlayAnimation(animtype animType);
		/// @CSharpLua.Template = "BlzPlaySpecialEffectWithTimeScale({this}, {0}, {1})"
		public extern void PlayAnimation(animtype animType, float timeScale);
		/// @CSharpLua.Template = "DestroyEffect({this})"
		public extern void Dispose();
	}
}
