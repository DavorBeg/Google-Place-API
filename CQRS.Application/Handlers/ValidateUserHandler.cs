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
		public Task<TokenDto> Handle(ValidateUserCommand request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
