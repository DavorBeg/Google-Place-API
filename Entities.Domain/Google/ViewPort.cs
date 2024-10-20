using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class Viewport
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("low")]
		public virtual Location? Low { get; set; } = null;
		[JsonIgnore]
		public Guid? LowId { get; set; }

		[JsonProperty("high")]
		public virtual Location? High { get; set; } = null;
		[JsonIgnore]
		public Guid? HighId { get; set; }
		[JsonIgnore]
		public Guid? PlaceId { get; set; } 
	}
}
