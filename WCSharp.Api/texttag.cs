using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class texttag : IDisposable
	{
		internal texttag()
		{
		}

		/// @CSharpLua.Template = "CreateTextTag()"
		public static extern texttag Create();

		/// @CSharpLua.Template = "SetTextTagText({0}, {1}, {2})"
		public extern void SetText(string text, float height);
		/// @CSharpLua.Template = "SetTextTagPos({0}, {1}, {2}, {3})"
		public extern void SetPosition(float x, float y, float heightOffset);
		/// @CSharpLua.Template = "SetTextTagPosUnit({0}, {2}, {3})"
		public extern void SetPositionUnit(unit unit, float heightOffset);
		/// @CSharpLua.Template = "SetTextTagColor({0}, {1}, {2}, {3}, {4})"
		public extern void SetColor(int red, int green, int blue, int alpha = 255);
		/// @CSharpLua.Template = "SetTextTagVelocity({0}, {1}, {2})"
		public extern void SetVelocity(float xVelocity, float yVelocity);
		/// @CSharpLua.Template = "SetTextTagVisibility({0}, {1})"
		public extern void SetVisibility(bool visible);
		/// @CSharpLua.Template = "SetTextTagSuspended({0}, {1})"
		public extern void SetSuspended(bool suspend);
		/// @CSharpLua.Template = "SetTextTagPermanent({0}, {1})"
		public extern void SetPermanent(bool permanent);
		/// @CSharpLua.Template = "SetTextTagAge({0}, {1})"
		public extern void SetAge(float age);
		/// @CSharpLua.Template = "SetTextTagLifespan({0}, {1})"
		public extern void SetLifespan(float lifespan);
		/// @CSharpLua.Template = "SetTextTagFadepoint({0}, {1})"
		public extern void SetFadepoint(float fadepoint);

		/// @CSharpLua.Template = "DestroyTextTag({0})"
		public extern void Dispose();
	}
}
