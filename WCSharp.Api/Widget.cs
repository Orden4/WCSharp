namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Widget : Agent
	{
		internal Widget()
		{
		}

		/// @CSharpLua.Get = "GetWidgetLife({0})"
		/// @CSharpLua.Set = "SetWidgetLife({0}, {1})"
		public extern float Life { get; set; }

		/// @CSharpLua.Get = "GetWidgetX({0})"
		/// @CSharpLua.Set = "SetWidgetX({0}, {1})"
		public extern virtual float X { get; set; }

		/// @CSharpLua.Get = "GetWidgetY({0})"
		/// @CSharpLua.Set = "SetWidgetY({0}, {1})"
		public extern virtual float Y { get; set; }

		/// @CSharpLua.Template = "AddSpecialEffectTarget({1}, {0}, {2})"
		public extern Effect AddSpecialEffect(string model, string attachmentPoint);

		/// @CSharpLua.Template = "AddSpellEffectTarget({1}, {3}, {0}, {2})"
		public extern Effect AddSpellEffect(string model, string attachmentPoint, EffectType type);

		/// @CSharpLua.Template = "AddSpellEffectTargetById({1}, {3}, {0}, {2})"
		public extern Effect AddSpellEffect(int abilityId, string attachmentPoint, EffectType type);
	}
}
