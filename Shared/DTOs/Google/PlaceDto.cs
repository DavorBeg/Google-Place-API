using Entities.Domain.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record PlaceDto
	{
		public string Id { get; set; } = null!;
		public string Name { get; set; } = null!;
		public DisplayName? DisplayName { get; set; } 
		public IEnumerable<string> Types { get; set; } = null!;
		public string PrimaryType { get; set; } = null!;
		public string NationalPhoneNumber { get; set; } = null!;

	}
}
