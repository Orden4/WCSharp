using System;
using System.Collections.Generic;
using System.Linq;

namespace WCSharp.Json
{
	internal static class Deserialization
	{
		public static object DeserializeLuaTable(object table, Type type)
		{
			if (table == null)
			{
				return null;
			}

			var deserialize = type.GetMethod("Deserialize");
			if (deserialize != null && table is string)
			{
				return deserialize.Invoke(null, new object[] { table });
			}

			if (type.IsArray)
			{
				return DeserializeArray(type, table);
			}

			var instance = Activator.CreateInstance(type);
			var interfaces = type.GetInterfaces()
				.Where(x => x.IsGenericType)
				.Select(x => x.GetGenericTypeDefinition())
				.ToList();

			if (interfaces.Contains(typeof(IList<>)))
			{
				return DeserializeList(type, instance, table);
			}
			else if (interfaces.Contains(typeof(IDictionary<,>)))
			{
				return DeserializeDictionary(type, instance, table);
			}

			object value = null;

			foreach (var property in type.GetProperties())
			{
				var name = property.Name;
#if __CSharpLua__
/*[[
value = table[name]
]]*/
#endif
				value = DeserializeLuaValue(value, property.PropertyType);
				if (value != null)
				{
					property.SetValue(instance, value);
				}
			}

			return instance;
		}

		private static object DeserializeArray(Type type, object table)
		{
			var count = 0;
#if __CSharpLua__
/*[[
count = #table
]]*/
#endif
			var elementType = type.GetElementType();
			var array = Array.CreateInstance(elementType, count);
			for (var i = 0; i < count; i++)
			{
				object value = null;
#if __CSharpLua__
/*[[
value = table[i + 1]
]]*/
#endif
				array.SetValue(DeserializeLuaValue(value, elementType), i);
			}

			return array;
		}

		private static object DeserializeList(Type type, object instance, object table)
		{
			var genericType = type.GetGenericArguments()[0];
			var add = type.GetMethod("Add", new Type[] { genericType });

			object v = null;
#if __CSharpLua__
/*[[
for _, v in pairs(table) do
]]*/
#endif
			add.Invoke(instance, new object[] { DeserializeLuaValue(v, genericType) });
#if __CSharpLua__
/*[[
end
]]*/
#endif
			return instance;
		}

		private static object DeserializeDictionary(Type type, object instance, object table)
		{
			var genericTypes = type.GetGenericArguments();
			var add = type.GetMethod("Add", genericTypes);

			object k = null;
			object v = null;
#if __CSharpLua__
/*[[
for k, v in pairs(table) do
]]*/
#endif
			k = DeserializeLuaString(k, genericTypes[0]);
			v = DeserializeLuaValue(v, genericTypes[1]);
			add.Invoke(instance, new object[] { k, v });
#if __CSharpLua__
/*[[
end
]]*/
#endif
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
				return DeserializeLuaTable(value, type);
			}
		}
	}
}
