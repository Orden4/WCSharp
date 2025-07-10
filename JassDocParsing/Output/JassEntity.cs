namespace JassDocParsing.Output
{
	public class JassEntity
	{
		public string SourceFile { get; set; } = null!;
		public string Name { get; set; } = null!;
		public string? Description { get; set; }
		public string Source { get; set; } = null!;
		public string Patch { get; set; } = null!;
		public List<string> Bugs { get; set; } = [];
		public List<string> Notes { get; set; } = [];
	}
}
