using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Entities.Domain.Google
{
	public class Period
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("open")]
		public virtual Close? Open { get; set; } 

		[JsonIgnore]
		public Guid? OpenId { get; set; }

		[JsonProperty("close")]
		public virtual Close? Close { get; set; } 

		[JsonIgnore]
		public Guid? CloseId { get; set; }

		[JsonIgnore]
		public Guid CurrentOpeningHoursId { get; set; }
	}
}
