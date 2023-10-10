namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class widget : agent
	{
		internal widget()
		{
		}

		/// @CSharpLua.Get = "GetWidgetLife({this})"
		/// @CSharpLua.Set = "SetWidgetLife({this}, {0})"
		public extern float Life { get; set; }

		/// @CSharpLua.Template = "AddSpecialEffectTarget({0}, {this}, {1})"
		public extern effect AddSpecialEffect(string model, string attachmentPoint);

		/// @CSharpLua.Template = "AddSpellEffectTarget({0}, {2}, {this}, {1})"
		public extern effect AddSpellEffect(string model, string attachmentPoint, effecttype type);

		/// @CSharpLua.Template = "AddSpellEffectTargetById({0}, {2}, {this}, {1})"
		public extern effect AddSpellEffect(int abilityId, string attachmentPoint, effecttype type);

		/// @CSharpLua.Template = "AddIndicator({this}, {0}, {1}, {2}, {3})"
		public extern effect AddIndicator(int red, int green, int blue, int alpha = 255);
	}
}
