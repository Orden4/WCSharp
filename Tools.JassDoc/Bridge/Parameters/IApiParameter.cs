using WCSharp.IO.JassDoc.Output;

namespace Tools.JassDoc.Bridge.Parameters
{
	public interface IApiParameter
	{
		JassMethodParameter JassParameter { get; }

		string Format();
	}
}
