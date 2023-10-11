namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class questitem : agent
	{
		internal questitem()
		{
		}

		/// @CSharpLua.Template = "QuestCreateItem({0})"
		public static extern questitem Create(quest quest);

		/// @CSharpLua.Get = "IsQuestItemCompleted({this})"
		/// @CSharpLua.Set = "QuestItemSetCompleted({this}, {0})"
		public extern bool IsCompleted { get; set; }

		/// @CSharpLua.Template = "QuestItemSetDescription({this}, {0})"
		public extern void SetDescription(string description);
	}
}
