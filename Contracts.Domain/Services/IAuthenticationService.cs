using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Shared.DTOs.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Domain.Services
{
	public interface IAuthenticationService
	{
		Task<IdentityResult> RegisterUser(UserForRegisterDto userForRegistration);
		Task<bool> ValidateUser(UserForLoginDto userForAuthentication, HttpContext request);
		Task<TokenDto> CreateToken();
	}
}
