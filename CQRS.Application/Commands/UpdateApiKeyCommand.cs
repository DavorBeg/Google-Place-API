using MediatR;
using Shared.DTOs.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Commands
{
	public record UpdateApiKeyCommand(ClaimsPrincipal user, UserAPIKeyForUpdateDto insertedKey) : IRequest<string>;
}
