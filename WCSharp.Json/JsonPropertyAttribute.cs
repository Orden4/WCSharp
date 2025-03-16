using System;

namespace WCSharp.Json
{
	/// <summary>
	/// Defines properties for the serializing and deserializing of WCSharp.JSON objects.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class JsonPropertyAttribute : Attribute
	{
		/// <summary>
		/// The JSON name that the file should use during serializing/deserializing.
		/// <para>During deserializing, the real name may still be used if the attribute name cannot be matched on.</para>
		/// <para>Note: If you provide a name that is identical to the name of another property, the result will be ambigious.</para>
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Creates a new <see cref="JsonPropertyAttribute"/> to configure the way that a property is serialized/deserialized.
		/// </summary>
		public JsonPropertyAttribute(string name)
		{
			Name = name;
		}
	}
}
