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

		/// @CSharpLua.Get = "IsQuestRequired({0})"
		/// @CSharpLua.Set = "QuestSetRequired({0}, {1})"
		public extern float IsRequired { get; set; }

		/// @CSharpLua.Get = "IsQuestCompleted({0})"
		/// @CSharpLua.Set = "QuestSetCompleted({0}, {1})"
		public extern float IsCompleted { get; set; }

		/// @CSharpLua.Get = "IsQuestDiscovered({0})"
		/// @CSharpLua.Set = "QuestSetDiscovered({0}, {1})"
		public extern float IsDiscovered { get; set; }

		/// @CSharpLua.Get = "IsQuestFailed({0})"
		/// @CSharpLua.Set = "QuestSetFailed({0}, {1})"
		public extern float IsFailed { get; set; }

		/// @CSharpLua.Get = "IsQuestEnabled({0})"
		/// @CSharpLua.Set = "QuestSetEnabled({0}, {1})"
		public extern float IsEnabled { get; set; }

		/// @CSharpLua.Template = "QuestSetTitle({0}, {1})"
		public extern void SetTitle(string title);

		/// @CSharpLua.Template = "QuestSetDescription({0}, {1})"
		public extern void SetDescription(string description);

		/// @CSharpLua.Template = "QuestSetIconPath({0}, {1})"
		public extern void SetIcon(string iconPath);

		/// @CSharpLua.Template = "QuestCreateItem({0})"
		public extern questitem AddItem();

		/// @CSharpLua.Template = "DestroyQuest({0})"
		public extern void Dispose();
	}
}
