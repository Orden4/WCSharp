using System.Globalization;
using System.Text;
using WCSharp.ConstantGenerator.Extensions;

namespace WCSharp.ConstantGenerator
{
	internal class Thing
	{
		public Type Type { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public string Identifier { get; set; }
		public string Suffix { get; set; }

		public int NumberCode => FourCC.Decode(Code);

		public override string ToString()
		{
			if (Type == Type.ADDITIONAL)
			{
				return $"{Identifier} = {Code}";
			}
			else
			{
				var name = Name ?? Identifier;
				var suffix = Suffix;
				if (!string.IsNullOrEmpty(suffix))
				{
					suffix = "_" + suffix;
				}

				var sb = new StringBuilder();
				sb.Append(Type);
				if (ConstantGenerator.Options.IncludeCode)
				{
					sb.Append("_" + Code);
				}
				sb.Append($"_{name}{suffix}");

				return $"{sb.ToString().ToUpper(CultureInfo.InvariantCulture).Escape()} = {NumberCode}";
			}
		}
	}
}
