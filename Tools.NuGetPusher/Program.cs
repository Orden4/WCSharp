using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace NuGetPusher
{
	internal class Program
	{
		[STAThread]
		private static async Task Main(string[] args)
		{
			Log.Logger = new LoggerConfiguration()
				.WriteTo.Console()
				.CreateLogger();

			var configuration = new ConfigurationBuilder()
				.AddJsonFile("appSettings.json")
				.AddCommandLine(args)
				.Build();
			var appSettings = configuration.Get<AppSettings>()
				?? throw new InvalidOperationException("No AppSettings found.");

			var runner = new Runner(appSettings);
			foreach (var project in appSettings.Projects)
			{
				await runner.Run(project);
			}
		}
	}
}
