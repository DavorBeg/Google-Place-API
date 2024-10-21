using MediatR;
using Shared.DTOs.Authentication;

namespace CQRS.Application.Commands
{
	public sealed record RegisterUserCommand(UserForRegisterDto user) : IRequest<RegisteredDto>;
}
