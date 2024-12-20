﻿using MediatR;
using Shared.DTOs.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Commands.GoogleFeature
{
	public record SearchPlacesForLocationCommand(ClaimsPrincipal user, RequestPlaceDTO searchParams) : IRequest<GooglePlaceDTO>;

}
