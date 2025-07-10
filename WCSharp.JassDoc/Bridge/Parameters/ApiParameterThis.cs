using JassDocParsing.Output;

namespace WCSharp.JassDoc.Bridge.Parameters
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
