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
				name = name.ToUpper();
				var suffix = Suffix;
				if (!string.IsNullOrEmpty(suffix))
				{
					suffix = "_" + suffix;
				}

				return $"{Type}_{Code}_{name}{suffix}".Escape().ToUpper() + $" = {NumberCode}";
			}
		}
	}
}
