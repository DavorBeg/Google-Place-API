using AutoMapper.Configuration.Annotations;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Entities.Domain.Google
{
	public partial class DisplayName
	{
		[Key]
		[JsonIgnore]
		[Ignore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("text")]
		public string Text { get; set; } = string.Empty;

		[JsonProperty("languageCode")]
		public string LanguageCode { get; set; } = string.Empty;

		[JsonIgnore]
		[Ignore]
		public Guid? PlaceId { get; set; } 
	}
}
