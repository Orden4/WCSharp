using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Tools.ApiChecking
{
	/// <summary>
	/// Figured I'd see how easy this was to do via Roslyn. It's not that bad, but code is awful because I don't care.
	/// Probably neither the API nor this will see much change, so whatever.
	/// </summary>
	public partial class ApiChecker
	{
		/** Expected output:
Mismatched argument count: item.X
Argument is not used in template: item.X
Mismatched argument count: item.Y
Argument is not used in template: item.Y
Mismatched return type: lightning.Dispose
Argument is not used in template: multiboard.SetVisibility
No template found for: sound.IsPlaying
No template found for: sound.IsPlaying
No template found for: trigger.Enabled
No template found for: trigger.Enabled
Argument is not used in template: unit.SkillPoints
Mismatched argument count: unit.AttackRange1
Argument is not used in template: unit.AttackRange1
Mismatched argument count: unit.AttackRange2
Argument is not used in template: unit.AttackRange2
		 */

		private static readonly Regex templateRegex = TemplateRegex();
		private static readonly Regex getRegex = GetRegex();
		private static readonly Regex setRegex = SetRegex();
		private static readonly Regex callRegex = CallRegex();
		private CSharpCompilation compilation;

		public string Folder { get; }
		public CSharpParseOptions ParseOptions { get; }
		public CSharpCompilationOptions CompilationOptions { get; }
		public List<JassTemplate> JassTemplates { get; }

		public ApiChecker(string folder, IEnumerable<JassTemplate> jassTemplates)
		{
			Folder = folder;
			ParseOptions = new CSharpParseOptions();
			CompilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
			JassTemplates = jassTemplates.ToList();
		}

		private void ParseJassFile(string jassFile)
		{
			throw new NotImplementedException();
		}

		public void Run()
		{
			var syntaxTrees = new List<SyntaxTree>();
			foreach (var file in Directory.EnumerateFiles(Folder, "*.cs", SearchOption.AllDirectories))
			{
				if (file.EndsWith("Common.cs") || file.EndsWith("Blizzard.cs"))
					continue;

				var text = File.ReadAllText(file);
				var syntaxTree = CSharpSyntaxTree.ParseText(text, ParseOptions, file);
				syntaxTrees.Add(syntaxTree);
			}
			var references = new List<MetadataReference>();
			this.compilation = CSharpCompilation.Create("WCSharp.Api", syntaxTrees, references, CompilationOptions);

			foreach (var syntaxTree in this.compilation.SyntaxTrees)
			{
				var root = syntaxTree.GetRoot();
				EnumerateChildren(root);
			}

			foreach (var jassTemplate in JassTemplates.Where(x => x.Uses == 0))
			{
				Console.WriteLine($"Unused: {jassTemplate.Name}");
			}

			foreach (var jassTemplate in JassTemplates.Where(x => x.Uses > 1))
			{
				Console.WriteLine($"Multiple uses: {jassTemplate.Name}");
			}
		}

		private void EnumerateChildren(SyntaxNode node)
		{
			foreach (var child in node.ChildNodes())
			{
				EnumerateChildren(child);
			}

			if (node is MethodDeclarationSyntax method)
			{
				CheckMethod(method);
			}
			else if (node is PropertyDeclarationSyntax property)
			{
				CheckProperty(property);
			}
		}

		private void CheckProperty(PropertyDeclarationSyntax property)
		{
			CheckProperty(property, isGetter: true);
			if (property.AccessorList.Accessors.Count == 2)
			{
				CheckProperty(property, isGetter: false);
				CheckSetProperty(property);
			}
		}

		private void CheckSetProperty(PropertyDeclarationSyntax property)
		{
			var luaTemplate = ConstructTemplate(property, setRegex);
			if (luaTemplate == null)
			{
				Console.WriteLine($"No template found for: {Source(property)}");
				return;
			}

			var jassTemplate = JassTemplates.FirstOrDefault(x => x.Name == luaTemplate.Name);
			if (jassTemplate == null)
			{
				Console.WriteLine($"Could not find JASS method: {luaTemplate.Name}");
				return;
			}

			var seenParameters = new HashSet<int>();
			foreach (var argument in luaTemplate.Arguments)
			{
				if (argument.Value != null)
					continue;

				if (argument.Parameter < -1 || argument.Parameter >= 1)
					Console.WriteLine($"Lua template contains invalid parameter: {Source(property)}");

				if (!seenParameters.Add(argument.Parameter))
					Console.WriteLine($"Repeat argument: {Source(property)}");
			}

			var luaArguments = luaTemplate.Arguments.Where(x => x.Parameter == 0).ToList();
			if (luaArguments.Count == 0)
				Console.WriteLine($"Argument is not used in template: {Source(property)}");

			foreach (var luaArgument in luaArguments)
			{
				var jassArgument = jassTemplate.ArgumentTypes[luaArgument.Index];
				if (!IsType(jassArgument, property.Type))
					Console.WriteLine($"Mismatched argument type: {Source(property)}");
			}
		}

		private void CheckProperty(PropertyDeclarationSyntax property, bool isGetter)
		{
			var luaTemplate = ConstructTemplate(property, isGetter ? getRegex : setRegex);
			if (luaTemplate == null)
			{
				if (!isGetter || !property.Modifiers.Any(x => x.Kind().HasFlag(SyntaxKind.StaticKeyword)))
				{
					Console.WriteLine($"No template found for: {Source(property)}");
				}
				return;
			}

			var jassTemplate = JassTemplates.FirstOrDefault(x => x.Name == luaTemplate.Name);
			if (jassTemplate == null)
			{
				Console.WriteLine($"Could not find JASS method: {luaTemplate.Name}");
				return;
			}

			jassTemplate.Uses++;

			if (isGetter && !IsType(jassTemplate.ReturnType, property.Type))
			{
				Console.WriteLine($"Mismatched property type: {Source(property)}");
				return;
			}

			if (luaTemplate.Arguments.Count != jassTemplate.ArgumentTypes.Count)
			{
				Console.WriteLine($"Mismatched argument count: {Source(property)}");
				return;
			}

			if (!property.Modifiers.Any(x => x.Kind().HasFlag(SyntaxKind.StaticKeyword)))
			{
				foreach (var argument in luaTemplate.Arguments.Where(x => x.Parameter == -1))
				{
					var jassArgument = jassTemplate.ArgumentTypes[argument.Index];
					var @class = (ClassDeclarationSyntax)property.Parent;
					if (!IsType(jassArgument, @class))
						Console.WriteLine($"{{this}} mismatch in: {Source(property)}");
				}
			}
		}

		private void CheckMethod(MethodDeclarationSyntax method)
		{
			var luaTemplate = ConstructTemplate(method, templateRegex);
			if (luaTemplate == null)
			{
				if (!method.Modifiers.Any(x => x.Kind().HasFlag(SyntaxKind.OverrideKeyword)))
				{
					Console.WriteLine($"No template found for: {Source(method)}");
				}
				return;
			}

			var jassTemplate = JassTemplates.FirstOrDefault(x => x.Name == luaTemplate.Name);
			if (jassTemplate == null)
			{
				Console.WriteLine($"Could not find JASS method: {luaTemplate.Name}");
				return;
			}

			jassTemplate.Uses++;

			if (!IsType(jassTemplate.ReturnType, method.ReturnType))
			{
				Console.WriteLine($"Mismatched return type: {Source(method)}");
				return;
			}

			if (luaTemplate.Arguments.Count != jassTemplate.ArgumentTypes.Count)
			{
				Console.WriteLine($"Mismatched argument count: {Source(method)}");
				return;
			}

			if (!method.Modifiers.Any(x => x.Kind().HasFlag(SyntaxKind.StaticKeyword)))
			{
				foreach (var argument in luaTemplate.Arguments.Where(x => x.Parameter == -1))
				{
					var jassArgument = jassTemplate.ArgumentTypes[argument.Index];
					var @class = (ClassDeclarationSyntax)method.Parent;
					if (!IsType(jassArgument, @class))
						Console.WriteLine($"{{this}} mismatch in: {Source(method)}");
				}
			}

			var seenParameters = new HashSet<int>();
			foreach (var argument in luaTemplate.Arguments)
			{
				if (argument.Value != null)
					continue;

				if (argument.Parameter < -1 || argument.Parameter >= method.ParameterList.Parameters.Count)
					Console.WriteLine($"Lua template contains invalid parameter: {Source(method)}");

				if (!seenParameters.Add(argument.Parameter))
					Console.WriteLine($"Repeat argument: {Source(method)}");
			}

			for (var i = 0; i < method.ParameterList.Parameters.Count; i++)
			{
				var argument = method.ParameterList.Parameters[i];
				var luaArguments = luaTemplate.Arguments.Where(x => x.Parameter == i).ToList();
				if (luaArguments.Count == 0)
					Console.WriteLine($"Argument is not used in template: {Source(method)}");

				foreach (var luaArgument in luaArguments)
				{
					var jassArgument = jassTemplate.ArgumentTypes[luaArgument.Index];
					if (!IsType(jassArgument, argument.Type))
						Console.WriteLine($"Mismatched argument type: {Source(method)}");
				}
			}
		}

		private bool IsType(string jassArgument, ClassDeclarationSyntax @class)
		{
			return IsType(GetJassType(jassArgument), @class.Identifier.Text);
		}

		private bool IsType(string jassArgument, TypeSyntax type)
		{
			string typeName;
			if (type is PredefinedTypeSyntax predefinedType)
			{
				typeName = predefinedType.Keyword.Text;
			}
			else
			{
				typeName = type.ToString();
			}
			return IsType(GetJassType(jassArgument), typeName);
		}

		private bool IsType(string expectedType, string actualType)
		{
			if (expectedType == actualType)
				return true;

			var expectedNamedType = this.compilation.GetTypeByMetadataName($"WCSharp.Api.{expectedType}");
			var actualNamedType = this.compilation.GetTypeByMetadataName($"WCSharp.Api.{actualType}");
			if (expectedNamedType == null || actualNamedType == null)
				return false;

			while (actualNamedType != null)
			{
				if (SymbolEqualityComparer.Default.Equals(expectedNamedType, actualNamedType))
					return true;

				actualNamedType = actualNamedType.BaseType;
			}

			return false;
		}

		private string GetJassType(string jassArgument)
		{
			return jassArgument switch
			{
				"integer" => "int",
				"real" => "float",
				"string" => "string",
				"boolean" => "bool",
				"code" => "Action",
				"nothing" => "void",
				"event" => "@event",
				_ => jassArgument,
			};
		}

		private static LuaTemplate ConstructTemplate(SyntaxNode node, Regex identifier)
		{
			var match = FindTemplate(node, identifier);
			if (match == null)
				return null;

			var callMatch = callRegex.Match(match.Groups[1].Value);
			if (!callMatch.Success)
				return null;

			return new LuaTemplate
			{
				Text = match.Value,
				Name = callMatch.Groups[1].Value,
				Arguments = ConstructArguments(callMatch.Groups[2].Value).ToList()
			};
		}

		private static IEnumerable<LuaArgument> ConstructArguments(string value)
		{
			if (string.IsNullOrWhiteSpace(value))
				yield break;

			var args = value.Split(',').Select(x => x.Trim()).ToList();
			for (var i = 0; i < args.Count; i++)
			{
				var arg = args[i];
				var parameter = int.MinValue;
				string argValue = null;
				if (string.Equals("{this}", arg, StringComparison.InvariantCultureIgnoreCase))
				{
					parameter = -1;
				}
				else if (arg.Length > 2 && int.TryParse(arg.AsSpan(1, arg.Length - 2), out var parameterValue))
				{
					parameter = parameterValue;
				}
				else
				{
					argValue = arg;
				}

				yield return new LuaArgument
				{
					Index = i,
					Parameter = parameter,
					Value = argValue,
				};
			}
		}

		private static Match FindTemplate(SyntaxNode node, Regex identifier)
		{
			var match = default(Match);
			foreach (var trivia in node.GetLeadingTrivia())
			{
				if (!trivia.Kind().HasFlag(SyntaxKind.SingleLineDocumentationCommentTrivia))
					continue;

				var lines = trivia.ToString().Split("\r\n");
				foreach (var line in lines)
				{
					var foundMatch = identifier.Match(line);
					if (foundMatch.Success)
					{
						if (match != null)
							throw new Exception();
						match = foundMatch;
					}
				}
			}

			return match;
		}

		private string Source(PropertyDeclarationSyntax property)
		{
			var @class = (ClassDeclarationSyntax)property.Parent;
			return $"{@class.Identifier.Text}.{property.Identifier.Text}";
		}

		private string Source(MethodDeclarationSyntax method)
		{
			var @class = (ClassDeclarationSyntax)method.Parent;
			return $"{@class.Identifier.Text}.{method.Identifier.Text}";
		}

		[GeneratedRegex("@CSharpLua.Template = \"(.*)\"", RegexOptions.IgnoreCase)]
		private static partial Regex TemplateRegex();
		[GeneratedRegex("@CSharpLua.Get = \"(.*)\"", RegexOptions.IgnoreCase)]
		private static partial Regex GetRegex();
		[GeneratedRegex("@CSharpLua.Set = \"(.*)\"", RegexOptions.IgnoreCase)]
		private static partial Regex SetRegex();
		[GeneratedRegex(@"^([a-zA-Z]+)\((.*)\)$", RegexOptions.IgnoreCase)]
		private static partial Regex CallRegex();
	}
}
