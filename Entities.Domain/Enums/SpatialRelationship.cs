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
	public enum SpatialRelationship
	{
		NEAR,
		WITHIN,
		BESIDE,
		ACROSS_THE_ROAD,
		DOWN_THE_ROAD,
		AROUND_THE_CORNER,
		BEHIND
	}
}
