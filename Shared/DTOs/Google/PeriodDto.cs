using Entities.Domain.Google;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record PeriodDto
	{
		public CloseDto? Open { get; init; }
		public CloseDto? Close { get; init; }
	}
}
