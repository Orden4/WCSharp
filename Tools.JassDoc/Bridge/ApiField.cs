using WCSharp.IO.JassDoc.Output;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Tools.JassDoc.Bridge
{
	public class ApiField : IApiEntity
	{
		public ISymbol Symbol => Field;

		public required CSharpSyntaxNode SyntaxNode { get; init; }
		public required IFieldSymbol Field { get; init; }
		public required JassProperty JassProperty { get; init; }

		public string FormatNative()
		{
			return JassProperty.Name;
		}

		public string See()
		{
			return Field.ToString()!;
		}
	}
}
