﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Shared.DTOs.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Commands
{
	public sealed record ValidateUserCommand(UserForLoginDto User, HttpContext httpContext) : IRequest<TokenDto>;

}
