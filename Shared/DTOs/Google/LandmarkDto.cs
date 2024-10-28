using Entities.Domain.Enums;
using Entities.Domain.Google;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record LandmarkDto
	{
		public string Name { get; set; } = string.Empty;
		public virtual DisplayNameDto? DisplayName { get; set; }

		[JsonProperty("types")]
		public virtual List<string>? Types { get; set; }
		public SpatialRelationship? SpatialRelationship { get; set; }
		public double StraightLineDistanceMeters { get; set; }
		public double? TravelDistanceMeters { get; set; }
	}
}
