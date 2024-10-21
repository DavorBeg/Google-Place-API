using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Authentication
{
	public record UserProfileDto
	{
		public string username { get; init; } = null!;
		public string email { get; init; } = null!;
		public string apiKey { get; init; } = null!;
	}
}
