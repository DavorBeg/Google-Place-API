using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class Date
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("year")]
		public long Year { get; set; }

		[JsonProperty("month")]
		public long Month { get; set; }

		[JsonProperty("day")]
		public long Day { get; set; }
	}
}
