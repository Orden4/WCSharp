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

			object value = default;

			foreach (var property in type.GetProperties())
			{
				var name = property.Name;
#if __CSharpLua__
/*[[
value = table[name];
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

		private static object DeserializeList(Type type, object instance, object table)
		{
			var genericType = type.GetGenericArguments()[0];
			var add = type.GetMethod("Add", new Type[] { genericType });

			object v = default;
#if __CSharpLua__
/*[[
for k,v in pairs(table) do
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

			object k = default;
			object v = default;
#if __CSharpLua__
/*[[
for k,v in pairs(table) do
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

			//if (type == typeof(bool))
			//{
			//	if (value is bool @bool)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(byte))
			//{
			//	if (value is byte @byte)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(sbyte))
			//{
			//	if (value is sbyte @sbyte)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(char))
			//{
			//	if (value is char @char)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(decimal))
			//{
			//	if (value is decimal @decimal)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(double))
			//{
			//	if (value is double @double)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(float))
			//{
			//	if (value is float @float)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(int))
			//{
			//	if (value is int @int)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(uint))
			//{
			//	if (value is uint @uint)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(long))
			//{
			//	if (value is long @long)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(ulong))
			//{
			//	if (value is ulong @ulong)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(short))
			//{
			//	if (value is short @short)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(ushort))
			//{
			//	if (value is ushort @ushort)
			//	{
			//		return value;
			//	}
			//}
			//else if (type == typeof(string))
			//{
			//	if (value is string @string)
			//	{
			//		return value;
			//	}
			//}
			//else if (type.IsClass)
			//{
			//	return DeserializeLuaTable(value, type);
			//}

			//return null;
		}
	}
}
