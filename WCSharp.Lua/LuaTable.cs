using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace WCSharp.Lua
{
	/// <summary>
	/// Represents a table in Lua in a way that is easier to work with from C#.
	/// </summary>
	/// Unfortunately this can't just extend <see cref="Dictionary{TKey, TValue}"/> because
	/// adding properties/fields messes with the enumeration after transpilation to Lua.
	public class LuaTable : IDictionary<object, object>
	{
		private readonly Dictionary<object, object> dict;

		/// <summary>
		/// The actual Lua table that this dictionary is mapping.
		/// </summary>
		public object Lua { get; set; }
		/// <inheritdoc/>
		public ICollection<object> Keys => this.dict.Keys;
		/// <inheritdoc/>
		public ICollection<object> Values => this.dict.Values;
		/// <inheritdoc/>
		public int Count => this.dict.Count;

		bool ICollection<KeyValuePair<object, object>>.IsReadOnly => ((IDictionary<object, object>)this.dict).IsReadOnly;

		/// <inheritdoc/>
		public object this[object key]
		{
			get => this.dict[key];
			set => this.dict[key] = value;
		}

		/// <summary>
		/// Initialises a new <see cref="LuaTable"/> and adds all pairs located on the table into the dictionary.
		/// </summary>
		public LuaTable(object table)
		{
			this.dict = new Dictionary<object, object>();
			Lua = table;

			object k = null;
			object v = null;
#if __CSharpLua__
/*[[
for k, v in pairs(table) do
]]*/
#endif
			this.dict.Add(k, v);
#if __CSharpLua__
/*[[
end
]]*/
#endif
		}

		/// <inheritdoc/>
		public void Add(object key, object value)
		{
			this.dict.Add(key, value);
		}

		/// <inheritdoc/>
		public bool ContainsKey(object key)
		{
			return this.dict.ContainsKey(key);
		}

		/// <inheritdoc/>
		public bool Remove(object key)
		{
			return this.dict.Remove(key);
		}

		/// <inheritdoc/>
		public bool TryGetValue(object key, [MaybeNullWhen(false)] out object value)
		{
			return this.dict.TryGetValue(key, out value);
		}

		/// <inheritdoc/>
		public void Clear()
		{
			this.dict.Clear();
		}

		/// <inheritdoc/>
		public IEnumerator<KeyValuePair<object, object>> GetEnumerator()
		{
			return this.dict.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.dict.GetEnumerator();
		}

		void ICollection<KeyValuePair<object, object>>.Add(KeyValuePair<object, object> item)
		{
			((IDictionary<object, object>)this.dict).Add(item);
		}

		bool ICollection<KeyValuePair<object, object>>.Contains(KeyValuePair<object, object> item)
		{
			return ((IDictionary<object, object>)this.dict).Contains(item);
		}

		void ICollection<KeyValuePair<object, object>>.CopyTo(KeyValuePair<object, object>[] array, int arrayIndex)
		{
			((IDictionary<object, object>)this.dict).CopyTo(array, arrayIndex);
		}

		bool ICollection<KeyValuePair<object, object>>.Remove(KeyValuePair<object, object> item)
		{
			return ((IDictionary<object, object>)this.dict).Remove(item);
		}
	}
}
