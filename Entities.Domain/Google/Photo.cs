using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Domain.Google
{
	public class Photo
	{
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; } = string.Empty;

		[JsonProperty("widthPx")]
		public long WidthPx { get; set; }

		[JsonProperty("heightPx")]
		public long HeightPx { get; set; }

		[JsonProperty("authorAttributions")]
		public virtual IEnumerable<AuthorAttribution> AuthorAttributions { get; set; } = Enumerable.Empty<AuthorAttribution>();

		[JsonIgnore]
		public string? PlaceId { get; set; }
	}
}
