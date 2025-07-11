using System.Data;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using Tools.JassDoc.Bridge;
using Tools.JassDoc.Bridge.Parameters;
using Tools.JassDoc.Bridge.Properties;
using WCSharp.IO.JassDoc.Output;
using WCSharp.JassDoc.Bridge;

namespace Tools.JassDoc.RoslynParsing
{
	public class RoslynParser
	{
		public static async Task<RoslynProject> GetApiEntities(string csproj, JassApiCollection jassApi)
		{
			var workspace = MSBuildWorkspace.Create();
			var project = await workspace.OpenProjectAsync(csproj);
			var compilation = await project.GetCompilationAsync()
				?? throw new Exception();

			var parser = new RoslynParser(csproj, jassApi, compilation);
			parser.Run();

			return new RoslynProject(csproj, compilation, parser.entities, jassApi);
		}

		private readonly string csproj;
		private readonly JassApiCollection jassApi;
		private readonly Compilation compilation;
		private readonly List<IApiEntity> entities = [];
		private readonly Dictionary<SyntaxTree, SemanticModel> semanticModelCache = [];

		private RoslynParser(string csproj, JassApiCollection jassApi, Compilation compilation)
		{
			this.csproj = csproj;
			this.jassApi = jassApi;
			this.compilation = compilation;
		}

		private SemanticModel GetSemanticModel(SyntaxTree syntaxTree)
		{
			if (!this.semanticModelCache.TryGetValue(syntaxTree, out var semanticModel))
			{
				this.semanticModelCache[syntaxTree] = semanticModel = this.compilation.GetSemanticModel(syntaxTree);
			}
			return semanticModel;
		}

		private void Run()
		{
			var existingTypes = this.jassApi.Api.Types.Select(x => x.Name).ToHashSet();
			var methods = this.compilation.SyntaxTrees.SelectMany(x => x.GetRoot().DescendantNodes())
				.OfType<MethodDeclarationSyntax>()
				.Where(x => x.Modifiers.Any(x => x.IsKind(SyntaxKind.ExternKeyword)) && !x.Modifiers.Any(x => x.IsKind(SyntaxKind.OverrideKeyword)))
				.ToList();
			var properties = this.compilation.SyntaxTrees.SelectMany(x => x.GetRoot().DescendantNodes())
				.OfType<PropertyDeclarationSyntax>()
				.Where(x => x.Modifiers.Any(x => x.IsKind(SyntaxKind.ExternKeyword)))
				.ToList();
			var fields = this.compilation.SyntaxTrees.SelectMany(x => x.GetRoot().DescendantNodes())
				.OfType<FieldDeclarationSyntax>()
				.Where(x => !x.Modifiers.Any(x => x.IsKind(SyntaxKind.ConstKeyword)))
				.ToList();
			var types = this.compilation.SyntaxTrees.SelectMany(x => x.GetRoot().DescendantNodes())
				.OfType<TypeDeclarationSyntax>()
				.Where(x => existingTypes.Contains(x.Identifier.Text))
				.ToList();

			GetApiEntities([.. methods, .. properties, .. fields, .. types]);
		}

		private void GetApiEntities(IEnumerable<SyntaxNode> nodes)
		{
			foreach (var node in nodes)
			{
				switch (node)
				{
					case MethodDeclarationSyntax methodDeclaration:
						MapMethod(methodDeclaration);
						break;
					case PropertyDeclarationSyntax propertyDeclaration:
						MapProperty(propertyDeclaration);
						break;
					case TypeDeclarationSyntax typeDeclaration:
						MapType(typeDeclaration);
						break;
					case FieldDeclarationSyntax fieldDeclaration:
						MapField(fieldDeclaration);
						break;
					default:
						throw new NotImplementedException();
				}
			}
		}

		private void MapMethod(MethodDeclarationSyntax methodDeclaration)
		{
			var semanticModel = GetSemanticModel(methodDeclaration.SyntaxTree);
			var methodSymbol = semanticModel.GetDeclaredSymbol(methodDeclaration)!;
			var template = CSharpLuaUtils.GetAnnotations(methodSymbol).First(x => x.Kind == CSharpLuaAnnotationKind.Template);
			if (!CSharpLuaUtils.TryParseMethodBasic(template.Value!, out var methodName, out var arguments))
			{
				Console.WriteLine($"Complex template: {template}");
				return;
			}

			if (!this.jassApi.TryGetJassEntity<JassMethod>(methodName, out var jassMethod))
			{
				Console.WriteLine($"Unknown method: {methodName}");
				return;
			}

			var parameters = GetParameters(jassMethod, arguments, methodSymbol);

			this.entities.Add(new ApiMethodBasic
			{
				SyntaxNode = methodDeclaration,
				JassMethod = jassMethod,
				Method = methodSymbol,
				Parameters = parameters,
			});
		}

