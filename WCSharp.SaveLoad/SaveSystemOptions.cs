using System.Collections.Generic;
using WCSharp.Shared;

namespace WCSharp.SaveLoad
{
	/// <summary>
	/// Defines a set of options for a <see cref="SaveSystem{T}"/>.
	/// <para>The <see cref="SaveFolder"/>, <see cref="Salt"/>, <see cref="Hash1"/> and <see cref="Hash2"/> properties are required.</para>
	/// </summary>
	public class SaveSystemOptions
	{
		/// <summary>
		/// May not be empty. The folder in which to store the saves.
		/// </summary>
		public string SaveFolder { get; set; }

		/// <summary>
		/// May not be empty. The salt to use on the string. You can just type something random, or generate something with <see href="https://www.random.org/strings/"/>.
		/// <para>You may use any length of salt, but around 16 is sufficient.</para>
		/// <para>This should never be changed after release of a map, as changing it will invalidate all existing save files.</para>
		/// </summary>
		public string Salt { get; set; }

		/// <summary>
		/// Must be greater than 0. It is recommended to simply pick any prime number from <see href="http://www.mathematical.com/primes0to1000k.html"/> or a similar site.
		/// <para>This should never be changed after release of a map, as changing it will invalidate all existing save files.</para>
		/// </summary>
		public int Hash1 { get; set; }

		/// <summary>
		/// Must be greater than 0. It is recommended to simply pick any prime number from <see href="http://www.mathematical.com/primes0to1000k.html"/> or a similar site.
		/// <para>This should never be changed after release of a map, as changing it will invalidate all existing save files.</para>
		/// </summary>
		public int Hash2 { get; set; }

		/// <summary>
		/// Whether saves are bound to the name of the player. If true, saves will have the player name contained in the filename,
		/// and upon loading this will be matched with the current player's name.
		/// <para>Attempting to load a save tied to a different username will result in a new save file being created instead.</para>
		/// <para>This should never be changed after release of a map, as changing it will invalidate all existing save files.</para>
		/// </summary>
		public bool BindSavesToPlayerName { get; set; }

		/// <summary>
		/// Optional. The given string will be added to the filename of any save stored.
		/// </summary>
		public string Suffix { get; set; }

		/// <summary>
		/// Optional. The save is encoded in Base64, if you want, you can provide a custom Base64 provider to effectively scramble the save.
		/// <para>This does not change much in terms of protection, but makes it harder for people to inspect save files.</para>
		/// <para>This should never be changed after release of a map, as changing it will invalidate all existing save files.</para>
		/// </summary>
		public Base64 Base64Provider { get; set; }

		/// <summary>
		/// Optional. By default, you have 5000 characters to use as storage. If you approach that limit, you can use this to expand the amount of storage space.
		/// <para>By default, the following ability ids are included:</para>
		/// <para>Amls, Ahan, Aroc, Amic, Amil, Aclf, Acmg, Adef, Adis, Afbt</para>
		/// </summary>
		public IEnumerable<int> AdditionalAbilityIds { get; set; }
	}
}
