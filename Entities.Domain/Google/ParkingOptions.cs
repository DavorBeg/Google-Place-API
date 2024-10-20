using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class ParkingOptions
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("paidParkingLot", NullValueHandling = NullValueHandling.Ignore)]
		public bool? PaidParkingLot { get; set; }

		[JsonProperty("paidStreetParking", NullValueHandling = NullValueHandling.Ignore)]
		public bool? PaidStreetParking { get; set; }

		[JsonProperty("valetParking", NullValueHandling = NullValueHandling.Ignore)]
		public bool? ValetParking { get; set; }

		[JsonProperty("freeStreetParking", NullValueHandling = NullValueHandling.Ignore)]
		public bool? FreeStreetParking { get; set; }

		[JsonProperty("freeGarageParking", NullValueHandling = NullValueHandling.Ignore)]
		public bool? FreeGarageParking { get; set; }

		[JsonProperty("paidGarageParking", NullValueHandling = NullValueHandling.Ignore)]
		public bool? PaidGarageParking { get; set; }

		[JsonIgnore]
		public Guid? PlaceId { get; set; }
	}
}
