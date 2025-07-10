using JassDocParsing.Output;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace WCSharp.JassDoc.Bridge.Properties
{
	public class ApiPropertyValue : IApiPropertyPart
	{
		public CSharpSyntaxNode SyntaxNode => Parent.SyntaxNode;
		public ISymbol Symbol => Parent.Symbol;

		public required ApiProperty Parent { get; init; }
		public required JassProperty JassProperty { get; init; }

		public string FormatNative()
		{
			return JassProperty.Name;
		}

		public string See()
		{
			return Parent.See();
		}
	}
}
