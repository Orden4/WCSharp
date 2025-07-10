namespace JassDocParsing.Output
{
	public class JassProperty : JassEntity
	{
		public string Type { get; set; } = null!;
		public string? Value { get; set; }
		public bool IsArray { get; set; }
		public bool IsConstant { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
