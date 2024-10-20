﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Entities.Domain.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PriceLevel
	{
		PRICE_LEVEL_UNSPECIFIED,
		PRICE_LEVEL_FREE,
		PRICE_LEVEL_INEXPENSIVE,
		PRICE_LEVEL_MODERATE,
		PRICE_LEVEL_EXPENSIVE,
		PRICE_LEVEL_VERY_EXPENSIVE
	}
}