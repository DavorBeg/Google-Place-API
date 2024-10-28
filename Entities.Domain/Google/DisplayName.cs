using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Entities.Domain.Google
{
	public partial class DisplayName
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("text")]
		public string Text { get; set; } = string.Empty;

		[JsonProperty("languageCode")]
		public string LanguageCode { get; set; } = string.Empty;

		[JsonIgnore]
		public Guid? PlaceId { get; set; } 
	}
}
