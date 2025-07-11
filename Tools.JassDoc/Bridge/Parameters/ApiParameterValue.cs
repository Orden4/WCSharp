using WCSharp.IO.JassDoc.Output;

namespace Tools.JassDoc.Bridge.Parameters
{
	public class ApiParameterValue : IApiParameter
	{
		public required JassProperty JassProperty { get; init; }
		public required JassMethodParameter JassParameter { get; init; }

		public string Format()
		{
			return JassProperty.Name;
		}
	}
}
