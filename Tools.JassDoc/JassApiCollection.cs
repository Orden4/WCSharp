using System.Collections.Frozen;
using System.Diagnostics.CodeAnalysis;
using WCSharp.IO.JassDoc.Output;
using WCSharp.IO.JassDoc.Parsing;

namespace Tools.JassDoc
{
	public class JassApiCollection
	{
		public JassApi Api { get; }

		private readonly FrozenDictionary<string, JassEntity> jassEntitiesByName;

		public JassApiCollection(JassApi api)
		{
			Api = api;
			this.jassEntitiesByName = api.Entities.ToFrozenDictionary(x => x.Name, x => x);
		}

		public bool TryGetJassEntity<T>(string name, [NotNullWhen(true)] out T? entity) where T : JassEntity
		{
			if (!this.jassEntitiesByName.TryGetValue(name, out var obj) || obj is not T value)
			{
				entity = default;
				return false;
			}

			entity = value;
			return true;
		}

		public static async Task<JassApiCollection> CreateAsync()
		{
			var jassApi = await JassDocParser.ParseDocAsync([
				new Uri("https://raw.githubusercontent.com/lep/jassdoc/refs/heads/master/common.j"),
				new Uri("https://raw.githubusercontent.com/lep/jassdoc/refs/heads/master/Blizzard.j"),
				new Uri("https://raw.githubusercontent.com/lep/jassdoc/refs/heads/master/common.ai"),
				new Uri("https://raw.githubusercontent.com/lep/jassdoc/refs/heads/master/builtin-types.j"),
			]);
			return new JassApiCollection(jassApi);
		}
	}
}
