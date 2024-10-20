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
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("overview")]
		public virtual DisplayName Overview { get; set; } = null!;
		[JsonIgnore]
		public Guid OverviewId { get; set; }


		[JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
		public virtual DisplayName? Description { get; set; }
		[JsonIgnore]
		public Guid? DescriptionId { get; set; }

		[JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
		public virtual References? References { get; set; }
		[JsonIgnore]
		public virtual Guid? ReferencesId { get; set; }

		[JsonIgnore]
		public Guid? PlaceId { get; set; }
	}
}
