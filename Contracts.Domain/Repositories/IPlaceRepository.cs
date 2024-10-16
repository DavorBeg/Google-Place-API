using Entities.Domain.Google;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Domain.Repositories
{
    public interface IPlaceRepository<T> : IRepository<T> where T : Place
    {
        Task<IEnumerable<Place>> GetPlacesWithParameters(PlaceParameters parameters, bool trackChanges);
    }
}
