using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Entities.Domain.Google
{
	public class AddressDescriptor
	{
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("landmarks")]
		public virtual IEnumerable<Landmark> Landmarks { get; set; } = Enumerable.Empty<Landmark>();

		[JsonProperty("areas")]
		public virtual IEnumerable<Area> Areas { get; set; } = Enumerable.Empty<Area>();
	}

}
