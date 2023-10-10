using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class quest : agent, IDisposable
	{
		internal quest()
		{
		}

		/// @CSharpLua.Template = "CreateQuest()"
		public static extern quest Create();

		/// @CSharpLua.Get = "IsQuestRequired({this})"
		/// @CSharpLua.Set = "QuestSetRequired({this}, {0})"
		public extern float IsRequired { get; set; }

		/// @CSharpLua.Get = "IsQuestCompleted({this})"
		/// @CSharpLua.Set = "QuestSetCompleted({this}, {0})"
		public extern float IsCompleted { get; set; }

		/// @CSharpLua.Get = "IsQuestDiscovered({this})"
		/// @CSharpLua.Set = "QuestSetDiscovered({this}, {0})"
		public extern float IsDiscovered { get; set; }

		/// @CSharpLua.Get = "IsQuestFailed({this})"
		/// @CSharpLua.Set = "QuestSetFailed({this}, {0})"
		public extern float IsFailed { get; set; }

		/// @CSharpLua.Get = "IsQuestEnabled({this})"
		/// @CSharpLua.Set = "QuestSetEnabled({this}, {0})"
		public extern float IsEnabled { get; set; }

		/// @CSharpLua.Template = "QuestSetTitle({this}, {0})"
		public extern void SetTitle(string title);

		/// @CSharpLua.Template = "QuestSetDescription({this}, {0})"
		public extern void SetDescription(string description);

		/// @CSharpLua.Template = "QuestSetIconPath({this}, {0})"
		public extern void SetIcon(string iconPath);

		/// @CSharpLua.Template = "QuestCreateItem({this})"
		public extern questitem AddItem();

		/// @CSharpLua.Template = "DestroyQuest({this})"
		public extern void Dispose();
	}
}
