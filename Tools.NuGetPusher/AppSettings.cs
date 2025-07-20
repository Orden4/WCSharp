using System.Collections.Generic;

namespace NuGetPusher
{
	internal class AppSettings
	{
		public string Author { get; set; } = null!;
		public string NuGetSource { get; set; } = null!;
		public int RetryLimit { get; set; }
		public int RetryDelay { get; set; }
		public List<string> Projects { get; set; } = [];

		public string ApiKey { get; set; } = null!;
		public string PackageDirectory { get; set; } = null!;
	}
}
