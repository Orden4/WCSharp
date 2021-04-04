using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace NuGetPusher
{
	public class XmlElement
	{
		public string Name { get; set; }
		public string Value { get; set; }
		public List<XmlElement> Children { get; set; }

		public static List<XmlElement> Load(string file)
		{
			var doc = XDocument.Load(file);
			return LoadElements(doc.Descendants().Elements());
		}

		public static List<XmlElement> LoadElements(IEnumerable<XElement> elements)
		{
			return elements.Select(x => new XmlElement
			{
				Name = x.Name.LocalName,
				Value = x.Value,
				Children = LoadElements(x.Elements())
			}).ToList();
		}

		public static IEnumerable<XmlElement> Flatten(IEnumerable<XmlElement> elements)
		{
			foreach (var element in elements)
			{
				yield return element;
				foreach (var child in Flatten(element.Children))
				{
					yield return child;
				}
			}
		}
	}
}
