using Entities.Domain.Enums;
using Entities.Domain.Google;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{

	public record CurrentOpeningHoursDto
	{
		public bool OpenNow { get; init; }
		public IEnumerable<PeriodDto>? Periods { get; init; }
		public IEnumerable<string>? WeekdayDescriptions { get; init; }
		public SecondaryHoursType? SecondaryHoursType { get; init; }
	}

}
