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
	public partial class Landmark
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("name")]
		public string Name { get; set; } = string.Empty;

		[JsonProperty("placeId")]
		public string PlaceId { get; set; } = string.Empty;

		[JsonProperty("displayName")]
		public virtual DisplayName DisplayName { get; set; } = new DisplayName();
		[JsonIgnore]
		public Guid? DisplayNameId { get; set; }

		[JsonProperty("types")]
		public virtual List<string> Types { get; set; }

		[JsonProperty("spatialRelationship", NullValueHandling = NullValueHandling.Ignore)]
		public SpatialRelationship? SpatialRelationship { get; set; }

		[JsonProperty("straightLineDistanceMeters")]
		public double StraightLineDistanceMeters { get; set; }

		[JsonProperty("travelDistanceMeters", NullValueHandling = NullValueHandling.Ignore)]
		public double? TravelDistanceMeters { get; set; }

		[JsonIgnore]
		public Guid? AddressDescriptorId { get; set; }

	}
}
