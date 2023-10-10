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

		/// @CSharpLua.Template = "DialogClear({0})"
		public extern void Clear();
		/// @CSharpLua.Template = "DialogSetMessage({0})"
		public extern void SetMessage(string message);
		/// @CSharpLua.Template = "DialogAddButton({0}, {1}, {2})"
		public extern button AddButton(string buttonText, int hotkey);
		/// @CSharpLua.Template = "DialogAddQuitButton({0}, {3}, {1}, {2})"
		public extern button AddQuitButton(string buttonText, int hotkey, bool doScoreScreen);
		/// @CSharpLua.Template = "DialogDisplay({1}, {0}, {2})"
		public extern void SetVisibility(player player, bool visibility);

		/// @CSharpLua.Template = "DialogDestroy({0})"
		public extern void Dispose();
	}
}
