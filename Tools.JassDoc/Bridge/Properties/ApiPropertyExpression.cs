using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Tools.JassDoc.Bridge.Properties
{
	public class ApiPropertyExpression : IApiPropertyPart
	{
		public CSharpSyntaxNode SyntaxNode => Parent.SyntaxNode;
		public ISymbol Symbol => Parent.Symbol;

		public required ApiProperty Parent { get; init; }
		public required string Expression { get; init; }

		public string FormatNative()
		{
			return Expression;
		}

		public string See()
		{
			return Parent.See();
		}
	}
}
