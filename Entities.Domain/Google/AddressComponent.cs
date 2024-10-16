﻿using Newtonsoft.Json;
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
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("longText")]
		public string LongText { get; set; } = null!;

		[JsonProperty("shortText")]
		public string ShortText { get; set; } = null!;

		[JsonProperty("types")]
		public IEnumerable<string> Types { get; set; } = Enumerable.Empty<string>();

		[JsonProperty("languageCode")]
		public string LanguageCode { get; set; } = string.Empty;
	}
}
