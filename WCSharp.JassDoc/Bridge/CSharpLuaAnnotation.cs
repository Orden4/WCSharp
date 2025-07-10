namespace WCSharp.JassDoc.Bridge
{
	public class CSharpLuaAnnotation
	{
		public CSharpLuaAnnotationKind Kind { get; init; }
		public required string KindValue { get; init; }
		public string? Value { get; init; }

		public override string ToString()
		{
			var value = "";
			if (Value != null)
			{
				value = $" = \"{Value}\"";
			}
			return $"@CSharpLua.{KindValue}{value}";
		}
	}
}
