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
	public enum FuelType
	{
		FUEL_TYPE_UNSPECIFIED,
		DIESEL,
		REGULAR_UNLEADED,
		MIDGRADE,
		PREMIUM,
		SP91,
		SP91_E10,
		SP92,
		SP95,
		SP95_E10,
		SP98,
		SP99,
		SP100,
		LPG,
		E80,
		E85,
		METHANE,
		BIO_DIESEL,
		TRUCK_DIESEL
	}
}
