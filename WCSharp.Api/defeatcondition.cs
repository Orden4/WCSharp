using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class defeatcondition : agent, IDisposable
	{
		internal defeatcondition()
		{
		}

		/// @CSharpLua.Template = "CreateDefeatCondition()"
		public static extern defeatcondition Create();

		/// @CSharpLua.Template = "DefeatConditionSetDescription({this}, {0})"
		public extern void SetDescription(string description);

		/// @CSharpLua.Template = "DestroyDefeatCondition({this})"
		public extern void Dispose();
	}
}
