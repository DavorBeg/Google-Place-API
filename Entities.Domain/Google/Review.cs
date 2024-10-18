using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class Review
	{
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; } = string.Empty;

		[JsonProperty("relativePublishTimeDescription")]
		public string RelativePublishTimeDescription { get; set; } = string.Empty;

		[JsonProperty("rating")]
		public long Rating { get; set; }

		[JsonProperty("text")]
		public virtual DisplayName? Text { get; set; }

		[JsonProperty("originalText")]
		public virtual DisplayName? OriginalText { get; set; }

		[JsonProperty("authorAttribution")]
		public virtual AuthorAttribution? AuthorAttribution { get; set; }

		[JsonProperty("publishTime")]
		public DateTimeOffset PublishTime { get; set; }

		[JsonIgnore]
		public string? PlaceId { get; set; }	
	}
}
