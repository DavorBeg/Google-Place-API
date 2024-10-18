using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class AccessibilityOptions
	{
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("wheelchairAccessibleParking", NullValueHandling = NullValueHandling.Ignore)]
		public bool? WheelchairAccessibleParking { get; set; }

		[JsonProperty("wheelchairAccessibleEntrance")]
		public bool WheelchairAccessibleEntrance { get; set; }

		[JsonProperty("wheelchairAccessibleRestroom")]
		public bool WheelchairAccessibleRestroom { get; set; }

		[JsonProperty("wheelchairAccessibleSeating")]
		public bool WheelchairAccessibleSeating { get; set; }
	}
}
