using Entities.Domain.Google;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record CloseDto
	{
		public long Day { get; init; }
		public long Hour { get; init; }
		public long Minute { get; init; }
		public DateDto? Date { get; init; }
	}
}
