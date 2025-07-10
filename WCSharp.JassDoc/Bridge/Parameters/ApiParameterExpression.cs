using JassDocParsing.Output;

namespace WCSharp.JassDoc.Bridge.Parameters
{
	public class ApiParameterExpression : IApiParameter
	{
		public required string Expression { get; init; }
		public required JassMethodParameter JassParameter { get; init; }

		public string Format()
		{
			return Expression;
		}
	}
}
