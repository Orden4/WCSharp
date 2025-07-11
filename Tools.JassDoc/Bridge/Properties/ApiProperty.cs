using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Tools.JassDoc.Bridge;

namespace Tools.JassDoc.Bridge.Properties
{
	public class ApiProperty : IApiEntity
	{
		public ISymbol Symbol => Property;

		public required CSharpSyntaxNode SyntaxNode { get; init; }
		public required IPropertySymbol Property { get; init; }
		public IApiPropertyPart Get { get; set; } = null!;
		public IApiPropertyPart? Set { get; set; }

		string IApiEntity.FormatNative()
		{
			throw new NotImplementedException();
		}

		public string See()
		{
			return Property.ToString()!;
		}
	}
}
