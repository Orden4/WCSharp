using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WCSharp.Json
{
	internal static class Serialization
	{
		public static Dictionary<string, object> ConvertInputToDictionary(object input, Type type)
		{
			var dict = new Dictionary<string, object>();

			foreach (var property in type.GetProperties())
			{
				var propertyType = property.PropertyType;
				var value = property.GetValue(input);
				if (!propertyType.IsClass)
				{
					dict.Add(property.Name, value);
				}
				else if (propertyType == typeof(string))
				{
					if (value != null)
					{
						dict.Add(property.Name, value);
					}
				}
				else if (value != null)
				{
					dict.Add(property.Name, SerializeClass(value, propertyType));
				}
			}

			return dict;
		}

		public static object SerializeClass(object value, Type type)
		{
			var serialize = type.GetMethod("Serialize");
			if (serialize != null)
			{
				return (string)serialize.Invoke(null, new object[] { value });
			}

			if (type.IsArray)
			{
				return SerializeArray(value, type);
			}

			var interfaces = type.GetInterfaces()
				.Where(x => x.IsGenericType)
				.Select(x => x.GetGenericTypeDefinition())
				.ToList();

			if (interfaces.Contains(typeof(IList<>)))
			{
				return SerializeList(value, type);
			}
			else if (interfaces.Contains(typeof(IDictionary<,>)))
			{
				return SerializeDictionary(value, type);
			}

			return ConvertInputToDictionary(value, type);
		}

		private static object SerializeArray(object value, Type type)
		{
			var elementType = type.GetElementType();
			if (!elementType.IsClass || elementType == typeof(string))
			{
				// Only primitives, will serialize fine
				return value;
			}
			else
			{
				var newList = new List<Dictionary<string, object>>();
				foreach (var item in (IEnumerable)value)
				{
					newList.Add(ConvertInputToDictionary(item, elementType));
				}
				return newList;
			}
		}

		private static object SerializeList(object value, Type type)
		{
			var itemType = type.GetGenericArguments()[0];
			if (!itemType.IsClass || itemType == typeof(string))
			{
				// Only primitives, will serialize fine
				return value;
			}
			else
			{
				var newList = new List<Dictionary<string, object>>();
				foreach (var item in (IEnumerable)value)
				{
					newList.Add(ConvertInputToDictionary(item, itemType));
				}
				return newList;
			}
		}

		private static object SerializeDictionary(object value, Type type)
		{
			var genericArguments = type.GetGenericArguments();
			if (genericArguments[0].IsClass && genericArguments[0] != typeof(string))
				throw new ArgumentException("ERROR: Cannot serialize dictionaries with keys that are not primitives, enums or strings.");

			var serializeValue = genericArguments[1].IsClass && genericArguments[1] != typeof(string);
			var newDict = new Dictionary<string, object>();
			PropertyInfo keyProp = null;
			PropertyInfo valueProp = null;
			foreach (var item in (IEnumerable)value)
			{
				if (keyProp == null)
				{
					var itemType = item.GetType();
					keyProp = itemType.GetProperty("Key");
					valueProp = itemType.GetProperty("Value");
				}

				var itemKeyValue = keyProp.GetValue(item);
				if (itemKeyValue != null)
				{
					var itemValue = valueProp.GetValue(item);
					var serializedValue = serializeValue
						? ConvertInputToDictionary(itemValue, genericArguments[1])
						: itemValue;
					newDict.Add(itemKeyValue.ToString(), serializedValue);
				}
			}

			return newDict;
		}
	}
}
