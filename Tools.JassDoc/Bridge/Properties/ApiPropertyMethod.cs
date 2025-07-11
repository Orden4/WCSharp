using WCSharp.IO.JassDoc.Output;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Tools.JassDoc.Bridge.Parameters;

namespace Tools.JassDoc.Bridge.Properties
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
