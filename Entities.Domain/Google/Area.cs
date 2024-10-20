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
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("name")]
		public string Name { get; set; } = string.Empty;

		[JsonProperty("placeId")]
		public string PlaceId { get; set; } = string.Empty;

		[JsonProperty("displayName")]
		public virtual DisplayName DisplayName { get; set; } = null!;
		[JsonIgnore]
		public Guid? DisplayNameId { get; set; }

		[JsonProperty("containment")]
		public Containment Containment { get; set; } = Containment.CONTAINMENT_UNSPECIFIED;

		[JsonIgnore]
		public Guid? AddressDescriptorId { get; set; }
	}
}
