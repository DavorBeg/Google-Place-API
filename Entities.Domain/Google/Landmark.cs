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
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; } = string.Empty;

		[JsonProperty("placeId")]
		public string PlaceId { get; set; } = string.Empty;

		[JsonProperty("displayName")]
		public virtual DisplayName DisplayName { get; set; } = new DisplayName();

		[JsonProperty("types")]
		public virtual IEnumerable<string> Types { get; set; } = Enumerable.Empty<string>();

		[JsonProperty("spatialRelationship", NullValueHandling = NullValueHandling.Ignore)]
		public SpatialRelationship? SpatialRelationship { get; set; }

		[JsonProperty("straightLineDistanceMeters")]
		public double StraightLineDistanceMeters { get; set; }

		[JsonProperty("travelDistanceMeters", NullValueHandling = NullValueHandling.Ignore)]
		public double? TravelDistanceMeters { get; set; }

	}
}
