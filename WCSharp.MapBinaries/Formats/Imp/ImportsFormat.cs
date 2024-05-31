namespace WCSharp.MapBinaries.Formats.Imp
{
	public class ImportsFormat
	{
		public int Version { get; set; }
		public List<Import> Imports { get; } = new();
	}
}
