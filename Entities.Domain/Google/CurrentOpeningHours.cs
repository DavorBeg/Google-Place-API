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
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("openNow")]
		public bool OpenNow { get; set; }

		[JsonProperty("periods")]
		public virtual ICollection<Period> Periods { get; set; }

		[JsonProperty("weekdayDescriptions")]
		public virtual List<string> WeekdayDescriptions { get; set; }

		[JsonProperty("secondaryHoursType", NullValueHandling = NullValueHandling.Ignore)]
		public SecondaryHoursType? SecondaryHoursType { get; set; }


		[JsonIgnore]
		public Guid? PlaceCurrentSecondaryOpeningHoursId { get; set; }

		[JsonIgnore]
		public Guid? PlaceRegularSecondaryOpeningHoursId { get; set; }


	}
}
