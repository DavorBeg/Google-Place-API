using Entities.Domain.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Infrastructure.Extensions
{
	public static class PlaceExtensions
	{
		//public static IQueryable<Place> FilterPlaces(this IQueryable<Place> places, IEnumerable<string> categories) =>
		//	places.Where(x => x.Types.Any(type => categories.Contains(type)));

		/// <summary>
		/// Extension method that takes search string and check it with places name property.
		/// </summary>
		/// <param name="places"></param>
		/// <param name="searchTerm"></param>
		/// <returns></returns>
		public static IQueryable<Place> Search(this IQueryable<Place> places, string searchTerm)
		{
			if (string.IsNullOrWhiteSpace(searchTerm))
				return places;

			var lowerCaseTerm = searchTerm.Trim().ToLower();
			return places.Where(e => e.Name!.ToLower().Contains(lowerCaseTerm));
		}

	}
}
