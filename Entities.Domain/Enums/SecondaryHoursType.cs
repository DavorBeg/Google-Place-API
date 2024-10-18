using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SecondaryHoursType
	{
		SECONDARY_HOURS_TYPE_UNSPECIFIED,
		DRIVE_THROUGH,
		HAPPY_HOUR,
		DELIVERY,
		TAKEOUT,
		KITCHEN,
		BREAKFAST,
		LUNCH,
		DINNER,
		BRUNCH,
		PICKUP,
		ACCESS,
		SENIOR_HOURS,
		ONLINE_SERVICE_HOURS
	}
}
