using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class AddressComponent
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("longText")]
		public string LongText { get; set; } = null!;

		[JsonProperty("shortText")]
		public string ShortText { get; set; } = null!;

		[JsonProperty("types")]
		public List<string> Types { get; set; }

		[JsonProperty("languageCode")]
		public string LanguageCode { get; set; } = string.Empty;

		[JsonIgnore]
		public Guid? PlaceId { get; set; }
	}
}
