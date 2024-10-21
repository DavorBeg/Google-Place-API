using Contracts.Domain;
using Contracts.Domain.Services;
using CQRS.Application.Commands;
using Exceptions.Domain;
using MediatR;
using System.Security.Claims;

namespace CQRS.Application.Handlers
{
	public class UpdatedApiKeyHandler : IRequestHandler<UpdateApiKeyCommand, string>
	{
		public readonly IAuthenticationService _authenticationService;


		public UpdatedApiKeyHandler(IAuthenticationService authenticationService)
        {
			_authenticationService = authenticationService;
        }

        public async Task<string> Handle(UpdateApiKeyCommand request, CancellationToken cancellationToken)
		{
			var userId = request.user.Claims.FirstOrDefault(x => x.Type.Equals(ClaimTypes.NameIdentifier, StringComparison.OrdinalIgnoreCase))?.Value;
			var newApiKey = await _authenticationService.UpdateUserApiKey(userId ?? throw new UserNotFoundException(), request.insertedKey);
			return newApiKey;
		}
	}
}
