using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Entities.Domain.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BusinessStatus
	{
		BUSINESS_STATUS_UNSPECIFIED,
		OPERATIONAL,
		CLOSED_TEMPORARILY,
		CLOSED_PERMANENTLY
	}
}
