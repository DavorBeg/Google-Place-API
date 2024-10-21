using Contracts.Domain.Services;
using CQRS.Application.Commands;
using MediatR;
using Shared.DTOs.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Handlers
{
	public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, RegisteredDto>
	{
		private readonly IAuthenticationService _authentication;
		private readonly ILoggerManager _logger;
		public RegisterUserHandler(IAuthenticationService authentication, ILoggerManager logger) 
		{ 
			_authentication = authentication;
			_logger = logger;
		}


		public async Task<RegisteredDto> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var result = await _authentication.RegisterUserAsync(request.user);
				return new RegisteredDto(result.Succeeded, result.Errors.Select(x => x.Description).ToArray());
			}
			catch (Exception ex)
			{
				_logger.LogError(ex.Message);
				throw;
			}
		}
	}
}
