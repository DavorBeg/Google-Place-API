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
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("low")]
		public virtual Location? Low { get; set; } = null;

		[JsonProperty("high")]
		public virtual Location? High { get; set; } = null;
	}
}
