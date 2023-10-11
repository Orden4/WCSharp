using System.Collections.Generic;

namespace Tools.ApiChecking
{
	public class LuaTemplate
	{
		public string Text { get; init; }
		public string Name { get; init; }
		public List<LuaArgument> Arguments { get; init; }
	}
}
