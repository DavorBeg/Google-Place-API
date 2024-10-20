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
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("center")]
		public virtual Location Center { get; set; } = null!;

		[JsonProperty("radius")]
		public double Radius { get; set; }
	}
}
