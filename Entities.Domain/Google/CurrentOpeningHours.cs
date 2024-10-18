using Entities.Domain.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class CurrentOpeningHours
	{
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("openNow")]
		public bool OpenNow { get; set; }

		[JsonProperty("periods")]
		public virtual IEnumerable<Period> Periods { get; set; } = Enumerable.Empty<Period>();

		[JsonProperty("weekdayDescriptions")]
		public virtual IEnumerable<string> WeekdayDescriptions { get; set; } = Enumerable.Empty<string>();

		[JsonProperty("secondaryHoursType", NullValueHandling = NullValueHandling.Ignore)]
		public SecondaryHoursType? SecondaryHoursType { get; set; }

		[JsonIgnore]
		public string? PlaceId { get; set; }
	}
}
