using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class texttag : handle, IDisposable
	{
		internal texttag()
		{
		}

		/// @CSharpLua.Template = "CreateTextTag()"
		public static extern texttag Create();

		/// @CSharpLua.Template = "SetTextTagText({this}, {0}, {1})"
		public extern void SetText(string text, float height);
		/// @CSharpLua.Template = "SetTextTagPos({this}, {0}, {1}, {2})"
		public extern void SetPosition(float x, float y, float heightOffset);
		/// @CSharpLua.Template = "SetTextTagPosUnit({this}, {0}, {1})"
		public extern void SetPosition(unit unit, float heightOffset);
		/// @CSharpLua.Template = "SetTextTagColor({this}, {0}, {1}, {2}, {3})"
		public extern void SetColor(int red, int green, int blue, int alpha = 255);
		/// @CSharpLua.Template = "SetTextTagVelocity({this}, {0}, {1})"
		public extern void SetVelocity(float xVelocity, float yVelocity);
		/// @CSharpLua.Template = "SetTextTagVisibility({this}, {0})"
		public extern void SetVisibility(bool visible);
		/// @CSharpLua.Template = "SetTextTagSuspended({this}, {0})"
		public extern void SetSuspended(bool suspend);
		/// @CSharpLua.Template = "SetTextTagPermanent({this}, {0})"
		public extern void SetPermanent(bool permanent);
		/// @CSharpLua.Template = "SetTextTagAge({this}, {0})"
		public extern void SetAge(float age);
		/// @CSharpLua.Template = "SetTextTagLifespan({this}, {0})"
		public extern void SetLifespan(float lifespan);
		/// @CSharpLua.Template = "SetTextTagFadepoint({this}, {0})"
		public extern void SetFadepoint(float fadepoint);

		/// @CSharpLua.Template = "DestroyTextTag({this})"
		public extern void Dispose();
	}
}
