using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Authentication
{
	public record UserForRegisterDto
	{
		[Required(ErrorMessage = "Username field is required.")]
		public string username { get; init; } = null!;

		[Required(ErrorMessage = "Email field is required.")]
		[EmailAddress]
		public string email { get; init; } = null!;

		[Required(ErrorMessage = "Password field is required.")]
		[MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
		public string password { get; init; } = null!;

		[Required(ErrorMessage = "Repeat password field is required.")]
		[Compare("password", ErrorMessage = "Passwords and repeated password do not match.")]
		public string rPassword { get; init; } = null!;

		public string? apiKey { get; init; }
	}
}
