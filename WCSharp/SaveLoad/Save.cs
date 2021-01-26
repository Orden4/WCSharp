using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WCSharp.Utils;
using static War3Api.Common;

namespace WCSharp.SaveLoad
{
	public class Save : IDictionary<string, string>
	{
		private readonly Dictionary<string, string> data = new Dictionary<string, string>();

		public player Player { get; private set; }
		public int SaveSlot { get; set; }

		public ICollection<string> Keys => this.data.Keys;

		public ICollection<string> Values => this.data.Values;

		public int Count => this.data.Count;

		bool ICollection<KeyValuePair<string, string>>.IsReadOnly => throw new NotImplementedException();

		internal bool Verified { get; } = true;

		public string this[string key]
		{
			get => this.data[key];
			set
			{
				if (value == null)
				{
					this.data.Remove(key);
				}
				else
				{
					this.data[key] = value;
				}
			}
		}

		private static readonly List<string> saveableSuffixes = new List<string>
		{
			"Bool",
			"Byte",
			"Char",
			"Decimal",
			"Double",
			"Float",
			"Decimal",
			"Double",
			"Float",
			"Int",
			"Long",
			"Short",
			"String"
		};

		internal Save()
		{
		}

		internal Save(string data)
		{
			var spl = data.Contains(";") ? data.Split(';') : Base64.FromBase64(data).Split(';');
			if (spl.Length % 2 == 0)
			{
				for (var i = 0; i < spl.Length; i += 2)
				{
					this.data.Add(spl[i], spl[i + 1]);
				}
			}
		}

		/// <summary>
		/// Creates a new save for the given player, using the given slot.
		/// <para>The save slot must be between 1 and 10.</para>
		/// </summary>
		/// <param name="player">The player to create the save for.</param>
		/// <param name="saveSlot">The slot to save to.</param>
		public Save(player player, int saveSlot = 1)
		{
			Player = player;
			SaveSlot = saveSlot;
		}

		internal Save(player player, int saveSlot, string data) : this(player, saveSlot)
		{
			var spl = data.Contains(";") ? data.Split(';') : Base64.FromBase64(data).Split(';');
			if (spl.Length % 2 == 0)
			{
				for (var i = 0; i < spl.Length; i += 2)
				{
					this.data.Add(spl[i], spl[i + 1]);
				}

				if (!Verify())
				{
					Verified = false;
				}
			}
		}

		private bool Verify()
		{
			if (TryGetValue(SaveSystem.SAVE_HASH, out int savedHash))
			{
				this.data.Remove(SaveSystem.SAVE_HASH);
				var actualHash = GetHashCode();
				if (savedHash == actualHash)
				{
					return true;
				}
			}

			this.data.Clear();
			return false;
		}

		/// <summary>
		/// Sets or overwrites the given key to the given value. Null values will not be added, and instead remove the existing value.
		/// </summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add. Value will not be added if null.</param>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public void Add(string key, string value)
		{
			if (value == null)
			{
				this.data.Remove(key);
			}
			else
			{
				this.data[key] = value;
			}
		}

		/// <summary>
		/// Sets or overwrites the given key to the given value.
		/// </summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add.</param>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public void Add(string key, bool value)
		{
			this.data[key] = value.ToString();
		}

		/// <summary>
		/// Sets or overwrites the given key to the given value.
		/// </summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add.</param>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public void Add(string key, byte value)
		{
			this.data[key] = value.ToString();
		}

		/// <summary>
		/// Sets or overwrites the given key to the given value.
		/// </summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add.</param>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public void Add(string key, sbyte value)
		{
			this.data[key] = value.ToString();
		}

		/// <summary>
		/// Sets or overwrites the given key to the given value.
		/// </summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add.</param>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public void Add(string key, char value)
		{
			this.data[key] = value.ToString();
		}

		/// <summary>
		/// Sets or overwrites the given key to the given value.
		/// </summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add.</param>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public void Add(string key, decimal value)
		{
			this.data[key] = value.ToString();
		}

		/// <summary>
		/// Sets or overwrites the given key to the given value.
		/// </summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add.</param>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public void Add(string key, double value)
		{
			this.data[key] = value.ToString();
		}

