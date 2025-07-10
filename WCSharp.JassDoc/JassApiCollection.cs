using System.Collections.Frozen;
using System.Diagnostics.CodeAnalysis;
using JassDocParsing.Output;
using JassDocParsing.Parsing;

namespace WCSharp.JassDoc
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
			var jassApi = new JassApi();
			jassApi.Merge(await JassDocParser.ParseDoc(new Uri("https://raw.githubusercontent.com/lep/jassdoc/refs/heads/master/common.j"), "common.j"));
			jassApi.Merge(await JassDocParser.ParseDoc(new Uri("https://raw.githubusercontent.com/lep/jassdoc/refs/heads/master/Blizzard.j"), "blizzard.j"));
			jassApi.Merge(await JassDocParser.ParseDoc(new Uri("https://raw.githubusercontent.com/lep/jassdoc/refs/heads/master/common.ai"), "common.ai"));
			jassApi.Merge(await JassDocParser.ParseDoc(new Uri("https://raw.githubusercontent.com/lep/jassdoc/refs/heads/master/builtin-types.j"), "builtin-types.j"));
			return new JassApiCollection(jassApi);
		}
	}
}
