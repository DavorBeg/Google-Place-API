using Contracts.Domain;
using Contracts.Domain.Services;
using CQRS.Application.Commands.GoogleFeature;
using Exceptions.Domain;
using MediatR;
using Shared.DTOs.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Handlers.GoogleFeature
{
	public class SearchPlacesForLocationHandler : IRequestHandler<SearchPlacesForLocationCommand, GooglePlaceDTO>
	{
		private readonly IGoogleService _googleService;
		private readonly IRepositoryManager _repositoryManager;
		
        public SearchPlacesForLocationHandler(IGoogleService googleService, IRepositoryManager repositoryManager)
        {
            _googleService = googleService;
			_repositoryManager = repositoryManager;
        }
        public async Task<GooglePlaceDTO> Handle(SearchPlacesForLocationCommand request, CancellationToken cancellationToken)
		{
			var id = request.user?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new UserNotFoundException();
			var user = await _repositoryManager.User.GetUserById(Guid.Parse(id)) ?? throw new UserNotFoundException();
			var apiKey = string.IsNullOrEmpty(user.UserAPIKey) ? throw new InvalidApiKeyException() : user.UserAPIKey;

			var result = await _googleService.SearchLocation(request.searchParams, apiKey) ?? throw new PlacesNotFoundException();
			return result;
		}
	}
}
