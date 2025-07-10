using JassDocParsing.Output;

namespace WCSharp.JassDoc.Bridge.Parameters
{
	public interface IApiParameter
	{
		JassMethodParameter JassParameter { get; }

		string Format();
	}
}
