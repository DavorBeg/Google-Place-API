using Entities.Domain.Google;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record PhotoDto
	{
		public string Name { get; init; } = string.Empty;
		public long WidthPx { get; init; }
		public long HeightPx { get; init; }
		public ICollection<AuthorAttributionDto>? AuthorAttributions { get; init; }
	}
}
