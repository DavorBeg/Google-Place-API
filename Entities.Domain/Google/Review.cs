using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class Review
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("name")]
		public string Name { get; set; } = string.Empty;

		[JsonProperty("relativePublishTimeDescription")]
		public string RelativePublishTimeDescription { get; set; } = string.Empty;

		[JsonProperty("rating")]
		public long Rating { get; set; }

		[JsonProperty("text")]
		public virtual DisplayName? Text { get; set; }
		[JsonIgnore]
		public Guid? TextId { get; set; }

		[JsonProperty("originalText")]
		public virtual DisplayName? OriginalText { get; set; }
		[JsonIgnore]
		public Guid? OriginalTextId { get; set; }

		[JsonProperty("authorAttribution")]
		public virtual AuthorAttribution? AuthorAttribution { get; set; }
		[JsonIgnore]
		public Guid? AuthorAttributionId { get; set; }

		[JsonProperty("publishTime")]
		public DateTimeOffset PublishTime { get; set; }

		[JsonIgnore]
		public Guid? PlaceId { get; set; }

		[JsonIgnore]
		public Guid? ReferencesId { get; set; }



	}
}
