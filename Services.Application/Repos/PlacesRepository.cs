using Contracts.Domain.Repositories;
using Entities.Domain.Google;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Application.Repos
{
	public class PlacesRepository : IPlaceRepository<Place>
	{
		public void Create(Place entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Place entity)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Place>> GetAllAsync(bool trackChanges)
		{
			throw new NotImplementedException();
		}

		public Task<Place> GetById(string id, bool trackChanges)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Place>> GetPlacesWithParameters(PlaceParameters parameters, bool trackChanges)
		{
			throw new NotImplementedException();
		}

		public void Update(Place entity)
		{
			throw new NotImplementedException();
		}
	}
}
