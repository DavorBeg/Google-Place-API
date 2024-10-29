using Entities.Domain.Google;
using Shared.DTOs.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.FavoriteFeature
{
	public record FavoritePlaceDto
	{
		public PlaceDto Place { get; init; } = null!;
		public DateTime CreatedAt { get; init; }
	}
}
