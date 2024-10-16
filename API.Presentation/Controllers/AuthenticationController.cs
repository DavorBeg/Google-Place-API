using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Shared.DTOs.Authentication;

namespace PlacesAPI.Controllers
{
	[Route("api/auth")]
	[ApiController]
	public class AuthenticationController : ControllerBase
	{
		[HttpPost("register")]
		public async Task<IActionResult> RegisterUser([FromBody] UserForRegisterDto userForRegistration)
		{
			return StatusCode(201);
		}

		[HttpPost("login")]
		public async Task<IActionResult> Authenticate([FromBody] UserForLoginDto user)
		{
			return Ok("tokenDto");
		}
	}
}
