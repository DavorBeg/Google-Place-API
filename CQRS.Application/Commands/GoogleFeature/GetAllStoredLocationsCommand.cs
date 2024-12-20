﻿using Contracts.Domain;
using Entities.Domain.Google;
using MediatR;
using Shared.DTOs.Google;
using System.Security.Claims;


namespace CQRS.Application.Commands.GoogleFeature
{
	public record GetAllStoredLocationsCommand(ClaimsPrincipal user) : IRequest<IEnumerable<PlaceDto>>, ICacheableCommand
	{
		public string CacheKey { get; set; } = "allStoredLocations";
	}
}
