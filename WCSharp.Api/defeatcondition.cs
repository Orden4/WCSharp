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
		public extern defeatcondition Create();

		/// @CSharpLua.Template = "DefeatConditionSetDescription({0})"
		public extern string SetDescription(string description);

		/// @CSharpLua.Template = "DestroyDefeatCondition({0})"
		public extern void Dispose();
	}
}
