using WCSharp.IO.JassDoc.Output;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Tools.JassDoc.Bridge
{
	public class ApiType : IApiEntity
	{
		public ISymbol Symbol => Type;

		public required CSharpSyntaxNode SyntaxNode { get; init; }
		public required INamedTypeSymbol Type { get; init; }
		public required JassType JassType { get; init; }

		string IApiEntity.FormatNative()
		{
			throw new NotImplementedException();
		}

		public string See()
		{
			return Type.ToString()!;
		}
	}
}
