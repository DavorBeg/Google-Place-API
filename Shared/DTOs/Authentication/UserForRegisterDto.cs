using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Authentication
{
	public record UserForRegisterDto(string username, string password, string rPassword, string? apiKey);
}
