using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationModels.Domain
{
	public class GoogleConfiguration
	{
		public string? BaseUri { get; set; }
		public string? ApiVersion { get; set; } 
		public IEnumerable<RequiredHeader> RequireHeaders { get; set; } = Enumerable.Empty<RequiredHeader>();
		public IEnumerable<string> AvailableFeatures { get; set; } = Enumerable.Empty<string>();

		public string FullUrl { get => $"{this.BaseUri}/{this.ApiVersion}/"; }

	}

	public class RequiredHeader
	{
		public string? Name { get; set; } 
		public string? DefaultValue { get; set; }
	}
}
