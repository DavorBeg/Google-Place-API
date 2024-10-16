using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class ParkingOptions
	{
		public bool? StreetParking { get; set; }
		public bool? GarageParking { get; set; }
		public bool? ValetParking { get; set; }
	}
}
