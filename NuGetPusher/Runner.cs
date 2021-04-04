using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NuGet.Common;
using NuGet.Configuration;
using NuGet.Protocol.Core.Types;
using Task = System.Threading.Tasks.Task;

namespace NuGetPusher
{
	internal class Runner
	{
		private readonly PackageSource source;
		private readonly IEnumerable<Lazy<INuGetResourceProvider>> providers;
		private readonly SourceRepository repository;
		private readonly PackageSearchResource search;
		private readonly SearchFilter filter;

		public Runner(string sourceUri)
		{
			this.source = new PackageSource(sourceUri);
			this.providers = Repository.Provider.GetCoreV3();
			this.repository = new SourceRepository(this.source, this.providers);
			this.search = this.repository.GetResource<PackageSearchResource>();
			this.filter = new SearchFilter(includePrerelease: true);
		}

		public async Task Run(string project)
		{
			var csprojPath = Path.Combine(project, project + ".csproj");
			var elements = XmlElement.Load(csprojPath);
			var version = XmlElement.Flatten(elements).FirstOrDefault(x => x.Name == "Version").Value;
			if (!await HasVersion(project, version))
			{
				Console.WriteLine($"Updating {project} to v{version}.");
				await UploadPackage(project, version);
				Console.WriteLine($"Pushed {project} v{version}.");
			}
		}

		private async Task UploadPackage(string project, string version)
		{
			var csproj = Path.Combine(Environment.CurrentDirectory, project, project + ".csproj");

			var process = new Process();
			process.StartInfo.FileName = "dotnet";
			process.StartInfo.Arguments = $"restore {csproj} --force --force-evaluate --no-cache";
			process.Start();
			await process.WaitForExitAsync();
			if (process.ExitCode != 0)
			{
				Console.WriteLine($"Restoring {project} v{version} failed. Retrying in 30 seconds.");
				await Task.Delay(30000);
				await UploadPackage(project, version);
			}

			process = new Process();
			process.StartInfo.FileName = @"dotnet";
			process.StartInfo.Arguments = $"build -c Release \"{csproj}\"";
			process.Start();
			await process.WaitForExitAsync();

			if (process.ExitCode != 0)
			{
				Console.WriteLine($"Building {project} v{version} failed. Retrying in 30 seconds.");
				await Task.Delay(30000);
				await UploadPackage(project, version);
			}

			Console.WriteLine($"Building {project} v{version} succeeded. Pushing package.");
			process = new Process();
			process.StartInfo.FileName = "dotnet";
			process.StartInfo.Arguments = $"nuget push {project}/bin/Release/{project}.{version}.nupkg --api-key {Program.ApiKey} --source {Program.Source}";
			process.Start();
			await process.WaitForExitAsync();
		}

		private async Task<bool> HasVersion(string project, string version)
		{
			var results = await this.search.SearchAsync($"packageid:{project}", this.filter, 0, 20, NullLogger.Instance, CancellationToken.None);
			foreach (var result in results)
			{
				if (result.Title == project && result.Authors.StartsWith("Orden"))
				{
					var versions = await result.GetVersionsAsync();
					return versions.Any(x => x.Version.OriginalVersion == version);
				}
			}

			throw new Exception($"{project} not found");
		}
	}
}
