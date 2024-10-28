using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record AuthorAttributionDto
	{
		public string DisplayName { get; set; } = string.Empty;
		public string Uri { get; set; } = string.Empty;
		public string PhotoUri { get; set; } = string.Empty;
	}
}
