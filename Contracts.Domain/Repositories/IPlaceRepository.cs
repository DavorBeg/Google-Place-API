using Entities.Domain.Google;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Domain.Repositories
{
    public interface IPlaceRepository
    {
        Task<IEnumerable<Place>> GetPlacesWithParametersAsync(PlaceParameters parameters, bool trackChanges);
        Task<IEnumerable<Place>> GetPlacesAsync(bool trackChanges);

        void CreatePlace(Place place);
        void UpdatePlace(Place place);
        void DeletePlace(Place place);

    }
}
