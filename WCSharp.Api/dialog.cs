using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class dialog : agent, IDisposable
	{
		internal dialog()
		{
		}

		/// @CSharpLua.Template = "DialogCreate({0})"
		public static extern void Create();

		/// @CSharpLua.Template = "DialogClear({this})"
		public extern void Clear();
		/// @CSharpLua.Template = "DialogSetMessage({this})"
		public extern void SetMessage(string message);
		/// @CSharpLua.Template = "DialogAddButton({this}, {0}, {1})"
		public extern button AddButton(string buttonText, int hotkey);
		/// @CSharpLua.Template = "DialogAddQuitButton({this}, {2}, {0}, {1})"
		public extern button AddQuitButton(string buttonText, int hotkey, bool doScoreScreen);
		/// @CSharpLua.Template = "DialogDisplay({0}, {this}, {1})"
		public extern void SetVisibility(player player, bool visibility);

		/// @CSharpLua.Template = "DialogDestroy({this})"
		public extern void Dispose();
	}
}
