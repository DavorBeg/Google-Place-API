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
	public enum EVConnectorType
	{
		EV_CONNECTOR_TYPE_UNSPECIFIED,
		EV_CONNECTOR_TYPE_OTHER,
		EV_CONNECTOR_TYPE_J1772,
		EV_CONNECTOR_TYPE_TYPE_2,
		EV_CONNECTOR_TYPE_CHADEMO,
		EV_CONNECTOR_TYPE_CCS_COMBO_1,
		EV_CONNECTOR_TYPE_CCS_COMBO_2,
		EV_CONNECTOR_TYPE_TESLA,
		EV_CONNECTOR_TYPE_UNSPECIFIED_GB_T,
		EV_CONNECTOR_TYPE_UNSPECIFIED_WALL_OUTLET
	}
}
