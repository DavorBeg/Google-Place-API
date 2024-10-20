using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Entities.Domain.Google
{
	public class AddressDescriptor
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("landmarks")]
		public virtual ICollection<Landmark> Landmarks { get; set; }

		[JsonProperty("areas")]
		public virtual ICollection<Area> Areas { get; set; }

		[JsonIgnore]
		public Guid? PlaceId { get; set; }	
	}

}
