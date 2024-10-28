using AutoMapper.Configuration.Annotations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record DisplayNameDto
	{

		[JsonProperty("text")]
		public string? Text { get; init; }

		[JsonProperty("languageCode")]
		public string? LanguageCode { get; init; } 
	}
}
