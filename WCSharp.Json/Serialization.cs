using System.Collections.Generic;

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
					dict.Add(property.Name, ConvertInputToDictionary(value));
				}
			}

			return dict;
		}
	}
}
