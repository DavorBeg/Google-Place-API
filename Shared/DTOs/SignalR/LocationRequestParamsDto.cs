using Entities.Domain.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.SignalR
{
	public record LocationRequestParamsDto
	{
		public string User { get; init; } = null!;
		public IEnumerable<string> IncludedTypes { get; set; } = Enumerable.Empty<string>();
		public int MaxResultCount { get; init; }
		public Circle Circle { get; init; } = null!;
		
		public DateTime Timestamp { get; init; } = DateTime.Now;

		public string RequestName { get => Shared.SignalR.SignalR.Events.UserRequestSearchLocation; }
	}
}
	