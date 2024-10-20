using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class Circle
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("center")]
		public virtual Location Center { get; set; } = null!;
		[JsonIgnore]
		public Guid? CenterId { get; set; }


		[JsonProperty("radius")]
		public double Radius { get; set; }

		[JsonIgnore]
		public Guid? PlaceId { get; set; }
	}
}
