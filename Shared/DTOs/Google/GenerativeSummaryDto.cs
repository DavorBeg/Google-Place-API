using Entities.Domain.Google;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record GenerativeSummaryDto
	{
		public DisplayNameDto? Overview { get; set; }
		public DisplayNameDto? Description { get; set; }
		public References? References { get; set; }
	}
}
