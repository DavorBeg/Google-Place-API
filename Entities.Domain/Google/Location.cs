using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public partial class Location
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("latitude")]
		public double Latitude { get; set; }

		[JsonProperty("longitude")]
		public double Longitude { get; set; }

		[JsonIgnore]
		public Guid? PlaceId { get; set; }
	}
}
