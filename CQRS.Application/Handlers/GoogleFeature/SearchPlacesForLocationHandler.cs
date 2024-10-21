using CQRS.Application.Commands.GoogleFeature;
using MediatR;
using Shared.DTOs.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Handlers.GoogleFeature
{
	public class SearchPlacesForLocationHandler : IRequestHandler<SearchPlacesForLocationCommand, GooglePlaceDTO>
	{
		public Task<GooglePlaceDTO> Handle(SearchPlacesForLocationCommand request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
