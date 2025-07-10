namespace JassDocParsing.Output
{
	public class JassMethodParameter
	{
		public int Index { get; set; }
		public string Name { get; set; } = null!;
		public string Type { get; set; } = null!;
		public string? Description { get; set; }
	}
}
