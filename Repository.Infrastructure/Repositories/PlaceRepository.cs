using Contracts.Domain.Repositories;
using Entities.Domain.Google;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Repository.Infrastructure.Extensions;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Infrastructure.Repositories
{
	public class PlaceRepository : RepositoryBase<Place>, IPlaceRepository
	{

		public PlaceRepository(RepositoryContext context) : base(context)
		{

		}

		public void InsertManyPlaces(IEnumerable<Place> places) => InsertMany(places);

		public void CreatePlace(Place place) => Create(place);

		public void DeletePlace(Place place) => Delete(place);

		public async Task<IEnumerable<Place>> GetPlacesAsync(bool trackChanges)
		{
			return await GetAll(trackChanges).ToListAsync();
		}

		public async Task<IEnumerable<Place>> GetPlacesWithParametersAsync(PlaceParameters parameters, bool trackChanges)
		{
			//x.Types.Any(type => parameters.Categories.Contains(type)
			var baseQuery =
				parameters.Categories.IsNullOrEmpty() ?
				FindByCond((x) => true, trackChanges) : FindByCond((x) => x.Types.Any(type => parameters.Categories.Contains(type)), trackChanges);

			var result = await baseQuery.Search(parameters.SearchTerm).ToListAsync();

			return result;
		}

		public void UpdatePlace(Place place)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<string>> GetPlacesIdsAsync()
		{
			var result = await _context.Places.Select(x => x.Id).AsNoTracking().ToListAsync();
			if (result is null) return Enumerable.Empty<string>();
			else return result;
		}

		public async Task<Place> GetPlaceByIdAsync(string placeId, bool trackChanges)
		{
			return await (trackChanges ? _context.Places.FirstAsync(x => x.Id == placeId) : _context.Places.AsNoTracking().FirstAsync(x => x.Id == placeId));
		}
	}
}
