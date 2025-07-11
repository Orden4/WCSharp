using WCSharp.IO.JassDoc.Output;

namespace Tools.JassDoc.Bridge.Parameters
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
