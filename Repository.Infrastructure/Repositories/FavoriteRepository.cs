using Contracts.Domain.Repositories;
using Entities.Domain.Favorite;
using Entities.Domain.Google;
using Exceptions.Domain;
using Microsoft.EntityFrameworkCore;
using Shared.DTOs.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Infrastructure.Repositories
{
	public class FavoriteRepository : RepositoryBase<FavoritePlace>, IFavoriteRepository
	{
        public FavoriteRepository(RepositoryContext context) : base(context)
		{
            
        }

        public async Task<FavoritePlace> CreateFavoriteLocationForUserAsync(string userId, string placeId)
		{
			var place = await _context.Places.Where(x => x.Id == placeId).FirstOrDefaultAsync();
			var user = await _context.Users.Where(x => x.Id == userId).FirstOrDefaultAsync();
			if (place is null) throw new PlacesNotFoundException($"Place with ID: {placeId} was not found.");
			if (user is null) throw new UserNotFoundException($"User with ID: {userId} was not found.");

			var alreadyExist = _context.FavoritePlaces.Any(x => x.UserId.ToString() == userId && x.GooglePlaceId == placeId);
			if (alreadyExist) throw new FavoritePlaceConflictException();

			var result = 
			new FavoritePlace()
			{
				UserId = Guid.Parse(user.Id),
				PlaceId = place.PlaceId,
				Types = place.Types,
				CreatedAt = DateTime.Now,
				GooglePlaceId = place.Id
			};

			base.Create(result);
			return result;
		}

		public async Task<IEnumerable<FavoritePlace>> GetAllFavoritePlacesForUserAsync(string userId, bool trackChanges)
		{
			var result = trackChanges ? 
				await _context.FavoritePlaces.Where(x => x.UserId.ToString() == userId).Include(x => x.Place).ToListAsync() :
				await _context.FavoritePlaces.Where(x => x.UserId.ToString() == userId).Include(x => x.Place).AsNoTracking().ToListAsync();

			if (result is null) throw new PlacesNotFoundException();
			return result;
		}

		public async Task<FavoritePlace> GetFavoriteLocationForUserAsync(string userId, string placeId, bool trackChanges)
		{
			var result = trackChanges ?
				await _context.FavoritePlaces.Where(x => x.UserId.ToString() == userId).Include(x => x.Place).FirstOrDefaultAsync(x => x.GooglePlaceId.ToString() == placeId) :
				await _context.FavoritePlaces.Where(x => x.UserId.ToString() == userId).Include(x => x.Place).AsNoTracking().FirstOrDefaultAsync(x => x.GooglePlaceId.ToString() == placeId);

			if(result is null) throw new PlacesNotFoundException($"Place with ID: {placeId} was not found.");
			return result;
		}
	}
}
