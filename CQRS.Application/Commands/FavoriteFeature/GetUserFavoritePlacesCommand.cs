using MediatR;
using Shared.DTOs.FavoriteFeature;
using Shared.DTOs.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Commands.FavoriteFeature
{
	public record GetUserFavoritePlacesCommand() : IRequest<IEnumerable<FavoritePlaceDto>>;

}
