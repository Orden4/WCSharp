using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class HashTable
	{
		internal HashTable()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator hashtable(HashTable x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator HashTable(hashtable x);
	}
}
