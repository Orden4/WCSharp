using JassDocParsing.Output;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using WCSharp.JassDoc.Bridge.Parameters;

namespace WCSharp.JassDoc.Bridge.Properties
{
	public class ApiPropertyMethod : IApiPropertyPart
	{
		public CSharpSyntaxNode SyntaxNode => Parent.SyntaxNode;
		public ISymbol Symbol => Parent.Symbol;

		public required ApiProperty Parent { get; init; }
		public required JassMethod JassMethod { get; init; }
		public List<IApiParameter> Parameters { get; init; } = [];

		public string FormatNative()
		{
			return $"{JassMethod.Name}({string.Join(", ", Parameters.Select(x => x.Format()))})";
		}

		public string See()
		{
			return Parent.See();
		}
	}
}
