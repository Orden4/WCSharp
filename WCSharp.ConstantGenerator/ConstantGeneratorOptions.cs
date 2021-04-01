namespace WCSharp.ConstantGenerator
{
	/// <summary>
	/// Defines a set of optional parameters for constant generation.
	/// </summary>
	public class ConstantGeneratorOptions
	{
		/// <summary>
		/// Whether to include the FourCC code in the name of constants outputted.
		/// <para>Example: 'ABILITY_A001_FIREBALL' if true, or 'ABILITY_FIREBALL' if false.</para>
		/// <para>Defaults to false.</para>
		/// </summary>
		public bool IncludeCode { get; set; }
	}
}
