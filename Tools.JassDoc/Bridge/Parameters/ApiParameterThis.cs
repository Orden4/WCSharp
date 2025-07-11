using WCSharp.IO.JassDoc.Output;

namespace Tools.JassDoc.Bridge.Parameters
{
	public class ApiParameterThis : IApiParameter
	{
		public required JassMethodParameter JassParameter { get; init; }

		public string Format()
		{
			return "{instance}";
		}
	}
}
