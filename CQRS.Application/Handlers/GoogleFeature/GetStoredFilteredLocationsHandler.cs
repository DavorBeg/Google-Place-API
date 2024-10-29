using AutoMapper;
using Contracts.Domain;
using Contracts.Domain.Services;
using CQRS.Application.Commands.GoogleFeature;
using Exceptions.Domain;
using MediatR;
using Shared.DTOs.Google;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Handlers.GoogleFeature
{
	public class GetStoredFilteredLocationsHandler : IRequestHandler<GetStoredFilteredLocationsCommand, IEnumerable<PlaceDto>>
	{
		private readonly IRepositoryManager _repositoryManager;
		private readonly IUserAccessor _userAccessor;
		private readonly IMapper _mapper;

        public GetStoredFilteredLocationsHandler(IRepositoryManager repositoryManager, IUserAccessor userAccessor, IMapper mapper)
        {
            _userAccessor = userAccessor;
			_repositoryManager = repositoryManager;	
			_mapper = mapper;
        }
        public async Task<IEnumerable<PlaceDto>> Handle(GetStoredFilteredLocationsCommand request, CancellationToken cancellationToken)
		{
			Debug.WriteLine("Called once");
			var result = await _repositoryManager.Place.GetPlacesWithParametersAsync(request.parameters, false);
			if (result is null) throw new PlacesNotFoundException();
			else
			{
				var mappedResult = _mapper.Map<IEnumerable<PlaceDto>>(result);
				return mappedResult;
			}

		}
	}
}
