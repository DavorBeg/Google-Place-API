using Entities.Domain.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class Area
	{
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; } = string.Empty;

		[JsonProperty("placeId")]
		public string PlaceId { get; set; } = string.Empty;

		[JsonProperty("displayName")]
		public DisplayName DisplayName { get; set; } = null!;

		[JsonProperty("containment")]
		public Containment Containment { get; set; } = Containment.CONTAINMENT_UNSPECIFIED;
	}
}
