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
	public record AreaDto
	{
		public string Name { get; set; } = string.Empty;
		public DisplayNameDto? DisplayName { get; set; }
		public Containment Containment { get; set; } = Containment.CONTAINMENT_UNSPECIFIED;
	}
}
