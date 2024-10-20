using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entities.Domain.Google
{
	public class Close
	{
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("day")]
		public long Day { get; set; }

		[JsonProperty("hour")]
		public long Hour { get; set; }

		[JsonProperty("minute")]
		public long Minute { get; set; }

		[JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
		public Date Date { get; set; } = new Date();
	}
}
