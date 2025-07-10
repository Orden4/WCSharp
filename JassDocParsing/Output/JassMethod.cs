namespace JassDocParsing.Output
{
	public class JassMethod : JassEntity
	{
		public string ReturnType { get; set; } = null!;
		public List<string> Events { get; set; } = [];
		public List<JassMethodParameter> Parameters { get; set; } = [];
		public bool IsPure { get; set; }
		public bool IsAsync { get; set; }
		public bool IsConstant { get; set; }

		public override string ToString()
		{
			return $"{Name}({string.Join(", ", Parameters.Select(x => x.Name))})";
		}
	}
}
