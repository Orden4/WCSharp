using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace WCSharp.Json
{
	internal static class Serialization
	{
		public static Dictionary<string, object> ConvertInputToDictionary(object input)
		{
			var dict = new Dictionary<string, object>();

			foreach (var property in input.GetType().GetProperties())
			{
				var value = property.GetValue(input);
				if (!property.PropertyType.IsClass)
				{
					dict.Add(property.Name, value);
				}
				else if (property.PropertyType == typeof(string))
				{
					if (value != null)
					{
						dict.Add(property.Name, value);
					}
				}
				else if (value != null)
				{
					dict.Add(property.Name, SerializeClass(property, value));
				}
			}

			return dict;
		}

		private static object SerializeClass(PropertyInfo property, object value)
		{
			if (property.PropertyType.IsGenericType)
			{
				var typeDefinition = property.PropertyType.GetGenericTypeDefinition();
				if (typeDefinition == typeof(List<>))
				{
					return SerializeList(property, value);
				}
				else if (typeDefinition == typeof(Dictionary<,>))
				{
					return SerializeDictionary(property, value);
				}
			}

			return ConvertInputToDictionary(value);
		}

		private static object SerializeList(PropertyInfo property, object value)
		{
			var itemType = property.PropertyType.GetGenericArguments()[0];
			if (!itemType.IsClass || itemType == typeof(string))
			{
				// Only primitives, will serialize fine
				return value;
			}
			else
			{
				var newList = new List<Dictionary<string, object>>();
				foreach (var item in (ICollection)value)
				{
					newList.Add(ConvertInputToDictionary(item));
				}
				return newList;
			}
		}

		private static object SerializeDictionary(PropertyInfo property, object value)
		{
			var genericArguments = property.PropertyType.GetGenericArguments();
			if (genericArguments[0].IsClass && genericArguments[0] != typeof(string))
				throw new ArgumentException("ERROR: Cannot serialize dictionaries with keys that are not primitives, enums or strings.");

			if (!genericArguments[1].IsClass || genericArguments[1] == typeof(string))
			{
				// Only primitives, will serialize fine
				return value;
			}
			else
			{
				var newDict = new Dictionary<object, object>();
				foreach (var item in (ICollection)value)
				{
					var itemType = item.GetType();
					var itemKey = itemType.GetProperty("Key").GetValue(item);
					var itemValue = itemType.GetProperty("Value").GetValue(item);
					newDict.Add(itemKey, ConvertInputToDictionary(itemValue));
				}
				return newDict;
			}
		}
	}
}