		private void MapProperty(PropertyDeclarationSyntax propertyDeclaration)
		{
			var semanticModel = GetSemanticModel(propertyDeclaration.SyntaxTree);
			var propertySymbol = semanticModel.GetDeclaredSymbol(propertyDeclaration)!;
			var getTemplate = CSharpLuaUtils.GetAnnotations(propertySymbol).First(x => x.Kind == CSharpLuaAnnotationKind.Get);
			var setTemplate = CSharpLuaUtils.GetAnnotations(propertySymbol).FirstOrDefault(x => x.Kind == CSharpLuaAnnotationKind.Set);

			var property = new ApiProperty
			{
				SyntaxNode = propertyDeclaration,
				Property = propertySymbol,
			};

			property.Get = GetPropertyPart(property, getTemplate);
			property.Set = GetPropertyPart(property, setTemplate);

			this.entities.Add(property);
		}

		private void MapType(TypeDeclarationSyntax typeDeclaration)
		{
			var semanticModel = GetSemanticModel(typeDeclaration.SyntaxTree);
			var typeSymbol = semanticModel.GetDeclaredSymbol(typeDeclaration)!;
			if (!this.jassApi.TryGetJassEntity<JassType>(typeSymbol.Name, out var jassType))
				throw new Exception();

			this.entities.Add(new ApiType
			{
				SyntaxNode = typeDeclaration,
				Type = typeSymbol,
				JassType = jassType,
			});
		}

		private void MapField(FieldDeclarationSyntax fieldDeclaration)
		{
			foreach (var variable in fieldDeclaration.Declaration.Variables)
			{
				var semanticModel = GetSemanticModel(fieldDeclaration.SyntaxTree);
				var fieldSymbol = (IFieldSymbol)semanticModel.GetDeclaredSymbol(variable)!;
				if (!fieldSymbol.GetDocumentationCommentXml()!.Contains("@CSharpLua"))
					return;

				if (!this.jassApi.TryGetJassEntity<JassProperty>(fieldSymbol.Name, out var jassField))
					throw new Exception();

				this.entities.Add(new ApiField
				{
					SyntaxNode = fieldDeclaration,
					Field = fieldSymbol,
					JassProperty = jassField,
				});
			}
		}

		private List<IApiParameter> GetParameters(JassMethod jassMethod, List<object> arguments, ISymbol? symbol = null)
		{
			var parameters = new List<IApiParameter>();
			for (var i = 0; i < arguments.Count; i++)
			{
				var argument = arguments[i];
				if (argument is int intValue)
				{
					if (symbol is IMethodSymbol methodSymbol)
					{
						parameters.Add(new ApiParameterSymbol
						{
							Parameter = methodSymbol.Parameters.First(x => x.Ordinal == intValue),
							JassParameter = jassMethod.Parameters[i],
						});
						continue;
					}
					else if (symbol is IPropertySymbol propertySymbol && intValue == 0)
					{
						parameters.Add(new ApiParameterSymbol
						{
							Parameter = propertySymbol,
							JassParameter = jassMethod.Parameters[intValue],
						});
						continue;
					}
				}
				else if (argument is string str)
				{
					if (str == "{this}")
					{
						parameters.Add(new ApiParameterThis
						{
							JassParameter = jassMethod.Parameters[i],
						});
						continue;
					}
					else if (this.jassApi.TryGetJassEntity<JassProperty>(str, out var jassProperty))
					{
						parameters.Add(new ApiParameterValue
						{
							JassProperty = jassProperty,
							JassParameter = jassMethod.Parameters[i],
						});
						continue;
					}
					else
					{
						parameters.Add(new ApiParameterExpression
						{
							Expression = str,
							JassParameter = jassMethod.Parameters[i],
						});
						continue;
					}
				}

				throw new NotImplementedException();
			}

			return parameters;
		}

		[return: NotNullIfNotNull(nameof(annotation))]
		private IApiPropertyPart? GetPropertyPart(ApiProperty property, CSharpLuaAnnotation? annotation)
		{
			if (annotation == null)
				return null;

			if (CSharpLuaUtils.TryParseMethodBasic(annotation.Value!, out var methodName, out var arguments))
			{
				if (!this.jassApi.TryGetJassEntity<JassMethod>(methodName, out var jassMethod))
				{
					Console.WriteLine($"Unknown method: {methodName}");
					return new ApiPropertyExpression
					{
						Parent = property,
						Expression = annotation.Value!.Replace("{this}", "{instance}").Replace("{0}", "{value}")
					};
				}

				var parameters = GetParameters(jassMethod, arguments, property.Symbol);
				return new ApiPropertyMethod
				{
					Parent = property,
					JassMethod = jassMethod,
					Parameters = parameters,
				};
			}
			else if (this.jassApi.TryGetJassEntity<JassProperty>(annotation.Value!, out var jassProperty))
			{
				return new ApiPropertyValue
				{
					Parent = property,
					JassProperty = jassProperty
				};
			}
			else
			{
				Console.WriteLine($"Complex template: {annotation.Value}");
				return new ApiPropertyExpression
				{
					Parent = property,
					Expression = annotation.Value!.Replace("{this}", "{instance}").Replace("{0}", "{value}")
				};
			}
		}
	}
}
