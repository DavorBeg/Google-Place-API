﻿using Contracts.Domain.Services;
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
	public class ValidateUserHandler : IRequestHandler<ValidateUserCommand, TokenDto>
	{

		private readonly IAuthenticationService _authentication;
		private readonly ILoggerManager _logger;
		public ValidateUserHandler(IAuthenticationService authentication, ILoggerManager logger)
		{
			_authentication = authentication;
			_logger = logger;
		}

		public async Task<TokenDto> Handle(ValidateUserCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var result = await _authentication.ValidateUserAsync(request.User, request.httpContext);
				if (result)
				{
					var token = await _authentication.CreateTokenAsync();
					return token;
				}
				else throw new UnauthorizedAccessException();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex.Message);
				throw;
			}
		}
	}
}
