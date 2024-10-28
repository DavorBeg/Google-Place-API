using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record LocationDto
	{
		public double Latitude { get; init; }
		public double Longitude { get; init; }
	}
}
