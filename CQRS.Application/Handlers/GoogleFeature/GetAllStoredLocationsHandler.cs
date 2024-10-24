using AutoMapper;
using Contracts.Domain;
using CQRS.Application.Commands.GoogleFeature;
using Entities.Domain.Google;
using MediatR;
using Shared.DTOs.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Handlers.GoogleFeature
{
	public class GetAllStoredLocationsHandler : IRequestHandler<GetAllStoredLocationsCommand, IEnumerable<PlaceDto>>
	{
		private readonly IRepositoryManager _repositoryManager;
		private readonly IMapper _mapper; 

        public GetAllStoredLocationsHandler(IRepositoryManager repositoryManager, IMapper mapper)
        {
			_repositoryManager = repositoryManager;
			_mapper = mapper;


		}
        public async Task<IEnumerable<PlaceDto>> Handle(GetAllStoredLocationsCommand request, CancellationToken cancellationToken)
		{
			var result = await _repositoryManager.Place.GetPlacesAsync(false);
			var mapped = _mapper.Map<IEnumerable<PlaceDto>>(result);
			return mapped;
		}
	}
}
