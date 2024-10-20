using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class AuthorAttribution
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("displayName")]
		public string DisplayName { get; set; } = string.Empty;

		[JsonProperty("uri")]
		public string Uri { get; set; } = string.Empty;

		[JsonProperty("photoUri")]
		public string PhotoUri { get; set; } = string.Empty;

		[JsonIgnore]
		public Guid? PhotoId { get; set; }
	}
}
