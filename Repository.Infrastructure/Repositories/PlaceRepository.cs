using Contracts.Domain.Repositories;
using Entities.Domain.Google;
using Microsoft.EntityFrameworkCore;
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
			var result = await FindByCond(x => x.Types.Any(type => parameters.Categories.Contains(type)), trackChanges).ToListAsync();
			return result;
		}

		public void UpdatePlace(Place place)
		{
			
		}

		public async Task<IEnumerable<string>> GetPlacesIdsAsync()
		{
			var result = await _context.Places.Select(x => x.Id).AsNoTracking().ToListAsync();
			if (result is null) return Enumerable.Empty<string>();
			else return result;
		}
	}
}
