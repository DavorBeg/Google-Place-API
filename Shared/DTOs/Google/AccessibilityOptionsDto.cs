using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record AccessibilityOptionsDto
	{
		public bool? WheelchairAccessibleParking { get; init; }
		public bool WheelchairAccessibleEntrance { get; init; }
		public bool WheelchairAccessibleRestroom { get; init; }
		public bool WheelchairAccessibleSeating { get; init; }
	}
}
