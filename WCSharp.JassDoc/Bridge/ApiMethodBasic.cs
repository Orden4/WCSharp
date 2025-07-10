using JassDocParsing.Output;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using WCSharp.JassDoc.Bridge.Parameters;

namespace WCSharp.JassDoc.Bridge
{
	public class ApiMethodBasic : IApiEntity
	{
		public ISymbol Symbol => Method;
		public bool IsConstructor => Method.ContainingType.Name == Method.Name;

		public required CSharpSyntaxNode SyntaxNode { get; init; }
		public required IMethodSymbol Method { get; init; }
		public required JassMethod JassMethod { get; init; }
		public List<IApiParameter> Parameters { get; init; } = [];

		public string FormatNative()
		{
			return $"{JassMethod.Name}({string.Join(", ", Parameters.Select(x => x.Format()))})";
		}

		public string See()
		{
			return Method.ToString()!;
		}
	}
}
