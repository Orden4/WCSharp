using JassDocParsing.Output;
using Microsoft.CodeAnalysis;

namespace WCSharp.JassDoc.Bridge.Parameters
{
	public class ApiParameterSymbol : IApiParameter
	{
		public required ISymbol Parameter { get; init; }
		public required JassMethodParameter JassParameter { get; init; }
		public int Ordinal => Parameter is IParameterSymbol parameterSymbol ? parameterSymbol.Ordinal : 0;

		public string Format()
		{
			if (Parameter is IPropertySymbol)
			{
				return "{value}";
			}
			else
			{
				return Parameter.Name;
			}
		}
	}
}
