using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Domain.Google
{
	public class Photo
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("name")]
		public string Name { get; set; } = string.Empty;

		[JsonProperty("widthPx")]
		public long WidthPx { get; set; }

		[JsonProperty("heightPx")]
		public long HeightPx { get; set; }

		[JsonProperty("authorAttributions")]
		public virtual ICollection<AuthorAttribution> AuthorAttributions { get; set; } 

		[JsonIgnore]
		public Guid? PlaceId { get; set; }

	}
}
