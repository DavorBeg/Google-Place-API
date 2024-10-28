using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record AddressComponentDto
	{
		public string? LongText { get; init; } 
		public string? ShortText { get; init; } 
		public List<string>? Types { get; init; }
		public string? LanguageCode { get; init; } 
	}
}
