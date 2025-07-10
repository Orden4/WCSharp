namespace JassDocParsing.Output
{
	public class JassType : JassEntity
	{
		public string? Extends { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
