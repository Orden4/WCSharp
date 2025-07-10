using System.Diagnostics.CodeAnalysis;
using JassDocParsing.Output;
using Microsoft.CodeAnalysis;
using WCSharp.JassDoc.Bridge;
using WCSharp.JassDoc.Bridge.Properties;

namespace WCSharp.JassDoc.RoslynParsing
{
	public class RoslynProject
	{
		public string Project { get; }
		public Compilation Compilation { get; }
		public JassApiCollection JassApi { get; }
		public List<IApiEntity> ApiEntities { get; }

		private readonly Dictionary<JassEntity, IApiEntity> commonEntityMapping = [];
		private readonly Dictionary<JassEntity, IApiEntity> uncommonEntityMapping = [];

		public RoslynProject(string project, Compilation compilation, IEnumerable<IApiEntity> apiEntities, JassApiCollection jassApi)
		{
			Project = project;
			Compilation = compilation;
			JassApi = jassApi;
			ApiEntities = [.. apiEntities];

			// Map natives in common/blizzard
			foreach (var apiEntity in ApiEntities)
			{
				switch (apiEntity)
				{
					case ApiType apiType:
						this.commonEntityMapping.Add(apiType.JassType, apiType);
						break;
					case ApiMethodBasic apiMethodBasic:
						if (apiMethodBasic.Method.ContainingType.Name is not ("Common" or "Blizzard"))
							continue;
						this.commonEntityMapping.Add(apiMethodBasic.JassMethod, apiMethodBasic);
						break;
					case ApiField apiField:
						if (apiField.Field.ContainingType.Name is not ("Common" or "Blizzard"))
							continue;
						this.commonEntityMapping.Add(apiField.JassProperty, apiField);
						break;
					default:
						break;
				}
			}

			// Map natives in WCSharp.Api (where possible)
			var uncommonsByTemplates = jassApi.Api.Entities.ToDictionary(x => x, _ => new List<IApiEntity>());
			foreach (var apiEntity in ApiEntities)
			{
				if (apiEntity is ApiType)
					continue;

				switch (apiEntity)
				{
					case ApiMethodBasic apiMethodBasic:
						if (apiMethodBasic.Method.ContainingType.Name is "Common" or "Blizzard")
							continue;
						uncommonsByTemplates[apiMethodBasic.JassMethod].Add(apiMethodBasic);
						break;
					case ApiProperty apiProperty:
						if (apiProperty.Property.ContainingType.Name is "Common" or "Blizzard")
							continue;

						if (apiProperty.Get is ApiPropertyMethod getMethod)
						{
							uncommonsByTemplates[getMethod.JassMethod].Add(apiProperty.Get);
						}
						else if (apiProperty.Get is ApiPropertyValue getValue)
						{
							uncommonsByTemplates[getValue.JassProperty].Add(apiProperty.Get);
						}

						if (apiProperty.Set is ApiPropertyMethod setMethod)
						{
							uncommonsByTemplates[setMethod.JassMethod].Add(apiProperty.Set);
						}
						else if (apiProperty.Set is ApiPropertyValue setValue)
						{
							uncommonsByTemplates[setValue.JassProperty].Add(apiProperty.Set);
						}

						break;
					default:
						break;
				}
			}

			foreach (var entry in uncommonsByTemplates)
			{
				if (entry.Value.Count == 1)
				{
					this.uncommonEntityMapping.Add(entry.Key, entry.Value[0]);
				}
			}
		}

		public bool TryFindApiEntity(JassEntity jassEntity, [NotNullWhen(true)] out IApiEntity? apiEntity)
		{
			if (this.uncommonEntityMapping.TryGetValue(jassEntity, out apiEntity))
			{
				return true;
			}
			else if (this.commonEntityMapping.TryGetValue(jassEntity, out apiEntity))
			{
				return true;
			}

			return false;
		}
	}
}
