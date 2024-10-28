using Entities.Domain.Google;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record AddressDescriptorDto
	{
		public ICollection<LandmarkDto>? Landmarks { get; set; }
		public ICollection<AreaDto>? Areas { get; set; }
	}
}
