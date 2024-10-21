using MediatR;
using Shared.DTOs.FavoriteFeature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Notifications.FavoriteFeature
{
	public record UserFavoritePlaceDeletedNotification(string placeId) : INotification;
}
