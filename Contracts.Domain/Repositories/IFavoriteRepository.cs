using Entities.Domain.Favorite;
using Entities.Domain.Google;
using Shared.DTOs.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Domain.Repositories
{
	public interface IFavoriteRepository
	{
		public Task<FavoritePlace> CreateFavoriteLocationForUserAsync(string userId, string placeId);
		public Task<IEnumerable<FavoritePlace>> GetAllFavoritePlacesForUserAsync(string userId, bool trackChanges);
		public Task<FavoritePlace> GetFavoriteLocationForUserAsync(string userId, string placeId, bool trackChanges);
	}
}
