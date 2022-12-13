using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class QuestItem : Agent
	{
		internal QuestItem()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator questitem(QuestItem x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator QuestItem(questitem x);

		/// @CSharpLua.Template = "QuestCreateItem({0})"
		public static extern QuestItem Create(Quest quest);

		/// @CSharpLua.Get = "IsQuestItemCompleted({0})"
		/// @CSharpLua.Set = "QuestItemSetCompleted({0}, {1})"
		public extern float IsCompleted { get; set; }

		/// @CSharpLua.Template = "QuestItemSetDescription({0}, {1})"
		public extern void SetDescription(string description);
	}
}
