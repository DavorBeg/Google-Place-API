using Entities.Domain.Google;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Commands.FavoriteFeature
{
	public record GetUserFavoritePlaceCommand(ClaimsPrincipal User, string placeId) : IRequest<Place>;
}
