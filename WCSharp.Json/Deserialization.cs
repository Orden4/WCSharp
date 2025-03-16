using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WCSharp.Shared;

namespace WCSharp.Json
{
	internal static class Deserialization
	{
		public static object DeserializeLuaTable(LuaTable table, Type type)
		{
			if (type.IsArray)
			{
				return DeserializeArray(type, table);
			}

			var instance = Activator.CreateInstance(type);
			var interfaces = type.GetInterfaces()
				.Where(x => x.IsGenericType)
				.Select(x => x.GetGenericTypeDefinition())
				.ToList();

			if (interfaces.Contains(typeof(IDictionary<,>)))
			{
				return DeserializeDictionary(type, instance, table);
			}
			else if (interfaces.Contains(typeof(ICollection<>)))
			{
				return DeserializeCollection(type, instance, table);
			}

			var properties = type.GetProperties();
			for (var i = 0; i < properties.Length; i++)
			{
				var property = properties[i];
				if (!TryGetTableValue(table, property, out var value))
				{
					var deserializedValue = DeserializeLuaValue(value, property.PropertyType);
					if (deserializedValue != null)
					{
						property.SetValue(instance, deserializedValue);
					}
				}
			}

			return instance;
		}

		private static bool TryGetTableValue(LuaTable table, PropertyInfo property, out object value)
		{
			var jsonAttribute = property.GetCustomAttribute<JsonPropertyAttribute>();
			if (jsonAttribute != null && !string.IsNullOrEmpty(jsonAttribute.Name))
			{
				if (table.TryGetValue(jsonAttribute.Name, out value))
					return true;
			}

			return table.TryGetValue(property.Name, out value);
		}

		private static object DeserializeClass(object value, Type type)
		{
			if (value == null)
			{
				return null;
			}

			var deserialize = type.GetMethod("Deserialize");
			if (deserialize != null && value is string)
			{
				return deserialize.Invoke(null, new object[] { value });
			}

			return DeserializeLuaTable(new LuaTable(value), type);
		}

		private static object DeserializeArray(Type type, LuaTable table)
		{
			var elementType = type.GetElementType();
			var array = Array.CreateInstance(elementType, table.Count);

			var i = 0;
			foreach (var item in table)
			{
				array.SetValue(DeserializeLuaValue(item.Value, elementType), i++);
			}

			return array;
		}

		private static object DeserializeCollection(Type type, object instance, LuaTable table)
		{
			var genericType = type.GetGenericArguments()[0];
			var add = type.GetMethod("Add", new Type[] { genericType });

			if (add == null)
			{
				return null;
			}

			foreach (var value in table.Values)
			{
				add.Invoke(instance, new object[] { DeserializeLuaValue(value, genericType) });
			}

			return instance;
		}

		private static object DeserializeDictionary(Type type, object instance, LuaTable table)
		{
			var genericTypes = type.GetGenericArguments();
			var add = type.GetMethod("Add", genericTypes);

			if (add == null)
			{
				return null;
			}

			foreach (var keyValue in table)
			{
				var key = DeserializeLuaString(keyValue.Key, genericTypes[0]);
				var value = DeserializeLuaValue(keyValue.Value, genericTypes[1]);
				add.Invoke(instance, new object[] { key, value });
			}

			return instance;
		}

		private static object DeserializeLuaString(object stringObject, Type type)
		{
			if (stringObject is string @string)
			{
				if (type == typeof(bool))
				{
					if (bool.TryParse(@string, out var @bool))
					{
						return @bool;
					}
				}
				else if (type == typeof(byte))
				{
					if (byte.TryParse(@string, out var @byte))
					{
						return @byte;
					}
				}
				else if (type == typeof(sbyte))
				{
					if (sbyte.TryParse(@string, out var @sbyte))
					{
						return @sbyte;
					}
				}
				else if (type == typeof(char))
				{
					if (char.TryParse(@string, out var @char))
					{
						return @char;
					}
				}
				else if (type == typeof(decimal))
				{
					if (decimal.TryParse(@string, out var @decimal))
					{
						return @decimal;
					}
				}
				else if (type == typeof(double))
				{
					if (double.TryParse(@string, out var @double))
					{
						return @double;
					}
				}
				else if (type == typeof(float))
				{
					if (float.TryParse(@string, out var @float))
					{
						return @float;
					}
				}
				else if (type == typeof(int))
				{
					if (int.TryParse(@string, out var @int))
					{
						return @int;
					}
				}
				else if (type == typeof(uint))
				{
					if (uint.TryParse(@string, out var @uint))
					{
						return @uint;
					}
				}
				else if (type == typeof(long))
				{
					if (long.TryParse(@string, out var @long))
					{
						return @long;
					}
				}
				else if (type == typeof(ulong))
				{
					if (ulong.TryParse(@string, out var @ulong))
					{
						return @ulong;
					}
				}
				else if (type == typeof(short))
				{
					if (short.TryParse(@string, out var @short))
					{
						return @short;
					}
				}
				else if (type == typeof(ushort))
				{
					if (ushort.TryParse(@string, out var @ushort))
					{
						return @ushort;
					}
				}
				else if (type == typeof(string))
				{
					return @string;
				}
				else
				{
					throw new Exception("Cannot deserialize dictionaries with non-primitive key types.");
				}
			}

			throw new Exception("Serialized dictionary keys should always be strings.");
		}

		private static object DeserializeLuaValue(object value, Type type)
		{
			if (!type.IsClass || type == typeof(string))
			{
				return value;
			}
			else
			{
				return DeserializeClass(value, type);
			}
		}
	}
}
