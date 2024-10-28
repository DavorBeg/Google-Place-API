using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record ParkingOptionsDto
	{
		public bool? PaidParkingLot { get; init; }
		public bool? PaidStreetParking { get; init; }
		public bool? ValetParking { get; init; }
		public bool? FreeStreetParking { get; init; }
		public bool? FreeGarageParking { get; init; }
		public bool? PaidGarageParking { get; init; }
	}
}
