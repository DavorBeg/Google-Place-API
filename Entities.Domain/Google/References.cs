using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class References
	{
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("reviews")]
		public IEnumerable<Review> Reviews { get; set; } = Enumerable.Empty<Review>();
	}
}
