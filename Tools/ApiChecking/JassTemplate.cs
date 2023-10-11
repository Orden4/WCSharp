using System.Collections.Generic;

namespace Tools.ApiChecking
{
	public class JassTemplate
	{
		public string Name { get; init; }
		public List<string> ArgumentTypes { get; init; }
		public string ReturnType { get; init; }
		public int Uses { get; set; }
	}
}
