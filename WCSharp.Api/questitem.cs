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

		/// @CSharpLua.Get = "IsQuestItemCompleted({0})"
		/// @CSharpLua.Set = "QuestItemSetCompleted({0}, {1})"
		public extern float IsCompleted { get; set; }

		/// @CSharpLua.Template = "QuestItemSetDescription({0}, {1})"
		public extern void SetDescription(string description);
	}
}
