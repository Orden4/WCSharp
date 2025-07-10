using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace WCSharp.JassDoc.Bridge
{
	public interface IApiEntity
	{
		CSharpSyntaxNode SyntaxNode { get; }
		ISymbol Symbol { get; }

		string FormatNative();
		string See();
	}
}
