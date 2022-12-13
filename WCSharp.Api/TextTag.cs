using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class TextTag : IDisposable
	{
		internal TextTag()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator texttag(TextTag x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator TextTag(texttag x);

		/// @CSharpLua.Template = "CreateTextTag()"
		public static extern TextTag Create();

		/// @CSharpLua.Template = "SetTextTagText({0}, {1}, {2})"
		public extern void SetText(string text, float height);
		/// @CSharpLua.Template = "SetTextTagPos({0}, {1}, {2}, {3})"
		public extern void SetPosition(float x, float y, float heightOffset);
		/// @CSharpLua.Template = "SetTextTagPosUnit({0}, {2}, {3})"
		public extern void SetPositionUnit(Unit unit, float heightOffset);
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
