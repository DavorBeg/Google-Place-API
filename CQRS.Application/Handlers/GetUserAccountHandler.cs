using Contracts.Domain.Services;
using CQRS.Application.Commands;
using Exceptions.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Shared.DTOs.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Handlers
{
	public class GetUserAccountHandler : IRequestHandler<GetUserAccountCommand, UserProfileDto>
	{
		private readonly IAuthenticationService _authenticationService;

        public GetUserAccountHandler(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        public async Task<UserProfileDto> Handle(GetUserAccountCommand request, CancellationToken cancellationToken)
		{
			var userId = request.user.Claims.FirstOrDefault(x => x.Type.Equals(ClaimTypes.NameIdentifier, StringComparison.OrdinalIgnoreCase))?.Value;
			var user = await _authenticationService.GetCurrentUserProfileAsync(userId ?? throw new UserNotFoundException());
			return user;
		}
	}
}
