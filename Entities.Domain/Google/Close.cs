using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Entities.Domain.Google
{
	public class Close
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("day")]
		public long Day { get; set; }

		[JsonProperty("hour")]
		public long Hour { get; set; }

		[JsonProperty("minute")]
		public long Minute { get; set; }

		[JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
		public virtual Date? Date { get; set; } = new Date();
	}
}
