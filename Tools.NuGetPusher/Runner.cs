using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using NuGet.Common;
using NuGet.Configuration;
using NuGet.Protocol.Core.Types;
using Serilog;
using Task = System.Threading.Tasks.Task;

namespace NuGetPusher
{
	internal class Runner
	{
		private readonly PackageSource source;
		private readonly IEnumerable<Lazy<INuGetResourceProvider>> providers;
		private readonly SourceRepository repository;
		private readonly PackageSearchResource search;
		private readonly PackageUpdateResource update;
		private readonly SearchFilter filter;
		private readonly AppSettings appSettings;

		public Runner(AppSettings appSettings)
		{
			this.appSettings = appSettings;
			this.source = new PackageSource(appSettings.NuGetSource);
			this.providers = Repository.Provider.GetCoreV3();
			this.repository = new SourceRepository(this.source, this.providers);
			this.search = this.repository.GetResource<PackageSearchResource>();
			this.update = this.repository.GetResource<PackageUpdateResource>();
			this.filter = new SearchFilter(includePrerelease: true);
		}

		private static string GetVersion(string project)
		{
			var doc = XDocument.Load("Directory.Build.props");
			var version = doc.Descendants("Version").SingleOrDefault();
			if (version != null && !string.IsNullOrEmpty(version.Value))
			{
				return version.Value;
			}

			throw new Exception($"Cannot find version of project {project}");
		}

		public async Task Run(string project)
		{
			var version = GetVersion(project);
			if (!await HasVersion(project, version))
			{
				Log.Information("Updating {Project} to v{Version}.", project, version);
				await UploadPackage(project, version);
				Log.Information("Pushed {Project} v{Version}.", project, version);
			}
		}

		private async Task UploadPackage(string project, string version)
		{
			var retryCount = 0;
			while (true)
			{
				var package = Path.Combine(Environment.CurrentDirectory, this.appSettings.PackageDirectory, $"{project}.{version}.nupkg");
				try
				{
					await this.update.PushAsync(
						[package],
						symbolSource: null,
						timeoutInSecond: 300,
						disableBuffering: false,
						getApiKey: _ => this.appSettings.ApiKey,
						getSymbolApiKey: _ => null,
						noServiceEndpoint: false,
						skipDuplicate: true,
						allowSnupkg: false,
						allowInsecureConnections: false,
						log: NullLogger.Instance
					);
					return;
				}
				catch (Exception e)
				{
					if (retryCount >= this.appSettings.RetryLimit)
					{
						Log.Error("Failed to push {Project} v{Version}. Aborting.", project, version);
						Log.Error(e, "Push error.");
						throw new Exception("Push retry limit exceeded.");
					}
					else
					{
						retryCount++;
						Log.Warning($"Failed to push {{Project}} v{{Version}}. Retrying in {this.appSettings.RetryDelay} seconds...", project, version);
						Log.Warning(e, "Push error.");
						await Task.Delay(TimeSpan.FromSeconds(this.appSettings.RetryDelay));
					}
				}
			}
		}

		private async Task<bool> HasVersion(string project, string version)
		{
			var results = await this.search.SearchAsync($"packageid:{project}", this.filter, 0, 20, NullLogger.Instance, CancellationToken.None);
			foreach (var result in results)
			{
				if (result.Title == project && result.Authors.StartsWith(this.appSettings.Author))
				{
					var versions = await result.GetVersionsAsync();
					return versions.Any(x => x.Version.OriginalVersion == version);
				}
			}

			return false;
		}
	}
}
