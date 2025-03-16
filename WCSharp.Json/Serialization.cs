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

			var properties = type.GetProperties();
			for (var i = 0; i < properties.Length; i++)
			{
				var property = properties[i];
				var propertyType = property.PropertyType;
				var value = property.GetValue(input);
				var name = property.Name;
				var jsonAttribute = property.GetCustomAttribute<JsonPropertyAttribute>();
				if (jsonAttribute != null && !string.IsNullOrEmpty(jsonAttribute.Name))
				{
					name = jsonAttribute.Name;
				}

				if (!propertyType.IsClass)
				{
					dict.Add(name, value);
				}
				else if (propertyType == typeof(string))
				{
					if (value != null)
					{
						dict.Add(name, value);
					}
				}
				else if (value != null)
				{
					dict.Add(name, SerializeClass(value, propertyType));
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

			if (interfaces.Contains(typeof(IDictionary<,>)))
			{
				return SerializeDictionary(value, type);
			}
			else if (interfaces.Contains(typeof(ICollection<>)))
			{
				return SerializeCollection(value, type);
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

		private static object SerializeCollection(object value, Type type)
		{
			var itemType = type.GetGenericArguments()[0];
			if (!itemType.IsClass || itemType == typeof(string))
			{
				if (type.GetGenericTypeDefinition() == typeof(HashSet<>))
				{
					return SerializeHashSet(value);
				}
				else
				{
					return value;
				}
			}

			var newList = new List<Dictionary<string, object>>();
			foreach (var item in (IEnumerable)value)
			{
				newList.Add(ConvertInputToDictionary(item, itemType));
			}
			return newList;
		}

		private static object SerializeHashSet(object value)
		{
			// Internally CSharpLua hashtables are tables mapping values to a true boolean
			// If we don't convert it to a list first, Rxi will just output an array of "true" values
			var newList = new List<object>();
			foreach (var item in (IEnumerable)value)
			{
				newList.Add(item);
			}
			return newList;
		}

		private static object SerializeDictionary(object value, Type type)
		{
			var genericArguments = type.GetGenericArguments();
			if (genericArguments[0].IsClass && genericArguments[0] != typeof(string))
				throw new ArgumentException("ERROR: Cannot serialize dictionaries with keys that are not primitives, enums or strings.");

			var serializeValue = genericArguments[1].IsClass && genericArguments[1] != typeof(string);
			var newDict = new Dictionary<string, object>();
			foreach (var item in (IEnumerable)value)
			{
				// KeyValuePairs were changed from having a key/value property to just being 1 and 2 indexed, which we can't access with reflection
				// So we just use CSharpLua.Templates to just directly work on the KeyValuePair table
				var itemKeyValue = GetKey(item);
				var itemValue = GetValue(item);
				var serializedValue = serializeValue
					? ConvertInputToDictionary(itemValue, genericArguments[1])
					: itemValue;
				newDict.Add(itemKeyValue.ToString(), serializedValue);
			}

			return newDict;
		}

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
		/// @CSharpLua.Template = "{0}[1]"
		private static extern object GetKey(object item);
		/// @CSharpLua.Template = "{0}[2]"
		private static extern object GetValue(object item);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	}
}
