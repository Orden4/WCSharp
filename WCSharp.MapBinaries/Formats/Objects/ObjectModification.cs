namespace WCSharp.MapBinaries.Formats.Objects
{
	public class ObjectModification
	{
		public required string ModificationId { get; set; }
		public VariableType VariableType { get; set; }
		public uint LevelVariation { get; set; }
		public uint DataPointer { get; set; }
		public required object Value { get; set; }
	}
}
