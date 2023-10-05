namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class widget : agent
	{
		internal widget()
		{
		}

		/// @CSharpLua.Get = "GetWidgetLife({0})"
		/// @CSharpLua.Set = "SetWidgetLife({0}, {1})"
		public extern float Life { get; set; }

		/// @CSharpLua.Template = "AddSpecialEffectTarget({1}, {0}, {2})"
		public extern effect AddSpecialEffect(string model, string attachmentPoint);

		/// @CSharpLua.Template = "AddSpellEffectTarget({1}, {3}, {0}, {2})"
		public extern effect AddSpellEffect(string model, string attachmentPoint, effecttype type);

		/// @CSharpLua.Template = "AddSpellEffectTargetById({1}, {3}, {0}, {2})"
		public extern effect AddSpellEffect(int abilityId, string attachmentPoint, effecttype type);

		/// @CSharpLua.Template = "AddIndicator({0}, {1}, {2}, {3}, {4})"
		public extern effect AddIndicator(int red, int green, int blue, int alpha = 255);
	}
}
