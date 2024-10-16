using AutoMapper;
using ConfigurationModels.Domain;
using Contracts.Domain.Services;
using Entities.Domain.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Shared.DTOs.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Exceptions.Domain;
using Microsoft.AspNetCore.Http;

namespace Services.Application
{
	public class AuthenticationService : IAuthenticationService
	{
		private readonly IMapper _mapper;
		private readonly ILoggerManager _logger;
		private readonly IOptions<JwtConfiguration> _jwtConfiguration;
		private readonly UserManager<User> _userManager;

		private User? _user;

        public AuthenticationService(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IOptions<JwtConfiguration> jwtConfiguration)
        {
			_logger = logger;
			_mapper = mapper;
			_userManager = userManager;
			_jwtConfiguration = jwtConfiguration;
		}

        public async Task<TokenDto> CreateToken()
		{
			var signingCredentials = GetSigningCredentials();
			var claims = await GetClaims();
			var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

			var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
			return new TokenDto(accessToken);
		}

		public async Task<IdentityResult> RegisterUser(UserForRegisterDto userForRegistration)
		{
			if (string.Equals(userForRegistration.password, userForRegistration.rPassword, StringComparison.Ordinal) == false) throw new PasswordNotMatchedException();

			var user = _mapper.Map<User>(userForRegistration);

			var result = await _userManager.CreateAsync(user, userForRegistration.password);
			if (result.Succeeded)
			{
				_logger.LogInfo($"New user registered with name: {user.UserName}");
				await _userManager.AddToRolesAsync(user, new[] { "User" });
			}
			
			return result;
		}

		public async Task<bool> ValidateUser(UserForLoginDto userForAuthentication, HttpContext request)
		{
			_user = await _userManager.FindByNameAsync(userForAuthentication.username);
			if(_user == null) { throw new UserNotFound(); }
			var result = await _userManager.CheckPasswordAsync(_user, userForAuthentication.password);

			if(!result) {
				var ipAddress = request.Connection.RemoteIpAddress.ToString();
				_logger.LogWarn($"Someone tried to login as ${userForAuthentication.username} from IP: ${ipAddress}"); 
			}
			return result;

		}

		#region Private_methods

		private SigningCredentials GetSigningCredentials()
		{
			var key = Encoding.UTF8.GetBytes(_jwtConfiguration.Value.Secret ?? throw new NullReferenceException("Secret is not configured. Value null returned."));
			var secret = new SymmetricSecurityKey(key);
			return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
		}
		private async Task<List<Claim>> GetClaims()
		{
			var claims = new List<Claim>
			{
				new Claim(ClaimTypes.Name, _user?.UserName ?? throw new NullReferenceException("User or user name is null reference!"))
			};
			var roles = await _userManager.GetRolesAsync(_user);
			foreach (var role in roles)
			{
				claims.Add(new Claim(ClaimTypes.Role, role));
			}
			return claims;
		}
		private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
		{
			var tokenOptions =
				new JwtSecurityToken(
				issuer: _jwtConfiguration.Value.ValidIssuer,
				audience: _jwtConfiguration.Value.ValidAudience,
				claims: claims,
				expires: DateTime.Now.AddMinutes((Convert.ToDouble(_jwtConfiguration.Value.Expires))),
				signingCredentials: signingCredentials);

			return tokenOptions;
		}
		#endregion
	}
}
