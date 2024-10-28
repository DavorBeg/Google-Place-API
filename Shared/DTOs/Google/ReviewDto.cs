using Entities.Domain.Google;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record ReviewDto
	{
		public string? Name { get; init; }
		public string? RelativePublishTimeDescription { get; init; } 
		public long Rating { get; init; }
		public DisplayNameDto? Text { get; init; }
		public DisplayNameDto? OriginalText { get; init; }
		public AuthorAttributionDto? AuthorAttribution { get; init; }
	}
}
