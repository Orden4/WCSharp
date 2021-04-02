using System;

namespace WCSharp.Json
{
	/// <summary>
	/// Entry point for converting classes to and from JSON files.
	/// </summary>
	public static class JsonConvert
	{
		/// <summary>
		/// Attempts to convert the given JSON string into the specified generic class.
		/// <para>Please read the documentation for details on what can and cannot be (de)serialized.</para>
		/// </summary>
		public static bool TryDeserialize<T>(string input, out T data)
		{
			if (TryDeserialize(input, typeof(T), out var obj))
			{
				data = (T)obj;
				return true;
			}
			else
			{
				data = default;
				return false;
			}
		}

		/// <summary>
		/// Attempts to convert the given JSON string into the specified generic class.
		/// <para>Please read the documentation for details on what can and cannot be (de)serialized.</para>
		/// </summary>
		public static bool TryDeserialize(string input, Type deserializeType, out object data)
		{
			try
			{
				data = Deserialize(input, deserializeType);
				return true;
			}
			catch (Exception)
			{
				data = null;
				return false;
			}
		}
		/// <summary>
		/// Converts the given JSON string into the specified generic class.
		/// <para>Please read the documentation for details on what can and cannot be (de)serialized.</para>
		/// </summary>
		public static T Deserialize<T>(string input)
		{
			return (T)Deserialize(input, typeof(T));
		}

		/// <summary>
		/// Converts the given JSON string into the specified generic class.
		/// <para>Please read the documentation for details on what can and cannot be (de)serialized.</para>
		/// </summary>
		public static object Deserialize(string input, Type deserializeType)
		{
			return Deserialization.DeserializeLuaTable(Lua.Json.Deserialize(input), deserializeType);
		}

		/// <summary>
		/// Converts the given generic class into a JSON string.
		/// <para>Please read the documentation for details on what can and cannot be (de)serialized.</para>
		/// </summary>
		public static string Serialize<T>(T input)
		{
			var jsonInput = Serialization.SerializeClass(input, typeof(T));
			return Lua.Json.Serialize(jsonInput);
		}
	}
}
