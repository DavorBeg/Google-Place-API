using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class GenerativeSummary
	{
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("overview")]
		public virtual DisplayName Overview { get; set; } = null!;

		[JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
		public virtual DisplayName? Description { get; set; }

		[JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
		public virtual References? References { get; set; }
	}
}