		/// <summary>
		/// Sets or overwrites the given key to the given value.
		/// </summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add.</param>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public void Add(string key, float value)
		{
			this.data[key] = value.ToString();
		}

		/// <summary>
		/// Sets or overwrites the given key to the given value.
		/// </summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add.</param>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public void Add(string key, uint value)
		{
			this.data[key] = value.ToString();
		}

		/// <summary>
		/// Sets or overwrites the given key to the given value.
		/// </summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add.</param>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public void Add(string key, long value)
		{
			this.data[key] = value.ToString();
		}

		/// <summary>
		/// Sets or overwrites the given key to the given value.
		/// </summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add.</param>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public void Add(string key, ulong value)
		{
			this.data[key] = value.ToString();
		}

		/// <summary>
		/// Sets or overwrites the given key to the given value.
		/// </summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add.</param>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public void Add(string key, short value)
		{
			this.data[key] = value.ToString();
		}

		/// <summary>
		/// Sets or overwrites the given key to the given value.
		/// </summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add.</param>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public void Add(string key, ushort value)
		{
			this.data[key] = value.ToString();
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out string value)
		{
			return this.data.TryGetValue(key, out value);
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out bool value)
		{
			if (this.data.TryGetValue(key, out var v))
			{
				return bool.TryParse(v, out value);
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out byte value)
		{
			if (this.data.TryGetValue(key, out var v))
			{
				return byte.TryParse(v, out value);
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out sbyte value)
		{
			if (this.data.TryGetValue(key, out var v))
			{
				return sbyte.TryParse(v, out value);
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out char value)
		{
			if (this.data.TryGetValue(key, out var v))
			{
				return char.TryParse(v, out value);
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out decimal value)
		{
			if (this.data.TryGetValue(key, out var v))
			{
				return decimal.TryParse(v, out value);
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out double value)
		{
			if (this.data.TryGetValue(key, out var v))
			{
				return double.TryParse(v, out value);
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out float value)
		{
			if (this.data.TryGetValue(key, out var v))
			{
				return float.TryParse(v, out value);
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out int value)
		{
			if (this.data.TryGetValue(key, out var v))
			{
				return int.TryParse(v, out value);
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out uint value)
		{
			if (this.data.TryGetValue(key, out var v))
			{
				return uint.TryParse(v, out value);
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out long value)
		{
			if (this.data.TryGetValue(key, out var v))
			{
				return long.TryParse(v, out value);
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out ulong value)
		{
			if (this.data.TryGetValue(key, out var v))
			{
				return ulong.TryParse(v, out value);
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out short value)
		{
			if (this.data.TryGetValue(key, out var v))
			{
				return short.TryParse(v, out value);
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// <para>Note: You must specify the type, do not use "var".</para>
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
		/// <returns>True if the <see cref="Save"/> contains an element with the specified key and type; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Key is null.</exception>
		public bool TryGetValue(string key, out ushort value)
		{
			if (this.data.TryGetValue(key, out var v))
			{
				return ushort.TryParse(v, out value);
			}
			else
			{
				value = default;
				return false;
			}
		}

		public T Deserialize<T>()
			where T : Saveable, new()
		{
			var obj = new T();
			var type = typeof(T);

			foreach (var keyValue in this.data)
			{
				var prop = type.GetProperty(keyValue.Key);
				if (prop == null)
				{
					continue;
				}

				if (keyValue.Key.EndsWith("String"))
				{
					prop.SetValue(obj, keyValue.Value);
				}
				else if (keyValue.Key.EndsWith("Bool"))
				{
					if (bool.TryParse(keyValue.Value, out var value))
					{
						prop.SetValue(obj, value);
					}
				}
				else if (keyValue.Key.EndsWith("SByte"))
				{
					if (sbyte.TryParse(keyValue.Value, out var value))
					{
						prop.SetValue(obj, value);
					}
				}
				else if (keyValue.Key.EndsWith("Byte"))
				{
					if (byte.TryParse(keyValue.Value, out var value))
					{
						prop.SetValue(obj, value);
					}
				}
				else if (keyValue.Key.EndsWith("Char"))
				{
					if (char.TryParse(keyValue.Value, out var value))
					{
						prop.SetValue(obj, value);
					}
				}
				else if (keyValue.Key.EndsWith("Decimal"))
				{
					if (decimal.TryParse(keyValue.Value, out var value))
					{
						prop.SetValue(obj, value);
					}
				}
				else if (keyValue.Key.EndsWith("Double"))
				{
					if (double.TryParse(keyValue.Value, out var value))
					{
						prop.SetValue(obj, value);
					}
				}
				else if (keyValue.Key.EndsWith("Float"))
				{
					if (float.TryParse(keyValue.Value, out var value))
					{
						prop.SetValue(obj, value);
					}
				}
				else if (keyValue.Key.EndsWith("UInt"))
				{
					if (uint.TryParse(keyValue.Value, out var value))
					{
						prop.SetValue(obj, value);
					}
				}
				else if (keyValue.Key.EndsWith("Int"))
				{
					if (int.TryParse(keyValue.Value, out var value))
					{
						prop.SetValue(obj, value);
					}
				}
				else if (keyValue.Key.EndsWith("ULong"))
				{
					if (ulong.TryParse(keyValue.Value, out var value))
					{
						prop.SetValue(obj, value);
					}
				}
				else if (keyValue.Key.EndsWith("Long"))
				{
					if (long.TryParse(keyValue.Value, out var value))
					{
						prop.SetValue(obj, value);
					}
				}
				else if (keyValue.Key.EndsWith("UShort"))
				{
					if (ushort.TryParse(keyValue.Value, out var value))
					{
						prop.SetValue(obj, value);
					}
				}
				else if (keyValue.Key.EndsWith("Short"))
				{
					if (short.TryParse(keyValue.Value, out var value))
					{
						prop.SetValue(obj, value);
					}
				}
			}

			obj.Player = Player;
			obj.SaveSlot = SaveSlot;

			return obj;
		}

		public void Serialize<T>(T obj)
			where T : Saveable
		{
			this.data.Clear();
			foreach (var property in obj.GetType().GetFields())
			{
				if (!saveableSuffixes.Any(x => property.Name.EndsWith(x)))
				{
					continue;
				}

				var value = property.GetValue(obj);
				if (value != null)
				{
					this.data.Add(property.Name, value.ToString());
				}
			}
		}

		public override bool Equals(object obj)
		{
			return this == obj;
		}

		public override int GetHashCode()
		{
			var hash = SaveSystem.Hash1;

			foreach (var keyValue in this.data.OrderBy(x => x.Key))
			{
				hash = (hash * SaveSystem.Hash2) ^ GetHashCode(keyValue.Key);
				hash = (hash * SaveSystem.Hash2) ^ GetHashCode(keyValue.Value);
			}

			if (SaveSystem.BindSavesToPlayerName)
			{
				hash = (hash * SaveSystem.Hash2) ^ GetHashCode(GetPlayerName(Player));
			}

			return hash;
		}

		private int GetHashCode(string @string)
		{
			var hash = 419933;

			foreach (var ch in @string)
			{
				hash = (hash * 577097) ^ ch;
			}

			return hash;
		}

		public override string ToString()
		{
			this.data.Add(SaveSystem.SAVE_HASH, GetHashCode().ToString());
			var str = this.Select(x => $"{x.Key};{x.Value}").Aggregate((x, y) => $"{x};{y}");
			this.data.Remove(SaveSystem.SAVE_HASH);
			return Base64.ToBase64(str);
		}

		public bool ContainsKey(string key)
		{
			return this.data.ContainsKey(key);
		}

		public bool Remove(string key)
		{
			return this.data.Remove(key);
		}

		public void Clear()
		{
			this.data.Clear();
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return this.data.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.data.GetEnumerator();
		}

		void ICollection<KeyValuePair<string, string>>.Add(KeyValuePair<string, string> item)
		{
			throw new NotImplementedException();
		}

		bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> item)
		{
			throw new NotImplementedException();
		}

		void ICollection<KeyValuePair<string, string>>.CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item)
		{
			throw new NotImplementedException();
		}
	}
}
