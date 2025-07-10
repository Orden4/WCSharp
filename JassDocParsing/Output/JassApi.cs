using System.Text.Json.Serialization;

namespace JassDocParsing.Output
{
	public class JassApi
	{
		[JsonIgnore]
		public IEnumerable<JassEntity> Entities => Methods.AsEnumerable<JassEntity>().Concat(Properties).Concat(Types);

		public List<JassType> Types { get; set; } = [];
		public List<JassMethod> Methods { get; set; } = [];
		public List<JassProperty> Properties { get; set; } = [];

		public void Merge(JassApi other)
		{
			Types.AddRange(other.Types);
			Methods.AddRange(other.Methods);
			Properties.AddRange(other.Properties);
		}
	}
}
