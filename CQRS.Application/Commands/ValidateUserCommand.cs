using MediatR;
using Microsoft.AspNetCore.Http;
using Shared.DTOs.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Commands
{
	public sealed record ValidateUserCommand : IRequest<TokenDto>
	{
		public UserForLoginDto User { get; init; } = null!;
		public HttpContext httpContext { get; init; } = null!;
	}
}
